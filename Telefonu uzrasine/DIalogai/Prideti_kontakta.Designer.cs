namespace Telefonu_uzrasine.DIalogai
{
    partial class AddContactForm
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
            atsaukti = new Button();
            pranesimas = new Label();
            patvirtinimas = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            data = new TextBox();
            numeris = new TextBox();
            vardas = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // atsaukti
            // 
            atsaukti.Location = new Point(175, 315);
            atsaukti.Name = "atsaukti";
            atsaukti.Size = new Size(94, 29);
            atsaukti.TabIndex = 19;
            atsaukti.Text = "Atšaukti";
            atsaukti.UseVisualStyleBackColor = true;
            atsaukti.Click += atsaukti_Click;
            // 
            // pranesimas
            // 
            pranesimas.AutoSize = true;
            pranesimas.Location = new Point(89, 81);
            pranesimas.Name = "pranesimas";
            pranesimas.Size = new Size(0, 20);
            pranesimas.TabIndex = 18;
            // 
            // patvirtinimas
            // 
            patvirtinimas.DialogResult = DialogResult.OK;
            patvirtinimas.Location = new Point(42, 315);
            patvirtinimas.Name = "patvirtinimas";
            patvirtinimas.Size = new Size(94, 29);
            patvirtinimas.TabIndex = 17;
            patvirtinimas.Text = "Patvirtinti";
            patvirtinimas.UseVisualStyleBackColor = true;
            patvirtinimas.Click += patvirtinimas_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 234);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 16;
            label6.Text = "Gimimo metai";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 168);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 15;
            label7.Text = "Telefono numeris";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 107);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 14;
            label8.Text = "Vardas ir pavardė";
            // 
            // data
            // 
            data.Location = new Point(65, 254);
            data.MaxLength = 10;
            data.Multiline = true;
            data.Name = "data";
            data.Size = new Size(180, 35);
            data.TabIndex = 12;
            data.TabStop = false;
            data.MouseClick += data_MouseClick;
            data.KeyPress += data_KeyPress;
            // 
            // numeris
            // 
            numeris.Location = new Point(65, 196);
            numeris.MaxLength = 15;
            numeris.Multiline = true;
            numeris.Name = "numeris";
            numeris.Size = new Size(180, 35);
            numeris.TabIndex = 11;
            numeris.TabStop = false;
            numeris.MouseClick += numeris_MouseClick;
            numeris.KeyPress += numeris_KeyPress;
            // 
            // vardas
            // 
            vardas.Location = new Point(65, 130);
            vardas.MaxLength = 20;
            vardas.Multiline = true;
            vardas.Name = "vardas";
            vardas.Size = new Size(180, 35);
            vardas.TabIndex = 13;
            vardas.TabStop = false;
            vardas.MouseClick += vardas_MouseClick;
            vardas.KeyPress += vardas_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 65);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 38);
            label1.TabIndex = 0;
            label1.Text = "Kontakto pridėjimas";
            // 
            // Prideti_kontakta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(310, 370);
            Controls.Add(panel2);
            Controls.Add(atsaukti);
            Controls.Add(pranesimas);
            Controls.Add(patvirtinimas);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(data);
            Controls.Add(numeris);
            Controls.Add(vardas);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Prideti_kontakta";
            StartPosition = FormStartPosition.CenterParent;
            FormClosing += Prideti_kontakta_FormClosing;
            FormClosed += Prideti_kontakta_FormClosed;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button atsaukti;
        private Label pranesimas;
        private Button patvirtinimas;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox data;
        private TextBox numeris;
        private TextBox vardas;
        private Panel panel2;
        private Label label1;
    }
}