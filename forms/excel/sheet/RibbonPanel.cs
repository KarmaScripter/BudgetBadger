// <copyright file = "RibbonPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ***************************************************************************************************************************
    // ****************************************************   ASSEMBLIES  ********************************************************
    // ***************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class RibbonPanel : SpreadsheetRibbon
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonPanel"/> class.
        /// </summary>
        public RibbonPanel()
        {
            Size = new Size( 1098, 162 );
            Dock = DockStyleEx.Top;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Font = FontConfig.FontSizeSmall;
            ForeColor = ColorConfig.ForeColorGray;
            BackColor = ColorConfig.BackColorBlack;
            Ribbon.BackColor = BackColor;
            Ribbon.CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            Ribbon.TitleColor = Color.White;
            Ribbon.TitleFont = new Font( "Roboto", 10, FontStyle.Bold );
            Ribbon.BorderStyle = ToolStripBorderStyle.StaticEdge;
            RibbonStyle = RibbonStyle.Office2007;
            OfficeColorScheme = ToolStripEx.ColorScheme.Black;
            OfficeMenu.Margin = Margin;
            OfficeMenu.Padding = Padding;
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public SpreadsheetGrid Grid { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public Spreadsheet ActiveSheet { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public SpreadsheetGridModel Model { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }
    }
}