using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class Weapon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeaponId { get; set; }
        public string WeaponName { get; set; }
        public int WeaponScale { get; set; }
        public int DamagePerMinute { get; set; }
        public int MagazineSize { get; set; }
        public int OptimalRange { get; set; }
        public int ReloadSpeed { get; set; }
        public int HeadShotMultiplier { get; set; }
        public int MaxDamage { get; set; }
        public bool SupportUnderBarrel { get; set; }
        public bool SupportMuzzle { get; set; }
        public bool SupportMagazine { get; set; }
        public bool SupportOptic { get; set; }
        public string Symbol { get; set; }
        public int WeaponTypeId { get; set; }
        [ForeignKey("WeaponTypeId")]
        public WeaponType WeaponType { get; set; }
    }
}