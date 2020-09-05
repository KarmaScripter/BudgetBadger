using System;

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Editors;
    using VisualPlus.Toolkit.Controls.Interactivity;
    using VisualPlus.Toolkit.Controls.Layout;

    partial class ExcelBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelBrowser));
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.Label = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.BackPanel = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
            this.Table4 = new System.Windows.Forms.TableLayoutPanel();
            this.visualButton3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualButton2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualButton1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Table2 = new System.Windows.Forms.TableLayoutPanel();
            this.Table3 = new System.Windows.Forms.TableLayoutPanel();
            this.CsvCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.SideLabel = new BudgetExecution.LabelPanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.XlsxCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.XlsCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.visualRichTextBox1 = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.Table1 = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.CloseBox = new BudgetExecution.ClosePanel();
            this.Separator1 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
            this.Separator2 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.BackPanel.SuspendLayout();
            this.Table4.SuspendLayout();
            this.Table2.SuspendLayout();
            this.Table3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.Table1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.LightGray;
            this.Label.Location = new System.Drawing.Point(44, 3);
            this.Label.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label.Name = "Label";
            this.Label.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label.Outline = false;
            this.Label.OutlineColor = System.Drawing.Color.Red;
            this.Label.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.ReflectionSpacing = 0;
            this.Label.ShadowColor = System.Drawing.Color.Black;
            this.Label.ShadowDirection = 315;
            this.Label.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label.ShadowOpacity = 100;
            this.Label.Size = new System.Drawing.Size(479, 26);
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
            // 
            // BackPanel
            // 
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Controls.Add(this.Table4);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 426);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(666, 91);
            this.BackPanel.TabIndex = 2;
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Table4
            // 
            this.Table4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Table4.ColumnCount = 5;
            this.Table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.Table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.Table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Table4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.Table4.Controls.Add(this.visualButton3, 1, 0);
            this.Table4.Controls.Add(this.visualButton2, 2, 0);
            this.Table4.Controls.Add(this.visualButton1, 3, 0);
            this.Table4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table4.Location = new System.Drawing.Point(0, 0);
            this.Table4.Name = "Table4";
            this.Table4.RowCount = 1;
            this.Table4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table4.Size = new System.Drawing.Size(666, 91);
            this.Table4.TabIndex = 2;
            // 
            // visualButton3
            // 
            this.visualButton3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton3.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton3.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualButton3.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualButton3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualButton3.Border.HoverVisible = true;
            this.visualButton3.Border.Rounding = 6;
            this.visualButton3.Border.Thickness = 1;
            this.visualButton3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualButton3.Border.Visible = true;
            this.visualButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.visualButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualButton3.ForeColor = System.Drawing.Color.LightGray;
            this.visualButton3.Image = null;
            this.visualButton3.Location = new System.Drawing.Point(93, 3);
            this.visualButton3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualButton3.Name = "visualButton3";
            this.visualButton3.Size = new System.Drawing.Size(157, 85);
            this.visualButton3.TabIndex = 2;
            this.visualButton3.Text = "Browse";
            this.visualButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualButton3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualButton3.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.visualButton3.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualButton3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualButton3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualButton2
            // 
            this.visualButton2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton2.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton2.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualButton2.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualButton2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton2.Border.HoverColor = System.Drawing.Color.Lime;
            this.visualButton2.Border.HoverVisible = true;
            this.visualButton2.Border.Rounding = 6;
            this.visualButton2.Border.Thickness = 1;
            this.visualButton2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualButton2.Border.Visible = true;
            this.visualButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.visualButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualButton2.ForeColor = System.Drawing.Color.LightGray;
            this.visualButton2.Image = null;
            this.visualButton2.Location = new System.Drawing.Point(256, 3);
            this.visualButton2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualButton2.Name = "visualButton2";
            this.visualButton2.Size = new System.Drawing.Size(142, 85);
            this.visualButton2.TabIndex = 1;
            this.visualButton2.Text = "Accept";
            this.visualButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualButton2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualButton2.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.visualButton2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualButton2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualButton2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualButton1
            // 
            this.visualButton1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton1.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualButton1.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualButton1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualButton1.Border.HoverColor = System.Drawing.Color.Red;
            this.visualButton1.Border.HoverVisible = true;
            this.visualButton1.Border.Rounding = 6;
            this.visualButton1.Border.Thickness = 1;
            this.visualButton1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualButton1.Border.Visible = true;
            this.visualButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.visualButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualButton1.ForeColor = System.Drawing.Color.LightGray;
            this.visualButton1.Image = null;
            this.visualButton1.Location = new System.Drawing.Point(404, 3);
            this.visualButton1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualButton1.Name = "visualButton1";
            this.visualButton1.Size = new System.Drawing.Size(144, 85);
            this.visualButton1.TabIndex = 0;
            this.visualButton1.Text = "Cancel";
            this.visualButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualButton1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualButton1.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.visualButton1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualButton1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualButton1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Dialog
            // 
            this.Dialog.DefaultExt = "xlsx";
            this.Dialog.FileName = "Excel";
            this.Dialog.Filter = "Excel FIles | *.xlsx | *.xls | *.csv";
            this.Dialog.Title = "Browse to Excel File";
            // 
            // Table2
            // 
            this.Table2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Table2.ColumnCount = 3;
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4265F));
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.5735F));
            this.Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.Table2.Controls.Add(this.Table3, 2, 0);
            this.Table2.Controls.Add(this.visualRichTextBox1, 1, 0);
            this.Table2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table2.Location = new System.Drawing.Point(1, 33);
            this.Table2.Name = "Table2";
            this.Table2.Padding = new System.Windows.Forms.Padding(1);
            this.Table2.RowCount = 1;
            this.Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table2.Size = new System.Drawing.Size(666, 393);
            this.Table2.TabIndex = 5;
            // 
            // Table3
            // 
            this.Table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Table3.ColumnCount = 1;
            this.Table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table3.Controls.Add(this.CsvCheckBox, 0, 3);
            this.Table3.Controls.Add(this.SideLabel, 0, 0);
            this.Table3.Controls.Add(this.XlsxCheckBox, 0, 1);
            this.Table3.Controls.Add(this.XlsCheckBox, 0, 2);
            this.Table3.Location = new System.Drawing.Point(553, 4);
            this.Table3.Name = "Table3";
            this.Table3.RowCount = 5;
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.30508F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.69492F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table3.Size = new System.Drawing.Size(106, 229);
            this.Table3.TabIndex = 3;
            // 
            // CsvCheckBox
            // 
            this.CsvCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CsvCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.CsvCheckBox.Border.HoverVisible = true;
            this.CsvCheckBox.Border.Rounding = 3;
            this.CsvCheckBox.Border.Thickness = 1;
            this.CsvCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CsvCheckBox.Border.Visible = true;
            this.CsvCheckBox.Box = new System.Drawing.Size(14, 14);
            this.CsvCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CsvCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CsvCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.CsvCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.CsvCheckBox.BoxSpacing = 2;
            this.CsvCheckBox.CheckStyle.AutoSize = true;
            this.CsvCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.CsvCheckBox.CheckStyle.Character = '✔';
            this.CsvCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.CsvCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsvCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.CsvCheckBox.CheckStyle.ShapeRounding = 3;
            this.CsvCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CsvCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.CsvCheckBox.CheckStyle.Thickness = 2F;
            this.CsvCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CsvCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CsvCheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.CsvCheckBox.IsBoxLarger = false;
            this.CsvCheckBox.Location = new System.Drawing.Point(10, 122);
            this.CsvCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.CsvCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CsvCheckBox.Name = "CsvCheckBox";
            this.CsvCheckBox.Size = new System.Drawing.Size(93, 23);
            this.CsvCheckBox.TabIndex = 4;
            this.CsvCheckBox.Text = "    .CSV";
            this.CsvCheckBox.TextSize = new System.Drawing.Size(39, 15);
            this.CsvCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.CsvCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CsvCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.CsvCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // SideLabel
            // 
            this.SideLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.SideLabel.BindingSource = this.BudgetBinding;
            this.SideLabel.DataFilter = null;
            this.SideLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideLabel.Field = BudgetExecution.Field.NS;
            this.SideLabel.Font = new System.Drawing.Font("Roboto", 8F);
            this.SideLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SideLabel.Location = new System.Drawing.Point(3, 7);
            this.SideLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SideLabel.Name = "SideLabel";
            this.SideLabel.Numeric = BudgetExecution.Numeric.NS;
            this.SideLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SideLabel.Outline = false;
            this.SideLabel.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.SideLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.SideLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SideLabel.ReflectionSpacing = 0;
            this.SideLabel.ShadowColor = System.Drawing.Color.Black;
            this.SideLabel.ShadowDirection = 315;
            this.SideLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.SideLabel.ShadowOpacity = 100;
            this.SideLabel.Size = new System.Drawing.Size(100, 23);
            this.SideLabel.TabIndex = 2;
            this.SideLabel.Text = "Inlude";
            this.SideLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            this.SideLabel.TextLineAlignment = System.Drawing.StringAlignment.Far;
            this.SideLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.SideLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SideLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SideLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SideLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SideLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.SideLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.SideLabel.ToolTip = null;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // XlsxCheckBox
            // 
            this.XlsxCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.XlsxCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.XlsxCheckBox.Border.HoverVisible = true;
            this.XlsxCheckBox.Border.Rounding = 3;
            this.XlsxCheckBox.Border.Thickness = 1;
            this.XlsxCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.XlsxCheckBox.Border.Visible = true;
            this.XlsxCheckBox.Box = new System.Drawing.Size(14, 14);
            this.XlsxCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.XlsxCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.XlsxCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.XlsxCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.XlsxCheckBox.BoxSpacing = 2;
            this.XlsxCheckBox.Checked = true;
            this.XlsxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XlsxCheckBox.CheckStyle.AutoSize = true;
            this.XlsxCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.XlsxCheckBox.CheckStyle.Character = '✔';
            this.XlsxCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.XlsxCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XlsxCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.XlsxCheckBox.CheckStyle.ShapeRounding = 3;
            this.XlsxCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.XlsxCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.XlsxCheckBox.CheckStyle.Thickness = 2F;
            this.XlsxCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XlsxCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.XlsxCheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.XlsxCheckBox.IsBoxLarger = false;
            this.XlsxCheckBox.Location = new System.Drawing.Point(10, 43);
            this.XlsxCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.XlsxCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.XlsxCheckBox.Name = "XlsxCheckBox";
            this.XlsxCheckBox.Size = new System.Drawing.Size(93, 23);
            this.XlsxCheckBox.TabIndex = 3;
            this.XlsxCheckBox.Text = "    .XLSX";
            this.XlsxCheckBox.TextSize = new System.Drawing.Size(45, 15);
            this.XlsxCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.XlsxCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsxCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsxCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsxCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.XlsxCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.XlsxCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // XlsCheckBox
            // 
            this.XlsCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.XlsCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.XlsCheckBox.Border.HoverVisible = true;
            this.XlsCheckBox.Border.Rounding = 3;
            this.XlsCheckBox.Border.Thickness = 1;
            this.XlsCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.XlsCheckBox.Border.Visible = true;
            this.XlsCheckBox.Box = new System.Drawing.Size(14, 14);
            this.XlsCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.XlsCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.XlsCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.XlsCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.XlsCheckBox.BoxSpacing = 2;
            this.XlsCheckBox.CheckStyle.AutoSize = true;
            this.XlsCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.XlsCheckBox.CheckStyle.Character = '✔';
            this.XlsCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.XlsCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XlsCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.XlsCheckBox.CheckStyle.ShapeRounding = 3;
            this.XlsCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.XlsCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.XlsCheckBox.CheckStyle.Thickness = 2F;
            this.XlsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XlsCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.XlsCheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.XlsCheckBox.IsBoxLarger = false;
            this.XlsCheckBox.Location = new System.Drawing.Point(10, 84);
            this.XlsCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.XlsCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.XlsCheckBox.Name = "XlsCheckBox";
            this.XlsCheckBox.Size = new System.Drawing.Size(93, 23);
            this.XlsCheckBox.TabIndex = 5;
            this.XlsCheckBox.Text = "    ..XLS";
            this.XlsCheckBox.TextSize = new System.Drawing.Size(41, 15);
            this.XlsCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.XlsCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.XlsCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.XlsCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualRichTextBox1
            // 
            this.visualRichTextBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualRichTextBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.visualRichTextBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualRichTextBox1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualRichTextBox1.Border.HoverVisible = false;
            this.visualRichTextBox1.Border.Rounding = 6;
            this.visualRichTextBox1.Border.Thickness = 1;
            this.visualRichTextBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualRichTextBox1.Border.Visible = true;
            this.visualRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualRichTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.visualRichTextBox1.Location = new System.Drawing.Point(88, 4);
            this.visualRichTextBox1.MaxLength = 2147483647;
            this.visualRichTextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualRichTextBox1.Name = "visualRichTextBox1";
            this.visualRichTextBox1.ReadOnly = false;
            this.visualRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.visualRichTextBox1.ShowSelectionMargin = false;
            this.visualRichTextBox1.Size = new System.Drawing.Size(459, 385);
            this.visualRichTextBox1.TabIndex = 0;
            this.visualRichTextBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualRichTextBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualRichTextBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualRichTextBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualRichTextBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualRichTextBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualRichTextBox1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Table1
            // 
            this.Table1.ColumnCount = 3;
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.862903F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.1371F));
            this.Table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.Table1.Controls.Add(this.PictureBox, 0, 0);
            this.Table1.Controls.Add(this.CloseBox, 2, 0);
            this.Table1.Controls.Add(this.Label, 1, 0);
            this.Table1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table1.Location = new System.Drawing.Point(1, 1);
            this.Table1.Name = "Table1";
            this.Table1.RowCount = 1;
            this.Table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table1.Size = new System.Drawing.Size(666, 32);
            this.Table1.TabIndex = 6;
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BindingSource = null;
            this.PictureBox.DataFilter = null;
            this.PictureBox.Field = BudgetExecution.Field.NS;
            this.PictureBox.HoverText = null;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.ImageList = null;
            this.PictureBox.Location = new System.Drawing.Point(9, 5);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(23, 22);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
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
            this.CloseBox.Location = new System.Drawing.Point(566, 0);
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
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Separator1.Line = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Separator1.Location = new System.Drawing.Point(7, 33);
            this.Separator1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Separator1.Name = "Separator1";
            this.Separator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Separator1.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Separator1.ShadowVisible = true;
            this.Separator1.Size = new System.Drawing.Size(660, 4);
            this.Separator1.TabIndex = 7;
            this.Separator1.Text = "visualSeparator1";
            this.Separator1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Separator1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Separator1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Separator1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Separator1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Separator1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Separator1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Separator2
            // 
            this.Separator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Separator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Separator2.Line = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Separator2.Location = new System.Drawing.Point(1, 422);
            this.Separator2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Separator2.Name = "Separator2";
            this.Separator2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Separator2.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Separator2.ShadowVisible = true;
            this.Separator2.Size = new System.Drawing.Size(666, 4);
            this.Separator2.TabIndex = 8;
            this.Separator2.Text = "visualSeparator1";
            this.Separator2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Separator2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Separator2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Separator2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Separator2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Separator2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Separator2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            // ExcelBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            captionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(20, 10);
            captionImage1.Name = "CaptionImage1";
            captionImage1.Size = new System.Drawing.Size(25, 20);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(668, 518);
            this.ControlBox = false;
            this.Controls.Add(this.Separator1);
            this.Controls.Add(this.Separator2);
            this.Controls.Add(this.Table2);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.Table1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.MinimizeBox = false;
            this.Name = "ExcelBrowser";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.BackPanel.ResumeLayout(false);
            this.Table4.ResumeLayout(false);
            this.Table2.ResumeLayout(false);
            this.Table3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.Table1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public VisualLabel Label;

        public VisualPanel BackPanel;

        private VisualButton visualButton1;

        private VisualButton visualButton2;

        private VisualButton visualButton3;

        public OpenFileDialog Dialog;

        public TableLayoutPanel Table2;

        public VisualRichTextBox visualRichTextBox1;
        public TableLayoutPanel Table4;
        public TableLayoutPanel Table1;
        public PicturePanel PictureBox;
        public ClosePanel CloseBox;
        public TableLayoutPanel Table3;
        public VisualCheckBox CsvCheckBox;
        private LabelPanel SideLabel;
        public VisualCheckBox XlsxCheckBox;
        public VisualCheckBox XlsCheckBox;
        public VisualSeparator Separator1;
        public VisualSeparator Separator2;
        public BudgetBinding BudgetBinding;
        public ToolTip ToolTip;
    }

}
