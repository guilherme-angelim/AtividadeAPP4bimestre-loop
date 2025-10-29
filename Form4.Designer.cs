namespace atividade.APP_4bimestre
{
    partial class frmex3
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
            txtqtd = new TextBox();
            lblqtd = new Label();
            lblareaqtd = new Label();
            txtareaqtd = new TextBox();
            txttotal = new TextBox();
            lbltotal = new Label();
            SuspendLayout();
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(587, 574);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 18;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(492, 573);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 17;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btncalcularfor
            // 
            btncalcularfor.Location = new Point(306, 554);
            btncalcularfor.Name = "btncalcularfor";
            btncalcularfor.Size = new Size(131, 59);
            btncalcularfor.TabIndex = 16;
            btncalcularfor.Text = "Calcular (For)";
            btncalcularfor.UseVisualStyleBackColor = true;
            btncalcularfor.Click += btncalcularfor_Click;
            // 
            // btncalculardowhile
            // 
            btncalculardowhile.Location = new Point(169, 554);
            btncalculardowhile.Name = "btncalculardowhile";
            btncalculardowhile.Size = new Size(131, 59);
            btncalculardowhile.TabIndex = 15;
            btncalculardowhile.Text = "Calcular (Do...While)";
            btncalculardowhile.UseVisualStyleBackColor = true;
            btncalculardowhile.Click += btncalculardowhile_Click;
            // 
            // btncalcularwhile
            // 
            btncalcularwhile.Location = new Point(34, 554);
            btncalcularwhile.Name = "btncalcularwhile";
            btncalcularwhile.Size = new Size(131, 59);
            btncalcularwhile.TabIndex = 14;
            btncalcularwhile.Text = "Calcular (While)";
            btncalcularwhile.UseVisualStyleBackColor = true;
            btncalcularwhile.Click += btncalcularwhile_Click;
            // 
            // txtqtd
            // 
            txtqtd.Location = new Point(224, 49);
            txtqtd.Name = "txtqtd";
            txtqtd.Size = new Size(155, 23);
            txtqtd.TabIndex = 20;
            txtqtd.TextChanged += txtqtd_TextChanged;
            // 
            // lblqtd
            // 
            lblqtd.AutoSize = true;
            lblqtd.Location = new Point(25, 57);
            lblqtd.Name = "lblqtd";
            lblqtd.Size = new Size(193, 15);
            lblqtd.TabIndex = 19;
            lblqtd.Text = "Informe a quantidade de cômodos:";
            // 
            // lblareaqtd
            // 
            lblareaqtd.AutoSize = true;
            lblareaqtd.Location = new Point(34, 133);
            lblareaqtd.Name = "lblareaqtd";
            lblareaqtd.Size = new Size(109, 15);
            lblareaqtd.TabIndex = 21;
            lblareaqtd.Text = "Área dos cômodos:";
            // 
            // txtareaqtd
            // 
            txtareaqtd.Location = new Point(169, 125);
            txtareaqtd.Multiline = true;
            txtareaqtd.Name = "txtareaqtd";
            txtareaqtd.ReadOnly = true;
            txtareaqtd.Size = new Size(493, 239);
            txtareaqtd.TabIndex = 22;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(169, 394);
            txttotal.Multiline = true;
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(493, 23);
            txttotal.TabIndex = 24;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(34, 402);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(103, 15);
            lbltotal.TabIndex = 23;
            lbltotal.Text = "Área total da casa:";
            // 
            // frmex3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 652);
            ControlBox = false;
            Controls.Add(txttotal);
            Controls.Add(lbltotal);
            Controls.Add(txtareaqtd);
            Controls.Add(lblareaqtd);
            Controls.Add(txtqtd);
            Controls.Add(lblqtd);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcularfor);
            Controls.Add(btncalculardowhile);
            Controls.Add(btncalcularwhile);
            Name = "frmex3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 3: Calculo de área";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvoltar;
        private Button btnlimpar;
        private Button btncalcularfor;
        private Button btncalculardowhile;
        private Button btncalcularwhile;
        private TextBox txtqtd;
        private Label lblqtd;
        private Label lblareaqtd;
        private TextBox txtareaqtd;
        private TextBox txttotal;
        private Label lbltotal;
    }
}