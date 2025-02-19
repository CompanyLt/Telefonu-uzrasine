namespace Telefonu_uzrasine
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lentele = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            istrinti = new Button();
            redaguoti = new Button();
            prideti = new Button();
            ((System.ComponentModel.ISupportInitialize)lentele).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lentele
            // 
            lentele.AllowUserToAddRows = false;
            lentele.AllowUserToDeleteRows = false;
            lentele.BackgroundColor = SystemColors.ButtonHighlight;
            lentele.BorderStyle = BorderStyle.Fixed3D;
            lentele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            lentele.DefaultCellStyle = dataGridViewCellStyle1;
            lentele.Location = new Point(0, 141);
            lentele.Name = "lentele";
            lentele.ReadOnly = true;
            lentele.RowHeadersVisible = false;
            lentele.RowHeadersWidth = 51;
            lentele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lentele.Size = new Size(813, 397);
            lentele.TabIndex = 0;
            lentele.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(istrinti);
            panel1.Controls.Add(redaguoti);
            panel1.Controls.Add(prideti);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 143);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(258, 4);
            label1.Name = "label1";
            label1.Size = new Size(304, 62);
            label1.TabIndex = 5;
            label1.Text = "Telefonknygė";
            // 
            // istrinti
            // 
            istrinti.BackColor = SystemColors.ActiveCaption;
            istrinti.Location = new Point(459, 84);
            istrinti.Name = "istrinti";
            istrinti.Size = new Size(133, 49);
            istrinti.TabIndex = 4;
            istrinti.Text = "Ištrinti";
            istrinti.UseVisualStyleBackColor = false;
            istrinti.Click += istrinti_Click;
            // 
            // redaguoti
            // 
            redaguoti.BackColor = SystemColors.ActiveCaption;
            redaguoti.Location = new Point(327, 84);
            redaguoti.Name = "redaguoti";
            redaguoti.Size = new Size(135, 49);
            redaguoti.TabIndex = 3;
            redaguoti.Text = "Redaguoti";
            redaguoti.UseVisualStyleBackColor = false;
            redaguoti.Click += redaguoti_Click;
            // 
            // prideti
            // 
            prideti.BackColor = SystemColors.ActiveCaption;
            prideti.Location = new Point(194, 84);
            prideti.Name = "prideti";
            prideti.Size = new Size(135, 49);
            prideti.TabIndex = 2;
            prideti.Text = "Pridėti";
            prideti.UseVisualStyleBackColor = false;
            prideti.Click += prideti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 553);
            Controls.Add(panel1);
            Controls.Add(lentele);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telefonų kontaktų užrašinė v1.0";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)lentele).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView lentele;
        private Panel panel1;
        private Button istrinti;
        private Button redaguoti;
        private Button prideti;
        private Label label1;
    }
}
