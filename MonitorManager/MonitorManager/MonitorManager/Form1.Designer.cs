namespace MonitorManager
{
    partial class Form1
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
            this.Standard = new System.Windows.Forms.Button();
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Standard
            // 
            this.Standard.Location = new System.Drawing.Point(12, 131);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(142, 23);
            this.Standard.TabIndex = 0;
            this.Standard.Text = "Standard Layout";
            this.Standard.UseVisualStyleBackColor = true;
            this.Standard.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayText
            // 
            this.DisplayText.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayText.Location = new System.Drawing.Point(45, 28);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(75, 20);
            this.DisplayText.TabIndex = 1;
            this.DisplayText.Text = "Choose:";
            this.DisplayText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 179);
            this.Controls.Add(this.DisplayText);
            this.Controls.Add(this.Standard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Standard;
        private System.Windows.Forms.TextBox DisplayText;
    }
}

