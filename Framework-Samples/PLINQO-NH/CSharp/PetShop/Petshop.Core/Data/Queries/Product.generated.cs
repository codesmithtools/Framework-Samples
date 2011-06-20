﻿#pragma warning disable 1591
// <auto-generated>
//     This code was generated from a CodeSmith Generator template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;

namespace Petshop.Data
{
    /// <summary>
    /// The query extension class for Product.
    /// </summary>
    public static partial class ProductExtensions
    {
        #region Unique Results
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Petshop.Data.Entities.Product GetByKey(this IQueryable<Petshop.Data.Entities.Product> queryable
            , System.String productId
            )
        {
            return queryable
                .Where(p => p.ProductId == productId)
                .FirstOrDefault();
        }
        
        #endregion
        
        #region By Property
        

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.ProductId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="productId">ProductId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByProductId(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String productId)
        {
            return queryable.Where(p => p.ProductId == productId);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.ProductId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="productId">ProductId to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByProductId(this IQueryable<Petshop.Data.Entities.Product> queryable, ContainmentOperator containmentOperator, System.String productId)
        {
            if (productId == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("productId", "Parameter 'productId' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(p => p.ProductId.Contains(productId));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(p => p.ProductId.StartsWith(productId));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(p => p.ProductId.EndsWith(productId));
                case ContainmentOperator.NotContains:
                    return queryable.Where(p => p.ProductId.Contains(productId) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(p => p.ProductId != productId);
                default:
                    return queryable.Where(p => p.ProductId == productId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.ProductId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="productId">ProductId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByProductId(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String productId, params System.String[] additionalValues)
        {
            var productIdList = new List<System.String> { productId };

            if (additionalValues != null)
                productIdList.AddRange(additionalValues);

            if (productIdList.Count == 1)
                return queryable.ByProductId(productIdList[0]);

            return queryable.ByProductId(productIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.ProductId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByProductId(this IQueryable<Petshop.Data.Entities.Product> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(p => values.Contains(p.ProductId));
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByName(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String name)
        {
            // support nulls
            return name == null 
                ? queryable.Where(p => p.Name == null) 
                : queryable.Where(p => p.Name == name);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByName(this IQueryable<Petshop.Data.Entities.Product> queryable, ContainmentOperator containmentOperator, System.String name)
        {
            if (name == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("name", "Parameter 'name' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(p => p.Name.Contains(name));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(p => p.Name.StartsWith(name));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(p => p.Name.EndsWith(name));
                case ContainmentOperator.NotContains:
                    return queryable.Where(p => p.Name.Contains(name) == false);
                case ContainmentOperator.NotEquals:
                    return name == null 
                        ? queryable.Where(p => p.Name != null) 
                        : queryable.Where(p => p.Name != name);
                default:
                    return name == null 
                        ? queryable.Where(p => p.Name == null) 
                        : queryable.Where(p => p.Name == name);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByName(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String name, params System.String[] additionalValues)
        {
            var nameList = new List<System.String> { name };

            if (additionalValues != null)
                nameList.AddRange(additionalValues);
            else
                nameList.Add(null);

            if (nameList.Count == 1)
                return queryable.ByName(nameList[0]);

            return queryable.ByName(nameList);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByName(this IQueryable<Petshop.Data.Entities.Product> queryable, IEnumerable<System.String> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Petshop.Data.Entities.Product, bool>("Name", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Descn"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Descn to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByDescn(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String description)
        {
            // support nulls
            return description == null 
                ? queryable.Where(p => p.Descn == null) 
                : queryable.Where(p => p.Descn == description);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Descn"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Descn to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByDescn(this IQueryable<Petshop.Data.Entities.Product> queryable, ContainmentOperator containmentOperator, System.String description)
        {
            if (description == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("description", "Parameter 'description' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(p => p.Descn.Contains(description));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(p => p.Descn.StartsWith(description));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(p => p.Descn.EndsWith(description));
                case ContainmentOperator.NotContains:
                    return queryable.Where(p => p.Descn.Contains(description) == false);
                case ContainmentOperator.NotEquals:
                    return description == null 
                        ? queryable.Where(p => p.Descn != null) 
                        : queryable.Where(p => p.Descn != description);
                default:
                    return description == null 
                        ? queryable.Where(p => p.Descn == null) 
                        : queryable.Where(p => p.Descn == description);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Descn"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Descn to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByDescn(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String description, params System.String[] additionalValues)
        {
            var descriptionList = new List<System.String> { description };

            if (additionalValues != null)
                descriptionList.AddRange(additionalValues);
            else
                descriptionList.Add(null);

            if (descriptionList.Count == 1)
                return queryable.ByDescn(descriptionList[0]);

            return queryable.ByDescn(descriptionList);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Descn"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByDescn(this IQueryable<Petshop.Data.Entities.Product> queryable, IEnumerable<System.String> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Petshop.Data.Entities.Product, bool>("Descn", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Image"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="image">Image to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByImage(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String image)
        {
            // support nulls
            return image == null 
                ? queryable.Where(p => p.Image == null) 
                : queryable.Where(p => p.Image == image);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Image"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="image">Image to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByImage(this IQueryable<Petshop.Data.Entities.Product> queryable, ContainmentOperator containmentOperator, System.String image)
        {
            if (image == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("image", "Parameter 'image' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(p => p.Image.Contains(image));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(p => p.Image.StartsWith(image));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(p => p.Image.EndsWith(image));
                case ContainmentOperator.NotContains:
                    return queryable.Where(p => p.Image.Contains(image) == false);
                case ContainmentOperator.NotEquals:
                    return image == null 
                        ? queryable.Where(p => p.Image != null) 
                        : queryable.Where(p => p.Image != image);
                default:
                    return image == null 
                        ? queryable.Where(p => p.Image == null) 
                        : queryable.Where(p => p.Image == image);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Image"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="image">Image to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByImage(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String image, params System.String[] additionalValues)
        {
            var imageList = new List<System.String> { image };

            if (additionalValues != null)
                imageList.AddRange(additionalValues);
            else
                imageList.Add(null);

            if (imageList.Count == 1)
                return queryable.ByImage(imageList[0]);

            return queryable.ByImage(imageList);
        }

        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product.Image"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByImage(this IQueryable<Petshop.Data.Entities.Product> queryable, IEnumerable<System.String> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Petshop.Data.Entities.Product, bool>("Image", values);
            return queryable.Where(expression);
        }
    
        #endregion
        
        #region By Association
        
        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product by Category's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="category">Category to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByCategory(this IQueryable<Petshop.Data.Entities.Product> queryable, Petshop.Data.Entities.Category category)
        {
            return queryable.ByCategory(ComparisonOperator.Equals, category);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product by Category's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="category">Category to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByCategory(this IQueryable<Petshop.Data.Entities.Product> queryable, ComparisonOperator comparisonOperator, Petshop.Data.Entities.Category category)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(p => p.Category == category);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Category != category);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product by Category's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="categoryId">CategoryId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByCategory(this IQueryable<Petshop.Data.Entities.Product> queryable, System.String categoryId)
        {
            return queryable.ByCategory(ComparisonOperator.Equals, categoryId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Petshop.Data.Entities.Product by Category's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="categoryId">CategoryId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Petshop.Data.Entities.Product> ByCategory(this IQueryable<Petshop.Data.Entities.Product> queryable, ComparisonOperator comparisonOperator, System.String categoryId)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(p => p.Category.CategoryId == categoryId);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Category.CategoryId != categoryId);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        #endregion
    }
}
#pragma warning restore 1591

