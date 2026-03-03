namespace WinFormsApp125._02._26
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
            btn_adicionar = new Button();
            txt_name = new TextBox();
            list_name = new ListBox();
            btn_remove = new Button();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(80, 103);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(193, 23);
            btn_adicionar.TabIndex = 0;
            btn_adicionar.Text = "Adicionar Nome";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(78, 74);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(196, 23);
            txt_name.TabIndex = 1;
            // 
            // list_name
            // 
            list_name.FormattingEnabled = true;
            list_name.ItemHeight = 15;
            list_name.Location = new Point(78, 132);
            list_name.Name = "list_name";
            list_name.Size = new Size(196, 94);
            list_name.TabIndex = 2;
            list_name.SelectedIndexChanged += list_name_SelectedIndexChanged;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(78, 232);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(196, 23);
            btn_remove.TabIndex = 3;
            btn_remove.Text = "Remover Nome";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 390);
            Controls.Add(btn_remove);
            Controls.Add(list_name);
            Controls.Add(txt_name);
            Controls.Add(btn_adicionar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionar;
        private TextBox txt_name;
        private ListBox list_name;
        private Button btn_remove;
    }
}
