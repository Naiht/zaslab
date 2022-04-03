namespace zaslab
{
    partial class v_IngreE
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
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_Genero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombrea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_edad
            // 
            this.txt_edad.Enabled = false;
            this.txt_edad.Location = new System.Drawing.Point(517, 205);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(88, 27);
            this.txt_edad.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Edad: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // cmb_Genero
            // 
            this.cmb_Genero.FormattingEnabled = true;
            this.cmb_Genero.Location = new System.Drawing.Point(190, 144);
            this.cmb_Genero.Name = "cmb_Genero";
            this.cmb_Genero.Size = new System.Drawing.Size(151, 28);
            this.cmb_Genero.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Location = new System.Drawing.Point(16, 147);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(57, 20);
            this.Genero.TabIndex = 16;
            this.Genero.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID local del beneficiario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre y apellido";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(190, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(207, 27);
            this.txt_id.TabIndex = 13;
            // 
            // txt_nombrea
            // 
            this.txt_nombrea.Location = new System.Drawing.Point(190, 87);
            this.txt_nombrea.Name = "txt_nombrea";
            this.txt_nombrea.Size = new System.Drawing.Size(517, 27);
            this.txt_nombrea.TabIndex = 12;
            // 
            // v_IngreE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 290);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_Genero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_nombrea);
            this.Name = "v_IngreE";
            this.Text = "v_IngreE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_edad;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmb_Genero;
        private Label label4;
        private Label Genero;
        private Label label2;
        private Label label1;
        private TextBox txt_id;
        private TextBox txt_nombrea;
    }
}