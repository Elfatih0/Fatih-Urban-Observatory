using System.ComponentModel.DataAnnotations;

namespace FUO.Models
{
    public class SubSector
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(3)]
        public string Code { get; set; }

        [Required]
        [MaxLength(75)]
        public string EName { get; set; }

        [Required]
        [MaxLength(75)]
        public string AName { get; set; }

        [Required]
        [MaxLength(75)]
        public int Order { get; set; }
    }
}
