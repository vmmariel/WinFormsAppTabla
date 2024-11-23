//Fatima Mariel Villalpando Mota
namespace WinFormsAppTabla
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
            panelprincipal = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            labelminombre = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(255, 192, 255);
            panelprincipal.Controls.Add(labelminombre);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(0, 2);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(798, 443);
            panelprincipal.TabIndex = 0;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxresultados.Location = new Point(337, 90);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(223, 269);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonver.Location = new Point(126, 170);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(94, 29);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(112, 122);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(125, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelnumero.Location = new Point(81, 87);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(191, 22);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cuál tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labeltitulo.ForeColor = Color.White;
            labeltitulo.Location = new Point(186, 7);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(341, 41);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            labeltitulo.Click += labeltitulo_Click;
            // 
            // labelminombre
            // 
            labelminombre.AutoSize = true;
            labelminombre.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelminombre.Location = new Point(26, 414);
            labelminombre.Name = "labelminombre";
            labelminombre.Size = new Size(202, 18);
            labelminombre.TabIndex = 5;
            labelminombre.Text = "Fatima Mariel Villalpando Mota";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
        private TextBox textBoxnum;
        private Label labelnumero;
        private Label labelminombre;
    }
}
