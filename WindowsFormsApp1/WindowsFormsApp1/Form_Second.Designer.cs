namespace WindowsFormsApp1
{
    public partial class Form1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_GroupList1 = new WindowsFormsApp1.UC_GroupList();
            this.uC_Report1 = new WindowsFormsApp1.UC_Report();
            this.uC_GroupInfo1 = new WindowsFormsApp1.UC_GroupInfo();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.uC_GroupInfo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 441);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.uC_Report1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 441);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_GroupList1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 441);
            this.panel3.TabIndex = 1;
            // 
            // uC_GroupList1
            // 
            this.uC_GroupList1.Location = new System.Drawing.Point(162, 12);
            this.uC_GroupList1.Name = "uC_GroupList1";
            this.uC_GroupList1.Size = new System.Drawing.Size(350, 400);
            this.uC_GroupList1.TabIndex = 0;
            this.uC_GroupList1.Load += new System.EventHandler(this.uC_GroupList1_Load);
            // 
            // uC_Report1
            // 
            this.uC_Report1.Location = new System.Drawing.Point(9, 3);
            this.uC_Report1.Name = "uC_Report1";
            this.uC_Report1.Size = new System.Drawing.Size(690, 400);
            this.uC_Report1.TabIndex = 0;
            // 
            // uC_GroupInfo1
            // 
            this.uC_GroupInfo1.Location = new System.Drawing.Point(3, 12);
            this.uC_GroupInfo1.Name = "uC_GroupInfo1";
            this.uC_GroupInfo1.Size = new System.Drawing.Size(690, 400);
            this.uC_GroupInfo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 441);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

        public UC_GroupInfo uC_GroupInfo1;
        public UC_Report uC_Report1;
        public UC_GroupList uC_GroupList1;
    }
}