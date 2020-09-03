namespace BudgetExecution
{
    partial class EditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataEditor1 = new BudgetExecution.EditControl();
            this.SuspendLayout();
            // 
            // dataEditor1
            // 
            this.dataEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.dataEditor1.BindingSource = null;
            this.dataEditor1.DataFilter = null;
            this.dataEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEditor1.Field = BudgetExecution.Field.NS;
            this.dataEditor1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEditor1.ForeColor = System.Drawing.Color.DarkGray;
            this.dataEditor1.Location = new System.Drawing.Point(0, 0);
            this.dataEditor1.Name = "dataEditor1";
            this.dataEditor1.Numeric = BudgetExecution.Numeric.NS;
            this.dataEditor1.Padding = new System.Windows.Forms.Padding(1);
            this.dataEditor1.Size = new System.Drawing.Size(1101, 330);
            this.dataEditor1.TabIndex = 0;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BorderColor = System.Drawing.Color.Blue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1101, 330);
            this.ControlBox = false;
            this.Controls.Add(this.dataEditor1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private EditControl dataEditor1;
    }
}