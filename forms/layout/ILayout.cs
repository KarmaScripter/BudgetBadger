// <copyright file = "ILayout.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public interface ILayout
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="hover">if set to <c>true</c> [hover].</param>
        void SetBorderColor( Color color, bool hover = true );

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="hover">if set to <c>true</c> [hover].</param>
        void SetBorderHoverColor( Color color, bool hover = true );

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBackColor( Color color );

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        IEnumerable<Control> AddChild( Control item );

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
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Control> GetChildren();
    }
}