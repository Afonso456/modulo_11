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
            txt_valor2.Location = new Point(139, 12);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 99);
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
    }
}
