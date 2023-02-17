namespace AutoMapper.Modelo
{
    public class Carro
    {
        public Carro()
        {

        }

        public Carro(int id, string modelo, int anoFabricao, double pesoDoCarro, Marca marca, Cor corDoCarro, TipoCarro tipoDoCarro, bool vendido)
        {
            Id = id;
            Modelo = modelo;
            AnoFabricao = anoFabricao;
            PesoDoCarro = pesoDoCarro;
            Marca = marca;
            CorDoCarro = corDoCarro;
            TipoDoCarro = tipoDoCarro;
            Vendido = vendido;
        }

        public int Id { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricao { get; set; }
        public double PesoDoCarro { get; set; }
        public Marca Marca { get; set; }
        public Cor CorDoCarro { get; set; }
        public TipoCarro TipoDoCarro { get; set; }
        public bool Vendido { get; set; }
        public DateTime DtCadastro { get; set; }
    }
}
