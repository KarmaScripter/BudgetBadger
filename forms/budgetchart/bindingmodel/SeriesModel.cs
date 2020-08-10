// <copyright file = "SeriesModel.cs" company = "Terry D. Eppler">
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
    /// <seealso cref="SourceModel" />
    /// <seealso cref="ISeriesModel" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class SeriesModel : SourceModel, ISeriesModel
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SeriesModel" />
        /// class.
        /// </summary>
        public SeriesModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SeriesModel" />
        /// class.
        /// </summary>
        /// <param name="bindingsource"></param>
        public SeriesModel( IChartBinding bindingsource )
            : base( bindingsource )
        {
            SourceBinding = bindingsource;
            BindingModel = new ChartDataBindModel( SourceBinding );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding.GetDataMetric();
            SeriesData = Metric.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModel" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesconfig">The seriesconfig.</param>
        public SeriesModel( DataTable table, ISeriesConfig seriesconfig )
            : base( table, seriesconfig )
        {
            SourceBinding = new ChartBinding( table, seriesconfig );
            BindingModel = new ChartDataBindModel( SourceBinding );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding.GetDataMetric();
            SeriesData = Metric.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModel" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesconfig">The seriesconfig.</param>
        public SeriesModel( IEnumerable<DataRow> data, ISeriesConfig seriesconfig )
            : base( data, seriesconfig )
        {
            SourceBinding = new ChartBinding( data, seriesconfig );
            BindingModel = new ChartDataBindModel( SourceBinding );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding.GetDataMetric();
            SeriesData = Metric.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetSeriesMetric()
        {
            try
            {
                return Metric;
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
        public IEnumerable<double> GetSeriesValues()
        {
            try
            {
                var values = SeriesData.Values.SelectMany( v => v );

                return values?.Any() == true
                    ? values.ToArray()
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the series categories.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetSeriesCategories()
        {
            try
            {
                var data = GetSeriesData();
                var values = data.Keys;

                return values?.Any() == true
                    ? values.ToArray()
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        public ISourceModel GetSourceModel()
        {
            try
            {
                return (SourceModel)MemberwiseClone();
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}