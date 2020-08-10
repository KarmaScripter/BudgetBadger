// // <copyright file = "SeriesConfig.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

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
    public class SeriesConfig : ChartSeries, ISeriesConfig
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        public SeriesConfig()
        {
            // Basic Properties
            SmartLabels = true;
            Visible = true;
            ShowTicks = true;
            Rotate = true;
            EnableAreaToolTip = true;
            EnableStyles = true;
            OptimizePiePointPositions = true;
            LegendItemUseSeriesStyle = true;
            SmartLabelsBorderColor = ColorConfig.BorderColorBlue;
            SmartLabelsBorderWidth = BorderConfig.SizeThin;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "SeriesConfig"/>
        /// struct.
        /// </summary>
        /// <param name = "field" > The field. </param>
        /// <param name = "stat" > The metric. </param>
        /// <param name = "type" > The type. </param>
        /// <param name = "numeric" > The numeric. </param>
        public SeriesConfig( Field field, STAT stat = STAT.Total, ChartType type = ChartType.Column,
            Numeric numeric = Numeric.Amount )
            : this()
        {
            Name = $"{field}";
            Field = field;
            Stat = stat;
            ChartType = type;
            Numeric = numeric;
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary> Gets the field. </summary>
        /// <value> The field. </value>
        private Field Field { get; }

        /// <summary> Gets the stat. </summary>
        /// <value> The stat. </value>
        private STAT Stat { get; }

        /// <summary> Gets the type. </summary>
        /// <value> The type. </value>
        public ChartType ChartType { get; }

        /// <summary> Gets the numeric. </summary>
        /// <value> The numeric. </value>
        public Numeric Numeric { get; }

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
                Style.Callout.Font = ChartConfig.SetFont( "Roboto", 8, FontStyle.Regular );
                Style.DisplayText = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Gets the field. </summary>
        /// <returns> </returns>
        public Field GetField()
        {
            try
            {
                return Enum.IsDefined( typeof( Field ), Field )
                    ? Field
                    : Field.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Field.NS;
            }
        }

        /// <summary> Gets the statistic. </summary>
        /// <returns> </returns>
        public STAT GetStatistic()
        {
            try
            {
                return Enum.IsDefined( typeof( STAT ), Stat )
                    ? Stat
                    : STAT.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return STAT.None;
            }
        }

        /// <summary> Gets the numeric. </summary>
        /// <returns> </returns>
        public Numeric GetNumeric()
        {
            try
            {
                return Enum.IsDefined( typeof( Numeric ), Numeric )
                    ? Numeric
                    : Numeric.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Numeric.Default;
            }
        }

        /// <summary> Gets the type of the series. </summary>
        /// <param name = "type" > The type. </param>
        /// <returns> </returns>
        public ChartType GetSeriesType( ChartType type = ChartType.Column )
        {
            try
            {
                return Verify.ChartType( type )
                    ? (ChartType)Enum.Parse( typeof( ChartType ), type.ToString() )
                    : ChartType.Column;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ChartType.Column;
            }
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

                    if( ChartType != ChartType.Pie )
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