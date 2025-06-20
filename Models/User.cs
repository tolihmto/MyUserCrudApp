using System.ComponentModel.DataAnnotations;

namespace UserCrudApp.Models {
    public class User {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nom complet")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Adresse Email")]
        public string Email { get; set; }
    }
}
