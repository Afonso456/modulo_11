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
            lst_pessoas = new ListBox();
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
            btn_converter_TJ = new Button();
            btn_converter_JT = new Button();
            btn_maior_18 = new Button();
            SuspendLayout();
            // 
            // btn_guardat
            // 
            btn_guardat.Location = new Point(12, 303);
            btn_guardat.Name = "btn_guardat";
            btn_guardat.Size = new Size(95, 20);
            btn_guardat.TabIndex = 0;
            btn_guardat.Text = "Guardar TXT";
            btn_guardat.UseVisualStyleBackColor = true;
            btn_guardat.Click += btn_guardat_Click;
            // 
            // btn_lert
            // 
            btn_lert.Location = new Point(113, 303);
            btn_lert.Name = "btn_lert";
            btn_lert.Size = new Size(95, 20);
            btn_lert.TabIndex = 0;
            btn_lert.Text = "Ler TXT";
            btn_lert.UseVisualStyleBackColor = true;
            btn_lert.Click += btn_lerT_Click;
            // 
            // lst_pessoas
            // 
            lst_pessoas.FormattingEnabled = true;
            lst_pessoas.Location = new Point(12, 116);
            lst_pessoas.Name = "lst_pessoas";
            lst_pessoas.Size = new Size(401, 169);
            lst_pessoas.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(214, 303);
            button1.Name = "button1";
            button1.Size = new Size(97, 20);
            button1.TabIndex = 0;
            button1.Text = "Guardar JSON";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_guardarJ_Click;
            // 
            // button2
            // 
            button2.Location = new Point(317, 303);
            button2.Name = "button2";
            button2.Size = new Size(97, 20);
            button2.TabIndex = 0;
            button2.Text = "Ler JSON";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_lerJ_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(273, 63);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(104, 23);
            txt_id.TabIndex = 1;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(68, 12);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(104, 23);
            txt_nome.TabIndex = 1;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(273, 12);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(104, 23);
            txt_idade.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(68, 60);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(104, 23);
            txt_email.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 63);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 12);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // btn_converter_TJ
            // 
            btn_converter_TJ.Location = new Point(235, 329);
            btn_converter_TJ.Name = "btn_converter_TJ";
            btn_converter_TJ.Size = new Size(133, 20);
            btn_converter_TJ.TabIndex = 4;
            btn_converter_TJ.Text = "Converter JSON/TXT";
            btn_converter_TJ.UseVisualStyleBackColor = true;
            btn_converter_TJ.Click += btn_converter_JT_Click;
            // 
            // btn_converter_JT
            // 
            btn_converter_JT.Location = new Point(68, 329);
            btn_converter_JT.Name = "btn_converter_JT";
            btn_converter_JT.Size = new Size(133, 20);
            btn_converter_JT.TabIndex = 4;
            btn_converter_JT.Text = "Converter TXT/JSON";
            btn_converter_JT.UseVisualStyleBackColor = true;
            btn_converter_JT.Click += btn_converter_TJ_Click;
            // 
            // btn_maior_18
            // 
            btn_maior_18.Location = new Point(140, 355);
            btn_maior_18.Name = "btn_maior_18";
            btn_maior_18.Size = new Size(142, 20);
            btn_maior_18.TabIndex = 5;
            btn_maior_18.Text = "Maior 18";
            btn_maior_18.UseVisualStyleBackColor = true;
            btn_maior_18.Click += btn_maiores18_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 391);
            Controls.Add(btn_maior_18);
            Controls.Add(btn_converter_JT);
            Controls.Add(btn_converter_TJ);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lst_pessoas);
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
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardat;
        private Button btn_lert;
        private ListBox lst_pessoas;
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
        private Button btn_converter_TJ;
        private Button btn_converter_JT;
        private Button btn_maior_18;
    }
}
