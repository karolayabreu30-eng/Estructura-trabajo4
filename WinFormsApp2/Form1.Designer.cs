namespace WinFormsApp2
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
            btnEjercicio2 = new Button();
            lstResultados = new ListBox();
            SuspendLayout();
            // 
            // btnEjercicio2
            // 
            btnEjercicio2.Location = new Point(94, 220);
            btnEjercicio2.Name = "btnEjercicio2";
            btnEjercicio2.Size = new Size(94, 29);
            btnEjercicio2.TabIndex = 1;
            btnEjercicio2.Text = "Click";
            btnEjercicio2.UseVisualStyleBackColor = true;
            btnEjercicio2.Click += btnEjercicio2_Click;
            // 
            // lstResultados
            // 
            lstResultados.BackColor = SystemColors.MenuBar;
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(38, 35);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(208, 164);
            lstResultados.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(310, 284);
            Controls.Add(btnEjercicio2);
            Controls.Add(lstResultados);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnEjercicio2;
        private ListBox lstResultados;
    }
}
