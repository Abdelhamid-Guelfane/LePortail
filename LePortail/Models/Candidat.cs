using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LePortail.Models
{
    [Table("Candidat", Schema = "EspaceCandidat")]

    public class Candidat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCandidat { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nom { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "smallint")]
        [Display(Name = "Télephone")]
        public int Tel { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        [Display(Name = "Niveau d’étude")]
        public string NiveauDetude { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        [Display(Name = "Années d’expérience")]
        public string AnneesExperience { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Dernier employeur")]
        public string DernierEmployeur { get; set; }

        [NotMapped]
        public IFormFile CvCandidat { get; set; }

        
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Chemin du cv")]
        public string CheminDuCv { get; set; }

        

    }
    }
