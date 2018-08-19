namespace WindowsFormsApp1
{
    partial class Control1
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
            this.comboBox_atributos = new System.Windows.Forms.ComboBox();
            this.comboBox_2doFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_atributos
            // 
            this.comboBox_atributos.FormattingEnabled = true;
            this.comboBox_atributos.Items.AddRange(new object[] {
            "Atributo a filtrar",
            "Grupos",
            "Municipio",
            "Departamento",
            "Región",
            "Área",
            "Área mayor"});
            this.comboBox_atributos.Location = new System.Drawing.Point(31, 44);
            this.comboBox_atributos.Name = "comboBox_atributos";
            this.comboBox_atributos.Size = new System.Drawing.Size(139, 21);
            this.comboBox_atributos.TabIndex = 0;
            // 
            // comboBox_2doFiltro
            // 
            this.comboBox_2doFiltro.FormattingEnabled = true;
            this.comboBox_2doFiltro.Location = new System.Drawing.Point(32, 110);
            this.comboBox_2doFiltro.Name = "comboBox_2doFiltro";
            this.comboBox_2doFiltro.Size = new System.Drawing.Size(137, 21);
            this.comboBox_2doFiltro.TabIndex = 1;
            this.comboBox_2doFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atributo a filtrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo filtro";
            // 
            // Control1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_2doFiltro);
            this.Controls.Add(this.comboBox_atributos);
            this.Name = "Control1";
            this.Size = new System.Drawing.Size(200, 273);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_atributos;
        private System.Windows.Forms.ComboBox comboBox_2doFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
