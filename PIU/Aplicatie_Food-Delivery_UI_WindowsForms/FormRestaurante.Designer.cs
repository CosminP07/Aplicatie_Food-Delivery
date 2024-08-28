namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class FormRestaurante
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
            this.lstRestaurante = new System.Windows.Forms.ListBox();
            this.dataGridViewRestaurante = new System.Windows.Forms.DataGridView();
            this.lblRestaurante = new System.Windows.Forms.Label();
            this.btnStergeRestaurant = new System.Windows.Forms.Button();
            this.btnCautaRestaurant = new System.Windows.Forms.Button();
            this.btnSorteaza = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.btnModificaRestaurant = new System.Windows.Forms.Button();
            this.btnAdaugaRestaurant = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblCautare2 = new System.Windows.Forms.Label();
            this.lblCautare1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurante)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRestaurante
            // 
            this.lstRestaurante.FormattingEnabled = true;
            this.lstRestaurante.ItemHeight = 16;
            this.lstRestaurante.Location = new System.Drawing.Point(222, 290);
            this.lstRestaurante.Name = "lstRestaurante";
            this.lstRestaurante.Size = new System.Drawing.Size(474, 84);
            this.lstRestaurante.TabIndex = 25;
            // 
            // dataGridViewRestaurante
            // 
            this.dataGridViewRestaurante.AllowUserToResizeRows = false;
            this.dataGridViewRestaurante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRestaurante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRestaurante.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridViewRestaurante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRestaurante.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRestaurante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRestaurante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRestaurante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRestaurante.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRestaurante.EnableHeadersVisualStyles = false;
            this.dataGridViewRestaurante.GridColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewRestaurante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewRestaurante.Location = new System.Drawing.Point(222, 87);
            this.dataGridViewRestaurante.Name = "dataGridViewRestaurante";
            this.dataGridViewRestaurante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRestaurante.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRestaurante.RowHeadersWidth = 51;
            this.dataGridViewRestaurante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewRestaurante.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRestaurante.RowTemplate.Height = 24;
            this.dataGridViewRestaurante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRestaurante.Size = new System.Drawing.Size(474, 178);
            this.dataGridViewRestaurante.TabIndex = 24;
            // 
            // lblRestaurante
            // 
            this.lblRestaurante.AutoSize = true;
            this.lblRestaurante.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurante.Location = new System.Drawing.Point(13, 16);
            this.lblRestaurante.Name = "lblRestaurante";
            this.lblRestaurante.Size = new System.Drawing.Size(205, 27);
            this.lblRestaurante.TabIndex = 23;
            this.lblRestaurante.Text = "Meniu Restaurante";
            // 
            // btnStergeRestaurant
            // 
            this.btnStergeRestaurant.Location = new System.Drawing.Point(13, 311);
            this.btnStergeRestaurant.Name = "btnStergeRestaurant";
            this.btnStergeRestaurant.Size = new System.Drawing.Size(130, 23);
            this.btnStergeRestaurant.TabIndex = 22;
            this.btnStergeRestaurant.Text = "Șterge restaurant";
            this.btnStergeRestaurant.UseVisualStyleBackColor = true;
            this.btnStergeRestaurant.Click += new System.EventHandler(this.StergeSelectedClicked);
            // 
            // btnCautaRestaurant
            // 
            this.btnCautaRestaurant.AutoSize = true;
            this.btnCautaRestaurant.Location = new System.Drawing.Point(13, 264);
            this.btnCautaRestaurant.Name = "btnCautaRestaurant";
            this.btnCautaRestaurant.Size = new System.Drawing.Size(130, 26);
            this.btnCautaRestaurant.TabIndex = 21;
            this.btnCautaRestaurant.Text = "Caută restaurant";
            this.btnCautaRestaurant.UseVisualStyleBackColor = true;
            this.btnCautaRestaurant.Click += new System.EventHandler(this.btnCautaClicked);
            // 
            // btnSorteaza
            // 
            this.btnSorteaza.AutoSize = true;
            this.btnSorteaza.Location = new System.Drawing.Point(13, 221);
            this.btnSorteaza.Name = "btnSorteaza";
            this.btnSorteaza.Size = new System.Drawing.Size(130, 26);
            this.btnSorteaza.TabIndex = 20;
            this.btnSorteaza.Text = "Sortează lista";
            this.btnSorteaza.UseVisualStyleBackColor = true;
            this.btnSorteaza.Click += new System.EventHandler(this.btnSorteazaClicked);
            // 
            // btnActualizeaza
            // 
            this.btnActualizeaza.AutoSize = true;
            this.btnActualizeaza.Location = new System.Drawing.Point(13, 177);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(130, 26);
            this.btnActualizeaza.TabIndex = 19;
            this.btnActualizeaza.Text = "Actualizează lista";
            this.btnActualizeaza.UseVisualStyleBackColor = true;
            this.btnActualizeaza.Click += new System.EventHandler(this.mtResetLista_Click);
            // 
            // btnModificaRestaurant
            // 
            this.btnModificaRestaurant.AutoSize = true;
            this.btnModificaRestaurant.Location = new System.Drawing.Point(13, 132);
            this.btnModificaRestaurant.Name = "btnModificaRestaurant";
            this.btnModificaRestaurant.Size = new System.Drawing.Size(130, 26);
            this.btnModificaRestaurant.TabIndex = 18;
            this.btnModificaRestaurant.Text = "Modifică restaurant";
            this.btnModificaRestaurant.UseVisualStyleBackColor = true;
            this.btnModificaRestaurant.Click += new System.EventHandler(this.btnModificaClicked);
            // 
            // btnAdaugaRestaurant
            // 
            this.btnAdaugaRestaurant.AutoSize = true;
            this.btnAdaugaRestaurant.Location = new System.Drawing.Point(13, 87);
            this.btnAdaugaRestaurant.Name = "btnAdaugaRestaurant";
            this.btnAdaugaRestaurant.Size = new System.Drawing.Size(130, 26);
            this.btnAdaugaRestaurant.TabIndex = 17;
            this.btnAdaugaRestaurant.Text = "Adaugă restaurant";
            this.btnAdaugaRestaurant.UseVisualStyleBackColor = true;
            this.btnAdaugaRestaurant.Click += new System.EventHandler(this.btnAdaugaRestaurant_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.AutoSize = true;
            this.btnInapoi.Location = new System.Drawing.Point(13, 388);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(130, 26);
            this.btnInapoi.TabIndex = 16;
            this.btnInapoi.Text = "Înapoi la meniu";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.metroBtnInapoi_Click);
            // 
            // lblCautare2
            // 
            this.lblCautare2.AutoSize = true;
            this.lblCautare2.Location = new System.Drawing.Point(714, 448);
            this.lblCautare2.Name = "lblCautare2";
            this.lblCautare2.Size = new System.Drawing.Size(0, 16);
            this.lblCautare2.TabIndex = 15;
            // 
            // lblCautare1
            // 
            this.lblCautare1.AutoSize = true;
            this.lblCautare1.Location = new System.Drawing.Point(593, 448);
            this.lblCautare1.Name = "lblCautare1";
            this.lblCautare1.Size = new System.Drawing.Size(0, 16);
            this.lblCautare1.TabIndex = 14;
            // 
            // FormRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(709, 595);
            this.Controls.Add(this.lstRestaurante);
            this.Controls.Add(this.dataGridViewRestaurante);
            this.Controls.Add(this.lblRestaurante);
            this.Controls.Add(this.btnStergeRestaurant);
            this.Controls.Add(this.btnCautaRestaurant);
            this.Controls.Add(this.btnSorteaza);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnModificaRestaurant);
            this.Controls.Add(this.btnAdaugaRestaurant);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.lblCautare2);
            this.Controls.Add(this.lblCautare1);
            this.Name = "FormRestaurante";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxRestaurante;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstRestaurante;
        private System.Windows.Forms.DataGridView dataGridViewRestaurante;
        private System.Windows.Forms.Label lblRestaurante;
        private System.Windows.Forms.Button btnStergeRestaurant;
        private System.Windows.Forms.Button btnCautaRestaurant;
        private System.Windows.Forms.Button btnSorteaza;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.Button btnModificaRestaurant;
        private System.Windows.Forms.Button btnAdaugaRestaurant;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblCautare2;
        private System.Windows.Forms.Label lblCautare1;
    }
}