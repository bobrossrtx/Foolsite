using Terraria.ModLoader;

namespace FoolsMod
{
    public class FoolsMod : Mod
    {
        public static FoolsMod Instance;

        public FoolsMod()
        {
            Instance = this;
        }

        public override void Load()
        {
            if (Instance == null || Instance != this)
            {
                Instance = this;
            }
        }
    }
}