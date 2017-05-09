using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IsaacApi.Model.Entities
{
    public class IsaacDbContext : DbContext
    {
        public DbSet<EnTranslations> EnTranslations { get; set; }

        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<WeaponType> WeaponType { get; set; }

        public DbSet<WeaponTalent> WeaponTalent { get; set; }

        public DbSet<InventoryType> InventoryType { get; set; }

        public DbSet<SetPiece> SetPiece { get; set; }

        public DbSet<InventoryAttribute> InventoryAttribute { get; set; }

        public DbSet<GoldAttribute> GoldAttribute { get; set; }

        public DbSet<PlayerCharacter> PlayerCharacter { get; set; }

        public DbSet<CharacterInventory> CharacterInventory { get; set; }

        public DbSet<CharacterInventoryAttributes> CharacterInventoryAttributes { get; set; }

        public DbSet<CharacterBuild> CharacterBuild { get; set; }

        public DbSet<CharacterBuidPieces> CharacterBuidPieces { get; set; }

        public IsaacDbContext(DbContextOptions options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EnTranslations>().HasKey(m => m.EnTranslationsId);
            builder.Entity<Weapon>().HasKey((Expression<Func<Weapon, object>>)(m => (object)m.WeaponId));
            builder.Entity<WeaponType>().HasKey((Expression<Func<WeaponType, object>>)(m => (object)m.WeaponTypeId));
            builder.Entity<InventoryType>().HasKey((Expression<Func<InventoryType, object>>)(m => (object)m.InventoryTypeId));
            builder.Entity<SetPiece>().HasKey((Expression<Func<SetPiece, object>>)(m => (object)m.SetPieceId));
            builder.Entity<InventoryAttribute>().HasKey((Expression<Func<InventoryAttribute, object>>)(m => (object)m.InventoryAttributeId));
            builder.Entity<GoldAttribute>().HasKey((Expression<Func<GoldAttribute, object>>)(m => (object)m.GoldAttributeId));
            builder.Entity<PlayerCharacter>().HasKey((Expression<Func<PlayerCharacter, object>>)(m => (object)m.PlayerCharacterId));
            builder.Entity<CharacterInventory>().HasKey((Expression<Func<CharacterInventory, object>>)(m => (object)m.CharacterInventoryId));
            builder.Entity<WeaponTalent>().HasKey((Expression<Func<WeaponTalent, object>>)(m => (object)m.WeaponTalentId));
            builder.Entity<CharacterInventoryAttributes>().HasKey((Expression<Func<CharacterInventoryAttributes, object>>)(m => (object)m.CharacterInventoryAttributesId));
            builder.Entity<CharacterBuild>().HasKey((Expression<Func<CharacterBuild, object>>)(m => (object)m.CharacterBuildId));
            builder.Entity<CharacterBuidPieces>().HasKey((Expression<Func<CharacterBuidPieces, object>>)(m => (object)m.CharacterBuidPiecesId));
            base.OnModelCreating(builder);
        }
    }
}
