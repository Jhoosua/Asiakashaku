namespace Asiakashaku
{
    partial class Form1
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
            label1 = new Label();
            txtEtunimi = new TextBox();
            label2 = new Label();
            txtSukunimi = new TextBox();
            btnHaeTiedot = new Button();
            grpTulokset = new GroupBox();
            txtTulokset = new TextBox();
            txtTaloyhtiö = new Label();
            cmbTaloyhtio = new ComboBox();
            txtAsunnonTunnus = new Label();
            txtboxAsunnonTunnus = new TextBox();
            btnHaeAsukkaat = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            grpTulokset.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 52);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Etunimi:";
            // 
            // txtEtunimi
            // 
            txtEtunimi.Location = new Point(65, 76);
            txtEtunimi.Name = "txtEtunimi";
            txtEtunimi.Size = new Size(308, 27);
            txtEtunimi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 140);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Sukunimi:";
            // 
            // txtSukunimi
            // 
            txtSukunimi.Location = new Point(65, 164);
            txtSukunimi.Name = "txtSukunimi";
            txtSukunimi.Size = new Size(308, 27);
            txtSukunimi.TabIndex = 3;
            // 
            // btnHaeTiedot
            // 
            btnHaeTiedot.Location = new Point(157, 227);
            btnHaeTiedot.Name = "btnHaeTiedot";
            btnHaeTiedot.Size = new Size(126, 52);
            btnHaeTiedot.TabIndex = 4;
            btnHaeTiedot.Text = "Hae Tiedot";
            btnHaeTiedot.UseVisualStyleBackColor = true;
            btnHaeTiedot.Click += btnHaeTiedot_Click;
            // 
            // grpTulokset
            // 
            grpTulokset.Controls.Add(txtTulokset);
            grpTulokset.Location = new Point(186, 316);
            grpTulokset.Name = "grpTulokset";
            grpTulokset.Size = new Size(461, 403);
            grpTulokset.TabIndex = 5;
            grpTulokset.TabStop = false;
            grpTulokset.Text = "Hakutulokset";
            // 
            // txtTulokset
            // 
            txtTulokset.Location = new Point(6, 26);
            txtTulokset.Multiline = true;
            txtTulokset.Name = "txtTulokset";
            txtTulokset.ReadOnly = true;
            txtTulokset.ScrollBars = ScrollBars.Vertical;
            txtTulokset.Size = new Size(449, 361);
            txtTulokset.TabIndex = 0;
            // 
            // txtTaloyhtiö
            // 
            txtTaloyhtiö.AutoSize = true;
            txtTaloyhtiö.Location = new Point(439, 52);
            txtTaloyhtiö.Name = "txtTaloyhtiö";
            txtTaloyhtiö.Size = new Size(119, 20);
            txtTaloyhtiö.TabIndex = 6;
            txtTaloyhtiö.Text = "Valitse Taloyhtiö:";
            // 
            // cmbTaloyhtio
            // 
            cmbTaloyhtio.FormattingEnabled = true;
            cmbTaloyhtio.Location = new Point(439, 76);
            cmbTaloyhtio.Name = "cmbTaloyhtio";
            cmbTaloyhtio.Size = new Size(308, 28);
            cmbTaloyhtio.TabIndex = 7;
            // 
            // txtAsunnonTunnus
            // 
            txtAsunnonTunnus.AutoSize = true;
            txtAsunnonTunnus.Location = new Point(440, 140);
            txtAsunnonTunnus.Name = "txtAsunnonTunnus";
            txtAsunnonTunnus.Size = new Size(183, 20);
            txtAsunnonTunnus.TabIndex = 8;
            txtAsunnonTunnus.Text = "Asunnon tunnus (esim. A1)";
            // 
            // txtboxAsunnonTunnus
            // 
            txtboxAsunnonTunnus.Location = new Point(439, 164);
            txtboxAsunnonTunnus.Name = "txtboxAsunnonTunnus";
            txtboxAsunnonTunnus.Size = new Size(308, 27);
            txtboxAsunnonTunnus.TabIndex = 9;
            // 
            // btnHaeAsukkaat
            // 
            btnHaeAsukkaat.Location = new Point(533, 227);
            btnHaeAsukkaat.Name = "btnHaeAsukkaat";
            btnHaeAsukkaat.Size = new Size(135, 51);
            btnHaeAsukkaat.TabIndex = 10;
            btnHaeAsukkaat.Text = "Hae Asukkaat";
            btnHaeAsukkaat.UseVisualStyleBackColor = true;
            btnHaeAsukkaat.Click += btnHaeAsukkaat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 11);
            label3.Name = "label3";
            label3.Size = new Size(186, 20);
            label3.TabIndex = 11;
            label3.Text = "Hakutapa 1 - Hae henkilöä";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 11);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 12;
            label4.Text = "Hakutapa 2 - Hae asuntoa";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ScrollBar;
            label5.Location = new Point(404, 18);
            label5.Name = "label5";
            label5.Size = new Size(2, 260);
            label5.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 731);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnHaeAsukkaat);
            Controls.Add(txtboxAsunnonTunnus);
            Controls.Add(txtAsunnonTunnus);
            Controls.Add(cmbTaloyhtio);
            Controls.Add(txtTaloyhtiö);
            Controls.Add(grpTulokset);
            Controls.Add(btnHaeTiedot);
            Controls.Add(txtSukunimi);
            Controls.Add(label2);
            Controls.Add(txtEtunimi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Asiakashaku";
            grpTulokset.ResumeLayout(false);
            grpTulokset.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEtunimi;
        private Label label2;
        private TextBox txtSukunimi;
        private Button btnHaeTiedot;
        private GroupBox grpTulokset;
        private TextBox txtTulokset;
        private Label txtTaloyhtiö;
        private ComboBox cmbTaloyhtio;
        private Label txtAsunnonTunnus;
        private TextBox txtboxAsunnonTunnus;
        private Button btnHaeAsukkaat;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
