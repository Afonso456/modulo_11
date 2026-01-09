namespace gerir_pessoas
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
            btn_guardat = new Button();
            btn_lert = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            txt_id = new TextBox();
            txt_nome = new TextBox();
            txt_idade = new TextBox();
            txt_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_guardat
            // 
            btn_guardat.Location = new Point(28, 267);
            btn_guardat.Name = "btn_guardat";
            btn_guardat.Size = new Size(95, 20);
            btn_guardat.TabIndex = 0;
            btn_guardat.Text = "Guardar TXT";
            btn_guardat.UseVisualStyleBackColor = true;
            btn_guardat.Click += btn_guardat_Click;
            // 
            // btn_lert
            // 
            btn_lert.Location = new Point(30, 293);
            btn_lert.Name = "btn_lert";
            btn_lert.Size = new Size(95, 20);
            btn_lert.TabIndex = 0;
            btn_lert.Text = "Ler TXT";
            btn_lert.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(46, 227);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(110, 34);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(28, 319);
            button1.Name = "button1";
            button1.Size = new Size(97, 20);
            button1.TabIndex = 0;
            button1.Text = "Guardar JSON";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(28, 345);
            button2.Name = "button2";
            button2.Size = new Size(97, 20);
            button2.TabIndex = 0;
            button2.Text = "Ler JSON";
            button2.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(86, 32);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(104, 23);
            txt_id.TabIndex = 1;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(86, 72);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(104, 23);
            txt_nome.TabIndex = 1;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(86, 111);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(104, 23);
            txt_idade.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(86, 150);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(104, 23);
            txt_email.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 72);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 111);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 150);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(txt_email);
            Controls.Add(txt_idade);
            Controls.Add(txt_nome);
            Controls.Add(txt_id);
            Controls.Add(button2);
            Controls.Add(btn_lert);
            Controls.Add(button1);
            Controls.Add(btn_guardat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardat;
        private Button btn_lert;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox txt_id;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
