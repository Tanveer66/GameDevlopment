using MyNameSpace;
class MainClass
{

    static MyClassB myClassBObj = new("Tanveer" , 23);

    public static void Main()
    {
        myClassBObj.Grade = 'B';

        Console.WriteLine("Grade of Student is : " +myClassBObj.Grade);
        Console.WriteLine("Name  of Student is : " +myClassBObj.Name);
        Console.WriteLine("Age of Student is : " +myClassBObj.Age);
    }

    
}