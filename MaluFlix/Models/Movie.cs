using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MaluFlix.Models;

    [Table("Movie")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

         [Display(Name = "Título")]
        [Required(ErrorMessage ="O Título é obrigatório")]
        [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 30 caracteres")]
          public string Title { get; set; }

         [Display(Name = "Título Original")]
        [Required(ErrorMessage ="O Título Original é obrigatório")]
        [StringLength(100, ErrorMessage = "O Título Original deve possuir no máximo 30 caracteres")]
        public string OriginalTitle { get; set; }

        [Display(Name = "Sinopse")]
         [Required(ErrorMessage ="A Sinopse é obrigatória")]
        [StringLength(8000, ErrorMessage = "A Sipnose deve possuir no máximo 8000 caracteres")]
        public string Synopsis { get; set; }

        [Column(TypeName ="Year")]
        [Display(Name = "Ano de Estreia")]
        [Required(ErrorMessage = "O Ano de Estreia é obrigatório")]
         public Int16 MovieYear { get; set; }
        
        [Display(Name = "Duracão (em minutos")]
        [Required(ErrorMessage = "A Duração é obrigatória")]
         public Int16 Duration { get; set; }

         [Display(Name = "Classificação Etária")]
         [Required(ErrorMessage = "A Classisficação Etária é obrigatória")]
         public int AgeRating { get; set; }
         
         [StringLength(200)]
         [Display(Name = "Foto")]
          public string Image { get; set; }

          [NotMapped]
          [Display(Name = "Duração")]
          public string HourDuration { get{
                    return TimeSpan.FromMinutes(Duration) .ToString(@"%h'h 'mm'min'");
          }}
    }