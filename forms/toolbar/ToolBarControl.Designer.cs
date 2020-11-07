namespace BudgetExecution
{
    partial class ToolBarControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBarControl));
            this.ToolBar = new BudgetExecution.ToolPanel();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.Label = new BudgetExecution.BarLabel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.FirstButton = new BudgetExecution.BarButton();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.BarButton();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.TextBox = new BudgetExecution.BarTextBox();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.BarButton();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.BarButton();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.AddButton = new BudgetExecution.BarButton();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.DeleteButton = new BudgetExecution.BarButton();
            this.Separator9 = new BudgetExecution.ToolSeparator();
            this.UndoButton = new BudgetExecution.BarButton();
            this.Separator10 = new BudgetExecution.ToolSeparator();
            this.SaveButton = new BudgetExecution.BarButton();
            this.Separator11 = new BudgetExecution.ToolSeparator();
            this.RefreshButton = new BudgetExecution.BarButton();
            this.Separator12 = new BudgetExecution.ToolSeparator();
            this.UpdateButton = new BudgetExecution.BarButton();
            this.Separator17 = new BudgetExecution.ToolSeparator();
            this.CalculatorButton = new BudgetExecution.BarButton();
            this.Separator13 = new BudgetExecution.ToolSeparator();
            this.ExcelButton = new BudgetExecution.BarButton();
            this.Separator14 = new BudgetExecution.ToolSeparator();
            this.BrowseButton = new BudgetExecution.BarButton();
            this.Separator15 = new BudgetExecution.ToolSeparator();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Separator16 = new BudgetExecution.ToolSeparator();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolBar.BindingSource = this.BindingSource;
            this.ToolBar.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolBar.Buttons = null;
            this.ToolBar.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Center;
            this.ToolBar.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.DataFilter = null;
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolBar.Field = BudgetExecution.Field.NS;
            this.ToolBar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.ForeColor = System.Drawing.Color.Black;
            this.ToolBar.GripMargin = new System.Windows.Forms.Padding(0);
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
            this.SaveButton,
            this.Separator11,
            this.RefreshButton,
            this.Separator12,
            this.UpdateButton,
            this.Separator17,
            this.CalculatorButton,
            this.Separator13,
            this.ExcelButton,
            this.Separator14,
            this.BrowseButton,
            this.Separator15,
            this.ProgressBar,
            this.Separator16});
            this.ToolBar.Location = new System.Drawing.Point(1, 1);
            this.ToolBar.Margin = new System.Windows.Forms.Padding(0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Numeric = BudgetExecution.Numeric.NS;
            this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolBar.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.ToolBar.ShowCaption = true;
            this.ToolBar.ShowLauncher = false;
            this.ToolBar.Size = new System.Drawing.Size(1025, 51);
            this.ToolBar.TabIndex = 0;
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(5);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(6, 23);
            // 
            // Label
            // 
            this.Label.BindingSource = this.BudgetBinding;
            this.Label.Field = BudgetExecution.Field.NS;
            this.Label.Font = new System.Drawing.Font("Roboto", 8F);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(33, 23);
            this.Label.Tag = "Data Source";
            this.Label.Text = "Data:";
            this.Label.ToolTip = null;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(5);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(6, 23);
            // 
            // FirstButton
            // 
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.FirstButton.Bar = BudgetExecution.Tool.FirstButton;
            this.FirstButton.BindingSource = this.BudgetBinding;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.NS;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.FirstButton.ForeColor = System.Drawing.Color.LightGray;
            this.FirstButton.HoverText = "First Record";
            this.FirstButton.Image = ((System.Drawing.Image)(resources.GetObject("FirstButton.Image")));
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Padding = new System.Windows.Forms.Padding(1);
            this.FirstButton.Size = new System.Drawing.Size(23, 23);
            this.FirstButton.Tag = "First Record";
            this.FirstButton.Text = "FirstButton";
            this.FirstButton.ToolTip = null;
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(5);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 23);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PreviousButton.Bar = BudgetExecution.Tool.PreviousButton;
            this.PreviousButton.BindingSource = this.BudgetBinding;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.NS;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            this.PreviousButton.HoverText = "Previous Record";
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Padding = new System.Windows.Forms.Padding(1);
            this.PreviousButton.Size = new System.Drawing.Size(23, 23);
            this.PreviousButton.Tag = "Previous Record";
            this.PreviousButton.Text = "PreviousButton";
            this.PreviousButton.ToolTip = null;
            this.PreviousButton.ToolTipText = "Previous Record";
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Margin = new System.Windows.Forms.Padding(5);
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(6, 23);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BindingSource = this.BudgetBinding;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Field = BudgetExecution.Field.NS;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 8F);
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(154, 23);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = null;
            // 
            // Separator5
            // 
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Margin = new System.Windows.Forms.Padding(5);
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(6, 23);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.NextButton.Bar = BudgetExecution.Tool.NextButton;
            this.NextButton.BindingSource = this.BudgetBinding;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.NS;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.NextButton.ForeColor = System.Drawing.Color.LightGray;
            this.NextButton.HoverText = "Next Record";
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Padding = new System.Windows.Forms.Padding(1);
            this.NextButton.Size = new System.Drawing.Size(23, 23);
            this.NextButton.Tag = "Next Record";
            this.NextButton.Text = "NextButton";
            this.NextButton.ToolTip = null;
            this.NextButton.ToolTipText = "Next Record";
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(5);
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 23);
            // 
            // LastButton
            // 
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.LastButton.Bar = BudgetExecution.Tool.LastButton;
            this.LastButton.BindingSource = this.BudgetBinding;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.NS;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.LastButton.ForeColor = System.Drawing.Color.LightGray;
            this.LastButton.HoverText = "Last Record";
            this.LastButton.Image = ((System.Drawing.Image)(resources.GetObject("LastButton.Image")));
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Padding = new System.Windows.Forms.Padding(1);
            this.LastButton.Size = new System.Drawing.Size(23, 23);
            this.LastButton.Tag = "Last Record";
            this.LastButton.Text = "LastButton";
            this.LastButton.ToolTip = null;
            this.LastButton.ToolTipText = "Last Record";
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(5);
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(6, 23);
            // 
            // AddButton
            // 
            this.AddButton.AutoToolTip = false;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.AddButton.Bar = BudgetExecution.Tool.AddButton;
            this.AddButton.BindingSource = this.BudgetBinding;
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Field = BudgetExecution.Field.NS;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.AddButton.ForeColor = System.Drawing.Color.LightGray;
            this.AddButton.HoverText = "Add Record";
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(1);
            this.AddButton.Size = new System.Drawing.Size(23, 23);
            this.AddButton.Tag = "Add Record";
            this.AddButton.Text = "AddButton";
            this.AddButton.ToolTip = null;
            this.AddButton.ToolTipText = "Add Record";
            // 
            // Separator8
            // 
            this.Separator8.ForeColor = System.Drawing.Color.Black;
            this.Separator8.Margin = new System.Windows.Forms.Padding(5);
            this.Separator8.Name = "Separator8";
            this.Separator8.Size = new System.Drawing.Size(6, 23);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.DeleteButton.Bar = BudgetExecution.Tool.DeleteButton;
            this.DeleteButton.BindingSource = this.BudgetBinding;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Field = BudgetExecution.Field.NS;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightGray;
            this.DeleteButton.HoverText = null;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(1);
            this.DeleteButton.Size = new System.Drawing.Size(23, 23);
            this.DeleteButton.Tag = "Delete";
            this.DeleteButton.Text = "barButton6";
            this.DeleteButton.ToolTip = null;
            this.DeleteButton.ToolTipText = "DeleteButton";
            // 
            // Separator9
            // 
            this.Separator9.ForeColor = System.Drawing.Color.Black;
            this.Separator9.Margin = new System.Windows.Forms.Padding(5);
            this.Separator9.Name = "Separator9";
            this.Separator9.Size = new System.Drawing.Size(6, 23);
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.UndoButton.Bar = BudgetExecution.Tool.UndoButton;
            this.UndoButton.BindingSource = this.BudgetBinding;
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Field = BudgetExecution.Field.NS;
            this.UndoButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.UndoButton.ForeColor = System.Drawing.Color.LightGray;
            this.UndoButton.HoverText = "Undo Changes";
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Margin = new System.Windows.Forms.Padding(5);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Padding = new System.Windows.Forms.Padding(1);
            this.UndoButton.Size = new System.Drawing.Size(23, 23);
            this.UndoButton.Tag = "Undo Changes";
            this.UndoButton.Text = "UndoButton";
            this.UndoButton.ToolTip = null;
            this.UndoButton.ToolTipText = "Undo Changes";
            // 
            // Separator10
            // 
            this.Separator10.ForeColor = System.Drawing.Color.Black;
            this.Separator10.Margin = new System.Windows.Forms.Padding(5);
            this.Separator10.Name = "Separator10";
            this.Separator10.Size = new System.Drawing.Size(6, 23);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.SaveButton.Bar = BudgetExecution.Tool.SaveButton;
            this.SaveButton.BindingSource = this.BudgetBinding;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.NS;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.SaveButton.ForeColor = System.Drawing.Color.LightGray;
            this.SaveButton.HoverText = "Save Changes";
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(1);
            this.SaveButton.Size = new System.Drawing.Size(23, 23);
            this.SaveButton.Tag = "Save Changes";
            this.SaveButton.Text = "SaveButton";
            this.SaveButton.ToolTip = null;
            this.SaveButton.ToolTipText = "Save Changes";
            // 
            // Separator11
            // 
            this.Separator11.ForeColor = System.Drawing.Color.Black;
            this.Separator11.Margin = new System.Windows.Forms.Padding(5);
            this.Separator11.Name = "Separator11";
            this.Separator11.Size = new System.Drawing.Size(6, 23);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.RefreshButton.Bar = BudgetExecution.Tool.RefreshButton;
            this.RefreshButton.BindingSource = this.BudgetBinding;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Field = BudgetExecution.Field.NS;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.RefreshButton.ForeColor = System.Drawing.Color.LightGray;
            this.RefreshButton.HoverText = "Refresh Data";
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshButton.Size = new System.Drawing.Size(23, 23);
            this.RefreshButton.Tag = "Refresh Data";
            this.RefreshButton.Text = "RefreshButton";
            this.RefreshButton.ToolTip = null;
            this.RefreshButton.ToolTipText = "Refresh Data";
            // 
            // Separator12
            // 
            this.Separator12.ForeColor = System.Drawing.Color.Black;
            this.Separator12.Margin = new System.Windows.Forms.Padding(5);
            this.Separator12.Name = "Separator12";
            this.Separator12.Size = new System.Drawing.Size(6, 23);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoToolTip = false;
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.UpdateButton.Bar = BudgetExecution.Tool.UpdateButton;
            this.UpdateButton.BindingSource = this.BudgetBinding;
            this.UpdateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdateButton.Field = BudgetExecution.Field.NS;
            this.UpdateButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.UpdateButton.ForeColor = System.Drawing.Color.LightGray;
            this.UpdateButton.HoverText = "Update Data";
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Padding = new System.Windows.Forms.Padding(1);
            this.UpdateButton.Size = new System.Drawing.Size(23, 23);
            this.UpdateButton.Tag = "Update DataSource";
            this.UpdateButton.Text = "UpdateButton";
            this.UpdateButton.ToolTip = null;
            this.UpdateButton.ToolTipText = "Update Data Source";
            // 
            // Separator17
            // 
            this.Separator17.ForeColor = System.Drawing.Color.Black;
            this.Separator17.Margin = new System.Windows.Forms.Padding(5);
            this.Separator17.Name = "Separator17";
            this.Separator17.Size = new System.Drawing.Size(6, 23);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CalculatorButton.Bar = BudgetExecution.Tool.CalculatorButton;
            this.CalculatorButton.BindingSource = this.BudgetBinding;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.NS;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightGray;
            this.CalculatorButton.HoverText = "Calculator";
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Padding = new System.Windows.Forms.Padding(1);
            this.CalculatorButton.Size = new System.Drawing.Size(23, 23);
            this.CalculatorButton.Tag = "Calculator";
            this.CalculatorButton.Text = "CalculatorButton";
            this.CalculatorButton.ToolTip = null;
            this.CalculatorButton.ToolTipText = "Calculator";
            // 
            // Separator13
            // 
            this.Separator13.ForeColor = System.Drawing.Color.Black;
            this.Separator13.Margin = new System.Windows.Forms.Padding(5);
            this.Separator13.Name = "Separator13";
            this.Separator13.Size = new System.Drawing.Size(6, 23);
            // 
            // ExcelButton
            // 
            this.ExcelButton.AutoToolTip = false;
            this.ExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ExcelButton.Bar = BudgetExecution.Tool.ExcelButton;
            this.ExcelButton.BindingSource = this.BudgetBinding;
            this.ExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcelButton.Field = BudgetExecution.Field.NS;
            this.ExcelButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.ExcelButton.ForeColor = System.Drawing.Color.LightGray;
            this.ExcelButton.HoverText = "Browse Excel File";
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Padding = new System.Windows.Forms.Padding(1);
            this.ExcelButton.Size = new System.Drawing.Size(23, 23);
            this.ExcelButton.Tag = "Excel File";
            this.ExcelButton.Text = "DataButton";
            this.ExcelButton.ToolTip = null;
            this.ExcelButton.ToolTipText = "Browse Excel File";
            // 
            // Separator14
            // 
            this.Separator14.ForeColor = System.Drawing.Color.Black;
            this.Separator14.Margin = new System.Windows.Forms.Padding(5);
            this.Separator14.Name = "Separator14";
            this.Separator14.Size = new System.Drawing.Size(6, 23);
            // 
            // BrowseButton
            // 
            this.BrowseButton.AutoToolTip = false;
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BrowseButton.Bar = BudgetExecution.Tool.BrowseButton;
            this.BrowseButton.BindingSource = this.BudgetBinding;
            this.BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrowseButton.Field = BudgetExecution.Field.NS;
            this.BrowseButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.BrowseButton.ForeColor = System.Drawing.Color.LightGray;
            this.BrowseButton.HoverText = "Browse File";
            this.BrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("BrowseButton.Image")));
            this.BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(5);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Padding = new System.Windows.Forms.Padding(1);
            this.BrowseButton.Size = new System.Drawing.Size(23, 23);
            this.BrowseButton.Tag = "Browse File";
            this.BrowseButton.Text = "BrowseButton";
            this.BrowseButton.ToolTip = null;
            this.BrowseButton.ToolTipText = "Browse File";
            // 
            // Separator15
            // 
            this.Separator15.ForeColor = System.Drawing.Color.Black;
            this.Separator15.Margin = new System.Windows.Forms.Padding(5);
            this.Separator15.Name = "Separator15";
            this.Separator15.Size = new System.Drawing.Size(6, 23);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 23);
            // 
            // Separator16
            // 
            this.Separator16.ForeColor = System.Drawing.Color.Black;
            this.Separator16.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Separator16.Name = "Separator16";
            this.Separator16.Size = new System.Drawing.Size(6, 33);
            // 
            // ToolBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Controls.Add(this.ToolBar);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Name = "ToolBarControl";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Size = new System.Drawing.Size(1027, 52);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ToolPanel ToolBar;
        public BarButton AddButton;
        public BarLabel Label;
        public BarButton FirstButton;
        public BarButton PreviousButton;
        public BarTextBox TextBox;
        public BarButton NextButton;
        public BarButton LastButton;
        public BarButton DeleteButton;
        public BarButton UndoButton;
        public BarButton RefreshButton;
        public BarButton SaveButton;
        public BarButton CalculatorButton;
        public BarButton ExcelButton;
        public BarButton BrowseButton;
        public ToolSeparator Separator1;
        public ToolSeparator Separator2;
        public ToolSeparator Separator3;
        public ToolSeparator Separator4;
        public ToolSeparator Separator5;
        public ToolSeparator Separator6;
        public ToolSeparator Separator7;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolSeparator Separator11;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public ToolSeparator Separator14;
        public ToolSeparator Separator15;
        public ToolSeparator Separator17;
        public BarButton UpdateButton;
        public BudgetBinding BudgetBinding;
        public System.Windows.Forms.ToolStripProgressBar ProgressBar;
        public ToolSeparator Separator16;
    }
}
