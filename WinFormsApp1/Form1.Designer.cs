namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            codigo = new TextBox();
            descricao = new TextBox();
            aquisicao = new TextBox();
            porcentagem = new TextBox();
            table_product = new DataGridView();
            label6 = new Label();
            valorF = new TextBox();
            ((System.ComponentModel.ISupportInitialize)table_product).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(254, 237);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 59);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 94);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 126);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Preço de aquisição";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(390, 237);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 4;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 163);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 5;
            label4.Text = "Porcentagem de venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 197);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 6;
            label5.Text = "Valor de venda";
            // 
            // codigo
            // 
            codigo.Location = new Point(390, 59);
            codigo.Name = "codigo";
            codigo.Size = new Size(100, 23);
            codigo.TabIndex = 8;
            codigo.TextChanged += codigo_TextChanged;
            // 
            // descricao
            // 
            descricao.Location = new Point(390, 94);
            descricao.Name = "descricao";
            descricao.Size = new Size(100, 23);
            descricao.TabIndex = 9;
            // 
            // aquisicao
            // 
            aquisicao.Location = new Point(390, 126);
            aquisicao.Name = "aquisicao";
            aquisicao.Size = new Size(100, 23);
            aquisicao.TabIndex = 10;
            // 
            // porcentagem
            // 
            porcentagem.Location = new Point(390, 163);
            porcentagem.Name = "porcentagem";
            porcentagem.Size = new Size(100, 23);
            porcentagem.TabIndex = 11;
            // 
            // table_product
            // 
            table_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_product.Location = new Point(12, 296);
            table_product.Name = "table_product";
            table_product.RowTemplate.Height = 25;
            table_product.Size = new Size(776, 150);
            table_product.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Miriam CLM", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(285, 18);
            label6.Name = "label6";
            label6.Size = new Size(214, 27);
            label6.TabIndex = 13;
            label6.Text = "Cadastro de produto";
            // 
            // valorF
            // 
            valorF.Enabled = false;
            valorF.Location = new Point(390, 197);
            valorF.Name = "valorF";
            valorF.Size = new Size(100, 23);
            valorF.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(valorF);
            Controls.Add(label6);
            Controls.Add(table_product);
            Controls.Add(porcentagem);
            Controls.Add(aquisicao);
            Controls.Add(descricao);
            Controls.Add(codigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)table_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label valorFinal;
        private TextBox codigo;
        private TextBox descricao;
        private TextBox aquisicao;
        private TextBox porcentagem;
        private DataGridView table_product;
        private Label label6;
        private TextBox valorF;
    }
}