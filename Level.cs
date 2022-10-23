namespace Ashlad {

    class Level {

        /* Level file format
        // Areas
        AREA 1: 1,1;2,2
        Dragons Den: 5,5 6,6

        00000000
        01111110
        01000010
        01011010
        01011010
        01000010
        01111110
        00000000
        */

        public int sizex;
        public int sizey;

        public int[,] matrix;
        public Area[] areas;

        public Level (string lvlString) {

            this.sizex = lvlString.Split("\n\n")[1].Split("\n")[0].Length;
            this.sizey = lvlString.Split("\n\n")[1].Split("\n").Length;

            this.areas = new Area[lvlString.Split("\n\n")[0].Split("\n").Length];
            this.matrix = new int[sizex, sizey];
        }
    }

    class Area {

        public int sx;
        public int sy;
        public int ex;
        public int ey;

        public string title;

        public Area (int sx, int sy, int ex, int ey, string title) {

            this.sx = sx;
            this.sy = sy;
            this.ex = ex;
            this.ey = ey;

            this.title = title;
        }
    }
}