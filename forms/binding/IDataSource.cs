// <copyright file = "IDataSource.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System.Collections.Generic;
    using System.ComponentModel;

    public interface IDataSource
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        void SetField( Field field );

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindinglist">The bindingsource.</param>
        void SetDataSource<T1>( T1 bindinglist )
            where T1 : IBindingList;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2">The type of T2</typeparam>
        /// <param name="bindinglist">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1, T2>( T1 bindinglist, T2 dict )
            where T1 : IBindingList
            where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        void SetDataSource<T1>( IEnumerable<T1> data )
            where T1 : IEnumerable<T1>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the T1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<T1>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of T1</typeparam>
        /// <typeparam name="T2">The type of T2</typeparam>
        /// <typeparam name="T3">The type of T3</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<T1>
            where T2 : struct;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of T1</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<T1>;

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param>The numeric.</param>
        /// <param name = "dict" > </param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<T1>
            where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<T1>
            where T2 : struct;
    }
}
