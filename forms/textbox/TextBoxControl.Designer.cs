namespace BudgetExecution
{
    partial class TextBoxControl
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
            this.TextBox = new BudgetExecution.TextBoxPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.AlphaNumeric = false;
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.TextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.TextBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.TextBox.BindingSource = this.BudgetBinding;
            this.TextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.TextBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.TextBox.Border.HoverVisible = true;
            this.TextBox.Border.Rounding = 6;
            this.TextBox.Border.Thickness = 1;
            this.TextBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox.Border.Visible = true;
            this.TextBox.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox.ButtonBorder.HoverVisible = true;
            this.TextBox.ButtonBorder.Rounding = 6;
            this.TextBox.ButtonBorder.Thickness = 1;
            this.TextBox.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox.ButtonBorder.Visible = true;
            this.TextBox.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ButtonIndent = 3;
            this.TextBox.ButtonText = "";
            this.TextBox.ButtonVisible = false;
            this.TextBox.DataFilter = null;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Field = BudgetExecution.Field.NS;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.Image = null;
            this.TextBox.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox.ImageVisible = false;
            this.TextBox.ImageWidth = 35;
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox.Name = "TextBox";
            this.TextBox.Numeric = BudgetExecution.Numeric.NS;
            this.TextBox.PasswordChar = '\0';
            this.TextBox.ReadOnly = false;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox.Size = new System.Drawing.Size(159, 23);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox.TextBoxWidth = 149;
            this.TextBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox.ToolTip = this.ToolTip;
            this.TextBox.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox.Watermark.Text = "Watermark text";
            this.TextBox.Watermark.Visible = false;
            this.TextBox.WordWrap = true;
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
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.BackPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.TextBox);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(5);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(159, 26);
            this.BackPanel.TabIndex = 1;
            this.BackPanel.Text = "layoutPanel1";
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackPanel.ToolTip = null;
            // 
            // TextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BindingSource = this.BudgetBinding;
            this.Controls.Add(this.BackPanel);
            this.Name = "TextBoxControl";
            this.Size = new System.Drawing.Size(161, 28);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public TextBoxPanel TextBox;
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
        public LayoutPanel BackPanel;
    }
}
