// <copyright file = "BudgetChartControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Drawing;

    public partial class BudgetChartControl : ControlBase, IBudgetChart
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        public BudgetChartControl()
        {
            InitializeComponent();
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

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
            ( (IBudgetChart)Chart ).SetLegend( font, size, backcolor );
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
            return ( (IBudgetChart)Chart ).GetSourceModel();
        }

        /// <summary> Gets the series configuration. </summary>
        /// <returns> </returns>
        public ISeriesConfig GetSeriesConfiguration()
        {
            return ( (IBudgetChart)Chart ).GetSeriesConfiguration();
        }

        /// <summary> Gets the data metric. </summary>
        /// <returns> </returns>
        public IDataMetric GetDataMetric()
        {
            return ( (IBudgetChart)Chart ).GetDataMetric();
        }

        /// <summary> Gets the chart data. </summary>
        /// <returns> </returns>
        public ISeriesModel GetChartData()
        {
            return ( (IBudgetChart)Chart ).GetChartData();
        }

        /// <summary> Gets the data series. </summary>
        /// <returns> </returns>
        public IDataSeries GetDataSeries()
        {
            return ( (IBudgetChart)Chart ).GetDataSeries();
        }

        /// <summary> Gets the tile information. </summary>
        /// <returns> </returns>
        public ITitleInfo GetTileInfo()
        {
            return ( (IBudgetChart)Chart ).GetTileInfo();
        }
    }
}
