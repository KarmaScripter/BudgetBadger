// <copyright file = "CalendarPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class CalendarPanel : MonthCalendarAdv
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "CalendarPanel"/>
        /// class.
        /// </summary>
        public CalendarPanel()
        {
            Size = SizeConfig.GetSize( 305, 332 );
            Location = ControlConfig.GetLocation();
            Font = FontConfig.FontSizeSmall;
            Margin = ControlConfig.Margin;
            ForeColor = ColorConfig.ForeColorGray;
            BackColor = ColorConfig.BackColorBlack;
            Dock = ControlConfig.GetDockStyle();
            Anchor = ControlConfig.GetAnchorStyle();
            Visible = true;
            Enabled = true;
            Style = VisualStyle.Office2010;
            Office2010Theme = Office2010Theme.Blue;
            Border3DStyle = Border3DStyle.Flat;
            BorderStyle = BorderStyle.FixedSingle;
            FirstDayOfWeek = Day.Monday;
            BottomHeight = 30;
            DayNamesColor = ColorConfig.BackColorBlack;
            DayNamesFont = new Font( "Roboto", 10, FontStyle.Bold );
            DaysFont = FontConfig.FontSizeMedium;
            DaysColor = ColorConfig.BackColorBlack;
            DaysHeaderInterior = new BrushInfo( SystemColors.ControlDark );
            HeadForeColor = Color.White;
            HeaderHeight = 40;
            HeadGradient = false;
            HeaderFont = new Font( "Roboto", 12, FontStyle.Bold );
            HeaderStartColor = SystemColors.ControlDarkDark;
        }

        // **************************************************************************************************************************
        // *************************************************   PROPERTIES   *********************************************************
        // **************************************************************************************************************************

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public ToolTip ToolTip { get; set; }
    }
}
