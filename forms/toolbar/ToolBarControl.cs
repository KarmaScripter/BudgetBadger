﻿// // <copyright file = "ToolBarControl.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

using System;

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ControlBase" />
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    public partial class ToolBarControl : BarControlBase
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBarControl"/> class.
        /// </summary>
        public ToolBarControl()
        {
            InitializeComponent();
            Height = 33;
            Size = ToolBar.Size;
            Margin = new Padding( 0, 5, 0, 0 );
            Dock = DockStyle.Bottom;
            ToolBar.BackColor = ColorConfig.BackColorBlack;
            ToolBar.ForeColor = ColorConfig.ForeColorBlack;
            ToolBar.Font = FontConfig.FontSizeSmall;
            ToolBar.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
            ToolBar.Dock = DockStyle.Bottom;
            ToolBar.ShowCaption = false;
            ToolBar.CaptionMinHeight = 0;
            ToolBar.VisualStyle = ToolStripExStyle.Default;
            ToolBar.Office12Mode = true;
            ToolBar.Dock = DockStyle.Bottom;
            ToolBar.Stretch = true;
            ToolBar.Enabled = true;
            ToolBar.Visible = true;
            ToolBar.BorderStyle = ToolStripBorderStyle.None;
            ToolBar.Visible = true;
            ToolBar.Enabled = true;
        }

        // ***************************************************************************************************************************
        // ****************************************************  PROPERTIES   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        public void OnMouseHover( object sender, EventArgs e )
        {
            switch( sender )
            {
                case ToolStripButton button when Verify.Input( button?.Tag?.ToString() ):
                    try
                    {
                        ToolTip = new ToolTip( this, button?.Tag?.ToString() );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }

                    break;

                case ToolStripProgressBar progress when Verify.Input( progress?.Tag?.ToString() ):
                    try
                    {
                        ToolTip = new ToolTip( this, progress?.Tag?.ToString() );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }

                    break;
            }
        }

        public void OnMouseLeave( object sender, EventArgs e )
        {
            switch( sender )
            {
                case ToolStripButton button when ToolTip.Active:
                    try
                    {
                        ToolTip.RemoveAll();
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }

                    break;

                case ToolStripProgressBar progress when ToolTip.Active:
                    try
                    {
                        ToolTip.RemoveAll();
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }

                    break;
            }
        }
    }
}