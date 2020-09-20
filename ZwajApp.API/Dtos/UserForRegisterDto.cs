using System.ComponentModel.DataAnnotations;

namespace ZwajApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [StringLength(8,MinimumLength=5,ErrorMessage="يجب أن لا تقل عن 5 أحرف ولا تزيد عن 8 أحرف")]
        public string Password { get; set; }
    }
}