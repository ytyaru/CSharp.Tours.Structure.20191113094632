using System;

class S
{
    MemoryMeasurer mm = new MemoryMeasurer();
    public void Run()
    {
        Console.WriteLine("===== S =====");
        Point[] points = new Point[100];
        mm.Start(); 
        for (int i = 0; i < 100; i++) {
            points[i] = new Point(i, i);
        }
        mm.Stop(); 
        mm.Show(); 
    }
    struct Point {
        int x, y;
        public Point(int x, int y) => (this.x, this.y) = (x, y);
    }
}
