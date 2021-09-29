namespace TrenRezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVagon = new System.Windows.Forms.Label();
            this.txtKisiSay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rezervasyon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rdnEvet = new System.Windows.Forms.RadioButton();
            this.rdnHayır = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başkent Express";
            // 
            // lblVagon
            // 
            this.lblVagon.AutoSize = true;
            this.lblVagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVagon.Location = new System.Drawing.Point(47, 244);
            this.lblVagon.Name = "lblVagon";
            this.lblVagon.Size = new System.Drawing.Size(288, 18);
            this.lblVagon.TabIndex = 1;
            this.lblVagon.Text = "Kaç kişilik rezervasyon yapıcaksınız?";
            // 
            // txtKisiSay
            // 
            this.txtKisiSay.Location = new System.Drawing.Point(389, 243);
            this.txtKisiSay.Name = "txtKisiSay";
            this.txtKisiSay.Size = new System.Drawing.Size(177, 22);
            this.txtKisiSay.TabIndex = 2;
            this.txtKisiSay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKisiSay_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vagon 1 Kapasite:100 Dolu Koltuk: 50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vagon 2 Kapasite:90 Dolu Koltuk: 80";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vagon 3 Kapasite:80 Dolu Koltuk:80";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tren Bilgileri";
            // 
            // btn_rezervasyon
            // 
            this.btn_rezervasyon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_rezervasyon.Location = new System.Drawing.Point(50, 334);
            this.btn_rezervasyon.Name = "btn_rezervasyon";
            this.btn_rezervasyon.Size = new System.Drawing.Size(156, 40);
            this.btn_rezervasyon.TabIndex = 7;
            this.btn_rezervasyon.Text = "Rezervasyon Yap";
            this.btn_rezervasyon.UseVisualStyleBackColor = false;
            this.btn_rezervasyon.Click += new System.EventHandler(this.btn_rezervasyon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kisiler Farkli Vagonlara Yerlestirilebilir mi?\r\n";
            // 
            // rdnEvet
            // 
            this.rdnEvet.AutoSize = true;
            this.rdnEvet.Location = new System.Drawing.Point(389, 294);
            this.rdnEvet.Name = "rdnEvet";
            this.rdnEvet.Size = new System.Drawing.Size(61, 21);
            this.rdnEvet.TabIndex = 11;
            this.rdnEvet.TabStop = true;
            this.rdnEvet.Text = "Evet";
            this.rdnEvet.UseVisualStyleBackColor = true;
            // 
            // rdnHayır
            // 
            this.rdnHayır.AutoSize = true;
            this.rdnHayır.Location = new System.Drawing.Point(470, 294);
            this.rdnHayır.Name = "rdnHayır";
            this.rdnHayır.Size = new System.Drawing.Size(67, 21);
            this.rdnHayır.TabIndex = 12;
            this.rdnHayır.TabStop = true;
            this.rdnHayır.Text = "Hayır";
            this.rdnHayır.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rezervasyon Sonucu:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(812, 86);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(81, 20);
            this.lblSonuc.TabIndex = 14;
            this.lblSonuc.Text = "lblSonuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 493);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdnHayır);
            this.Controls.Add(this.rdnEvet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_rezervasyon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKisiSay);
            this.Controls.Add(this.lblVagon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Başkent Express";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVagon;
        private System.Windows.Forms.TextBox txtKisiSay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rezervasyon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdnEvet;
        private System.Windows.Forms.RadioButton rdnHayır;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSonuc;
    }
}

