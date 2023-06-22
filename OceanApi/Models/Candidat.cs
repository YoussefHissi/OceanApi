using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OceanApi
{
    public class Candidat
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName="nvarchar(250)")]
        public String nom { get; set; } = String.Empty;
        public String prenom { get; set; } = String.Empty;
        public String email { get; set; } = String.Empty;
        public String telephone { get; set; } = String.Empty;
        public String Niveau_etude { get; set; } = String.Empty;
        public String Annees_experience { get; set; } = String.Empty;
        public String Dernier_employeur { get; set; } = String.Empty;
        public String cv { get; set; } = String.Empty;

    }
}
