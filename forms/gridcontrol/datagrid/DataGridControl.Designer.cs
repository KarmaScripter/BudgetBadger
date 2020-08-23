// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
        // *********************************************************  ASSEMBLIES   ********************************************************
        // ********************************************************************************************************************************
        
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;

        partial class DataGridControl
        {
            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                IContainer components = new System.ComponentModel.Container();

                System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                    new System.Windows.Forms.DataGridViewCellStyle();

                System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 =
                    new System.Windows.Forms.DataGridViewCellStyle();

                System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 =
                    new System.Windows.Forms.DataGridViewCellStyle();

                System.ComponentModel.ComponentResourceManager resources =
                    new System.ComponentModel.ComponentResourceManager( typeof( DataGridControl ) );

                this.BackPanel = new LayoutPanel();

                this.DataGrid =
                    new DataGridPanel();

                this.prcIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

                this.budgetLevelDataGridViewTextBoxColumn =
                    new System.Windows.Forms.DataGridViewTextBoxColumn();

                this.rpioCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.bFYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.fundCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.ahCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.orgCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.rcCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

                this.accountCodeDataGridViewTextBoxColumn =
                    new System.Windows.Forms.DataGridViewTextBoxColumn();

                this.bocCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.AllocationsBindingSource = new System.Windows.Forms.BindingSource( this.components );
                this.ToolBar = new ToolPanel();
                this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                this.barLabel1 = new BarLabel();
                this.barButton1 = new BarButton();
                this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                this.barButton2 = new BarButton();
                this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
                this.barTextBox1 = new BarTextBox();
                this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
                this.barButton3 = new BarButton();
                this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
                this.barButton4 = new BarButton();
                this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
                this.barButton5 = new BarButton();
                this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
                this.barButton6 = new BarButton();
                this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
                this.barButton7 = new BarButton();
                this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
                this.barButton8 = new BarButton();
                this.BackPanel.SuspendLayout();
                ( (System.ComponentModel.ISupportInitialize)( this.DataGrid ) ).BeginInit();
                ( (System.ComponentModel.ISupportInitialize)( this.AllocationsBindingSource ) ).BeginInit();
                this.ToolBar.SuspendLayout();
                this.SuspendLayout();

                // 
                // BackPanel
                // 
                this.BackPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BindingSource = null;

                this.BackPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.BackPanel.Border.HoverVisible = true;
                this.BackPanel.Border.Rounding = 6;
                this.BackPanel.Border.Thickness = 1;
                this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.BackPanel.Border.Visible = true;
                this.BackPanel.Children = null;
                this.BackPanel.Controls.Add( this.DataGrid );
                this.BackPanel.Controls.Add( this.ToolBar );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BackPanel.Field = Field.NS;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 1, 1 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BackPanel.Size = new System.Drawing.Size( 1126, 483 );
                this.BackPanel.TabIndex = 0;
                this.BackPanel.Text = "layoutPanel1";

                this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.BackPanel.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // DataGrid
                // 
                this.DataGrid.AllowUserToOrderColumns = true;
                this.DataGrid.AutoGenerateColumns = false;

                this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.DataGrid.BindingSource = null;
                this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;

                this.DataGrid.ColumnHeadersBorderStyle =
                    System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

                dataGridViewCellStyle1.Alignment =
                    System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

                dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;

                dataGridViewCellStyle1.Font =
                    new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Bold );

                dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
                dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

                this.DataGrid.ColumnHeadersHeightSizeMode =
                    System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                this.DataGrid.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.prcIdDataGridViewTextBoxColumn,
                    this.budgetLevelDataGridViewTextBoxColumn,
                    this.rpioCodeDataGridViewTextBoxColumn,
                    this.bFYDataGridViewTextBoxColumn,
                    this.fundCodeDataGridViewTextBoxColumn,
                    this.ahCodeDataGridViewTextBoxColumn,
                    this.orgCodeDataGridViewTextBoxColumn,
                    this.rcCodeDataGridViewTextBoxColumn,
                    this.accountCodeDataGridViewTextBoxColumn,
                    this.bocCodeDataGridViewTextBoxColumn,
                    this.amountDataGridViewTextBoxColumn
                } );

                this.DataGrid.DataSource = this.AllocationsBindingSource;
                this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
                this.DataGrid.EnableHeadersVisualStyles = false;
                this.DataGrid.Field = Field.NS;
                this.DataGrid.DataFilter = null;
                this.DataGrid.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Bold );
                this.DataGrid.Location = new System.Drawing.Point( 0, 0 );
                this.DataGrid.Name = "DataGrid";

                dataGridViewCellStyle2.Alignment =
                    System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;

                dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;

                dataGridViewCellStyle2.Font =
                    new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Bold );

                dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
                dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
                this.DataGrid.RowHeadersWidth = 26;

                this.DataGrid.RowHeadersWidthSizeMode =
                    System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                dataGridViewCellStyle3.Alignment =
                    System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;

                dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
                dataGridViewCellStyle3.Font = new System.Drawing.Font( "Roboto", 10F );
                dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
                dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
                dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
                this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
                this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                this.DataGrid.Size = new System.Drawing.Size( 1126, 453 );
                this.DataGrid.TabIndex = 1;

                // 
                // prcIdDataGridViewTextBoxColumn
                // 
                this.prcIdDataGridViewTextBoxColumn.DataPropertyName = "PrcId";
                this.prcIdDataGridViewTextBoxColumn.HeaderText = "PrcId";
                this.prcIdDataGridViewTextBoxColumn.Name = "prcIdDataGridViewTextBoxColumn";

                // 
                // budgetLevelDataGridViewTextBoxColumn
                // 
                this.budgetLevelDataGridViewTextBoxColumn.DataPropertyName = "BudgetLevel";
                this.budgetLevelDataGridViewTextBoxColumn.HeaderText = "BudgetLevel";
                this.budgetLevelDataGridViewTextBoxColumn.Name = "budgetLevelDataGridViewTextBoxColumn";

                // 
                // rpioCodeDataGridViewTextBoxColumn
                // 
                this.rpioCodeDataGridViewTextBoxColumn.DataPropertyName = "RpioCode";
                this.rpioCodeDataGridViewTextBoxColumn.HeaderText = "RpioCode";
                this.rpioCodeDataGridViewTextBoxColumn.Name = "rpioCodeDataGridViewTextBoxColumn";

                // 
                // bFYDataGridViewTextBoxColumn
                // 
                this.bFYDataGridViewTextBoxColumn.DataPropertyName = "BFY";
                this.bFYDataGridViewTextBoxColumn.HeaderText = "BFY";
                this.bFYDataGridViewTextBoxColumn.Name = "bFYDataGridViewTextBoxColumn";

                // 
                // fundCodeDataGridViewTextBoxColumn
                // 
                this.fundCodeDataGridViewTextBoxColumn.DataPropertyName = "FundCode";
                this.fundCodeDataGridViewTextBoxColumn.HeaderText = "FundCode";
                this.fundCodeDataGridViewTextBoxColumn.Name = "fundCodeDataGridViewTextBoxColumn";

                // 
                // ahCodeDataGridViewTextBoxColumn
                // 
                this.ahCodeDataGridViewTextBoxColumn.DataPropertyName = "AhCode";
                this.ahCodeDataGridViewTextBoxColumn.HeaderText = "AhCode";
                this.ahCodeDataGridViewTextBoxColumn.Name = "ahCodeDataGridViewTextBoxColumn";

                // 
                // orgCodeDataGridViewTextBoxColumn
                // 
                this.orgCodeDataGridViewTextBoxColumn.DataPropertyName = "OrgCode";
                this.orgCodeDataGridViewTextBoxColumn.HeaderText = "OrgCode";
                this.orgCodeDataGridViewTextBoxColumn.Name = "orgCodeDataGridViewTextBoxColumn";

                // 
                // rcCodeDataGridViewTextBoxColumn
                // 
                this.rcCodeDataGridViewTextBoxColumn.DataPropertyName = "RcCode";
                this.rcCodeDataGridViewTextBoxColumn.HeaderText = "RcCode";
                this.rcCodeDataGridViewTextBoxColumn.Name = "rcCodeDataGridViewTextBoxColumn";

                // 
                // accountCodeDataGridViewTextBoxColumn
                // 
                this.accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
                this.accountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode";
                this.accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";

                // 
                // bocCodeDataGridViewTextBoxColumn
                // 
                this.bocCodeDataGridViewTextBoxColumn.DataPropertyName = "BocCode";
                this.bocCodeDataGridViewTextBoxColumn.HeaderText = "BocCode";
                this.bocCodeDataGridViewTextBoxColumn.Name = "bocCodeDataGridViewTextBoxColumn";

                // 
                // amountDataGridViewTextBoxColumn
                // 
                this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
                this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
                this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";

                // 
                // AllocationsBindingSource
                // 
                this.AllocationsBindingSource.DataMember = "Allocations";

                // 
                // ToolBar
                // 
                this.ToolBar.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ToolBar.DataFilter = null;
                this.ToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.ToolBar.Field = Field.NS;
                this.ToolBar.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ToolBar.ForeColor = System.Drawing.Color.MidnightBlue;
                this.ToolBar.Image = null;

                this.ToolBar.Items.AddRange( new System.Windows.Forms.ToolStripItem[]
                {
                    this.toolStripSeparator1,
                    this.barLabel1,
                    this.barButton1,
                    this.toolStripSeparator2,
                    this.barButton2,
                    this.toolStripSeparator3,
                    this.barTextBox1,
                    this.toolStripSeparator4,
                    this.barButton3,
                    this.toolStripSeparator5,
                    this.barButton4,
                    this.toolStripSeparator6,
                    this.barButton5,
                    this.toolStripSeparator7,
                    this.barButton6,
                    this.toolStripSeparator8,
                    this.barButton7,
                    this.toolStripSeparator9,
                    this.barButton8
                } );

                this.ToolBar.Location = new System.Drawing.Point( 0, 453 );
                this.ToolBar.Margin = new System.Windows.Forms.Padding( 3 );
                this.ToolBar.Name = "ToolBar";
                this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
                this.ToolBar.ShowCaption = false;
                this.ToolBar.Size = new System.Drawing.Size( 1126, 30 );
                this.ToolBar.TabIndex = 0;
                this.ToolBar.Text = "toolBarPanel1";

                // 
                // toolStripSeparator1
                // 
                this.toolStripSeparator1.Name = "toolStripSeparator1";
                this.toolStripSeparator1.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barLabel1
                // 
                this.barLabel1.BindingSource = null;
                this.barLabel1.Field = Field.NS;
                this.barLabel1.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barLabel1.ForeColor = System.Drawing.Color.LightGray;
                this.barLabel1.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
                this.barLabel1.Name = "barLabel1";
                this.barLabel1.Size = new System.Drawing.Size( 55, 28 );
                this.barLabel1.Text = "Commands";

                // 
                // barButton1
                // 
                this.barButton1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barButton1.BindingSource = this.AllocationsBindingSource;
                this.barButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.barButton1.Field = Field.NS;
                this.barButton1.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barButton1.ForeColor = System.Drawing.Color.LightGray;
                this.barButton1.HoverText = null;

                this.barButton1.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "barButton1.Image" ) ) );

                this.barButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.barButton1.Margin = new System.Windows.Forms.Padding( 10, 5, 10, 5 );
                this.barButton1.Name = "barButton1";
                this.barButton1.Size = new System.Drawing.Size( 23, 20 );
                this.barButton1.Text = "barButton1";

                // 
                // toolStripSeparator2
                // 
                this.toolStripSeparator2.Name = "toolStripSeparator2";
                this.toolStripSeparator2.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barButton2
                // 
                this.barButton2.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barButton2.BindingSource = this.AllocationsBindingSource;
                this.barButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.barButton2.Field = Field.NS;
                this.barButton2.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barButton2.ForeColor = System.Drawing.Color.LightGray;
                this.barButton2.HoverText = null;

                this.barButton2.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "barButton2.Image" ) ) );

                this.barButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.barButton2.Margin = new System.Windows.Forms.Padding( 10, 5, 10, 5 );
                this.barButton2.Name = "barButton2";
                this.barButton2.Size = new System.Drawing.Size( 23, 20 );
                this.barButton2.Text = "barButton2";

                // 
                // toolStripSeparator3
                // 
                this.toolStripSeparator3.Name = "toolStripSeparator3";
                this.toolStripSeparator3.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barTextBox1
                // 
                this.barTextBox1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barTextBox1.BindingSource = this.AllocationsBindingSource;
                this.barTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.barTextBox1.Field = Field.NS;
                this.barTextBox1.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barTextBox1.ForeColor = System.Drawing.Color.LightGray;
                this.barTextBox1.HoverText = null;
                this.barTextBox1.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
                this.barTextBox1.Name = "barTextBox1";
                this.barTextBox1.Size = new System.Drawing.Size( 200, 28 );

                // 
                // toolStripSeparator4
                // 
                this.toolStripSeparator4.Name = "toolStripSeparator4";
                this.toolStripSeparator4.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barButton3
                // 
                this.barButton3.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barButton3.BindingSource = this.AllocationsBindingSource;
                this.barButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.barButton3.Field = Field.NS;
                this.barButton3.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barButton3.ForeColor = System.Drawing.Color.LightGray;
                this.barButton3.HoverText = null;

                this.barButton3.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "barButton3.Image" ) ) );

                this.barButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.barButton3.Margin = new System.Windows.Forms.Padding( 10, 5, 10, 5 );
                this.barButton3.Name = "barButton3";
                this.barButton3.Size = new System.Drawing.Size( 23, 20 );
                this.barButton3.Text = "barButton3";

                // 
                // toolStripSeparator5
                // 
                this.toolStripSeparator5.Name = "toolStripSeparator5";
                this.toolStripSeparator5.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barButton4
                // 
                this.barButton4.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barButton4.BindingSource = this.AllocationsBindingSource;
                this.barButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.barButton4.Field = Field.NS;
                this.barButton4.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barButton4.ForeColor = System.Drawing.Color.LightGray;
                this.barButton4.HoverText = null;

                this.barButton4.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "barButton4.Image" ) ) );

                this.barButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.barButton4.Margin = new System.Windows.Forms.Padding( 10, 5, 10, 5 );
                this.barButton4.Name = "barButton4";
                this.barButton4.Size = new System.Drawing.Size( 23, 20 );
                this.barButton4.Text = "barButton4";

                // 
                // toolStripSeparator6
                // 
                this.toolStripSeparator6.Name = "toolStripSeparator6";
                this.toolStripSeparator6.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barButton5
                // 
                this.barButton5.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barButton5.BindingSource = this.AllocationsBindingSource;
                this.barButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.barButton5.Field = Field.NS;
                this.barButton5.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barButton5.ForeColor = System.Drawing.Color.LightGray;
                this.barButton5.HoverText = null;

                this.barButton5.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "barButton5.Image" ) ) );

                this.barButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.barButton5.Margin = new System.Windows.Forms.Padding( 10, 5, 10, 5 );
                this.barButton5.Name = "barButton5";
                this.barButton5.Size = new System.Drawing.Size( 23, 20 );
                this.barButton5.Text = "barButton5";

                // 
                // toolStripSeparator7
                // 
                this.toolStripSeparator7.Name = "toolStripSeparator7";
                this.toolStripSeparator7.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barButton6
                // 
                this.barButton6.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barButton6.BindingSource = this.AllocationsBindingSource;
                this.barButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.barButton6.Field = Field.NS;
                this.barButton6.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barButton6.ForeColor = System.Drawing.Color.LightGray;
                this.barButton6.HoverText = null;

                this.barButton6.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "barButton6.Image" ) ) );

                this.barButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.barButton6.Margin = new System.Windows.Forms.Padding( 10, 5, 10, 5 );
                this.barButton6.Name = "barButton6";
                this.barButton6.Size = new System.Drawing.Size( 23, 20 );
                this.barButton6.Text = "barButton6";

                // 
                // toolStripSeparator8
                // 
                this.toolStripSeparator8.Name = "toolStripSeparator8";
                this.toolStripSeparator8.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barButton7
                // 
                this.barButton7.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barButton7.BindingSource = this.AllocationsBindingSource;
                this.barButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.barButton7.Field = Field.NS;
                this.barButton7.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barButton7.ForeColor = System.Drawing.Color.LightGray;
                this.barButton7.HoverText = null;

                this.barButton7.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "barButton7.Image" ) ) );

                this.barButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.barButton7.Margin = new System.Windows.Forms.Padding( 10, 5, 10, 5 );
                this.barButton7.Name = "barButton7";
                this.barButton7.Size = new System.Drawing.Size( 23, 20 );
                this.barButton7.Text = "barButton7";

                // 
                // toolStripSeparator9
                // 
                this.toolStripSeparator9.Name = "toolStripSeparator9";
                this.toolStripSeparator9.Size = new System.Drawing.Size( 6, 30 );

                // 
                // barButton8
                // 
                this.barButton8.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.barButton8.BindingSource = null;
                this.barButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.barButton8.Field = Field.NS;
                this.barButton8.Font = new System.Drawing.Font( "Roboto", 8F );
                this.barButton8.ForeColor = System.Drawing.Color.LightGray;
                this.barButton8.HoverText = null;

                this.barButton8.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "barButton8.Image" ) ) );

                this.barButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.barButton8.Margin = new System.Windows.Forms.Padding( 10, 5, 10, 5 );
                this.barButton8.Name = "barButton8";
                this.barButton8.Size = new System.Drawing.Size( 23, 20 );
                this.barButton8.Text = "barButton8";

                // 
                // DataGridControl
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

                this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Controls.Add( this.BackPanel );

                this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.Name = "DataGridControl";
                this.Size = new System.Drawing.Size( 1128, 485 );
                this.BackPanel.ResumeLayout( false );
                this.BackPanel.PerformLayout();
                ( (System.ComponentModel.ISupportInitialize)( this.DataGrid ) ).EndInit();
                ( (System.ComponentModel.ISupportInitialize)( this.AllocationsBindingSource ) ).EndInit();
                this.ToolBar.ResumeLayout( false );
                this.ToolBar.PerformLayout();
                this.ResumeLayout( false );

            }

            #endregion

            public DataGridPanel DataGrid;

            public ToolPanel ToolBar;

            private ToolStripSeparator toolStripSeparator1;

            private BarButton barButton1;

            private BarButton barButton2;

            private BarTextBox barTextBox1;

            private BarButton barButton3;

            private BarButton barButton4;

            private BarButton barButton5;

            private BarButton barButton6;

            private BarButton barButton7;

            private BarButton barButton8;

            private ToolStripSeparator toolStripSeparator2;

            private ToolStripSeparator toolStripSeparator3;

            private ToolStripSeparator toolStripSeparator4;

            private ToolStripSeparator toolStripSeparator5;

            private ToolStripSeparator toolStripSeparator6;

            private ToolStripSeparator toolStripSeparator7;

            private ToolStripSeparator toolStripSeparator8;

            private ToolStripSeparator toolStripSeparator9;

            private BarLabel barLabel1;

            private DataGridViewTextBoxColumn prcIdDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn budgetLevelDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn rpioCodeDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn bFYDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn fundCodeDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn ahCodeDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn orgCodeDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn rcCodeDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn bocCodeDataGridViewTextBoxColumn;

            private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;

            private LayoutPanel BackPanel;

            private BindingSource AllocationsBindingSource;
        }
    
}
