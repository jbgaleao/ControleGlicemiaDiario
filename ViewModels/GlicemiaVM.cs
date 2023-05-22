using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleGlicemiaDiario.ViewModels
{
    public class GlicemiaVM
    {



        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(14, ErrorMessage = "Texto ultrapassa os 14 caracteres")]
        [DisplayName("Data/Hora da Medição")]
        public DateTime DataHoraMedicao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(14, ErrorMessage = "Texto ultrapassa os 14 caracteres")]
        [DisplayName("Data/Hora da Aplicação")]
        public DateTime DataHoraAplicação { get; set; }

        [Range(50, 500, ErrorMessage = "O valor deverá estar entre 50 e 500")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayName("Glicemia Medida")]
        public int GlicemiaMedida { get; set; }

        [Range(20, 40, ErrorMessage = "O valor deverá estar entre 20 e 40")]
        [DisplayName("Dose Regular")]
        public int? DoseRegular { get; set; }

        [Range(2, 16, ErrorMessage = "O valor deverá estar entre 20 e 16")]
        [DisplayName("Dose Ajuste")]
        public int? DoseAjuste { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(2048, ErrorMessage = "Texto ultrapassa os 2048 caracteres")]
        [DisplayName("Observações")]
        public string? Observacao { get; set; }
    }
}
