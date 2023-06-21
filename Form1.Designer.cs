namespace Atividade_V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Pes = new Button();
            Cad = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Cid = new TextBox();
            Est = new TextBox();
            Uf = new TextBox();
            Reg = new TextBox();
            Lim = new Button();
            Nov = new Button();
            SuspendLayout();
            // 
            // Pes
            // 
            Pes.BackColor = Color.Ivory;
            Pes.BackgroundImageLayout = ImageLayout.Center;
            Pes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Pes.ForeColor = SystemColors.ControlText;
            Pes.Location = new Point(428, 354);
            Pes.Name = "Pes";
            Pes.RightToLeft = RightToLeft.Yes;
            Pes.Size = new Size(111, 46);
            Pes.TabIndex = 0;
            Pes.Text = "Pesquisar";
            Pes.UseVisualStyleBackColor = false;
            Pes.Click += Pes_Click;
            // 
            // Cad
            // 
            Cad.BackColor = Color.Ivory;
            Cad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cad.Location = new Point(279, 354);
            Cad.Name = "Cad";
            Cad.Size = new Size(111, 46);
            Cad.TabIndex = 1;
            Cad.Text = "Cadastrar";
            Cad.UseVisualStyleBackColor = false;
            Cad.Click += Cad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 75);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 2;
            label1.Text = "Cidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 171);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 3;
            label2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Ivory;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(458, 171);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 4;
            label3.Text = "Região";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Ivory;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(487, 79);
            label4.Name = "label4";
            label4.Size = new Size(29, 21);
            label4.TabIndex = 5;
            label4.Text = "UF";
            // 
            // Cid
            // 
            Cid.BackColor = Color.Ivory;
            Cid.Location = new Point(157, 77);
            Cid.Name = "Cid";
            Cid.Size = new Size(183, 23);
            Cid.TabIndex = 6;
            Cid.TextChanged += Cid_TextChanged;
            // 
            // Est
            // 
            Est.BackColor = Color.Ivory;
            Est.Location = new Point(157, 173);
            Est.Name = "Est";
            Est.Size = new Size(183, 23);
            Est.TabIndex = 7;
            // 
            // Uf
            // 
            Uf.BackColor = Color.Ivory;
            Uf.Location = new Point(561, 77);
            Uf.Name = "Uf";
            Uf.Size = new Size(183, 23);
            Uf.TabIndex = 8;
            // 
            // Reg
            // 
            Reg.BackColor = Color.Ivory;
            Reg.Location = new Point(561, 173);
            Reg.Name = "Reg";
            Reg.Size = new Size(183, 23);
            Reg.TabIndex = 9;
            // 
            // Lim
            // 
            Lim.BackColor = Color.Ivory;
            Lim.BackgroundImageLayout = ImageLayout.Center;
            Lim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lim.ForeColor = SystemColors.ControlText;
            Lim.Location = new Point(561, 354);
            Lim.Name = "Lim";
            Lim.RightToLeft = RightToLeft.Yes;
            Lim.Size = new Size(111, 46);
            Lim.TabIndex = 10;
            Lim.Text = "Limpar";
            Lim.UseVisualStyleBackColor = false;
            Lim.Click += Lim_Click;
            // 
            // Nov
            // 
            Nov.BackColor = Color.Ivory;
            Nov.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nov.Location = new Point(133, 354);
            Nov.Name = "Nov";
            Nov.Size = new Size(111, 46);
            Nov.TabIndex = 11;
            Nov.Text = "Novo";
            Nov.UseVisualStyleBackColor = false;
            Nov.Click += Nov_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Nov);
            Controls.Add(Lim);
            Controls.Add(Reg);
            Controls.Add(Uf);
            Controls.Add(Est);
            Controls.Add(Cid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cad);
            Controls.Add(Pes);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Brasil";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Pes;
        private Button Cad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Cid;
        private TextBox Est;
        private TextBox Uf;
        private TextBox Reg;
        private Button Lim;
        private Button Nov;
    }
}