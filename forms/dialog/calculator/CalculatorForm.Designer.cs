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

        partial class CalculatorForm
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

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.Calculator = new BudgetExecution.CalculationControl();
            this.CloseBox = new BudgetExecution.ClosePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Calculator.BindingSource = null;
            this.Calculator.DataFilter = null;
            this.Calculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calculator.Field = BudgetExecution.Field.NS;
            this.Calculator.Font = new System.Drawing.Font("Roboto", 8F);
            this.Calculator.ForeColor = System.Drawing.Color.LightGray;
            this.Calculator.HoverText = null;
            this.Calculator.Location = new System.Drawing.Point(0, 24);
            this.Calculator.Margin = new System.Windows.Forms.Padding(5);
            this.Calculator.Name = "Calculator";
            this.Calculator.Numeric = BudgetExecution.Numeric.NS;
            this.Calculator.Padding = new System.Windows.Forms.Padding(1);
            this.Calculator.Size = new System.Drawing.Size(343, 368);
            this.Calculator.TabIndex = 0;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.CloseHoverBackColor = System.Drawing.Color.Maroon;
            this.CloseBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.CloseNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.CloseBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.CloseBox.ForeColor = System.Drawing.Color.LightGray;
            this.CloseBox.Location = new System.Drawing.Point(243, 0);
            this.CloseBox.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBox.MaximizeBox = true;
            this.CloseBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.MaximizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.MinimizeBox = true;
            this.CloseBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.MinimizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(100, 25);
            this.CloseBox.Style = MetroSet_UI.Design.Style.Custom;
            this.CloseBox.StyleManager = null;
            this.CloseBox.TabIndex = 1;
            this.CloseBox.Text = "closePanel1";
            this.CloseBox.ThemeAuthor = "Terry D. Eppler";
            this.CloseBox.ThemeName = "Budget Execution";
            this.CloseBox.ToolTip = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.67857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.32143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Controls.Add(this.CloseBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 24);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BindingSource = null;
            this.PictureBox.DataFilter = null;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Field = BudgetExecution.Field.NS;
            this.PictureBox.HoverText = null;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.ImageList = null;
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(56, 18);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BorderColor = System.Drawing.Color.Blue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CaptionBarHeight = 0;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(343, 392);
            this.ControlBox = false;
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.MinimizeBox = false;
            this.Name = "CalculatorForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            public CalculationControl Calculator;
        private ClosePanel CloseBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PicturePanel PictureBox;
    }
    
}