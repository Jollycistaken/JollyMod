using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
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
            Item.width = 83;
            Item.height = 31;
            Item.scale = 0.5f;
            Item.rare = ItemRarityID.LightRed;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 53;
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
    }
}
