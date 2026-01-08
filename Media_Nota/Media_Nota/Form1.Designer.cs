namespace Media_Nota
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
            txt_valor1 = new TextBox();
            txt_valor2 = new TextBox();
            btn_calcular = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label3 = new Label();
            lbl_resultado = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt_valor1
            // 
            txt_valor1.Location = new Point(12, 12);
            txt_valor1.Name = "txt_valor1";
            txt_valor1.Size = new Size(121, 23);
            txt_valor1.TabIndex = 0;
            // 
            // txt_valor2
            // 
            txt_valor2.Location = new Point(155, 12);
            txt_valor2.Name = "txt_valor2";
            txt_valor2.Size = new Size(121, 23);
            txt_valor2.TabIndex = 0;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(12, 52);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(121, 35);
            btn_calcular.TabIndex = 1;
            btn_calcular.Text = "Calcular Media";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.Location = new Point(139, 52);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Resultado";
            // 
            // lbl_resultado
            // 
            lbl_resultado.BorderStyle = BorderStyle.Fixed3D;
            lbl_resultado.Location = new Point(199, 67);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(88, 20);
            lbl_resultado.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 118);
            Controls.Add(lbl_resultado);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btn_calcular);
            Controls.Add(txt_valor2);
            Controls.Add(txt_valor1);
            Name = "Form1";
            Text = "Calcular Media Notas";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_valor1;
        private TextBox txt_valor2;
        private Button btn_calcular;
        private ErrorProvider errorProvider1;
        private Label lbl_resultado;
        private Label label3;
        private Label label1;
    }
}
