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
        private void InitializeComponent()
        {
            this.btnCauta1 = new System.Windows.Forms.Button();
            this.txtCautare11 = new System.Windows.Forms.TextBox();
            this.lblCautare11 = new System.Windows.Forms.Label();
            this.lblCautare21 = new System.Windows.Forms.Label();
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
            // txtCautare1
            // 
            this.txtCautare11.Location = new System.Drawing.Point(546, 368);
            this.txtCautare11.Name = "txtCautare1";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 499);
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
        private void InitializeComponent2()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Text = "Form2";
        }

        private System.Windows.Forms.Button btnCauta1;
        private System.Windows.Forms.TextBox txtCautare11;
        private System.Windows.Forms.Label lblCautare11;
        private System.Windows.Forms.Label lblCautare21;
    }
}