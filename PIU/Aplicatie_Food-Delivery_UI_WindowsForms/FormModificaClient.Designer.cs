namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class FormModificaClient
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblAdaugaStatut = new System.Windows.Forms.Label();
            this.lblAdaugaVarsta = new System.Windows.Forms.Label();
            this.lblAdaugaNume = new System.Windows.Forms.Label();
            this.rdbPensionar = new System.Windows.Forms.RadioButton();
            this.rdbSomer = new System.Windows.Forms.RadioButton();
            this.rdbAngajat = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.rdbElev = new System.Windows.Forms.RadioButton();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblAdaugaCLient = new System.Windows.Forms.Label();
            this.lblEroareNume = new System.Windows.Forms.Label();
            this.lblEroareVarsta = new System.Windows.Forms.Label();
            this.lblEroareStatut = new System.Windows.Forms.Label();
            this.lblModifica = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblID1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.AutoSize = true;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(187, 357);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(103, 35);
            this.btnAdauga.TabIndex = 23;
            this.btnAdauga.Text = "Modifică";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnModificaClicked);
            // 
            // lblAdaugaStatut
            // 
            this.lblAdaugaStatut.AutoSize = true;
            this.lblAdaugaStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaStatut.Location = new System.Drawing.Point(26, 213);
            this.lblAdaugaStatut.Name = "lblAdaugaStatut";
            this.lblAdaugaStatut.Size = new System.Drawing.Size(92, 16);
            this.lblAdaugaStatut.TabIndex = 22;
            this.lblAdaugaStatut.Text = "Statut social";
            // 
            // lblAdaugaVarsta
            // 
            this.lblAdaugaVarsta.AutoSize = true;
            this.lblAdaugaVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaVarsta.Location = new System.Drawing.Point(26, 156);
            this.lblAdaugaVarsta.Name = "lblAdaugaVarsta";
            this.lblAdaugaVarsta.Size = new System.Drawing.Size(52, 16);
            this.lblAdaugaVarsta.TabIndex = 21;
            this.lblAdaugaVarsta.Text = "Varsta";
            // 
            // lblAdaugaNume
            // 
            this.lblAdaugaNume.AutoSize = true;
            this.lblAdaugaNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaNume.Location = new System.Drawing.Point(26, 111);
            this.lblAdaugaNume.Name = "lblAdaugaNume";
            this.lblAdaugaNume.Size = new System.Drawing.Size(127, 16);
            this.lblAdaugaNume.TabIndex = 20;
            this.lblAdaugaNume.Text = "Nume si prenume";
            // 
            // rdbPensionar
            // 
            this.rdbPensionar.AutoSize = true;
            this.rdbPensionar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPensionar.Location = new System.Drawing.Point(187, 317);
            this.rdbPensionar.Name = "rdbPensionar";
            this.rdbPensionar.Size = new System.Drawing.Size(96, 23);
            this.rdbPensionar.TabIndex = 19;
            this.rdbPensionar.TabStop = true;
            this.rdbPensionar.Text = "Pensionar";
            this.rdbPensionar.UseVisualStyleBackColor = true;
            // 
            // rdbSomer
            // 
            this.rdbSomer.AutoSize = true;
            this.rdbSomer.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSomer.Location = new System.Drawing.Point(187, 290);
            this.rdbSomer.Name = "rdbSomer";
            this.rdbSomer.Size = new System.Drawing.Size(74, 23);
            this.rdbSomer.TabIndex = 18;
            this.rdbSomer.TabStop = true;
            this.rdbSomer.Text = "Somer";
            this.rdbSomer.UseVisualStyleBackColor = true;
            // 
            // rdbAngajat
            // 
            this.rdbAngajat.AutoSize = true;
            this.rdbAngajat.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAngajat.Location = new System.Drawing.Point(187, 263);
            this.rdbAngajat.Name = "rdbAngajat";
            this.rdbAngajat.Size = new System.Drawing.Size(82, 23);
            this.rdbAngajat.TabIndex = 17;
            this.rdbAngajat.TabStop = true;
            this.rdbAngajat.Text = "Angajat";
            this.rdbAngajat.UseVisualStyleBackColor = true;
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStudent.Location = new System.Drawing.Point(187, 236);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(81, 23);
            this.rdbStudent.TabIndex = 16;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "Student";
            this.rdbStudent.UseVisualStyleBackColor = true;
            // 
            // rdbElev
            // 
            this.rdbElev.AutoSize = true;
            this.rdbElev.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElev.Location = new System.Drawing.Point(187, 209);
            this.rdbElev.Name = "rdbElev";
            this.rdbElev.Size = new System.Drawing.Size(57, 23);
            this.rdbElev.TabIndex = 15;
            this.rdbElev.TabStop = true;
            this.rdbElev.Text = "Elev";
            this.rdbElev.UseVisualStyleBackColor = true;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(187, 156);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(100, 22);
            this.txtVarsta.TabIndex = 14;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(187, 111);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 13;
            // 
            // lblAdaugaCLient
            // 
            this.lblAdaugaCLient.AutoSize = true;
            this.lblAdaugaCLient.Font = new System.Drawing.Font("Unispace", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaCLient.Location = new System.Drawing.Point(12, 24);
            this.lblAdaugaCLient.Name = "lblAdaugaCLient";
            this.lblAdaugaCLient.Size = new System.Drawing.Size(285, 36);
            this.lblAdaugaCLient.TabIndex = 12;
            this.lblAdaugaCLient.Text = "Modifică Client";
            // 
            // lblEroareNume
            // 
            this.lblEroareNume.AutoSize = true;
            this.lblEroareNume.Location = new System.Drawing.Point(332, 116);
            this.lblEroareNume.Name = "lblEroareNume";
            this.lblEroareNume.Size = new System.Drawing.Size(0, 16);
            this.lblEroareNume.TabIndex = 24;
            // 
            // lblEroareVarsta
            // 
            this.lblEroareVarsta.AutoSize = true;
            this.lblEroareVarsta.Location = new System.Drawing.Point(335, 161);
            this.lblEroareVarsta.Name = "lblEroareVarsta";
            this.lblEroareVarsta.Size = new System.Drawing.Size(0, 16);
            this.lblEroareVarsta.TabIndex = 25;
            // 
            // lblEroareStatut
            // 
            this.lblEroareStatut.AutoSize = true;
            this.lblEroareStatut.Location = new System.Drawing.Point(335, 211);
            this.lblEroareStatut.Name = "lblEroareStatut";
            this.lblEroareStatut.Size = new System.Drawing.Size(0, 16);
            this.lblEroareStatut.TabIndex = 26;
            // 
            // lblModifica
            // 
            this.lblModifica.AutoSize = true;
            this.lblModifica.Location = new System.Drawing.Point(338, 363);
            this.lblModifica.Name = "lblModifica";
            this.lblModifica.Size = new System.Drawing.Size(0, 16);
            this.lblModifica.TabIndex = 27;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(187, 89);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 28;
            // 
            // lblID1
            // 
            this.lblID1.AutoSize = true;
            this.lblID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID1.Location = new System.Drawing.Point(26, 89);
            this.lblID1.Name = "lblID1";
            this.lblID1.Size = new System.Drawing.Size(22, 16);
            this.lblID1.TabIndex = 29;
            this.lblID1.Text = "ID";
            // 
            // FormModificaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblID1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblModifica);
            this.Controls.Add(this.lblEroareStatut);
            this.Controls.Add(this.lblEroareVarsta);
            this.Controls.Add(this.lblEroareNume);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblAdaugaStatut);
            this.Controls.Add(this.lblAdaugaVarsta);
            this.Controls.Add(this.lblAdaugaNume);
            this.Controls.Add(this.rdbPensionar);
            this.Controls.Add(this.rdbSomer);
            this.Controls.Add(this.rdbAngajat);
            this.Controls.Add(this.rdbStudent);
            this.Controls.Add(this.rdbElev);
            this.Controls.Add(this.txtVarsta);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblAdaugaCLient);
            this.Name = "FormModificaClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblAdaugaStatut;
        private System.Windows.Forms.Label lblAdaugaVarsta;
        private System.Windows.Forms.Label lblAdaugaNume;
        private System.Windows.Forms.RadioButton rdbPensionar;
        private System.Windows.Forms.RadioButton rdbSomer;
        private System.Windows.Forms.RadioButton rdbAngajat;
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.RadioButton rdbElev;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblAdaugaCLient;
        private System.Windows.Forms.Label lblEroareNume;
        private System.Windows.Forms.Label lblEroareVarsta;
        private System.Windows.Forms.Label lblEroareStatut;
        private System.Windows.Forms.Label lblModifica;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblID1;
    }
}