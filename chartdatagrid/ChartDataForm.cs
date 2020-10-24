// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    /// <seealso cref="BudgetExecution.IBudgetGrid" />
    /// <seealso cref="BudgetExecution.IBudgetChart" />
    public partial class ChartDataForm : MetroForm, IBudgetGrid, IBudgetChart
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDataForm" /> class.
        /// </summary>
        public ChartDataForm()
        {
            InitializeComponent();
        }

        // ***************************************************************************************************************************
        // ****************************************************     METHODS   ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the width of the column.
        /// </summary>
        /// <param name="columns">The columns.</param>
        public void SetColumnWidth( GridBoundColumnsCollection columns )
        {
            ( (IBudgetGrid)ChartDataControl ).SetColumnWidth( columns );
        }

        /// <summary>
        /// Sets the grid bound data columns.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetGridBoundDataColumns( IEnumerable<DataRow> data )
        {
            ( (IBudgetGrid)ChartDataControl ).SetGridBoundDataColumns( data );
        }

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="dict"></param>
        public void SetBindingSource( IEnumerable<DataRow> data, IDictionary<string, object> dict = null )
        {
            ( (IBudgetGrid)ChartDataControl ).SetBindingSource( data, dict );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( BindingSource bindingsource, IDictionary<string, object> dict = null )
        {
            ( (IBudgetGrid)ChartDataControl ).SetBindingSource( bindingsource, dict );
        }

        /// <summary>
        /// Pascalizes the headers.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="gridcolumns"></param>
        public void PascalizeHeaders( IEnumerable<DataRow> data, GridBoundColumnsCollection gridcolumns )
        {
            ( (IBudgetGrid)ChartDataControl ).PascalizeHeaders( data, gridcolumns );
        }

        /// <summary>
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            return ( (IBudgetGrid)ChartDataControl ).GetFilterValues( dict );
        }

        /// <summary>
        /// Gets the current data row.
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrentRow()
        {
            return ( (IBudgetGrid)ChartDataControl ).GetCurrentRow();
        }

        /// <summary>
        /// Sets the group panel.
        /// </summary>
        public void SetGridPanel()
        {
            ( (IBudgetGrid)ChartDataControl ).SetGridPanel();
        }

        /// <summary>
        /// Sets the toolbar.
        /// </summary>
        public void SetToolBar()
        {
            ( (IBudgetGrid)ChartDataControl ).SetToolBar();
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            ( (IBudgetGrid)ChartDataControl ).SetField( field );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bindingsource">The bindingsource.</param>
        public void SetDataSource<T>( T bindingsource ) where T : IBindingList
        {
            ( (IBudgetGrid)ChartDataControl ).SetDataSource( bindingsource );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindinglist">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T, T2>( T bindinglist, T2 dict )
            where T : IBindingList
            where T2 : IDictionary<string, object>
        {
            ( (IBudgetGrid)ChartDataControl ).SetDataSource( bindinglist, dict );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        public void SetDataSource<T>( IEnumerable<T> data ) where T : IEnumerable<DataRow>
        {
            ( (IBudgetGrid)ChartDataControl ).SetDataSource( data );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict ) where T1 : IEnumerable<DataRow>
        {
            ( (IBudgetGrid)ChartDataControl ).SetDataSource( data, dict );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        public void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow>
            where T2 : struct
        {
            ( (IBudgetGrid)ChartDataControl ).SetDataSource( data, field, filter );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, object field = null ) where T1 : IEnumerable<DataRow>
        {
            ( (IBudgetGrid)ChartDataControl ).SetDataSource( data, field );
        }

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict"></param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow>
            where T2 : IDictionary<string, object>
        {
            ( (IBudgetGrid)ChartDataControl ).SetDataSource( data, dict );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow>
            where T2 : struct
        {
            ( (IBudgetGrid)ChartDataControl ).SetDataSource( data, field, filter );
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize( int width = 600, int height = 400 )
        {
            ( (IBudgetChart)ChartDataControl ).SetSize( width, height );
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void SetLocation( int x = 1, int y = 1 )
        {
            ( (IBudgetChart)ChartDataControl ).SetLocation( x, y );
        }

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void SetParent( Control parent )
        {
            ( (IBudgetChart)ChartDataControl ).SetParent( parent );
        }

        /// <summary>
        /// Sets the primary axis title.
        /// </summary>
        /// <param name="text">The title.</param>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            ( (IBudgetChart)ChartDataControl ).SetPrimaryAxisTitle( text, font, color );
        }

        /// <summary>
        /// Sets the main title.
        /// </summary>
        /// <param name="text">The t.</param>
        /// <param name="font"></param>
        /// <param name="color"></param>
        public void SetMainTitle( string text, Font font, Color color )
        {
            ( (IBudgetChart)ChartDataControl ).SetMainTitle( text, font, color );
        }

        /// <summary>
        /// Sets the legend configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="size">The size.</param>
        /// <param name="backcolor">The backcolor.</param>
        public void SetLegend( Font font, Size size, Color backcolor )
        {
            ( (IBudgetChart)ChartDataControl ).SetLegend( font, size, backcolor );
        }

        /// <summary>
        /// Gets the style configuration.
        /// </summary>
        /// <returns></returns>
        public IChartConfig GetStyleConfiguration()
        {
            return ( (IBudgetChart)ChartDataControl ).GetStyleConfiguration();
        }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        public ISourceModel GetSourceModel()
        {
            return ( (IBudgetChart)ChartDataControl ).GetSourceModel();
        }

        /// <summary>
        /// Gets the series configuration.
        /// </summary>
        /// <returns></returns>
        public ISeriesConfig GetSeriesConfiguration()
        {
            return ( (IBudgetChart)ChartDataControl ).GetSeriesConfiguration();
        }

        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetDataMetric()
        {
            return ( (IBudgetChart)ChartDataControl ).GetDataMetric();
        }

        /// <summary>
        /// Gets the chart data.
        /// </summary>
        /// <returns></returns>
        public ISeriesModel GetChartData()
        {
            return ( (IBudgetChart)ChartDataControl ).GetChartData();
        }

        /// <summary>
        /// Gets the data series.
        /// </summary>
        /// <returns></returns>
        public IDataSeries GetDataSeries()
        {
            return ( (IBudgetChart)ChartDataControl ).GetDataSeries();
        }

        /// <summary>
        /// Gets the tile information.
        /// </summary>
        /// <returns></returns>
        public ITitleInfo GetTileInfo()
        {
            return ( (IBudgetChart)ChartDataControl ).GetTileInfo();
        }

        // ***************************************************************************************************************************
        // ****************************************************     EVENTS    ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="MouseEventArgs" />
        /// instance containing the event data.</param>
        public void OnRightClick( object sender, MouseEventArgs e )
        {
            ( (IBudgetGrid)ChartDataControl ).OnRightClick( sender, e );
        }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void OnCurrentChanged( object sender, EventArgs e )
        {
            ( (IBudgetGrid)ChartDataControl ).OnCurrentChanged( sender, e );
        }

        /// <summary>
        /// Models the on selection changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="GridSelectionChangedEventArgs" /> instance containing the event data.</param>
        public void ModelOnSelectionChanged( object sender, GridSelectionChangedEventArgs e )
        {
            ( (IBudgetGrid)ChartDataControl ).ModelOnSelectionChanged( sender, e );
        }
    }
}
