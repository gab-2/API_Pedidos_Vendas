// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BOLETO
    {
        public string CGC { get; set; }
        public double Valor { get; set; }
    }

    public class CARTAO
    {
        public string Numero { get; set; }
        public double Valor { get; set; }
    }

    public class PIX
    {
        public string Chave { get; set; }
        public double Valor { get; set; }
    }

    public class Root
    {
        public string Numero_Pedido { get; set; }
        public string CGC { get; set; }
        public PIX PIX { get; set; }
        public BOLETO BOLETO { get; set; }
        public CARTAO CARTAO { get; set; }
    }

