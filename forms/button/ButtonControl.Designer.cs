namespace BudgetExecution
{
    partial class ButtonControl
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
            this.Button = new BudgetExecution.ButtonPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.ToolTip = new BudgetExecution.ToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Button.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Button.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Button.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.Button.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.Button.BindingSource = this.BudgetBinding;
            this.Button.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Button.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.Button.Border.HoverVisible = true;
            this.Button.Border.Rounding = 6;
            this.Button.Border.Thickness = 1;
            this.Button.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.Button.Border.Visible = true;
            this.Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button.Field = BudgetExecution.Field.NS;
            this.Button.Font = new System.Drawing.Font("Roboto", 8F);
            this.Button.ForeColor = System.Drawing.Color.LightGray;
            this.Button.HoverText = null;
            this.Button.Image = null;
            this.Button.Images = null;
            this.Button.Location = new System.Drawing.Point(1, 1);
            this.Button.Margin = new System.Windows.Forms.Padding(5);
            this.Button.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(158, 78);
            this.Button.TabIndex = 0;
            this.Button.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Button.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Button.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.Button.TextStyle.Hover = System.Drawing.Color.LightGray;
            this.Button.TextStyle.Pressed = System.Drawing.Color.White;
            this.Button.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Button.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Button.ToolTip = this.ToolTip;
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
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BindingSource = this.BudgetBinding;
            this.Controls.Add(this.Button);
            this.Name = "ButtonControl";
            this.Size = new System.Drawing.Size(160, 80);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ButtonPanel Button;
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
    }
}
