// <copyright file = "SourceModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Chart.ChartDataBindModel" />
    /// <seealso cref="ISourceModel" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    public class SourceModel : ChartDataBindModel, ISourceModel
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        public SourceModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesconfig">The seriesconfig.</param>
        public SourceModel( IEnumerable<DataRow> data, ISeriesConfig seriesconfig )
        {
            SourceBinding = new ChartBinding( data, seriesconfig );
            BindingModel = new ChartDataBindModel( data, seriesconfig?.GetField().ToString() );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding?.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding?.GetDataMetric();
            SeriesData = Metric?.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesconfig">The seriesconfig.</param>
        public SourceModel( DataTable table, ISeriesConfig seriesconfig )
        {
            SourceBinding = new ChartBinding( table?.AsEnumerable(), seriesconfig );
            BindingModel = new ChartDataBindModel( table, seriesconfig?.GetField().ToString() );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding?.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding?.GetDataMetric();
            SeriesData = Metric?.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> struct.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        public SourceModel( IChartBinding bindingsource )
        {
            SourceBinding = bindingsource;
            BindingModel = new ChartDataBindModel( SourceBinding );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding?.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding?.GetDataMetric();
            SeriesData = Metric?.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        // ***************************************************************************************************************************
        // ************************************************  PROPERTIES **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        private protected IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets or sets the chart binding.
        /// </summary>
        /// <value>
        /// The chart binding.
        /// </value>
        public IChartBinding SourceBinding { get; set; }

        /// <summary>
        /// Gets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        private protected ChartDataBindModel BindingModel { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        private protected IDataMetric Metric { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        private protected ISeriesConfig Configuration { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        private protected STAT Stat { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        private protected IDictionary<string, IEnumerable<double>> SeriesData { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataRow> GetData()
        {
            try
            {
                return Verify.Rows( Data )
                    ? Data
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the source binding.
        /// </summary>
        /// <returns></returns>
        public IChartBinding GetSourceBinding()
        {
            try
            {
                return Verify.Ref( SourceBinding )
                    ? SourceBinding
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, IEnumerable<double>> GetSeriesData()
        {
            try
            {
                return SeriesData?.Any() == true
                    ? SeriesData
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetMetric()
        {
            try
            {
                var data = Metric?.GetData();

                return Verify.Rows( data )
                    ? Metric
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the series configurations.
        /// </summary>
        /// <returns></returns>
        public ISeriesConfig GetSeriesConfiguration()
        {
            try
            {
                return Verify.Ref( Configuration )
                    ? Configuration
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void OnChanged( object sender, EventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    using var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }
    }
}