namespace AutoMapper.Modelo
{
    public class SaidaDeDadosCarro
    {
        public string? Modelo { get; set; }
        public int AnoFabricao { get; set; }
        public double PesoDoCarro { get; set; }
        public string? Marca { get; set; }
        public string? CorDoCarro { get; set; }
        public string? TipoDoCarro { get; set; }
        public string? Vendido { get; set; }
        public string DescriDoCarro => $"Modelo : {Modelo} - Marca : {Marca} - Cor: {CorDoCarro} - Tipo: {TipoDoCarro}";
    }
}
