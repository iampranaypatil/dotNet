namespace Maths;
public static class MathEngine{
    public static int Addition(int op1, int op2){
        int result=op1+ op2;
        return result;
    }

    public static int Subraction(int op1, int op2){
        int result=op1- op2;
        return result;
    }

    public static void  Swap(ref Object o1, ref  Object o2){
        Object temp=o1;
        o1=o2;
        o2=temp;
    }


    public static void  Calculate(int radius,
                out double area, out double circumference){
        const double PI=3.14;
        area=radius*radius*PI;
        circumference=2*radius*PI;
    }
}