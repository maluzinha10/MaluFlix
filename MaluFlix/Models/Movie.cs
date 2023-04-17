using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MaluFlix.Models;

    [Table("Movie")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Título Original")]
        [Required(ErrorMessage ="O Título Original é obrigatório")]
        [StringLength(100, ErrorMessage = "O Título Original deve possuir no máximo 30 caracteres")]
        public string OriginalTitle { get; set; }

         [Display(Name = "Título")]
        [Required(ErrorMessage ="O Título é obrigatório")]
        [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 30 caracteres")]
        public string Title { get; set; }
        [Display(Name = "Sinopse")]
        [StringLength(100, ErrorMessage = "A Sipnose deve possuir no máximo 5000 caracteres")]
        
        public string Synopsis { get; set; }
         public int MovieYear { get; set; }
         public int Duration { get; set; }
         public int AgeRating { get; set; }
          public string Image { get; set; }
    }
