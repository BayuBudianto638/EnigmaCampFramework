using System.ComponentModel.DataAnnotations;

namespace EnigmaCamp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}