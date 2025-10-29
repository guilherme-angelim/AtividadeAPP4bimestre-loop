namespace atividade.APP_4bimestre
{
    partial class frmex1
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
            lblnum = new Label();
            txtnum = new TextBox();
            btncalcularwhile = new Button();
            btncalculardowhile = new Button();
            btncalcularfor = new Button();
            lblresul = new Label();
            txtresul = new TextBox();
            btnlimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(26, 58);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(150, 15);
            lblnum.TabIndex = 0;
            lblnum.Text = "Digite um número de 1 a 9:";
            // 
            // txtnum
            // 
            txtnum.Location = new Point(182, 50);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(155, 23);
            txtnum.TabIndex = 1;
            // 
            // btncalcularwhile
            // 
            btncalcularwhile.Location = new Point(26, 337);
            btncalcularwhile.Name = "btncalcularwhile";
            btncalcularwhile.Size = new Size(131, 59);
            btncalcularwhile.TabIndex = 2;
            btncalcularwhile.Text = "Calcular (While)";
            btncalcularwhile.UseVisualStyleBackColor = true;
            btncalcularwhile.Click += btncalcularwhile_Click;
            // 
            // btncalculardowhile
            // 
            btncalculardowhile.Location = new Point(163, 337);
            btncalculardowhile.Name = "btncalculardowhile";
            btncalculardowhile.Size = new Size(131, 59);
            btncalculardowhile.TabIndex = 3;
            btncalculardowhile.Text = "Calcular (Do...While)";
            btncalculardowhile.UseVisualStyleBackColor = true;
            btncalculardowhile.Click += btncalculardowhile_Click;
            // 
            // btncalcularfor
            // 
            btncalcularfor.Location = new Point(300, 337);
            btncalcularfor.Name = "btncalcularfor";
            btncalcularfor.Size = new Size(131, 59);
            btncalcularfor.TabIndex = 4;
            btncalcularfor.Text = "Calcular (For)";
            btncalcularfor.UseVisualStyleBackColor = true;
            btncalcularfor.Click += btncalcularfor_Click;
            // 
            // lblresul
            // 
            lblresul.AutoSize = true;
            lblresul.Location = new Point(26, 110);
            lblresul.Name = "lblresul";
            lblresul.Size = new Size(75, 15);
            lblresul.TabIndex = 5;
            lblresul.Text = "Sua tabuada:";
            // 
            // txtresul
            // 
            txtresul.Location = new Point(107, 102);
            txtresul.Multiline = true;
            txtresul.Name = "txtresul";
            txtresul.ReadOnly = true;
            txtresul.Size = new Size(539, 191);
            txtresul.TabIndex = 6;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(486, 355);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 7;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(581, 355);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 8;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmex1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(txtresul);
            Controls.Add(lblresul);
            Controls.Add(btncalcularfor);
            Controls.Add(btncalculardowhile);
            Controls.Add(btncalcularwhile);
            Controls.Add(txtnum);
            Controls.Add(lblnum);
            Name = "frmex1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício n°1: Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnum;
        private TextBox txtnum;
        private Button btncalcularwhile;
        private Button btncalculardowhile;
        private Button btncalcularfor;
        private Label lblresul;
        private TextBox txtresul;
        private Button btnlimpar;
        private Button btnvoltar;
    }
}
