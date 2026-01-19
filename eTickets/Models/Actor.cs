using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full Name is Required")]
        [MaxLength(40, ErrorMessage ="Full Name cannot exceed 40 characters")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        [MinLength(5, ErrorMessage = "Biography must be at least 5 characters long")]
        public string Bio { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }

        // -- Relationships --
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
