using IsaacApi.Model.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class InventoryAttribute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryAttributeId { get; set; }
        public int InventoryTypeId { get; set; }    
        public string AttributeLabel { get; set; }
        public int AttributeMaxValue { get; set; }
        public IsaacStatType StatType { get; set; }

        [ForeignKey("InventoryTypeId")]
        public InventoryType InventoryType { get; set; }
    }
}