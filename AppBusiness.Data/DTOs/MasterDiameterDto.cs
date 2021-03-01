namespace AppBusiness.Data.DTOs
{
    public class MasterDiameterDto
    {
        public string KodeDiameter { get; set; }
        public string KodeDiameterYangBerlaku { get; set; }
        public int? PeriodeMulaiBerlaku { get; set; }      
        public string NamaDiameter { get; set; }
        public decimal? Administrasi { get; set; } = 0;
        public decimal? Pemeliharaan { get; set; } = 0;
        public decimal? Pelayanan { get; set; } = 0;
        public decimal? Retribusi { get; set; } = 0;
        public decimal? DendaPakai0 { get; set; } = 0;
        public decimal? AirLimbah { get; set; } = 0;
        public string NomorBa { get; set; }
        public bool? Status { get; set; }

    }
}
