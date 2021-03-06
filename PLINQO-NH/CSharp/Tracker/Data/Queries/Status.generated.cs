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

namespace Tracker.Data
{
    /// <summary>
    /// The query extension class for Status.
    /// </summary>
    public static partial class StatusExtensions
    {
        #region Unique Results
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Tracker.Data.Entities.Status GetByKey(this IQueryable<Tracker.Data.Entities.Status> queryable
            , System.Int32 id
            )
        {
            return queryable
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }
        
        #endregion
        
        #region By Property
        

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ById(this IQueryable<Tracker.Data.Entities.Status> queryable, System.Int32 id)
        {
            return queryable.Where(s => s.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ById(this IQueryable<Tracker.Data.Entities.Status> queryable, ComparisonOperator comparisonOperator, System.Int32 id)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(s => s.Id > id);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(s => s.Id >= id);
                case ComparisonOperator.LessThan:
                    return queryable.Where(s => s.Id < id);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(s => s.Id <= id);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(s => s.Id != id);
                default:
                    return queryable.Where(s => s.Id == id);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ById(this IQueryable<Tracker.Data.Entities.Status> queryable, System.Int32 id, params System.Int32[] additionalValues)
        {
            var idList = new List<System.Int32> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ById(this IQueryable<Tracker.Data.Entities.Status> queryable, IEnumerable<System.Int32> values)
        {
            return queryable.Where(s => values.Contains(s.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByName(this IQueryable<Tracker.Data.Entities.Status> queryable, System.String name)
        {
            return queryable.Where(s => s.Name == name);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByName(this IQueryable<Tracker.Data.Entities.Status> queryable, ContainmentOperator containmentOperator, System.String name)
        {
            if (name == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("name", "Parameter 'name' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(s => s.Name.Contains(name));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(s => s.Name.StartsWith(name));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(s => s.Name.EndsWith(name));
                case ContainmentOperator.NotContains:
                    return queryable.Where(s => s.Name.Contains(name) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(s => s.Name != name);
                default:
                    return queryable.Where(s => s.Name == name);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByName(this IQueryable<Tracker.Data.Entities.Status> queryable, System.String name, params System.String[] additionalValues)
        {
            var nameList = new List<System.String> { name };

            if (additionalValues != null)
                nameList.AddRange(additionalValues);

            if (nameList.Count == 1)
                return queryable.ByName(nameList[0]);

            return queryable.ByName(nameList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByName(this IQueryable<Tracker.Data.Entities.Status> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(s => values.Contains(s.Name));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Description"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Description to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByDescription(this IQueryable<Tracker.Data.Entities.Status> queryable, System.String description)
        {
            // support nulls
            return description == null 
                ? queryable.Where(s => s.Description == null) 
                : queryable.Where(s => s.Description == description);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Description"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Description to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByDescription(this IQueryable<Tracker.Data.Entities.Status> queryable, ContainmentOperator containmentOperator, System.String description)
        {
            if (description == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("description", "Parameter 'description' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(s => s.Description.Contains(description));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(s => s.Description.StartsWith(description));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(s => s.Description.EndsWith(description));
                case ContainmentOperator.NotContains:
                    return queryable.Where(s => s.Description.Contains(description) == false);
                case ContainmentOperator.NotEquals:
                    return description == null 
                        ? queryable.Where(s => s.Description != null) 
                        : queryable.Where(s => s.Description != description);
                default:
                    return description == null 
                        ? queryable.Where(s => s.Description == null) 
                        : queryable.Where(s => s.Description == description);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Description"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Description to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByDescription(this IQueryable<Tracker.Data.Entities.Status> queryable, System.String description, params System.String[] additionalValues)
        {
            var descriptionList = new List<System.String> { description };

            if (additionalValues != null)
                descriptionList.AddRange(additionalValues);
            else
                descriptionList.Add(null);

            if (descriptionList.Count == 1)
                return queryable.ByDescription(descriptionList[0]);

            return queryable.ByDescription(descriptionList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Description"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByDescription(this IQueryable<Tracker.Data.Entities.Status> queryable, IEnumerable<System.String> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Tracker.Data.Entities.Status, bool>("Description", values);
            return queryable.Where(expression);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Order"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="order">Order to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByOrder(this IQueryable<Tracker.Data.Entities.Status> queryable, System.Int32 order)
        {
            return queryable.Where(s => s.Order == order);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Order"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="order">Order to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByOrder(this IQueryable<Tracker.Data.Entities.Status> queryable, ComparisonOperator comparisonOperator, System.Int32 order)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(s => s.Order > order);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(s => s.Order >= order);
                case ComparisonOperator.LessThan:
                    return queryable.Where(s => s.Order < order);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(s => s.Order <= order);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(s => s.Order != order);
                default:
                    return queryable.Where(s => s.Order == order);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Order"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="order">Order to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByOrder(this IQueryable<Tracker.Data.Entities.Status> queryable, System.Int32 order, params System.Int32[] additionalValues)
        {
            var orderList = new List<System.Int32> { order };

            if (additionalValues != null)
                orderList.AddRange(additionalValues);

            if (orderList.Count == 1)
                return queryable.ByOrder(orderList[0]);

            return queryable.ByOrder(orderList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.Order"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByOrder(this IQueryable<Tracker.Data.Entities.Status> queryable, IEnumerable<System.Int32> values)
        {
            return queryable.Where(s => values.Contains(s.Order));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByCreatedDate(this IQueryable<Tracker.Data.Entities.Status> queryable, System.DateTime createdDate)
        {
            return queryable.Where(s => s.CreatedDate == createdDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByCreatedDate(this IQueryable<Tracker.Data.Entities.Status> queryable, ComparisonOperator comparisonOperator, System.DateTime createdDate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(s => s.CreatedDate > createdDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(s => s.CreatedDate >= createdDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(s => s.CreatedDate < createdDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(s => s.CreatedDate <= createdDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(s => s.CreatedDate != createdDate);
                default:
                    return queryable.Where(s => s.CreatedDate == createdDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByCreatedDate(this IQueryable<Tracker.Data.Entities.Status> queryable, System.DateTime createdDate, params System.DateTime[] additionalValues)
        {
            var createdDateList = new List<System.DateTime> { createdDate };

            if (additionalValues != null)
                createdDateList.AddRange(additionalValues);

            if (createdDateList.Count == 1)
                return queryable.ByCreatedDate(createdDateList[0]);

            return queryable.ByCreatedDate(createdDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByCreatedDate(this IQueryable<Tracker.Data.Entities.Status> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(s => values.Contains(s.CreatedDate));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByModifiedDate(this IQueryable<Tracker.Data.Entities.Status> queryable, System.DateTime modifiedDate)
        {
            return queryable.Where(s => s.ModifiedDate == modifiedDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByModifiedDate(this IQueryable<Tracker.Data.Entities.Status> queryable, ComparisonOperator comparisonOperator, System.DateTime modifiedDate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(s => s.ModifiedDate > modifiedDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(s => s.ModifiedDate >= modifiedDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(s => s.ModifiedDate < modifiedDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(s => s.ModifiedDate <= modifiedDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(s => s.ModifiedDate != modifiedDate);
                default:
                    return queryable.Where(s => s.ModifiedDate == modifiedDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByModifiedDate(this IQueryable<Tracker.Data.Entities.Status> queryable, System.DateTime modifiedDate, params System.DateTime[] additionalValues)
        {
            var modifiedDateList = new List<System.DateTime> { modifiedDate };

            if (additionalValues != null)
                modifiedDateList.AddRange(additionalValues);

            if (modifiedDateList.Count == 1)
                return queryable.ByModifiedDate(modifiedDateList[0]);

            return queryable.ByModifiedDate(modifiedDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Status.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Status> ByModifiedDate(this IQueryable<Tracker.Data.Entities.Status> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(s => values.Contains(s.ModifiedDate));
        }
    
        #endregion
        
        #region By Association
        
        #endregion
    }
}
#pragma warning restore 1591

