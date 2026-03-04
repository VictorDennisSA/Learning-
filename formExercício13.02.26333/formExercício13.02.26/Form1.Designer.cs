namespace formExercício13._02._26
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
            btn_send = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            text_nome = new TextBox();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            listPeople = new ListBox();
            pnlMain = new Panel();
            dtpNasci = new DateTimePicker();
            list_ecivil = new ComboBox();
            mtbtele = new MaskedTextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            panel2.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // btn_send
            // 
            btn_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_send.Location = new Point(265, 291);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(102, 58);
            btn_send.TabIndex = 12;
            btn_send.Text = "Enviar";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 154);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 6;
            label5.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 59);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 199);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 8;
            label3.Text = "Estado Civil";
            // 
            // text_nome
            // 
            text_nome.Location = new Point(15, 31);
            text_nome.Name = "text_nome";
            text_nome.Size = new Size(290, 23);
            text_nome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 242);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 10;
            label4.Text = "Telefone";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 100);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(listPeople);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 361);
            panel2.TabIndex = 3;
            // 
            // listPeople
            // 
            listPeople.Dock = DockStyle.Fill;
            listPeople.FormattingEnabled = true;
            listPeople.ItemHeight = 15;
            listPeople.Location = new Point(0, 0);
            listPeople.Name = "listPeople";
            listPeople.Size = new Size(200, 361);
            listPeople.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dtpNasci);
            pnlMain.Controls.Add(list_ecivil);
            pnlMain.Controls.Add(mtbtele);
            pnlMain.Controls.Add(btn_send);
            pnlMain.Controls.Add(label6);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(textBox1);
            pnlMain.Controls.Add(textBox2);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(text_nome);
            pnlMain.Controls.Add(label5);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(label3);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 100);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(384, 361);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += panel3_Paint;
            // 
            // dtpNasci
            // 
            dtpNasci.Location = new Point(15, 173);
            dtpNasci.Name = "dtpNasci";
            dtpNasci.Size = new Size(237, 23);
            dtpNasci.TabIndex = 7;
            // 
            // list_ecivil
            // 
            list_ecivil.FormattingEnabled = true;
            list_ecivil.Location = new Point(15, 217);
            list_ecivil.Name = "list_ecivil";
            list_ecivil.Size = new Size(237, 23);
            list_ecivil.TabIndex = 9;
            list_ecivil.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // mtbtele
            // 
            mtbtele.Location = new Point(15, 260);
            mtbtele.Mask = "00 00000-0000";
            mtbtele.Name = "mtbtele";
            mtbtele.Size = new Size(95, 23);
            mtbtele.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 103);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 4;
            label6.Text = "Endereço";
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 23);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(pnlMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(0, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_send;
        private TextBox textBox1;
        private Label label5;
        private Label label2;
        private Label label3;
        private TextBox text_nome;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel pnlMain;
        private MaskedTextBox mtbtele;
        private ComboBox list_ecivil;
        private Label label6;
        private TextBox textBox2;
        private DateTimePicker dtpNasci;
        private ListBox listPeople;
    }
}
