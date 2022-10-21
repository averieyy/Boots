using Raylib_cs;

namespace Ashlad {

    class Game {

        public static int sizex = 600;
        public static int sizey = 400;

        public static bool Paused = true;

        public static List<int> currentkeys = new List<int>();
        public static List<int> lastkeys = new List<int>();
        public static Dictionary<int, bool> keys = new Dictionary<int, bool>();

        public static string[] texturepaths = new string[]{
            "./cursor.png"
        };
        public Texture2D[] textures;

        public Game () {

            Raylib.InitWindow(sizex, sizey, "Boots");
            Raylib.InitAudioDevice();
            Raylib.SetExitKey(KeyboardKey.KEY_NULL);
            Raylib.HideCursor();
            Raylib.SetWindowIcon(Raylib.LoadImage("./cursor.png"));

            // Load Textures
            textures = new Texture2D[texturepaths.Length];

            for (int i = 0; i < texturepaths.Length; i++) {

                textures[i] = Raylib.LoadTexture(texturepaths[i]);
            }
        }

        public void Run () {

            int fps = 20;
            long lt = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long ct;
            double delta = 1000/fps;

            while (!Raylib.WindowShouldClose()) {

                ct = DateTimeOffset.Now.ToUnixTimeMilliseconds();

                if (ct-lt >= delta) {

                    lt = ct;
                    Update();
                    Render();
                }
            }

            Raylib.CloseWindow();
        }

        public void Update () {

            int mouseX;
            int mouseY;
            if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT)) {
                    
                mouseX = Raylib.GetMouseX();
                mouseY = Raylib.GetMouseY();

            }
            else
                Raylib.SetMousePosition(sizex/2, sizey/2);
            
            currentkeys.Clear();
            int lk;
            while ((lk = Raylib.GetKeyPressed()) != 0) {
                currentkeys.Add(lk);
            }
            lastkeys = currentkeys;
        }

        public void Render () {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BEIGE);

            // Draw Cursor
            if (Paused) {

                Raylib.DrawTexture(textures[0], Raylib.GetMouseX(), Raylib.GetMouseY(), Color.WHITE);
            }

            // Start Drawing


            Raylib.EndDrawing();
        }
    }
}