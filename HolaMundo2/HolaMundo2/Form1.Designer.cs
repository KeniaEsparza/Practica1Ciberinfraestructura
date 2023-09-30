namespace HolaMundo2
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
            txtContrasena1 = new TextBox();
            txtContrasena2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn1validar = new Button();
            SuspendLayout();
            // 
            // txtContrasena1
            // 
            txtContrasena1.Location = new Point(199, 90);
            txtContrasena1.Name = "txtContrasena1";
            txtContrasena1.Size = new Size(100, 23);
            txtContrasena1.TabIndex = 0;
            // 
            // txtContrasena2
            // 
            txtContrasena2.Location = new Point(199, 128);
            txtContrasena2.Name = "txtContrasena2";
            txtContrasena2.Size = new Size(100, 23);
            txtContrasena2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 98);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese una contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 136);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Repite contraseña";
            // 
            // btn1validar
            // 
            btn1validar.Location = new Point(201, 198);
            btn1validar.Name = "btn1validar";
            btn1validar.Size = new Size(75, 23);
            btn1validar.TabIndex = 4;
            btn1validar.Text = "Validar";
            btn1validar.UseVisualStyleBackColor = true;
            btn1validar.Click += btn1validar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 259);
            Controls.Add(btn1validar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena2);
            Controls.Add(txtContrasena1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasena1;
        private TextBox txtContrasena2;
        private Label label1;
        private Label label2;
        private Button btn1validar;
    }
}