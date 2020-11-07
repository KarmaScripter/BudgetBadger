// <copyright file = "BudgetChartPanel.cs" company = "Terry D. Eppler">
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
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class ChartPanel : ChartBase, IBudgetChart
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        // Sets Starting Properties
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartPanel"/> class.
        /// </summary>
        public ChartPanel()
        {
            //Basic Control Properties
            Size = SizeConfig.GetSize( 600, 400 );
            Location = ControlConfig.GetLocation( 1, 1 );
            ShowLegend = false;
            ShowToolbar = false;
            ShowScrollBars = false;
            EnableMouseRotation = true;
            Padding = ControlConfig.Padding;
            Margin = ControlConfig.Margin;
            Anchor = ControlConfig.GetAnchorStyle();
            AllowGapForEmptyPoints = true;
            AllowGradientPalette = true;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            BackInterior = new BrushInfo( ColorConfig.FormDarkBackColor );
            BackColor = ColorConfig.FormDarkBackColor;

            ChartInterior = new BrushInfo( GradientStyle.PathRectangle, Color.LightGray,
                ColorConfig.FormDarkBackColor );

            CalcRegions = true;

            //ChartArea Properties
            ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( ColorConfig.FormDarkBackColor );
            ChartArea.BorderWidth = BorderConfig.SizeThin;
            ChartArea.BorderColor = ColorConfig.Transparent;
            ChartArea.BorderStyle = BorderStyle.FixedSingle;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );

            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;

            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, ColorConfig.FormDarkBackColor,
                Color.Silver );

            Depth = 250;
            ElementsSpacing = 10;
            ColumnDrawMode = ChartColumnDrawMode.InDepthMode;
            ColumnFixedWidth = 20;

            //Chart Appearance Settings
            Palette = ChartColorPalette.Metro;
            Skins = Skins.None;
            RealMode3D = true;
            Rotation = 0.1f;
            SmoothingMode = SmoothingMode.AntiAlias;
            Spacing = 5;
            AutoHighlight = true;
            SpacingBetweenPoints = 5;
            SpacingBetweenSeries = 10;
            Style3D = true;
            TextAlignment = AlignConfig.GetStringAlignment( StringAlignment.Center );
            TextPosition = ChartTextPosition.Top;
            Tilt = 5;
            ScrollPrecision = 100;
            RadarStyle = ChartRadarAxisStyle.Polygon;

            //Chart Legend Settings;
            ShowLegend = true;
            Legend.Font = FontConfig.FontSizeSmall;
            Legend.ItemsSize = SizeConfig.ImageSmall;
            Legend.VisibleCheckBox = true;
            Legend.BackInterior = new BrushInfo( ColorConfig.FormDarkBackColor );
            Legend.ItemsAlignment = AlignConfig.GetStringAlignment( StringAlignment.Center );
            Legend.ItemsTextAligment = VerticalAlignment.Center;
            Legend.Orientation = ChartOrientation.Vertical;
            Legend.FloatingAutoSize = true;
            Legend.ShowSymbol = true;
            Legend.ShowItemsShadow = true;
            Legend.ShowBorder = false;
            Legend.Visible = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartPanel" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesconfig">The seriesconfig.</param>
        public ChartPanel( DataTable table, ISeriesConfig seriesconfig )
            : this()
        {
            SourceModel = new SourceModel( table, seriesconfig );
            Configuration = SourceModel.GetSeriesConfiguration();
            ChartData = new SeriesModel( table, seriesconfig );
            DataMetric = SourceModel.GetMetric();
            TitleInfo = new TitleInfo( DataMetric.GetData()?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartPanel" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesconfig">The seriesconfig.</param>
        public ChartPanel( IEnumerable<DataRow> data, ISeriesConfig seriesconfig )
            : this()
        {
            SourceModel = new SourceModel( data, seriesconfig );
            Configuration = SourceModel.GetSeriesConfiguration();
            ChartData = new SeriesModel( data, seriesconfig );
            DataMetric = SourceModel.GetMetric();
            TitleInfo = new TitleInfo( DataMetric.GetData()?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartPanel" />
        /// class.
        /// </summary>
        /// <param name="sourcebinding">The sourcebinding.</param>
        public ChartPanel( IChartBinding sourcebinding )
            : this()
        {
            SourceModel = new SourceModel( sourcebinding );
            Configuration = SourceModel.GetSeriesConfiguration();
            ChartData = new SeriesModel( sourcebinding );
            DataMetric = SourceModel.GetMetric();
            TitleInfo = new TitleInfo( DataMetric.GetData()?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartPanel" />
        /// class.
        /// </summary>
        /// <param name="model">The model.</param>
        public ChartPanel( ISourceModel model )
            : this()
        {
            SourceModel = model;
            Configuration = SourceModel.GetSeriesConfiguration();
            ChartData = new SeriesModel( SourceModel.GetSourceBinding() );
            TitleInfo = new TitleInfo( Configuration.Name );
            DataMetric = SourceModel.GetMetric();
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartPanel" />
        /// class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="title">The title.</param>
        public ChartPanel( ISourceModel model, ITitleInfo title )
            : this()
        {
            SourceModel = model;
            Configuration = SourceModel.GetSeriesConfiguration();
            TitleInfo = title;
            DataMetric = SourceModel.GetMetric();
            ChartData = new SeriesModel( SourceModel.GetSourceBinding() );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartPanel" />
        /// class.
        /// </summary>
        /// <param name="chartdata">The chartdata.</param>
        /// <param name="title">The title.</param>
        public ChartPanel( ISeriesModel chartdata, ITitleInfo title )
            : this()
        {
            ChartData = chartdata;
            Configuration = ChartData.GetSeriesConfiguration();
            SourceModel = ChartData.GetSourceModel();
            TitleInfo = title;
            DataMetric = ChartData.GetSeriesMetric();
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize( int width = 600, int height = 400 )
        {
            if( width > 0
                && height > 0 )
            {
                try
                {
                    Size = new Size( width, height );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void SetLocation( int x = 1, int y = 1 )
        {
            if( x > 0
                && y > 0 )
            {
                try
                {
                    Location = new Point( x, y );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void SetParent( Control parent )
        {
            if( parent != null )
            {
                try
                {
                    Parent = parent;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the primary axis title.
        /// </summary>
        /// <param name="text">The title.</param>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            try
            {
                PrimaryXAxis.Title = text;
                PrimaryXAxis.TitleColor = color;
                PrimaryXAxis.TitleFont = font;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the main title.
        /// </summary>
        /// <param name="text">The t.</param>
        /// <param name="font"></param>
        /// <param name="color"></param>
        public void SetMainTitle( string text, Font font, Color color )
        {
            try
            {
                if( Titles?.Count > 0 )
                {
                    Titles.Clear();
                }

                using var title = new ChartTitle();
                title.Visible = true;
                title.Font = font;
                title.BackColor = ColorConfig.FormDarkBackColor;
                title.ForeColor = color;
                title.Text = text;
                Titles?.Add( title );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the style configuration.
        /// </summary>
        /// <returns></returns>
        public IChartConfig GetStyleConfiguration()
        {
            try
            {
                return Style.DisplayText
                    ? Style
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}
