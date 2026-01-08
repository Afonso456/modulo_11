namespace Calculadora
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
            components = new System.ComponentModel.Container();
            btn_dividir = new Button();
            tb_n1 = new TextBox();
            tb_n2 = new TextBox();
            label1 = new Label();
            lb_resultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            bt_subtrair = new Button();
            bt_soma = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btn_dividir
            // 
            btn_dividir.Location = new Point(103, 72);
            btn_dividir.Name = "btn_dividir";
            btn_dividir.Size = new Size(85, 33);
            btn_dividir.TabIndex = 0;
            btn_dividir.Text = "Dividir";
            btn_dividir.UseVisualStyleBackColor = true;
            btn_dividir.Click += btn_dividir_Click;
            // 
            // tb_n1
            // 
            tb_n1.Location = new Point(12, 36);
            tb_n1.Name = "tb_n1";
            tb_n1.Size = new Size(85, 23);
            tb_n1.TabIndex = 1;
            // 
            // tb_n2
            // 
            tb_n2.Location = new Point(103, 36);
            tb_n2.Name = "tb_n2";
            tb_n2.Size = new Size(85, 23);
            tb_n2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Resultado";
            // 
            // lb_resultado
            // 
            lb_resultado.BorderStyle = BorderStyle.Fixed3D;
            lb_resultado.Location = new Point(77, 9);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(111, 15);
            lb_resultado.TabIndex = 2;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // bt_subtrair
            // 
            bt_subtrair.Location = new Point(12, 115);
            bt_subtrair.Name = "bt_subtrair";
            bt_subtrair.Size = new Size(85, 37);
            bt_subtrair.TabIndex = 3;
            bt_subtrair.Text = "Subtrair";
            bt_subtrair.UseVisualStyleBackColor = true;
            bt_subtrair.Click += btnSubtrair_Click;
            // 
            // bt_soma
            // 
            bt_soma.Location = new Point(12, 72);
            bt_soma.Name = "bt_soma";
            bt_soma.Size = new Size(85, 37);
            bt_soma.TabIndex = 3;
            bt_soma.Text = "Somar";
            bt_soma.UseVisualStyleBackColor = true;
            bt_soma.Click += btnSomar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(207, 182);
            Controls.Add(bt_soma);
            Controls.Add(bt_subtrair);
            Controls.Add(lb_resultado);
            Controls.Add(label1);
            Controls.Add(tb_n2);
            Controls.Add(tb_n1);
            Controls.Add(btn_dividir);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_dividir;
        private TextBox tb_n1;
        private TextBox tb_n2;
        private Label label1;
        private Label lb_resultado;
        private ErrorProvider errorProvider1;
        private Button bt_soma;
        private Button bt_subtrair;
    }
}
