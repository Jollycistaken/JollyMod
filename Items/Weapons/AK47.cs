using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;

namespace JollyTest.Items.Weapons
{
    public class AK47 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AK-47");
            Tooltip.SetDefault("OG Draco");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            SoundStyle AK47Sound = new SoundStyle($"{nameof(JollyTest)}/Sounds/Weapons/AK47")
            {
                Volume = 0.2f,
                PitchVariance = 0.2f,
                MaxInstances = 3,
            };
            Item.width = 154;
            Item.height = 51;
            Item.scale = 0.5f;
            Item.rare = ItemRarityID.LightRed;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 53;
            Item.UseSound = AK47Sound;
            Item.knockBack = 5f;
            Item.noMelee = true;
            Item.shoot = ProjectileID.PurificationPowder; // I LOVE TERRARIA
            Item.shootSpeed = 10f;
            Item.useAmmo = AmmoID.Bullet;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-50f, 0f);
        }
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            Vector2 muzzleOffset = Vector2.Normalize(velocity) * 5f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                
                position.X += muzzleOffset.X;
                position.Y += muzzleOffset.Y;
            }
        }
    }
}
