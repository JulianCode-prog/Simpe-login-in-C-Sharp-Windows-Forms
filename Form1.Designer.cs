namespace Ejercicio_Login
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
            BtnAcept = new Button();
            label1 = new Label();
            TxtPass = new TextBox();
            label2 = new Label();
            TxtUsuario = new TextBox();
            SuspendLayout();
            // 
            // BtnAcept
            // 
            BtnAcept.Location = new Point(228, 135);
            BtnAcept.Name = "BtnAcept";
            BtnAcept.Size = new Size(75, 23);
            BtnAcept.TabIndex = 0;
            BtnAcept.Text = "Aceptar";
            BtnAcept.UseVisualStyleBackColor = true;
            BtnAcept.Click += BtnAcept_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 72);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su nombre";
            // 
            // TxtPass
            // 
            TxtPass.Location = new Point(218, 106);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(100, 23);
            TxtPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 106);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese su contraseña";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(218, 69);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(100, 23);
            TxtUsuario.TabIndex = 5;
            TxtUsuario.TextChanged += TxtUsuario_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtUsuario);
            Controls.Add(label2);
            Controls.Add(TxtPass);
            Controls.Add(label1);
            Controls.Add(BtnAcept);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAcept;
        private Label label1;
        private TextBox TxtPass;
        private Label label2;
        private TextBox TxtUsuario;
    }
}
