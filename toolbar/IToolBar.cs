// // <copyright file = "IToolBar.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BudgetExecution
{
    public interface IToolBar
    {
        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <returns></returns>
        IDictionary<string, BarButton> GetButtons();

        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <param name = "imagename" >
        /// The name.
        /// </param>
        /// <returns>
        /// </returns>
        BarButton CreateButton( string imagename );

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        BarLabel CreateLabel();

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        BarComboBox CreateComboBox();

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        BarTextBox CreateTextBox();

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        void SetField( Field field );

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        void SetDataSource<T>( T bindingsource )
            where T : IBindingList;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindinglist">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T, T2>( T bindinglist, T2 dict )
            where T : IBindingList
            where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        void SetDataSource<T>( IEnumerable<T> data )
            where T : IEnumerable<T>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<T1>;

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
            where T1 : IEnumerable<T1>
            where T2 : struct;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
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

        ToolStripItemCollection GetItems();
    }
}
