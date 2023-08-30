using System;

//ref link:https://www.youtube.com/watch?v=yH-rd41zkuI&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=21
//  Explicit/Implicit Operator Null
// explicit operator null -- danger when converting int? to int -- "public static explicit operator T(T? value);"
// implicit operator null -- safe when converting int to int? -- "public static explicit operator T?(T value);"
// int? (nullable) 1 more value than int(none nullable)

class MainClass
{
    static void Main()
    {
        //Nullable<int> sample = null;
        //int? i = null;
        ////int j = i ?? 8; // null or 8 //int j = i.HasValue ? i.GetValueOrDefault() : 8; // compiler: ?(or), :(else) -- return if has always value
        //int j = i.GetValueOrDefault(8); // other technique than compiler
        //Console.WriteLine(j);   // output 8
        //
        //int? a = 5;
        ////int b = a ?? 8;
        //int b = a.GetValueOrDefault(8);
        //Console.WriteLine(b);   // output 5


        ///////

        //safe
        int i = 5;
        int? j = i;
        Console.WriteLine(j);

        //unsafe
        int? a = 5; 
        //int? a = null; // error a is null
        //int b = a;  // error implicit a unsafe
        int b = (int)a;   // explicit a safe
        Console.WriteLine(b);
    }
}