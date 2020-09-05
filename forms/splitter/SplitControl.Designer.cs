namespace BudgetExecution
{
    partial class SplitControl
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
            this.SplitPanel = new BudgetExecution.SplitPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.ToolTip = new BudgetExecution.ToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanel)).BeginInit();
            this.SplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitPanel
            // 
            this.SplitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.SplitPanel.BindingSource = null;
            this.SplitPanel.DataFilter = null;
            this.SplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPanel.Field = BudgetExecution.Field.NS;
            this.SplitPanel.ForeColor = System.Drawing.Color.LightGray;
            this.SplitPanel.LeftPanel = this.SplitPanel.Panel1;
            this.SplitPanel.Location = new System.Drawing.Point(1, 1);
            this.SplitPanel.Margin = new System.Windows.Forms.Padding(5);
            this.SplitPanel.Name = "SplitPanel";
            this.SplitPanel.Panel1MinSize = 0;
            this.SplitPanel.Panel2MinSize = 0;
            this.SplitPanel.RightPanel = this.SplitPanel.Panel2;
            this.SplitPanel.Size = new System.Drawing.Size(862, 426);
            this.SplitPanel.SplitterDistance = 431;
            this.SplitPanel.SplitterWidth = 1;
            this.SplitPanel.TabIndex = 0;
            this.SplitPanel.ToolTip = null;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
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
            // SplitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Controls.Add(this.SplitPanel);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SplitControl";
            this.Size = new System.Drawing.Size(864, 428);
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanel)).EndInit();
            this.SplitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitPanel SplitPanel;
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
    }
}
