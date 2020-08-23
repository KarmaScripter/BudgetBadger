
namespace BudgetExecution
{
    
    
        
        // ********************************************************************************************************************************
        // *********************************************************  ASSEMBLIES   ********************************************************
        // ********************************************************************************************************************************

        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;

        partial class RecordControl
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

            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordControl));
            this.BackPanel = new BudgetExecution.LayoutPanel();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox12 = new BudgetExecution.TextBoxPanel();
            this.BindingSource = new BudgetExecution.BudgetBinding();
            this.TextBox11 = new BudgetExecution.TextBoxPanel();
            this.Label12 = new BudgetExecution.LabelPanel();
            this.Label11 = new BudgetExecution.LabelPanel();
            this.TextBox7 = new BudgetExecution.TextBoxPanel();
            this.TextBox6 = new BudgetExecution.TextBoxPanel();
            this.TextBox9 = new BudgetExecution.TextBoxPanel();
            this.TextBox5 = new BudgetExecution.TextBoxPanel();
            this.TextBox4 = new BudgetExecution.TextBoxPanel();
            this.TextBox3 = new BudgetExecution.TextBoxPanel();
            this.TextBox2 = new BudgetExecution.TextBoxPanel();
            this.Label5 = new BudgetExecution.LabelPanel();
            this.Label4 = new BudgetExecution.LabelPanel();
            this.Label3 = new BudgetExecution.LabelPanel();
            this.Label2 = new BudgetExecution.LabelPanel();
            this.Label1 = new BudgetExecution.LabelPanel();
            this.TextBox1 = new BudgetExecution.TextBoxPanel();
            this.TextBox10 = new BudgetExecution.TextBoxPanel();
            this.Label6 = new BudgetExecution.LabelPanel();
            this.TextBox8 = new BudgetExecution.TextBoxPanel();
            this.Label7 = new BudgetExecution.LabelPanel();
            this.Label8 = new BudgetExecution.LabelPanel();
            this.Label9 = new BudgetExecution.LabelPanel();
            this.Label10 = new BudgetExecution.LabelPanel();
            this.ToolBar = new BudgetExecution.ToolPanel();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Label = new BudgetExecution.BarLabel();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FirstButton = new BudgetExecution.BarButton();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PreviousButton = new BudgetExecution.BarButton();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TextBox = new BudgetExecution.BarTextBox();
            this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
            this.NextButton = new BudgetExecution.BarButton();
            this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
            this.LastButton = new BudgetExecution.BarButton();
            this.Separator7 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new BudgetExecution.BarButton();
            this.Separator8 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteButton = new BudgetExecution.BarButton();
            this.Separator9 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoButton = new BudgetExecution.BarButton();
            this.Separator10 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshButton = new BudgetExecution.BarButton();
            this.Separator11 = new System.Windows.Forms.ToolStripSeparator();
            this.CalculatorButton = new BudgetExecution.BarButton();
            this.Separator12 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new BudgetExecution.BarButton();
            this.Separator13 = new System.Windows.Forms.ToolStripSeparator();
            this.UploadButton = new BudgetExecution.BarButton();
            this.Separator14 = new System.Windows.Forms.ToolStripSeparator();
            this.BackPanel.SuspendLayout();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.ToolBar.SuspendLayout();
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
            this.BackPanel.Border.HoverVisible = true;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Children = null;
            this.BackPanel.Controls.Add(this.Table);
            this.BackPanel.Controls.Add(this.ToolBar);
            this.BackPanel.DataFilter = null;
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Field = BudgetExecution.Field.NS;
            this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
            this.BackPanel.Location = new System.Drawing.Point(1, 1);
            this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(1);
            this.BackPanel.Size = new System.Drawing.Size(1064, 192);
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Text = "layoutPanel1";
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Table.ColumnCount = 6;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Table.Controls.Add(this.TextBox12, 5, 3);
            this.Table.Controls.Add(this.TextBox11, 4, 3);
            this.Table.Controls.Add(this.Label12, 5, 2);
            this.Table.Controls.Add(this.Label11, 4, 2);
            this.Table.Controls.Add(this.TextBox7, 0, 3);
            this.Table.Controls.Add(this.TextBox6, 0, 3);
            this.Table.Controls.Add(this.TextBox9, 0, 3);
            this.Table.Controls.Add(this.TextBox5, 4, 1);
            this.Table.Controls.Add(this.TextBox4, 3, 1);
            this.Table.Controls.Add(this.TextBox3, 2, 1);
            this.Table.Controls.Add(this.TextBox2, 1, 1);
            this.Table.Controls.Add(this.Label5, 4, 0);
            this.Table.Controls.Add(this.Label4, 3, 0);
            this.Table.Controls.Add(this.Label3, 2, 0);
            this.Table.Controls.Add(this.Label2, 1, 0);
            this.Table.Controls.Add(this.Label1, 0, 0);
            this.Table.Controls.Add(this.TextBox1, 0, 1);
            this.Table.Controls.Add(this.TextBox10, 1, 3);
            this.Table.Controls.Add(this.Label6, 5, 0);
            this.Table.Controls.Add(this.TextBox8, 5, 1);
            this.Table.Controls.Add(this.Label7, 0, 2);
            this.Table.Controls.Add(this.Label8, 1, 2);
            this.Table.Controls.Add(this.Label9, 2, 2);
            this.Table.Controls.Add(this.Label10, 3, 2);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 4;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.Size = new System.Drawing.Size(1064, 145);
            this.Table.TabIndex = 1;
            // 
            // TextBox12
            // 
            this.TextBox12.AlphaNumeric = false;
            this.TextBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox12.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox12.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox12.BindingSource = this.BindingSource;
            this.TextBox12.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox12.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox12.Border.HoverVisible = true;
            this.TextBox12.Border.Rounding = 6;
            this.TextBox12.Border.Thickness = 1;
            this.TextBox12.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox12.Border.Visible = true;
            this.TextBox12.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox12.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox12.ButtonBorder.HoverVisible = true;
            this.TextBox12.ButtonBorder.Rounding = 6;
            this.TextBox12.ButtonBorder.Thickness = 1;
            this.TextBox12.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox12.ButtonBorder.Visible = true;
            this.TextBox12.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox12.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox12.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox12.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox12.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox12.ButtonIndent = 3;
            this.TextBox12.ButtonText = "visualButton";
            this.TextBox12.ButtonVisible = false;
            this.TextBox12.DataFilter = null;
            this.TextBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox12.Field = BudgetExecution.Field.NS;
            this.TextBox12.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox12.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox12.Image = null;
            this.TextBox12.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox12.ImageVisible = false;
            this.TextBox12.ImageWidth = 35;
            this.TextBox12.Location = new System.Drawing.Point(888, 111);
            this.TextBox12.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox12.PasswordChar = '\0';
            this.TextBox12.ReadOnly = false;
            this.TextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox12.Size = new System.Drawing.Size(173, 23);
            this.TextBox12.TabIndex = 23;
            this.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox12.TextBoxWidth = 163;
            this.TextBox12.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox12.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox12.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox12.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox12.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox12.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox12.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox12.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox12.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox12.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox12.Watermark.Text = "Watermark text";
            this.TextBox12.Watermark.Visible = false;
            this.TextBox12.WordWrap = true;
            // 
            // BindingSource
            // 
            this.BindingSource.DataFilter = null;
            this.BindingSource.Numeric = BudgetExecution.Numeric.Default;
            // 
            // TextBox11
            // 
            this.TextBox11.AlphaNumeric = false;
            this.TextBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox11.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox11.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox11.BindingSource = this.BindingSource;
            this.TextBox11.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox11.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox11.Border.HoverVisible = true;
            this.TextBox11.Border.Rounding = 6;
            this.TextBox11.Border.Thickness = 1;
            this.TextBox11.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox11.Border.Visible = true;
            this.TextBox11.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox11.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox11.ButtonBorder.HoverVisible = true;
            this.TextBox11.ButtonBorder.Rounding = 6;
            this.TextBox11.ButtonBorder.Thickness = 1;
            this.TextBox11.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox11.ButtonBorder.Visible = true;
            this.TextBox11.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox11.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox11.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox11.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox11.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox11.ButtonIndent = 3;
            this.TextBox11.ButtonText = "visualButton";
            this.TextBox11.ButtonVisible = false;
            this.TextBox11.DataFilter = null;
            this.TextBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox11.Field = BudgetExecution.Field.NS;
            this.TextBox11.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox11.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox11.Image = null;
            this.TextBox11.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox11.ImageVisible = false;
            this.TextBox11.ImageWidth = 35;
            this.TextBox11.Location = new System.Drawing.Point(711, 111);
            this.TextBox11.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox11.PasswordChar = '\0';
            this.TextBox11.ReadOnly = false;
            this.TextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox11.Size = new System.Drawing.Size(171, 23);
            this.TextBox11.TabIndex = 22;
            this.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox11.TextBoxWidth = 161;
            this.TextBox11.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox11.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox11.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox11.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox11.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox11.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox11.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox11.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox11.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox11.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox11.Watermark.Text = "Watermark text";
            this.TextBox11.Watermark.Visible = false;
            this.TextBox11.WordWrap = true;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label12.BindingSource = this.BindingSource;
            this.Label12.DataFilter = null;
            this.Label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label12.Field = BudgetExecution.Field.NS;
            this.Label12.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label12.ForeColor = System.Drawing.Color.LightGray;
            this.Label12.Location = new System.Drawing.Point(888, 75);
            this.Label12.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label12.Name = "Label12";
            this.Label12.Numeric = BudgetExecution.Numeric.Default;
            this.Label12.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label12.Outline = false;
            this.Label12.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label12.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label12.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label12.ReflectionSpacing = 0;
            this.Label12.ShadowColor = System.Drawing.Color.Black;
            this.Label12.ShadowDirection = 315;
            this.Label12.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label12.ShadowOpacity = 100;
            this.Label12.Size = new System.Drawing.Size(173, 30);
            this.Label12.TabIndex = 21;
            this.Label12.Text = "Label 12";
            this.Label12.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label12.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label12.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label12.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label12.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label12.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label12.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label12.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label12.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label11.BindingSource = this.BindingSource;
            this.Label11.DataFilter = null;
            this.Label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label11.Field = BudgetExecution.Field.NS;
            this.Label11.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label11.ForeColor = System.Drawing.Color.LightGray;
            this.Label11.Location = new System.Drawing.Point(711, 75);
            this.Label11.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label11.Name = "Label11";
            this.Label11.Numeric = BudgetExecution.Numeric.Default;
            this.Label11.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label11.Outline = false;
            this.Label11.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label11.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label11.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label11.ReflectionSpacing = 0;
            this.Label11.ShadowColor = System.Drawing.Color.Black;
            this.Label11.ShadowDirection = 315;
            this.Label11.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label11.ShadowOpacity = 100;
            this.Label11.Size = new System.Drawing.Size(171, 30);
            this.Label11.TabIndex = 20;
            this.Label11.Text = "Label 11";
            this.Label11.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label11.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label11.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label11.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label11.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label11.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label11.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label11.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label11.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // TextBox7
            // 
            this.TextBox7.AlphaNumeric = false;
            this.TextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox7.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox7.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox7.BindingSource = this.BindingSource;
            this.TextBox7.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox7.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox7.Border.HoverVisible = true;
            this.TextBox7.Border.Rounding = 6;
            this.TextBox7.Border.Thickness = 1;
            this.TextBox7.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox7.Border.Visible = true;
            this.TextBox7.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox7.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox7.ButtonBorder.HoverVisible = true;
            this.TextBox7.ButtonBorder.Rounding = 6;
            this.TextBox7.ButtonBorder.Thickness = 1;
            this.TextBox7.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox7.ButtonBorder.Visible = true;
            this.TextBox7.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox7.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox7.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox7.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox7.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox7.ButtonIndent = 3;
            this.TextBox7.ButtonText = "visualButton";
            this.TextBox7.ButtonVisible = false;
            this.TextBox7.DataFilter = null;
            this.TextBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox7.Field = BudgetExecution.Field.NS;
            this.TextBox7.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox7.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox7.Image = null;
            this.TextBox7.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox7.ImageVisible = false;
            this.TextBox7.ImageWidth = 35;
            this.TextBox7.Location = new System.Drawing.Point(3, 111);
            this.TextBox7.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox7.PasswordChar = '\0';
            this.TextBox7.ReadOnly = false;
            this.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox7.Size = new System.Drawing.Size(171, 23);
            this.TextBox7.TabIndex = 18;
            this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox7.TextBoxWidth = 161;
            this.TextBox7.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox7.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox7.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox7.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox7.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox7.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox7.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox7.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox7.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox7.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox7.Watermark.Text = "Watermark text";
            this.TextBox7.Watermark.Visible = false;
            this.TextBox7.WordWrap = true;
            // 
            // TextBox6
            // 
            this.TextBox6.AlphaNumeric = false;
            this.TextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox6.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox6.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox6.BindingSource = this.BindingSource;
            this.TextBox6.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox6.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox6.Border.HoverVisible = true;
            this.TextBox6.Border.Rounding = 6;
            this.TextBox6.Border.Thickness = 1;
            this.TextBox6.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox6.Border.Visible = true;
            this.TextBox6.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox6.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox6.ButtonBorder.HoverVisible = true;
            this.TextBox6.ButtonBorder.Rounding = 6;
            this.TextBox6.ButtonBorder.Thickness = 1;
            this.TextBox6.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox6.ButtonBorder.Visible = true;
            this.TextBox6.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox6.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox6.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox6.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox6.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox6.ButtonIndent = 3;
            this.TextBox6.ButtonText = "visualButton";
            this.TextBox6.ButtonVisible = false;
            this.TextBox6.DataFilter = null;
            this.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox6.Field = BudgetExecution.Field.NS;
            this.TextBox6.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox6.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox6.Image = null;
            this.TextBox6.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox6.ImageVisible = false;
            this.TextBox6.ImageWidth = 35;
            this.TextBox6.Location = new System.Drawing.Point(357, 111);
            this.TextBox6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox6.PasswordChar = '\0';
            this.TextBox6.ReadOnly = false;
            this.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox6.Size = new System.Drawing.Size(171, 23);
            this.TextBox6.TabIndex = 17;
            this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox6.TextBoxWidth = 161;
            this.TextBox6.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox6.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox6.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox6.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox6.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox6.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox6.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox6.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox6.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox6.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox6.Watermark.Text = "Watermark text";
            this.TextBox6.Watermark.Visible = false;
            this.TextBox6.WordWrap = true;
            // 
            // TextBox9
            // 
            this.TextBox9.AlphaNumeric = false;
            this.TextBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox9.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox9.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox9.BindingSource = this.BindingSource;
            this.TextBox9.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox9.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox9.Border.HoverVisible = true;
            this.TextBox9.Border.Rounding = 6;
            this.TextBox9.Border.Thickness = 1;
            this.TextBox9.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox9.Border.Visible = true;
            this.TextBox9.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox9.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox9.ButtonBorder.HoverVisible = true;
            this.TextBox9.ButtonBorder.Rounding = 6;
            this.TextBox9.ButtonBorder.Thickness = 1;
            this.TextBox9.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox9.ButtonBorder.Visible = true;
            this.TextBox9.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox9.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox9.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox9.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox9.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox9.ButtonIndent = 3;
            this.TextBox9.ButtonText = "visualButton";
            this.TextBox9.ButtonVisible = false;
            this.TextBox9.DataFilter = null;
            this.TextBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox9.Field = BudgetExecution.Field.NS;
            this.TextBox9.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox9.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox9.Image = null;
            this.TextBox9.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox9.ImageVisible = false;
            this.TextBox9.ImageWidth = 35;
            this.TextBox9.Location = new System.Drawing.Point(180, 111);
            this.TextBox9.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox9.PasswordChar = '\0';
            this.TextBox9.ReadOnly = false;
            this.TextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox9.Size = new System.Drawing.Size(171, 23);
            this.TextBox9.TabIndex = 15;
            this.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox9.TextBoxWidth = 161;
            this.TextBox9.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox9.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox9.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox9.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox9.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox9.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox9.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox9.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox9.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox9.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox9.Watermark.Text = "Watermark text";
            this.TextBox9.Watermark.Visible = false;
            this.TextBox9.WordWrap = true;
            // 
            // TextBox5
            // 
            this.TextBox5.AlphaNumeric = false;
            this.TextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox5.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox5.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox5.BindingSource = this.BindingSource;
            this.TextBox5.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox5.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox5.Border.HoverVisible = true;
            this.TextBox5.Border.Rounding = 6;
            this.TextBox5.Border.Thickness = 1;
            this.TextBox5.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox5.Border.Visible = true;
            this.TextBox5.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox5.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox5.ButtonBorder.HoverVisible = true;
            this.TextBox5.ButtonBorder.Rounding = 6;
            this.TextBox5.ButtonBorder.Thickness = 1;
            this.TextBox5.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox5.ButtonBorder.Visible = true;
            this.TextBox5.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox5.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox5.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox5.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox5.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox5.ButtonIndent = 3;
            this.TextBox5.ButtonText = "visualButton";
            this.TextBox5.ButtonVisible = false;
            this.TextBox5.DataFilter = null;
            this.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox5.Field = BudgetExecution.Field.NS;
            this.TextBox5.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox5.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox5.Image = null;
            this.TextBox5.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox5.ImageVisible = false;
            this.TextBox5.ImageWidth = 35;
            this.TextBox5.Location = new System.Drawing.Point(711, 39);
            this.TextBox5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox5.PasswordChar = '\0';
            this.TextBox5.ReadOnly = false;
            this.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox5.Size = new System.Drawing.Size(171, 23);
            this.TextBox5.TabIndex = 9;
            this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox5.TextBoxWidth = 161;
            this.TextBox5.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox5.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox5.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox5.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox5.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox5.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox5.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox5.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox5.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox5.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox5.Watermark.Text = "Watermark text";
            this.TextBox5.Watermark.Visible = false;
            this.TextBox5.WordWrap = true;
            // 
            // TextBox4
            // 
            this.TextBox4.AlphaNumeric = false;
            this.TextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox4.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox4.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox4.BindingSource = this.BindingSource;
            this.TextBox4.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox4.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox4.Border.HoverVisible = true;
            this.TextBox4.Border.Rounding = 6;
            this.TextBox4.Border.Thickness = 1;
            this.TextBox4.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox4.Border.Visible = true;
            this.TextBox4.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox4.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox4.ButtonBorder.HoverVisible = true;
            this.TextBox4.ButtonBorder.Rounding = 6;
            this.TextBox4.ButtonBorder.Thickness = 1;
            this.TextBox4.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox4.ButtonBorder.Visible = true;
            this.TextBox4.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox4.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox4.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox4.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox4.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.ButtonIndent = 3;
            this.TextBox4.ButtonText = "visualButton";
            this.TextBox4.ButtonVisible = false;
            this.TextBox4.DataFilter = null;
            this.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox4.Field = BudgetExecution.Field.NS;
            this.TextBox4.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox4.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox4.Image = null;
            this.TextBox4.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox4.ImageVisible = false;
            this.TextBox4.ImageWidth = 35;
            this.TextBox4.Location = new System.Drawing.Point(534, 39);
            this.TextBox4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox4.PasswordChar = '\0';
            this.TextBox4.ReadOnly = false;
            this.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox4.Size = new System.Drawing.Size(171, 23);
            this.TextBox4.TabIndex = 8;
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox4.TextBoxWidth = 161;
            this.TextBox4.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox4.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox4.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox4.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox4.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox4.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox4.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox4.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox4.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox4.Watermark.Text = "Watermark text";
            this.TextBox4.Watermark.Visible = false;
            this.TextBox4.WordWrap = true;
            // 
            // TextBox3
            // 
            this.TextBox3.AlphaNumeric = false;
            this.TextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox3.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox3.BindingSource = this.BindingSource;
            this.TextBox3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox3.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox3.Border.HoverVisible = true;
            this.TextBox3.Border.Rounding = 6;
            this.TextBox3.Border.Thickness = 1;
            this.TextBox3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox3.Border.Visible = true;
            this.TextBox3.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox3.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox3.ButtonBorder.HoverVisible = true;
            this.TextBox3.ButtonBorder.Rounding = 6;
            this.TextBox3.ButtonBorder.Thickness = 1;
            this.TextBox3.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox3.ButtonBorder.Visible = true;
            this.TextBox3.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox3.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox3.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox3.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox3.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.ButtonIndent = 3;
            this.TextBox3.ButtonText = "visualButton";
            this.TextBox3.ButtonVisible = false;
            this.TextBox3.DataFilter = null;
            this.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox3.Field = BudgetExecution.Field.NS;
            this.TextBox3.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox3.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox3.Image = null;
            this.TextBox3.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox3.ImageVisible = false;
            this.TextBox3.ImageWidth = 35;
            this.TextBox3.Location = new System.Drawing.Point(357, 39);
            this.TextBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox3.PasswordChar = '\0';
            this.TextBox3.ReadOnly = false;
            this.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox3.Size = new System.Drawing.Size(171, 23);
            this.TextBox3.TabIndex = 7;
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox3.TextBoxWidth = 161;
            this.TextBox3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox3.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox3.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox3.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox3.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox3.Watermark.Text = "Watermark text";
            this.TextBox3.Watermark.Visible = false;
            this.TextBox3.WordWrap = true;
            // 
            // TextBox2
            // 
            this.TextBox2.AlphaNumeric = false;
            this.TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox2.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox2.BindingSource = this.BindingSource;
            this.TextBox2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox2.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox2.Border.HoverVisible = true;
            this.TextBox2.Border.Rounding = 6;
            this.TextBox2.Border.Thickness = 1;
            this.TextBox2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox2.Border.Visible = true;
            this.TextBox2.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox2.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox2.ButtonBorder.HoverVisible = true;
            this.TextBox2.ButtonBorder.Rounding = 6;
            this.TextBox2.ButtonBorder.Thickness = 1;
            this.TextBox2.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox2.ButtonBorder.Visible = true;
            this.TextBox2.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox2.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox2.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox2.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox2.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.ButtonIndent = 3;
            this.TextBox2.ButtonText = "visualButton";
            this.TextBox2.ButtonVisible = false;
            this.TextBox2.DataFilter = null;
            this.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox2.Field = BudgetExecution.Field.NS;
            this.TextBox2.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox2.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox2.Image = null;
            this.TextBox2.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox2.ImageVisible = false;
            this.TextBox2.ImageWidth = 35;
            this.TextBox2.Location = new System.Drawing.Point(180, 39);
            this.TextBox2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox2.PasswordChar = '\0';
            this.TextBox2.ReadOnly = false;
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox2.Size = new System.Drawing.Size(171, 23);
            this.TextBox2.TabIndex = 6;
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox2.TextBoxWidth = 161;
            this.TextBox2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox2.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox2.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox2.Watermark.Text = "Watermark text";
            this.TextBox2.Watermark.Visible = false;
            this.TextBox2.WordWrap = true;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label5.BindingSource = this.BindingSource;
            this.Label5.DataFilter = null;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label5.Field = BudgetExecution.Field.NS;
            this.Label5.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label5.ForeColor = System.Drawing.Color.LightGray;
            this.Label5.Location = new System.Drawing.Point(711, 3);
            this.Label5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label5.Name = "Label5";
            this.Label5.Numeric = BudgetExecution.Numeric.Default;
            this.Label5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label5.Outline = false;
            this.Label5.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label5.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label5.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label5.ReflectionSpacing = 0;
            this.Label5.ShadowColor = System.Drawing.Color.Black;
            this.Label5.ShadowDirection = 315;
            this.Label5.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label5.ShadowOpacity = 100;
            this.Label5.Size = new System.Drawing.Size(171, 30);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Label 5";
            this.Label5.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label5.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label5.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label5.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label5.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label5.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label5.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label5.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label5.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label4.BindingSource = this.BindingSource;
            this.Label4.DataFilter = null;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label4.Field = BudgetExecution.Field.NS;
            this.Label4.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label4.ForeColor = System.Drawing.Color.LightGray;
            this.Label4.Location = new System.Drawing.Point(534, 3);
            this.Label4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label4.Name = "Label4";
            this.Label4.Numeric = BudgetExecution.Numeric.Default;
            this.Label4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label4.Outline = false;
            this.Label4.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label4.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label4.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label4.ReflectionSpacing = 0;
            this.Label4.ShadowColor = System.Drawing.Color.Black;
            this.Label4.ShadowDirection = 315;
            this.Label4.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label4.ShadowOpacity = 100;
            this.Label4.Size = new System.Drawing.Size(171, 30);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Label 4";
            this.Label4.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label4.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label4.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label4.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label4.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label4.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label4.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label4.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label3.BindingSource = this.BindingSource;
            this.Label3.DataFilter = null;
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Field = BudgetExecution.Field.NS;
            this.Label3.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label3.ForeColor = System.Drawing.Color.LightGray;
            this.Label3.Location = new System.Drawing.Point(357, 3);
            this.Label3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label3.Name = "Label3";
            this.Label3.Numeric = BudgetExecution.Numeric.Default;
            this.Label3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label3.Outline = false;
            this.Label3.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label3.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label3.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label3.ReflectionSpacing = 0;
            this.Label3.ShadowColor = System.Drawing.Color.Black;
            this.Label3.ShadowDirection = 315;
            this.Label3.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label3.ShadowOpacity = 100;
            this.Label3.Size = new System.Drawing.Size(171, 30);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Label 3";
            this.Label3.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label3.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label3.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label2.BindingSource = this.BindingSource;
            this.Label2.DataFilter = null;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Field = BudgetExecution.Field.NS;
            this.Label2.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label2.ForeColor = System.Drawing.Color.LightGray;
            this.Label2.Location = new System.Drawing.Point(180, 3);
            this.Label2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label2.Name = "Label2";
            this.Label2.Numeric = BudgetExecution.Numeric.Default;
            this.Label2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label2.Outline = false;
            this.Label2.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label2.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label2.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.ReflectionSpacing = 0;
            this.Label2.ShadowColor = System.Drawing.Color.Black;
            this.Label2.ShadowDirection = 315;
            this.Label2.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label2.ShadowOpacity = 100;
            this.Label2.Size = new System.Drawing.Size(171, 30);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Label 2";
            this.Label2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label1.BindingSource = this.BindingSource;
            this.Label1.DataFilter = null;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Field = BudgetExecution.Field.NS;
            this.Label1.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label1.ForeColor = System.Drawing.Color.LightGray;
            this.Label1.Location = new System.Drawing.Point(3, 3);
            this.Label1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label1.Name = "Label1";
            this.Label1.Numeric = BudgetExecution.Numeric.Default;
            this.Label1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label1.Outline = false;
            this.Label1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.ReflectionSpacing = 0;
            this.Label1.ShadowColor = System.Drawing.Color.Black;
            this.Label1.ShadowDirection = 315;
            this.Label1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label1.ShadowOpacity = 100;
            this.Label1.Size = new System.Drawing.Size(171, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Label 1";
            this.Label1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // TextBox1
            // 
            this.TextBox1.AlphaNumeric = false;
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox1.BindingSource = this.BindingSource;
            this.TextBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox1.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox1.Border.HoverVisible = true;
            this.TextBox1.Border.Rounding = 6;
            this.TextBox1.Border.Thickness = 1;
            this.TextBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox1.Border.Visible = true;
            this.TextBox1.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox1.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox1.ButtonBorder.HoverVisible = true;
            this.TextBox1.ButtonBorder.Rounding = 6;
            this.TextBox1.ButtonBorder.Thickness = 1;
            this.TextBox1.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox1.ButtonBorder.Visible = true;
            this.TextBox1.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox1.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox1.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox1.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ButtonIndent = 3;
            this.TextBox1.ButtonText = "visualButton";
            this.TextBox1.ButtonVisible = false;
            this.TextBox1.DataFilter = null;
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Field = BudgetExecution.Field.NS;
            this.TextBox1.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox1.Image = null;
            this.TextBox1.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox1.ImageVisible = false;
            this.TextBox1.ImageWidth = 35;
            this.TextBox1.Location = new System.Drawing.Point(3, 39);
            this.TextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.ReadOnly = false;
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox1.Size = new System.Drawing.Size(171, 23);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1.TextBoxWidth = 161;
            this.TextBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox1.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox1.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox1.Watermark.Text = "Watermark text";
            this.TextBox1.Watermark.Visible = false;
            this.TextBox1.WordWrap = true;
            // 
            // TextBox10
            // 
            this.TextBox10.AlphaNumeric = false;
            this.TextBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox10.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox10.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox10.BindingSource = this.BindingSource;
            this.TextBox10.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox10.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox10.Border.HoverVisible = true;
            this.TextBox10.Border.Rounding = 6;
            this.TextBox10.Border.Thickness = 1;
            this.TextBox10.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox10.Border.Visible = true;
            this.TextBox10.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox10.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox10.ButtonBorder.HoverVisible = true;
            this.TextBox10.ButtonBorder.Rounding = 6;
            this.TextBox10.ButtonBorder.Thickness = 1;
            this.TextBox10.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox10.ButtonBorder.Visible = true;
            this.TextBox10.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox10.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox10.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox10.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox10.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox10.ButtonIndent = 3;
            this.TextBox10.ButtonText = "visualButton";
            this.TextBox10.ButtonVisible = false;
            this.TextBox10.DataFilter = null;
            this.TextBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox10.Field = BudgetExecution.Field.NS;
            this.TextBox10.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox10.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox10.Image = null;
            this.TextBox10.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox10.ImageVisible = false;
            this.TextBox10.ImageWidth = 35;
            this.TextBox10.Location = new System.Drawing.Point(534, 111);
            this.TextBox10.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox10.PasswordChar = '\0';
            this.TextBox10.ReadOnly = false;
            this.TextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox10.Size = new System.Drawing.Size(171, 23);
            this.TextBox10.TabIndex = 16;
            this.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox10.TextBoxWidth = 161;
            this.TextBox10.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox10.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox10.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox10.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox10.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox10.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox10.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox10.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox10.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox10.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox10.Watermark.Text = "Watermark text";
            this.TextBox10.Watermark.Visible = false;
            this.TextBox10.WordWrap = true;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label6.BindingSource = this.BindingSource;
            this.Label6.DataFilter = null;
            this.Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label6.Field = BudgetExecution.Field.NS;
            this.Label6.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label6.ForeColor = System.Drawing.Color.LightGray;
            this.Label6.Location = new System.Drawing.Point(888, 3);
            this.Label6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label6.Name = "Label6";
            this.Label6.Numeric = BudgetExecution.Numeric.Default;
            this.Label6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label6.Outline = false;
            this.Label6.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label6.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label6.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label6.ReflectionSpacing = 0;
            this.Label6.ShadowColor = System.Drawing.Color.Black;
            this.Label6.ShadowDirection = 315;
            this.Label6.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label6.ShadowOpacity = 100;
            this.Label6.Size = new System.Drawing.Size(173, 30);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Label 6";
            this.Label6.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label6.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label6.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label6.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label6.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label6.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label6.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label6.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label6.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // TextBox8
            // 
            this.TextBox8.AlphaNumeric = false;
            this.TextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox8.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox8.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox8.BindingSource = this.BindingSource;
            this.TextBox8.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox8.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
            this.TextBox8.Border.HoverVisible = true;
            this.TextBox8.Border.Rounding = 6;
            this.TextBox8.Border.Thickness = 1;
            this.TextBox8.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox8.Border.Visible = true;
            this.TextBox8.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox8.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox8.ButtonBorder.HoverVisible = true;
            this.TextBox8.ButtonBorder.Rounding = 6;
            this.TextBox8.ButtonBorder.Thickness = 1;
            this.TextBox8.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox8.ButtonBorder.Visible = true;
            this.TextBox8.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox8.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox8.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox8.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox8.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox8.ButtonIndent = 3;
            this.TextBox8.ButtonText = "visualButton";
            this.TextBox8.ButtonVisible = false;
            this.TextBox8.DataFilter = null;
            this.TextBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox8.Field = BudgetExecution.Field.NS;
            this.TextBox8.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox8.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox8.Image = null;
            this.TextBox8.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox8.ImageVisible = false;
            this.TextBox8.ImageWidth = 35;
            this.TextBox8.Location = new System.Drawing.Point(888, 39);
            this.TextBox8.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Numeric = BudgetExecution.Numeric.Default;
            this.TextBox8.PasswordChar = '\0';
            this.TextBox8.ReadOnly = false;
            this.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox8.Size = new System.Drawing.Size(173, 23);
            this.TextBox8.TabIndex = 19;
            this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox8.TextBoxWidth = 163;
            this.TextBox8.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox8.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox8.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox8.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox8.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox8.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox8.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox8.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox8.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox8.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox8.Watermark.Text = "Watermark text";
            this.TextBox8.Watermark.Visible = false;
            this.TextBox8.WordWrap = true;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label7.BindingSource = this.BindingSource;
            this.Label7.DataFilter = null;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Field = BudgetExecution.Field.NS;
            this.Label7.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label7.ForeColor = System.Drawing.Color.LightGray;
            this.Label7.Location = new System.Drawing.Point(3, 75);
            this.Label7.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label7.Name = "Label7";
            this.Label7.Numeric = BudgetExecution.Numeric.Default;
            this.Label7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label7.Outline = false;
            this.Label7.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label7.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label7.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label7.ReflectionSpacing = 0;
            this.Label7.ShadowColor = System.Drawing.Color.Black;
            this.Label7.ShadowDirection = 315;
            this.Label7.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label7.ShadowOpacity = 100;
            this.Label7.Size = new System.Drawing.Size(171, 30);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Label 7";
            this.Label7.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label7.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label7.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label7.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label7.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label7.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label7.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label7.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label7.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label8.BindingSource = this.BindingSource;
            this.Label8.DataFilter = null;
            this.Label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label8.Field = BudgetExecution.Field.NS;
            this.Label8.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label8.ForeColor = System.Drawing.Color.LightGray;
            this.Label8.Location = new System.Drawing.Point(180, 75);
            this.Label8.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label8.Name = "Label8";
            this.Label8.Numeric = BudgetExecution.Numeric.Default;
            this.Label8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label8.Outline = false;
            this.Label8.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label8.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label8.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label8.ReflectionSpacing = 0;
            this.Label8.ShadowColor = System.Drawing.Color.Black;
            this.Label8.ShadowDirection = 315;
            this.Label8.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label8.ShadowOpacity = 100;
            this.Label8.Size = new System.Drawing.Size(171, 30);
            this.Label8.TabIndex = 12;
            this.Label8.Text = "Label 8";
            this.Label8.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label8.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label8.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label8.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label8.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label8.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label8.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label8.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label8.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label9.BindingSource = this.BindingSource;
            this.Label9.DataFilter = null;
            this.Label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label9.Field = BudgetExecution.Field.NS;
            this.Label9.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label9.ForeColor = System.Drawing.Color.LightGray;
            this.Label9.Location = new System.Drawing.Point(357, 75);
            this.Label9.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label9.Name = "Label9";
            this.Label9.Numeric = BudgetExecution.Numeric.Default;
            this.Label9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label9.Outline = false;
            this.Label9.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label9.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label9.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label9.ReflectionSpacing = 0;
            this.Label9.ShadowColor = System.Drawing.Color.Black;
            this.Label9.ShadowDirection = 315;
            this.Label9.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label9.ShadowOpacity = 100;
            this.Label9.Size = new System.Drawing.Size(171, 30);
            this.Label9.TabIndex = 13;
            this.Label9.Text = "Label 9";
            this.Label9.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label9.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label9.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label9.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label9.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label9.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label9.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label9.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label9.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label10.BindingSource = this.BindingSource;
            this.Label10.DataFilter = null;
            this.Label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label10.Field = BudgetExecution.Field.NS;
            this.Label10.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label10.ForeColor = System.Drawing.Color.LightGray;
            this.Label10.Location = new System.Drawing.Point(534, 75);
            this.Label10.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label10.Name = "Label10";
            this.Label10.Numeric = BudgetExecution.Numeric.Default;
            this.Label10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label10.Outline = false;
            this.Label10.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Label10.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label10.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label10.ReflectionSpacing = 0;
            this.Label10.ShadowColor = System.Drawing.Color.Black;
            this.Label10.ShadowDirection = 315;
            this.Label10.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label10.ShadowOpacity = 100;
            this.Label10.Size = new System.Drawing.Size(171, 30);
            this.Label10.TabIndex = 14;
            this.Label10.Text = "Label 10";
            this.Label10.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label10.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label10.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label10.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label10.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label10.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label10.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label10.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label10.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolBar.BindingSource = this.BindingSource;
            this.ToolBar.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolBar.CanOverflow = false;
            this.ToolBar.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Far;
            this.ToolBar.DataFilter = null;
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolBar.Field = BudgetExecution.Field.NS;
            this.ToolBar.Font = new System.Drawing.Font("Roboto", 8F);
            this.ToolBar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.Image = null;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator1,
            this.Label,
            this.Separator2,
            this.FirstButton,
            this.Separator3,
            this.PreviousButton,
            this.Separator4,
            this.TextBox,
            this.Separator5,
            this.NextButton,
            this.Separator6,
            this.LastButton,
            this.Separator7,
            this.AddButton,
            this.Separator8,
            this.DeleteButton,
            this.Separator9,
            this.UndoButton,
            this.Separator10,
            this.RefreshButton,
            this.Separator11,
            this.CalculatorButton,
            this.Separator12,
            this.SaveButton,
            this.Separator13,
            this.UploadButton,
            this.Separator14});
            this.ToolBar.Location = new System.Drawing.Point(0, 145);
            this.ToolBar.Margin = new System.Windows.Forms.Padding(3);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Numeric = BudgetExecution.Numeric.Default;
            this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolBar.ShowCaption = true;
            this.ToolBar.ShowLauncher = false;
            this.ToolBar.Size = new System.Drawing.Size(1064, 47);
            this.ToolBar.TabIndex = 0;
            // 
            // Separator1
            // 
            this.Separator1.Margin = new System.Windows.Forms.Padding(1);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(6, 30);
            // 
            // Label
            // 
            this.Label.BindingSource = this.BindingSource;
            this.Label.Field = BudgetExecution.Field.NS;
            this.Label.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(3, 5, 10, 5);
            this.Label.Name = "Label";
            this.Label.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Label.Size = new System.Drawing.Size(110, 22);
            this.Label.Tag = "Label";
            this.Label.Text = "Data Source:             ";
            // 
            // Separator2
            // 
            this.Separator2.Margin = new System.Windows.Forms.Padding(1);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(6, 30);
            // 
            // FirstButton
            // 
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.FirstButton.Bar = BudgetExecution.Tool.FirstButton;
            this.FirstButton.BindingSource = this.BindingSource;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.NS;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.FirstButton.ForeColor = System.Drawing.Color.LightGray;
            this.FirstButton.HoverText = null;
            this.FirstButton.Image = ((System.Drawing.Image)(resources.GetObject("FirstButton.Image")));
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.Size = new System.Drawing.Size(23, 22);
            this.FirstButton.Text = "barButton1";
            // 
            // Separator3
            // 
            this.Separator3.Margin = new System.Windows.Forms.Padding(1);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 30);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PreviousButton.Bar = BudgetExecution.Tool.PreviousButton;
            this.PreviousButton.BindingSource = this.BindingSource;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.NS;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            this.PreviousButton.HoverText = null;
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Padding = new System.Windows.Forms.Padding(1);
            this.PreviousButton.Size = new System.Drawing.Size(23, 22);
            this.PreviousButton.Text = "barButton2";
            // 
            // Separator4
            // 
            this.Separator4.Margin = new System.Windows.Forms.Padding(1);
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(6, 30);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BindingSource = this.BindingSource;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Field = BudgetExecution.Field.NS;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.HoverText = null;
            this.TextBox.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.TextBox.Name = "TextBox";
            this.TextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.TextBox.Padding = new System.Windows.Forms.Padding(1);
            this.TextBox.Size = new System.Drawing.Size(158, 30);
            this.TextBox.Tag = "";
            this.TextBox.Text = "Record";
            this.TextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Separator5
            // 
            this.Separator5.Margin = new System.Windows.Forms.Padding(1);
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(6, 30);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.NextButton.Bar = BudgetExecution.Tool.NextButton;
            this.NextButton.BindingSource = this.BindingSource;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.NS;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.NextButton.ForeColor = System.Drawing.Color.LightGray;
            this.NextButton.HoverText = null;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Padding = new System.Windows.Forms.Padding(1);
            this.NextButton.Size = new System.Drawing.Size(23, 22);
            this.NextButton.Text = "barButton3";
            // 
            // Separator6
            // 
            this.Separator6.Margin = new System.Windows.Forms.Padding(1);
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 30);
            // 
            // LastButton
            // 
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.LastButton.Bar = BudgetExecution.Tool.LastButton;
            this.LastButton.BindingSource = this.BindingSource;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.NS;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.LastButton.ForeColor = System.Drawing.Color.LightGray;
            this.LastButton.HoverText = null;
            this.LastButton.Image = ((System.Drawing.Image)(resources.GetObject("LastButton.Image")));
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Padding = new System.Windows.Forms.Padding(1);
            this.LastButton.Size = new System.Drawing.Size(23, 22);
            this.LastButton.Text = "barButton4";
            // 
            // Separator7
            // 
            this.Separator7.Margin = new System.Windows.Forms.Padding(1);
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(6, 30);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.AddButton.Bar = BudgetExecution.Tool.AddButton;
            this.AddButton.BindingSource = this.BindingSource;
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Field = BudgetExecution.Field.NS;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.AddButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddButton.HoverText = null;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(1);
            this.AddButton.Size = new System.Drawing.Size(23, 22);
            this.AddButton.Text = "barButton5";
            // 
            // Separator8
            // 
            this.Separator8.Margin = new System.Windows.Forms.Padding(1);
            this.Separator8.Name = "Separator8";
            this.Separator8.Size = new System.Drawing.Size(6, 30);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DeleteButton.Bar = BudgetExecution.Tool.DeleteButton;
            this.DeleteButton.BindingSource = this.BindingSource;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Field = BudgetExecution.Field.NS;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightGray;
            this.DeleteButton.HoverText = null;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(1);
            this.DeleteButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteButton.Text = "barButton6";
            // 
            // Separator9
            // 
            this.Separator9.Margin = new System.Windows.Forms.Padding(1);
            this.Separator9.Name = "Separator9";
            this.Separator9.Size = new System.Drawing.Size(6, 30);
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.UndoButton.Bar = BudgetExecution.Tool.UndoButton;
            this.UndoButton.BindingSource = this.BindingSource;
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Field = BudgetExecution.Field.NS;
            this.UndoButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.UndoButton.ForeColor = System.Drawing.Color.LightGray;
            this.UndoButton.HoverText = null;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Padding = new System.Windows.Forms.Padding(1);
            this.UndoButton.Size = new System.Drawing.Size(23, 22);
            this.UndoButton.Text = "barButton7";
            // 
            // Separator10
            // 
            this.Separator10.Margin = new System.Windows.Forms.Padding(1);
            this.Separator10.Name = "Separator10";
            this.Separator10.Size = new System.Drawing.Size(6, 30);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.RefreshButton.Bar = BudgetExecution.Tool.RefreshButton;
            this.RefreshButton.BindingSource = this.BindingSource;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Field = BudgetExecution.Field.NS;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.RefreshButton.ForeColor = System.Drawing.Color.LightGray;
            this.RefreshButton.HoverText = null;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.Text = "barButton8";
            // 
            // Separator11
            // 
            this.Separator11.Name = "Separator11";
            this.Separator11.Size = new System.Drawing.Size(6, 32);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CalculatorButton.Bar = BudgetExecution.Tool.CalculatorButton;
            this.CalculatorButton.BindingSource = this.BindingSource;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.NS;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightGray;
            this.CalculatorButton.HoverText = null;
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Padding = new System.Windows.Forms.Padding(1);
            this.CalculatorButton.Size = new System.Drawing.Size(23, 22);
            // 
            // Separator12
            // 
            this.Separator12.Name = "Separator12";
            this.Separator12.Size = new System.Drawing.Size(6, 32);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.SaveButton.Bar = BudgetExecution.Tool.SaveButton;
            this.SaveButton.BindingSource = this.BindingSource;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.NS;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.SaveButton.ForeColor = System.Drawing.Color.LightGray;
            this.SaveButton.HoverText = null;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(1);
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "barButton9";
            // 
            // Separator13
            // 
            this.Separator13.Name = "Separator13";
            this.Separator13.Size = new System.Drawing.Size(6, 32);
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.UploadButton.Bar = BudgetExecution.Tool.UpdateButton;
            this.UploadButton.BindingSource = this.BindingSource;
            this.UploadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UploadButton.Field = BudgetExecution.Field.NS;
            this.UploadButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.UploadButton.ForeColor = System.Drawing.Color.LightGray;
            this.UploadButton.HoverText = null;
            this.UploadButton.Image = ((System.Drawing.Image)(resources.GetObject("UploadButton.Image")));
            this.UploadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UploadButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Padding = new System.Windows.Forms.Padding(1);
            this.UploadButton.Size = new System.Drawing.Size(23, 22);
            this.UploadButton.Text = "barButton10";
            // 
            // Separator14
            // 
            this.Separator14.Name = "Separator14";
            this.Separator14.Size = new System.Drawing.Size(6, 32);
            // 
            // RecordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BackPanel);
            this.Name = "RecordControl";
            this.Size = new System.Drawing.Size(1066, 194);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            public TableLayoutPanel Table;

            public TextBoxPanel TextBox8;

            public TextBoxPanel TextBox7;

            public TextBoxPanel TextBox6;

            public TextBoxPanel TextBox9;

            public TextBoxPanel TextBox5;

            public TextBoxPanel TextBox4;

            public TextBoxPanel TextBox3;

            public TextBoxPanel TextBox2;

            public LabelPanel Label5;

            public LabelPanel Label4;

            public LabelPanel Label3;

            public LabelPanel Label2;

            public LabelPanel Label1;

            public TextBoxPanel TextBox1;

            public LabelPanel Label6;

            public LabelPanel Label7;

            public LabelPanel Label8;

            public LabelPanel Label9;

            public LabelPanel Label10;

            public TextBoxPanel TextBox10;

            public ToolPanel ToolBar;

            private ToolStripSeparator Separator1;

            public BarLabel Label;

            public ToolStripSeparator Separator2;

            public BarButton FirstButton;

            public ToolStripSeparator Separator3;

            public BarButton PreviousButton;

            public ToolStripSeparator Separator4;

            private BarTextBox TextBox;

            public ToolStripSeparator Separator5;

            public BarButton NextButton;

            public ToolStripSeparator Separator6;

            public BarButton LastButton;

            public ToolStripSeparator Separator7;

            public BarButton AddButton;

            public ToolStripSeparator Separator8;

            public BarButton DeleteButton;

            public ToolStripSeparator Separator9;

            public BarButton UndoButton;

            public ToolStripSeparator Separator10;

            public BarButton RefreshButton;

            private ToolStripSeparator Separator11;

            public BarButton SaveButton;

            private ToolStripSeparator Separator12;

            public BarButton UploadButton;

            private ToolStripSeparator Separator13;

            public BarButton CalculatorButton;

            public ToolStripSeparator Separator14;

            public TextBoxPanel TextBox12;

            public TextBoxPanel TextBox11;

            public LabelPanel Label12;

            public LabelPanel Label11;

            public new BudgetBinding BindingSource;

        public LayoutPanel BackPanel;
    }
    
}
