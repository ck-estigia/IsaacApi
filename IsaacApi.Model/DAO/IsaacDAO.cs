using IsaacApi.Model.Entities;
using IsaacApi.Model.Helpers;
using IsaacApi.Model.Partial;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace IsaacApi.Model.DAO
{
    internal class IsaacDAO
    {
        public IsaacDbContext _context;
        public ILogger _logger;

        public IsaacDAO(IsaacDbContext model, ILoggerFactory factory)
        {
            _context = model;
            _logger = factory.CreateLogger("IsaacMysqlProvider");
        }

        #region Weapons 
        public List<WeaponTalent> GetWeaponsTalent()
        {
            return _context.WeaponTalent.ToList();
        }
        public List<WeaponType> GetWeaponsByType()
        {
            return _context.WeaponType.Include(type => type.Weapons).ToList();
        }
        #endregion

        #region inventory weapons
        public List<Weapon> GetWeaponsInventory()
        {
            return _context.Weapons.Include(type => type.WeaponType).ToList();
        }
        public List<Weapon> GetWeaponsInventory(int weaponId)
        {
            return _context.Weapons.Where(p => p.WeaponId == weaponId).ToList();
        }
        #endregion

        #region gear sets
        public List<GoldAttribute> GetGoldAttribute()
        {
            return _context.GoldAttribute.ToList();
        }
        public List<InventoryType> GetInventoryType()
        {
            return _context.InventoryType.Include(inv => inv.InventoryAttribute).ToList();
        }
        public List<SetPiece> GetSetPieces()
        {
            return _context.SetPiece.ToList();
        }
        public List<InventoryAttribute> GetInventoryAttribute()
        {
            return _context.InventoryAttribute
                .Include(type => type.InventoryType)
                .ToList();
        }
        public List<InventoryAttribute> GetInventoryAttribute(int inventoryTypeId)
        {
            return _context.InventoryAttribute
                .Include(type => type.InventoryType)
                .Where(p => p.InventoryTypeId == inventoryTypeId)
                .ToList();
        }
        #endregion

        #region characters
        public List<CharacterBuild> GetCharacterBuilds(int playerCharacter)
        {
            return _context.CharacterBuild
                .Where(m => m.CharacterId == playerCharacter)
                .Include(m => m.PlayerCharacter)
                .Include(m => m.CharacterBuidPieces)
                .ThenInclude(pieces => pieces.CharacterInventory.CharacterInventoryAttributes)
                .ThenInclude(attr => attr.InventoryAttribute.InventoryType.InventoryAttribute)
                .ToList();
        }

        public List<CharacterInventory> GetCharacterInventory(int playerCharacterId)
        {
            return _context.CharacterInventory
                .Where(m => m.CharacterId == playerCharacterId)
                .Include(p => p.InventoryType.InventoryAttribute)
                .Include(p => p.CharacterInventoryAttributes)
                .Include(p => p.PlayerCharacter)
                .ToList();
        }

        public List<PlayerCharacter> GetCharacters()
        {
            return _context.PlayerCharacter.ToList();
        }

        public PlayerCharacter CreateCharacter(PlayerCharacter character)
        {
            character.PlayerCharacterId = 0;
            _context.PlayerCharacter.Add(character);
            _context.SaveChanges();
            return character;
        }

        public void UpdateCharacter(PlayerCharacter character)
        {
            PlayerCharacter playerCharacter = _context.PlayerCharacter
                .Where(p => p.PlayerCharacterId == character.PlayerCharacterId)
                .SingleOrDefault();

            if (playerCharacter == null)
                return;

            playerCharacter.CharacterName = character.CharacterName;
            _context.SaveChanges();
        }

        public void DeleteCharacter(int characterId)
        {
            PlayerCharacter entity = _context.PlayerCharacter
                .Where(p => p.PlayerCharacterId == characterId)
                .SingleOrDefault();

            if (entity == null)
                return;

            _context.PlayerCharacter.Remove(entity);
            _context.SaveChanges();
        }
        #endregion

        #region translations 
        public List<ITranslation> GetTranslations(IsaacLanguages language)
        {
            if (language != IsaacLanguages.EN)
                return new List<ITranslation>();

            return _context.EnTranslations.ToList<ITranslation>();
        }
        #endregion 

    }
}
