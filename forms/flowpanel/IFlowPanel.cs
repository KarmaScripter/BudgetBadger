// <copyright file = "IFlowPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public interface IFlowPanel
    {
        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        void SetLocation( int x, int y );

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        void SetSize( int width, int height );

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="parent">The parent.</param>
        void SetParent( Control parent );

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        void SetBindingSource( BindingSource bindingsource );

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddControl( Control item );

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Control> GetChildren();

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
        /// Sets the flow direction.
        /// </summary>
        /// <param name="direction">The direction.</param>
        /// <returns></returns>
        FlowDirection SetFlowDirection( FlowDirection direction = FlowDirection.TopDown );

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetToolTip( string text );
    }
}