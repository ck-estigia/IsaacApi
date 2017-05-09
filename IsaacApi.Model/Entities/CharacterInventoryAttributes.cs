using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class CharacterInventoryAttributes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharacterInventoryAttributesId { get; set; }
        public int InventoryAttributeId { get; set; }
        public int CurrentValue { get; set; }
        public int CharacterInventoryId { get; set; }
        [ForeignKey("InventoryAttributeId")]
        public InventoryAttribute InventoryAttribute { get; set; }
        [ForeignKey("CharacterInventoryId")]
        public CharacterInventory CharacterInventory { get; set; }
    }
}