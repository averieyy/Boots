using Raylib_cs;

namespace Ashlad {

    class Img {

        public static Texture2D ASHUP = FromInfo("./assets/images/ashlad/back.png");
        public static Texture2D ASHLEFT = FromInfo("./assets/images/ashlad/left.png");
        public static Texture2D ASHDOWN = FromInfo("./assets/images/ashlad/front.png");
        public static Texture2D ASHRIGHT = FromInfo("./assets/images/ashlad/right.png");

        public static Texture2D GRAVEL = FromInfo("./assets/images/tiles/gravel.png");
        public static Texture2D GOLD = FromInfo("./assets/images/tiles/gold.png");
        public static Texture2D GRASS = FromInfo("./assets/images/tiles/grass.png");
        public static Texture2D WATER = FromInfo("./assets/images/tiles/water.png");
        public static Texture2D BRICK = FromInfo("./assets/images/tiles/brick.png");
        public static Texture2D GOLDBRICK = FromInfo("./assets/images/tiles/goldbrick.png");
        public static Texture2D CHECKERS = FromInfo("./assets/images/tiles/checkers.png");
        public static Texture2D GOLDCHECKERS = FromInfo("./assets/images/tiles/goldcheckers.png");
        public static Texture2D LEAVES = FromInfo("./assets/images/tiles/leaves.png");
        public static Texture2D WOODPLANK = FromInfo("./assets/images/tiles/woodplanks.png");
        public static Texture2D WOODLOGFACE = FromInfo("./assets/images/tiles/woodface.png");
        public static Texture2D WOODLOG = FromInfo("./assets/images/tiles/woodlog.png");

        public static Texture2D STICK = FromInfo("./assets/images/cursor.png");

        public static Texture2D FromInfo (string uri) {

            return Raylib.LoadTexture(uri);
        }
    }
}