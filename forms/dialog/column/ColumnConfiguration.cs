// <copyright file="ColumnConfiguration.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
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
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "MetroForm"/>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ColumnConfiguration : MetroForm
    {
        // ***************************************************************************************************************************
        // *********************************************   CONSTRUCTORS **************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Sets Basic Properties Initializes a new instance of the
        /// <see cref = "ColumnConfiguration"/> class.
        /// </summary>
        public ColumnConfiguration()
        {
            InitializeComponent();
            Size = SizeConfig.DialogMinimum;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            BackColor = ColorConfig.BackColorBlack;
            BorderColor = ColorConfig.BorderColorBlue;
            ForeColor = ColorConfig.ForeColorGray;
            Anchor = ControlConfig.GetAnchorStyle();
            Padding = ControlConfig.Padding;
            Margin = ControlConfig.Margin;
            Dock = ControlConfig.GetDockStyle();
            Font = FontConfig.FontSizeSmall;
            Enabled = true;
            Visible = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColumnConfiguration"/> class.
        /// </summary>
        /// <param name = "dgv" >
        /// The DGV.
        /// </param>
        public ColumnConfiguration( DataGridView dgv )
            : this()
        {
            Grid = dgv;
            PopUp = new ToolStripDropDown();
            ColumnListBox.CheckOnClick = true;
            ColumnListBox.ItemCheck += OnDataGridItemChecked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColumnConfiguration"/> class.
        /// </summary>
        /// <param name = "dgv" >
        /// The DGV.
        /// </param>
        public ColumnConfiguration( DataGridPanel dgv )
            : this()
        {
            DataGridPanel = dgv;
            PopUp = new ToolStripDropDown();
            ColumnListBox.CheckOnClick = true;
            ColumnListBox.ItemCheck += OnDataGridItemChecked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColumnConfiguration"/> class.
        /// </summary>
        /// <param name = "dgv" >
        /// The DGV.
        /// </param>
        public ColumnConfiguration( BudgetGridPanel dgv )
            : this()
        {
            BudgetGridPanel = dgv;
            ColumnNames = GetBudgetGridDataColumns( BudgetGridPanel );
            PopUp = new ToolStripDropDown();
            ColumnListBox.CheckOnClick = true;
            ColumnListBox.ItemCheck += OnBudgetGridItemChecked;
        }

        // **********************************************************************************************************************
        // *************************************************   PROPERTIES   *****************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Gets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public DataGridView Grid { get; }

        /// <summary>
        /// Gets the data grid.
        /// </summary>
        /// <value>
        /// The data grid.
        /// </value>
        public DataGridPanel DataGridPanel { get; }

        /// <summary>
        /// Gets or sets the budget grid model.
        /// </summary>
        /// <value>
        /// The budget grid model.
        /// </value>
        public BudgetGridPanel BudgetGridPanel { get; }

        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        public IEnumerable<string> ColumnNames { get; }

        /// <summary>
        /// Gets the pop up.
        /// </summary>
        /// <value>
        /// The pop up.
        /// </value>
        public ToolStripDropDown PopUp { get; }

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public ToolStripControlHost Host { get; set; }

        // ***************************************************************************************************************************
        // ************************************************  METHODS   ***************************************************************
        // ***************************************************************************************************************************

        /// <summary>
        /// Gets the data grid pop up.
        /// </summary>
        /// <returns>
        /// </returns>
        private ToolStripDropDown GetDataGridPopUp()
        {
            if( DataGridPanel != null )
            {
                try
                {
                    var popup = new ToolStripDropDown();
                    return popup;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the budget grid pop up.
        /// </summary>
        /// <returns>
        /// </returns>
        private ToolStripDropDown GetBudgetGridPopUp()
        {
            if( BudgetGridPanel != null )
            {
                try
                {
                    var popup = new ToolStripDropDown();
                    return popup;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the control host.
        /// </summary>
        /// <param name = "listbox" >
        /// The listbox.
        /// </param>
        /// <returns>
        /// </returns>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        private ToolStripControlHost GetControlHost( Control listbox )
        {
            if( listbox != null )
            {
                try
                {
                    var controlhost = new ToolStripControlHost( this );
                    controlhost.AutoSize = true;
                    controlhost.Margin = Padding.Empty;
                    controlhost.Padding = Padding.Empty;
                    return controlhost;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the budget grid data columns.
        /// </summary>
        /// <param name = "datagrid" >
        /// The datagrid.
        /// </param>
        /// <returns>
        /// </returns>
        public IEnumerable<string> GetBudgetGridDataColumns( BudgetGridPanel datagrid )
        {
            try
            {
                return ( (DataTable)datagrid?.BindingSource?.DataSource )?.GetColumnNames();
            }
            catch( Exception ex )
            {
                using var error = new Error( ex );
                error?.SetText();
                error?.ShowDialog();
                return default;
            }
        }

        /// <summary>
        /// Gets the data grid data columns.
        /// </summary>
        /// <param name = "datagrid" >
        /// The datagrid.
        /// </param>
        /// <returns>
        /// </returns>
        public IEnumerable<string> GetDataGridDataColumns( DataGridPanel datagrid )
        {
            try
            {
                return ( (DataTable)datagrid?.BindingSource?.DataSource )?.GetColumnNames();
            }
            catch( Exception ex )
            {
                using var error = new Error( ex );
                error?.SetText();
                error?.ShowDialog();
                return default;
            }
        }

        // **********************************************************************************************************************
        // *************************************************   EVENTS    ********************************************************
        // **********************************************************************************************************************

        /// <summary>
        /// Called when [datagrid right click].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "DataGridViewCellMouseEventArgs"/> instance containing the
        /// event data.
        /// </param>
        public void OnDatagridRightClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right
                && Grid?.Columns != null )
            {
                try
                {
                    ColumnListBox?.Items?.Clear();

                    foreach( DataGridViewColumn c in Grid?.Columns )
                    {
                        ColumnListBox?.Items.Add( c.HeaderText, c.Visible );
                    }

                    using var colconfig = new ColumnConfiguration( Grid )
                    {
                        Location = Grid.PointToScreen( new Point( e.X, e.Y ) )
                    };

                    colconfig?.ShowDialog();
                    colconfig.TopMost = true;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Called when [budget grid right click].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "MouseEventArgs"/> instance containing the event data.
        /// </param>
        public void OnBudgetGridRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right
                && sender is GridModelDataBinder databinder
                && databinder.CurrentRowIndex <= 1 )
            {
                try
                {
                    ColumnListBox.Items.Clear();

                    foreach( var c in ColumnNames )
                    {
                        ColumnListBox.Items.Add( c, false );
                    }

                    using var columnconfiguration = new ColumnConfiguration( BudgetGridPanel )
                    {
                        Location = BudgetGridPanel.PointToScreen( new Point( e.X, e.Y ) )
                    };

                    columnconfiguration.ShowDialog();
                    columnconfiguration.TopMost = true;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Called when [data grid item checked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "ItemCheckEventArgs"/> instance containing the event data.
        /// </param>
        private void OnDataGridItemChecked( object sender, ItemCheckEventArgs e )
        {
            if( e != null )
            {
                try
                {
                    Grid.Columns[ e.Index ].Visible = e.NewValue == CheckState.Checked;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Called when [budget grid item checked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "ItemCheckEventArgs"/> instance containing the event data.
        /// </param>
        private void OnBudgetGridItemChecked( object sender, ItemCheckEventArgs e )
        {
            if( e != null )
            {
                try
                {
                    BudgetGridPanel.GridBoundColumns[ e.Index ].Hidden = e.NewValue == CheckState.Checked;
                }
                catch( Exception ex )
                {
                    using var error = new Error( ex );
                    error?.SetText();
                    error?.ShowDialog();
                }
            }
        }
    }
}