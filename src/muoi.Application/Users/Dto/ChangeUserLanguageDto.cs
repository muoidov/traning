using System.ComponentModel.DataAnnotations;

namespace muoi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}