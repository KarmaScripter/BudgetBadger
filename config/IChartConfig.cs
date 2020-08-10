// <copyright file = "IChartConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    public interface IChartConfig
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the anchor.
        /// </summary>
        /// <param name = "anchor" >
        /// The anchor.
        /// </param>
        /// <returns>
        /// </returns>
        AnchorStyles SetAnchor( AnchorStyles anchor = AnchorStyles.Left & AnchorStyles.Top );

        void ResetTextColor();

        void ResetFont();

        void ResetBorder();

        void ResetInterior();

        void ResetText();

        void ResetToolTip();

        void ResetToolTipFormat();

        void ResetImages();

        void ResetCallout();

        void ResetTextOrientation();

        void ResetHighlightInterior();

        void ResetLabel();

        void ResetTextFormat();

        void ResetDisplayText();

        Color TextColor { get; set; }

        ChartFontInfo Font { get; set; }

        ChartLineInfo Border { get; set; }

        BrushInfo Interior { get; set; }

        string Text { get; set; }

        string ToolTip { get; set; }

        string ToolTipFormat { get; set; }

        ChartCalloutInfo Callout { get; set; }

        ChartTextOrientation TextOrientation { get; set; }

        BrushInfo ShadowInterior { get; set; }

        bool HighlightOnMouseOver { get; set; }

        BrushInfo HighlightInterior { get; set; }

        string Label { get; set; }

        string TextFormat { get; set; }

        bool DisplayText { get; set; }
    }
}