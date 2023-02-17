namespace AutoMapper.Modelo
{
    public class EntradaDadosCarro
    {
        public string? Modelo { get; set; }
        public int AnoFabricao { get; set; }
        public double PesoDoCarro { get; set; }
        public Marca Marca { get; set; }
        public Cor CorDoCarro { get; set; }
        public TipoCarro TipoDoCarro { get; set; }
    }
}
