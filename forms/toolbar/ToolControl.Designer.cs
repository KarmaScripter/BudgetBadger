using System;

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    partial class ToolControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolControl));
            this.Label = new BudgetExecution.BarLabel();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.FirstButton = new BudgetExecution.BarButton();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.BarButton();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.TextBox = new BudgetExecution.BarTextBox();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.BarButton();
            this.Separator17 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.BarButton();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.DataButton = new BudgetExecution.BarButton();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.AddButton = new BudgetExecution.BarButton();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.DeleteButton = new BudgetExecution.BarButton();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.UndoButton = new BudgetExecution.BarButton();
            this.Separator9 = new BudgetExecution.ToolSeparator();
            this.RefreshButton = new BudgetExecution.BarButton();
            this.Separator10 = new BudgetExecution.ToolSeparator();
            this.SaveButton = new BudgetExecution.BarButton();
            this.Separator11 = new BudgetExecution.ToolSeparator();
            this.ComboBox = new BudgetExecution.BarComboBox();
            this.Separator12 = new BudgetExecution.ToolSeparator();
            this.CalculatorButton = new BudgetExecution.BarButton();
            this.Separator13 = new BudgetExecution.ToolSeparator();
            this.BrowseButton = new BudgetExecution.BarButton();
            this.Separator14 = new BudgetExecution.ToolSeparator();
            this.ExcelButton = new BudgetExecution.BarButton();
            this.Separator15 = new BudgetExecution.ToolSeparator();
            this.PdfButton = new BudgetExecution.BarButton();
            this.Separator16 = new BudgetExecution.ToolSeparator();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.ToolBar = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.BindingSource = null;
            this.Label.Field = BudgetExecution.Field.NS;
            this.Label.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(34, 22);
            this.Label.Tag = "Data Records";
            this.Label.Text = "Data";
            this.Label.ToolTip = null;
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(6, 19);
            // 
            // FirstButton
            // 
            this.FirstButton.AutoToolTip = false;
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.FirstButton.Bar = BudgetExecution.Tool.FirstButton;
            this.FirstButton.BindingSource = null;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.NS;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.FirstButton.ForeColor = System.Drawing.Color.LightGray;
            this.FirstButton.HoverText = "First Record";
            this.FirstButton.Image = ((System.Drawing.Image)(resources.GetObject("FirstButton.Image")));
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.Size = new System.Drawing.Size(23, 22);
            this.FirstButton.Tag = "First Record";
            this.FirstButton.ToolTip = null;
            this.FirstButton.ToolTipText = "First Record";
            this.FirstButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.FirstButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(6, 19);
            // 
            // PreviousButton
            // 
            this.PreviousButton.AutoToolTip = false;
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PreviousButton.Bar = BudgetExecution.Tool.FirstButton;
            this.PreviousButton.BindingSource = null;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.NS;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            this.PreviousButton.HoverText = "Previous Record";
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Padding = new System.Windows.Forms.Padding(1);
            this.PreviousButton.Size = new System.Drawing.Size(23, 22);
            this.PreviousButton.Tag = "Previous Record";
            this.PreviousButton.Text = "barButton2";
            this.PreviousButton.ToolTip = null;
            this.PreviousButton.ToolTipText = "Previous Record";
            this.PreviousButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.PreviousButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 19);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BindingSource = null;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Field = BudgetExecution.Field.NS;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.HoverText = null;
            this.TextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.TextBox.Padding = new System.Windows.Forms.Padding(1);
            this.TextBox.Size = new System.Drawing.Size(146, 22);
            this.TextBox.Tag = "Current Record";
            this.TextBox.Text = "Data Record";
            this.TextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox.ToolTip = null;
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(6, 19);
            // 
            // NextButton
            // 
            this.NextButton.AutoToolTip = false;
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.NextButton.Bar = BudgetExecution.Tool.FirstButton;
            this.NextButton.BindingSource = null;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.NS;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.NextButton.ForeColor = System.Drawing.Color.LightGray;
            this.NextButton.HoverText = "Next Record";
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Padding = new System.Windows.Forms.Padding(1);
            this.NextButton.Size = new System.Drawing.Size(23, 22);
            this.NextButton.Tag = "Next Record";
            this.NextButton.ToolTip = null;
            this.NextButton.ToolTipText = "Next Record";
            this.NextButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.NextButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator17
            // 
            this.Separator17.ForeColor = System.Drawing.Color.Black;
            this.Separator17.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator17.Name = "Separator17";
            this.Separator17.Size = new System.Drawing.Size(6, 19);
            // 
            // LastButton
            // 
            this.LastButton.AutoToolTip = false;
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.LastButton.Bar = BudgetExecution.Tool.FirstButton;
            this.LastButton.BindingSource = null;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.NS;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.LastButton.ForeColor = System.Drawing.Color.LightGray;
            this.LastButton.HoverText = "Last Record";
            this.LastButton.Image = ((System.Drawing.Image)(resources.GetObject("LastButton.Image")));
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Padding = new System.Windows.Forms.Padding(1);
            this.LastButton.Size = new System.Drawing.Size(23, 22);
            this.LastButton.Tag = "Last Record";
            this.LastButton.Text = "barButton3";
            this.LastButton.ToolTip = null;
            this.LastButton.ToolTipText = "Last Record";
            this.LastButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.LastButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator5
            // 
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(6, 19);
            // 
            // DataButton
            // 
            this.DataButton.AutoToolTip = false;
            this.DataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DataButton.Bar = BudgetExecution.Tool.FirstButton;
            this.DataButton.BindingSource = null;
            this.DataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DataButton.Field = BudgetExecution.Field.NS;
            this.DataButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.DataButton.ForeColor = System.Drawing.Color.LightGray;
            this.DataButton.HoverText = "View Data Table";
            this.DataButton.Image = ((System.Drawing.Image)(resources.GetObject("DataButton.Image")));
            this.DataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.DataButton.Name = "DataButton";
            this.DataButton.Padding = new System.Windows.Forms.Padding(1);
            this.DataButton.Size = new System.Drawing.Size(23, 22);
            this.DataButton.Tag = "View Data Table";
            this.DataButton.ToolTip = null;
            this.DataButton.ToolTipText = "View Data Table";
            this.DataButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.DataButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 19);
            // 
            // AddButton
            // 
            this.AddButton.AutoToolTip = false;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.AddButton.Bar = BudgetExecution.Tool.FirstButton;
            this.AddButton.BindingSource = null;
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Field = BudgetExecution.Field.NS;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.AddButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddButton.HoverText = "Add Record";
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(1);
            this.AddButton.Size = new System.Drawing.Size(23, 22);
            this.AddButton.Tag = "Add Record";
            this.AddButton.Text = "barButton4";
            this.AddButton.ToolTip = null;
            this.AddButton.ToolTipText = "Add Record";
            this.AddButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.AddButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(6, 19);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoToolTip = false;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DeleteButton.Bar = BudgetExecution.Tool.FirstButton;
            this.DeleteButton.BindingSource = null;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Field = BudgetExecution.Field.NS;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightGray;
            this.DeleteButton.HoverText = "Delete Record";
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(1);
            this.DeleteButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteButton.Tag = "Delete Record";
            this.DeleteButton.ToolTip = null;
            this.DeleteButton.ToolTipText = "Delete Record";
            this.DeleteButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator8
            // 
            this.Separator8.ForeColor = System.Drawing.Color.Black;
            this.Separator8.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator8.Name = "Separator8";
            this.Separator8.Size = new System.Drawing.Size(6, 19);
            // 
            // UndoButton
            // 
            this.UndoButton.AutoToolTip = false;
            this.UndoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.UndoButton.Bar = BudgetExecution.Tool.FirstButton;
            this.UndoButton.BindingSource = null;
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Field = BudgetExecution.Field.NS;
            this.UndoButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.UndoButton.ForeColor = System.Drawing.Color.LightGray;
            this.UndoButton.HoverText = "Undo Last Edit";
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Padding = new System.Windows.Forms.Padding(1);
            this.UndoButton.Size = new System.Drawing.Size(23, 22);
            this.UndoButton.Tag = "Undo Last Edit";
            this.UndoButton.ToolTip = null;
            this.UndoButton.ToolTipText = "Undo Last Edit";
            this.UndoButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.UndoButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator9
            // 
            this.Separator9.ForeColor = System.Drawing.Color.Black;
            this.Separator9.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator9.Name = "Separator9";
            this.Separator9.Size = new System.Drawing.Size(6, 19);
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoToolTip = false;
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.RefreshButton.Bar = BudgetExecution.Tool.FirstButton;
            this.RefreshButton.BindingSource = null;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Field = BudgetExecution.Field.NS;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.RefreshButton.ForeColor = System.Drawing.Color.LightGray;
            this.RefreshButton.HoverText = "Refresh Database";
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.Tag = "Refresh Database";
            this.RefreshButton.ToolTip = null;
            this.RefreshButton.ToolTipText = "NS";
            this.RefreshButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.RefreshButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator10
            // 
            this.Separator10.ForeColor = System.Drawing.Color.Black;
            this.Separator10.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator10.Name = "Separator10";
            this.Separator10.Size = new System.Drawing.Size(6, 19);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoToolTip = false;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.SaveButton.Bar = BudgetExecution.Tool.FirstButton;
            this.SaveButton.BindingSource = null;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.NS;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.SaveButton.ForeColor = System.Drawing.Color.LightGray;
            this.SaveButton.HoverText = "Save Changes";
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(1);
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Tag = "Save Changes";
            this.SaveButton.ToolTip = null;
            this.SaveButton.ToolTipText = "Save Changes";
            this.SaveButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.SaveButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator11
            // 
            this.Separator11.ForeColor = System.Drawing.Color.Black;
            this.Separator11.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator11.Name = "Separator11";
            this.Separator11.Size = new System.Drawing.Size(6, 19);
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ComboBox.BindingSource = null;
            this.ComboBox.DropDownHeight = 150;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.DropDownWidth = 150;
            this.ComboBox.Field = BudgetExecution.Field.NS;
            this.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.ComboBox.HoverText = null;
            this.ComboBox.IntegralHeight = false;
            this.ComboBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ComboBox.MaxDropDownItems = 30;
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ComboBox.Size = new System.Drawing.Size(160, 22);
            this.ComboBox.Tag = "Select Value";
            this.ComboBox.ToolTip = null;
            this.ComboBox.ToolTipText = "Make Selection";
            // 
            // Separator12
            // 
            this.Separator12.ForeColor = System.Drawing.Color.Black;
            this.Separator12.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator12.Name = "Separator12";
            this.Separator12.Size = new System.Drawing.Size(6, 19);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.AutoToolTip = false;
            this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CalculatorButton.Bar = BudgetExecution.Tool.FirstButton;
            this.CalculatorButton.BindingSource = null;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.NS;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightGray;
            this.CalculatorButton.HoverText = "Calculator";
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Padding = new System.Windows.Forms.Padding(1);
            this.CalculatorButton.Size = new System.Drawing.Size(23, 22);
            this.CalculatorButton.Tag = "Calculator";
            this.CalculatorButton.ToolTip = null;
            this.CalculatorButton.ToolTipText = "Calculator";
            this.CalculatorButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.CalculatorButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator13
            // 
            this.Separator13.ForeColor = System.Drawing.Color.Black;
            this.Separator13.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator13.Name = "Separator13";
            this.Separator13.Size = new System.Drawing.Size(6, 19);
            // 
            // BrowseButton
            // 
            this.BrowseButton.AutoToolTip = false;
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BrowseButton.Bar = BudgetExecution.Tool.FirstButton;
            this.BrowseButton.BindingSource = null;
            this.BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrowseButton.Field = BudgetExecution.Field.NS;
            this.BrowseButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.BrowseButton.ForeColor = System.Drawing.Color.LightGray;
            this.BrowseButton.HoverText = "Browse FIle";
            this.BrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("BrowseButton.Image")));
            this.BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Padding = new System.Windows.Forms.Padding(1);
            this.BrowseButton.Size = new System.Drawing.Size(23, 22);
            this.BrowseButton.Tag = "Browse FIle";
            this.BrowseButton.Text = "barButton10";
            this.BrowseButton.ToolTip = null;
            this.BrowseButton.ToolTipText = "Browse FIle";
            this.BrowseButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.BrowseButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator14
            // 
            this.Separator14.ForeColor = System.Drawing.Color.Black;
            this.Separator14.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator14.Name = "Separator14";
            this.Separator14.Size = new System.Drawing.Size(6, 19);
            // 
            // ExcelButton
            // 
            this.ExcelButton.AutoToolTip = false;
            this.ExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ExcelButton.Bar = BudgetExecution.Tool.FirstButton;
            this.ExcelButton.BindingSource = null;
            this.ExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcelButton.Field = BudgetExecution.Field.NS;
            this.ExcelButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.ExcelButton.ForeColor = System.Drawing.Color.LightGray;
            this.ExcelButton.HoverText = "Excel Document";
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Padding = new System.Windows.Forms.Padding(1);
            this.ExcelButton.Size = new System.Drawing.Size(23, 22);
            this.ExcelButton.Tag = "Excel Document";
            this.ExcelButton.Text = "barButton1";
            this.ExcelButton.ToolTip = null;
            this.ExcelButton.ToolTipText = "Excel Document";
            this.ExcelButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.ExcelButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator15
            // 
            this.Separator15.ForeColor = System.Drawing.Color.Black;
            this.Separator15.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator15.Name = "Separator15";
            this.Separator15.Size = new System.Drawing.Size(6, 19);
            // 
            // PdfButton
            // 
            this.PdfButton.AutoToolTip = false;
            this.PdfButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PdfButton.Bar = BudgetExecution.Tool.FirstButton;
            this.PdfButton.BindingSource = null;
            this.PdfButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PdfButton.Field = BudgetExecution.Field.NS;
            this.PdfButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.PdfButton.ForeColor = System.Drawing.Color.LightGray;
            this.PdfButton.HoverText = "PDF Document";
            this.PdfButton.Image = ((System.Drawing.Image)(resources.GetObject("PdfButton.Image")));
            this.PdfButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PdfButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PdfButton.Name = "PdfButton";
            this.PdfButton.Padding = new System.Windows.Forms.Padding(1);
            this.PdfButton.Size = new System.Drawing.Size(23, 22);
            this.PdfButton.Tag = "PDF Document";
            this.PdfButton.Text = "barButton2";
            this.PdfButton.ToolTip = null;
            this.PdfButton.ToolTipText = "PDF Document";
            this.PdfButton.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.PdfButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Separator16
            // 
            this.Separator16.ForeColor = System.Drawing.Color.Black;
            this.Separator16.Margin = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator16.Name = "Separator16";
            this.Separator16.Size = new System.Drawing.Size(6, 19);
            // 
            // Progress
            // 
            this.Progress.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Progress.Name = "Progress";
            this.Progress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Progress.Size = new System.Drawing.Size(100, 19);
            this.Progress.Tag = "Progress";
            this.Progress.ToolTipText = "Progress";
            this.Progress.MouseEnter += new System.EventHandler(this.OnMouseHover);
            this.Progress.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // ToolBar
            // 
            this.ToolBar.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolBar.CanOverflow = false;
            this.ToolBar.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Far;
            this.ToolBar.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolBar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.ForeColor = System.Drawing.Color.Black;
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.Image = null;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label,
            this.Separator1,
            this.FirstButton,
            this.Separator2,
            this.PreviousButton,
            this.Separator3,
            this.TextBox,
            this.Separator4,
            this.NextButton,
            this.Separator17,
            this.LastButton,
            this.Separator5,
            this.DataButton,
            this.Separator6,
            this.AddButton,
            this.Separator7,
            this.DeleteButton,
            this.Separator8,
            this.UndoButton,
            this.Separator9,
            this.RefreshButton,
            this.Separator10,
            this.SaveButton,
            this.Separator11,
            this.ComboBox,
            this.Separator12,
            this.CalculatorButton,
            this.Separator13,
            this.BrowseButton,
            this.Separator14,
            this.ExcelButton,
            this.Separator15,
            this.PdfButton,
            this.Separator16,
            this.Progress});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Margin = new System.Windows.Forms.Padding(3);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolBar.Padding = new System.Windows.Forms.Padding(1);
            this.ToolBar.ShowCaption = true;
            this.ToolBar.ShowLauncher = false;
            this.ToolBar.Size = new System.Drawing.Size(1289, 51);
            this.ToolBar.Stretch = true;
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "Command Bar";
            this.ToolBar.MouseHover += new System.EventHandler(this.OnMouseHover);
            // 
            // ToolBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolBar);
            this.Name = "ToolControl";
            this.Size = new System.Drawing.Size(1289, 51);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            public BarComboBox ComboBox;

            public ToolStripEx ToolBar;

            public BarLabel Label;
        private ToolSeparator Separator1;
        public BarButton FirstButton;
        private ToolSeparator Separator2;
        public BarButton PreviousButton;
        private ToolSeparator Separator3;
        private ToolSeparator Separator4;
        public BarButton NextButton;
        private ToolSeparator Separator17;
        public BarButton LastButton;
        private ToolSeparator Separator5;
        public BarButton DataButton;
        private ToolSeparator Separator6;
        public BarButton AddButton;
        private ToolSeparator Separator7;
        public BarButton DeleteButton;
        private ToolSeparator Separator8;
        public BarButton UndoButton;
        private ToolSeparator Separator9;
        public BarButton RefreshButton;
        private ToolSeparator Separator10;
        public BarButton SaveButton;
        private ToolSeparator Separator11;
        private ToolSeparator Separator12;
        public BarButton CalculatorButton;
        private ToolSeparator Separator13;
        public BarButton BrowseButton;
        private ToolSeparator Separator14;
        public BarButton ExcelButton;
        private ToolSeparator Separator15;
        public BarButton PdfButton;
        private ToolSeparator Separator16;
        public ToolStripProgressBar Progress;
        public BarTextBox TextBox;
    }
    
}
