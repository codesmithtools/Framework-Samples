﻿Imports NHibernate.Criterion
Imports Sample.Data.Generated.ManagerObjects
Imports Sample.Data.Generated.BusinessObjects
Imports Sample.Data.Generated.Base

Module Module1

    Sub Main()

        Try

            ' The IManagerFactory will take care of creating manager objects for you.
            Dim managerFactory As IManagerFactory = New ManagerFactory()

            ' By default, all managers running on the same thread will share the same session.
            ' It is strongly recommended that you dispose your managers when you are done with them,
            ' this will allow unused ISessions to be closed in a timely manner.
            Using categoryManager As ICategoryManager = managerFactory.GetCategoryManager()

                ' Create a new category
                Dim categoryA As New Category()
                categoryA.Id = "TEST1"
                categoryA.Name = "Test 1"
                categoryA.Descn = "Hello world!"

                ' Save the category. This will add it to the database as a new row on the next commit changes.
                categoryManager.Save(categoryA)
                ' Commit changes to the database.
                categoryManager.Session.CommitChanges()
                ' The category should now be in the database.

                ' Update the entity.
                categoryA.Descn = "I changed!"
                ' Commit changes to the database.
                categoryManager.Session.CommitChanges()
                ' Notice that the changes were tracked and committed.

                ' Get a new instance of the same category, this time with GetById.
                Dim categoryB As Category = categoryManager.GetById(categoryA.Id)
                ' Update it's description.
                categoryB.Descn = "Good night moon!"
                ' Commit changes to the database.
                categoryManager.Session.CommitChanges()
                ' Notice that this time changes were made.

                ' Refresh the original category entity.
                categoryManager.Refresh(categoryA)
                ' Notice that the category description is now "Good night moon!".

                ' ------------------------------------------------------------------------------------
                ' If we want to have multiple sessions open at one time we can explicedly create them.

                ' Create the new session.
                Dim session2 As INHibernateSession = New NHibernateSession()
                ' Pass that new session into the managerFactory to create a manager that will use that session.
                Using categoryManager2 As ICategoryManager = managerFactory.GetCategoryManager(session2)

                    ' Create another category.
                    Dim category2 As New Category()
                    category2.Id = "TEST2"
                    category2.Name = "Test 2"
                    category2.Descn = "Same DB, same thread, different session."

                    ' Save category2 to the second manager.
                    categoryManager2.Save(category2)
                    ' Commit changes with the first manager.
                    categoryManager.Session.CommitChanges()
                    ' Notice the category was not inserted. Now submit changes with categoryManager2.
                    categoryManager2.Session.CommitChanges()
                    ' Notice that the changes have now been submitted.

                    ' ------------------------------------------------------------------------------------
                    ' Examples of how to search for results.

                    ' GetByExample
                    Dim example As New Category()
                    example.Name = "Test 1"
                    Dim categoriesFromExample As IList(Of Category) = categoryManager2.GetByExample(example, "Descn")

                    ' GetByCriteria
                    Dim criterion As SimpleExpression = Expression.[Like]("Name", "Test", MatchMode.Start)
                    Dim categoriesFromCriteria As IList(Of Category) = categoryManager2.GetByCriteria(criterion)

                    ' GetByQuery
                    Dim categoriesFromQuery As IList(Of Category) = categoryManager2.GetByQuery("select c from Category c where c.Name = 'Endangered' or c.Name = 'Fish'")
                    Dim uniqueCategoryQuery As Category = categoryManager2.GetUniqueByQuery("select c from Category c where c.Id = 'BYARD'")

                    ' ------------------------------------------------------------------------------------
                    ' Clean up our DB and delete the entries we just made.

                    ' Delete categoryA
                    categoryManager.Delete(categoryA)
                    ' Commit changes to the database.
                    categoryManager.Session.CommitChanges()
                    ' Notice that it has been deleted.

                    ' We could delete category2 with categoryManager2, but for example lets use categoryManager instead.
                    ' Evict/Detach category2 from categoryManager2.
                    categoryManager2.Evict(category2)
                    ' Now Attach category2 to categoryManager.
                    categoryManager.Update(category2)

                    ' Delete category2 using categoryManager
                    categoryManager.Delete(category2)
                    ' Commit changes to the database.
                    categoryManager.Session.CommitChanges()
                    ' Notice that it has been deleted.

                End Using

            End Using

            ' ---------------------------------------------------------------------------------------------
            ' If we want to eager load associations we can just use the SetFetchMode method on the manager.

            Using categoryManager As ICategoryManager = managerFactory.GetCategoryManager()
                ' This will load Products on the Categories.
                categoryManager.SetFetchMode("Products", NHibernate.FetchMode.Eager)
                ' This will load Items on the Products.
                categoryManager.SetFetchMode("Products.Items", NHibernate.FetchMode.Eager)

                ' This makes a single database call.
                Dim eagerResult As IList(Of Category) = categoryManager.GetAll()

                ' These read from pre-loaded collections and make no more database calls.
                Dim eagerCategory As Category = eagerResult(0)
                Dim eagerProduct As Product = eagerCategory.Products(0)
                Dim eagerItem As Item = eagerProduct.Items(0)
            End Using

        Catch ex As Exception

            System.Console.WriteLine(ex.Message)
            System.Console.ReadLine()

        End Try

    End Sub

End Module
