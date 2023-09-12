using AbstractNamspace;
using MyNameSpace;
using MyDataStructures;
class MainClass
{

  static BClass bClassObj = new("Tanveer" , 23);

  static ArrayDsa arrayDsa = new();
  static ListDsa listDsa = new();



    public static void Main()
    {
      Console.WriteLine("Name :-" + bClassObj.Name + "---" + bClassObj.Num);
      bClassObj.Ishow();
      arrayDsa.DisplayNumbers();
      listDsa.DisplayList();
    }

    
}