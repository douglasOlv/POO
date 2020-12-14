using System;

class Student
{
    public string name;
    public double grade1, grade2;

    // Methods
    public double averange()
    {
        return (grade1+grade2)/2;
    }

    public string situation(double averange)
    {
        return averange >= 7 ? "approved" : "failed";
    }

    public void message(){
        double averange = this.averange();
        string situation = this.situation(averange);

        Console.WriteLine(name+" is "+situation+" with averange "+averange);
    }

}