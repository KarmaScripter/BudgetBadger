// // <copyright file = "IBudgetBinding.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;

    public interface IBindingSource 
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the data filter.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        void SetDataFilter( Field field, string filter );

        /// <summary>
        /// Sets the data filter.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        void SetDataFilter( IDictionary<string, object> dict );

        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <returns></returns>
        DataSet GetDataSet();

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <returns>
        /// </returns>
        Field GetField();

        /// <summary>
        /// Gets the data filter.
        /// </summary>
        /// <returns>
        /// </returns>
        IDictionary<string, object> GetDataFilter();

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns>
        /// </returns>
        DataTable GetDataTable();

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>
        /// </returns>
        IEnumerable<DataRow> GetData();

        /// <summary>
        /// Gets the current row.
        /// </summary>
        /// <returns>
        /// </returns>
        DataRow GetCurrent();

        /// <summary>
        /// Gets the index of the current.
        /// </summary>
        /// <returns>
        /// </returns>
        int GetIndex();

        /// <summary>
        /// Finds the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        int Find( string name, object key );

        /// <summary>
        /// Moves the first.
        /// </summary>
        void MoveFirst();

        /// <summary>
        /// Moves the last.
        /// </summary>
        void MoveLast();

        /// <summary>
        /// Moves the next.
        /// </summary>
        void MoveNext();

        /// <summary>
        /// Moves the previous.
        /// </summary>
        void MovePrevious();

        /// <summary>
        /// Removes the current.
        /// </summary>
        void RemoveCurrent();

        /// <summary>
        /// Resets the bindings.
        /// </summary>
        /// <param name="changed">if set to <c>true</c> [changed].</param>
        void ResetBindings( bool changed );

        /// <summary>
        /// Resets the current item.
        /// </summary>
        void ResetCurrentItem();

        /// <summary>
        /// Resets the item.
        /// </summary>
        /// <param name="index">The index.</param>
        void ResetItem( int index );
    }
}