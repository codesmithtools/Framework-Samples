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

namespace Sakila.Data
{
    /// <summary>
    /// The query extension class for Inventory.
    /// </summary>
    public static partial class InventoryExtensions
    {
        #region Unique Results
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Sakila.Data.Entities.Inventory GetByKey(this IQueryable<Sakila.Data.Entities.Inventory> queryable
            , System.Int32 inventoryId
            )
        {
            return queryable
                .Where(i => i.InventoryId == inventoryId)
                .FirstOrDefault();
        }
        
        #endregion
        
        #region By Property
        

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory.InventoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="inventoryId">InventoryId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByInventoryId(this IQueryable<Sakila.Data.Entities.Inventory> queryable, System.Int32 inventoryId)
        {
            return queryable.Where(i => i.InventoryId == inventoryId);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory.InventoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="inventoryId">InventoryId to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByInventoryId(this IQueryable<Sakila.Data.Entities.Inventory> queryable, ComparisonOperator comparisonOperator, System.Int32 inventoryId)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(i => i.InventoryId > inventoryId);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(i => i.InventoryId >= inventoryId);
                case ComparisonOperator.LessThan:
                    return queryable.Where(i => i.InventoryId < inventoryId);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(i => i.InventoryId <= inventoryId);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(i => i.InventoryId != inventoryId);
                default:
                    return queryable.Where(i => i.InventoryId == inventoryId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory.InventoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="inventoryId">InventoryId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByInventoryId(this IQueryable<Sakila.Data.Entities.Inventory> queryable, System.Int32 inventoryId, params System.Int32[] additionalValues)
        {
            var inventoryIdList = new List<System.Int32> { inventoryId };

            if (additionalValues != null)
                inventoryIdList.AddRange(additionalValues);

            if (inventoryIdList.Count == 1)
                return queryable.ByInventoryId(inventoryIdList[0]);

            return queryable.ByInventoryId(inventoryIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory.InventoryId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByInventoryId(this IQueryable<Sakila.Data.Entities.Inventory> queryable, IEnumerable<System.Int32> values)
        {
            return queryable.Where(i => values.Contains(i.InventoryId));
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory.LastUpdate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastUpdate">LastUpdate to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByLastUpdate(this IQueryable<Sakila.Data.Entities.Inventory> queryable, System.DateTime lastUpdate)
        {
            return queryable.Where(i => i.LastUpdate == lastUpdate);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory.LastUpdate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastUpdate">LastUpdate to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByLastUpdate(this IQueryable<Sakila.Data.Entities.Inventory> queryable, ComparisonOperator comparisonOperator, System.DateTime lastUpdate)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                    return queryable.Where(i => i.LastUpdate > lastUpdate);
                case ComparisonOperator.GreaterThanOrEquals:
                    return queryable.Where(i => i.LastUpdate >= lastUpdate);
                case ComparisonOperator.LessThan:
                    return queryable.Where(i => i.LastUpdate < lastUpdate);
                case ComparisonOperator.LessThanOrEquals:
                    return queryable.Where(i => i.LastUpdate <= lastUpdate);
                case ComparisonOperator.NotEquals:
                    return queryable.Where(i => i.LastUpdate != lastUpdate);
                default:
                    return queryable.Where(i => i.LastUpdate == lastUpdate);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory.LastUpdate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="lastUpdate">LastUpdate to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByLastUpdate(this IQueryable<Sakila.Data.Entities.Inventory> queryable, System.DateTime lastUpdate, params System.DateTime[] additionalValues)
        {
            var lastUpdateList = new List<System.DateTime> { lastUpdate };

            if (additionalValues != null)
                lastUpdateList.AddRange(additionalValues);

            if (lastUpdateList.Count == 1)
                return queryable.ByLastUpdate(lastUpdateList[0]);

            return queryable.ByLastUpdate(lastUpdateList);
        }

        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory.LastUpdate"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByLastUpdate(this IQueryable<Sakila.Data.Entities.Inventory> queryable, IEnumerable<System.DateTime> values)
        {
            return queryable.Where(i => values.Contains(i.LastUpdate));
        }
    
        #endregion
        
        #region By Association
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory by Store's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="store">Store to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByStore(this IQueryable<Sakila.Data.Entities.Inventory> queryable, Sakila.Data.Entities.Store store)
        {
            return queryable.ByStore(ComparisonOperator.Equals, store);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory by Store's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="store">Store to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByStore(this IQueryable<Sakila.Data.Entities.Inventory> queryable, ComparisonOperator comparisonOperator, Sakila.Data.Entities.Store store)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(i => i.Store == store);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(i => i.Store != store);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory by Store's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="storeId">StoreId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByStore(this IQueryable<Sakila.Data.Entities.Inventory> queryable, System.Byte storeId)
        {
            return queryable.ByStore(ComparisonOperator.Equals, storeId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory by Store's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="storeId">StoreId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByStore(this IQueryable<Sakila.Data.Entities.Inventory> queryable, ComparisonOperator comparisonOperator, System.Byte storeId)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(i => i.Store.StoreId == storeId);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(i => i.Store.StoreId != storeId);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory by Film's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="film">Film to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByFilm(this IQueryable<Sakila.Data.Entities.Inventory> queryable, Sakila.Data.Entities.Film film)
        {
            return queryable.ByFilm(ComparisonOperator.Equals, film);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory by Film's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="film">Film to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByFilm(this IQueryable<Sakila.Data.Entities.Inventory> queryable, ComparisonOperator comparisonOperator, Sakila.Data.Entities.Film film)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(i => i.Film == film);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(i => i.Film != film);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory by Film's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="filmId">FilmId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByFilm(this IQueryable<Sakila.Data.Entities.Inventory> queryable, System.Int16 filmId)
        {
            return queryable.ByFilm(ComparisonOperator.Equals, filmId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Sakila.Data.Entities.Inventory by Film's primary key."/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <param name="filmId">FilmId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static IQueryable<Sakila.Data.Entities.Inventory> ByFilm(this IQueryable<Sakila.Data.Entities.Inventory> queryable, ComparisonOperator comparisonOperator, System.Int16 filmId)
        {
            switch(comparisonOperator)
            {
                case ComparisonOperator.Equals:
                    return queryable.Where(i => i.Film.FilmId == filmId);
                
                case ComparisonOperator.NotEquals:
                    return queryable.Where(i => i.Film.FilmId != filmId);
                    
                default:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support Association type.", "comparisonOperator");
            }
        }
            
        #endregion
    }
}
#pragma warning restore 1591

