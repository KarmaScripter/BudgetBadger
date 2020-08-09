// <copyright file="IButtonPanel.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Drawing;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    public interface IButton
    {
        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the fore. Required Attributes: ForeColor
        /// </summary>
        /// <param name="format">The format.</param>
        void SetForeColor( ColorFormat format );

        /// <summary>
        /// Sets the state of the back color.
        /// </summary>
        /// <param name="format">The format.</param>
        void SetBackColorStyle( ColorFormat format );

        /// <summary>
        /// Sets the border configuration. Required Attributes: BorderColor, and HoverColor
        /// </summary>
        /// <param name="format">The format.</param>
        void SetBorderStyle( ColorFormat format );

        /// <summary>
        /// Sets the text style configuration. Required Attributes: PressedColor, DisabledColor,
        /// EnabledColor, and HoverColor
        /// </summary>
        /// <param name="format">The format.</param>
        void SetTextStyle( ColorFormat format );

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="image">The image.</param>
        void SetImage( Image image );

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnMouseOver( object sender, EventArgs e );

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnClick( object sender, EventArgs e );
    }
}