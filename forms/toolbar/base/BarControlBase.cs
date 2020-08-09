// <copyright file="ToolBarControl.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    public class BarControlBase : UserControl
    {
        // ***************************************************************************************************************************
        // ****************************************************    FIELDS     ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// The image path
        /// </summary>
        public static readonly string ImagePath = Resource.ToolBar;

        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBarControl"/> class.
        /// </summary>
        public BarControlBase()
        {
            ForeColor = Color.Black;
            BackColor = ColorConfig.BackColorBlack;
            Font = FontConfig.FontSizeSmall;
            Padding = new Padding( 0 );
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <param name = "imagename" >
        /// The name.
        /// </param>
        /// <returns>
        /// </returns>
        public BarButton CreateButton( string imagename )
        {
            if( Verify.Input( imagename ) )
            {
                try
                {
                    var image = new BudgetImage( imagename, ImageSource.ToolBar, ImageSizer.Small );
                    var barbutton = new BarButton();
                    return barbutton;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <param name="tool">The tool.</param>
        /// <returns></returns>
        public BarButton CreateButton( Tool tool )
        {
            if( Verify.Input( tool.ToString() ) )
            {
                try
                {
                    var image = new BudgetImage( tool.ToString(), ImageSource.ToolBar, ImageSizer.Small );
                    var barbutton = new BarButton();
                    return barbutton;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarLabel CreateLabel()
        {
            try
            {
                return new BarLabel();
            }
            catch( Exception ex )
            {
                using var error = new Error( ex );
                error?.SetText();
                error?.ShowDialog();
                return default;
            }
        }

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarComboBox CreateComboBox()
        {
            try
            {
                return new BarComboBox();
            }
            catch( Exception ex )
            {
                using var error = new Error( ex );
                error?.SetText();
                error?.ShowDialog();
                return default;
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarTextBox CreateTextBox()
        {
            try
            {
                return new BarTextBox();
            }
            catch( Exception ex )
            {
                using var error = new Error( ex );
                error?.SetText();
                error?.ShowDialog();
                return default;
            }
        }
    }
}