namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class FormAdaugaRestaurant
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
            this.lblEroareStatut = new System.Windows.Forms.Label();
            this.lblEroareVarsta = new System.Windows.Forms.Label();
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
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.lblAdaugaCLient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEroareExistent
            // 
            this.lblEroareExistent.AutoSize = true;
            this.lblEroareExistent.Location = new System.Drawing.Point(322, 342);
            this.lblEroareExistent.Name = "lblEroareExistent";
            this.lblEroareExistent.Size = new System.Drawing.Size(0, 16);
            this.lblEroareExistent.TabIndex = 31;
            // 
            // lblEroareStatut
            // 
            this.lblEroareStatut.AutoSize = true;
            this.lblEroareStatut.Location = new System.Drawing.Point(359, 197);
            this.lblEroareStatut.Name = "lblEroareStatut";
            this.lblEroareStatut.Size = new System.Drawing.Size(0, 16);
            this.lblEroareStatut.TabIndex = 30;
            // 
            // lblEroareVarsta
            // 
            this.lblEroareVarsta.AutoSize = true;
            this.lblEroareVarsta.Location = new System.Drawing.Point(359, 146);
            this.lblEroareVarsta.Name = "lblEroareVarsta";
            this.lblEroareVarsta.Size = new System.Drawing.Size(0, 16);
            this.lblEroareVarsta.TabIndex = 29;
            // 
            // lblEroareNume
            // 
            this.lblEroareNume.AutoSize = true;
            this.lblEroareNume.Location = new System.Drawing.Point(356, 96);
            this.lblEroareNume.Name = "lblEroareNume";
            this.lblEroareNume.Size = new System.Drawing.Size(0, 16);
            this.lblEroareNume.TabIndex = 28;
            // 
            // btnAdauga
            // 
            this.btnAdauga.AutoSize = true;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(187, 342);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(97, 35);
            this.btnAdauga.TabIndex = 27;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.OnAdaugaClicked);
            // 
            // lblAdaugaSpecific
            // 
            this.lblAdaugaSpecific.AutoSize = true;
            this.lblAdaugaSpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaSpecific.Location = new System.Drawing.Point(61, 197);
            this.lblAdaugaSpecific.Name = "lblAdaugaSpecific";
            this.lblAdaugaSpecific.Size = new System.Drawing.Size(63, 16);
            this.lblAdaugaSpecific.TabIndex = 26;
            this.lblAdaugaSpecific.Text = "Specific";
            // 
            // lblAdaugaAn
            // 
            this.lblAdaugaAn.AutoSize = true;
            this.lblAdaugaAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaAn.Location = new System.Drawing.Point(61, 141);
            this.lblAdaugaAn.Name = "lblAdaugaAn";
            this.lblAdaugaAn.Size = new System.Drawing.Size(86, 16);
            this.lblAdaugaAn.TabIndex = 25;
            this.lblAdaugaAn.Text = "An fondator";
            // 
            // lblAdaugaDenumire
            // 
            this.lblAdaugaDenumire.AutoSize = true;
            this.lblAdaugaDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaDenumire.Location = new System.Drawing.Point(58, 96);
            this.lblAdaugaDenumire.Name = "lblAdaugaDenumire";
            this.lblAdaugaDenumire.Size = new System.Drawing.Size(73, 16);
            this.lblAdaugaDenumire.TabIndex = 24;
            this.lblAdaugaDenumire.Text = "Denumire";
            // 
            // rdbIndian
            // 
            this.rdbIndian.AutoSize = true;
            this.rdbIndian.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIndian.Location = new System.Drawing.Point(187, 302);
            this.rdbIndian.Name = "rdbIndian";
            this.rdbIndian.Size = new System.Drawing.Size(71, 23);
            this.rdbIndian.TabIndex = 23;
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
            this.rdbChinezesc.TabIndex = 22;
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
            this.rdbFastFood.TabIndex = 21;
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
            this.rdbElegant.TabIndex = 20;
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
            this.rdbTraditional.TabIndex = 19;
            this.rdbTraditional.TabStop = true;
            this.rdbTraditional.Text = "Traditional";
            this.rdbTraditional.UseVisualStyleBackColor = true;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(187, 141);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(50, 22);
            this.txtAn.TabIndex = 18;
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(187, 96);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(146, 22);
            this.txtDenumire.TabIndex = 17;
            // 
            // lblAdaugaCLient
            // 
            this.lblAdaugaCLient.AutoSize = true;
            this.lblAdaugaCLient.Font = new System.Drawing.Font("Unispace", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaCLient.Location = new System.Drawing.Point(12, 9);
            this.lblAdaugaCLient.Name = "lblAdaugaCLient";
            this.lblAdaugaCLient.Size = new System.Drawing.Size(321, 36);
            this.lblAdaugaCLient.TabIndex = 16;
            this.lblAdaugaCLient.Text = "Adaugă Restaurant";
            // 
            // FormAdaugaRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEroareExistent);
            this.Controls.Add(this.lblEroareStatut);
            this.Controls.Add(this.lblEroareVarsta);
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
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.lblAdaugaCLient);
            this.Name = "FormAdaugaRestaurant";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEroareExistent;
        private System.Windows.Forms.Label lblEroareStatut;
        private System.Windows.Forms.Label lblEroareVarsta;
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
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label lblAdaugaCLient;
    }
}