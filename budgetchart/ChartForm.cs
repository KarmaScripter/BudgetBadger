// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

using System.Drawing;
using System.Windows.Forms;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using Syncfusion.Windows.Forms;

    public partial class ChartForm : MetroForm, IBudgetChart
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        public ChartForm()
        {
            InitializeComponent();
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the size. </summary>
        /// <param name = "width" > The width. </param>
        /// <param name = "height" > The height. </param>
        /// <returns> </returns>
        public void SetSize( int width = 600, int height = 400 )
        {
            ( (IBudgetChart)Chart ).SetSize( width, height );
        }

        /// <summary> Sets the location. </summary>
        /// <param name = "x" > The x. </param>
        /// <param name = "y" > The y. </param>
        public void SetLocation( int x = 1, int y = 1 )
        {
            ( (IBudgetChart)Chart ).SetLocation( x, y );
        }

        /// <summary> Sets the parent. </summary>
        /// <param name = "parent" > The parent. </param>
        public void SetParent( Control parent )
        {
            ( (IBudgetChart)Chart ).SetParent( parent );
        }

        /// <summary> Sets the primary axis title. </summary>
        /// <param name = "text" > The title. </param>
        /// <param name = "font" > </param>
        /// <param name = "color" > The color. </param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            Chart.SetPrimaryAxisTitle( text, font, color );
        }

        /// <summary> Sets the main title. </summary>
        /// <param name = "text" > The t. </param>
        /// <param name = "font" > </param>
        /// <param name = "color" > </param>
        public void SetMainTitle( string text, Font font, Color color )
        {
            Chart.SetMainTitle( text, font, color );
        }

        /// <summary> Sets the legend configuration. </summary>
        /// <param name = "font" > The font. </param>
        /// <param name = "size" > The size. </param>
        /// <param name = "backcolor" > The backcolor. </param>
        public void SetLegend( Font font, Size size, Color backcolor )
        {
            Chart.SetLegend( font, size, backcolor );
        }

        /// <summary> Gets the style configuration. </summary>
        /// <returns> </returns>
        public IChartConfig GetStyleConfiguration()
        {
            return Chart.GetStyleConfiguration();
        }

        /// <summary> Gets the source model. </summary>
        /// <returns> </returns>
        public ISourceModel GetSourceModel()
        {
            return Chart.GetSourceModel();
        }

        /// <summary> Gets the series configuration. </summary>
        /// <returns> </returns>
        public ISeriesConfig GetSeriesConfiguration()
        {
            return Chart.GetSeriesConfiguration();
        }

        /// <summary> Gets the data metric. </summary>
        /// <returns> </returns>
        public IDataMetric GetDataMetric()
        {
            return Chart.GetDataMetric();
        }

        /// <summary> Gets the chart data. </summary>
        /// <returns> </returns>
        public ISeriesModel GetChartData()
        {
            return Chart.GetChartData();
        }

        /// <summary> Gets the data series. </summary>
        /// <returns> </returns>
        public IDataSeries GetDataSeries()
        {
            return Chart.GetDataSeries();
        }

        /// <summary> Gets the tile information. </summary>
        /// <returns> </returns>
        public ITitleInfo GetTileInfo()
        {
            return Chart.GetTileInfo();
        }
    }
}
