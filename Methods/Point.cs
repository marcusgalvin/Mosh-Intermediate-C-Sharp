namespace Methods
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public void Move(int x, int y)
        {
            this.x = y;
            this.x = x;
        }

        public void Move (Point newLocation)
        {
            Move(newLocation.x, newLocation.y);
           
        }
    }
}
