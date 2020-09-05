namespace BudgetExecution
{
    partial class RichTextBoxControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.RichTextBox = new BudgetExecution.RichTextPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.RichTextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.RichTextBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.RichTextBox.BindingSource = this.BudgetBinding;
            this.RichTextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.RichTextBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.RichTextBox.Border.HoverVisible = true;
            this.RichTextBox.Border.Rounding = 6;
            this.RichTextBox.Border.Thickness = 1;
            this.RichTextBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.RichTextBox.Border.Visible = true;
            this.RichTextBox.DataFilter = null;
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Field = BudgetExecution.Field.NS;
            this.RichTextBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.RichTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.RichTextBox.MaxLength = 2147483647;
            this.RichTextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Numeric = BudgetExecution.Numeric.NS;
            this.RichTextBox.ReadOnly = false;
            this.RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.RichTextBox.ShowSelectionMargin = false;
            this.RichTextBox.Size = new System.Drawing.Size(161, 33);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.RichTextBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RichTextBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RichTextBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RichTextBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.RichTextBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.RichTextBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.RichTextBox.ToolTip = this.ToolTip;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.Color.Blue;
            this.ToolTip.ForeColor = System.Drawing.Color.LightGray;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Design.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipTitle = "";
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.HoverColor = System.Drawing.Color.Blue;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.RichTextBox);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(5);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(161, 33);
            this.BackPanel.TabIndex = 1;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackPanel.ToolTip = null;
            // 
            // RichTextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BindingSource = this.BudgetBinding;
            this.Controls.Add(this.BackPanel);
            this.Name = "RichTextBoxControl";
            this.Size = new System.Drawing.Size(163, 35);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
        public RichTextPanel RichTextBox;
        public LayoutPanel BackPanel;
    }
}
