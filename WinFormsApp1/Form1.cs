namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Produto> lista = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = codigo.Text;
            produto.Descricao = descricao.Text;
            produto.PrecoAquisicao = Convert.ToDouble(aquisicao.Text);
            produto.PorcentagemVenda = Convert.ToDouble(porcentagem.Text);


            produto.ValorDeVenda = produto.PrecoAquisicao + (produto.PrecoAquisicao * (produto.PorcentagemVenda / 100));
            valorF.Text = produto.ValorDeVenda.ToString();
            lista.Add(produto);

            /*BindingSource bns = new BindingSource();
            bns.DataSource = lista;
            table_product.DataSource = bns;*/

            table_product.DataSource = null;
            table_product.Refresh();
            table_product.DataSource = lista;
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = table_product.CurrentCell.RowIndex;
            lista.RemoveAt(index);

            table_product.DataSource = null;
            table_product.Refresh();
            table_product.DataSource = lista;
        }
    }
}