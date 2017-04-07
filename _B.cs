/*
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Linq;


class Program
    {
    static void Main()
        {
        // Create a stop watch in case we want to time things.
        Stopwatch watch = new Stopwatch();
        watch.Start();
        // Instantiate the variable we use to read in the variables.
        Scanner cin = new Scanner();
        StreamWriter sw = new StreamWriter("B.out");

        // Read the number of test cases.
        int testcases = cin.nextInt();

        // Go through each test case.
        for (int t = 0; t < testcases; t++)
            {
            // Write the case number format.
            sw.Write("Case #{0}: ", t + 1);

            ///////////////////////////
            // CODE JAM CODE GOES HERE

            

            
            ///////////////////////////

            // Go to a new line if we aren't at the last testcase.
            if (t != testcases - 1)
                { sw.WriteLine(); }
            }
        sw.Close();
        Console.WriteLine("Finished in {0} seconds.", watch.ElapsedMilliseconds * 1000);
        // Make a beep noise.
        Console.Beep(5000, 1000);
        }

    ///////////////////////////////////////////////////////////////////////////////////
    // Thank you rian from Japan from Code Jam.
    static void swap<T>(ref T a, ref T b) { var t = a; a = b; b = t; }

    static T[] copy<T>(T[] a)
        {
        var ret = new T[a.Length];
        for (int i = 0; i < a.Length; i++) ret[i] = a[i];
        return ret;
        }
    static T[][] copy2<T>(T[][] a)
        {
        var ret = new T[a.Length][];
        for (int i = 0; i < a.Length; i++)
            {
            ret[i] = new T[a[0].Length];
            for (int j = 0; j < a[0].Length; j++) ret[i][j] = a[i][j];
            }
        return ret;
        }

    }

//////////////////////////////////////////////////////////
// Thank you rian from Japan, from Google Code Jam.
class MyMath
    {
    ///////////////////////////////
    // Checks if a number is prime.
    public bool IsPrime(long a)
        {
        if (a < 2) return false;
        for (long i = 2; i * i <= a; i++) if (a % i == 0) return false;
        return true;
        }
    ///////////////////////////////

    ///////////////////////////////
    public long[][] powmat(long[][] A, long n, int M)
        {
        var E = new long[A.Length][];
        for (int i = 0; i < A.Length; i++)
            {
            E[i] = new long[A.Length];
            E[i][i] = 1;
            }
        if (n == 0) return E;
        var t = powmat(A, n / 2, M);
        if ((n & 1) == 0) return mulmat(t, t, M);
        return mulmat(mulmat(t, t, M), A, M);
        }
    ///////////////////////////////

    ///////////////////////////////
    public long[] mulmat(long[][] A, long[] x, int M)
        {
        var ans = new long[A.Length];
        for (int i = 0; i < A.Length; i++) for (int j = 0; j < x.Length; j++) ans[i] = (ans[i] + x[j] * A[i][j]) % M;
        return ans;
        }
    public long[][] mulmat(long[][] A, long[][] B, int M)
        {
        var ans = new long[A.Length][];
        for (int i = 0; i < A.Length; i++)
            {
            ans[i] = new long[B[0].Length];
            for (int j = 0; j < B[0].Length; j++) for (int k = 0; k < B.Length; k++) ans[i][j] = (ans[i][j] + A[i][k] * B[k][j]) % M;
            }
        return ans;
        }
    ///////////////////////////////

    ///////////////////////////////
    public long powmod(long a, long b, long M)
        {
        if (a == 0) return 0;
        if (b == 0) return 1;
        var t = powmod(a, b / 2, M);
        if ((b & 1) == 0) return t * t % M;
        return t * t % M * a % M;
        }
    ///////////////////////////////

    ///////////////////////////////
    // Gets the greatest common divisor of two numbers.
    public long GCD(long a, long b)
        {
        while (b > 0) { var t = a % b; a = b; b = t; }
        return a;
        }
    ///////////////////////////////

    ///////////////////////////////
    // Gets the least common multiple of two numbers.
    public long LCM(int a, int b) { return a * (long)b / GCD(a, b); }
    ///////////////////////////////

    ///////////////////////////////
    public long Comb(int n, int r)
        {
        const int M = 1000000007;
        if (n < 0 || r < 0 || r > n) return 0;
        if (n - r < r) r = n - r;
        if (r == 0) return 1;
        if (r == 1) return n;
        var numerator = new int[r];
        var denominator = new int[r];
        for (int k = 0; k < r; k++)
            {
            numerator[k] = n - r + k + 1;
            denominator[k] = k + 1;
            }
        for (int p = 2; p <= r; p++)
            {
            int pivot = denominator[p - 1];
            if (pivot > 1)
                {
                int offset = (n - r) % p;
                for (int k = p - 1; k < r; k += p)
                    {
                    numerator[k - offset] /= pivot;
                    denominator[k] /= pivot;
                    }
                }
            }
        long result = 1;
        for (int k = 0; k < r; k++) if (numerator[k] > 1) result = result * numerator[k] % M;
        return result;
        }
    ///////////////////////////////
    }
//////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////
// Class to read input variables one at a time.
class Scanner
    {
    string[] s;
    int i;

    // Get all the files with the .in extension
    static string[] files = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(), "*.in");
    // Choose the first one and use it for streamreader (make sure there's only one .in file in your folder..)
    StreamReader sr = new StreamReader(files[0]);

    char[] cs = new char[] { ' ' };

    public Scanner()
        {
        s = new string[0];
        i = 0;
        }

    public string next()
        {      
        if (i < s.Length) return s[i++];
        string st = sr.ReadLine();
        while (st == "") st = sr.ReadLine();
        s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
        i = 0;
        return s[i++];
        }

    public int nextInt()
        {
        return int.Parse(next());
        }

    public long nextLong()
        {
        return long.Parse(next());
        }

    public double nextDouble()
        {
        return double.Parse(next());
        }
    
    }
//////////////////////////////////////////////////////////
*/