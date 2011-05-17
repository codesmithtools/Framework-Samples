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
using Plinqo.NHibernate;

namespace Tracker.Data
{
    /// <summary>
    /// The query extension class for Priority.
    /// </summary>
    public static partial class PriorityExtensions
    {
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Tracker.Data.Entities.Priority GetByKey(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.Int32 id)
        {
            return queryable.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByName(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.String name)
        {
            return queryable.Where(p => p.Name == name);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByName(this IQueryable<Tracker.Data.Entities.Priority> queryable, ContainmentOperator containmentOperator, System.String name)
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
                    return queryable.Where(p => p.Name != name);
                default:
                    return queryable.Where(p => p.Name == name);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="name">Name to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByName(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.String name, params System.String[] additionalValues)
        {
            var nameList = new List<System.String> { name };

            if (additionalValues != null)
                nameList.AddRange(additionalValues);

            if (nameList.Count == 1)
                return queryable.ByName(nameList[0]);

            return queryable.ByName(nameList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Name"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByName(this IQueryable<Tracker.Data.Entities.Priority> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(p => values.Contains(p.Name));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Order"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="order">Order to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByOrder(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.Int32 order)
        {
            return queryable.Where(p => p.Order == order);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Order"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="order">Order to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByOrder(this IQueryable<Tracker.Data.Entities.Priority> queryable, ComparisonOperator comparisonOperator, System.Int32 order)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(p => p.Order > order);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(p => p.Order >= order);
                case ComparisonOperator.LessThan:
                    return queryable.Where(p => p.Order < order);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(p => p.Order <= order);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.Order != order);
                default:
                    return queryable.Where(p => p.Order == order);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Order"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="order">Order to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByOrder(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.Int32 order, params System.Int32[] additionalValues)
        {
            var orderList = new List<System.Int32> { order };

            if (additionalValues != null)
                orderList.AddRange(additionalValues);

            if (orderList.Count == 1)
                return queryable.ByOrder(orderList[0]);

            return queryable.ByOrder(orderList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Order"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByOrder(this IQueryable<Tracker.Data.Entities.Priority> queryable, IEnumerable<System.Int32> values)
        {
            return queryable.Where(p => values.Contains(p.Order));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Description"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Description to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByDescription(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.String description)
        {
            return queryable.Where(p => p.Description == description);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Description"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Description to search for.</param>
        /// <param name="containmentOperator">The containment operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByDescription(this IQueryable<Tracker.Data.Entities.Priority> queryable, ContainmentOperator containmentOperator, System.String description)
        {
            if (description == null && containmentOperator != ContainmentOperator.Equals && containmentOperator != ContainmentOperator.NotEquals)
                throw new ArgumentNullException("description", "Parameter 'description' cannot be null with the specified ContainmentOperator.  Parameter 'containmentOperator' must be ContainmentOperator.Equals or ContainmentOperator.NotEquals to support null.");

            switch (containmentOperator)
            {
                case ContainmentOperator.Contains:
                    return queryable.Where(p => p.Description.Contains(description));
                case ContainmentOperator.StartsWith:
                    return queryable.Where(p => p.Description.StartsWith(description));
                case ContainmentOperator.EndsWith:
                    return queryable.Where(p => p.Description.EndsWith(description));
                case ContainmentOperator.NotContains:
                    return queryable.Where(p => p.Description.Contains(description) == false);
                case ContainmentOperator.NotEquals:
                    return queryable.Where(p => p.Description != description);
                default:
                    return queryable.Where(p => p.Description == description);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Description"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="description">Description to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByDescription(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.String description, params System.String[] additionalValues)
        {
            var descriptionList = new List<System.String> { description };

            if (additionalValues != null)
                descriptionList.AddRange(additionalValues);

            if (descriptionList.Count == 1)
                return queryable.ByDescription(descriptionList[0]);

            return queryable.ByDescription(descriptionList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.Description"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByDescription(this IQueryable<Tracker.Data.Entities.Priority> queryable, IEnumerable<System.String> values)
        {
            return queryable.Where(p => values.Contains(p.Description));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByCreatedDate(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.DateTime createdDate)
        {
            return queryable.Where(p => p.CreatedDate == createdDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByCreatedDate(this IQueryable<Tracker.Data.Entities.Priority> queryable, ComparisonOperator comparisonOperator, System.DateTime createdDate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(p => p.CreatedDate > createdDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(p => p.CreatedDate >= createdDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(p => p.CreatedDate < createdDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(p => p.CreatedDate <= createdDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.CreatedDate != createdDate);
                default:
                    return queryable.Where(p => p.CreatedDate == createdDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="createdDate">CreatedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByCreatedDate(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.DateTime createdDate, params System.DateTime[] additionalValues)
        {
            var createdDateList = new List<System.DateTime> { createdDate };

            if (additionalValues != null)
                createdDateList.AddRange(additionalValues);

            if (createdDateList.Count == 1)
                return queryable.ByCreatedDate(createdDateList[0]);

            return queryable.ByCreatedDate(createdDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.CreatedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByCreatedDate(this IQueryable<Tracker.Data.Entities.Priority> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(p => values.Contains(p.CreatedDate));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByModifiedDate(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.DateTime modifiedDate)
        {
            return queryable.Where(p => p.ModifiedDate == modifiedDate);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByModifiedDate(this IQueryable<Tracker.Data.Entities.Priority> queryable, ComparisonOperator comparisonOperator, System.DateTime modifiedDate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(p => p.ModifiedDate > modifiedDate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(p => p.ModifiedDate >= modifiedDate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(p => p.ModifiedDate < modifiedDate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(p => p.ModifiedDate <= modifiedDate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(p => p.ModifiedDate != modifiedDate);
                default:
                    return queryable.Where(p => p.ModifiedDate == modifiedDate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="modifiedDate">ModifiedDate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByModifiedDate(this IQueryable<Tracker.Data.Entities.Priority> queryable, System.DateTime modifiedDate, params System.DateTime[] additionalValues)
        {
            var modifiedDateList = new List<System.DateTime> { modifiedDate };

            if (additionalValues != null)
                modifiedDateList.AddRange(additionalValues);

            if (modifiedDateList.Count == 1)
                return queryable.ByModifiedDate(modifiedDateList[0]);

            return queryable.ByModifiedDate(modifiedDateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Data.Entities.Priority.ModifiedDate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Tracker.Data.Entities.Priority> ByModifiedDate(this IQueryable<Tracker.Data.Entities.Priority> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(p => values.Contains(p.ModifiedDate));
        }
    }
}
#pragma warning restore 1591

