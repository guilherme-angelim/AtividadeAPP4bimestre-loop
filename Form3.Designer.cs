namespace atividade.APP_4bimestre
{
    partial class frmex2
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
            btnvoltar = new Button();
            btnlimpar = new Button();
            btncalcularfor = new Button();
            btncalculardowhile = new Button();
            btncalcularwhile = new Button();
            txttemp = new TextBox();
            lblresul = new Label();
            lbltxt = new Label();
            SuspendLayout();
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(579, 357);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 13;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(484, 356);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 12;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btncalcularfor
            // 
            btncalcularfor.Location = new Point(298, 337);
            btncalcularfor.Name = "btncalcularfor";
            btncalcularfor.Size = new Size(131, 59);
            btncalcularfor.TabIndex = 11;
            btncalcularfor.Text = "Calcular (For)";
            btncalcularfor.UseVisualStyleBackColor = true;
            btncalcularfor.Click += btncalcularfor_Click;
            // 
            // btncalculardowhile
            // 
            btncalculardowhile.Location = new Point(161, 337);
            btncalculardowhile.Name = "btncalculardowhile";
            btncalculardowhile.Size = new Size(131, 59);
            btncalculardowhile.TabIndex = 10;
            btncalculardowhile.Text = "Calcular (Do...While)";
            btncalculardowhile.UseVisualStyleBackColor = true;
            btncalculardowhile.Click += btncalculardowhile_Click;
            // 
            // btncalcularwhile
            // 
            btncalcularwhile.Location = new Point(26, 337);
            btncalcularwhile.Name = "btncalcularwhile";
            btncalcularwhile.Size = new Size(131, 59);
            btncalcularwhile.TabIndex = 9;
            btncalcularwhile.Text = "Calcular (While)";
            btncalcularwhile.UseVisualStyleBackColor = true;
            btncalcularwhile.Click += btncalcularwhile_Click;
            // 
            // txttemp
            // 
            txttemp.Location = new Point(106, 113);
            txttemp.Multiline = true;
            txttemp.Name = "txttemp";
            txttemp.ReadOnly = true;
            txttemp.Size = new Size(539, 191);
            txttemp.TabIndex = 17;
            // 
            // lblresul
            // 
            lblresul.AutoSize = true;
            lblresul.Location = new Point(230, 95);
            lblresul.Name = "lblresul";
            lblresul.Size = new Size(277, 15);
            lblresul.TabIndex = 16;
            lblresul.Text = "Temperatura em farenheight (até 100 graus celcius)";
            // 
            // lbltxt
            // 
            lbltxt.AutoSize = true;
            lbltxt.Font = new Font("Segoe UI", 20F);
            lbltxt.Location = new Point(213, 22);
            lbltxt.Name = "lbltxt";
            lbltxt.Size = new Size(346, 37);
            lbltxt.TabIndex = 14;
            lbltxt.Text = "Tempreratura em celcius: 10";
            // 
            // frmex2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txttemp);
            Controls.Add(lblresul);
            Controls.Add(lbltxt);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcularfor);
            Controls.Add(btncalculardowhile);
            Controls.Add(btncalcularwhile);
            Name = "frmex2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 2: Conversão de temperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnvoltar;
        private Button btnlimpar;
        private Button btncalcularfor;
        private Button btncalculardowhile;
        private Button btncalcularwhile;
        private TextBox txttemp;
        private Label lblresul;
        private Label lbltxt;
    }
}