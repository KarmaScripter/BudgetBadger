// <copyright file = "ISeriesConfig.cs" company = "Terry D. Eppler">
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
    using Syncfusion.Windows.Forms.Chart;

    public interface ISeriesConfig
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the callout. </summary>
        void SetCallout();

        /// <summary> Gets the field. </summary>
        /// <returns> </returns>
        Field GetField();

        /// <summary> Gets the statistic. </summary>
        /// <returns> </returns>
        STAT GetStatistic();

        /// <summary> Gets the numeric. </summary>
        /// <returns> </returns>
        Numeric GetNumeric();

        /// <summary> Gets the type of the series. </summary>
        /// <param name = "type" > The type. </param>
        /// <returns> </returns>
        ChartType GetSeriesType( ChartType type = ChartType.Column );

        string Name { get; set; }

        object Tag { get; set; }

        string Text { get; set; }

        bool EnableStyles { get; set; }

        bool Visible { get; set; }

        ChartFancyToolTipInfo FancyToolTip { get; }

        bool LegendItemUseSeriesStyle { get; set; }

        bool OptimizePiePointPositions { get; set; }

        bool Rotate { get; set; }

        bool ShowTicks { get; set; }

        bool DrawSeriesNameInDepth { get; set; }

        bool SmartLabels { get; set; }

        float SmartLabelsBorderWidth { get; set; }

        Color SmartLabelsBorderColor { get; set; }

        bool EnableAreaToolTip { get; set; }
    }
}
