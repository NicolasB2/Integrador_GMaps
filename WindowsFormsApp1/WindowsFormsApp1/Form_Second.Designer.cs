namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_GroupInfo1 = new WindowsFormsApp1.UC_GroupInfo();
            this.uC_GroupList2 = new WindowsFormsApp1.UC_GroupList();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_Report1 = new WindowsFormsApp1.UC_Report();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.uC_GroupList2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 313);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.uC_GroupInfo1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 313);
            this.panel2.TabIndex = 1;
            // 
            // uC_GroupInfo1
            // 
            this.uC_GroupInfo1.Location = new System.Drawing.Point(188, 46);
            this.uC_GroupInfo1.Name = "uC_GroupInfo1";
            this.uC_GroupInfo1.Size = new System.Drawing.Size(189, 150);
            this.uC_GroupInfo1.TabIndex = 0;
            // 
            // uC_GroupList2
            // 
            this.uC_GroupList2.Location = new System.Drawing.Point(114, 27);
            this.uC_GroupList2.Name = "uC_GroupList2";
            this.uC_GroupList2.Size = new System.Drawing.Size(354, 250);
            this.uC_GroupList2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_Report1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 313);
            this.panel3.TabIndex = 1;
            // 
            // uC_Report1
            // 
            this.uC_Report1.Location = new System.Drawing.Point(200, 68);
            this.uC_Report1.Name = "uC_Report1";
            this.uC_Report1.Size = new System.Drawing.Size(177, 150);
            this.uC_Report1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 313);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UC_GroupInfo uC_GroupInfo1;
        private UC_GroupList uC_GroupList2;
        private System.Windows.Forms.Panel panel3;
        private UC_Report uC_Report1;
    }
}