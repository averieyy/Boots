using Raylib_cs;

namespace Ashlad {

    class Game {

        public static int sizex = 600;
        public static int sizey = 400;

        public static int playerx = sizex / 2;
        public static int playery = sizey / 2;

        public static bool Paused = true;

        public static List<int> currentkeys = new List<int>();
        public static List<int> lastkeys = new List<int>();
        public static Dictionary<int, bool> keys = new Dictionary<int, bool>();

        public static bool mouseDown = false;

        public Game () {

            Raylib.InitWindow(sizex, sizey, "Boots");
            Raylib.InitAudioDevice();
            Raylib.SetExitKey(KeyboardKey.KEY_NULL);
            Raylib.HideCursor();
            Raylib.SetWindowIcon(Raylib.LoadImage("./assets/images/cursor.png"));
        }

        public void Run () {

            int fps = 60;
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

            mouseX = Raylib.GetMouseX();
            mouseY = Raylib.GetMouseY();

            if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT)) {
                    
                if (mouseDown == false)
                    Raylib.SetMousePosition(sizex/2, sizey/2);
                mouseDown = true;
            }
            else {
                if (mouseDown == true)
                    Raylib.SetMousePosition(sizex/2, sizey/2);
                mouseDown = false;
            }
            
            currentkeys.Clear();
            int lk;
            while ((lk = Raylib.GetKeyPressed()) != 0) {
                currentkeys.Add(lk);
            }
            lastkeys = currentkeys;

            if (!lastkeys.Contains(27) && currentkeys.Contains(27)) Paused = !Paused;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) playery--;
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) playery++;
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) playerx--;
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) playerx++;
        }

        public void Render () {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BEIGE);


            // Start Drawing

            // CLEAR LATER
            Raylib.DrawTexture(Img.ASHDOWN, playerx-16, playery-16, Color.WHITE);

            // Draw Cursor
            if (!Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON)) {

                Raylib.DrawTexture(Img.STICK, Raylib.GetMouseX(), Raylib.GetMouseY(), Color.WHITE);
            }
            Raylib.EndDrawing();
        }
    }
}