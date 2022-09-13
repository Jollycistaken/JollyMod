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
    public class Draco : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Draco");
            Tooltip.SetDefault("The Draco");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            
            Item.width = 114;
            Item.height = 47;
            Item.scale = 0.5f;
            Item.rare = ItemRarityID.LightRed;
            Item.useTime = 14;
            Item.useAnimation = 14;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 23;
            Item.knockBack = 5f;
            Item.noMelee = true;
            Item.shoot = ProjectileID.PurificationPowder; // I LOVE TERRARIA
            Item.shootSpeed = 14f;
            Item.useAmmo = AmmoID.Bullet;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0f, 2f);
        }
    }
}
