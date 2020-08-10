// <copyright file = "DataGridPanel.cs" company = "Terry D. Eppler">
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
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.DataGridView" />
    /// <seealso/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class DataGridPanel : GridData, IDataGrid
    {
        // ***************************************************************************************************************************
        // ******************************************************  CONSTRUCTORS  *****************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGridPanel" />
        /// class.
        /// </summary>
        public DataGridPanel()
        {
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 8, FontStyle.Bold );
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            SizeConfig.GetSize( 700, 400 );
            Anchor = ControlConfig.GetAnchorStyle();
            EnableHeadersVisualStyles = false;
            BackColor = ColorConfig.BackColorBlack;
            BorderStyle = BorderStyle.FixedSingle;
            BackgroundColor = BackColor;

            // Column Configuration
            AllowUserToOrderColumns = true;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            ColumnHeadersHeight = 35;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 11, FontStyle.Bold );
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Row Configuration
            RowHeadersWidth = 26;
            RowHeadersDefaultCellStyle.BackColor = ColorConfig.ForeColorGray;
            RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 10, FontStyle.Bold );
            RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            RowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
            RowsDefaultCellStyle.Font = new Font( "Roboto", 10 );
            RowsDefaultCellStyle.ForeColor = Color.Black;
            RowsDefaultCellStyle.SelectionBackColor = SystemColors.ControlLight;
            RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            // Epilog
            Visible = true;
            Enabled = true;
            ColumnHeaderMouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGridPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public DataGridPanel( Size size, Point location )
            : this()
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridPanel"/> class.
        /// </summary>
        /// <param name="datagrid">The datagrid.</param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public DataGridPanel( DataGridView datagrid )
            : this( datagrid.Size, datagrid.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGridPanel" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public DataGridPanel( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
        }

        // ***************************************************************************************************************************
        // *******************************************************      METHODS        ***********************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets the column configuration.
        /// </summary>
        public void SetColumnConfiguration()
        {
            try
            {
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
                ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 11, FontStyle.Bold );
                ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the row configuration.
        /// </summary>
        public void SetRowConfiguration()
        {
            try
            {
                RowHeadersDefaultCellStyle = new DataGridViewCellStyle();
                RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 10, FontStyle.Bold );
                RowHeadersDefaultCellStyle.BackColor = ColorConfig.ForeColorGray;
                RowsDefaultCellStyle = new DataGridViewCellStyle();
                RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                RowsDefaultCellStyle.SelectionBackColor = SystemColors.ControlLight;
                RowsDefaultCellStyle.ForeColor = Color.Black;
                RowsDefaultCellStyle.Font = new Font( "Roboto", 10 );
                RowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( IEnumerable<DataRow> data, IDictionary<string, object> dict )
        {
            if( Verify.Input( data )
                && dict?.Any() == true )
            {
                try
                {
                    if( Verify.Input( BindingSource.Filter ) )
                    {
                        BindingSource.RemoveFilter();
                    }

                    BindingSource.DataSource = data.CopyToDataTable();
                    BindingSource.Filter = GetFilterValues( dict );
                    DataSource = BindingSource;
                    PascalizeHeaders( data );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( BindingSource bindingsource, IDictionary<string, object> dict )
        {
            if( bindingsource?.DataSource != null
                && dict?.Any() == true )
            {
                try
                {
                    if( Verify.Input( BindingSource.Filter ) )
                    {
                        BindingSource.RemoveFilter();
                    }

                    BindingSource.DataSource = ( bindingsource.DataSource as IEnumerable<DataRow> )
                        ?.CopyToDataTable();

                    BindingSource.Filter = GetFilterValues( dict );
                    DataSource = BindingSource;
                    PascalizeHeaders( BindingSource.DataSource as IEnumerable<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Pascalizes the headers.
        /// </summary>
        /// <param name="data">The data.</param>
        public void PascalizeHeaders( IEnumerable<DataRow> data )
        {
            if( Verify.Input( data ) )
            {
                try
                {
                    if( data?.CopyToDataTable()?.Columns?.Count > 0 )
                    {
                        foreach( DataColumn column in data.CopyToDataTable().Columns )
                        {
                            foreach( DataGridViewColumn gridcol in Columns )
                            {
                                gridcol.HeaderText = column.Caption;
                            }
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
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            {
                if( dict != null )
                {
                    try
                    {
                        var vals = string.Empty;

                        foreach( var kvp in dict )
                        {
                            vals += $"{kvp.Key} = '{kvp.Value}' AND ";
                        }

                        return vals.Trim().Substring( 0, vals.Length - 4 );
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

        /// <summary>
        /// Gets the current data row.
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrentDataRow()
        {
            try
            {
                using var message = new Message( "Not Yet Implemented." );
                message?.ShowDialog();
                return default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        // ***************************************************************************************************************************
        // ****************************************************   EVENTS/DELEGATES  **************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="DataGridViewCellMouseEventArgs" /> instance containing the event data.</param>
        public void OnRightClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    using var config = new ColumnConfiguration( this );

                    foreach( DataGridViewColumn c in Columns )
                    {
                        config.ColumnListBox.Items.Add( c.HeaderText, c.Visible );
                    }

                    config.ColumnListBox.Items.Clear();
                    config.Location = PointToScreen( new Point( e.X, e.Y ) );
                    config.ShowDialog();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}