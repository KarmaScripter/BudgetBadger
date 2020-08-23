// <copyright file = "ITabControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Enums;

    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public interface ITabControl
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBackColor( Color color );

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name="border">if set to
        /// <c> true </c>
        /// [border].</param>
        void SetBorderStyle( bool border );

        /// <summary>
        /// Sets the table style.
        /// </summary>
        /// <param name="style">The style.</param>
        void SetTabStyle( TabStyle style );

        /// <summary>
        /// Sets the size of the item.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        void SetItemSize( int width = 120, int height = 20 );

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        void SetBindingSource( BindingSource bindingsource );

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        void SetField( Field field );

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        void SetTag( object tag );

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="tab">The tab.</param>
        void AddTab( TabPage tab );

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="name">The name.</param>
        void AddTab( string name );

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Control> GetChildren();

        /// <summary>
        /// Called when [selected index changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnSelectedIndexChanged( object sender, EventArgs e );

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnCurrentChanged( object sender, EventArgs e );
    }
}
