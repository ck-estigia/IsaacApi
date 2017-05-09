using IsaacApi.Model.DAO;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Helpers;
using IsaacApi.Model.Partial;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace IsaacApi.Model.BL
{
    internal class IsaacBL
    {
        private IsaacDAO _Dao;
        public IsaacBL(IsaacDbContext model, ILoggerFactory factory)
        {
            _Dao = new IsaacDAO(model, factory);
        }

        #region Weapons 
        public List<WeaponTalent> GetWeaponsTalent()
        {
            return _Dao.GetWeaponsTalent();
        }
        public List<WeaponType> GetWeaponsByType()
        {
            return _Dao.GetWeaponsByType();
        }
        #endregion

        #region inventory weapons
        public List<Weapon> GetWeaponsInventory()
        {
            return _Dao.GetWeaponsInventory();
        }
        public List<Weapon> GetWeaponsInventory(int weaponId)
        {
            return _Dao.GetWeaponsInventory();
        }
        #endregion

        #region gear sets
        public List<GoldAttribute> GetGoldAttribute()
        {
            return _Dao.GetGoldAttribute();
        }
        public List<InventoryType> GetInventoryType()
        {
            return _Dao.GetInventoryType();
        }
        public List<SetPiece> GetSetPieces()
        {
            return _Dao.GetSetPieces();
        }
        public List<InventoryAttribute> GetInventoryAttribute()
        {
            return _Dao.GetInventoryAttribute();
        }
        public List<InventoryAttribute> GetInventoryAttribute(int inventoryTypeId)
        {
            return _Dao.GetInventoryAttribute();
        }
        #endregion

        #region characters
        public List<CharacterBuild> GetCharacterBuilds(int playerCharacter)
        {
            return _Dao.GetCharacterBuilds(playerCharacter);
        }

        public List<CharacterInventory> GetCharacterInventory(int playerCharacterId)
        {
            return _Dao.GetCharacterInventory(playerCharacterId);
        }

        public List<PlayerCharacter> GetCharacters()
        {
            return _Dao.GetCharacters();
        }

        public PlayerCharacter CreateCharacter(PlayerCharacter character)
        {
            return _Dao.CreateCharacter(character);
        }

        public void UpdateCharacter(PlayerCharacter character)
        {
            _Dao.UpdateCharacter(character);
        }

        public void DeleteCharacter(int characterId)
        {
            _Dao.DeleteCharacter(characterId);
        }
        #endregion

        #region translations 
        public List<ITranslation> GetTranslations(IsaacLanguages language)
        {
            return _Dao.GetTranslations(language);
        }
        #endregion 
    }
}
