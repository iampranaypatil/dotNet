namespace Drawing;
public  sealed class Line:Shape{
    public Point startPoint;
    public Point endPoint;
    public Line():base(){
        this.startPoint=new Point();
        this.endPoint=new Point();  
    }

    public Line(Point pt1, Point pt2, int w, string c ):base(w,c)
    {
        this.startPoint=pt1;
        this.endPoint=pt2;
    }

    public override void Draw(){
    
    string data=String.Format("({0}, {1}) , ({2}, {3}), width={4}, color={5}",
                                startPoint.x, startPoint.y, endPoint.x, endPoint.y,width, color);                    
    Console.WriteLine(data);
    }

}