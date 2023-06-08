namespace Game
{
    public partial class Form1 : Form
    {
        public Graphics g;
        public int MapWidth = 896;
        public int MapHeight = 896;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Hijacked WinForms method which will paint stuff on the screen.
        /// For the purposes of this game, we are only using this method to set the order in which our layers should render.
        /// For example, the background layer should be rendered at the top of the method, and the foreground should be rendered at the bottom.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;


            //Set render order here...

            //Draw map
            PaintMap(0);


            //Draw player
            g.DrawImage(Player.Img, Player.X, Player.Y);
        }

        public void PaintMap(int index)
        {

            Map map = Maps.Get(index);


            int tileSize = map.Tiles[0].Width;
            int numCols = 14;
            int row = 0;

            for (int i = 0; i < map.Tiles.Count; i++)
            {
                int col = i % numCols;
                int x = tileSize * col;
                int y = tileSize * row;

                g.DrawImage(map.Tiles[i].Img, x, y);

                if (col == numCols - 1)
                {
                    row++;
                }
            }
        }

        //Call this when you wish to redraw the screen
        public void Redraw()
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(Start);

        }


        public void Start()
        {
            while (true)
            {


                if (Player.MoveRight && Player.X <= MapWidth - 33)
                {
                    Player.X += Player.Speed;
                }

                if (Player.MoveLeft && Player.X >= 0)
                {
                    Player.X -= Player.Speed;
                }
                if (Player.MoveUp && Player.Y >= 0 )
                {
                    Player.Y -= Player.Speed;
                }
                if (Player.MoveDown && Player.Y <= MapHeight - 35)
                {
                    Player.Y += Player.Speed;
                }


                Redraw();
                Thread.Sleep(16);

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.W:
                    Player.MoveUp = true;
                    break;

                case Keys.S:
                    Player.MoveDown = true;
                    break;

                case Keys.A:
                    Player.MoveLeft = true;
                    break;
                case Keys.D:
                    Player.MoveRight = true;
                    break;

            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.W:
                    Player.MoveUp = false;
                    break;

                case Keys.S:
                    Player.MoveDown = false;
                    break;

                case Keys.A:
                    Player.MoveLeft = false;
                    break;
                case Keys.D:
                    Player.MoveRight = false;
                    break;

            }
        }
    }
}
