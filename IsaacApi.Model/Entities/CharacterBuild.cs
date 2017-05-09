using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class CharacterBuild
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharacterBuildId { get; set; }
        public string BuildLabel { get; set; }
        public int CharacterId { get; set; }
        [ForeignKey("CharacterId")]
        public PlayerCharacter PlayerCharacter { get; set; }
        public List<CharacterBuidPieces> CharacterBuidPieces { get; set; }
    }
}