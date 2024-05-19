namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    partial class FormMeniu
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
            this.btnRestaurant = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurant.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurant.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnRestaurant.Location = new System.Drawing.Point(205, 190);
            this.btnRestaurant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRestaurant.Size = new System.Drawing.Size(262, 208);
            this.btnRestaurant.TabIndex = 0;
            this.btnRestaurant.Text = "Administrare Restaurante";
            this.btnRestaurant.UseVisualStyleBackColor = false;
            this.btnRestaurant.Click += new System.EventHandler(this.OnRestaurantClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(598, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(262, 208);
            this.button1.TabIndex = 1;
            this.button1.Text = "Administrare Clienti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OnClientiClicked);
            // 
            // FormMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1100, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestaurant);
            this.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMeniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurant;
        private System.Windows.Forms.Button button1;
    }
}