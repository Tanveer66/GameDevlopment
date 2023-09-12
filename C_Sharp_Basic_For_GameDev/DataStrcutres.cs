namespace MyDataStructures{
    public class ArrayDsa{

        int[] numbers = {12 , 2 ,3 };

        public void DisplayNumbers()
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
                
            }
        }

    }

    public class ListDsa{
        private List<string> aList = new();
       
      public ListDsa()
       {
          aList.Add("Tanveer Ahmad");
          aList.Add("Ali khan");
          aList.Add("COMSATS");
       }

       public void DisplayList()
       {
        foreach (var item in aList)
        {
            Console.WriteLine(item);
            
        }
       }
    

    }
}