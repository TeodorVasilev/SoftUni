namespace P02._Point_in_Rectangle
{
	public class Rectangle
	{
		public Rectangle(Point topLeft, Point botRight)
		{
			this.TopLeft = topLeft;
			this.BottomRight = botRight;
		}

		public Point TopLeft { get; set; }

		public Point BottomRight { get; set; }

		public bool Contains(Point point)
		{
			if(point.X >= this.TopLeft.X && 
			   point.X <= this.BottomRight.X &&
			   point.Y >= this.TopLeft.Y &&
			   point.Y <= this.BottomRight.Y)
			{
				return true;
			}

			return false;
		}
	}
}
