namespace Aplicativo_Escola_Exemplo.PL.Forms
{
    partial class FormAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_cancelar = new Button();
            btn_salvar = new Button();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_cancelar.BackColor = Color.Wheat;
            btn_cancelar.Cursor = Cursors.Hand;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_cancelar.Location = new Point(25, 272);
            btn_cancelar.Margin = new Padding(16, 16, 16, 8);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(156, 32);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_salvar.BackColor = Color.Wheat;
            btn_salvar.Cursor = Cursors.Hand;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_salvar.Location = new Point(283, 272);
            btn_salvar.Margin = new Padding(16, 16, 16, 8);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(156, 32);
            btn_salvar.TabIndex = 6;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            // 
            // FormAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(464, 321);
            Controls.Add(btn_salvar);
            Controls.Add(btn_cancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAlunos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAlunos";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_salvar;
    }
}