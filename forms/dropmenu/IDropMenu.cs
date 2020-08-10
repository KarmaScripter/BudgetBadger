// <copyright file = "IDropMenu.cs" company = "Terry D. Eppler">
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
    public interface IDropMenu
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name="style">The style.</param>
        void SetBorderStyle( BorderStyle style = BorderStyle.None );

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBorderColor( Color color );

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBackColor( Color color );

        /// <summary>
        /// Sets the expanded sized.
        /// </summary>
        /// <param name="height">The height.</param>
        void SetExpandedSize( int height = 500 );

        /// <summary>
        /// Opens this instance.
        /// </summary>
        void Open();

        /// <summary>
        /// Closes this instance.
        /// </summary>
        void Close();

        /// <summary>
        /// Sets the header text.
        /// </summary>
        /// <param name="header">The header.</param>
        void SetHeaderText( string header );

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddControl( Control item );

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetHoverText( string text );

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
