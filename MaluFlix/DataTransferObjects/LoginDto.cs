using System.ComponentModel.DataAnnotations;
namespace MaluFlix.DataTransferObjects;
    public class LoginDto
    {
        [Display(Name = "Email ou Nome do Usuário")]
        [Required(ErrorMessage = "Por favor, informa seu email ou nome do usuário")]
        public string Email { get; set; }
        [Display(Name = "Senha de Acesso")]
        [Required(ErrorMessage = "Por favor, informe sua senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Manter Conectado?")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
