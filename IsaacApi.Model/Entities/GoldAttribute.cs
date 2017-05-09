using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class GoldAttribute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoldAttributeId { get; set; }
        public string GoldAttributeLabel { get; set; }
        public string GoldAttributeDescription { get; set; }
    }
}