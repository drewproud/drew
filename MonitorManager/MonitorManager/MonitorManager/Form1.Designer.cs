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
            this.leftMonitor = new System.Windows.Forms.ComboBox();
            this.mainMonitor = new System.Windows.Forms.ComboBox();
            this.rightMonitor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Standard
            // 
            this.Standard.Location = new System.Drawing.Point(100, 161);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(142, 23);
            this.Standard.TabIndex = 0;
            this.Standard.Text = "Standard Layout";
            this.Standard.UseVisualStyleBackColor = true;
            this.Standard.Click += new System.EventHandler(this.button1_Click);
            // 
            // leftMonitor
            // 
            this.leftMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leftMonitor.FormattingEnabled = true;
            this.leftMonitor.Location = new System.Drawing.Point(66, 32);
            this.leftMonitor.Name = "leftMonitor";
            this.leftMonitor.Size = new System.Drawing.Size(232, 21);
            this.leftMonitor.TabIndex = 1;
            this.leftMonitor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mainMonitor
            // 
            this.mainMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainMonitor.FormattingEnabled = true;
            this.mainMonitor.Location = new System.Drawing.Point(66, 74);
            this.mainMonitor.Name = "mainMonitor";
            this.mainMonitor.Size = new System.Drawing.Size(232, 21);
            this.mainMonitor.TabIndex = 2;
            this.mainMonitor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // rightMonitor
            // 
            this.rightMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightMonitor.FormattingEnabled = true;
            this.rightMonitor.Location = new System.Drawing.Point(66, 117);
            this.rightMonitor.Name = "rightMonitor";
            this.rightMonitor.Size = new System.Drawing.Size(232, 21);
            this.rightMonitor.TabIndex = 3;
            this.rightMonitor.SelectedIndexChanged += new System.EventHandler(this.rightMonitor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 235);
            this.Controls.Add(this.rightMonitor);
            this.Controls.Add(this.mainMonitor);
            this.Controls.Add(this.leftMonitor);
            this.Controls.Add(this.Standard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Standard;
        private System.Windows.Forms.ComboBox leftMonitor;
        private System.Windows.Forms.ComboBox mainMonitor;
        private System.Windows.Forms.ComboBox rightMonitor;
    }
}

