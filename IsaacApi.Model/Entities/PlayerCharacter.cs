using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IsaacApi.Model.Entities
{
    public class PlayerCharacter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerCharacterId { set; get; }
        public string CharacterName { set; get; }
    }
}
