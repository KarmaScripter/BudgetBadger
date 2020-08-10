// <copyright file = "ToolBarPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    public class ToolBarPanel : ToolBarBase
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        public ToolBarPanel()
        {
            Margin = ControlConfig.Margin;
            BackColor = ColorConfig.BackColorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            OfficeColorScheme = ColorScheme.Black;
            Dock = DockStyle.Bottom;
            ShowCaption = true;
            BorderStyle = ToolStripBorderStyle.StaticEdge;
        }

        // ***************************************************************************************************************************
        // ****************************************************   PROPERTIES  ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public ToolTip ToolTip { get; set; }

        /// <summary> Gets or sets the size of the image. </summary>
        /// <value> The size of the image. </value>
        private Size ImageSize { get; set; } = new Size( 16, 16 );

        // ***************************************************************************************************************************
        // ****************************************************   METHODS     ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <returns></returns>
        private new ToolStripItemCollection GetItems()
        {
            return default;
        }
    }
}