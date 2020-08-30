namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using Syncfusion.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Interactivity;

    partial class Error : MetroForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.Info = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.StackPanel = new BudgetExecution.RichTextPanel();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.LightGray;
            this.Info.Location = new System.Drawing.Point(38, 31);
            this.Info.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Info.Name = "Info";
            this.Info.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Info.Outline = false;
            this.Info.OutlineColor = System.Drawing.Color.Red;
            this.Info.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Info.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.ReflectionSpacing = 0;
            this.Info.ShadowColor = System.Drawing.Color.Black;
            this.Info.ShadowDirection = 315;
            this.Info.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Info.ShadowOpacity = 100;
            this.Info.Size = new System.Drawing.Size(557, 20);
            this.Info.TabIndex = 0;
            this.Info.Text = "Source :";
            this.Info.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Info.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Info.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Info.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Info.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // StackPanel
            // 
            this.StackPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.StackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.StackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.StackPanel.BindingSource = null;
            this.StackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StackPanel.Border.HoverColor = System.Drawing.Color.Maroon;
            this.StackPanel.Border.HoverVisible = true;
            this.StackPanel.Border.Rounding = 6;
            this.StackPanel.Border.Thickness = 1;
            this.StackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.StackPanel.Border.Visible = true;
            this.StackPanel.DataFilter = null;
            this.StackPanel.Field = BudgetExecution.Field.NS;
            this.StackPanel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.StackPanel.Location = new System.Drawing.Point(38, 59);
            this.StackPanel.Margin = new System.Windows.Forms.Padding(5);
            this.StackPanel.MaxLength = 2147483647;
            this.StackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.StackPanel.Name = "StackPanel";
            this.StackPanel.Numeric = BudgetExecution.Numeric.NS;
            this.StackPanel.ReadOnly = false;
            this.StackPanel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.StackPanel.ShowSelectionMargin = false;
            this.StackPanel.Size = new System.Drawing.Size(557, 396);
            this.StackPanel.TabIndex = 1;
            this.StackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.StackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.StackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.StackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(650, 517);
            this.Controls.Add(this.StackPanel);
            this.Controls.Add(this.Info);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);

        }

        #endregion
        public RichTextPanel StackPanel;
        public VisualLabel Info;
    }
}
