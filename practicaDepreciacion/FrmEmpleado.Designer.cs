namespace practicaDepreciacion
{
    partial class FrmEmpleado
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
            this.btnEmpleadoEnv = new System.Windows.Forms.Button();
            this.bntEmpleadoUp = new System.Windows.Forms.Button();
            this.dataEmpleado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbEmpleadoEst = new System.Windows.Forms.ComboBox();
            this.btnEmpleadoDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpleadoEnv
            // 
            this.btnEmpleadoEnv.Location = new System.Drawing.Point(12, 456);
            this.btnEmpleadoEnv.Name = "btnEmpleadoEnv";
            this.btnEmpleadoEnv.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleadoEnv.TabIndex = 0;
            this.btnEmpleadoEnv.Text = "Enviar";
            this.btnEmpleadoEnv.UseVisualStyleBackColor = true;
            this.btnEmpleadoEnv.Click += new System.EventHandler(this.BtnEmpleadoEnv_Click);
            // 
            // bntEmpleadoUp
            // 
            this.bntEmpleadoUp.Location = new System.Drawing.Point(117, 456);
            this.bntEmpleadoUp.Name = "bntEmpleadoUp";
            this.bntEmpleadoUp.Size = new System.Drawing.Size(75, 23);
            this.bntEmpleadoUp.TabIndex = 1;
            this.bntEmpleadoUp.Text = "Modificar";
            this.bntEmpleadoUp.UseVisualStyleBackColor = true;
            // 
            // dataEmpleado
            // 
            this.dataEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleado.Location = new System.Drawing.Point(360, 12);
            this.dataEmpleado.Name = "dataEmpleado";
            this.dataEmpleado.Size = new System.Drawing.Size(587, 418);
            this.dataEmpleado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-mail";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 20);
            this.txtName.TabIndex = 9;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(83, 84);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(247, 20);
            this.txtApellidos.TabIndex = 10;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidos_KeyPress);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(83, 146);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(247, 55);
            this.txtAdress.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(83, 219);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(247, 20);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(83, 252);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // cmbEmpleadoEst
            // 
            this.cmbEmpleadoEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleadoEst.FormattingEnabled = true;
            this.cmbEmpleadoEst.Items.AddRange(new object[] {
            "Enfermo",
            "Disponible"});
            this.cmbEmpleadoEst.Location = new System.Drawing.Point(83, 283);
            this.cmbEmpleadoEst.Name = "cmbEmpleadoEst";
            this.cmbEmpleadoEst.Size = new System.Drawing.Size(247, 21);
            this.cmbEmpleadoEst.TabIndex = 14;
            this.cmbEmpleadoEst.SelectedIndexChanged += new System.EventHandler(this.CmbEmpeadoEst_SelectedIndexChanged);
            // 
            // btnEmpleadoDel
            // 
            this.btnEmpleadoDel.Location = new System.Drawing.Point(217, 456);
            this.btnEmpleadoDel.Name = "btnEmpleadoDel";
            this.btnEmpleadoDel.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleadoDel.TabIndex = 15;
            this.btnEmpleadoDel.Text = "Eliminar";
            this.btnEmpleadoDel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::practicaDepreciacion.Properties.Resources.konosuba_aqua;
            this.pictureBox1.Location = new System.Drawing.Point(106, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cedula";
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(83, 117);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(247, 20);
            this.txtCed.TabIndex = 18;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 493);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEmpleadoDel);
            this.Controls.Add(this.cmbEmpleadoEst);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataEmpleado);
            this.Controls.Add(this.bntEmpleadoUp);
            this.Controls.Add(this.btnEmpleadoEnv);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleadoEnv;
        private System.Windows.Forms.Button bntEmpleadoUp;
        private System.Windows.Forms.DataGridView dataEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbEmpleadoEst;
        private System.Windows.Forms.Button btnEmpleadoDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCed;
    }
}