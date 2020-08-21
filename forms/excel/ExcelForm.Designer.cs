
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

            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 =
                new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();

            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController
                formulaRangeSelectionController1 =
                    new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();

            Syncfusion.Windows.Forms.Tools.Office2016ColorTable office2016ColorTable1 =
                new Syncfusion.Windows.Forms.Tools.Office2016ColorTable();

            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();

            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager( typeof( ExcelForm ) );

            this.BackPanel = new LayoutPanel();
            this.Sheet = new SheetPanel();
            this.BindingSource = new System.Windows.Forms.BindingSource( this.components );
            this.Ribbon = new RibbonPanel();
            this.BackPanel.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.BindingSource ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.Ribbon ) ).BeginInit();
            this.SuspendLayout();

            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BackPanel.BindingSource = null;

            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add( this.Sheet );
            this.BackPanel.Controls.Add( this.Ribbon );
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = Field.NS;
            this.BackPanel.DataFilter = null;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point( 1, 1 );
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Hover;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
            this.BackPanel.Size = new System.Drawing.Size( 1059, 703 );
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Text = "layoutPanel1";

            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 131 ) ) ) ),
                ( (int)( ( (byte)( 129 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ) );

            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

            this.BackPanel.TextStyle.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            this.BackPanel.ToolTip = null;

            // 
            // Sheet
            // 
            this.Sheet.AllowCellContextMenu = true;
            this.Sheet.AllowExtendRowColumnCount = true;
            this.Sheet.AllowFormulaRangeSelection = true;
            this.Sheet.AllowTabItemContextMenu = true;
            this.Sheet.AllowZooming = true;

            this.Sheet.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.Sheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sheet.BindingSource = this.BindingSource;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;

            spreadsheetCopyPaste1.DefaultPasteOption =
                Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;

            this.Sheet.CopyPaste = spreadsheetCopyPaste1;
            this.Sheet.DefaultColumnCount = 26;
            this.Sheet.DefaultRowCount = 66;
            this.Sheet.DisplayAlerts = true;
            this.Sheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sheet.FileName = "Book1";
            this.Sheet.Font = new System.Drawing.Font( "Roboto", 8F );
            this.Sheet.ForeColor = System.Drawing.Color.Black;
            this.Sheet.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.Sheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.Sheet.Grid = null;
            this.Sheet.IsCustomTabItemContextMenuEnabled = false;
            this.Sheet.Location = new System.Drawing.Point( 0, 162 );
            this.Sheet.Model = null;
            this.Sheet.Name = "Sheet";
            this.Sheet.Padding = new System.Windows.Forms.Padding( 1 );
            this.Sheet.SelectedTabIndex = 0;
            this.Sheet.SelectedTabItem = null;
            this.Sheet.ShowBusyIndicator = true;
            this.Sheet.Size = new System.Drawing.Size( 1059, 541 );
            this.Sheet.TabIndex = 1;
            this.Sheet.TabItemContextMenu = null;
            this.Sheet.Text = "sheetPanel1";

            // 
            // Ribbon
            // 
            this.Ribbon.ActiveSheet = this.Sheet;
            this.Ribbon.AllowCollapse = false;

            this.Ribbon.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.Ribbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ribbon.BindingSource = this.BindingSource;
            this.Ribbon.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;

            this.Ribbon.CaptionFont = new System.Drawing.Font( "Segoe UI", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.Ribbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;

            this.Ribbon.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.Ribbon.Grid = null;
            this.Ribbon.HideMenuButtonToolTip = true;
            this.Ribbon.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.Ribbon.Location = new System.Drawing.Point( 0, 0 );

            this.Ribbon.MenuButtonFont = new System.Drawing.Font( "Roboto", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

            this.Ribbon.MenuButtonText = "FILE";

            this.Ribbon.MenuColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 48 ) ) ) ),
                ( (int)( ( (byte)( 48 ) ) ) ), ( (int)( ( (byte)( 48 ) ) ) ) );

            this.Ribbon.Model = null;
            this.Ribbon.Name = "Ribbon";

            this.Ribbon.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;

            this.Ribbon.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;

            office2016ColorTable1.BackStageTitleColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            office2016ColorTable1.CaptionBackColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            office2016ColorTable1.CaptionForeColor = System.Drawing.Color.LightGray;

            office2016ColorTable1.GalleryItemHoveredTextColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            office2016ColorTable1.LauncherColorSelected = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            office2016ColorTable1.ToolStripItemForeColor = System.Drawing.Color.FromArgb(
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.Ribbon.Office2016ColorTable.Add( office2016ColorTable1 );
            this.Ribbon.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;

            // 
            // Ribbon.OfficeMenu
            // 
            this.Ribbon.OfficeMenu.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.Ribbon.OfficeMenu.Margin = new System.Windows.Forms.Padding( 3 );
            this.Ribbon.OfficeMenu.Name = "OfficeMenu";
            this.Ribbon.OfficeMenu.ShowItemToolTips = true;
            this.Ribbon.OfficeMenu.Size = new System.Drawing.Size( 12, 65 );
            this.Ribbon.Padding = new System.Windows.Forms.Padding( 1 );
            this.Ribbon.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ribbon.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.Custom;
            this.Ribbon.ShowQuickItemsDropDownButton = false;
            this.Ribbon.ShowRibbonDisplayOptionButton = false;
            this.Ribbon.Size = new System.Drawing.Size( 1059, 162 );
            this.Ribbon.Spreadsheet = this.Sheet;
            this.Ribbon.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.Ribbon.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.Ribbon.TabIndex = 0;
            this.Ribbon.TitleColor = System.Drawing.Color.White;

            this.Ribbon.TitleFont = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Bold );

            // 
            // ExcelDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.BorderColor = System.Drawing.SystemColors.HotTrack;

            this.CaptionBarColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CaptionBarHeight = 30;

            this.CaptionButtonColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.CaptionButtonHoverColor = System.Drawing.Color.Red;

            this.CaptionForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            captionImage1.BackColor = System.Drawing.Color.Transparent;

            captionImage1.Image = ( (System.Drawing.Image)( resources.GetObject( "captionImage1.Image" ) ) );

            captionImage1.Location = new System.Drawing.Point( 10, 4 );
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size( 50, 15 );
            this.CaptionImages.Add( captionImage1 );
            this.ClientSize = new System.Drawing.Size( 1061, 705 );
            this.Controls.Add( this.BackPanel );
            this.DoubleBuffered = true;
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;

            this.MetroColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

            this.MinimizeBox = false;
            this.Name = "ExcelForm";
            this.Padding = new System.Windows.Forms.Padding( 1 );
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.Text = "ExcelDocument";
            this.BackPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.BindingSource ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.Ribbon ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        public SheetPanel Sheet;

        public RibbonPanel Ribbon;

        private LayoutPanel BackPanel;

        private BindingSource BindingSource;
    }
}