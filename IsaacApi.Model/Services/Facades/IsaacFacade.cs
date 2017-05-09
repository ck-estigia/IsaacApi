using IsaacApi.Model.BL;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Helpers;
using IsaacApi.Model.Partial;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;

namespace IsaacApi.Model.Services.Facades
{
    public class IsaacFacade : IIsaacFacade
    {
        private IsaacBL _Bl;
        public IsaacFacade(IsaacDbContext model, ILoggerFactory factory)
        {
            _Bl = new IsaacBL(model, factory);
        }

        #region Weapons 
        public List<WeaponTalent> GetWeaponsTalent()
        {
            return _Bl.GetWeaponsTalent();
        }
        public List<WeaponType> GetWeaponsByType()
        {
            return _Bl.GetWeaponsByType();
        }
        #endregion

        #region inventory weapons
        public List<Weapon> GetWeaponsInventory()
        {
            return _Bl.GetWeaponsInventory();
        }
        public List<Weapon> GetWeaponsInventory(int weaponId)
        {
            return _Bl.GetWeaponsInventory();
        }
        #endregion

        #region gear sets
        public List<GoldAttribute> GetGoldAttribute()
        {
            return _Bl.GetGoldAttribute();
        }
        public List<InventoryType> GetInventoryType()
        {
            return _Bl.GetInventoryType();
        }
        public List<SetPiece> GetSetPieces()
        {
            return _Bl.GetSetPieces();
        }
        public List<InventoryAttribute> GetInventoryAttribute()
        {
            return _Bl.GetInventoryAttribute();
        }
        public List<InventoryAttribute> GetInventoryAttribute(int inventoryTypeId)
        {
            return _Bl.GetInventoryAttribute();
        }
        #endregion

        #region characters
        public List<CharacterBuild> GetCharacterBuilds(int playerCharacter)
        {
            return _Bl.GetCharacterBuilds(playerCharacter);
        }

        public List<CharacterInventory> GetCharacterInventory(int playerCharacterId)
        {
            return _Bl.GetCharacterInventory(playerCharacterId);
        }

        public List<PlayerCharacter> GetCharacters()
        {
            return _Bl.GetCharacters();
        }

        public PlayerCharacter CreateCharacter(PlayerCharacter character)
        {
            return _Bl.CreateCharacter(character);
        }

        public void UpdateCharacter(PlayerCharacter character)
        {
            _Bl.UpdateCharacter(character);
        }

        public void DeleteCharacter(int characterId)
        {
            _Bl.DeleteCharacter(characterId);
        }
        #endregion

        #region translations 
        public List<ITranslation> GetTranslations(IsaacLanguages language)
        {
            return _Bl.GetTranslations(language);
        }
        #endregion

    }
}
