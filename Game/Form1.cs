namespace Game
{
    public partial class Form1 : Form
    {

        Tile grassTile;

        public Form1()
        {
            InitializeComponent();
            grassTile = new Tile("../../../assets/unknown.png", 100, 100);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Image character = Image.FromFile("../../../assets/unknown.png");


            Graphics g = e.Graphics;

            g.DrawImage(grassTile.Img, 100, 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}