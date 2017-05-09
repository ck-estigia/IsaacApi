using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IsaacApi.Model.Entities
{
    public class CharacterBuidPieces
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharacterBuidPiecesId { get; set; }
        public int CharacterBuildId { get; set; }
        public int CharacterInventoryId { get; set; }
        [ForeignKey("CharacterBuildId")]
        public CharacterBuild CharaterBuild { get; set; }
        [ForeignKey("CharacterInventoryId")]
        public CharacterInventory CharacterInventory { get; set; }
    }
}
