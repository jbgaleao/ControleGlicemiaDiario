namespace ControleGlicemiaDiario.Models
{
    public class Glicemia
    {
        public int Id { get; set; }
        public DateTime DataAplicacao { get; set; }
        public DateTime HoraAplicacao { get; set; }
        public int GlicemiaMedida { get; set; }
        public int? DoseRegulat { get; set; }
        public int? DoseAjuste { get; set; }
        public string? Observacao { get; set; }
    }
}
