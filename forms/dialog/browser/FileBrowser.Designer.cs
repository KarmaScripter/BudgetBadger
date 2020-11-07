
namespace BudgetExecution
{
    
    
        // ********************************************************************************************************************************
        // *********************************************************  ASSEMBLIES   ********************************************************
        // ********************************************************************************************************************************
        
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;
        using VisualPlus.Toolkit.Controls.Editors;
        using VisualPlus.Toolkit.Controls.Interactivity;
        using VisualPlus.Toolkit.Controls.Layout;

        partial class FileBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBrowser));
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.visualButton1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.visualButton3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.visualRichTextBox1 = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.Table3 = new System.Windows.Forms.TableLayoutPanel();
            this.visualCheckBox6 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.visualCheckBox5 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.visualCheckBox4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.visualCheckBox2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.visualCheckBox3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.visualCheckBox1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.CsvCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.SideLabel = new BudgetExecution.LabelPanel();
            this.XlsxCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.XlsCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.Header = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.closePanel1 = new BudgetExecution.ClosePanel();
            this.Dialog = new System.Windows.Forms.OpenFileDialog();
            this.visualSeparator1 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
            this.visualSeparator2 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
            this.tableLayoutPanel2.SuspendLayout();
            this.Table.SuspendLayout();
            this.Table3.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // visualLabel1
            // 
            this.visualLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.visualLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualLabel1.ForeColor = System.Drawing.Color.White;
            this.visualLabel1.Location = new System.Drawing.Point(102, 3);
            this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel1.Name = "visualLabel1";
            this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel1.Outline = false;
            this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.ReflectionSpacing = 0;
            this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel1.ShadowDirection = 315;
            this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ShadowOpacity = 100;
            this.visualLabel1.Size = new System.Drawing.Size(442, 20);
            this.visualLabel1.TabIndex = 0;
            this.visualLabel1.Text = "Label";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualLabel1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.visualButton1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.visualButton3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 420);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(668, 98);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // visualButton1
            // 
            this.visualButton1.BackColor = System.Drawing.Color.Transparent;
            this.visualButton1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton1.BackColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualButton1.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualButton1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualButton1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualButton1.Border.HoverVisible = true;
            this.visualButton1.Border.Rounding = 6;
            this.visualButton1.Border.Thickness = 1;
            this.visualButton1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualButton1.Border.Visible = true;
            this.visualButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.visualButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualButton1.ForeColor = System.Drawing.Color.LightGray;
            this.visualButton1.Image = null;
            this.visualButton1.Location = new System.Drawing.Point(339, 5);
            this.visualButton1.Margin = new System.Windows.Forms.Padding(5);
            this.visualButton1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualButton1.Name = "visualButton1";
            this.visualButton1.Size = new System.Drawing.Size(324, 88);
            this.visualButton1.TabIndex = 0;
            this.visualButton1.Text = "Cancel";
            this.visualButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualButton1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualButton1.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.visualButton1.TextStyle.Hover = System.Drawing.Color.White;
            this.visualButton1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualButton1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualButton3
            // 
            this.visualButton3.BackColor = System.Drawing.Color.Transparent;
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
            this.visualButton3.Location = new System.Drawing.Point(5, 5);
            this.visualButton3.Margin = new System.Windows.Forms.Padding(5);
            this.visualButton3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualButton3.Name = "visualButton3";
            this.visualButton3.Size = new System.Drawing.Size(324, 88);
            this.visualButton3.TabIndex = 2;
            this.visualButton3.Text = "Open";
            this.visualButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualButton3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualButton3.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.visualButton3.TextStyle.Hover = System.Drawing.Color.White;
            this.visualButton3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualButton3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.43769F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.69301F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6764F));
            this.Table.Controls.Add(this.visualRichTextBox1, 1, 0);
            this.Table.Controls.Add(this.Table3, 2, 0);
            this.Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Table.Location = new System.Drawing.Point(3, 72);
            this.Table.Margin = new System.Windows.Forms.Padding(5);
            this.Table.Name = "Table";
            this.Table.Padding = new System.Windows.Forms.Padding(1);
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.Size = new System.Drawing.Size(666, 320);
            this.Table.TabIndex = 5;
            // 
            // visualRichTextBox1
            // 
            this.visualRichTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualRichTextBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualRichTextBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualRichTextBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.visualRichTextBox1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualRichTextBox1.Border.HoverVisible = false;
            this.visualRichTextBox1.Border.Rounding = 6;
            this.visualRichTextBox1.Border.Thickness = 1;
            this.visualRichTextBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualRichTextBox1.Border.Visible = true;
            this.visualRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualRichTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.visualRichTextBox1.Location = new System.Drawing.Point(102, 6);
            this.visualRichTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.visualRichTextBox1.MaxLength = 2147483647;
            this.visualRichTextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualRichTextBox1.Name = "visualRichTextBox1";
            this.visualRichTextBox1.ReadOnly = false;
            this.visualRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.visualRichTextBox1.ShowSelectionMargin = false;
            this.visualRichTextBox1.Size = new System.Drawing.Size(447, 308);
            this.visualRichTextBox1.TabIndex = 0;
            this.visualRichTextBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualRichTextBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualRichTextBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualRichTextBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualRichTextBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualRichTextBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualRichTextBox1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Table3
            // 
            this.Table3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Table3.ColumnCount = 1;
            this.Table3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table3.Controls.Add(this.visualCheckBox6, 0, 9);
            this.Table3.Controls.Add(this.visualCheckBox5, 0, 8);
            this.Table3.Controls.Add(this.visualCheckBox4, 0, 7);
            this.Table3.Controls.Add(this.visualCheckBox2, 0, 6);
            this.Table3.Controls.Add(this.visualCheckBox3, 0, 5);
            this.Table3.Controls.Add(this.visualCheckBox1, 0, 4);
            this.Table3.Controls.Add(this.CsvCheckBox, 0, 3);
            this.Table3.Controls.Add(this.SideLabel, 0, 0);
            this.Table3.Controls.Add(this.XlsxCheckBox, 0, 1);
            this.Table3.Controls.Add(this.XlsCheckBox, 0, 2);
            this.Table3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table3.Location = new System.Drawing.Point(557, 4);
            this.Table3.Name = "Table3";
            this.Table3.RowCount = 10;
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table3.Size = new System.Drawing.Size(105, 312);
            this.Table3.TabIndex = 2;
            // 
            // visualCheckBox6
            // 
            this.visualCheckBox6.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualCheckBox6.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox6.Border.HoverVisible = true;
            this.visualCheckBox6.Border.Rounding = 3;
            this.visualCheckBox6.Border.Thickness = 1;
            this.visualCheckBox6.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox6.Border.Visible = true;
            this.visualCheckBox6.Box = new System.Drawing.Size(14, 14);
            this.visualCheckBox6.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualCheckBox6.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.visualCheckBox6.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox6.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox6.BoxSpacing = 2;
            this.visualCheckBox6.CheckStyle.AutoSize = true;
            this.visualCheckBox6.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.visualCheckBox6.CheckStyle.Character = '✔';
            this.visualCheckBox6.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.visualCheckBox6.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualCheckBox6.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.visualCheckBox6.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox6.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox6.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox6.CheckStyle.Thickness = 2F;
            this.visualCheckBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualCheckBox6.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox6.IsBoxLarger = false;
            this.visualCheckBox6.Location = new System.Drawing.Point(5, 284);
            this.visualCheckBox6.Margin = new System.Windows.Forms.Padding(5);
            this.visualCheckBox6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox6.Name = "visualCheckBox6";
            this.visualCheckBox6.Size = new System.Drawing.Size(95, 23);
            this.visualCheckBox6.TabIndex = 13;
            this.visualCheckBox6.Text = "SQL Compact ";
            this.visualCheckBox6.TextSize = new System.Drawing.Size(73, 15);
            this.visualCheckBox6.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualCheckBox6.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox6.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox6.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox6.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox6.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox6.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualCheckBox5
            // 
            this.visualCheckBox5.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualCheckBox5.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox5.Border.HoverVisible = true;
            this.visualCheckBox5.Border.Rounding = 3;
            this.visualCheckBox5.Border.Thickness = 1;
            this.visualCheckBox5.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox5.Border.Visible = true;
            this.visualCheckBox5.Box = new System.Drawing.Size(14, 14);
            this.visualCheckBox5.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualCheckBox5.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.visualCheckBox5.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox5.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox5.BoxSpacing = 2;
            this.visualCheckBox5.CheckStyle.AutoSize = true;
            this.visualCheckBox5.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.visualCheckBox5.CheckStyle.Character = '✔';
            this.visualCheckBox5.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.visualCheckBox5.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualCheckBox5.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.visualCheckBox5.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox5.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox5.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox5.CheckStyle.Thickness = 2F;
            this.visualCheckBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualCheckBox5.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox5.IsBoxLarger = false;
            this.visualCheckBox5.Location = new System.Drawing.Point(5, 253);
            this.visualCheckBox5.Margin = new System.Windows.Forms.Padding(5);
            this.visualCheckBox5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox5.Name = "visualCheckBox5";
            this.visualCheckBox5.Size = new System.Drawing.Size(95, 21);
            this.visualCheckBox5.TabIndex = 12;
            this.visualCheckBox5.Text = "Power Point ";
            this.visualCheckBox5.TextSize = new System.Drawing.Size(65, 15);
            this.visualCheckBox5.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualCheckBox5.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox5.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox5.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox5.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox5.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox5.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualCheckBox4
            // 
            this.visualCheckBox4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualCheckBox4.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox4.Border.HoverVisible = true;
            this.visualCheckBox4.Border.Rounding = 3;
            this.visualCheckBox4.Border.Thickness = 1;
            this.visualCheckBox4.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox4.Border.Visible = true;
            this.visualCheckBox4.Box = new System.Drawing.Size(14, 14);
            this.visualCheckBox4.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualCheckBox4.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.visualCheckBox4.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox4.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox4.BoxSpacing = 2;
            this.visualCheckBox4.CheckStyle.AutoSize = true;
            this.visualCheckBox4.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.visualCheckBox4.CheckStyle.Character = '✔';
            this.visualCheckBox4.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.visualCheckBox4.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualCheckBox4.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.visualCheckBox4.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox4.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox4.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox4.CheckStyle.Thickness = 2F;
            this.visualCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualCheckBox4.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox4.IsBoxLarger = false;
            this.visualCheckBox4.Location = new System.Drawing.Point(5, 222);
            this.visualCheckBox4.Margin = new System.Windows.Forms.Padding(5);
            this.visualCheckBox4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox4.Name = "visualCheckBox4";
            this.visualCheckBox4.Size = new System.Drawing.Size(95, 21);
            this.visualCheckBox4.TabIndex = 11;
            this.visualCheckBox4.Text = "Excel ";
            this.visualCheckBox4.TextSize = new System.Drawing.Size(30, 15);
            this.visualCheckBox4.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualCheckBox4.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox4.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox4.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox4.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox4.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox4.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualCheckBox2
            // 
            this.visualCheckBox2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualCheckBox2.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox2.Border.HoverVisible = true;
            this.visualCheckBox2.Border.Rounding = 3;
            this.visualCheckBox2.Border.Thickness = 1;
            this.visualCheckBox2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox2.Border.Visible = true;
            this.visualCheckBox2.Box = new System.Drawing.Size(14, 14);
            this.visualCheckBox2.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualCheckBox2.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.visualCheckBox2.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox2.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox2.BoxSpacing = 2;
            this.visualCheckBox2.CheckStyle.AutoSize = true;
            this.visualCheckBox2.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.visualCheckBox2.CheckStyle.Character = '✔';
            this.visualCheckBox2.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.visualCheckBox2.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualCheckBox2.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.visualCheckBox2.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox2.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox2.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox2.CheckStyle.Thickness = 2F;
            this.visualCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualCheckBox2.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox2.IsBoxLarger = false;
            this.visualCheckBox2.Location = new System.Drawing.Point(5, 191);
            this.visualCheckBox2.Margin = new System.Windows.Forms.Padding(5);
            this.visualCheckBox2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox2.Name = "visualCheckBox2";
            this.visualCheckBox2.Size = new System.Drawing.Size(95, 21);
            this.visualCheckBox2.TabIndex = 10;
            this.visualCheckBox2.Text = "CSV ";
            this.visualCheckBox2.TextSize = new System.Drawing.Size(25, 15);
            this.visualCheckBox2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualCheckBox2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualCheckBox3
            // 
            this.visualCheckBox3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualCheckBox3.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox3.Border.HoverVisible = true;
            this.visualCheckBox3.Border.Rounding = 3;
            this.visualCheckBox3.Border.Thickness = 1;
            this.visualCheckBox3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox3.Border.Visible = true;
            this.visualCheckBox3.Box = new System.Drawing.Size(14, 14);
            this.visualCheckBox3.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualCheckBox3.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.visualCheckBox3.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox3.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox3.BoxSpacing = 2;
            this.visualCheckBox3.CheckStyle.AutoSize = true;
            this.visualCheckBox3.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.visualCheckBox3.CheckStyle.Character = '✔';
            this.visualCheckBox3.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.visualCheckBox3.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualCheckBox3.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.visualCheckBox3.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox3.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox3.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox3.CheckStyle.Thickness = 2F;
            this.visualCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualCheckBox3.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox3.IsBoxLarger = false;
            this.visualCheckBox3.Location = new System.Drawing.Point(5, 160);
            this.visualCheckBox3.Margin = new System.Windows.Forms.Padding(5);
            this.visualCheckBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox3.Name = "visualCheckBox3";
            this.visualCheckBox3.Size = new System.Drawing.Size(95, 21);
            this.visualCheckBox3.TabIndex = 9;
            this.visualCheckBox3.Text = "Access ";
            this.visualCheckBox3.TextSize = new System.Drawing.Size(41, 15);
            this.visualCheckBox3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualCheckBox3.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox3.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualCheckBox1
            // 
            this.visualCheckBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualCheckBox1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.visualCheckBox1.Border.HoverVisible = true;
            this.visualCheckBox1.Border.Rounding = 3;
            this.visualCheckBox1.Border.Thickness = 1;
            this.visualCheckBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox1.Border.Visible = true;
            this.visualCheckBox1.Box = new System.Drawing.Size(14, 14);
            this.visualCheckBox1.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.visualCheckBox1.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.visualCheckBox1.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.visualCheckBox1.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.visualCheckBox1.BoxSpacing = 2;
            this.visualCheckBox1.CheckStyle.AutoSize = true;
            this.visualCheckBox1.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.visualCheckBox1.CheckStyle.Character = '✔';
            this.visualCheckBox1.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.visualCheckBox1.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualCheckBox1.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.visualCheckBox1.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox1.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox1.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox1.CheckStyle.Thickness = 2F;
            this.visualCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualCheckBox1.ForeColor = System.Drawing.Color.LightGray;
            this.visualCheckBox1.IsBoxLarger = false;
            this.visualCheckBox1.Location = new System.Drawing.Point(5, 129);
            this.visualCheckBox1.Margin = new System.Windows.Forms.Padding(5);
            this.visualCheckBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox1.Name = "visualCheckBox1";
            this.visualCheckBox1.Size = new System.Drawing.Size(95, 21);
            this.visualCheckBox1.TabIndex = 6;
            this.visualCheckBox1.Text = "SQLite ";
            this.visualCheckBox1.TextSize = new System.Drawing.Size(37, 15);
            this.visualCheckBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualCheckBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.CsvCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.CsvCheckBox.CheckStyle.ShapeRounding = 3;
            this.CsvCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CsvCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.CsvCheckBox.CheckStyle.Thickness = 2F;
            this.CsvCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CsvCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvCheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.CsvCheckBox.IsBoxLarger = false;
            this.CsvCheckBox.Location = new System.Drawing.Point(5, 98);
            this.CsvCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.CsvCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CsvCheckBox.Name = "CsvCheckBox";
            this.CsvCheckBox.Size = new System.Drawing.Size(95, 21);
            this.CsvCheckBox.TabIndex = 4;
            this.CsvCheckBox.Text = "SQL  Server";
            this.CsvCheckBox.TextSize = new System.Drawing.Size(62, 15);
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
            this.SideLabel.BindingSource = null;
            this.SideLabel.DataFilter = null;
            this.SideLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideLabel.Field = BudgetExecution.Field.NS;
            this.SideLabel.Font = new System.Drawing.Font("Roboto", 8F);
            this.SideLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SideLabel.Location = new System.Drawing.Point(3, 10);
            this.SideLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SideLabel.Name = "SideLabel";
            this.SideLabel.Numeric = BudgetExecution.Numeric.NS;
            this.SideLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SideLabel.Outline = false;
            this.SideLabel.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.SideLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.SideLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SideLabel.ReflectionSpacing = 0;
            this.SideLabel.ShadowColor = System.Drawing.Color.Black;
            this.SideLabel.ShadowDirection = 315;
            this.SideLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.SideLabel.ShadowOpacity = 100;
            this.SideLabel.Size = new System.Drawing.Size(99, 18);
            this.SideLabel.TabIndex = 2;
            this.SideLabel.Text = "Browse:";
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
            this.XlsxCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.XlsxCheckBox.CheckStyle.ShapeRounding = 3;
            this.XlsxCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.XlsxCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.XlsxCheckBox.CheckStyle.Thickness = 2F;
            this.XlsxCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XlsxCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XlsxCheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.XlsxCheckBox.IsBoxLarger = false;
            this.XlsxCheckBox.Location = new System.Drawing.Point(5, 36);
            this.XlsxCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.XlsxCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.XlsxCheckBox.Name = "XlsxCheckBox";
            this.XlsxCheckBox.Size = new System.Drawing.Size(95, 21);
            this.XlsxCheckBox.TabIndex = 3;
            this.XlsxCheckBox.Text = "Adobe ";
            this.XlsxCheckBox.TextSize = new System.Drawing.Size(36, 15);
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
            this.XlsCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.XlsCheckBox.CheckStyle.ShapeRounding = 3;
            this.XlsCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.XlsCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.XlsCheckBox.CheckStyle.Thickness = 2F;
            this.XlsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XlsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XlsCheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.XlsCheckBox.IsBoxLarger = false;
            this.XlsCheckBox.Location = new System.Drawing.Point(5, 67);
            this.XlsCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.XlsCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.XlsCheckBox.Name = "XlsCheckBox";
            this.XlsCheckBox.Size = new System.Drawing.Size(95, 21);
            this.XlsCheckBox.TabIndex = 5;
            this.XlsCheckBox.Text = "Word";
            this.XlsCheckBox.TextSize = new System.Drawing.Size(30, 15);
            this.XlsCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.XlsCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XlsCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.XlsCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.XlsCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.ColumnCount = 3;
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.13187F));
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.86813F));
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Header.Controls.Add(this.PictureBox, 0, 0);
            this.Header.Controls.Add(this.closePanel1, 2, 0);
            this.Header.Controls.Add(this.visualLabel1, 1, 0);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.RowCount = 1;
            this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Header.Size = new System.Drawing.Size(668, 26);
            this.Header.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BindingSource = null;
            this.PictureBox.DataFilter = null;
            this.PictureBox.Field = BudgetExecution.Field.NS;
            this.PictureBox.HoverText = null;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.ImageList = null;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(26, 16);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // closePanel1
            // 
            this.closePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePanel1.CloseHoverBackColor = System.Drawing.Color.Red;
            this.closePanel1.CloseHoverForeColor = System.Drawing.Color.White;
            this.closePanel1.CloseNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.closePanel1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.closePanel1.Font = new System.Drawing.Font("Roboto", 8F);
            this.closePanel1.ForeColor = System.Drawing.Color.LightGray;
            this.closePanel1.Location = new System.Drawing.Point(568, 0);
            this.closePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.closePanel1.MaximizeBox = true;
            this.closePanel1.MaximizeHoverBackColor = System.Drawing.Color.Blue;
            this.closePanel1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.closePanel1.MaximizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.closePanel1.MinimizeBox = true;
            this.closePanel1.MinimizeHoverBackColor = System.Drawing.Color.Blue;
            this.closePanel1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.closePanel1.MinimizeNormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.closePanel1.Name = "closePanel1";
            this.closePanel1.Size = new System.Drawing.Size(100, 25);
            this.closePanel1.Style = MetroSet_UI.Design.Style.Custom;
            this.closePanel1.StyleManager = null;
            this.closePanel1.TabIndex = 1;
            this.closePanel1.Text = "closePanel1";
            this.closePanel1.ThemeAuthor = "Terry D. Eppler";
            this.closePanel1.ThemeName = "Budget Execution";
            this.closePanel1.ToolTip = null;
            // 
            // Dialog
            // 
            this.Dialog.Filter = "Document FIles | *.PDF | *.DOCX | *.DOC ";
            // 
            // visualSeparator1
            // 
            this.visualSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualSeparator1.Line = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.visualSeparator1.Location = new System.Drawing.Point(0, 51);
            this.visualSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.visualSeparator1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualSeparator1.Name = "visualSeparator1";
            this.visualSeparator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualSeparator1.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.visualSeparator1.ShadowVisible = false;
            this.visualSeparator1.Size = new System.Drawing.Size(669, 4);
            this.visualSeparator1.TabIndex = 6;
            this.visualSeparator1.Text = "visualSeparator1";
            this.visualSeparator1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualSeparator1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualSeparator1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualSeparator1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualSeparator2
            // 
            this.visualSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.visualSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualSeparator2.Line = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.visualSeparator2.Location = new System.Drawing.Point(0, 416);
            this.visualSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.visualSeparator2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualSeparator2.Name = "visualSeparator2";
            this.visualSeparator2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualSeparator2.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.visualSeparator2.ShadowVisible = false;
            this.visualSeparator2.Size = new System.Drawing.Size(668, 4);
            this.visualSeparator2.TabIndex = 7;
            this.visualSeparator2.Text = "visualSeparator2";
            this.visualSeparator2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualSeparator2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualSeparator2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualSeparator2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualSeparator2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            captionImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Location = new System.Drawing.Point(20, 10);
            captionImage1.Name = "PdfImage";
            captionImage1.Size = new System.Drawing.Size(25, 20);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(668, 518);
            this.ControlBox = false;
            this.Controls.Add(this.visualSeparator1);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.visualSeparator2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Header);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.MinimizeBox = false;
            this.Name = "FileBrowser";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            this.Table3.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            public VisualLabel visualLabel1;

            public VisualButton visualButton1;

            public VisualButton visualButton3;

            public TableLayoutPanel Table;

            public VisualRichTextBox visualRichTextBox1;
        private TableLayoutPanel tableLayoutPanel2;
        public TableLayoutPanel Table3;
        public VisualCheckBox CsvCheckBox;
        public VisualCheckBox XlsxCheckBox;
        public VisualCheckBox XlsCheckBox;
        public OpenFileDialog Dialog;
        public VisualCheckBox visualCheckBox4;
        public VisualCheckBox visualCheckBox2;
        public VisualCheckBox visualCheckBox3;
        public VisualCheckBox visualCheckBox1;
        public VisualCheckBox visualCheckBox6;
        public VisualCheckBox visualCheckBox5;
        public VisualSeparator visualSeparator1;
        private VisualSeparator visualSeparator2;
        public PicturePanel PictureBox;
        public ClosePanel closePanel1;
        public LabelPanel SideLabel;
        public TableLayoutPanel Header;
    }
    
}
