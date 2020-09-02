
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
            this.DataChart = new BudgetExecution.BudgetChartPanel();
            this.ToolBarControl = new BudgetExecution.ToolBarControl();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.BackPanel.SuspendLayout();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
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
            this.BackPanel.Controls.Add(this.ToolBarControl);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(1105, 499);
            this.BackPanel.TabIndex = 2;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackPanel.ToolTip = null;
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 2;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.DataGrid, 0, 0);
            this.Table.Controls.Add(this.DataChart, 1, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Size = new System.Drawing.Size(1105, 447);
            this.Table.TabIndex = 0;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowDragSelectedCols = true;
            this.DataGrid.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataGrid.BindingSource = this.BudgetBinding;
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
            this.DataGrid.Numeric = BudgetExecution.Numeric.NS;
            this.DataGrid.OptimizeInsertRemoveCells = true;
            this.DataGrid.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataGrid.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGrid.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DataGrid.Size = new System.Drawing.Size(551, 445);
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
            // DataChart
            // 
            this.DataChart.AllowGradientPalette = true;
            this.DataChart.AllowUserEditStyles = true;
            this.DataChart.AutoHighlight = true;
            this.DataChart.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.DataChart.BindingSource = this.BudgetBinding;
            this.DataChart.ChartArea.AutoScale = true;
            this.DataChart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.DataChart.ChartArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataChart.ChartArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataChart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.DataChart.ChartArea.CursorReDraw = false;
            this.DataChart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(3, 3, 3, 3);
            this.DataChart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.LightGray, System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.DataChart.DataSourceName = "[none]";
            this.DataChart.Depth = 250F;
            this.DataChart.DisplayChartContextMenu = false;
            this.DataChart.DisplaySeriesContextMenu = false;
            this.DataChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataChart.EnableMouseRotation = true;
            this.DataChart.IsWindowLess = false;
            // 
            // 
            // 
            this.DataChart.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))));
            this.DataChart.Legend.Font = new System.Drawing.Font("Roboto", 8F);
            this.DataChart.Legend.ItemsAlignment = System.Drawing.StringAlignment.Center;
            this.DataChart.Legend.ItemsSize = new System.Drawing.Size(12, 12);
            this.DataChart.Legend.Location = new System.Drawing.Point(440, 64);
            this.DataChart.Legend.ShowItemsShadow = true;
            this.DataChart.Legend.ShowSymbol = true;
            this.DataChart.Legend.VisibleCheckBox = true;
            this.DataChart.Localize = null;
            this.DataChart.Location = new System.Drawing.Point(556, 4);
            this.DataChart.Name = "DataChart";
            this.DataChart.Padding = new System.Windows.Forms.Padding(1);
            this.DataChart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.DataChart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.DataChart.PrimaryXAxis.Margin = true;
            this.DataChart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.DataChart.PrimaryYAxis.Margin = true;
            this.DataChart.RealMode3D = true;
            this.DataChart.Rotation = 0.1F;
            this.DataChart.Series3D = true;
            this.DataChart.SeriesHighlight = true;
            this.DataChart.ShadowColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))), System.Drawing.Color.Silver);
            this.DataChart.ShowScrollBars = false;
            this.DataChart.Size = new System.Drawing.Size(545, 439);
            this.DataChart.Spacing = 5F;
            this.DataChart.SpacingBetweenPoints = 5F;
            this.DataChart.Style3D = true;
            this.DataChart.TabIndex = 1;
            this.DataChart.Text = "Title";
            this.DataChart.Tilt = 5F;
            // 
            // 
            // 
            this.DataChart.Title.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataChart.Title.Name = "Default";
            this.DataChart.Titles.Add(this.DataChart.Title);
            // 
            // ToolBarControl
            // 
            this.ToolBarControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolBarControl.BindingSource = this.BudgetBinding;
            this.ToolBarControl.DataFilter = null;
            this.ToolBarControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolBarControl.Field = BudgetExecution.Field.NS;
            this.ToolBarControl.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarControl.ForeColor = System.Drawing.Color.LightGray;
            this.ToolBarControl.HoverText = null;
            this.ToolBarControl.Location = new System.Drawing.Point(0, 447);
            this.ToolBarControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.ToolBarControl.Name = "ToolBarControl";
            this.ToolBarControl.Numeric = BudgetExecution.Numeric.NS;
            this.ToolBarControl.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.ToolBarControl.Size = new System.Drawing.Size(1105, 52);
            this.ToolBarControl.TabIndex = 1;
            this.ToolBarControl.ToolButtons = null;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // ChartDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackPanel);
            this.MaximumSize = new System.Drawing.Size(1900, 1060);
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "ChartDataGrid";
            this.Size = new System.Drawing.Size(1107, 501);
            this.BackPanel.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public LayoutPanel BackPanel;

        public TableLayoutPanel Table;

        public BudgetGridPanel DataGrid;

        public BudgetChartPanel DataChart;
        public ToolBarControl ToolBarControl;
        public BudgetBinding BudgetBinding;
    }
    
}
