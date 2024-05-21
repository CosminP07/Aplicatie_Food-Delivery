namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class FormClienti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCautare1 = new System.Windows.Forms.Label();
            this.lblCautare2 = new System.Windows.Forms.Label();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnAdaugaClient = new System.Windows.Forms.Button();
            this.btnModificaClient = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.btnSorteaza = new System.Windows.Forms.Button();
            this.btnCautaClient = new System.Windows.Forms.Button();
            this.btnStergeClient = new System.Windows.Forms.Button();
            this.lblClienti = new System.Windows.Forms.Label();
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.lstClienti = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCautare1
            // 
            this.lblCautare1.AutoSize = true;
            this.lblCautare1.Location = new System.Drawing.Point(593, 445);
            this.lblCautare1.Name = "lblCautare1";
            this.lblCautare1.Size = new System.Drawing.Size(0, 16);
            this.lblCautare1.TabIndex = 2;
            // 
            // lblCautare2
            // 
            this.lblCautare2.AutoSize = true;
            this.lblCautare2.Location = new System.Drawing.Point(714, 445);
            this.lblCautare2.Name = "lblCautare2";
            this.lblCautare2.Size = new System.Drawing.Size(0, 16);
            this.lblCautare2.TabIndex = 3;
            // 
            // btnInapoi
            // 
            this.btnInapoi.AutoSize = true;
            this.btnInapoi.Location = new System.Drawing.Point(13, 385);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(154, 26);
            this.btnInapoi.TabIndex = 4;
            this.btnInapoi.Text = "Înapoi la meniu";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnAdaugaClient
            // 
            this.btnAdaugaClient.AutoSize = true;
            this.btnAdaugaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaClient.Location = new System.Drawing.Point(13, 84);
            this.btnAdaugaClient.Name = "btnAdaugaClient";
            this.btnAdaugaClient.Size = new System.Drawing.Size(154, 35);
            this.btnAdaugaClient.TabIndex = 5;
            this.btnAdaugaClient.Text = "Adaugă client";
            this.btnAdaugaClient.UseVisualStyleBackColor = true;
            this.btnAdaugaClient.Click += new System.EventHandler(this.btnAdaugaClient_Click);
            // 
            // btnModificaClient
            // 
            this.btnModificaClient.AutoSize = true;
            this.btnModificaClient.Location = new System.Drawing.Point(13, 129);
            this.btnModificaClient.Name = "btnModificaClient";
            this.btnModificaClient.Size = new System.Drawing.Size(154, 26);
            this.btnModificaClient.TabIndex = 6;
            this.btnModificaClient.Text = "Modifică client";
            this.btnModificaClient.UseVisualStyleBackColor = true;
            this.btnModificaClient.Click += new System.EventHandler(this.btnModificaClicked);
            // 
            // btnActualizeaza
            // 
            this.btnActualizeaza.AutoSize = true;
            this.btnActualizeaza.Location = new System.Drawing.Point(13, 174);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(154, 26);
            this.btnActualizeaza.TabIndex = 7;
            this.btnActualizeaza.Text = "Actualizează lista";
            this.btnActualizeaza.UseVisualStyleBackColor = true;
            this.btnActualizeaza.Click += new System.EventHandler(this.mtResetLista_Click);
            // 
            // btnSorteaza
            // 
            this.btnSorteaza.AutoSize = true;
            this.btnSorteaza.Location = new System.Drawing.Point(13, 218);
            this.btnSorteaza.Name = "btnSorteaza";
            this.btnSorteaza.Size = new System.Drawing.Size(154, 26);
            this.btnSorteaza.TabIndex = 8;
            this.btnSorteaza.Text = "Sortează lista";
            this.btnSorteaza.UseVisualStyleBackColor = true;
            this.btnSorteaza.Click += new System.EventHandler(this.btnSorteazaClicked);
            // 
            // btnCautaClient
            // 
            this.btnCautaClient.AutoSize = true;
            this.btnCautaClient.Location = new System.Drawing.Point(13, 261);
            this.btnCautaClient.Name = "btnCautaClient";
            this.btnCautaClient.Size = new System.Drawing.Size(154, 26);
            this.btnCautaClient.TabIndex = 9;
            this.btnCautaClient.Text = "Caută client";
            this.btnCautaClient.UseVisualStyleBackColor = true;
            this.btnCautaClient.Click += new System.EventHandler(this.btnCautaClicked);
            // 
            // btnStergeClient
            // 
            this.btnStergeClient.Location = new System.Drawing.Point(13, 308);
            this.btnStergeClient.Name = "btnStergeClient";
            this.btnStergeClient.Size = new System.Drawing.Size(154, 23);
            this.btnStergeClient.TabIndex = 10;
            this.btnStergeClient.Text = "Șterge client";
            this.btnStergeClient.UseVisualStyleBackColor = true;
            this.btnStergeClient.Click += new System.EventHandler(this.StergeSelectedClicked);
            // 
            // lblClienti
            // 
            this.lblClienti.AutoSize = true;
            this.lblClienti.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienti.Location = new System.Drawing.Point(13, 13);
            this.lblClienti.Name = "lblClienti";
            this.lblClienti.Size = new System.Drawing.Size(145, 27);
            this.lblClienti.TabIndex = 11;
            this.lblClienti.Text = "Meniu Clienți";
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.AllowUserToResizeRows = false;
            this.dataGridViewClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClienti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClienti.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClienti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewClienti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClienti.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClienti.EnableHeadersVisualStyles = false;
            this.dataGridViewClienti.GridColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewClienti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewClienti.Location = new System.Drawing.Point(222, 84);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClienti.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewClienti.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClienti.Size = new System.Drawing.Size(474, 178);
            this.dataGridViewClienti.TabIndex = 12;
            // 
            // lstClienti
            // 
            this.lstClienti.FormattingEnabled = true;
            this.lstClienti.ItemHeight = 16;
            this.lstClienti.Location = new System.Drawing.Point(222, 287);
            this.lstClienti.Name = "lstClienti";
            this.lstClienti.Size = new System.Drawing.Size(474, 84);
            this.lstClienti.TabIndex = 13;
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(983, 558);
            this.Controls.Add(this.lstClienti);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.lblClienti);
            this.Controls.Add(this.btnStergeClient);
            this.Controls.Add(this.btnCautaClient);
            this.Controls.Add(this.btnSorteaza);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnModificaClient);
            this.Controls.Add(this.btnAdaugaClient);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.lblCautare2);
            this.Controls.Add(this.lblCautare1);
            this.Name = "FormClienti";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lblCautare1;
        private System.Windows.Forms.Label lblCautare2;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnAdaugaClient;
        private System.Windows.Forms.Button btnModificaClient;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.Button btnSorteaza;
        private System.Windows.Forms.Button btnCautaClient;
        private System.Windows.Forms.Button btnStergeClient;
        private System.Windows.Forms.Label lblClienti;
        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.ListBox lstClienti;
    }
}

