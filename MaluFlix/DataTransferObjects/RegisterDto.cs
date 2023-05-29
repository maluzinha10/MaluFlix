using System.ComponentModel.DataAnnotations;

namespace MaluFlix.DataTransferObjects;

    public class RegisterDto
    {
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua Data de Nasciemnto")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu Email")]
        [EmailAddress(ErrorMessage = "Por favor, informe um Email válido")]
        [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }

          [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso")]
        [Required(ErrorMessage = "Por favor, informe a sua Senga de Acesso")]
        [StringLength(20, MinimumLength =6, ErrorMessage = "A Senha deve possuir no mínimo 6 e o máximo 20 caracteres")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha de Acesso")]
        [Required(ErrorMessage = "Por favor, informe a sua Senga de Acesso")]
        public string ConfirmPassword { get; set; }
    }
