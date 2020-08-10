// // <copyright file = "IBudgetGrid.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    public interface IBudgetGrid
    {
        void SetColumnWidth( GridBoundColumnsCollection columns );

        /// <summary> Sets the grid bound data columns. </summary>
        /// <param name = "data" > The data. </param>
        void SetGridBoundDataColumns( IEnumerable<DataRow> data );

        /// <summary> Sets the data source. </summary>
        /// <param name = "data" > The data. </param>
        /// <param name = "dict" > </param>
        void SetBindingSource( IEnumerable<DataRow> data, IDictionary<string, object> dict = null );

        /// <summary> Sets the binding source. </summary>
        /// <param name = "bindingsource" > The bindingsource. </param>
        /// <param name = "dict" > The dictionary. </param>
        void SetBindingSource( BindingSource bindingsource, IDictionary<string, object> dict = null );

        /// <summary> Pascalizes the headers. </summary>
        void PascalizeHeaders( IEnumerable<DataRow> data, GridBoundColumnsCollection gridcolumns );

        /// <summary> Gets the filter values. </summary>
        /// <param name = "dict" > The dictionary. </param>
        /// <returns> </returns>
        string GetFilterValues( IDictionary<string, object> dict );

        /// <summary> Gets the current data row. </summary>
        /// <returns> </returns>
        DataRow GetCurrentRow();

        /// <summary> Sets the group panel. </summary>
        void SetGridPanel();

        /// <summary> Sets the toolbar. </summary>
        void SetToolBar();

        /// <summary> Called when [right click]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnRightClick( object sender, MouseEventArgs e );

        void OnCurrentChanged( object sender, EventArgs e );

        void ModelOnSelectionChanged( object sender, GridSelectionChangedEventArgs e );

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        void SetField( Field field );

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        void SetDataSource<T>( T bindingsource ) where T : IBindingList;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindinglist">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T, T2>( T bindinglist, T2 dict )
            where T : IBindingList where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        void SetDataSource<T>( IEnumerable<T> data ) where T : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow> where T2 : struct;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, object field = null ) where T1 : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param>The numeric.</param>
        /// <param name = "dict" > </param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow> where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow> where T2 : struct;
    }
}