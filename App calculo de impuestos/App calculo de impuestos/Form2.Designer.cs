namespace App_calculo_de_impuestos
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
            this.Sueldobruto = new System.Windows.Forms.TextBox();
            this.sfs1 = new System.Windows.Forms.TextBox();
            this.afp = new System.Windows.Forms.TextBox();
            this.isr = new System.Windows.Forms.TextBox();
            this.Sueldonet = new System.Windows.Forms.TextBox();
            this.clacbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sueldobruto
            // 
            this.Sueldobruto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sueldobruto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sueldobruto.Location = new System.Drawing.Point(77, 86);
            this.Sueldobruto.Name = "Sueldobruto";
            this.Sueldobruto.Size = new System.Drawing.Size(158, 19);
            this.Sueldobruto.TabIndex = 0;
            this.Sueldobruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sueldobruto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sfs1
            // 
            this.sfs1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sfs1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfs1.Location = new System.Drawing.Point(55, 241);
            this.sfs1.Name = "sfs1";
            this.sfs1.Size = new System.Drawing.Size(135, 19);
            this.sfs1.TabIndex = 1;
            this.sfs1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfs1.TextChanged += new System.EventHandler(this.sfs_TextChanged);
            // 
            // afp
            // 
            this.afp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.afp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.afp.Location = new System.Drawing.Point(255, 241);
            this.afp.Name = "afp";
            this.afp.Size = new System.Drawing.Size(122, 19);
            this.afp.TabIndex = 2;
            this.afp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.afp.TextChanged += new System.EventHandler(this.afp_TextChanged);
            // 
            // isr
            // 
            this.isr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isr.Location = new System.Drawing.Point(433, 241);
            this.isr.Name = "isr";
            this.isr.Size = new System.Drawing.Size(114, 19);
            this.isr.TabIndex = 3;
            this.isr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sueldonet
            // 
            this.Sueldonet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sueldonet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sueldonet.Location = new System.Drawing.Point(511, 362);
            this.Sueldonet.Name = "Sueldonet";
            this.Sueldonet.Size = new System.Drawing.Size(121, 19);
            this.Sueldonet.TabIndex = 4;
            this.Sueldonet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clacbtn
            // 
            this.clacbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clacbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clacbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clacbtn.Location = new System.Drawing.Point(433, 86);
            this.clacbtn.Name = "clacbtn";
            this.clacbtn.Size = new System.Drawing.Size(119, 36);
            this.clacbtn.TabIndex = 5;
            this.clacbtn.Text = "Calcular";
            this.clacbtn.UseVisualStyleBackColor = true;
            this.clacbtn.Click += new System.EventHandler(this.clacbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::App_calculo_de_impuestos.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 440);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clacbtn);
            this.Controls.Add(this.Sueldonet);
            this.Controls.Add(this.isr);
            this.Controls.Add(this.afp);
            this.Controls.Add(this.sfs1);
            this.Controls.Add(this.Sueldobruto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Principal Page";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Sueldobruto;
        private TextBox sfs1;
        private TextBox afp;
        private TextBox isr;
        private TextBox Sueldonet;
        private Button clacbtn;
        private Button button1;
        private Button button2;
    }
}