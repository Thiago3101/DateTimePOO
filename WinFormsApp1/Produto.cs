public class Produto
{
    public string Id { get; set; }
    public string Descricao { get; set; }
    public double PrecoAquisicao { get; set; }
    public double PorcentagemVenda { get; set; }
    public double ValorDeVenda { get; set; }
    public Produto() { }
    public Produto(string id, string descricao, double precoAquisicao, double porcentagemVenda, double valorDeVenda) 
    { 
        this.Id = id;
        this.Descricao = descricao;
        this.PrecoAquisicao = precoAquisicao;
        this.PorcentagemVenda = porcentagemVenda;
        this.ValorDeVenda = valorDeVenda;
    }
}