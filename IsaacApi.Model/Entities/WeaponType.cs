using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class WeaponType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeaponTypeId { get; set; }    
        public string WeaponTypeName { get; set; }
        public List<Weapon> Weapons { get; set; }
    }
}