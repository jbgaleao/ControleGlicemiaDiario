namespace ControleGlicemiaDiario.Models
{
    public class Glicemia
    {
        public int Id { get; set; }
        public DateTime DataHoraMedicao { get; set; }
        public DateTime DataHoraAplicacao { get; set; }
        public int GlicemiaMedida { get; set; }
        public int? DoseRegular { get; set; }
        public int? DoseAjuste { get; set; }
        public string? Observacao { get; set; }
    }
}
