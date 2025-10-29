namespace atividade.APP_4bimestre
{
    partial class frmmenu
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
            menuStrip1 = new MenuStrip();
            tsmex = new ToolStripMenuItem();
            tsmiex1 = new ToolStripMenuItem();
            tsmiex2 = new ToolStripMenuItem();
            tsmiex3 = new ToolStripMenuItem();
            tsmsair = new ToolStripMenuItem();
            lbltxt = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmex, tsmsair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmex
            // 
            tsmex.DropDownItems.AddRange(new ToolStripItem[] { tsmiex1, tsmiex2, tsmiex3 });
            tsmex.Name = "tsmex";
            tsmex.Size = new Size(70, 20);
            tsmex.Text = "Exercícios";
            // 
            // tsmiex1
            // 
            tsmiex1.Name = "tsmiex1";
            tsmiex1.Size = new Size(180, 22);
            tsmiex1.Text = "Ex. 1: Tabuada";
            tsmiex1.Click += tsmiex1_Click;
            // 
            // tsmiex2
            // 
            tsmiex2.Name = "tsmiex2";
            tsmiex2.Size = new Size(240, 22);
            tsmiex2.Text = "Ex.2: Conversão de temperatura";
            tsmiex2.Click += tsmiex2_Click;
            // 
            // tsmiex3
            // 
            tsmiex3.Name = "tsmiex3";
            tsmiex3.Size = new Size(240, 22);
            tsmiex3.Text = "Ex.3: Cálculo de áreas";
            tsmiex3.Click += tsmiex3_Click;
            // 
            // tsmsair
            // 
            tsmsair.Name = "tsmsair";
            tsmsair.Size = new Size(38, 20);
            tsmsair.Text = "Sair";
            tsmsair.Click += tsmsair_Click;
            // 
            // lbltxt
            // 
            lbltxt.AutoSize = true;
            lbltxt.Font = new Font("Segoe UI", 20F);
            lbltxt.Location = new Point(0, 131);
            lbltxt.Name = "lbltxt";
            lbltxt.Size = new Size(299, 37);
            lbltxt.TabIndex = 15;
            lbltxt.Text = "Criadores do programa:";
            lbltxt.Click += lbltxt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(0, 216);
            label1.Name = "label1";
            label1.Size = new Size(203, 21);
            label1.TabIndex = 16;
            label1.Text = "Guilherme Ferreira Angelim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(0, 180);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 17;
            label2.Text = "Anna Beatriz Xavier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(707, 413);
            label3.Name = "label3";
            label3.Size = new Size(81, 37);
            label3.TabIndex = 18;
            label3.Text = "1°D.S";
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbltxt);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmex;
        private ToolStripMenuItem tsmiex1;
        private ToolStripMenuItem tsmiex2;
        private ToolStripMenuItem tsmiex3;
        private ToolStripMenuItem tsmsair;
        private Label lbltxt;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}