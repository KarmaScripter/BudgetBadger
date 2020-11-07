// <copyright file = "ITitleInfo.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    public interface ITitleInfo
    {
        // ***************************************************************************************************************************
        // ****************************************************    MEMBERS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the main title. </summary>
        /// <returns> </returns>
        string GetMainText();

        /// <summary> Sets the axis title. </summary>
        /// <returns> </returns>
        string GetAxisText();

        /// <summary> Gets the main title. </summary>
        /// <returns> </returns>
        ChartTitle GetChartMainTitle();

        /// <summary> Gets the axis title. </summary>
        /// <returns> </returns>
        ChartTitle GetChartAxisTitle();

        /// <summary> Gets the main title. </summary>
        /// <param name = "color" > The color. </param>
        /// <param name = "font" > The font. </param>
        /// <returns> </returns>
        ChartTitle GetChartMainTitle( Color color, Font font );

        /// <summary> Gets the axis title. </summary>
        /// <param name = "color" > The color. </param>
        /// <param name = "font" > The font. </param>
        /// <returns> </returns>
        ChartTitle GetChartAxisTitle( Color color, Font font );
    }
}
