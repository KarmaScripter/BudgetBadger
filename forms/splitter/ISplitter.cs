// <copyright file="ISplitter.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public interface ISplitter
    {
        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddLeftPanelChild( Control item );

        /// <summary>
        /// Adds the right panel child.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddRightPanelChild( Control item );

        /// <summary>
        /// Sets the splitter distance.
        /// </summary>
        /// <param name="distance">The distance.</param>
        void SetSplitterDistance( int distance );

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Control> GetChildren();

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        void SetSize( int width, int height );

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        void SetLocation( int x, int y );

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="dock">The dock.</param>
        void SetDockStyle( DockStyle dock );

        /// <summary>
        /// Anchors the style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        void SetAnchorStyle( AnchorStyles anchor );
    }
}