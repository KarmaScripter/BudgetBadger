// <copyright file = "SheetPanel.cs" company = "Terry D. Eppler">
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
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet" />
    /// <seealso cref="ISpreadsheet" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class SheetPanel : Spreadsheet, ISpreadsheet
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="SheetPanel"/> class.
        /// </summary>
        public SheetPanel()
        {
            Size = new Size( 1098, 536 );
            Dock = DockStyle.Fill;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            BackColor = ColorConfig.ForeColorGray;
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            DefaultColumnCount = 26;
            DefaultRowCount = 66;
            AllowZooming = true;
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
        public SpreadsheetGridModel Model { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void OpenFile( Stream file )
        {
        }

        /// <summary>
        /// Displays the message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="button">The button.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        public bool DisplayMessageBox( string text, string caption, MessageBoxButtons button,
            MessageBoxIcon icon )
        {
            return false;
        }
    }
}