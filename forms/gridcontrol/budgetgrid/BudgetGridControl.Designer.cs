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

    partial class BudgetGridControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetGridControl));
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo2 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.DataGrid = new BudgetExecution.BudgetGridPanel();
            this.InfoSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolBar = new BudgetExecution.ToolPanel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Label = new BudgetExecution.BarLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FirstButton = new BudgetExecution.BarButton();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PreviousButton = new BudgetExecution.BarButton();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TextBox = new BudgetExecution.BarTextBox();
            this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
            this.NextButton = new BudgetExecution.BarButton();
            this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
            this.LastButton = new BudgetExecution.BarButton();
            this.Separator7 = new System.Windows.Forms.ToolStripSeparator();
            this.InsertButton = new BudgetExecution.BarButton();
            this.Separator8 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteButton = new BudgetExecution.BarButton();
            this.Separator9 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new BudgetExecution.BarButton();
            this.Separator10 = new System.Windows.Forms.ToolStripSeparator();
            this.CalculatorButton = new BudgetExecution.BarButton();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoSource)).BeginInit();
            this.ToolBar.SuspendLayout();
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
            this.BackPanel.Border.HoverVisible = true;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.DataGrid);
            this.BackPanel.Controls.Add(this.ToolBar);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(863, 446);
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Text = "layoutPanel1";
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowDragSelectedCols = true;
            this.DataGrid.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataGrid.BindingSource = this.InfoSource;
            this.DataGrid.Current = null;
            this.DataGrid.DataFilter = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("DataGrid.DataFilter")));
            this.DataGrid.DataMember = "";
            this.DataGrid.DataSource = this.InfoSource;
            this.DataGrid.DefaultRowHeight = 22;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.ExcelLikeAlignment = true;
            this.DataGrid.ExcelLikeSelectionFrame = true;
            this.DataGrid.Field = BudgetExecution.Field.NS;
            this.DataGrid.Font = new System.Drawing.Font("Consolas", 8F);
            this.DataGrid.ForeColor = System.Drawing.Color.White;
            this.DataGrid.GridBoxPanel = null;
            this.DataGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Black;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Numeric = BudgetExecution.Numeric.Default;
            this.DataGrid.OptimizeInsertRemoveCells = true;
            this.DataGrid.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataGrid.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGrid.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DataGrid.Size = new System.Drawing.Size(863, 414);
            this.DataGrid.SmartSizeBox = false;
            this.DataGrid.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.DataGrid.TabIndex = 0;
            gridStyleInfo2.AutoFit = Syncfusion.Windows.Forms.Grid.AutoFitOptions.Both;
            gridStyleInfo2.Font.Bold = false;
            gridStyleInfo2.Font.Facename = "consolas";
            gridStyleInfo2.Font.Italic = false;
            gridStyleInfo2.Font.Size = 8F;
            gridStyleInfo2.Font.Strikeout = false;
            gridStyleInfo2.Font.Underline = false;
            gridStyleInfo2.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridStyleInfo2.Themed = true;
            gridStyleInfo2.WrapText = false;
            this.DataGrid.TableStyle = gridStyleInfo2;
            this.DataGrid.Text = "budgetGridPanel1";
            this.DataGrid.ThemesEnabled = true;
            this.DataGrid.ToolBar = null;
            this.DataGrid.UseListChangedEvent = true;
            this.DataGrid.UseRightToLeftCompatibleTextBox = true;
            // 
            // InfoSource
            // 
            this.InfoSource.DataMember = "Info";
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolBar.BindingSource = this.InfoSource;
            this.ToolBar.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolBar.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Bottom;
            this.ToolBar.DataFilter = null;
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolBar.Field = BudgetExecution.Field.NS;
            this.ToolBar.Font = new System.Drawing.Font("Roboto", 8F);
            this.ToolBar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.Image = null;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.CalculatorButton,
            this.SaveButton,
            this.toolStripSeparator2,
            this.DeleteButton,
            this.Separator3,
            this.InsertButton,
            this.Separator6,
            this.LastButton,
            this.Separator8,
            this.NextButton,
            this.Separator5,
            this.TextBox,
            this.Separator7,
            this.PreviousButton,
            this.Separator9,
            this.FirstButton,
            this.Separator4,
            this.Label,
            this.Separator10});
            this.ToolBar.Location = new System.Drawing.Point(0, 414);
            this.ToolBar.Margin = new System.Windows.Forms.Padding(3);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Numeric = BudgetExecution.Numeric.Default;
            this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolBar.ShowCaption = false;
            this.ToolBar.Size = new System.Drawing.Size(863, 32);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "toolBarPanel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // Label
            // 
            this.Label.BindingSource = this.InfoSource;
            this.Label.Field = BudgetExecution.Field.NS;
            this.Label.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label.ForeColor = System.Drawing.Color.LightGray;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(64, 28);
            this.Label.Tag = "Label";
            this.Label.Text = "Commands";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // FirstButton
            // 
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.FirstButton.Bar = BudgetExecution.Tool.FirstButton;
            this.FirstButton.BindingSource = this.InfoSource;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.NS;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.FirstButton.ForeColor = System.Drawing.Color.LightGray;
            this.FirstButton.HoverText = null;
            this.FirstButton.Image = ((System.Drawing.Image)(resources.GetObject("FirstButton.Image")));
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(23, 20);
            this.FirstButton.Text = "barButton1";
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 30);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PreviousButton.Bar = BudgetExecution.Tool.PreviousButton;
            this.PreviousButton.BindingSource = this.InfoSource;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.NS;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            this.PreviousButton.HoverText = null;
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(23, 20);
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(6, 30);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TextBox.BindingSource = this.InfoSource;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Field = BudgetExecution.Field.NS;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.HoverText = null;
            this.TextBox.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.TextBox.Name = "TextBox";
            this.TextBox.Padding = new System.Windows.Forms.Padding(1);
            this.TextBox.Size = new System.Drawing.Size(176, 28);
            this.TextBox.Tag = "";
            // 
            // Separator5
            // 
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(6, 30);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.NextButton.Bar = BudgetExecution.Tool.NextButton;
            this.NextButton.BindingSource = this.InfoSource;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.NS;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.NextButton.ForeColor = System.Drawing.Color.LightGray;
            this.NextButton.HoverText = null;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(23, 20);
            this.NextButton.Text = "barButton3";
            // 
            // Separator6
            // 
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 30);
            // 
            // LastButton
            // 
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.LastButton.Bar = BudgetExecution.Tool.LastButton;
            this.LastButton.BindingSource = this.InfoSource;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.NS;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.LastButton.ForeColor = System.Drawing.Color.LightGray;
            this.LastButton.HoverText = null;
            this.LastButton.Image = ((System.Drawing.Image)(resources.GetObject("LastButton.Image")));
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(23, 20);
            this.LastButton.Text = "barButton4";
            // 
            // Separator7
            // 
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(6, 30);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.InsertButton.Bar = BudgetExecution.Tool.InsertButton;
            this.InsertButton.BindingSource = this.InfoSource;
            this.InsertButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertButton.Field = BudgetExecution.Field.NS;
            this.InsertButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.InsertButton.ForeColor = System.Drawing.Color.LightGray;
            this.InsertButton.HoverText = null;
            this.InsertButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertButton.Image")));
            this.InsertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(23, 20);
            this.InsertButton.Text = "barButton5";
            // 
            // Separator8
            // 
            this.Separator8.Name = "Separator8";
            this.Separator8.Size = new System.Drawing.Size(6, 30);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DeleteButton.Bar = BudgetExecution.Tool.DeleteButton;
            this.DeleteButton.BindingSource = this.InfoSource;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Field = BudgetExecution.Field.NS;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightGray;
            this.DeleteButton.HoverText = null;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 20);
            this.DeleteButton.Text = "barButton6";
            // 
            // Separator9
            // 
            this.Separator9.Name = "Separator9";
            this.Separator9.Size = new System.Drawing.Size(6, 30);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.SaveButton.Bar = BudgetExecution.Tool.SaveButton;
            this.SaveButton.BindingSource = this.InfoSource;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.NS;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.SaveButton.ForeColor = System.Drawing.Color.LightGray;
            this.SaveButton.HoverText = null;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 20);
            this.SaveButton.Text = "barButton7";
            // 
            // Separator10
            // 
            this.Separator10.Name = "Separator10";
            this.Separator10.Size = new System.Drawing.Size(6, 30);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CalculatorButton.Bar = BudgetExecution.Tool.CalculatorButton;
            this.CalculatorButton.BindingSource = this.InfoSource;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.NS;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightGray;
            this.CalculatorButton.HoverText = null;
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(23, 20);
            this.CalculatorButton.Text = "barButton8";
            // 
            // BudgetGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Controls.Add(this.BackPanel);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BudgetGridControl";
            this.Size = new System.Drawing.Size(865, 448);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoSource)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public BudgetGridPanel DataGrid;

        public ToolPanel ToolBar;

        public ToolStripSeparator toolStripSeparator1;

        public BarLabel Label;

        public ToolStripSeparator toolStripSeparator2;

        public BarButton FirstButton;

        public ToolStripSeparator Separator3;

        public BarButton PreviousButton;

        public ToolStripSeparator Separator4;

        public BarTextBox TextBox;

        public ToolStripSeparator Separator5;

        public BarButton NextButton;

        public ToolStripSeparator Separator6;

        public BarButton LastButton;

        public ToolStripSeparator Separator7;

        public BarButton InsertButton;

        public ToolStripSeparator Separator8;

        public BarButton DeleteButton;

        public ToolStripSeparator Separator9;

        public BarButton SaveButton;

        public ToolStripSeparator Separator10;

        public BarButton CalculatorButton;

        public LayoutPanel BackPanel;

        public BindingSource InfoSource;
    }
}
