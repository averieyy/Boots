using Raylib_cs;

namespace Ashlad {

    class Img {

        public static Texture2D ASHUP = FromInfo("./ashlad.png");
        public static Texture2D ASHLEFT = FromInfo("./ashlad.png");
        public static Texture2D ASHDOWN = FromInfo("./ashlad.png");
        public static Texture2D ASHRIGHT = FromInfo("./ashlad.png");

        public static Texture2D FromInfo (string uri) {

            return Raylib.LoadTexture(uri);
        }
    }
}