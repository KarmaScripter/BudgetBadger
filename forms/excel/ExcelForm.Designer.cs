
namespace BudgetExecution
{

    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    partial class ExcelForm
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
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 = new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.Sheet = new BudgetExecution.SheetPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.Ribbon = new BudgetExecution.RibbonPanel();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.CloseBox = new BudgetExecution.ClosePanel();
            this.Label = new BudgetExecution.LabelPanel();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).BeginInit();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
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
            this.BackPanel.Controls.Add(this.Sheet);
            this.BackPanel.Controls.Add(this.Ribbon);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 27);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Hover;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(1114, 856);
            this.BackPanel.TabIndex = 0;
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
            // Sheet
            // 
            this.Sheet.AllowCellContextMenu = true;
            this.Sheet.AllowExtendRowColumnCount = true;
            this.Sheet.AllowFormulaRangeSelection = true;
            this.Sheet.AllowTabItemContextMenu = true;
            this.Sheet.AllowZooming = true;
            this.Sheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Sheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sheet.BindingSource = this.BudgetBinding;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.Sheet.CopyPaste = spreadsheetCopyPaste1;
            this.Sheet.DefaultColumnCount = 26;
            this.Sheet.DefaultRowCount = 66;
            this.Sheet.DisplayAlerts = true;
            this.Sheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sheet.FileName = "Book1";
            this.Sheet.Font = new System.Drawing.Font("Roboto", 8F);
            this.Sheet.ForeColor = System.Drawing.Color.Black;
            this.Sheet.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.Sheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.Sheet.Grid = null;
            this.Sheet.IsCustomTabItemContextMenuEnabled = false;
            this.Sheet.Location = new System.Drawing.Point(0, 162);
            this.Sheet.Model = null;
            this.Sheet.Name = "Sheet";
            this.Sheet.Padding = new System.Windows.Forms.Padding(1);
            this.Sheet.SelectedTabIndex = 0;
            this.Sheet.SelectedTabItem = null;
            this.Sheet.ShowBusyIndicator = true;
            this.Sheet.Size = new System.Drawing.Size(1114, 694);
            this.Sheet.TabIndex = 1;
            this.Sheet.TabItemContextMenu = null;
            this.Sheet.Text = "sheetPanel1";
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // Ribbon
            // 
            this.Ribbon.ActiveSheet = this.Sheet;
            this.Ribbon.AllowCollapse = false;
            this.Ribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Ribbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ribbon.BackStageNavigationButtonStyle = Syncfusion.Windows.Forms.Tools.BackStageNavigationButtonStyles.Office2013;
            this.Ribbon.BindingSource = this.BudgetBinding;
            this.Ribbon.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.Ribbon.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ribbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.Ribbon.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ribbon.Grid = null;
            this.Ribbon.HideMenuButtonToolTip = true;
            this.Ribbon.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.Ribbon.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.MenuButtonFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ribbon.MenuButtonText = "FILE";
            this.Ribbon.MenuButtonVisible = false;
            this.Ribbon.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Ribbon.Model = null;
            this.Ribbon.Name = "Ribbon";
            this.Ribbon.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            this.Ribbon.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            office2016ColorTable1.BackStageTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            office2016ColorTable1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            office2016ColorTable1.CaptionForeColor = System.Drawing.Color.LightGray;
            office2016ColorTable1.GalleryItemHoveredTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            office2016ColorTable1.LauncherColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            office2016ColorTable1.ToolStripItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Ribbon.Office2016ColorTable.Add(office2016ColorTable1);
            this.Ribbon.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // Ribbon.OfficeMenu
            // 
            this.Ribbon.OfficeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Ribbon.OfficeMenu.Margin = new System.Windows.Forms.Padding(3);
            this.Ribbon.OfficeMenu.Name = "OfficeMenu";
            this.Ribbon.OfficeMenu.ShowItemToolTips = true;
            this.Ribbon.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.Ribbon.Padding = new System.Windows.Forms.Padding(1);
            this.Ribbon.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ribbon.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.Ribbon.ShowPanelOnMouseHover = true;
            this.Ribbon.ShowQuickItemsDropDownButton = false;
            this.Ribbon.ShowRibbonDisplayOptionButton = false;
            this.Ribbon.Size = new System.Drawing.Size(1114, 162);
            this.Ribbon.Spreadsheet = this.Sheet;
            this.Ribbon.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.Ribbon.SystemText.RenameDisplayLabelText = "&Display ImageName:";
            this.Ribbon.TabIndex = 0;
            this.Ribbon.TitleColor = System.Drawing.Color.White;
            this.Ribbon.TitleFont = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            // 
            // Table
            // 
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.210032F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.78997F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.Table.Controls.Add(this.CloseBox, 2, 0);
            this.Table.Controls.Add(this.Label, 1, 0);
            this.Table.Controls.Add(this.PictureBox, 0, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table.Location = new System.Drawing.Point(1, 1);
            this.Table.Margin = new System.Windows.Forms.Padding(5);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Size = new System.Drawing.Size(1114, 26);
            this.Table.TabIndex = 1;
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBox.CloseHoverBackColor = System.Drawing.Color.Red;
            this.CloseBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.CloseNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.CloseBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.CloseBox.ForeColor = System.Drawing.Color.LightGray;
            this.CloseBox.Location = new System.Drawing.Point(1014, 0);
            this.CloseBox.Margin = new System.Windows.Forms.Padding(0);
            this.CloseBox.MaximizeBox = true;
            this.CloseBox.MaximizeHoverBackColor = System.Drawing.Color.Blue;
            this.CloseBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.MaximizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.MinimizeBox = true;
            this.CloseBox.MinimizeHoverBackColor = System.Drawing.Color.Blue;
            this.CloseBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.CloseBox.MinimizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(100, 25);
            this.CloseBox.Style = MetroSet_UI.Design.Style.Custom;
            this.CloseBox.StyleManager = null;
            this.CloseBox.TabIndex = 0;
            this.CloseBox.Text = "closePanel1";
            this.CloseBox.ThemeAuthor = "Terry D. Eppler";
            this.CloseBox.ThemeName = "Budget Execution";
            this.CloseBox.ToolTip = null;
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Label.BindingSource = this.BudgetBinding;
            this.Label.DataFilter = null;
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Field = BudgetExecution.Field.NS;
            this.Label.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.LightGray;
            this.Label.Location = new System.Drawing.Point(72, 3);
            this.Label.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label.Name = "Label";
            this.Label.Numeric = BudgetExecution.Numeric.NS;
            this.Label.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label.Outline = false;
            this.Label.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Label.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.ReflectionSpacing = 0;
            this.Label.ShadowColor = System.Drawing.Color.Black;
            this.Label.ShadowDirection = 315;
            this.Label.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label.ShadowOpacity = 100;
            this.Label.Size = new System.Drawing.Size(882, 20);
            this.Label.TabIndex = 1;
            this.Label.Text = "Label";
            this.Label.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Label.ToolTip = null;
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
            this.PictureBox.Size = new System.Drawing.Size(63, 20);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionBarHeight = 30;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1116, 884);
            this.ControlBox = false;
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.Table);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.MinimizeBox = false;
            this.Name = "ExcelForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.BackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).EndInit();
            this.Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The sheet
        /// </summary>
        public SheetPanel Sheet;

        /// <summary>
        /// The ribbon
        /// </summary>
        public RibbonPanel Ribbon;

        /// <summary>
        /// The table
        /// </summary>
        public TableLayoutPanel Table;

        /// <summary>
        /// The close box
        /// </summary>
        public ClosePanel CloseBox;

        /// <summary>
        /// The label
        /// </summary>
        public LabelPanel Label;

        /// <summary>
        /// The PictureBox
        /// </summary>
        public PicturePanel PictureBox;
        private LayoutPanel BackPanel;
        private BudgetBinding BudgetBinding;
    }
}
