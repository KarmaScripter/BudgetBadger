using System;

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    // ********************************************************************************************************************************
        // *********************************************************  ASSEMBLIES   ********************************************************
        // ********************************************************************************************************************************

        partial class DataEditor
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

                System.ComponentModel.ComponentResourceManager resources =
                    new System.ComponentModel.ComponentResourceManager( typeof( DataEditor ) );

                this.BackPanel = new LayoutPanel();
                this.BottomPanel = new LayoutPanel();
                this.SecondRow = new System.Windows.Forms.TableLayoutPanel();
                this.TextBox9 = new TextBoxPanel();
                this.TextBox8 = new TextBoxPanel();
                this.TextBox7 = new TextBoxPanel();
                this.TextBox12 = new TextBoxPanel();
                this.TextBox11 = new TextBoxPanel();
                this.TextBox10 = new TextBoxPanel();
                this.Label7 = new LabelPanel();
                this.Label8 = new LabelPanel();
                this.Label9 = new LabelPanel();
                this.Label10 = new LabelPanel();
                this.Label11 = new LabelPanel();
                this.Label12 = new LabelPanel();
                this.ComboBox7 = new ComboBoxPanel();
                this.BindingSource = new System.Windows.Forms.BindingSource( this.components );
                this.ComboBox8 = new ComboBoxPanel();
                this.ComboBox9 = new ComboBoxPanel();
                this.ComboBox10 = new ComboBoxPanel();
                this.ComboBox11 = new ComboBoxPanel();
                this.ComboBox12 = new ComboBoxPanel();
                this.FirtsRow = new System.Windows.Forms.TableLayoutPanel();
                this.TextBox6 = new TextBoxPanel();
                this.TextBox5 = new TextBoxPanel();
                this.TextBox4 = new TextBoxPanel();
                this.TextBox3 = new TextBoxPanel();
                this.TextBox2 = new TextBoxPanel();
                this.ComboBox6 = new ComboBoxPanel();
                this.ComboBox5 = new ComboBoxPanel();
                this.ComboBox4 = new ComboBoxPanel();
                this.ComboBox3 = new ComboBoxPanel();
                this.ComboBox2 = new ComboBoxPanel();
                this.Label6 = new LabelPanel();
                this.Label5 = new LabelPanel();
                this.Label4 = new LabelPanel();
                this.Label3 = new LabelPanel();
                this.Label2 = new LabelPanel();
                this.Label1 = new LabelPanel();
                this.ComboBox1 = new ComboBoxPanel();
                this.TextBox1 = new TextBoxPanel();
                this.TopPanel = new LayoutPanel();
                this.TopLabel = new LabelPanel();
                this.ToolBar = new ToolPanel();
                this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
                this.BarLabel = new BarLabel();
                this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
                this.FirstButton = new BarButton();
                this.ToolTip = new ToolTip();
                this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
                this.PreviousButton = new BarButton();
                this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
                this.TextBox = new BarTextBox();
                this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
                this.NextButton = new BarButton();
                this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
                this.LastButton = new BarButton();
                this.Separator7 = new System.Windows.Forms.ToolStripSeparator();
                this.AddButton = new BarButton();
                this.Separator8 = new System.Windows.Forms.ToolStripSeparator();
                this.DeleteButton = new BarButton();
                this.Separator9 = new System.Windows.Forms.ToolStripSeparator();
                this.UndoButton = new BarButton();
                this.Separator10 = new System.Windows.Forms.ToolStripSeparator();
                this.RefreshButton = new BarButton();
                this.Separator11 = new System.Windows.Forms.ToolStripSeparator();
                this.SaveButton = new BarButton();
                this.Separator12 = new System.Windows.Forms.ToolStripSeparator();
                this.ComboBox = new BarComboBox();
                this.Separator13 = new System.Windows.Forms.ToolStripSeparator();
                this.CalculatorButton = new BarButton();
                this.Separator14 = new System.Windows.Forms.ToolStripSeparator();
                this.ExitButton = new BarButton();
                this.Separator15 = new System.Windows.Forms.ToolStripSeparator();
                this.BackPanel.SuspendLayout();
                this.BottomPanel.SuspendLayout();
                this.SecondRow.SuspendLayout();
                ( (System.ComponentModel.ISupportInitialize)( this.BindingSource ) ).BeginInit();
                this.FirtsRow.SuspendLayout();
                this.TopPanel.SuspendLayout();
                this.ToolBar.SuspendLayout();
                this.SuspendLayout();

                // 
                // BackPanel
                // 
                this.BackPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BackPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

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
                this.BackPanel.Controls.Add( this.BottomPanel );
                this.BackPanel.Controls.Add( this.TopPanel );
                this.BackPanel.Controls.Add( this.ToolBar );
                this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BackPanel.Field = Field.NS;
                this.BackPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BackPanel.Location = new System.Drawing.Point( 1, 1 );
                this.BackPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BackPanel.Name = "BackPanel";
                this.BackPanel.Padding = new System.Windows.Forms.Padding( 3 );
                this.BackPanel.Size = new System.Drawing.Size( 1147, 320 );
                this.BackPanel.TabIndex = 0;
                this.BackPanel.Text = "layoutPanel1";

                this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.BackPanel.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // BottomPanel
                // 
                this.BottomPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BottomPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BottomPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BottomPanel.BindingSource = null;

                this.BottomPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.BottomPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.BottomPanel.Border.HoverVisible = true;
                this.BottomPanel.Border.Rounding = 6;
                this.BottomPanel.Border.Thickness = 1;
                this.BottomPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.BottomPanel.Border.Visible = true;
                this.BottomPanel.Children = null;
                this.BottomPanel.Controls.Add( this.SecondRow );
                this.BottomPanel.Controls.Add( this.FirtsRow );
                this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.BottomPanel.Field = Field.NS;
                this.BottomPanel.ForeColor = System.Drawing.Color.LightGray;
                this.BottomPanel.Location = new System.Drawing.Point( 0, 44 );
                this.BottomPanel.Margin = new System.Windows.Forms.Padding( 5 );
                this.BottomPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.BottomPanel.Name = "BottomPanel";
                this.BottomPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.BottomPanel.Size = new System.Drawing.Size( 1147, 243 );
                this.BottomPanel.TabIndex = 3;
                this.BottomPanel.Text = "layoutPanel1";

                this.BottomPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.BottomPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BottomPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BottomPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.BottomPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.BottomPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.BottomPanel.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // SecondRow
                // 
                this.SecondRow.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.SecondRow.ColumnCount = 6;

                this.SecondRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent,
                        47.80488F ) );

                this.SecondRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent,
                        52.19512F ) );

                this.SecondRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 202F ) );

                this.SecondRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 182F ) );

                this.SecondRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 183F ) );

                this.SecondRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 186F ) );

                this.SecondRow.Controls.Add( this.TextBox9, 0, 2 );
                this.SecondRow.Controls.Add( this.TextBox8, 0, 2 );
                this.SecondRow.Controls.Add( this.TextBox7, 0, 2 );
                this.SecondRow.Controls.Add( this.TextBox12, 0, 2 );
                this.SecondRow.Controls.Add( this.TextBox11, 0, 2 );
                this.SecondRow.Controls.Add( this.TextBox10, 0, 2 );
                this.SecondRow.Controls.Add( this.Label7, 0, 0 );
                this.SecondRow.Controls.Add( this.Label8, 1, 0 );
                this.SecondRow.Controls.Add( this.Label9, 2, 0 );
                this.SecondRow.Controls.Add( this.Label10, 3, 0 );
                this.SecondRow.Controls.Add( this.Label11, 4, 0 );
                this.SecondRow.Controls.Add( this.Label12, 5, 0 );
                this.SecondRow.Controls.Add( this.ComboBox7, 0, 1 );
                this.SecondRow.Controls.Add( this.ComboBox8, 1, 1 );
                this.SecondRow.Controls.Add( this.ComboBox9, 2, 1 );
                this.SecondRow.Controls.Add( this.ComboBox10, 3, 1 );
                this.SecondRow.Controls.Add( this.ComboBox11, 4, 1 );
                this.SecondRow.Controls.Add( this.ComboBox12, 5, 1 );
                this.SecondRow.Dock = System.Windows.Forms.DockStyle.Fill;
                this.SecondRow.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
                this.SecondRow.Location = new System.Drawing.Point( 0, 128 );
                this.SecondRow.Name = "SecondRow";
                this.SecondRow.RowCount = 3;

                this.SecondRow.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 38.82353F ) );

                this.SecondRow.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 61.17647F ) );

                this.SecondRow.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 44F ) );

                this.SecondRow.Size = new System.Drawing.Size( 1147, 115 );
                this.SecondRow.TabIndex = 1;

                // 
                // TextBox9
                // 
                this.TextBox9.AlphaNumeric = false;

                this.TextBox9.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox9.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox9.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox9.BindingSource = null;

                this.TextBox9.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox9.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox9.Border.HoverVisible = true;
                this.TextBox9.Border.Rounding = 6;
                this.TextBox9.Border.Thickness = 1;
                this.TextBox9.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox9.Border.Visible = true;

                this.TextBox9.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox9.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox9.ButtonBorder.HoverVisible = true;
                this.TextBox9.ButtonBorder.Rounding = 6;
                this.TextBox9.ButtonBorder.Thickness = 1;
                this.TextBox9.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox9.ButtonBorder.Visible = true;

                this.TextBox9.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox9.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox9.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox9.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox9.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox9.ButtonIndent = 3;
                this.TextBox9.ButtonText = "visualButton";
                this.TextBox9.ButtonVisible = false;
                this.TextBox9.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox9.Field = Field.NS;
                this.TextBox9.DataFilter = null;
                this.TextBox9.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox9.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox9.Image = null;
                this.TextBox9.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox9.ImageVisible = false;
                this.TextBox9.ImageWidth = 35;
                this.TextBox9.Location = new System.Drawing.Point( 396, 73 );
                this.TextBox9.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox9.Name = "TextBox9";
                this.TextBox9.Numeric = Numeric.NS;
                this.TextBox9.PasswordChar = '\0';
                this.TextBox9.ReadOnly = false;
                this.TextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox9.Size = new System.Drawing.Size( 196, 23 );
                this.TextBox9.TabIndex = 18;
                this.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox9.TextBoxWidth = 186;

                this.TextBox9.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox9.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox9.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox9.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox9.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox9.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox9.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox9.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox9.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox9.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox9.Watermark.Text = "Watermark text";
                this.TextBox9.Watermark.Visible = false;
                this.TextBox9.WordWrap = true;

                // 
                // TextBox8
                // 
                this.TextBox8.AlphaNumeric = false;

                this.TextBox8.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox8.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox8.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox8.BindingSource = null;

                this.TextBox8.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox8.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox8.Border.HoverVisible = true;
                this.TextBox8.Border.Rounding = 6;
                this.TextBox8.Border.Thickness = 1;
                this.TextBox8.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox8.Border.Visible = true;

                this.TextBox8.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox8.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox8.ButtonBorder.HoverVisible = true;
                this.TextBox8.ButtonBorder.Rounding = 6;
                this.TextBox8.ButtonBorder.Thickness = 1;
                this.TextBox8.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox8.ButtonBorder.Visible = true;

                this.TextBox8.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox8.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox8.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox8.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox8.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox8.ButtonIndent = 3;
                this.TextBox8.ButtonText = "visualButton";
                this.TextBox8.ButtonVisible = false;
                this.TextBox8.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox8.Field = Field.NS;
                this.TextBox8.DataFilter = null;
                this.TextBox8.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox8.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox8.Image = null;
                this.TextBox8.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox8.ImageVisible = false;
                this.TextBox8.ImageWidth = 35;
                this.TextBox8.Location = new System.Drawing.Point( 191, 73 );
                this.TextBox8.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox8.Name = "TextBox8";
                this.TextBox8.Numeric = Numeric.NS;
                this.TextBox8.PasswordChar = '\0';
                this.TextBox8.ReadOnly = false;
                this.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox8.Size = new System.Drawing.Size( 199, 23 );
                this.TextBox8.TabIndex = 17;
                this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox8.TextBoxWidth = 189;

                this.TextBox8.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox8.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox8.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox8.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox8.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox8.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox8.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox8.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox8.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox8.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox8.Watermark.Text = "Watermark text";
                this.TextBox8.Watermark.Visible = false;
                this.TextBox8.WordWrap = true;

                // 
                // TextBox7
                // 
                this.TextBox7.AlphaNumeric = false;

                this.TextBox7.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox7.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox7.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox7.BindingSource = null;

                this.TextBox7.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox7.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox7.Border.HoverVisible = true;
                this.TextBox7.Border.Rounding = 6;
                this.TextBox7.Border.Thickness = 1;
                this.TextBox7.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox7.Border.Visible = true;

                this.TextBox7.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox7.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox7.ButtonBorder.HoverVisible = true;
                this.TextBox7.ButtonBorder.Rounding = 6;
                this.TextBox7.ButtonBorder.Thickness = 1;
                this.TextBox7.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox7.ButtonBorder.Visible = true;

                this.TextBox7.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox7.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox7.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox7.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox7.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox7.ButtonIndent = 3;
                this.TextBox7.ButtonText = "visualButton";
                this.TextBox7.ButtonVisible = false;
                this.TextBox7.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox7.Field = Field.NS;
                this.TextBox7.DataFilter = null;
                this.TextBox7.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox7.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox7.Image = null;
                this.TextBox7.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox7.ImageVisible = false;
                this.TextBox7.ImageWidth = 35;
                this.TextBox7.Location = new System.Drawing.Point( 3, 73 );
                this.TextBox7.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox7.Name = "TextBox7";
                this.TextBox7.Numeric = Numeric.NS;
                this.TextBox7.PasswordChar = '\0';
                this.TextBox7.ReadOnly = false;
                this.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox7.Size = new System.Drawing.Size( 182, 23 );
                this.TextBox7.TabIndex = 16;
                this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox7.TextBoxWidth = 172;

                this.TextBox7.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox7.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox7.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox7.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox7.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox7.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox7.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;


                this.TextBox7.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox7.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox7.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox7.Watermark.Text = "Watermark text";
                this.TextBox7.Watermark.Visible = false;
                this.TextBox7.WordWrap = true;

                // 
                // TextBox12
                // 
                this.TextBox12.AlphaNumeric = false;

                this.TextBox12.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox12.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox12.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox12.BindingSource = null;

                this.TextBox12.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox12.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox12.Border.HoverVisible = true;
                this.TextBox12.Border.Rounding = 6;
                this.TextBox12.Border.Thickness = 1;
                this.TextBox12.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox12.Border.Visible = true;

                this.TextBox12.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox12.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox12.ButtonBorder.HoverVisible = true;
                this.TextBox12.ButtonBorder.Rounding = 6;
                this.TextBox12.ButtonBorder.Thickness = 1;
                this.TextBox12.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox12.ButtonBorder.Visible = true;

                this.TextBox12.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox12.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox12.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox12.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox12.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox12.ButtonIndent = 3;
                this.TextBox12.ButtonText = "visualButton";
                this.TextBox12.ButtonVisible = false;
                this.TextBox12.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox12.Field = Field.NS;
                this.TextBox12.DataFilter = null;
                this.TextBox12.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox12.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox12.Image = null;
                this.TextBox12.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox12.ImageVisible = false;
                this.TextBox12.ImageWidth = 35;
                this.TextBox12.Location = new System.Drawing.Point( 963, 73 );
                this.TextBox12.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox12.Name = "TextBox12";
                this.TextBox12.Numeric = Numeric.NS;
                this.TextBox12.PasswordChar = '\0';
                this.TextBox12.ReadOnly = false;
                this.TextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox12.Size = new System.Drawing.Size( 181, 23 );
                this.TextBox12.TabIndex = 15;
                this.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox12.TextBoxWidth = 171;

                this.TextBox12.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox12.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox12.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox12.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox12.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox12.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox12.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox12.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox12.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox12.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox12.Watermark.Text = "Watermark text";
                this.TextBox12.Watermark.Visible = false;
                this.TextBox12.WordWrap = true;

                // 
                // TextBox11
                // 
                this.TextBox11.AlphaNumeric = false;

                this.TextBox11.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox11.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox11.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox11.BindingSource = null;

                this.TextBox11.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox11.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox11.Border.HoverVisible = true;
                this.TextBox11.Border.Rounding = 6;
                this.TextBox11.Border.Thickness = 1;
                this.TextBox11.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox11.Border.Visible = true;

                this.TextBox11.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox11.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox11.ButtonBorder.HoverVisible = true;
                this.TextBox11.ButtonBorder.Rounding = 6;
                this.TextBox11.ButtonBorder.Thickness = 1;
                this.TextBox11.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox11.ButtonBorder.Visible = true;

                this.TextBox11.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox11.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox11.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox11.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox11.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox11.ButtonIndent = 3;
                this.TextBox11.ButtonText = "visualButton";
                this.TextBox11.ButtonVisible = false;
                this.TextBox11.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox11.Field = Field.NS;
                this.TextBox11.DataFilter = null;
                this.TextBox11.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox11.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox11.Image = null;
                this.TextBox11.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox11.ImageVisible = false;
                this.TextBox11.ImageWidth = 35;
                this.TextBox11.Location = new System.Drawing.Point( 780, 73 );
                this.TextBox11.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox11.Name = "TextBox11";
                this.TextBox11.Numeric = Numeric.NS;
                this.TextBox11.PasswordChar = '\0';
                this.TextBox11.ReadOnly = false;
                this.TextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox11.Size = new System.Drawing.Size( 177, 23 );
                this.TextBox11.TabIndex = 14;
                this.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox11.TextBoxWidth = 167;

                this.TextBox11.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox11.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox11.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox11.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox11.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox11.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox11.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox11.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox11.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox11.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox11.Watermark.Text = "Watermark text";
                this.TextBox11.Watermark.Visible = false;
                this.TextBox11.WordWrap = true;

                // 
                // TextBox10
                // 
                this.TextBox10.AlphaNumeric = false;

                this.TextBox10.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox10.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox10.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox10.BindingSource = null;

                this.TextBox10.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox10.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox10.Border.HoverVisible = true;
                this.TextBox10.Border.Rounding = 6;
                this.TextBox10.Border.Thickness = 1;
                this.TextBox10.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox10.Border.Visible = true;

                this.TextBox10.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox10.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox10.ButtonBorder.HoverVisible = true;
                this.TextBox10.ButtonBorder.Rounding = 6;
                this.TextBox10.ButtonBorder.Thickness = 1;
                this.TextBox10.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox10.ButtonBorder.Visible = true;

                this.TextBox10.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox10.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox10.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox10.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox10.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox10.ButtonIndent = 3;
                this.TextBox10.ButtonText = "visualButton";
                this.TextBox10.ButtonVisible = false;
                this.TextBox10.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox10.Field = Field.NS;
                this.TextBox10.DataFilter = null;
                this.TextBox10.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox10.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox10.Image = null;
                this.TextBox10.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox10.ImageVisible = false;
                this.TextBox10.ImageWidth = 35;
                this.TextBox10.Location = new System.Drawing.Point( 598, 73 );
                this.TextBox10.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox10.Name = "TextBox10";
                this.TextBox10.Numeric = Numeric.NS;
                this.TextBox10.PasswordChar = '\0';
                this.TextBox10.ReadOnly = false;
                this.TextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox10.Size = new System.Drawing.Size( 176, 23 );
                this.TextBox10.TabIndex = 13;
                this.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox10.TextBoxWidth = 166;

                this.TextBox10.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox10.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox10.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox10.TextStyle.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox10.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox10.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox10.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox10.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox10.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox10.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox10.Watermark.Text = "Watermark text";
                this.TextBox10.Watermark.Visible = false;
                this.TextBox10.WordWrap = true;

                // 
                // Label7
                // 
                this.Label7.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label7.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label7.Field = Field.NS;
                this.Label7.DataFilter = null;
                this.Label7.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label7.ForeColor = System.Drawing.Color.LightGray;
                this.Label7.Location = new System.Drawing.Point( 3, 3 );
                this.Label7.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label7.Name = "Label7";
                this.Label7.Numeric = Numeric.NS;
                this.Label7.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label7.Outline = false;

                this.Label7.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label7.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label7.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label7.ReflectionSpacing = 0;
                this.Label7.ShadowColor = System.Drawing.Color.Black;
                this.Label7.ShadowDirection = 315;
                this.Label7.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label7.ShadowOpacity = 100;
                this.Label7.Size = new System.Drawing.Size( 182, 21 );
                this.Label7.TabIndex = 1;
                this.Label7.Text = "Label-7";
                this.Label7.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label7.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label7.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label7.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label7.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label7.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label7.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label7.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label7.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;


                // 
                // Label8
                // 
                this.Label8.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label8.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label8.Field = Field.NS;
                this.Label8.DataFilter = null;
                this.Label8.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label8.ForeColor = System.Drawing.Color.LightGray;
                this.Label8.Location = new System.Drawing.Point( 191, 3 );
                this.Label8.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label8.Name = "Label8";
                this.Label8.Numeric = Numeric.NS;
                this.Label8.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label8.Outline = false;

                this.Label8.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label8.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label8.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label8.ReflectionSpacing = 0;
                this.Label8.ShadowColor = System.Drawing.Color.Black;
                this.Label8.ShadowDirection = 315;
                this.Label8.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label8.ShadowOpacity = 100;
                this.Label8.Size = new System.Drawing.Size( 199, 21 );
                this.Label8.TabIndex = 2;
                this.Label8.Text = "Label-8";
                this.Label8.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label8.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label8.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label8.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label8.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label8.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label8.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label8.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label8.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Label9
                // 
                this.Label9.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label9.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label9.Field = Field.NS;
                this.Label9.DataFilter = null;
                this.Label9.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label9.ForeColor = System.Drawing.Color.LightGray;
                this.Label9.Location = new System.Drawing.Point( 396, 3 );
                this.Label9.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label9.Name = "Label9";
                this.Label9.Numeric = Numeric.NS;
                this.Label9.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label9.Outline = false;

                this.Label9.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label9.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label9.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label9.ReflectionSpacing = 0;
                this.Label9.ShadowColor = System.Drawing.Color.Black;
                this.Label9.ShadowDirection = 315;
                this.Label9.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label9.ShadowOpacity = 100;
                this.Label9.Size = new System.Drawing.Size( 196, 21 );
                this.Label9.TabIndex = 3;
                this.Label9.Text = "Label-9";
                this.Label9.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label9.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label9.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label9.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label9.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label9.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label9.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label9.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label9.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                // 
                // Label10
                // 
                this.Label10.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label10.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label10.Field = Field.NS;
                this.Label10.DataFilter = null;
                this.Label10.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label10.ForeColor = System.Drawing.Color.LightGray;
                this.Label10.Location = new System.Drawing.Point( 598, 3 );
                this.Label10.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label10.Name = "Label10";
                this.Label10.Numeric = Numeric.NS;
                this.Label10.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label10.Outline = false;

                this.Label10.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label10.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label10.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label10.ReflectionSpacing = 0;
                this.Label10.ShadowColor = System.Drawing.Color.Black;
                this.Label10.ShadowDirection = 315;
                this.Label10.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label10.ShadowOpacity = 100;
                this.Label10.Size = new System.Drawing.Size( 176, 21 );
                this.Label10.TabIndex = 4;
                this.Label10.Text = "Label-10";
                this.Label10.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label10.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label10.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label10.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label10.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label10.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label10.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label10.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label10.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Label11
                // 
                this.Label11.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label11.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label11.Field = Field.NS;
                this.Label11.DataFilter = null;
                this.Label11.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label11.ForeColor = System.Drawing.Color.LightGray;
                this.Label11.Location = new System.Drawing.Point( 780, 3 );
                this.Label11.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label11.Name = "Label11";
                this.Label11.Numeric = Numeric.NS;
                this.Label11.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label11.Outline = false;

                this.Label11.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label11.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label11.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label11.ReflectionSpacing = 0;
                this.Label11.ShadowColor = System.Drawing.Color.Black;
                this.Label11.ShadowDirection = 315;
                this.Label11.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label11.ShadowOpacity = 100;
                this.Label11.Size = new System.Drawing.Size( 177, 21 );
                this.Label11.TabIndex = 5;
                this.Label11.Text = "Label-11";
                this.Label11.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label11.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label11.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label11.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label11.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label11.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label11.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label11.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label11.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Label12
                // 
                this.Label12.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label12.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label12.Field = Field.NS;
                this.Label12.DataFilter = null;
                this.Label12.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label12.ForeColor = System.Drawing.Color.LightGray;
                this.Label12.Location = new System.Drawing.Point( 963, 3 );
                this.Label12.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label12.Name = "Label12";
                this.Label12.Numeric = Numeric.NS;
                this.Label12.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label12.Outline = false;

                this.Label12.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label12.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label12.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label12.ReflectionSpacing = 0;
                this.Label12.ShadowColor = System.Drawing.Color.Black;
                this.Label12.ShadowDirection = 315;
                this.Label12.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label12.ShadowOpacity = 100;
                this.Label12.Size = new System.Drawing.Size( 181, 21 );
                this.Label12.TabIndex = 6;
                this.Label12.Text = "Label-12";
                this.Label12.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label12.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label12.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label12.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label12.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label12.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label12.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label12.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label12.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // ComboBox7
                // 
                this.ComboBox7.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox7.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox7.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox7.BindingSource = this.BindingSource;

                this.ComboBox7.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox7.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.ComboBox7.Border.HoverVisible = true;
                this.ComboBox7.Border.Rounding = 1;
                this.ComboBox7.Border.Thickness = 1;
                this.ComboBox7.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox7.Border.Visible = true;
                this.ComboBox7.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox7.ButtonImage = null;

                this.ComboBox7.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox7.ButtonWidth = 22;
                this.ComboBox7.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox7.DropDownHeight = 100;
                this.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox7.DropDownWidth = 200;
                this.ComboBox7.Field = Field.NS;
                this.ComboBox7.DataFilter = null;
                this.ComboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox7.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox7.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox7.FormattingEnabled = true;
                this.ComboBox7.HoverText = null;
                this.ComboBox7.ImageList = null;
                this.ComboBox7.ImageVisible = false;
                this.ComboBox7.Index = 0;
                this.ComboBox7.IntegralHeight = false;
                this.ComboBox7.ItemHeight = 24;
                this.ComboBox7.ItemImageVisible = true;
                this.ComboBox7.Location = new System.Drawing.Point( 3, 30 );
                this.ComboBox7.MaxDropDownItems = 100;

                this.ComboBox7.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox7.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox7.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox7.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox7.Name = "ComboBox7";

                this.ComboBox7.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox7.SeparatorVisible = false;
                this.ComboBox7.Size = new System.Drawing.Size( 182, 30 );
                this.ComboBox7.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox7.TabIndex = 7;
                this.ComboBox7.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox7.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox7.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox7.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox7.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox7.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox7.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox7.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox7.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox7.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox7.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox7.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox7.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox7.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox7.Watermark.Text = "Watermark text";
                this.ComboBox7.Watermark.Visible = false;

                // 
                // ComboBox8
                // 
                this.ComboBox8.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox8.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox8.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox8.BindingSource = this.BindingSource;

                this.ComboBox8.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox8.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox8.Border.HoverVisible = true;
                this.ComboBox8.Border.Rounding = 1;
                this.ComboBox8.Border.Thickness = 1;
                this.ComboBox8.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox8.Border.Visible = true;
                this.ComboBox8.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox8.ButtonImage = null;

                this.ComboBox8.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox8.ButtonWidth = 22;
                this.ComboBox8.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox8.DropDownHeight = 100;
                this.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox8.DropDownWidth = 200;
                this.ComboBox8.Field = Field.NS;
                this.ComboBox8.DataFilter = null;
                this.ComboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox8.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox8.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox8.FormattingEnabled = true;
                this.ComboBox8.HoverText = null;
                this.ComboBox8.ImageList = null;
                this.ComboBox8.ImageVisible = false;
                this.ComboBox8.Index = 0;
                this.ComboBox8.IntegralHeight = false;
                this.ComboBox8.ItemHeight = 24;
                this.ComboBox8.ItemImageVisible = true;
                this.ComboBox8.Location = new System.Drawing.Point( 191, 30 );
                this.ComboBox8.MaxDropDownItems = 100;

                this.ComboBox8.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox8.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox8.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox8.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox8.Name = "ComboBox8";

                this.ComboBox8.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox8.SeparatorVisible = false;
                this.ComboBox8.Size = new System.Drawing.Size( 199, 30 );
                this.ComboBox8.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox8.TabIndex = 8;
                this.ComboBox8.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox8.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox8.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox8.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox8.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox8.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox8.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox8.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox8.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox8.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox8.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox8.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox8.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox8.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox8.Watermark.Text = "Watermark text";
                this.ComboBox8.Watermark.Visible = false;

                // 
                // ComboBox9
                // 
                this.ComboBox9.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox9.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox9.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox9.BindingSource = this.BindingSource;

                this.ComboBox9.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox9.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox9.Border.HoverVisible = true;
                this.ComboBox9.Border.Rounding = 1;
                this.ComboBox9.Border.Thickness = 1;
                this.ComboBox9.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox9.Border.Visible = true;
                this.ComboBox9.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox9.ButtonImage = null;

                this.ComboBox9.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox9.ButtonWidth = 22;
                this.ComboBox9.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox9.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox9.DropDownHeight = 100;
                this.ComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox9.DropDownWidth = 200;
                this.ComboBox9.Field = Field.NS;
                this.ComboBox9.DataFilter = null;
                this.ComboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox9.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox9.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox9.FormattingEnabled = true;
                this.ComboBox9.HoverText = null;
                this.ComboBox9.ImageList = null;
                this.ComboBox9.ImageVisible = false;
                this.ComboBox9.Index = 0;
                this.ComboBox9.IntegralHeight = false;
                this.ComboBox9.ItemHeight = 24;
                this.ComboBox9.ItemImageVisible = true;
                this.ComboBox9.Location = new System.Drawing.Point( 396, 30 );
                this.ComboBox9.MaxDropDownItems = 100;

                this.ComboBox9.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox9.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox9.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox9.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox9.Name = "ComboBox9";

                this.ComboBox9.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox9.SeparatorVisible = false;
                this.ComboBox9.Size = new System.Drawing.Size( 196, 30 );
                this.ComboBox9.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox9.TabIndex = 9;
                this.ComboBox9.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox9.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox9.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox9.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox9.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox9.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox9.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox9.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox9.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox9.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox9.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox9.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox9.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox9.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox9.Watermark.Text = "Watermark text";
                this.ComboBox9.Watermark.Visible = false;

                // 
                // ComboBox10
                // 
                this.ComboBox10.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox10.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox10.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox10.BindingSource = this.BindingSource;

                this.ComboBox10.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox10.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox10.Border.HoverVisible = true;
                this.ComboBox10.Border.Rounding = 1;
                this.ComboBox10.Border.Thickness = 1;
                this.ComboBox10.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox10.Border.Visible = true;
                this.ComboBox10.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox10.ButtonImage = null;

                this.ComboBox10.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox10.ButtonWidth = 22;
                this.ComboBox10.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox10.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox10.DropDownHeight = 100;
                this.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox10.DropDownWidth = 200;
                this.ComboBox10.Field = Field.NS;
                this.ComboBox10.DataFilter = null;
                this.ComboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox10.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox10.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox10.FormattingEnabled = true;
                this.ComboBox10.HoverText = null;
                this.ComboBox10.ImageList = null;
                this.ComboBox10.ImageVisible = false;
                this.ComboBox10.Index = 0;
                this.ComboBox10.IntegralHeight = false;
                this.ComboBox10.ItemHeight = 24;
                this.ComboBox10.ItemImageVisible = true;
                this.ComboBox10.Location = new System.Drawing.Point( 598, 30 );
                this.ComboBox10.MaxDropDownItems = 100;

                this.ComboBox10.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox10.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox10.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox10.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox10.Name = "ComboBox10";

                this.ComboBox10.SeparatorColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox10.SeparatorVisible = false;
                this.ComboBox10.Size = new System.Drawing.Size( 176, 30 );
                this.ComboBox10.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox10.TabIndex = 10;
                this.ComboBox10.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox10.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox10.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox10.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox10.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox10.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox10.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox10.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox10.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox10.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox10.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox10.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox10.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox10.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox10.Watermark.Text = "Watermark text";
                this.ComboBox10.Watermark.Visible = false;

                // 
                // ComboBox11
                // 
                this.ComboBox11.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox11.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox11.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox11.BindingSource = this.BindingSource;

                this.ComboBox11.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox11.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox11.Border.HoverVisible = true;
                this.ComboBox11.Border.Rounding = 1;
                this.ComboBox11.Border.Thickness = 1;
                this.ComboBox11.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox11.Border.Visible = true;
                this.ComboBox11.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox11.ButtonImage = null;

                this.ComboBox11.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox11.ButtonWidth = 22;
                this.ComboBox11.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox11.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox11.DropDownHeight = 100;
                this.ComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox11.DropDownWidth = 200;
                this.ComboBox11.Field = Field.NS;
                this.ComboBox11.DataFilter = null;
                this.ComboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox11.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox11.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox11.FormattingEnabled = true;
                this.ComboBox11.HoverText = null;
                this.ComboBox11.ImageList = null;
                this.ComboBox11.ImageVisible = false;
                this.ComboBox11.Index = 0;
                this.ComboBox11.IntegralHeight = false;
                this.ComboBox11.ItemHeight = 24;
                this.ComboBox11.ItemImageVisible = true;
                this.ComboBox11.Location = new System.Drawing.Point( 780, 30 );
                this.ComboBox11.MaxDropDownItems = 100;

                this.ComboBox11.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox11.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox11.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox11.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox11.Name = "ComboBox11";

                this.ComboBox11.SeparatorColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox11.SeparatorVisible = false;
                this.ComboBox11.Size = new System.Drawing.Size( 177, 30 );
                this.ComboBox11.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox11.TabIndex = 11;
                this.ComboBox11.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox11.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox11.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox11.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox11.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox11.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox11.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox11.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox11.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox11.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox11.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox11.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox11.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox11.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox11.Watermark.Text = "Watermark text";
                this.ComboBox11.Watermark.Visible = false;

                // 
                // ComboBox12
                // 
                this.ComboBox12.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox12.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox12.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox12.BindingSource = this.BindingSource;

                this.ComboBox12.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox12.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox12.Border.HoverVisible = true;
                this.ComboBox12.Border.Rounding = 1;
                this.ComboBox12.Border.Thickness = 1;
                this.ComboBox12.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox12.Border.Visible = true;
                this.ComboBox12.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox12.ButtonImage = null;

                this.ComboBox12.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox12.ButtonWidth = 22;
                this.ComboBox12.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox12.DropDownHeight = 100;
                this.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox12.DropDownWidth = 200;
                this.ComboBox12.Field = Field.NS;
                this.ComboBox12.DataFilter = null;
                this.ComboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox12.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox12.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox12.FormattingEnabled = true;
                this.ComboBox12.HoverText = null;
                this.ComboBox12.ImageList = null;
                this.ComboBox12.ImageVisible = false;
                this.ComboBox12.Index = 0;
                this.ComboBox12.IntegralHeight = false;
                this.ComboBox12.ItemHeight = 24;
                this.ComboBox12.ItemImageVisible = true;
                this.ComboBox12.Location = new System.Drawing.Point( 963, 30 );
                this.ComboBox12.MaxDropDownItems = 100;

                this.ComboBox12.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox12.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox12.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox12.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox12.Name = "ComboBox12";

                this.ComboBox12.SeparatorColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox12.SeparatorVisible = false;
                this.ComboBox12.Size = new System.Drawing.Size( 181, 30 );
                this.ComboBox12.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox12.TabIndex = 12;
                this.ComboBox12.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox12.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox12.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox12.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox12.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox12.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox12.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox12.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox12.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox12.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox12.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox12.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox12.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox12.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox12.Watermark.Text = "Watermark text";
                this.ComboBox12.Watermark.Visible = false;

                // 
                // FirtsRow
                // 
                this.FirtsRow.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.FirtsRow.ColumnCount = 6;

                this.FirtsRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent,
                        47.60563F ) );

                this.FirtsRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent,
                        52.39437F ) );

                this.FirtsRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 201F ) );

                this.FirtsRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 183F ) );

                this.FirtsRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 183F ) );

                this.FirtsRow.ColumnStyles.Add(
                    new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 186F ) );

                this.FirtsRow.Controls.Add( this.TextBox6, 5, 2 );
                this.FirtsRow.Controls.Add( this.TextBox5, 4, 2 );
                this.FirtsRow.Controls.Add( this.TextBox4, 3, 2 );
                this.FirtsRow.Controls.Add( this.TextBox3, 2, 2 );
                this.FirtsRow.Controls.Add( this.TextBox2, 1, 2 );
                this.FirtsRow.Controls.Add( this.ComboBox6, 5, 1 );
                this.FirtsRow.Controls.Add( this.ComboBox5, 4, 1 );
                this.FirtsRow.Controls.Add( this.ComboBox4, 3, 1 );
                this.FirtsRow.Controls.Add( this.ComboBox3, 2, 1 );
                this.FirtsRow.Controls.Add( this.ComboBox2, 1, 1 );
                this.FirtsRow.Controls.Add( this.Label6, 5, 0 );
                this.FirtsRow.Controls.Add( this.Label5, 4, 0 );
                this.FirtsRow.Controls.Add( this.Label4, 3, 0 );
                this.FirtsRow.Controls.Add( this.Label3, 2, 0 );
                this.FirtsRow.Controls.Add( this.Label2, 1, 0 );
                this.FirtsRow.Controls.Add( this.Label1, 0, 0 );
                this.FirtsRow.Controls.Add( this.ComboBox1, 0, 1 );
                this.FirtsRow.Controls.Add( this.TextBox1, 0, 2 );
                this.FirtsRow.Dock = System.Windows.Forms.DockStyle.Top;
                this.FirtsRow.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
                this.FirtsRow.Location = new System.Drawing.Point( 0, 0 );
                this.FirtsRow.Name = "FirtsRow";
                this.FirtsRow.RowCount = 3;

                this.FirtsRow.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );

                this.FirtsRow.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );

                this.FirtsRow.RowStyles.Add(
                    new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 45F ) );

                this.FirtsRow.Size = new System.Drawing.Size( 1147, 128 );
                this.FirtsRow.TabIndex = 0;

                // 
                // TextBox6
                // 
                this.TextBox6.AlphaNumeric = false;

                this.TextBox6.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox6.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox6.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox6.BindingSource = null;

                this.TextBox6.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox6.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox6.Border.HoverVisible = true;
                this.TextBox6.Border.Rounding = 6;
                this.TextBox6.Border.Thickness = 1;
                this.TextBox6.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox6.Border.Visible = true;

                this.TextBox6.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox6.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox6.ButtonBorder.HoverVisible = true;
                this.TextBox6.ButtonBorder.Rounding = 6;
                this.TextBox6.ButtonBorder.Thickness = 1;
                this.TextBox6.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox6.ButtonBorder.Visible = true;

                this.TextBox6.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox6.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox6.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox6.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox6.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox6.ButtonIndent = 3;
                this.TextBox6.ButtonText = "visualButton";
                this.TextBox6.ButtonVisible = false;
                this.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox6.Field = Field.NS;
                this.TextBox6.DataFilter = null;
                this.TextBox6.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox6.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox6.Image = null;
                this.TextBox6.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox6.ImageVisible = false;
                this.TextBox6.ImageWidth = 35;
                this.TextBox6.Location = new System.Drawing.Point( 963, 85 );
                this.TextBox6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox6.Name = "TextBox6";
                this.TextBox6.Numeric = Numeric.NS;
                this.TextBox6.PasswordChar = '\0';
                this.TextBox6.ReadOnly = false;
                this.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox6.Size = new System.Drawing.Size( 181, 23 );
                this.TextBox6.TabIndex = 17;
                this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox6.TextBoxWidth = 171;

                this.TextBox6.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox6.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox6.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox6.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox6.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox6.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox6.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox6.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox6.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox6.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox6.Watermark.Text = "Watermark text";
                this.TextBox6.Watermark.Visible = false;
                this.TextBox6.WordWrap = true;

                // 
                // TextBox5
                // 
                this.TextBox5.AlphaNumeric = false;

                this.TextBox5.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox5.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox5.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox5.BindingSource = null;

                this.TextBox5.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox5.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox5.Border.HoverVisible = true;
                this.TextBox5.Border.Rounding = 6;
                this.TextBox5.Border.Thickness = 1;
                this.TextBox5.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox5.Border.Visible = true;

                this.TextBox5.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox5.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox5.ButtonBorder.HoverVisible = true;
                this.TextBox5.ButtonBorder.Rounding = 6;
                this.TextBox5.ButtonBorder.Thickness = 1;
                this.TextBox5.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox5.ButtonBorder.Visible = true;

                this.TextBox5.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox5.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox5.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox5.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox5.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox5.ButtonIndent = 3;
                this.TextBox5.ButtonText = "visualButton";
                this.TextBox5.ButtonVisible = false;
                this.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox5.Field = Field.NS;
                this.TextBox5.DataFilter = null;
                this.TextBox5.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox5.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox5.Image = null;
                this.TextBox5.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox5.ImageVisible = false;
                this.TextBox5.ImageWidth = 35;
                this.TextBox5.Location = new System.Drawing.Point( 780, 85 );
                this.TextBox5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox5.Name = "TextBox5";
                this.TextBox5.Numeric = Numeric.NS;
                this.TextBox5.PasswordChar = '\0';
                this.TextBox5.ReadOnly = false;
                this.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox5.Size = new System.Drawing.Size( 177, 23 );
                this.TextBox5.TabIndex = 16;
                this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox5.TextBoxWidth = 167;

                this.TextBox5.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox5.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox5.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox5.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox5.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox5.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox5.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox5.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox5.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox5.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox5.Watermark.Text = "Watermark text";
                this.TextBox5.Watermark.Visible = false;
                this.TextBox5.WordWrap = true;

                // 
                // TextBox4
                // 
                this.TextBox4.AlphaNumeric = false;

                this.TextBox4.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox4.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox4.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox4.BindingSource = null;

                this.TextBox4.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox4.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox4.Border.HoverVisible = true;
                this.TextBox4.Border.Rounding = 6;
                this.TextBox4.Border.Thickness = 1;
                this.TextBox4.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox4.Border.Visible = true;

                this.TextBox4.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox4.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox4.ButtonBorder.HoverVisible = true;
                this.TextBox4.ButtonBorder.Rounding = 6;
                this.TextBox4.ButtonBorder.Thickness = 1;
                this.TextBox4.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox4.ButtonBorder.Visible = true;

                this.TextBox4.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox4.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox4.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox4.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox4.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox4.ButtonIndent = 3;
                this.TextBox4.ButtonText = "visualButton";
                this.TextBox4.ButtonVisible = false;
                this.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox4.Field = Field.NS;
                this.TextBox4.DataFilter = null;
                this.TextBox4.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox4.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox4.Image = null;
                this.TextBox4.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox4.ImageVisible = false;
                this.TextBox4.ImageWidth = 35;
                this.TextBox4.Location = new System.Drawing.Point( 597, 85 );
                this.TextBox4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox4.Name = "TextBox4";
                this.TextBox4.Numeric = Numeric.NS;
                this.TextBox4.PasswordChar = '\0';
                this.TextBox4.ReadOnly = false;
                this.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox4.Size = new System.Drawing.Size( 177, 23 );
                this.TextBox4.TabIndex = 15;
                this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox4.TextBoxWidth = 167;

                this.TextBox4.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox4.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox4.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox4.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox4.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox4.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox4.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox4.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox4.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox4.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox4.Watermark.Text = "Watermark text";
                this.TextBox4.Watermark.Visible = false;
                this.TextBox4.WordWrap = true;

                // 
                // TextBox3
                // 
                this.TextBox3.AlphaNumeric = false;

                this.TextBox3.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox3.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox3.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox3.BindingSource = null;

                this.TextBox3.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox3.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox3.Border.HoverVisible = true;
                this.TextBox3.Border.Rounding = 6;
                this.TextBox3.Border.Thickness = 1;
                this.TextBox3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox3.Border.Visible = true;

                this.TextBox3.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox3.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox3.ButtonBorder.HoverVisible = true;
                this.TextBox3.ButtonBorder.Rounding = 6;
                this.TextBox3.ButtonBorder.Thickness = 1;
                this.TextBox3.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox3.ButtonBorder.Visible = true;

                this.TextBox3.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox3.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox3.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox3.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox3.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox3.ButtonIndent = 3;
                this.TextBox3.ButtonText = "visualButton";
                this.TextBox3.ButtonVisible = false;
                this.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox3.Field = Field.NS;
                this.TextBox3.DataFilter = null;
                this.TextBox3.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox3.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox3.Image = null;
                this.TextBox3.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox3.ImageVisible = false;
                this.TextBox3.ImageWidth = 35;
                this.TextBox3.Location = new System.Drawing.Point( 396, 85 );
                this.TextBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox3.Name = "TextBox3";
                this.TextBox3.Numeric = Numeric.NS;
                this.TextBox3.PasswordChar = '\0';
                this.TextBox3.ReadOnly = false;
                this.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox3.Size = new System.Drawing.Size( 195, 23 );
                this.TextBox3.TabIndex = 14;
                this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox3.TextBoxWidth = 185;

                this.TextBox3.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox3.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox3.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox3.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox3.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox3.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox3.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox3.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox3.Watermark.Text = "Watermark text";
                this.TextBox3.Watermark.Visible = false;
                this.TextBox3.WordWrap = true;

                // 
                // TextBox2
                // 
                this.TextBox2.AlphaNumeric = false;

                this.TextBox2.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox2.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox2.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox2.BindingSource = null;

                this.TextBox2.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox2.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox2.Border.HoverVisible = true;
                this.TextBox2.Border.Rounding = 6;
                this.TextBox2.Border.Thickness = 1;
                this.TextBox2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox2.Border.Visible = true;

                this.TextBox2.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox2.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox2.ButtonBorder.HoverVisible = true;
                this.TextBox2.ButtonBorder.Rounding = 6;
                this.TextBox2.ButtonBorder.Thickness = 1;
                this.TextBox2.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox2.ButtonBorder.Visible = true;

                this.TextBox2.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox2.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox2.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox2.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox2.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox2.ButtonIndent = 3;
                this.TextBox2.ButtonText = "visualButton";
                this.TextBox2.ButtonVisible = false;
                this.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox2.Field = Field.NS;
                this.TextBox2.DataFilter = null;
                this.TextBox2.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox2.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox2.Image = null;
                this.TextBox2.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox2.ImageVisible = false;
                this.TextBox2.ImageWidth = 35;
                this.TextBox2.Location = new System.Drawing.Point( 190, 85 );
                this.TextBox2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox2.Name = "TextBox2";
                this.TextBox2.Numeric = Numeric.NS;
                this.TextBox2.PasswordChar = '\0';
                this.TextBox2.ReadOnly = false;
                this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox2.Size = new System.Drawing.Size( 200, 23 );
                this.TextBox2.TabIndex = 13;
                this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox2.TextBoxWidth = 190;

                this.TextBox2.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox2.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox2.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox2.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox2.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox2.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox2.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox2.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox2.Watermark.Text = "Watermark text";
                this.TextBox2.Watermark.Visible = false;
                this.TextBox2.WordWrap = true;

                // 
                // ComboBox6
                // 
                this.ComboBox6.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox6.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox6.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox6.BindingSource = this.BindingSource;

                this.ComboBox6.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox6.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox6.Border.HoverVisible = true;
                this.ComboBox6.Border.Rounding = 1;
                this.ComboBox6.Border.Thickness = 1;
                this.ComboBox6.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox6.Border.Visible = true;
                this.ComboBox6.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox6.ButtonImage = null;

                this.ComboBox6.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox6.ButtonWidth = 22;
                this.ComboBox6.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox6.DropDownHeight = 100;
                this.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox6.DropDownWidth = 200;
                this.ComboBox6.Field = Field.NS;
                this.ComboBox6.DataFilter = null;
                this.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox6.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox6.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox6.FormattingEnabled = true;
                this.ComboBox6.HoverText = null;
                this.ComboBox6.ImageList = null;
                this.ComboBox6.ImageVisible = false;
                this.ComboBox6.Index = 0;
                this.ComboBox6.IntegralHeight = false;
                this.ComboBox6.ItemHeight = 24;
                this.ComboBox6.ItemImageVisible = true;
                this.ComboBox6.Location = new System.Drawing.Point( 963, 44 );
                this.ComboBox6.MaxDropDownItems = 100;

                this.ComboBox6.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox6.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox6.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox6.Name = "ComboBox6";

                this.ComboBox6.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox6.SeparatorVisible = false;
                this.ComboBox6.Size = new System.Drawing.Size( 181, 30 );
                this.ComboBox6.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox6.TabIndex = 11;
                this.ComboBox6.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox6.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox6.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox6.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox6.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox6.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox6.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox6.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox6.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox6.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox6.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox6.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox6.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox6.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox6.Watermark.Text = "Watermark text";
                this.ComboBox6.Watermark.Visible = false;

                // 
                // ComboBox5
                // 
                this.ComboBox5.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox5.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox5.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox5.BindingSource = this.BindingSource;

                this.ComboBox5.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox5.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox5.Border.HoverVisible = true;
                this.ComboBox5.Border.Rounding = 1;
                this.ComboBox5.Border.Thickness = 1;
                this.ComboBox5.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox5.Border.Visible = true;
                this.ComboBox5.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox5.ButtonImage = null;

                this.ComboBox5.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox5.ButtonWidth = 22;
                this.ComboBox5.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox5.DropDownHeight = 100;
                this.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox5.DropDownWidth = 200;
                this.ComboBox5.Field = Field.NS;
                this.ComboBox5.DataFilter = null;
                this.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox5.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox5.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox5.FormattingEnabled = true;
                this.ComboBox5.HoverText = null;
                this.ComboBox5.ImageList = null;
                this.ComboBox5.ImageVisible = false;
                this.ComboBox5.Index = 0;
                this.ComboBox5.IntegralHeight = false;
                this.ComboBox5.ItemHeight = 24;
                this.ComboBox5.ItemImageVisible = true;
                this.ComboBox5.Location = new System.Drawing.Point( 780, 44 );
                this.ComboBox5.MaxDropDownItems = 100;

                this.ComboBox5.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox5.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox5.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox5.Name = "ComboBox5";

                this.ComboBox5.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox5.SeparatorVisible = false;
                this.ComboBox5.Size = new System.Drawing.Size( 177, 30 );
                this.ComboBox5.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox5.TabIndex = 10;
                this.ComboBox5.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox5.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox5.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox5.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox5.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox5.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox5.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox5.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox5.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox5.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox5.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox5.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox5.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox5.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox5.Watermark.Text = "Watermark text";
                this.ComboBox5.Watermark.Visible = false;

                // 
                // ComboBox4
                // 
                this.ComboBox4.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox4.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox4.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox4.BindingSource = this.BindingSource;

                this.ComboBox4.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox4.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox4.Border.HoverVisible = true;
                this.ComboBox4.Border.Rounding = 1;
                this.ComboBox4.Border.Thickness = 1;
                this.ComboBox4.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox4.Border.Visible = true;
                this.ComboBox4.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox4.ButtonImage = null;

                this.ComboBox4.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox4.ButtonWidth = 22;
                this.ComboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox4.DropDownHeight = 100;
                this.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox4.DropDownWidth = 200;
                this.ComboBox4.Field = Field.NS;
                this.ComboBox4.DataFilter = null;
                this.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox4.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox4.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox4.FormattingEnabled = true;
                this.ComboBox4.HoverText = null;
                this.ComboBox4.ImageList = null;
                this.ComboBox4.ImageVisible = false;
                this.ComboBox4.Index = 0;
                this.ComboBox4.IntegralHeight = false;
                this.ComboBox4.ItemHeight = 24;
                this.ComboBox4.ItemImageVisible = true;
                this.ComboBox4.Location = new System.Drawing.Point( 597, 44 );
                this.ComboBox4.MaxDropDownItems = 100;

                this.ComboBox4.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox4.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox4.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox4.Name = "ComboBox4";

                this.ComboBox4.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox4.SeparatorVisible = false;
                this.ComboBox4.Size = new System.Drawing.Size( 177, 30 );
                this.ComboBox4.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox4.TabIndex = 9;
                this.ComboBox4.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox4.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox4.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox4.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox4.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox4.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox4.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox4.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox4.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox4.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox4.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox4.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox4.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox4.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox4.Watermark.Text = "Watermark text";
                this.ComboBox4.Watermark.Visible = false;

                // 
                // ComboBox3
                // 
                this.ComboBox3.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox3.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox3.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox3.BindingSource = this.BindingSource;

                this.ComboBox3.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox3.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox3.Border.HoverVisible = true;
                this.ComboBox3.Border.Rounding = 1;
                this.ComboBox3.Border.Thickness = 1;
                this.ComboBox3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox3.Border.Visible = true;
                this.ComboBox3.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox3.ButtonImage = null;

                this.ComboBox3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox3.ButtonWidth = 22;
                this.ComboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox3.DropDownHeight = 100;
                this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox3.DropDownWidth = 200;
                this.ComboBox3.Field = Field.NS;
                this.ComboBox3.DataFilter = null;
                this.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox3.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox3.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox3.FormattingEnabled = true;
                this.ComboBox3.HoverText = null;
                this.ComboBox3.ImageList = null;
                this.ComboBox3.ImageVisible = false;
                this.ComboBox3.Index = 0;
                this.ComboBox3.IntegralHeight = false;
                this.ComboBox3.ItemHeight = 24;
                this.ComboBox3.ItemImageVisible = true;
                this.ComboBox3.Location = new System.Drawing.Point( 396, 44 );
                this.ComboBox3.MaxDropDownItems = 100;

                this.ComboBox3.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox3.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox3.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox3.Name = "ComboBox3";

                this.ComboBox3.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox3.SeparatorVisible = false;
                this.ComboBox3.Size = new System.Drawing.Size( 195, 30 );
                this.ComboBox3.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox3.TabIndex = 8;
                this.ComboBox3.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox3.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox3.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox3.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox3.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox3.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox3.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox3.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox3.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox3.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox3.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox3.Watermark.Text = "Watermark text";
                this.ComboBox3.Watermark.Visible = false;

                // 
                // ComboBox2
                // 
                this.ComboBox2.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox2.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox2.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox2.BindingSource = this.BindingSource;

                this.ComboBox2.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox2.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox2.Border.HoverVisible = true;
                this.ComboBox2.Border.Rounding = 1;
                this.ComboBox2.Border.Thickness = 1;
                this.ComboBox2.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox2.Border.Visible = true;
                this.ComboBox2.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox2.ButtonImage = null;

                this.ComboBox2.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox2.ButtonWidth = 22;
                this.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox2.DropDownHeight = 100;
                this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox2.DropDownWidth = 200;
                this.ComboBox2.Field = Field.NS;
                this.ComboBox2.DataFilter = null;
                this.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox2.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox2.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox2.FormattingEnabled = true;
                this.ComboBox2.HoverText = null;
                this.ComboBox2.ImageList = null;
                this.ComboBox2.ImageVisible = false;
                this.ComboBox2.Index = 0;
                this.ComboBox2.IntegralHeight = false;
                this.ComboBox2.ItemHeight = 24;
                this.ComboBox2.ItemImageVisible = true;
                this.ComboBox2.Location = new System.Drawing.Point( 190, 44 );
                this.ComboBox2.MaxDropDownItems = 100;

                this.ComboBox2.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox2.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox2.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox2.Name = "ComboBox2";

                this.ComboBox2.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox2.SeparatorVisible = false;
                this.ComboBox2.Size = new System.Drawing.Size( 200, 30 );
                this.ComboBox2.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox2.TabIndex = 7;
                this.ComboBox2.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox2.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox2.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox2.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox2.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox2.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox2.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox2.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox2.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox2.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox2.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox2.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox2.Watermark.Text = "Watermark text";
                this.ComboBox2.Watermark.Visible = false;

                // 
                // Label6
                // 
                this.Label6.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label6.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label6.Field = Field.NS;
                this.Label6.DataFilter = null;
                this.Label6.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label6.ForeColor = System.Drawing.Color.LightGray;
                this.Label6.Location = new System.Drawing.Point( 963, 15 );
                this.Label6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label6.Name = "Label6";
                this.Label6.Numeric = Numeric.NS;
                this.Label6.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label6.Outline = false;

                this.Label6.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label6.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label6.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label6.ReflectionSpacing = 0;
                this.Label6.ShadowColor = System.Drawing.Color.Black;
                this.Label6.ShadowDirection = 315;
                this.Label6.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label6.ShadowOpacity = 100;
                this.Label6.Size = new System.Drawing.Size( 181, 23 );
                this.Label6.TabIndex = 5;
                this.Label6.Text = "Label-6";
                this.Label6.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label6.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label6.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label6.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label6.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label6.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label6.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label6.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label6.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Label5
                // 
                this.Label5.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label5.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label5.Field = Field.NS;
                this.Label5.DataFilter = null;
                this.Label5.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label5.ForeColor = System.Drawing.Color.LightGray;
                this.Label5.Location = new System.Drawing.Point( 780, 15 );
                this.Label5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label5.Name = "Label5";
                this.Label5.Numeric = Numeric.NS;
                this.Label5.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label5.Outline = false;

                this.Label5.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label5.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label5.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label5.ReflectionSpacing = 0;
                this.Label5.ShadowColor = System.Drawing.Color.Black;
                this.Label5.ShadowDirection = 315;
                this.Label5.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label5.ShadowOpacity = 100;
                this.Label5.Size = new System.Drawing.Size( 177, 23 );
                this.Label5.TabIndex = 4;
                this.Label5.Text = "Label-5";
                this.Label5.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label5.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label5.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label5.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label5.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label5.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label5.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label5.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label5.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Label4
                // 
                this.Label4.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label4.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label4.Field = Field.NS;
                this.Label4.DataFilter = null;
                this.Label4.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label4.ForeColor = System.Drawing.Color.LightGray;
                this.Label4.Location = new System.Drawing.Point( 597, 15 );
                this.Label4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label4.Name = "Label4";
                this.Label4.Numeric = Numeric.NS;
                this.Label4.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label4.Outline = false;

                this.Label4.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label4.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label4.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label4.ReflectionSpacing = 0;
                this.Label4.ShadowColor = System.Drawing.Color.Black;
                this.Label4.ShadowDirection = 315;
                this.Label4.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label4.ShadowOpacity = 100;
                this.Label4.Size = new System.Drawing.Size( 177, 23 );
                this.Label4.TabIndex = 3;
                this.Label4.Text = "Label-4";
                this.Label4.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label4.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label4.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label4.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label4.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label4.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label4.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label4.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label4.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Label3
                // 
                this.Label3.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label3.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label3.Field = Field.NS;
                this.Label3.DataFilter = null;
                this.Label3.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label3.ForeColor = System.Drawing.Color.LightGray;
                this.Label3.Location = new System.Drawing.Point( 396, 15 );
                this.Label3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label3.Name = "Label3";
                this.Label3.Numeric = Numeric.NS;
                this.Label3.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label3.Outline = false;

                this.Label3.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label3.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label3.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label3.ReflectionSpacing = 0;
                this.Label3.ShadowColor = System.Drawing.Color.Black;
                this.Label3.ShadowDirection = 315;
                this.Label3.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label3.ShadowOpacity = 100;
                this.Label3.Size = new System.Drawing.Size( 195, 23 );
                this.Label3.TabIndex = 2;
                this.Label3.Text = "Label-3";
                this.Label3.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label3.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label3.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label3.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label3.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label3.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label3.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Label2
                // 
                this.Label2.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label2.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label2.Field = Field.NS;
                this.Label2.DataFilter = null;
                this.Label2.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label2.ForeColor = System.Drawing.Color.LightGray;
                this.Label2.Location = new System.Drawing.Point( 190, 15 );
                this.Label2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label2.Name = "Label2";
                this.Label2.Numeric = Numeric.NS;
                this.Label2.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label2.Outline = false;

                this.Label2.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label2.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label2.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label2.ReflectionSpacing = 0;
                this.Label2.ShadowColor = System.Drawing.Color.Black;
                this.Label2.ShadowDirection = 315;
                this.Label2.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label2.ShadowOpacity = 100;
                this.Label2.Size = new System.Drawing.Size( 200, 23 );
                this.Label2.TabIndex = 1;
                this.Label2.Text = "Label-2";
                this.Label2.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label2.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label2.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label2.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label2.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label2.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label2.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // Label1
                // 
                this.Label1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label1.BindingSource = this.BindingSource;
                this.Label1.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.Label1.Field = Field.NS;
                this.Label1.DataFilter = null;
                this.Label1.Font = new System.Drawing.Font( "Roboto", 8F );
                this.Label1.ForeColor = System.Drawing.Color.LightGray;
                this.Label1.Location = new System.Drawing.Point( 3, 15 );
                this.Label1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.Label1.Name = "Label1";
                this.Label1.Numeric = Numeric.NS;
                this.Label1.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.Label1.Outline = false;

                this.Label1.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Label1.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.Label1.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label1.ReflectionSpacing = 0;
                this.Label1.ShadowColor = System.Drawing.Color.Black;
                this.Label1.ShadowDirection = 315;
                this.Label1.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.Label1.ShadowOpacity = 100;
                this.Label1.Size = new System.Drawing.Size( 181, 23 );
                this.Label1.TabIndex = 0;
                this.Label1.Text = "Label-1";
                this.Label1.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label1.TextLineAlignment = System.Drawing.StringAlignment.Far;

                this.Label1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.Label1.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label1.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label1.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.Label1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.Label1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.Label1.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // ComboBox1
                // 
                this.ComboBox1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.ComboBox1.BindingSource = this.BindingSource;

                this.ComboBox1.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox1.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.ComboBox1.Border.HoverVisible = true;
                this.ComboBox1.Border.Rounding = 1;
                this.ComboBox1.Border.Thickness = 1;
                this.ComboBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.ComboBox1.Border.Visible = true;
                this.ComboBox1.ButtonColor = System.Drawing.Color.LightGray;
                this.ComboBox1.ButtonImage = null;

                this.ComboBox1.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox
                    .ButtonStyles.Arrow;

                this.ComboBox1.ButtonWidth = 22;
                this.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
                this.ComboBox1.DropDownHeight = 100;
                this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox1.DropDownWidth = 200;
                this.ComboBox1.Field = Field.NS;
                this.ComboBox1.DataFilter = null;
                this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox1.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox1.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox1.FormattingEnabled = true;
                this.ComboBox1.HoverText = null;
                this.ComboBox1.ImageList = null;
                this.ComboBox1.ImageVisible = false;
                this.ComboBox1.Index = 0;
                this.ComboBox1.IntegralHeight = false;
                this.ComboBox1.ItemHeight = 24;
                this.ComboBox1.ItemImageVisible = true;
                this.ComboBox1.Location = new System.Drawing.Point( 3, 44 );
                this.ComboBox1.MaxDropDownItems = 100;

                this.ComboBox1.MenuItemHover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.ComboBox1.MenuItemNormal = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox1.MenuTextColor = System.Drawing.Color.LightGray;
                this.ComboBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox1.Name = "ComboBox1";

                this.ComboBox1.SeparatorColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ) );

                this.ComboBox1.SeparatorVisible = false;
                this.ComboBox1.Size = new System.Drawing.Size( 181, 30 );
                this.ComboBox1.State = VisualPlus.Enumerators.MouseStates.Normal;
                this.ComboBox1.TabIndex = 6;
                this.ComboBox1.TextAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox1.TextDisabledColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.ComboBox1.TextLineAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox1.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.ComboBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.ComboBox1.TextStyle.Hover = System.Drawing.Color.Empty;
                this.ComboBox1.TextStyle.Pressed = System.Drawing.Color.Empty;
                this.ComboBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.ComboBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.ComboBox1.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.ComboBox1.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.ComboBox1.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ComboBox1.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.ComboBox1.Watermark.Text = "Watermark text";
                this.ComboBox1.Watermark.Visible = false;

                // 
                // TextBox1
                // 
                this.TextBox1.AlphaNumeric = false;

                this.TextBox1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 10 ) ) ) ), ( (int)( ( (byte)( 10 ) ) ) ),
                    ( (int)( ( (byte)( 10 ) ) ) ) );

                this.TextBox1.BindingSource = null;

                this.TextBox1.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 30 ) ) ) ),
                    ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ) );

                this.TextBox1.Border.HoverColor = System.Drawing.Color.SteelBlue;
                this.TextBox1.Border.HoverVisible = true;
                this.TextBox1.Border.Rounding = 6;
                this.TextBox1.Border.Thickness = 1;
                this.TextBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox1.Border.Visible = true;

                this.TextBox1.ButtonBorder.Color = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 180 ) ) ) ), ( (int)( ( (byte)( 180 ) ) ) ),
                    ( (int)( ( (byte)( 180 ) ) ) ) );

                this.TextBox1.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 120 ) ) ) ), ( (int)( ( (byte)( 183 ) ) ) ),
                    ( (int)( ( (byte)( 230 ) ) ) ) );

                this.TextBox1.ButtonBorder.HoverVisible = true;
                this.TextBox1.ButtonBorder.Rounding = 6;
                this.TextBox1.ButtonBorder.Thickness = 1;
                this.TextBox1.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TextBox1.ButtonBorder.Visible = true;

                this.TextBox1.ButtonColor.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox1.ButtonColor.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 220 ) ) ) ),
                    ( (int)( ( (byte)( 220 ) ) ) ) );

                this.TextBox1.ButtonColor.Hover = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ),
                    ( (int)( ( (byte)( 224 ) ) ) ) );

                this.TextBox1.ButtonColor.Pressed = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ),
                    ( (int)( ( (byte)( 192 ) ) ) ) );

                this.TextBox1.ButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox1.ButtonIndent = 3;
                this.TextBox1.ButtonText = "visualButton";
                this.TextBox1.ButtonVisible = false;
                this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TextBox1.Field = Field.NS;
                this.TextBox1.DataFilter = null;
                this.TextBox1.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox1.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox1.Image = null;
                this.TextBox1.ImageSize = new System.Drawing.Size( 16, 16 );
                this.TextBox1.ImageVisible = false;
                this.TextBox1.ImageWidth = 35;
                this.TextBox1.Location = new System.Drawing.Point( 3, 85 );
                this.TextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TextBox1.Name = "TextBox1";
                this.TextBox1.Numeric = Numeric.NS;
                this.TextBox1.PasswordChar = '\0';
                this.TextBox1.ReadOnly = false;
                this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TextBox1.Size = new System.Drawing.Size( 181, 23 );
                this.TextBox1.TabIndex = 12;
                this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.TextBox1.TextBoxWidth = 171;

                this.TextBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TextBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox1.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TextBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TextBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TextBox1.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                this.TextBox1.Watermark.Active = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ),
                    ( (int)( ( (byte)( 128 ) ) ) ) );

                this.TextBox1.Watermark.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TextBox1.Watermark.Inactive = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 211 ) ) ) ), ( (int)( ( (byte)( 211 ) ) ) ),
                    ( (int)( ( (byte)( 211 ) ) ) ) );

                this.TextBox1.Watermark.Text = "Watermark text";
                this.TextBox1.Watermark.Visible = false;
                this.TextBox1.WordWrap = true;

                // 
                // TopPanel
                // 
                this.TopPanel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TopPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TopPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TopPanel.BindingSource = null;

                this.TopPanel.Border.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TopPanel.Border.HoverColor = System.Drawing.SystemColors.HotTrack;
                this.TopPanel.Border.HoverVisible = true;
                this.TopPanel.Border.Rounding = 6;
                this.TopPanel.Border.Thickness = 1;
                this.TopPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
                this.TopPanel.Border.Visible = true;
                this.TopPanel.Children = null;
                this.TopPanel.Controls.Add( this.TopLabel );
                this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
                this.TopPanel.Field = Field.NS;
                this.TopPanel.ForeColor = System.Drawing.Color.LightGray;
                this.TopPanel.Location = new System.Drawing.Point( 0, 0 );
                this.TopPanel.Margin = new System.Windows.Forms.Padding( 5 );
                this.TopPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TopPanel.Name = "TopPanel";
                this.TopPanel.Padding = new System.Windows.Forms.Padding( 1 );
                this.TopPanel.Size = new System.Drawing.Size( 1147, 44 );
                this.TopPanel.TabIndex = 2;
                this.TopPanel.Text = "layoutPanel1";

                this.TopPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TopPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TopPanel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TopPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TopPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TopPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TopPanel.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // TopLabel
                // 
                this.TopLabel.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TopLabel.Dock = System.Windows.Forms.DockStyle.Fill;
                this.TopLabel.Field = Field.NS;
                this.TopLabel.DataFilter = null;

                this.TopLabel.Font = new System.Drawing.Font( "Roboto", 9.75F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.TopLabel.ForeColor = System.Drawing.Color.LightGray;
                this.TopLabel.Location = new System.Drawing.Point( 0, 0 );
                this.TopLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
                this.TopLabel.Name = "TopLabel";
                this.TopLabel.Numeric = Numeric.NS;
                this.TopLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
                this.TopLabel.Outline = false;

                this.TopLabel.OutlineColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TopLabel.OutlineLocation = new System.Drawing.Point( 0, 0 );

                this.TopLabel.ReflectionColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 120 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TopLabel.ReflectionSpacing = 0;
                this.TopLabel.ShadowColor = System.Drawing.Color.Black;
                this.TopLabel.ShadowDirection = 315;
                this.TopLabel.ShadowLocation = new System.Drawing.Point( 0, 0 );
                this.TopLabel.ShadowOpacity = 100;
                this.TopLabel.Size = new System.Drawing.Size( 1147, 44 );
                this.TopLabel.TabIndex = 1;
                this.TopLabel.Text = "Title";
                this.TopLabel.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TopLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TopLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(
                    ( (int)( ( (byte)( 131 ) ) ) ), ( (int)( ( (byte)( 129 ) ) ) ),
                    ( (int)( ( (byte)( 129 ) ) ) ) );

                this.TopLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TopLabel.TextStyle.Hover = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TopLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 0 ) ) ) ),
                    ( (int)( ( (byte)( 0 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );

                this.TopLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
                this.TopLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;

                this.TopLabel.TextStyle.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 
                // ToolBar
                // 
                this.ToolBar.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ToolBar.BindingSource = null;
                this.ToolBar.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
                this.ToolBar.DataFilter = null;
                this.ToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.ToolBar.Field = Field.NS;
                this.ToolBar.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ToolBar.ForeColor = System.Drawing.Color.MidnightBlue;
                this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
                this.ToolBar.Image = null;

                this.ToolBar.Items.AddRange( new System.Windows.Forms.ToolStripItem[]
                {
                    this.Separator1,
                    this.BarLabel,
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
                    this.SaveButton,
                    this.Separator12,
                    this.ComboBox,
                    this.Separator13,
                    this.CalculatorButton,
                    this.Separator14,
                    this.ExitButton,
                    this.Separator15
                } );

                this.ToolBar.Location = new System.Drawing.Point( 0, 287 );
                this.ToolBar.Margin = new System.Windows.Forms.Padding( 3, 5, 3, 5 );
                this.ToolBar.Name = "ToolBar";
                this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
                this.ToolBar.Padding = new System.Windows.Forms.Padding( 1 );
                this.ToolBar.ShowCaption = false;
                this.ToolBar.Size = new System.Drawing.Size( 1147, 33 );
                this.ToolBar.TabIndex = 0;

                // 
                // Separator1
                // 
                this.Separator1.Name = "Separator1";
                this.Separator1.Size = new System.Drawing.Size( 6, 29 );

                // 
                // BarLabel
                // 
                this.BarLabel.BindingSource = this.BindingSource;
                this.BarLabel.Field = Field.NS;
                this.BarLabel.Font = new System.Drawing.Font( "Roboto", 8F );
                this.BarLabel.ForeColor = System.Drawing.Color.Black;
                this.BarLabel.HoverText = null;
                this.BarLabel.Margin = new System.Windows.Forms.Padding( 3 );
                this.BarLabel.Name = "Label";
                this.BarLabel.Size = new System.Drawing.Size( 62, 23 );
                this.BarLabel.Tag = "Label";
                this.BarLabel.Text = "Data Editor";

                // 
                // Separator2
                // 
                this.Separator2.Name = "Separator2";
                this.Separator2.Size = new System.Drawing.Size( 6, 29 );

                // 
                // FirstButton
                // 
                this.FirstButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.FirstButton.Bar = Tool.FirstButton;
                this.FirstButton.BindingSource = this.BindingSource;
                this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.FirstButton.Field = Field.NS;
                this.FirstButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.FirstButton.ForeColor = System.Drawing.Color.LightGray;
                this.FirstButton.HoverText = null;

                this.FirstButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "FirstButton.Image" ) ) );

                this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.FirstButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.FirstButton.Name = "FirstButton";
                this.FirstButton.Size = new System.Drawing.Size( 23, 23 );
                this.FirstButton.Tag = "First Record";
                this.FirstButton.Text = "barButton1";

                // 
                // ToolTip
                // 
                this.ToolTip.AutoPopDelay = 5000;

                this.ToolTip.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ToolTip.BindingSource = this.BindingSource;
                this.ToolTip.BorderColor = System.Drawing.SystemColors.HotTrack;
                this.ToolTip.ForeColor = System.Drawing.Color.LightGray;
                this.ToolTip.InitialDelay = 500;
                this.ToolTip.Name = null;
                this.ToolTip.OwnerDraw = true;
                this.ToolTip.ReshowDelay = 100;
                this.ToolTip.Style = MetroSet_UI.Design.Style.Custom;
                this.ToolTip.StyleManager = null;
                this.ToolTip.ThemeAuthor = "Terry D. Eppler";
                this.ToolTip.ThemeName = "Budget Execution";

                // 
                // Separator3
                // 
                this.Separator3.Name = "Separator3";
                this.Separator3.Size = new System.Drawing.Size( 6, 29 );

                // 
                // PreviousButton
                // 
                this.PreviousButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.PreviousButton.Bar = Tool.FirstButton;
                this.PreviousButton.BindingSource = this.BindingSource;
                this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.PreviousButton.Field = Field.NS;
                this.PreviousButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.PreviousButton.ForeColor = System.Drawing.Color.LightGray;
                this.PreviousButton.HoverText = null;

                this.PreviousButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "PreviousButton.Image" ) ) );

                this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.PreviousButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.PreviousButton.Name = "PreviousButton";
                this.PreviousButton.Size = new System.Drawing.Size( 23, 23 );
                this.PreviousButton.Tag = "Previous Record";
                this.PreviousButton.Text = "barButton2";

                // 
                // Separator4
                // 
                this.Separator4.Name = "Separator4";
                this.Separator4.Size = new System.Drawing.Size( 6, 29 );

                // 
                // TextBox
                // 
                this.TextBox.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.TextBox.BindingSource = this.BindingSource;
                this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.TextBox.Field = Field.NS;
                this.TextBox.Font = new System.Drawing.Font( "Roboto", 8F );
                this.TextBox.ForeColor = System.Drawing.Color.LightGray;
                this.TextBox.HoverText = null;
                this.TextBox.Margin = new System.Windows.Forms.Padding( 3 );
                this.TextBox.Name = "TextBox";
                this.TextBox.Padding = new System.Windows.Forms.Padding( 1 );
                this.TextBox.Size = new System.Drawing.Size( 164, 23 );
                this.TextBox.Tag = "";
                this.TextBox.Text = "Text";
                this.TextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                // 
                // Separator5
                // 
                this.Separator5.Name = "Separator5";
                this.Separator5.Size = new System.Drawing.Size( 6, 29 );

                // 
                // NextButton
                // 
                this.NextButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.NextButton.Bar = Tool.FirstButton;
                this.NextButton.BindingSource = this.BindingSource;
                this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.NextButton.Field = Field.NS;
                this.NextButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.NextButton.ForeColor = System.Drawing.Color.LightGray;
                this.NextButton.HoverText = null;

                this.NextButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "NextButton.Image" ) ) );

                this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.NextButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.NextButton.Name = "NextButton";
                this.NextButton.Size = new System.Drawing.Size( 23, 23 );
                this.NextButton.Tag = "Next Record";
                this.NextButton.Text = "barButton3";

                // 
                // Separator6
                // 
                this.Separator6.Name = "Separator6";
                this.Separator6.Size = new System.Drawing.Size( 6, 29 );

                // 
                // LastButton
                // 
                this.LastButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.LastButton.Bar = Tool.FirstButton;
                this.LastButton.BindingSource = this.BindingSource;
                this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.LastButton.Field = Field.NS;
                this.LastButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.LastButton.ForeColor = System.Drawing.Color.LightGray;
                this.LastButton.HoverText = null;

                this.LastButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "LastButton.Image" ) ) );

                this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.LastButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.LastButton.Name = "LastButton";
                this.LastButton.Size = new System.Drawing.Size( 23, 23 );
                this.LastButton.Tag = "Last Record";
                this.LastButton.Text = "barButton4";

                // 
                // Separator7
                // 
                this.Separator7.Name = "Separator7";
                this.Separator7.Size = new System.Drawing.Size( 6, 29 );

                // 
                // AddButton
                // 
                this.AddButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.AddButton.Bar = Tool.FirstButton;
                this.AddButton.BindingSource = this.BindingSource;
                this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.AddButton.Field = Field.NS;
                this.AddButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.AddButton.ForeColor = System.Drawing.Color.LightGray;
                this.AddButton.HoverText = null;
                this.AddButton.Image = ( (System.Drawing.Image)( resources.GetObject( "AddButton.Image" ) ) );
                this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.AddButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.AddButton.Name = "AddButton";
                this.AddButton.Size = new System.Drawing.Size( 23, 23 );
                this.AddButton.Tag = "Add Record";
                this.AddButton.Text = "barButton5";

                // 
                // Separator8
                // 
                this.Separator8.Name = "Separator8";
                this.Separator8.Size = new System.Drawing.Size( 6, 29 );

                // 
                // DeleteButton
                // 
                this.DeleteButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.DeleteButton.Bar = Tool.FirstButton;
                this.DeleteButton.BindingSource = this.BindingSource;
                this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.DeleteButton.Field = Field.NS;
                this.DeleteButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.DeleteButton.ForeColor = System.Drawing.Color.LightGray;
                this.DeleteButton.HoverText = null;

                this.DeleteButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "DeleteButton.Image" ) ) );

                this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.DeleteButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.DeleteButton.Name = "DeleteButton";
                this.DeleteButton.Size = new System.Drawing.Size( 23, 23 );
                this.DeleteButton.Tag = "Delete Record";
                this.DeleteButton.Text = "barButton6";

                // 
                // Separator9
                // 
                this.Separator9.Name = "Separator9";
                this.Separator9.Size = new System.Drawing.Size( 6, 29 );

                // 
                // UndoButton
                // 
                this.UndoButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.UndoButton.Bar = Tool.FirstButton;
                this.UndoButton.BindingSource = this.BindingSource;
                this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.UndoButton.Field = Field.NS;
                this.UndoButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.UndoButton.ForeColor = System.Drawing.Color.LightGray;
                this.UndoButton.HoverText = null;

                this.UndoButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "UndoButton.Image" ) ) );

                this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.UndoButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.UndoButton.Name = "UndoButton";
                this.UndoButton.Size = new System.Drawing.Size( 23, 23 );
                this.UndoButton.Tag = "Undo Last Change";
                this.UndoButton.Text = "barButton7";

                // 
                // Separator10
                // 
                this.Separator10.Name = "Separator10";
                this.Separator10.Size = new System.Drawing.Size( 6, 29 );

                // 
                // RefreshButton
                // 
                this.RefreshButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.RefreshButton.Bar = Tool.FirstButton;
                this.RefreshButton.BindingSource = this.BindingSource;
                this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.RefreshButton.Field = Field.NS;
                this.RefreshButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.RefreshButton.ForeColor = System.Drawing.Color.LightGray;
                this.RefreshButton.HoverText = null;

                this.RefreshButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "RefreshButton.Image" ) ) );

                this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.RefreshButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.RefreshButton.Name = "RefreshButton";
                this.RefreshButton.Size = new System.Drawing.Size( 23, 23 );
                this.RefreshButton.Tag = "Refresh Data";
                this.RefreshButton.Text = "barButton8";

                // 
                // Separator11
                // 
                this.Separator11.Name = "Separator11";
                this.Separator11.Size = new System.Drawing.Size( 6, 29 );

                // 
                // SaveButton
                // 
                this.SaveButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.SaveButton.Bar = Tool.FirstButton;
                this.SaveButton.BindingSource = this.BindingSource;
                this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.SaveButton.Field = Field.NS;
                this.SaveButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.SaveButton.ForeColor = System.Drawing.Color.LightGray;
                this.SaveButton.HoverText = null;

                this.SaveButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "SaveButton.Image" ) ) );

                this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.SaveButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.SaveButton.Name = "SaveButton";
                this.SaveButton.Size = new System.Drawing.Size( 23, 23 );
                this.SaveButton.Tag = "Save Changes";
                this.SaveButton.Text = "barButton9";

                // 
                // Separator12
                // 
                this.Separator12.Name = "Separator12";
                this.Separator12.Size = new System.Drawing.Size( 6, 29 );

                // 
                // ComboBox
                // 
                this.ComboBox.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ComboBox.BindingSource = this.BindingSource;
                this.ComboBox.DropDownHeight = 200;
                this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.ComboBox.Field = Field.NS;
                this.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ComboBox.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ComboBox.ForeColor = System.Drawing.Color.LightGray;
                this.ComboBox.HoverText = null;
                this.ComboBox.IntegralHeight = false;
                this.ComboBox.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
                this.ComboBox.MaxDropDownItems = 30;
                this.ComboBox.Name = "ComboBox";
                this.ComboBox.Padding = new System.Windows.Forms.Padding( 1 );
                this.ComboBox.Size = new System.Drawing.Size( 130, 23 );
                this.ComboBox.Tag = "Make Selection";
                this.ComboBox.ToolTipText = "Make Selection";

                // 
                // Separator13
                // 
                this.Separator13.Margin = new System.Windows.Forms.Padding( 0, 0, 50, 0 );
                this.Separator13.Name = "Separator13";
                this.Separator13.Size = new System.Drawing.Size( 6, 29 );

                // 
                // CalculatorButton
                // 
                this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.CalculatorButton.Bar = Tool.FirstButton;
                this.CalculatorButton.BindingSource = null;
                this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.CalculatorButton.Field = Field.NS;
                this.CalculatorButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.CalculatorButton.ForeColor = System.Drawing.Color.LightGray;
                this.CalculatorButton.HoverText = null;

                this.CalculatorButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "CalculatorButton.Image" ) ) );

                this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.CalculatorButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.CalculatorButton.Name = "CalculatorButton";
                this.CalculatorButton.Size = new System.Drawing.Size( 23, 23 );
                this.CalculatorButton.Tag = "Calculator";
                this.CalculatorButton.Text = "barButton10";

                // 
                // Separator14
                // 
                this.Separator14.Name = "Separator14";
                this.Separator14.Size = new System.Drawing.Size( 6, 29 );

                // 
                // ExitButton
                // 
                this.ExitButton.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.ExitButton.Bar = Tool.FirstButton;
                this.ExitButton.BindingSource = null;
                this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                this.ExitButton.Field = Field.NS;
                this.ExitButton.Font = new System.Drawing.Font( "Roboto", 8F );
                this.ExitButton.ForeColor = System.Drawing.Color.LightGray;
                this.ExitButton.HoverText = null;

                this.ExitButton.Image =
                    ( (System.Drawing.Image)( resources.GetObject( "ExitButton.Image" ) ) );

                this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
                this.ExitButton.Margin = new System.Windows.Forms.Padding( 10, 3, 10, 3 );
                this.ExitButton.Name = "ExitButton";
                this.ExitButton.Padding = new System.Windows.Forms.Padding( 10, 0, 10, 0 );
                this.ExitButton.Size = new System.Drawing.Size( 40, 23 );
                this.ExitButton.Tag = "Exit Edit";
                this.ExitButton.Text = "barButton11";

                // 
                // Separator15
                // 
                this.Separator15.Name = "Separator15";
                this.Separator15.Size = new System.Drawing.Size( 6, 29 );

                // 
                // DataEditor
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

                this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 5 ) ) ) ),
                    ( (int)( ( (byte)( 5 ) ) ) ), ( (int)( ( (byte)( 5 ) ) ) ) );

                this.Controls.Add( this.BackPanel );
                this.DoubleBuffered = true;

                this.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );

                this.ForeColor = System.Drawing.Color.DarkGray;
                this.Name = "DataEditor";
                this.Padding = new System.Windows.Forms.Padding( 1 );
                this.Size = new System.Drawing.Size( 1149, 322 );
                this.BackPanel.ResumeLayout( false );
                this.BackPanel.PerformLayout();
                this.BottomPanel.ResumeLayout( false );
                this.SecondRow.ResumeLayout( false );
                this.SecondRow.PerformLayout();
                ( (System.ComponentModel.ISupportInitialize)( this.BindingSource ) ).EndInit();
                this.FirtsRow.ResumeLayout( false );
                this.FirtsRow.PerformLayout();
                this.TopPanel.ResumeLayout( false );
                this.ToolBar.ResumeLayout( false );
                this.ToolBar.PerformLayout();
                this.ResumeLayout( false );

            }

            #endregion

            public ToolPanel ToolBar;

            private LayoutPanel BottomPanel;

            public TableLayoutPanel SecondRow;

            public TextBoxPanel TextBox9;

            public TextBoxPanel TextBox8;

            public TextBoxPanel TextBox7;

            public TextBoxPanel TextBox12;

            public TextBoxPanel TextBox11;

            public TextBoxPanel TextBox10;

            public LabelPanel Label7;

            public LabelPanel Label8;

            public LabelPanel Label9;

            public LabelPanel Label10;

            public LabelPanel Label11;

            public LabelPanel Label12;

            public ComboBoxPanel ComboBox7;

            public ComboBoxPanel ComboBox8;

            public ComboBoxPanel ComboBox9;

            public ComboBoxPanel ComboBox10;

            public ComboBoxPanel ComboBox11;

            public ComboBoxPanel ComboBox12;

            public TableLayoutPanel FirtsRow;

            public TextBoxPanel TextBox6;

            public TextBoxPanel TextBox5;

            public TextBoxPanel TextBox4;

            public TextBoxPanel TextBox3;

            public TextBoxPanel TextBox2;

            public ComboBoxPanel ComboBox6;

            public ComboBoxPanel ComboBox5;

            public ComboBoxPanel ComboBox4;

            public ComboBoxPanel ComboBox3;

            public ComboBoxPanel ComboBox2;

            public LabelPanel Label6;

            public LabelPanel Label5;

            public LabelPanel Label4;

            public LabelPanel Label3;

            public LabelPanel Label2;

            public LabelPanel Label1;

            public ComboBoxPanel ComboBox1;

            public TextBoxPanel TextBox1;

            private LayoutPanel TopPanel;

            public BarButton FirstButton;

            public BarButton PreviousButton;

            private BarTextBox TextBox;

            public BarButton NextButton;

            public BarButton LastButton;

            public BarButton AddButton;

            public BarButton DeleteButton;

            public BarButton UndoButton;

            public BarButton RefreshButton;

            public BarButton SaveButton;

            public BarComboBox ComboBox;

            public BarButton CalculatorButton;

            public BarButton ExitButton;

            public ToolTip ToolTip;

            public BarLabel BarLabel;

            private ToolStripSeparator Separator1;

            private ToolStripSeparator Separator2;

            private ToolStripSeparator Separator3;

            private ToolStripSeparator Separator4;

            private ToolStripSeparator Separator5;

            private ToolStripSeparator Separator6;

            private ToolStripSeparator Separator7;

            private ToolStripSeparator Separator8;

            private ToolStripSeparator Separator9;

            private ToolStripSeparator Separator10;

            private ToolStripSeparator Separator11;

            private ToolStripSeparator Separator12;

            private ToolStripSeparator Separator13;

            private ToolStripSeparator Separator14;

            private ToolStripSeparator Separator15;

            private LayoutPanel BackPanel;

            public LabelPanel TopLabel;

            private BindingSource BindingSource;
        }
    
}
