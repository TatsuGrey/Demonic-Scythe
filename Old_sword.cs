using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Mod01.Items
{
    public class Old_sword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Old_sword");
            Tooltip.SetDefault("This is a basic modded sword. Has vampiric properties.");
        }

        public override void SetDefaults()
        {
            Item.damage = 500;
			Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
			Item.crit = 40;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void OnHitNPC(
            Player player,
            NPC target,
            int damage,
            float knockback,
            bool crit
        )
        {
            player.statLife += 50;
            target.life -= 50;
            if (player.statLife > player.statLifeMax2)
            {
                player.statLife = player.statLifeMax2;
            }
        }

         public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.RubyStaff)
            .AddIngredient(ItemID.Fireblossom, 5)
            .AddIngredient(ItemID.SpectreBar, 12)
            .AddTile(TileID.MythrilAnvil)
            .Register();
        }
    }
}
