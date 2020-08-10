// // <copyright file = "IBudgetChart.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    public interface IBudgetChart
    {
        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the size. </summary>
        /// <param name = "width" > The width. </param>
        /// <param name = "height" > The height. </param>
        /// <returns> </returns>
        void SetSize( int width = 600, int height = 400 );

        /// <summary> Sets the location. </summary>
        /// <param name = "x" > The x. </param>
        /// <param name = "y" > The y. </param>
        void SetLocation( int x = 1, int y = 1 );

        /// <summary> Sets the parent. </summary>
        /// <param name = "parent" > The parent. </param>
        void SetParent( Control parent );

        /// <summary> Sets the primary axis title. </summary>
        /// <param name = "text" > The title. </param>
        /// <param name = "font" > </param>
        /// <param name = "color" > The color. </param>
        void SetPrimaryAxisTitle( string text, Font font, Color color );

        /// <summary> Sets the main title. </summary>
        /// <param name = "text" > The t. </param>
        /// <param name = "font" > </param>
        /// <param name = "color" > </param>
        void SetMainTitle( string text, Font font, Color color );

        /// <summary> Sets the legend configuration. </summary>
        /// <param name = "font" > The font. </param>
        /// <param name = "size" > The size. </param>
        /// <param name = "backcolor" > The backcolor. </param>
        void SetLegend( Font font, Size size, Color backcolor );

        /// <summary> Gets the style configuration. </summary>
        /// <returns> </returns>
        IChartConfig GetStyleConfiguration();

        /// <summary> Gets the source model. </summary>
        /// <returns> </returns>
        ISourceModel GetSourceModel();

        /// <summary> Gets the series configuration. </summary>
        /// <returns> </returns>
        ISeriesConfig GetSeriesConfiguration();

        /// <summary> Gets the data metric. </summary>
        /// <returns> </returns>
        IDataMetric GetDataMetric();

        /// <summary> Gets the chart data. </summary>
        /// <returns> </returns>
        ISeriesModel GetChartData();

        /// <summary> Gets the data series. </summary>
        /// <returns> </returns>
        IDataSeries GetDataSeries();

        /// <summary> Gets the tile information. </summary>
        /// <returns> </returns>
        ITitleInfo GetTileInfo();
    }
}