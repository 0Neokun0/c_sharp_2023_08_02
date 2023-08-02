using System;

// 「実装の隠蔽」で作った複素数クラス
class Complex
{
    // 実装は外部から隠蔽(privateにしておく)
    private double re; // 実部を記憶しておく
    private double im; // 虚部を記憶しておく

    public double Re() { return this.re; }    // 実部を取り出す
    public void Re(double x) { this.re = x; } // 実部を書き換え

    public double Im() { return this.im; }    // 虚部を取り出す
    public void Im(double y) { this.im = y; } // 虚部を書き換え

    public double Abs() { return Math.Sqrt(re * re + im * im); }  // 絶対値を取り出す
}

// クラス利用側
class ConcealSample
{
    static void Main()
    {
        // x = 5 + 1i
        Complex x = new Complex();
        x.Re(5);  // x.re = 5
        x.Im(1);  // x.im = 1

        // y = -2 + 3i
        Complex y = new Complex();
        y.Re(-2); // y.re = -2
        y.Im(3); // y.im =  3

        Complex z = new Complex();
        z.Re(x.Re() + y.Re()); // z.re = x.re + y.re
        z.Im(x.Im() + y.Im()); // z.im = x.im + y.im

        Console.Write("|{0} + {1}i| = {2}\n", z.Re(), z.Im(), z.Abs());
        // |3 + 4i| = 5 と表示される
    }
}