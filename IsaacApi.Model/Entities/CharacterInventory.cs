using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class CharacterInventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharacterInventoryId { get; set; }

        public int CharacterId { get; set; }

        public int InventoryTypeId { get; set; }

        public int? SetPieceId { get; set; }

        public int? GoldAttributeId { get; set; }

        public List<CharacterInventoryAttributes> CharacterInventoryAttributes { get; set; }

        [ForeignKey("InventoryTypeId")]
        public InventoryType InventoryType { get; set; }

        [ForeignKey("CharacterId")]
        public PlayerCharacter PlayerCharacter { get; set; }
    }
}