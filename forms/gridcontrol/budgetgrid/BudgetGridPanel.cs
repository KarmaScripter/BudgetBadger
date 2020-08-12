// <copyright file = "BudgetGridPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ******************************************************************************************************************************
    // ******************************************************   ASSEMBLIES   ********************************************************
    // ******************************************************************************************************************************

    using System;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class BudgetGridPanel : BudgetGridData, IBudgetGrid
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetGridPanel"/>
        /// class.
        /// </summary>
        /// <overload>
        /// Initializes a new instance of
        /// <see cref = "T:Syncfusion.Windows.Forms.Grid.GridDataBoundGrid"/>
        /// .
        /// </overload>
        public BudgetGridPanel()
        {
            // Basic Properties
            ForeColor = Color.White;
            BackColor = ColorConfig.BackColorBlack;
            Font = new Font( "Roboto", 8, FontStyle.Bold );
            Margin = new Padding( 0 );
            Padding = new Padding( 0 );
            Size = SizeConfig.GetSize( 700, 400 );
            Location = ControlConfig.GetLocation();
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            Font = FontConfig.FontSizeSmall;
            Visible = true;
            Enabled = true;

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;
            Model.Properties.GridLineColor = Color.FromArgb( 64, 64, 64 );

            // Style Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            GridVisualStyles = GridVisualStyles.Office2010Black;
            EnableAddNew = true;
            EnableEdit = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            AlphaBlendSelectionColor = ColorConfig.BorderColorBlue;
            Properties.BackgroundColor = ColorConfig.BackColorBlack;
            Properties.CenterHorizontal = true;
            Properties.CenterVertical = true;
            Properties.ColHeaders = true;
            Properties.RowHeaders = true;
            Properties.Buttons3D = true;

            // Table Style Properties
            TableStyle.Themed = true;
            TableStyle.WrapText = false;
            TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            TableStyle.AutoFit = AutoFitOptions.Both;
            TableStyle.Font.Facename = "consolas";
            TableStyle.Font.Size = 8;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetGridPanel"/>
        /// class.
        /// </summary>
        /// <param name = "size" > The size. </param>
        /// <param name = "location" > The location. </param>
        public BudgetGridPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetGridPanel"/>
        /// class.
        /// </summary>
        /// <param name = "datagrid" > The datagrid. </param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public BudgetGridPanel( GridDataBoundGrid datagrid )
            : this( datagrid.Size, datagrid.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetGridPanel"/>
        /// class.
        /// </summary>
        /// <param name = "size" > The size. </param>
        /// <param name = "location" > The location. </param>
        /// <param name = "parent" > The parent. </param>
        public BudgetGridPanel( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        // ***************************************************************************************************************************
        // ******************************************************   PROPERTIES   *****************************************************
        // ***************************************************************************************************************************

        /// <summary> Gets or sets the tool bar. </summary>
        /// <value> The tool bar. </value>
        public ToolPanel ToolBar { set; get; }

        /// <summary> Gets or sets the grid panel. </summary>
        /// <value> The grid panel. </value>
        public GroupBoxPanel GridBoxPanel { get; set; }

        /// <summary> Gets or sets the current. </summary>
        /// <value> The current. </value>
        public DataRow Current { get; set; }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public void SetColumnWidth( GridBoundColumnsCollection columns )
        {
            if( columns.Count > 0 )
            {
                try
                {
                    for( var i = 0; i < columns.Count; i++ )
                    {
                        switch( i )
                        {
                            case 0:
                            {
                                Model.ColWidths[ i ] = 40;
                                Model.RowHeights[ i ] = 30;
                                break;
                            }

                            case 1:
                            {
                                Model.ColWidths[ i ] = 40;
                                Model.RowHeights[ i ] = 22;
                                break;
                            }
                        }

                        if( i > 1 )
                        {
                            Model.ColWidths[ i ] = 90;
                            Model.RowHeights[ i ] = 22;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the grid bound data columns. </summary>
        /// <param name = "data" > The data. </param>
        public void SetGridBoundDataColumns( IEnumerable<DataRow> data )
        {
            if( data.Any() )
            {
                var table = data.CopyToDataTable();

                foreach( DataColumn col in table.Columns )
                {
                    var gridcolumn = new GridBoundColumn();
                    gridcolumn.HeaderText = col.Caption;
                    gridcolumn.StyleInfo.Font.Bold = true;
                    gridcolumn.StyleInfo.BackColor = ColorConfig.BackColorBlack;
                    gridcolumn.StyleInfo.TextColor = Color.White;
                    gridcolumn.BackColor = ColorConfig.BackColorBlack;
                    gridcolumn.MappingName = col.ColumnName;
                    GridBoundColumns.Add( gridcolumn );
                }

                PascalizeHeaders( data, GridBoundColumns );
                SetColumnWidth( GridBoundColumns );
            }
        }

        /// <summary> Sets the data source. </summary>
        /// <param name = "data" > The data. </param>
        /// <param name = "dict" > </param>
        public void SetBindingSource( IEnumerable<DataRow> data, IDictionary<string, object> dict = null )
        {
            switch( data?.Any() )
            {
                case true when dict == null:
                    try
                    {
                        SetGridBoundDataColumns( data );
                        BindingSource.DataSource = data.CopyToDataTable();
                        Binder.DataSource = BindingSource;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }

                    break;

                case true when dict != null:
                    try
                    {
                        SetGridBoundDataColumns( data );
                        BindingSource.DataSource = data.CopyToDataTable();
                        BindingSource.Filter = GetFilterValues( dict );
                        Binder.DataSource = BindingSource;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }

                    break;
            }
        }

        /// <summary> Sets the binding source. </summary>
        /// <param name = "bindingsource" > The bindingsource. </param>
        /// <param name = "dict" > The dictionary. </param>
        public void SetBindingSource( BindingSource bindingsource, IDictionary<string, object> dict = null )
        {
            if( bindingsource.DataSource != null
                && dict == null )
            {
                try
                {
                    SetGridBoundDataColumns( bindingsource.DataSource as IEnumerable<DataRow> );

                    BindingSource.DataSource = ( bindingsource.DataSource as IEnumerable<DataRow> )
                        ?.CopyToDataTable();

                    Binder.DataSource = BindingSource;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
            else if( bindingsource?.DataSource != null
                && dict != null )
            {
                try
                {
                    SetGridBoundDataColumns( bindingsource.DataSource as IEnumerable<DataRow> );

                    BindingSource.DataSource = ( bindingsource.DataSource as IEnumerable<DataRow> )
                        ?.CopyToDataTable();

                    if( Verify.Input( BindingSource.Filter ) )
                    {
                        BindingSource.RemoveFilter();
                        BindingSource.Filter = GetFilterValues( dict );
                    }

                    if( string.IsNullOrEmpty( BindingSource.Filter ) )
                    {
                        BindingSource.Filter = GetFilterValues( dict );
                    }

                    Binder.DataSource = BindingSource.DataSource;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Pascalizes the headers. </summary>
        public void PascalizeHeaders( IEnumerable<DataRow> data, GridBoundColumnsCollection gridcolumns )
        {
            if( data.Any()
                && gridcolumns.Count > 0 )
            {
                try
                {
                    var table = data.CopyToDataTable();
                    var datacolumns = table.GetColumnNames();

                    for( var i = 0; i < gridcolumns?.Count; i++ )
                    {
                        gridcolumns[ i ].HeaderText = datacolumns[ i ].Contains( "Id" )
                            ? "ID"
                            : datacolumns[ i ]?.SplitPascal();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Gets the filter values. </summary>
        /// <param name = "dict" > The dictionary. </param>
        /// <returns> </returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            {
                if( dict?.Any() == true )
                {
                    try
                    {
                        var vals = string.Empty;

                        foreach( var kvp in dict )
                        {
                            vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                        }

                        return vals.TrimEnd( "AND ".ToCharArray() );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                        return default;
                    }
                }

                return default;
            }
        }

        /// <summary> Gets the current data row. </summary>
        /// <returns> </returns>
        public DataRow GetCurrentRow()
        {
            if( Binder?.DataSource != null )
            {
                try
                {
                    var currencymanager = (CurrencyManager)BindingContext[ DataSource ];
                    var index = Binder.CurrentPosition;
                    var dataview = (DataView)currencymanager.List;

                    if( index > -1 )
                    {
                        var datarow = dataview[ index ].Row;
                        return datarow ?? default;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary> Sets the group panel. </summary>
        public void SetGridPanel()
        {
            try
            {
                var location = new Point( Location.X - 6, Location.Y - 6 );
                var size = new Size( Size.Width + 3, Size.Height + 66 );
                var gridpanel = new GroupBoxPanel( size, location );
                gridpanel.Border.Color = ColorConfig.BorderColorBlue;
                gridpanel.Padding = new Padding( 3, 1, 3, 1 );

                if( ToolBar != null )
                {
                    gridpanel.Controls.Add( ToolBar );
                }

                GridBoxPanel = gridpanel;
                GridBoxPanel.Controls.Add( this );
                Dock = DockStyle.Bottom;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the toolbar. </summary>
        public void SetToolBar()
        {
            try
            {
                var toolbar = new ToolPanel();
                GridBoxPanel?.Controls.Add( ToolBar );
                toolbar.Dock = DockStyle.Fill;
                toolbar.Dock = DockStyle.Bottom;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary> Called when [right click]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right
                && Binder.CurrentRowIndex <= 1 )
            {
                try
                {
                    var colconfig = new ColumnConfiguration( this );
                    colconfig?.ColumnListBox?.Items?.Clear();

                    foreach( var name in colconfig?.ColumnNames )
                    {
                        colconfig?.ColumnListBox?.Items?.Add( name.SplitPascal(), false );
                    }

                    colconfig.Location = PointToScreen( new Point( e.X, e.Y ) );
                    colconfig.TopMost = true;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
        public void OnCurrentChanged( object sender, EventArgs e )
        {
            try
            {
                Current = GetCurrentRow();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public void ModelOnSelectionChanged( object sender, GridSelectionChangedEventArgs e )
        {
            try
            {
                Current = GetCurrentRow();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}
