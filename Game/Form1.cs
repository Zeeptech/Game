namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Image character = Image.FromFile("../../../assets/pic.png");


            Graphics g = e.Graphics;

            g.DrawImage(character,0, 0 );

        }
    }
}