
public class Pedido
{
    public required string CGC_Cliente { get; set; }
    public required string Nome { get; set; }
    public required string Forma_de_Pagamento { get; set; }
    public DateTime Data_de_Entrega { get; set; }
    public double Valor_Total { get; set; }
    public int Quantidade_de_Itens { get; set; }
    public required List<Item> Lista_de_Itens { get; set; }
}

