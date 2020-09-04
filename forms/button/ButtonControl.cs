// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Drawing;

    public partial class ButtonControl : ControlBase, IButton
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public ButtonControl()
        {
            InitializeComponent();
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the color of the fore. Required Attributes: ForeColor
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetForeColor( ColorFormat format )
        {
            Button.SetForeColor( format );
        }

        /// <summary>
        /// Sets the state of the back color.
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetBackColorStyle( ColorFormat format )
        {
            Button.SetBackColorStyle( format );
        }

        /// <summary>
        /// Sets the border configuration. Required Attributes: BorderColor, and HoverColor
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetBorderStyle( ColorFormat format )
        {
            Button.SetBorderStyle( format );
        }

        /// <summary>
        /// Sets the text style configuration. Required Attributes: PressedColor, DisabledColor,
        /// EnabledColor, and HoverColor
        /// </summary>
        /// <param name="format">The format.</param>
        public void SetTextStyle( ColorFormat format )
        {
            Button.SetTextStyle( format );
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="image">The image.</param>
        public void SetImage( Image image )
        {
            Button.SetImage( image );
        }

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnClick( object sender, EventArgs e )
        {
            Button.OnClick( sender, e );
        }
    }
}
