// // <copyright file = "GridChartControl.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ControlBase" />
    /// <seealso cref="BudgetExecution.IBudgetGrid" />
    /// <seealso cref="BudgetExecution.IBudgetChart" />
    /// <seealso cref="ControlBase" />
    public partial class ChartDataControl : ControlBase, IBudgetGrid, IBudgetChart
    {
        // ***************************************************************************************************************************
        // ****************************************************  CONSTRUCTORS ********************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDataControl" /> class.
        /// </summary>
        public ChartDataControl()
        {
            InitializeComponent();
            MaximumSize = SizeConfig.FormMaximum;
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
            DataGrid.SetColumnWidth( columns );
        }

        /// <summary>
        /// Sets the grid bound data columns.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetGridBoundDataColumns( IEnumerable<DataRow> data )
        {
            DataGrid.SetGridBoundDataColumns( data );
        }

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="dict"></param>
        public void SetBindingSource( IEnumerable<DataRow> data, IDictionary<string, object> dict = null )
        {
            DataGrid.SetBindingSource( data, dict );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( BindingSource bindingsource, IDictionary<string, object> dict = null )
        {
            DataGrid.SetBindingSource( bindingsource, dict );
        }

        /// <summary>
        /// Pascalizes the headers.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="gridcolumns"></param>
        public void PascalizeHeaders( IEnumerable<DataRow> data, GridBoundColumnsCollection gridcolumns )
        {
            DataGrid.PascalizeHeaders( data, gridcolumns );
        }

        /// <summary>
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            return DataGrid.GetFilterValues( dict );
        }

        /// <summary>
        /// Gets the current data row.
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrentRow()
        {
            return DataGrid.GetCurrentRow();
        }

        /// <summary>
        /// Sets the group panel.
        /// </summary>
        public void SetGridPanel()
        {
            DataGrid.SetGridPanel();
        }

        /// <summary>
        /// Sets the toolbar.
        /// </summary>
        public void SetToolBar()
        {
            DataGrid.SetToolBar();
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="data">The data.</param>
        public new void SetDataSource<T1>( IEnumerable<T1> data ) where T1 : IEnumerable<DataRow>
        {
            ( (IBudgetGrid)DataGrid ).SetDataSource( data );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public new void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>
        {
            ( (IBudgetGrid)DataGrid ).SetDataSource( data, dict );
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
        public new void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow> where T2 : struct
        {
            ( (IBudgetGrid)DataGrid ).SetDataSource( data, field, filter );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        public new void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<DataRow>
        {
            ( (IBudgetGrid)DataGrid ).SetDataSource( data, field );
        }

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict"></param>
        public new void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow> where T2 : IDictionary<string, object>
        {
            ( (IBudgetGrid)DataGrid ).SetDataSource( data, dict );
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public new void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow> where T2 : struct
        {
            ( (IBudgetGrid)DataGrid ).SetDataSource( data, field, filter );
        }

        /// <summary>
        /// Sets the primary axis title.
        /// </summary>
        /// <param name="text">The title.</param>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            ( (IBudgetChart)Chart ).SetPrimaryAxisTitle( text, font, color );
        }

        /// <summary>
        /// Sets the main title.
        /// </summary>
        /// <param name="text">The t.</param>
        /// <param name="font"></param>
        /// <param name="color"></param>
        public void SetMainTitle( string text, Font font, Color color )
        {
            ( (IBudgetChart)Chart ).SetMainTitle( text, font, color );
        }

        /// <summary>
        /// Sets the legend configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="size">The size.</param>
        /// <param name="backcolor">The backcolor.</param>
        public void SetLegend( Font font, Size size, Color backcolor )
        {
            ( (IBudgetChart)Chart ).SetLegend( font, size, backcolor );
        }

        /// <summary>
        /// Gets the style configuration.
        /// </summary>
        /// <returns></returns>
        public IChartConfig GetStyleConfiguration()
        {
            return ( (IBudgetChart)Chart ).GetStyleConfiguration();
        }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        public ISourceModel GetSourceModel()
        {
            return ( (IBudgetChart)Chart ).GetSourceModel();
        }

        /// <summary>
        /// Gets the series configuration.
        /// </summary>
        /// <returns></returns>
        public ISeriesConfig GetSeriesConfiguration()
        {
            return ( (IBudgetChart)Chart ).GetSeriesConfiguration();
        }

        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetDataMetric()
        {
            return ( (IBudgetChart)Chart ).GetDataMetric();
        }

        /// <summary>
        /// Gets the chart data.
        /// </summary>
        /// <returns></returns>
        public ISeriesModel GetChartData()
        {
            return ( (IBudgetChart)Chart ).GetChartData();
        }

        /// <summary>
        /// Gets the data series.
        /// </summary>
        /// <returns></returns>
        public IDataSeries GetDataSeries()
        {
            return ( (IBudgetChart)Chart ).GetDataSeries();
        }

        /// <summary>
        /// Gets the tile information.
        /// </summary>
        /// <returns></returns>
        public ITitleInfo GetTileInfo()
        {
            return ( (IBudgetChart)Chart ).GetTileInfo();
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
            DataGrid.OnRightClick( sender, e );
        }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void OnCurrentChanged( object sender, EventArgs e )
        {
            DataGrid.OnCurrentChanged( sender, e );
        }

        /// <summary>
        /// Models the on selection changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="GridSelectionChangedEventArgs" /> instance containing the event data.</param>
        public void ModelOnSelectionChanged( object sender, GridSelectionChangedEventArgs e )
        {
            DataGrid.ModelOnSelectionChanged( sender, e );
        }
    }
}
