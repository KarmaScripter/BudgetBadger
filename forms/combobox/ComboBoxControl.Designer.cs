namespace BudgetExecution
{
    partial class ComboBoxControl
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
            this.ComboBox = new BudgetExecution.ComboBoxPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ComboBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ComboBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ComboBox.BindingSource = this.BudgetBinding;
            this.ComboBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ComboBox.Border.HoverColor = System.Drawing.Color.Blue;
            this.ComboBox.Border.HoverVisible = true;
            this.ComboBox.Border.Rounding = 1;
            this.ComboBox.Border.Thickness = 1;
            this.ComboBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ComboBox.Border.Visible = false;
            this.ComboBox.ButtonColor = System.Drawing.Color.LightGray;
            this.ComboBox.ButtonImage = null;
            this.ComboBox.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.ComboBox.ButtonWidth = 22;
            this.ComboBox.DataFilter = null;
            this.ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox.DropDownHeight = 100;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.DropDownWidth = 200;
            this.ComboBox.Field = BudgetExecution.Field.NS;
            this.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.HoverText = null;
            this.ComboBox.ImageList = null;
            this.ComboBox.ImageVisible = false;
            this.ComboBox.Index = 0;
            this.ComboBox.IntegralHeight = false;
            this.ComboBox.ItemHeight = 24;
            this.ComboBox.ItemImageVisible = true;
            this.ComboBox.Location = new System.Drawing.Point(0, 0);
            this.ComboBox.MaxDropDownItems = 100;
            this.ComboBox.MenuItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ComboBox.MenuItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ComboBox.MenuTextColor = System.Drawing.Color.LightGray;
            this.ComboBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Numeric = BudgetExecution.Numeric.NS;
            this.ComboBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ComboBox.SeparatorVisible = false;
            this.ComboBox.Size = new System.Drawing.Size(191, 30);
            this.ComboBox.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.ComboBox.TabIndex = 0;
            this.ComboBox.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ComboBox.TextDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ComboBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ComboBox.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ComboBox.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ComboBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ComboBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox.TextStyle.Hover = System.Drawing.Color.Empty;
            this.ComboBox.TextStyle.Pressed = System.Drawing.Color.Empty;
            this.ComboBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ComboBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ComboBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ComboBox.ToolTip = this.ToolTip;
            this.ComboBox.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ComboBox.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ComboBox.Watermark.Text = "Watermark text";
            this.ComboBox.Watermark.Visible = false;
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
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
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
            this.BackPanel.Controls.Add(this.ComboBox);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(191, 33);
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
            // ComboBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.BindingSource = this.BudgetBinding;
            this.Controls.Add(this.BackPanel);
            this.Name = "ComboBoxControl";
            this.Size = new System.Drawing.Size(193, 35);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public ComboBoxPanel ComboBox;
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
        public LayoutPanel BackPanel;
    }
}
