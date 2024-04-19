using System.Collections.Generic;

public class Expedicao
{
    public string Numero_Pedido { get; set; }
    public int Quantidade_de_Itens { get; set; }
    public List<ListaDeItem> Lista_de_Itens { get; set; }
}
