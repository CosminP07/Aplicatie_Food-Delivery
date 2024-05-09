namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class Form1
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
            this.Cautare = new System.Windows.Forms.Button();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.lblCautare1 = new System.Windows.Forms.Label();
            this.lblCautare2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cautare
            // 
            this.Cautare.Location = new System.Drawing.Point(714, 387);
            this.Cautare.Name = "Cautare";
            this.Cautare.Size = new System.Drawing.Size(75, 23);
            this.Cautare.TabIndex = 0;
            this.Cautare.Text = "Cauta";
            this.Cautare.UseVisualStyleBackColor = true;
            this.Cautare.Click += new System.EventHandler(this.OnCautaClicked);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(593, 388);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(100, 22);
            this.txtCautare.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 558);
            this.Controls.Add(this.lblCautare2);
            this.Controls.Add(this.lblCautare1);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.Cautare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button Cautare;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Label lblCautare1;
        private System.Windows.Forms.Label lblCautare2;
    }
}

