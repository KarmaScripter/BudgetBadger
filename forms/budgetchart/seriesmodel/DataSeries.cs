// <copyright file="DataSeries.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using Syncfusion.Windows.Forms.Chart;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class DataSeries : ChartSeries, IDataSeries
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        public DataSeries()
        {
        }

        public DataSeries( ISeriesModel chartdata )
            : this()
        {
            Config = chartdata.GetSeriesConfiguration();
            Name = Config.Name;
            Type = GetSeriesType( Config.GetSeriesType() );
            Metric = Config.GetStatistic();
            SourceModel = chartdata?.GetSourceModel();
            SeriesData = SourceModel.GetSeriesData();
            SeriesValues = chartdata?.GetSeriesValues();
            SeriesCategories = chartdata?.GetSeriesCategories();
            SmartLabels = Config.SmartLabels;
            Visible = Config.Visible;
            ShowTicks = Config.ShowTicks;
            Rotate = Config.Rotate;
            EnableAreaToolTip = Config.EnableAreaToolTip;
            EnableStyles = Config.EnableStyles;
            OptimizePiePointPositions = Config.OptimizePiePointPositions;
            LegendItemUseSeriesStyle = Config.LegendItemUseSeriesStyle;
            SmartLabelsBorderColor = ColorConfig.BorderColorBlue;
            SmartLabelsBorderWidth = BorderConfig.SizeThin;
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary> Gets the configuration. </summary>
        /// <value> The configuration. </value>
        private ISeriesConfig Config { get; }

        /// <summary> Gets the value. </summary>
        /// <value> The value. </value>
        private STAT Metric { get; }

        /// <summary> Gets the source model. </summary>
        /// <value> The source model. </value>
        private ISourceModel SourceModel { get; }

        /// <summary> Gets the series data. </summary>
        /// <value> The series data. </value>
        private IDictionary<string, IEnumerable<double>> SeriesData { get; }

        /// <summary> Gets the series categories. </summary>
        /// <value> The series categories. </value>
        private IEnumerable<string> SeriesCategories { get; }

        /// <summary> Gets the series values. </summary>
        /// <value> The series values. </value>
        private IEnumerable<double> SeriesValues { get; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary> Sets the callout. </summary>
        public void SetCallout()
        {
            try
            {
                Style.Callout.Enable = true;
                Style.Callout.Position = LabelPosition.Top;
                Style.Callout.DisplayTextAndFormat = "{0} : {2}";
                Style.Callout.Border.Color = ColorConfig.BorderColorBlue;
                Style.Callout.Color = ColorConfig.BackColorBlack;
                Style.Callout.Font = ChartConfig.SetFont( FontConfig.FontSizeSmall );
                Style.DisplayText = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Gets the type of the series. </summary>
        /// <param name = "type" > The type. </param>
        /// <returns> </returns>
        public ChartSeriesType GetSeriesType( ChartType type = ChartType.Column )
        {
            try
            {
                return Verify.ChartType( type )
                    ? (ChartSeriesType)Enum.Parse( typeof( ChartSeriesType ), type.ToString() )
                    : ChartSeriesType.Column;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }

            return ChartSeriesType.Column;
        }

        /// <summary> Sets the point configuration. </summary>
        /// <param name = "stat" > The value. </param>
        public void SetPointConfiguration( STAT stat = STAT.Total )
        {
            if( Verify.STAT( stat ) )
            {
                try
                {
                    switch( stat )
                    {
                        case STAT.Total:
                        case STAT.Average:
                        {
                            Style.TextFormat = "{0:C}";
                            break;
                        }

                        case STAT.Percentage:
                        {
                            Style.TextFormat = "{0:P}";
                            break;
                        }

                        case STAT.Count:
                        {
                            Style.TextFormat = "{0}";
                            break;
                        }
                    }

                    if( Type != ChartSeriesType.Pie )
                    {
                        SmartLabels = true;
                        SortPoints = true;
                        Style.DisplayText = true;
                        Style.TextOffset = 50.0F;
                        Style.TextOrientation = ChartTextOrientation.Up;
                        Style.DisplayShadow = true;
                        Style.TextColor = Color.White;
                        Style.Font.Size = 10F;
                        Style.Font.FontStyle = FontStyle.Bold;
                        Style.Font.Facename = "Roboto";
                        ShowTicks = true;
                        ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        ConfigItems.ColumnItem.PhongAlpha = 20d;
                    }
                    else
                    {
                        SmartLabels = true;
                        SortPoints = true;
                        Style.DisplayText = true;
                        Style.TextOffset = 50.0F;
                        Style.TextOrientation = ChartTextOrientation.Up;
                        Style.DisplayShadow = true;
                        Style.TextColor = Color.White;
                        Style.Font.Size = 10F;
                        Style.Font.FontStyle = FontStyle.Bold;
                        Style.Font.Facename = "Roboto";
                        ShowTicks = true;
                        ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        ConfigItems.ColumnItem.PhongAlpha = 20d;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the points. </summary>
        /// <param name = "data" > The data. </param>
        /// <param name = "type" > The type. </param>
        /// <param name = "stat" > The value. </param>
        public void SetPoints( IDictionary<string, double> data, ChartType type = ChartType.Column,
            STAT stat = STAT.Total )
        {
            if( Enum.IsDefined( typeof( ChartType ), type ) )
            {
                try
                {
                    if( Points.Count > 0 )
                    {
                        Points.Clear();
                    }

                    switch( type )
                    {
                        case ChartType.Column:
                        case ChartType.Line:
                        case ChartType.Spline:
                        case ChartType.SplineArea:
                        case ChartType.Area:
                        case ChartType.Bar:
                        case ChartType.BoxAndWhisker:
                        case ChartType.Bubble:
                        case ChartType.Candle:
                        case ChartType.ColumnRange:
                        case ChartType.Gannt:
                        case ChartType.HeatMap:
                        case ChartType.HiLo:
                        case ChartType.HiLoOpenClose:
                        case ChartType.Histogram:
                        case ChartType.Kagi:
                        case ChartType.PointAndFigure:
                        case ChartType.Polar:
                        case ChartType.Radar:
                        case ChartType.RangeArea:
                        case ChartType.RotatedSpline:
                        case ChartType.Scatter:
                        case ChartType.StackingArea:
                        case ChartType.StackingArea100:
                        case ChartType.StackingBar:
                        case ChartType.StackingBar100:
                        case ChartType.StackingColumn100:
                        case ChartType.StepArea:
                        case ChartType.StepLine:
                        case ChartType.ThreeLineBreak:
                        case ChartType.Tornado:
                        case ChartType.StackingColumn:
                        {
                            foreach( var kvp in data )
                            {
                                Points.Add( kvp.Key, kvp.Value );
                            }

                            break;
                        }

                        case ChartType.Pyramid:
                        case ChartType.Funnel:
                        case ChartType.Pie:
                        {
                            foreach( var kvp in data )
                            {
                                Points.Add( kvp.Key, kvp.Value );
                                var keys = data.Keys.Select( k => k.ToString() ).ToArray();
                                var vals = data.Values.Select( v => v ).ToArray();

                                if( stat != STAT.Percentage )
                                {
                                    for( var i = 0; i < data.Keys.Count; i++ )
                                    {
                                        Styles[ i ].TextFormat = $"{keys[ i ]} \n {vals[ i ]:N1}";
                                    }
                                }
                                else if( stat == STAT.Percentage )
                                {
                                    for( var i = 0; i < data.Keys.Count; i++ )
                                    {
                                        Styles[ i ].TextFormat = $"{keys[ i ]} \n {vals[ i ]:P}";
                                    }
                                }
                            }

                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Gets the data. </summary>
        /// <returns> </returns>
        public IDictionary<string, IEnumerable<double>> GetSeriesValues()
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