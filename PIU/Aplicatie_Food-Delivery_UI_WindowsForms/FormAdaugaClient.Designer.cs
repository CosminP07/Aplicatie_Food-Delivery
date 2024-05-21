namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class FormAdaugaClient
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
            this.lblAdaugaCLient = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.rdbElev = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.rdbAngajat = new System.Windows.Forms.RadioButton();
            this.rdbSomer = new System.Windows.Forms.RadioButton();
            this.rdbPensionar = new System.Windows.Forms.RadioButton();
            this.lblAdaugaNume = new System.Windows.Forms.Label();
            this.lblAdaugaVarsta = new System.Windows.Forms.Label();
            this.lblAdaugaStatut = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblEroareNume = new System.Windows.Forms.Label();
            this.lblEroareVarsta = new System.Windows.Forms.Label();
            this.lblEroareStatut = new System.Windows.Forms.Label();
            this.lblEroareExistent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdaugaCLient
            // 
            this.lblAdaugaCLient.AutoSize = true;
            this.lblAdaugaCLient.Font = new System.Drawing.Font("Unispace", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaCLient.Location = new System.Drawing.Point(13, 13);
            this.lblAdaugaCLient.Name = "lblAdaugaCLient";
            this.lblAdaugaCLient.Size = new System.Drawing.Size(249, 36);
            this.lblAdaugaCLient.TabIndex = 0;
            this.lblAdaugaCLient.Text = "Adaugă Client";
            this.lblAdaugaCLient.Click += new System.EventHandler(this.lblAdaugaCLient_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(188, 100);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(163, 22);
            this.txtNume.TabIndex = 1;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(188, 145);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(29, 22);
            this.txtVarsta.TabIndex = 2;
            // 
            // rdbElev
            // 
            this.rdbElev.AutoSize = true;
            this.rdbElev.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElev.Location = new System.Drawing.Point(188, 198);
            this.rdbElev.Name = "rdbElev";
            this.rdbElev.Size = new System.Drawing.Size(57, 23);
            this.rdbElev.TabIndex = 3;
            this.rdbElev.TabStop = true;
            this.rdbElev.Text = "Elev";
            this.rdbElev.UseVisualStyleBackColor = true;
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStudent.Location = new System.Drawing.Point(188, 225);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(81, 23);
            this.rdbStudent.TabIndex = 4;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "Student";
            this.rdbStudent.UseVisualStyleBackColor = true;
            // 
            // rdbAngajat
            // 
            this.rdbAngajat.AutoSize = true;
            this.rdbAngajat.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAngajat.Location = new System.Drawing.Point(188, 252);
            this.rdbAngajat.Name = "rdbAngajat";
            this.rdbAngajat.Size = new System.Drawing.Size(82, 23);
            this.rdbAngajat.TabIndex = 5;
            this.rdbAngajat.TabStop = true;
            this.rdbAngajat.Text = "Angajat";
            this.rdbAngajat.UseVisualStyleBackColor = true;
            // 
            // rdbSomer
            // 
            this.rdbSomer.AutoSize = true;
            this.rdbSomer.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSomer.Location = new System.Drawing.Point(188, 279);
            this.rdbSomer.Name = "rdbSomer";
            this.rdbSomer.Size = new System.Drawing.Size(74, 23);
            this.rdbSomer.TabIndex = 6;
            this.rdbSomer.TabStop = true;
            this.rdbSomer.Text = "Somer";
            this.rdbSomer.UseVisualStyleBackColor = true;
            // 
            // rdbPensionar
            // 
            this.rdbPensionar.AutoSize = true;
            this.rdbPensionar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPensionar.Location = new System.Drawing.Point(188, 306);
            this.rdbPensionar.Name = "rdbPensionar";
            this.rdbPensionar.Size = new System.Drawing.Size(96, 23);
            this.rdbPensionar.TabIndex = 7;
            this.rdbPensionar.TabStop = true;
            this.rdbPensionar.Text = "Pensionar";
            this.rdbPensionar.UseVisualStyleBackColor = true;
            // 
            // lblAdaugaNume
            // 
            this.lblAdaugaNume.AutoSize = true;
            this.lblAdaugaNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaNume.Location = new System.Drawing.Point(41, 100);
            this.lblAdaugaNume.Name = "lblAdaugaNume";
            this.lblAdaugaNume.Size = new System.Drawing.Size(127, 16);
            this.lblAdaugaNume.TabIndex = 8;
            this.lblAdaugaNume.Text = "Nume si prenume";
            // 
            // lblAdaugaVarsta
            // 
            this.lblAdaugaVarsta.AutoSize = true;
            this.lblAdaugaVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaVarsta.Location = new System.Drawing.Point(41, 145);
            this.lblAdaugaVarsta.Name = "lblAdaugaVarsta";
            this.lblAdaugaVarsta.Size = new System.Drawing.Size(52, 16);
            this.lblAdaugaVarsta.TabIndex = 9;
            this.lblAdaugaVarsta.Text = "Vârsta";
            // 
            // lblAdaugaStatut
            // 
            this.lblAdaugaStatut.AutoSize = true;
            this.lblAdaugaStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaStatut.Location = new System.Drawing.Point(41, 202);
            this.lblAdaugaStatut.Name = "lblAdaugaStatut";
            this.lblAdaugaStatut.Size = new System.Drawing.Size(92, 16);
            this.lblAdaugaStatut.TabIndex = 10;
            this.lblAdaugaStatut.Text = "Statut social";
            // 
            // btnAdauga
            // 
            this.btnAdauga.AutoSize = true;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(188, 346);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(97, 35);
            this.btnAdauga.TabIndex = 11;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.OnAdaugaClicked);
            // 
            // lblEroareNume
            // 
            this.lblEroareNume.AutoSize = true;
            this.lblEroareNume.Location = new System.Drawing.Point(357, 100);
            this.lblEroareNume.Name = "lblEroareNume";
            this.lblEroareNume.Size = new System.Drawing.Size(0, 16);
            this.lblEroareNume.TabIndex = 12;
            // 
            // lblEroareVarsta
            // 
            this.lblEroareVarsta.AutoSize = true;
            this.lblEroareVarsta.Location = new System.Drawing.Point(360, 150);
            this.lblEroareVarsta.Name = "lblEroareVarsta";
            this.lblEroareVarsta.Size = new System.Drawing.Size(0, 16);
            this.lblEroareVarsta.TabIndex = 13;
            // 
            // lblEroareStatut
            // 
            this.lblEroareStatut.AutoSize = true;
            this.lblEroareStatut.Location = new System.Drawing.Point(360, 201);
            this.lblEroareStatut.Name = "lblEroareStatut";
            this.lblEroareStatut.Size = new System.Drawing.Size(0, 16);
            this.lblEroareStatut.TabIndex = 14;
            // 
            // lblEroareExistent
            // 
            this.lblEroareExistent.AutoSize = true;
            this.lblEroareExistent.Location = new System.Drawing.Point(323, 346);
            this.lblEroareExistent.Name = "lblEroareExistent";
            this.lblEroareExistent.Size = new System.Drawing.Size(0, 16);
            this.lblEroareExistent.TabIndex = 15;
            // 
            // FormAdaugaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEroareExistent);
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
            this.Name = "FormAdaugaClient";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdaugaCLient;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.RadioButton rdbElev;
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.RadioButton rdbAngajat;
        private System.Windows.Forms.RadioButton rdbSomer;
        private System.Windows.Forms.RadioButton rdbPensionar;
        private System.Windows.Forms.Label lblAdaugaNume;
        private System.Windows.Forms.Label lblAdaugaVarsta;
        private System.Windows.Forms.Label lblAdaugaStatut;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblEroareNume;
        private System.Windows.Forms.Label lblEroareVarsta;
        private System.Windows.Forms.Label lblEroareStatut;
        private System.Windows.Forms.Label lblEroareExistent;
    }
}