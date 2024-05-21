namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class FormCautaRestaurant
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
            this.lblEroareExistent = new System.Windows.Forms.Label();
            this.lblEroareNume = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblAdaugaSpecific = new System.Windows.Forms.Label();
            this.lblAdaugaAn = new System.Windows.Forms.Label();
            this.lblAdaugaDenumire = new System.Windows.Forms.Label();
            this.rdbIndian = new System.Windows.Forms.RadioButton();
            this.rdbChinezesc = new System.Windows.Forms.RadioButton();
            this.rdbFastFood = new System.Windows.Forms.RadioButton();
            this.rdbElegant = new System.Windows.Forms.RadioButton();
            this.rdbTraditional = new System.Windows.Forms.RadioButton();
            this.lblAdaugaCLient = new System.Windows.Forms.Label();
            this.cmbDenumire = new System.Windows.Forms.ComboBox();
            this.cmbAn = new System.Windows.Forms.ComboBox();
            this.lblCauta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEroareExistent
            // 
            this.lblEroareExistent.AutoSize = true;
            this.lblEroareExistent.Location = new System.Drawing.Point(322, 342);
            this.lblEroareExistent.Name = "lblEroareExistent";
            this.lblEroareExistent.Size = new System.Drawing.Size(0, 16);
            this.lblEroareExistent.TabIndex = 45;
            // 
            // lblEroareNume
            // 
            this.lblEroareNume.AutoSize = true;
            this.lblEroareNume.Location = new System.Drawing.Point(356, 96);
            this.lblEroareNume.Name = "lblEroareNume";
            this.lblEroareNume.Size = new System.Drawing.Size(0, 16);
            this.lblEroareNume.TabIndex = 44;
            // 
            // btnAdauga
            // 
            this.btnAdauga.AutoSize = true;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(187, 342);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(80, 35);
            this.btnAdauga.TabIndex = 43;
            this.btnAdauga.Text = "Caută";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.OnBtnCautaClicked);
            // 
            // lblAdaugaSpecific
            // 
            this.lblAdaugaSpecific.AutoSize = true;
            this.lblAdaugaSpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaSpecific.Location = new System.Drawing.Point(61, 197);
            this.lblAdaugaSpecific.Name = "lblAdaugaSpecific";
            this.lblAdaugaSpecific.Size = new System.Drawing.Size(63, 16);
            this.lblAdaugaSpecific.TabIndex = 42;
            this.lblAdaugaSpecific.Text = "Specific";
            // 
            // lblAdaugaAn
            // 
            this.lblAdaugaAn.AutoSize = true;
            this.lblAdaugaAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaAn.Location = new System.Drawing.Point(61, 141);
            this.lblAdaugaAn.Name = "lblAdaugaAn";
            this.lblAdaugaAn.Size = new System.Drawing.Size(86, 16);
            this.lblAdaugaAn.TabIndex = 41;
            this.lblAdaugaAn.Text = "An fondator";
            // 
            // lblAdaugaDenumire
            // 
            this.lblAdaugaDenumire.AutoSize = true;
            this.lblAdaugaDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaDenumire.Location = new System.Drawing.Point(58, 96);
            this.lblAdaugaDenumire.Name = "lblAdaugaDenumire";
            this.lblAdaugaDenumire.Size = new System.Drawing.Size(73, 16);
            this.lblAdaugaDenumire.TabIndex = 40;
            this.lblAdaugaDenumire.Text = "Denumire";
            // 
            // rdbIndian
            // 
            this.rdbIndian.AutoSize = true;
            this.rdbIndian.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIndian.Location = new System.Drawing.Point(187, 302);
            this.rdbIndian.Name = "rdbIndian";
            this.rdbIndian.Size = new System.Drawing.Size(71, 23);
            this.rdbIndian.TabIndex = 39;
            this.rdbIndian.TabStop = true;
            this.rdbIndian.Text = "Indian";
            this.rdbIndian.UseVisualStyleBackColor = true;
            // 
            // rdbChinezesc
            // 
            this.rdbChinezesc.AutoSize = true;
            this.rdbChinezesc.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChinezesc.Location = new System.Drawing.Point(187, 275);
            this.rdbChinezesc.Name = "rdbChinezesc";
            this.rdbChinezesc.Size = new System.Drawing.Size(95, 23);
            this.rdbChinezesc.TabIndex = 38;
            this.rdbChinezesc.TabStop = true;
            this.rdbChinezesc.Text = "Chinezesc";
            this.rdbChinezesc.UseVisualStyleBackColor = true;
            // 
            // rdbFastFood
            // 
            this.rdbFastFood.AutoSize = true;
            this.rdbFastFood.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFastFood.Location = new System.Drawing.Point(187, 248);
            this.rdbFastFood.Name = "rdbFastFood";
            this.rdbFastFood.Size = new System.Drawing.Size(90, 23);
            this.rdbFastFood.TabIndex = 37;
            this.rdbFastFood.TabStop = true;
            this.rdbFastFood.Text = "FastFood";
            this.rdbFastFood.UseVisualStyleBackColor = true;
            // 
            // rdbElegant
            // 
            this.rdbElegant.AutoSize = true;
            this.rdbElegant.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElegant.Location = new System.Drawing.Point(187, 221);
            this.rdbElegant.Name = "rdbElegant";
            this.rdbElegant.Size = new System.Drawing.Size(79, 23);
            this.rdbElegant.TabIndex = 36;
            this.rdbElegant.TabStop = true;
            this.rdbElegant.Text = "Elegant";
            this.rdbElegant.UseVisualStyleBackColor = true;
            // 
            // rdbTraditional
            // 
            this.rdbTraditional.AutoSize = true;
            this.rdbTraditional.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTraditional.Location = new System.Drawing.Point(187, 194);
            this.rdbTraditional.Name = "rdbTraditional";
            this.rdbTraditional.Size = new System.Drawing.Size(103, 23);
            this.rdbTraditional.TabIndex = 35;
            this.rdbTraditional.TabStop = true;
            this.rdbTraditional.Text = "Traditional";
            this.rdbTraditional.UseVisualStyleBackColor = true;
            // 
            // lblAdaugaCLient
            // 
            this.lblAdaugaCLient.AutoSize = true;
            this.lblAdaugaCLient.Font = new System.Drawing.Font("Unispace", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaCLient.Location = new System.Drawing.Point(12, 9);
            this.lblAdaugaCLient.Name = "lblAdaugaCLient";
            this.lblAdaugaCLient.Size = new System.Drawing.Size(303, 36);
            this.lblAdaugaCLient.TabIndex = 32;
            this.lblAdaugaCLient.Text = "Caută Restaurant";
            // 
            // cmbDenumire
            // 
            this.cmbDenumire.FormattingEnabled = true;
            this.cmbDenumire.Location = new System.Drawing.Point(187, 96);
            this.cmbDenumire.Name = "cmbDenumire";
            this.cmbDenumire.Size = new System.Drawing.Size(151, 24);
            this.cmbDenumire.TabIndex = 46;
            // 
            // cmbAn
            // 
            this.cmbAn.FormattingEnabled = true;
            this.cmbAn.Location = new System.Drawing.Point(187, 141);
            this.cmbAn.Name = "cmbAn";
            this.cmbAn.Size = new System.Drawing.Size(64, 24);
            this.cmbAn.TabIndex = 47;
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.Location = new System.Drawing.Point(325, 342);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(0, 16);
            this.lblCauta.TabIndex = 48;
            // 
            // FormCautaRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCauta);
            this.Controls.Add(this.cmbAn);
            this.Controls.Add(this.cmbDenumire);
            this.Controls.Add(this.lblEroareExistent);
            this.Controls.Add(this.lblEroareNume);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblAdaugaSpecific);
            this.Controls.Add(this.lblAdaugaAn);
            this.Controls.Add(this.lblAdaugaDenumire);
            this.Controls.Add(this.rdbIndian);
            this.Controls.Add(this.rdbChinezesc);
            this.Controls.Add(this.rdbFastFood);
            this.Controls.Add(this.rdbElegant);
            this.Controls.Add(this.rdbTraditional);
            this.Controls.Add(this.lblAdaugaCLient);
            this.Name = "FormCautaRestaurant";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEroareExistent;
        private System.Windows.Forms.Label lblEroareNume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblAdaugaSpecific;
        private System.Windows.Forms.Label lblAdaugaAn;
        private System.Windows.Forms.Label lblAdaugaDenumire;
        private System.Windows.Forms.RadioButton rdbIndian;
        private System.Windows.Forms.RadioButton rdbChinezesc;
        private System.Windows.Forms.RadioButton rdbFastFood;
        private System.Windows.Forms.RadioButton rdbElegant;
        private System.Windows.Forms.RadioButton rdbTraditional;
        private System.Windows.Forms.Label lblAdaugaCLient;
        private System.Windows.Forms.ComboBox cmbDenumire;
        private System.Windows.Forms.ComboBox cmbAn;
        private System.Windows.Forms.Label lblCauta;
    }
}