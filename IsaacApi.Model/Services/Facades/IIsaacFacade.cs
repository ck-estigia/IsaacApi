using System.Collections.Generic;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Partial;
using IsaacApi.Model.Helpers;

namespace IsaacApi.Model.Services.Facades
{
    public interface IIsaacFacade
    {
        PlayerCharacter CreateCharacter(PlayerCharacter character);
        void DeleteCharacter(int characterId);
        List<CharacterBuild> GetCharacterBuilds(int playerCharacter);
        List<CharacterInventory> GetCharacterInventory(int playerCharacterId);
        List<PlayerCharacter> GetCharacters();
        List<GoldAttribute> GetGoldAttribute();
        List<InventoryAttribute> GetInventoryAttribute();
        List<InventoryAttribute> GetInventoryAttribute(int inventoryTypeId);
        List<InventoryType> GetInventoryType();
        List<SetPiece> GetSetPieces();
        List<ITranslation> GetTranslations(IsaacLanguages language);
        List<WeaponType> GetWeaponsByType();
        List<Weapon> GetWeaponsInventory();
        List<Weapon> GetWeaponsInventory(int weaponId);
        List<WeaponTalent> GetWeaponsTalent();
        void UpdateCharacter(PlayerCharacter character);
    }
}