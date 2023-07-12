namespace tfllib;

public sealed  class Complex
{
    private int real;
    private int imag;
    public Complex(){
        this.real=this.imag=0;
    }

    public Complex(int r, int i){
        this.real=r;
        this.imag=i;
    }

    public static Complex operator+(Complex c1, Complex c2){
        Complex temp=new Complex();
        temp.real=c1.real + c2.real;
        temp.imag=c1.imag + c2.imag;
        return temp;
    }

    public override string ToString(){
        return this.real + " +i"+ this.imag;
    }
}
