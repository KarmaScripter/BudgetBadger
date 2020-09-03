namespace BudgetExecution
{
    partial class Notification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Footer = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.Label();
            this.notifyTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
            this.labelClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.AutoSize = true;
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.Footer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Footer.ForeColor = System.Drawing.Color.DimGray;
            this.Footer.Location = new System.Drawing.Point(76, 78);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(100, 13);
            this.Footer.TabIndex = 6;
            this.Footer.Text = "App located name";
            this.Footer.Click += new System.EventHandler(this.LabelApp_Click);
            this.Footer.MouseEnter += new System.EventHandler(this.LabelApp_MouseEnter);
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.PictureBox.Location = new System.Drawing.Point(13, 27);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(36, 36);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBoxIcon_Click);
            this.PictureBox.MouseEnter += new System.EventHandler(this.PictureBoxIcon_MouseEnter);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoEllipsis = true;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.LightGray;
            this.Title.Location = new System.Drawing.Point(75, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(142, 23);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title located here";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.Click += new System.EventHandler(this.LabelTitle_Click);
            this.Title.MouseEnter += new System.EventHandler(this.LabelTitle_MouseEnter);
            // 
            // Body
            // 
            this.Body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Body.AutoEllipsis = true;
            this.Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.Body.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Body.ForeColor = System.Drawing.Color.DarkGray;
            this.Body.Location = new System.Drawing.Point(76, 34);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(262, 29);
            this.Body.TabIndex = 4;
            this.Body.Text = "Body located here";
            this.Body.Click += new System.EventHandler(this.LabelBody_Click);
            this.Body.MouseEnter += new System.EventHandler(this.LabelBody_MouseEnter);
            // 
            // notifyTimer
            // 
            this.notifyTimer.Tick += new System.EventHandler(this.NotifyTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.panel1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.panel1.Border.Color = System.Drawing.Color.Blue;
            this.panel1.Border.HoverColor = System.Drawing.Color.Blue;
            this.panel1.Border.HoverVisible = true;
            this.panel1.Border.Rounding = 6;
            this.panel1.Border.Thickness = 1;
            this.panel1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.panel1.Border.Visible = true;
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.PictureBox);
            this.panel1.Controls.Add(this.Footer);
            this.panel1.Controls.Add(this.Body);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(360, 100);
            this.panel1.TabIndex = 10;
            this.panel1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.panel1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.panel1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.panel1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.ForeColor = System.Drawing.Color.DimGray;
            this.labelClose.Location = new System.Drawing.Point(340, 5);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(17, 18);
            this.labelClose.TabIndex = 8;
            this.labelClose.Text = "x";
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.LabelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.LabelClose_MouseLeave);
            // 
            // ExNotifyBalloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(360, 100);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ExNotify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExNotifyBalloon_FormClosed);
            this.Load += new System.EventHandler(this.ExNotifyBalloon_Load);
            this.Click += new System.EventHandler(this.ExNotifyBalloon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Footer;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Body;
        private System.Windows.Forms.Timer notifyTimer;
        private System.Windows.Forms.Label labelClose;
        private VisualPlus.Toolkit.Controls.Layout.VisualPanel panel1;
    }
}
