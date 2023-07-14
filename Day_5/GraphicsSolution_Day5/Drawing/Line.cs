namespace Drawing ;
using System.Reflection;

//Multiple interface inheritance
public class Line:Shape, IPrintable{
    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}

    public Line(){
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);    
    }
    public Line(Point pt1, Point pt2){
        this.StartPoint=pt1;
        this.EndPoint=pt2;
    }

    public override void Draw()
    {
      //Reflection:
      //Get information about instance at runtime: 

      //compile time linking (Static Linking)

      //run time linking (dynamic linking)-----dll
      //System.Reflection.Assembly

      Type t=this.GetType();
      Console.WriteLine("Type ="+ t.Name);
      Console.WriteLine("Full Name="+t.FullName);

       //Runtime (Execution Engine)
      //Runtime concepts
      //1.Refelction
      //2.Multithreading
      //3.Serialization  (file I/O) (Boxing and UnBoxing)
      //4.Socket Programming(Networking)
                //TCP/IP
                //HTTP
                //Messaging
      //5.Data Access (CRUD Operations)
      //                 (Queries)

      Console.WriteLine("("+ this.StartPoint+ "), (" + this.EndPoint+ ")," +
       this.Width+"," + this.Color);
    }


    public void Print(){
        Console.WriteLine("Printing object using  exiting printer");
        Type t=this.GetType();
        Console.WriteLine("Type ="+ t.Name);
        Console.WriteLine("("+ this.StartPoint+ "), (" + this.EndPoint+ ")," +
       this.Width+"," + this.Color);
    }
}