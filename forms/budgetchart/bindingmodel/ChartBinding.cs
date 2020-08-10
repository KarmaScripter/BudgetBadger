// <copyright file = "ChartBinding.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // **************************************************************************************************************************
    // ********************************************      ASSEMBLIES    **********************************************************
    // **************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetBinding" />
    /// <seealso cref="IChartBinding" />
    /// <seealso cref="IChartSeriesModel" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ChartBinding : BudgetBinding, IChartBinding, IChartSeriesModel
    {
        // **************************************************************************************************************************
        // ********************************************   CONSTRUCTORS     **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetBinding" />
        /// class.
        /// </summary>
        public ChartBinding()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesconfig">The seriesconfig.</param>
        public ChartBinding( DataTable table, ISeriesConfig seriesconfig )
            : base( table.AsEnumerable() )
        {
            Data = table.AsEnumerable();
            SeriesConfiguration = seriesconfig;
            DataTable = table;
            DataSet = DataTable?.DataSet;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataSource = DataTable;
            Record = (DataRow)Current;
            Index = Position;
            AllowNew = true;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartBinding" />
        /// class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesconfig">The seriesconfig.</param>
        public ChartBinding( IEnumerable<DataRow> data, ISeriesConfig seriesconfig )
            : base( data )
        {
            Data = data;
            SeriesConfiguration = seriesconfig;
            DataTable = data.CopyToDataTable();
            DataSet = DataTable.DataSet;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataSource = DataTable;
            Record = (DataRow)Current;
            Index = Position;
            AllowNew = true;
            Changed += OnCurrentChanged;
        }

        // **************************************************************************************************************************
        // ********************************************      PROPERTIES    **********************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public new int Count { get; set; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        private protected IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        private protected ISeriesConfig SeriesConfiguration { get; set; }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        private protected IDataMetric Metric { get; set; }

        // **************************************************************************************************************************
        // ********************************************      METHODS    *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Gets the series configuration.
        /// </summary>
        /// <returns></returns>
        public ISeriesConfig GetSeriesConfig()
        {
            try
            {
                return SeriesConfiguration;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetDataMetric()
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
        /// Gets the count.
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            try
            {
                return Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the empty.
        /// </summary>
        /// <param name="xindex">The xindex.</param>
        /// <returns></returns>
        public bool GetEmpty( int xindex )
        {
            try
            {
                var numeric = SeriesConfiguration?.GetNumeric();
                return double.Parse( Record[ $"{numeric}" ].ToString() ) > 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <param name="xindex">The xindex.</param>
        /// <returns></returns>
        public double GetX( int xindex )
        {
            try
            {
                var numeric = SeriesConfiguration?.GetNumeric();

                return !GetEmpty( xindex )
                    ? double.Parse( Record[ $"{numeric}" ].ToString() )
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <param name="xindex">The xindex.</param>
        /// <returns></returns>
        public double GetY( int xindex )
        {
            try
            {
                var numeric = SeriesConfiguration?.GetNumeric();

                return !GetEmpty( xindex )
                    ? double.Parse( Record[ $@"{numeric}" ].ToString() )
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        // **************************************************************************************************************************
        // ********************************************      EVENTS     *************************************************************
        // **************************************************************************************************************************

        /// <summary>
        /// Gets or sets the chart handler.
        /// </summary>
        /// <value>
        /// The chart handler.
        /// </value>
        public ListChangedEventHandler ChartHandler { get; set; }

        /// <summary>
        /// Occurs when [changed].
        /// </summary>
        public event ListChangedEventHandler Changed;

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="ListChangedEventArgs" />
        /// instance containing the event data.</param>
        public void OnCurrentChanged( object sender, ListChangedEventArgs e )
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
    }
}