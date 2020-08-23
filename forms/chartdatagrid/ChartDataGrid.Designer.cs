﻿
namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    partial class ChartDataGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }

            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo1 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.DataGrid = new BudgetExecution.BudgetGridPanel();
            this.DataBinding = new System.Windows.Forms.BindingSource(this.components);
            this.Chart = new BudgetExecution.BudgetChartPanel();
            this.ToolControl = new BudgetExecution.ToolBarControl();
            this.BackPanel.SuspendLayout();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.Table);
            this.BackPanel.Controls.Add(this.ToolControl);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(1294, 598);
            this.BackPanel.TabIndex = 2;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.DataGrid, 0, 0);
            this.Table.Controls.Add(this.Chart, 1, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Size = new System.Drawing.Size(1294, 565);
            this.Table.TabIndex = 0;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowDragSelectedCols = true;
            this.DataGrid.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataGrid.BindingSource = this.DataBinding;
            this.DataGrid.Current = null;
            this.DataGrid.DataFilter = null;
            this.DataGrid.DefaultRowHeight = 22;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.ExcelLikeAlignment = true;
            this.DataGrid.ExcelLikeSelectionFrame = true;
            this.DataGrid.Field = BudgetExecution.Field.NS;
            this.DataGrid.Font = new System.Drawing.Font("Consolas", 8F);
            this.DataGrid.ForeColor = System.Drawing.Color.White;
            this.DataGrid.GridBoxPanel = null;
            this.DataGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Black;
            this.DataGrid.Location = new System.Drawing.Point(1, 1);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Numeric = BudgetExecution.Numeric.Default;
            this.DataGrid.OptimizeInsertRemoveCells = true;
            this.DataGrid.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataGrid.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGrid.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DataGrid.Size = new System.Drawing.Size(645, 563);
            this.DataGrid.SmartSizeBox = false;
            this.DataGrid.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.DataGrid.TabIndex = 0;
            gridStyleInfo1.AutoFit = Syncfusion.Windows.Forms.Grid.AutoFitOptions.Both;
            gridStyleInfo1.Font.Bold = false;
            gridStyleInfo1.Font.Facename = "consolas";
            gridStyleInfo1.Font.Italic = false;
            gridStyleInfo1.Font.Size = 8F;
            gridStyleInfo1.Font.Strikeout = false;
            gridStyleInfo1.Font.Underline = false;
            gridStyleInfo1.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridStyleInfo1.Themed = true;
            gridStyleInfo1.WrapText = false;
            this.DataGrid.TableStyle = gridStyleInfo1;
            this.DataGrid.Text = "budgetDataGrid1";
            this.DataGrid.ThemesEnabled = true;
            this.DataGrid.ToolBar = null;
            this.DataGrid.UseListChangedEvent = true;
            this.DataGrid.UseRightToLeftCompatibleTextBox = true;
            // 
            // Chart
            // 
            this.Chart.AllowGradientPalette = true;
            this.Chart.AllowUserEditStyles = true;
            this.Chart.AutoHighlight = true;
            this.Chart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.Chart.BindingSource = this.DataBinding;
            this.Chart.ChartArea.AutoScale = true;
            this.Chart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.Chart.ChartArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Chart.ChartArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Chart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart.ChartArea.CursorReDraw = false;
            this.Chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(3, 3, 3, 3);
            this.Chart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.LightGray, System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.Chart.DataSourceName = "[none]";
            this.Chart.Depth = 250F;
            this.Chart.DisplayChartContextMenu = false;
            this.Chart.DisplaySeriesContextMenu = false;
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart.EnableMouseRotation = true;
            this.Chart.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.Chart.Legend.Font = new System.Drawing.Font("Roboto", 8F);
            this.Chart.Legend.ItemsAlignment = System.Drawing.StringAlignment.Center;
            this.Chart.Legend.ItemsSize = new System.Drawing.Size(12, 12);
            this.Chart.Legend.Location = new System.Drawing.Point(535, 64);
            this.Chart.Legend.ShowItemsShadow = true;
            this.Chart.Legend.ShowSymbol = true;
            this.Chart.Legend.VisibleCheckBox = true;
            this.Chart.Localize = null;
            this.Chart.Location = new System.Drawing.Point(650, 4);
            this.Chart.Name = "Chart";
            this.Chart.Padding = new System.Windows.Forms.Padding(1);
            this.Chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.Chart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart.PrimaryXAxis.Margin = true;
            this.Chart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart.PrimaryYAxis.Margin = true;
            this.Chart.RealMode3D = true;
            this.Chart.Rotation = 0.1F;
            this.Chart.Series3D = true;
            this.Chart.SeriesHighlight = true;
            this.Chart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))), System.Drawing.Color.Silver);
            this.Chart.ShowScrollBars = false;
            this.Chart.Size = new System.Drawing.Size(640, 557);
            this.Chart.Spacing = 5F;
            this.Chart.SpacingBetweenPoints = 5F;
            this.Chart.Style3D = true;
            this.Chart.TabIndex = 1;
            this.Chart.Text = "Title";
            this.Chart.Tilt = 5F;
            // 
            // 
            // 
            this.Chart.Title.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.Title.Name = "Default";
            this.Chart.Titles.Add(this.Chart.Title);
            // 
            // ToolControl
            // 
            this.ToolControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolControl.ToolBar.BindingSource = this.DataBinding;
            this.ToolControl.ToolBar.DataFilter = null;
            this.ToolControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolControl.ToolBar.Field = BudgetExecution.Field.NS;
            this.ToolControl.Font = new System.Drawing.Font("Roboto", 8F);
            this.ToolControl.ForeColor = System.Drawing.Color.Black;
            this.ToolControl.Location = new System.Drawing.Point(0, 565);
            this.ToolControl.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ToolControl.Name = "ToolControl";
            this.ToolControl.Size = new System.Drawing.Size(1294, 33);
            this.ToolControl.TabIndex = 1;
            // 
            // ChartDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackPanel);
            this.MaximumSize = new System.Drawing.Size(1900, 1060);
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "ChartDataGrid";
            this.Size = new System.Drawing.Size(1296, 600);
            this.BackPanel.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public LayoutPanel BackPanel;

        public TableLayoutPanel Table;

        public BudgetGridPanel DataGrid;

        public BudgetChartPanel Chart;

        private BindingSource DataBinding;

        public ToolBarControl ToolControl;
    }
    
}
