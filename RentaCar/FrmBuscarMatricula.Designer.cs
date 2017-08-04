namespace RentaCar
{
    partial class FrmBuscarMatricula
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBuscarMatricula = new System.Windows.Forms.ComboBox();
            this.dataBuscarMatricula = new System.Windows.Forms.DataGridView();
            this.comboopcion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBuscarMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por: ";
            // 
            // comboBuscarMatricula
            // 
            this.comboBuscarMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscarMatricula.FormattingEnabled = true;
            this.comboBuscarMatricula.Items.AddRange(new object[] {
            "",
            "marca",
            "motor",
            "tipo",
            "transmicion",
            "estado"});
            this.comboBuscarMatricula.Location = new System.Drawing.Point(82, 6);
            this.comboBuscarMatricula.Name = "comboBuscarMatricula";
            this.comboBuscarMatricula.Size = new System.Drawing.Size(121, 21);
            this.comboBuscarMatricula.TabIndex = 1;
            this.comboBuscarMatricula.SelectedIndexChanged += new System.EventHandler(this.comboBuscarMatricula_SelectedIndexChanged);
            // 
            // dataBuscarMatricula
            // 
            this.dataBuscarMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBuscarMatricula.Location = new System.Drawing.Point(12, 53);
            this.dataBuscarMatricula.Name = "dataBuscarMatricula";
            this.dataBuscarMatricula.Size = new System.Drawing.Size(839, 255);
            this.dataBuscarMatricula.TabIndex = 2;
            // 
            // comboopcion
            // 
            this.comboopcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboopcion.FormattingEnabled = true;
            this.comboopcion.Location = new System.Drawing.Point(209, 6);
            this.comboopcion.Name = "comboopcion";
            this.comboopcion.Size = new System.Drawing.Size(121, 21);
            this.comboopcion.TabIndex = 3;
            this.comboopcion.SelectedIndexChanged += new System.EventHandler(this.comboopcion_SelectedIndexChanged);
            // 
            // FrmBuscarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 421);
            this.Controls.Add(this.comboopcion);
            this.Controls.Add(this.dataBuscarMatricula);
            this.Controls.Add(this.comboBuscarMatricula);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscarMatricula";
            this.Text = "FrmBuscarMatricula";
            this.Load += new System.EventHandler(this.FrmBuscarMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBuscarMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBuscarMatricula;
        private System.Windows.Forms.DataGridView dataBuscarMatricula;
        private System.Windows.Forms.ComboBox comboopcion;
    }
}