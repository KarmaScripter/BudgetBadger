namespace BudgetExecution
{
    partial class RotatingTileControl
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
            Syncfusion.Windows.Forms.Tools.TextItem textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem();
            this.Tile = new BudgetExecution.RotatingPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.ImageList = new BudgetExecution.ImageList();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tile
            // 
            this.Tile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            textItem1.Font = new System.Drawing.Font("Roboto", 8F);
            textItem1.HubTile = this.Tile;
            textItem1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Tile.Banner = textItem1;
            this.Tile.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Tile.BindingSource = this.BudgetBinding;
            textItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem2.HubTile = this.Tile;
            this.Tile.Body = textItem2;
            this.Tile.BodyText = null;
            this.Tile.DataFilter = null;
            this.Tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tile.EnableTileSlideEffect = false;
            this.Tile.Field = BudgetExecution.Field.NS;
            this.Tile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.Font = new System.Drawing.Font("Roboto", 10F);
            textItem3.HubTile = this.Tile;
            textItem3.TextColor = System.Drawing.Color.LightGray;
            this.Tile.Footer = textItem3;
            this.Tile.FooterText = null;
            this.Tile.ForeColor = System.Drawing.Color.LightGray;
            this.Tile.HoveredBorderColor = System.Drawing.Color.SteelBlue;
            this.Tile.Icon = null;
            this.Tile.ImagePath = null;
            this.Tile.Images = null;
            this.Tile.Location = new System.Drawing.Point(0, 0);
            this.Tile.Margin = new System.Windows.Forms.Padding(5);
            this.Tile.MinimumSize = new System.Drawing.Size(100, 100);
            this.Tile.Name = "Tile";
            this.Tile.Padding = new System.Windows.Forms.Padding(1);
            this.Tile.ShowRotateTileBanner = true;
            this.Tile.Size = new System.Drawing.Size(198, 158);
            this.Tile.TabIndex = 0;
            this.Tile.TileSize = new System.Drawing.Size(200, 160);
            this.Tile.TileType = Syncfusion.Windows.Forms.Tools.HubTileType.RotateTile;
            textItem4.Font = new System.Drawing.Font("Roboto", 12F);
            textItem4.HubTile = this.Tile;
            textItem4.TextColor = System.Drawing.Color.LightGray;
            this.Tile.Title = textItem4;
            this.Tile.TitleText = null;
            this.Tile.ToolTip = this.ToolTip;
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
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.BindingSource = null;
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.Tile);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(5);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(198, 158);
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
            // ImageList
            // 
            this.ImageList.BindingSouce = null;
            this.ImageList.BudgetImage = null;
            this.ImageList.BudgetImages = null;
            this.ImageList.Source = BudgetExecution.ImageSource.NS;
            // 
            // RotatingTileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BindingSource = this.BudgetBinding;
            this.Controls.Add(this.BackPanel);
            this.Name = "RotatingTileControl";
            this.Size = new System.Drawing.Size(200, 160);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LayoutPanel BackPanel;
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
        public RotatingPanel Tile;
        public ImageList ImageList;
    }
}
