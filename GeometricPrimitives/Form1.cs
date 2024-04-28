namespace GeometricPrimitives
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Pen p = new Pen(Color.DarkBlue, 5); //width < 1 => width = 1
			//Pen p1 = new Pen(Color.FromArgb(49, 226, 29), 2); //using the static method for custom color which does not exist as a property
			g.Clear(Color.LightPink);

			//DRAWING A LINE
			g.DrawLine(p,0,0,150,150);
			//g.DrawLine(p, 0, 0, 150, 150); //the same
			g.DrawLine(p,10,10,10,10); //does not draw anything

			Point a = new Point(0, 0);
			Point b = new Point(150, 150);
			g.DrawLine(p,a,b);

			//DRAWING A TRIANGLE
			int side=200, x1=200, y1=300, x2, y2, x3, y3;
			//Second point coordinates
			x2 = x1 + side;
			y2 = y1;
			//Third point coordinates
			x3 = (x1 + x2) / 2;
			int h = (int)(side * Math.Sqrt(3) / 2);
			y3 = y1 - h;
			//Drawing the 3 sides of the triangle
			g.DrawLine(p, x1, y1, x2, y2);
			g.DrawLine(p, x2, y2, x3, y3);
			g.DrawLine(p, x3, y3, x1, y1);

			//DRAWING A RECTANGLE
			g.DrawRectangle(p, 50, 50, 200, 300);

			//DRAWING A SQUARE
			g.DrawRectangle(p, 100 ,100, 300, 300);

			//DRAWING AN ECLIPSE
			g.DrawEllipse(p, 50,50, 200, 300);

			//DRAWING A CIRCLE
			g.DrawEllipse(p, 450, 50, 200, 200);
		}
	}

}		
	
	
