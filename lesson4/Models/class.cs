using System.ComponentModel.DataAnnotations;

namespace projectZ.Models
{
    public class simpledatabase_withLists
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public int Coin { get; set; }
        public int? InvitedUser { get; set; }
        [Required]
        public bool userIsVIP { get; set; }
        public Nullable<bool> gender { get; set; }

    }
}