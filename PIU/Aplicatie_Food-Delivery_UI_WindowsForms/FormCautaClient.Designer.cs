namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class FormCautaClient
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblModifica = new System.Windows.Forms.Label();
            this.lblEroareStatut = new System.Windows.Forms.Label();
            this.lblEroareVarsta = new System.Windows.Forms.Label();
            this.lblEroareNume = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblAdaugaStatut = new System.Windows.Forms.Label();
            this.lblAdaugaVarsta = new System.Windows.Forms.Label();
            this.lblAdaugaNume = new System.Windows.Forms.Label();
            this.rdbPensionar = new System.Windows.Forms.RadioButton();
            this.rdbSomer = new System.Windows.Forms.RadioButton();
            this.rdbAngajat = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.rdbElev = new System.Windows.Forms.RadioButton();
            this.lblAdaugaCLient = new System.Windows.Forms.Label();
            this.cmbNume = new System.Windows.Forms.ComboBox();
            this.cmbVarsta = new System.Windows.Forms.ComboBox();
            this.lblCauta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(187, 74);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 16);
            this.lblId.TabIndex = 45;
            // 
            // lblModifica
            // 
            this.lblModifica.AutoSize = true;
            this.lblModifica.Location = new System.Drawing.Point(338, 348);
            this.lblModifica.Name = "lblModifica";
            this.lblModifica.Size = new System.Drawing.Size(0, 16);
            this.lblModifica.TabIndex = 44;
            // 
            // lblEroareStatut
            // 
            this.lblEroareStatut.AutoSize = true;
            this.lblEroareStatut.Location = new System.Drawing.Point(335, 196);
            this.lblEroareStatut.Name = "lblEroareStatut";
            this.lblEroareStatut.Size = new System.Drawing.Size(0, 16);
            this.lblEroareStatut.TabIndex = 43;
            // 
            // lblEroareVarsta
            // 
            this.lblEroareVarsta.AutoSize = true;
            this.lblEroareVarsta.Location = new System.Drawing.Point(335, 146);
            this.lblEroareVarsta.Name = "lblEroareVarsta";
            this.lblEroareVarsta.Size = new System.Drawing.Size(0, 16);
            this.lblEroareVarsta.TabIndex = 42;
            // 
            // lblEroareNume
            // 
            this.lblEroareNume.AutoSize = true;
            this.lblEroareNume.Location = new System.Drawing.Point(332, 101);
            this.lblEroareNume.Name = "lblEroareNume";
            this.lblEroareNume.Size = new System.Drawing.Size(0, 16);
            this.lblEroareNume.TabIndex = 41;
            // 
            // btnAdauga
            // 
            this.btnAdauga.AutoSize = true;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(187, 342);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(80, 35);
            this.btnAdauga.TabIndex = 40;
            this.btnAdauga.Text = "Caută";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.OnBtnCautaClicked);
            // 
            // lblAdaugaStatut
            // 
            this.lblAdaugaStatut.AutoSize = true;
            this.lblAdaugaStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaStatut.Location = new System.Drawing.Point(38, 196);
            this.lblAdaugaStatut.Name = "lblAdaugaStatut";
            this.lblAdaugaStatut.Size = new System.Drawing.Size(92, 16);
            this.lblAdaugaStatut.TabIndex = 39;
            this.lblAdaugaStatut.Text = "Statut social";
            // 
            // lblAdaugaVarsta
            // 
            this.lblAdaugaVarsta.AutoSize = true;
            this.lblAdaugaVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaVarsta.Location = new System.Drawing.Point(38, 141);
            this.lblAdaugaVarsta.Name = "lblAdaugaVarsta";
            this.lblAdaugaVarsta.Size = new System.Drawing.Size(52, 16);
            this.lblAdaugaVarsta.TabIndex = 38;
            this.lblAdaugaVarsta.Text = "Varsta";
            // 
            // lblAdaugaNume
            // 
            this.lblAdaugaNume.AutoSize = true;
            this.lblAdaugaNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaNume.Location = new System.Drawing.Point(38, 96);
            this.lblAdaugaNume.Name = "lblAdaugaNume";
            this.lblAdaugaNume.Size = new System.Drawing.Size(127, 16);
            this.lblAdaugaNume.TabIndex = 37;
            this.lblAdaugaNume.Text = "Nume si prenume";
            // 
            // rdbPensionar
            // 
            this.rdbPensionar.AutoSize = true;
            this.rdbPensionar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPensionar.Location = new System.Drawing.Point(187, 302);
            this.rdbPensionar.Name = "rdbPensionar";
            this.rdbPensionar.Size = new System.Drawing.Size(96, 23);
            this.rdbPensionar.TabIndex = 36;
            this.rdbPensionar.TabStop = true;
            this.rdbPensionar.Text = "Pensionar";
            this.rdbPensionar.UseVisualStyleBackColor = true;
            // 
            // rdbSomer
            // 
            this.rdbSomer.AutoSize = true;
            this.rdbSomer.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSomer.Location = new System.Drawing.Point(187, 275);
            this.rdbSomer.Name = "rdbSomer";
            this.rdbSomer.Size = new System.Drawing.Size(74, 23);
            this.rdbSomer.TabIndex = 35;
            this.rdbSomer.TabStop = true;
            this.rdbSomer.Text = "Somer";
            this.rdbSomer.UseVisualStyleBackColor = true;
            // 
            // rdbAngajat
            // 
            this.rdbAngajat.AutoSize = true;
            this.rdbAngajat.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAngajat.Location = new System.Drawing.Point(187, 248);
            this.rdbAngajat.Name = "rdbAngajat";
            this.rdbAngajat.Size = new System.Drawing.Size(82, 23);
            this.rdbAngajat.TabIndex = 34;
            this.rdbAngajat.TabStop = true;
            this.rdbAngajat.Text = "Angajat";
            this.rdbAngajat.UseVisualStyleBackColor = true;
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStudent.Location = new System.Drawing.Point(187, 221);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(81, 23);
            this.rdbStudent.TabIndex = 33;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "Student";
            this.rdbStudent.UseVisualStyleBackColor = true;
            // 
            // rdbElev
            // 
            this.rdbElev.AutoSize = true;
            this.rdbElev.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElev.Location = new System.Drawing.Point(187, 194);
            this.rdbElev.Name = "rdbElev";
            this.rdbElev.Size = new System.Drawing.Size(57, 23);
            this.rdbElev.TabIndex = 32;
            this.rdbElev.TabStop = true;
            this.rdbElev.Text = "Elev";
            this.rdbElev.UseVisualStyleBackColor = true;
            // 
            // lblAdaugaCLient
            // 
            this.lblAdaugaCLient.AutoSize = true;
            this.lblAdaugaCLient.Font = new System.Drawing.Font("Unispace", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaCLient.Location = new System.Drawing.Point(12, 9);
            this.lblAdaugaCLient.Name = "lblAdaugaCLient";
            this.lblAdaugaCLient.Size = new System.Drawing.Size(231, 36);
            this.lblAdaugaCLient.TabIndex = 29;
            this.lblAdaugaCLient.Text = "Caută Client";
            // 
            // cmbNume
            // 
            this.cmbNume.FormattingEnabled = true;
            this.cmbNume.Location = new System.Drawing.Point(187, 93);
            this.cmbNume.Name = "cmbNume";
            this.cmbNume.Size = new System.Drawing.Size(151, 24);
            this.cmbNume.TabIndex = 46;
            // 
            // cmbVarsta
            // 
            this.cmbVarsta.FormattingEnabled = true;
            this.cmbVarsta.Location = new System.Drawing.Point(187, 141);
            this.cmbVarsta.Name = "cmbVarsta";
            this.cmbVarsta.Size = new System.Drawing.Size(55, 24);
            this.cmbVarsta.TabIndex = 47;
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.Location = new System.Drawing.Point(335, 342);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(0, 16);
            this.lblCauta.TabIndex = 48;
            // 
            // FormCautaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCauta);
            this.Controls.Add(this.cmbVarsta);
            this.Controls.Add(this.cmbNume);
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
            this.Controls.Add(this.lblAdaugaCLient);
            this.Name = "FormCautaClient";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCautaClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblModifica;
        private System.Windows.Forms.Label lblEroareStatut;
        private System.Windows.Forms.Label lblEroareVarsta;
        private System.Windows.Forms.Label lblEroareNume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblAdaugaStatut;
        private System.Windows.Forms.Label lblAdaugaVarsta;
        private System.Windows.Forms.Label lblAdaugaNume;
        private System.Windows.Forms.RadioButton rdbPensionar;
        private System.Windows.Forms.RadioButton rdbSomer;
        private System.Windows.Forms.RadioButton rdbAngajat;
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.RadioButton rdbElev;
        private System.Windows.Forms.Label lblAdaugaCLient;
        private System.Windows.Forms.ComboBox cmbNume;
        private System.Windows.Forms.ComboBox cmbVarsta;
        private System.Windows.Forms.Label lblCauta;
    }
}