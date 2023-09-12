namespace AbstractNamspace
{
    public abstract class AClass
    {

        public AClass()
        {
            this.name = "Deaful Name Value";
            this.num = 0;
        }

        public AClass(string Name, int num)
        {
            this.name = Name;
            this.num = num;

        }

        protected string? name;
        protected int num;

        abstract public string? Name
        {
            set;
            get;
        }

        abstract public int Num
        {
            set;
            get;
        }



    }//end of AClass

    public class BClass : AClass , IFace

    {
        public BClass(string name , int num) : base(name , num)
        {

        }
        public override string? Name { get => this.name; set => this.name = value; }
        public override int Num { get => this.num; set => this.num = value; }

        public void Ishow()
        {
            Console.WriteLine("This show Method of Inteface");
        }
    }

    interface IFace{

         void Ishow();
    }
}