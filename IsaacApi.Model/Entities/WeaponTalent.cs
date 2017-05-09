using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class WeaponTalent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeaponTalentId { get; set; }
        public string WeaponTalentName { get; set; }
        public string WeaponTalentDescription { get; set; }
        public int FirearmsRequirement { get; set; }
        public int StaminaRequirement { get; set; }
        public int ElectronicsRequirement { get; set; }    
        public bool AssaultRifle { get; set; }
        public bool LighthMachineGun { get; set; }
        public bool SubmachineGun { get; set; }
        public bool MarksManRifle { get; set; }
        public bool Shotgun { get; set; }
        public bool Pistol { get; set; }
        public string WeaponTalentLogo { get; set; }
    }
}