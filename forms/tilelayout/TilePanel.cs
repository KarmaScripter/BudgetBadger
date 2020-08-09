// <copyright file="TilePanel.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref = "TileLayout"/>
    /// <seealso cref = "IDisposable"/>
    public class TilePanel : TileLayout
    {
        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "TilePanel"/>
        /// class.
        /// </summary>
        public TilePanel()
        {
            BackColor = ColorConfig.BackColorBlack;
            ForeColor = ColorConfig.ForeColorGray;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Font = FontConfig.FontSizeSmall;
            Border3DStyle = Border3DStyle.Flat;
            BorderColor = ColorConfig.BorderColorGray;
            BorderStyle = BorderStyle.FixedSingle;
            BackgroundColor = new BrushInfo( BackColor );
            SetParentFormFlat = true;
            ShowGroupTitle = true;
            ShowItemPreview = true;
            TextAlignment = TextAlignment.Center;
            TitleFont = new Font( "Roboto", 10, FontStyle.Regular );
            MainLayout = new MainLayout();
        }

        // **************************************************************************************************************************
        // ********************************************      PROPERTIES    **********************************************************
        // **************************************************************************************************************************

        /// <summary> Gets or sets the image builder. </summary>
        /// <value> The image builder. </value>
        public ImageBuilder ImageBuilder { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the image list. </summary>
        /// <value> The image list. </value>
        public ImageList ImageList { get; set; }

        /// <summary> Gets or sets the slide show. </summary>
        /// <value> The slide show. </value>
        public Streamer Streamer { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public ToolTip ToolTip { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public string HoverText { get; set; }

        /// <summary> Gets or sets the field. </summary>
        /// <value> The field. </value>
        public Field Field { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        public IDictionary<string, object> DataFilter { get; set; }
    }
}