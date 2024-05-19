namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class Form2
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
        private void InitializeComponent2()
        {
            this.btnCauta1 = new System.Windows.Forms.Button();
            this.txtCautare11 = new System.Windows.Forms.TextBox();
            this.lblCautare11 = new System.Windows.Forms.Label();
            this.lblCautare21 = new System.Windows.Forms.Label();
            this.btnInapoi1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCauta1
            // 
            this.btnCauta1.Location = new System.Drawing.Point(679, 368);
            this.btnCauta1.Name = "btnCauta1";
            this.btnCauta1.Size = new System.Drawing.Size(75, 23);
            this.btnCauta1.TabIndex = 0;
            this.btnCauta1.Text = "Cauta";
            this.btnCauta1.UseVisualStyleBackColor = true;
            this.btnCauta1.Click += new System.EventHandler(this.OnCautaCClicked);
            // 
            // txtCautare11
            // 
            this.txtCautare11.Location = new System.Drawing.Point(546, 368);
            this.txtCautare11.Name = "txtCautare11";
            this.txtCautare11.Size = new System.Drawing.Size(100, 22);
            this.txtCautare11.TabIndex = 1;
            // 
            // lblCautare11
            // 
            this.lblCautare11.AutoSize = true;
            this.lblCautare11.Location = new System.Drawing.Point(546, 429);
            this.lblCautare11.Name = "lblCautare11";
            this.lblCautare11.Size = new System.Drawing.Size(0, 16);
            this.lblCautare11.TabIndex = 2;
            // 
            // lblCautare21
            // 
            this.lblCautare21.AutoSize = true;
            this.lblCautare21.Location = new System.Drawing.Point(679, 428);
            this.lblCautare21.Name = "lblCautare21";
            this.lblCautare21.Size = new System.Drawing.Size(0, 16);
            this.lblCautare21.TabIndex = 3;
            // 
            // btnInapoi1
            // 
            this.btnInapoi1.AutoSize = true;
            this.btnInapoi1.Location = new System.Drawing.Point(546, 447);
            this.btnInapoi1.Name = "btnInapoi1";
            this.btnInapoi1.Size = new System.Drawing.Size(107, 26);
            this.btnInapoi1.TabIndex = 4;
            this.btnInapoi1.Text = "Inapoi la meniu";
            this.btnInapoi1.UseVisualStyleBackColor = true;
            this.btnInapoi1.Click += new System.EventHandler(this.metroBtnInapoi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInapoi1);
            this.Controls.Add(this.lblCautare21);
            this.Controls.Add(this.lblCautare11);
            this.Controls.Add(this.txtCautare11);
            this.Controls.Add(this.btnCauta1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnCauta1;
        private System.Windows.Forms.TextBox txtCautare11;
        private System.Windows.Forms.Label lblCautare11;
        private System.Windows.Forms.Label lblCautare21;
        private System.Windows.Forms.Button btnInapoi1;
        private System.Windows.Forms.Button button1;
    }
}