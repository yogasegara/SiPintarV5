namespace AppBusiness.Data.DTOs
{
    public class MasterGolonganDto
    {
        public string KodeGol { get; set; }
        public string KodeGolYangBerlaku { get; set; }
        public int? PeriodeMulaiBerlaku { get; set; }
        public string NamaGolongan { get; set; }
        public string Kategori { get; set; }
        public string Uraian { get; set; }
        public string NomorBa { get; set; }
        public decimal? Administrasi { get; set; } = 0;
        public decimal? Pemeliharaan { get; set; } = 0;
        public decimal? Pelayanan { get; set; } = 0;
        public decimal? Retribusi { get; set; } = 0;
        public decimal? RetribusiPakai { get; set; } = 0;
        public decimal? AirLimbah { get; set; } = 0;
        public decimal? MinPakai { get; set; } = 0;
        public decimal? DendaPakai0 { get; set; } = 0;
        public decimal? DendaTunggakan1 { get; set; } = 0;
        public decimal? DendaTunggakan2 { get; set; } = 0;
        public decimal? DendaTunggakan3 { get; set; } = 0;
        public decimal? DendaTunggakan4 { get; set; } = 0;
        public decimal? DendaTunggakanPerBulan { get; set; } = 0;
        public decimal? MinDenda { get; set; } = 0;
        public decimal? Ppn { get; set; } = 0;
        public decimal? Bb1 { get; set; } = 0;
        public decimal? Bb2 { get; set; } = 0;
        public decimal? Bb3 { get; set; } = 0;
        public decimal? Bb4 { get; set; } = 0;
        public decimal? Bb5 { get; set; } = 0;
        public decimal? Ba1 { get; set; } = 0;
        public decimal? Ba2 { get; set; } = 0;
        public decimal? Ba3 { get; set; } = 0;
        public decimal? Ba4 { get; set; } = 0;
        public decimal? Ba5 { get; set; } = 0;
        public decimal? T1 { get; set; } = 0;
        public decimal? T2 { get; set; } = 0;
        public decimal? T3 { get; set; } = 0;
        public decimal? T4 { get; set; } = 0;
        public decimal? T5 { get; set; } = 0;
        public bool? T1Tetap { get; set; } = false;
        public bool? T2Tetap { get; set; } = false;
        public bool? T3Tetap { get; set; } = false;
        public bool? T4Tetap { get; set; } = false;
        public bool? T5Tetap { get; set; } = false;
        public bool? TrfDendaBerdasarkanPersen { get; set; } = false;
        public bool? Status { get; set; } = false;
    }
}
