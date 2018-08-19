namespace WindowsFormsApp1
{
    partial class UC_GroupList
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Investigation_groups = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Investigation_groups
            // 
            this.Investigation_groups.AutoSize = true;
            this.Investigation_groups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Investigation_groups.Location = new System.Drawing.Point(83, 16);
            this.Investigation_groups.Name = "Investigation_groups";
            this.Investigation_groups.Size = new System.Drawing.Size(172, 20);
            this.Investigation_groups.TabIndex = 0;
            this.Investigation_groups.Text = "Investigation groups";
            this.Investigation_groups.Click += new System.EventHandler(this.Investigation_groups_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(135, 192);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(75, 23);
            this.Continue.TabIndex = 1;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(113, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // UC_GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Investigation_groups);
            this.Name = "UC_GroupList";
            this.Size = new System.Drawing.Size(354, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Investigation_groups;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.ListBox listBox1;
    }
}
