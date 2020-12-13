using System;

class People
{
    // Method 01
   public void introduce()
   {
       Console.WriteLine("hello");

   }

    // Method 02
    public void introduce(string name)
    {
        Console.WriteLine("hello "+name);

    }

    // Method 03
    public void introduce(string name, int age)
    {
        Console.WriteLine("hello "+name+" you have "+age+" years old");

    }

    
}