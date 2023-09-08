namespace MyNameSpace
{
    public class MyClassA
    {

        protected String? name;
        protected int age;
        //permetarized constructor
        public MyClassA(String? name, int Age) { this.name = name; this.age = Age; }
        //Default Constructor
        public MyClassA() { this.name = "Default"; this.age = 12; }

        public String? Name { set { this.name = value; } get { return this.name; } }

        public int Age { set { this.age = value; } get { return this.age; } }


    }
    public class MyClassB : MyClassA
    {
         char? grade;
         public MyClassB() { this.grade = 'A'; }
        public MyClassB(String? name, int Age) : base(name, Age) {}
        public char? Grade { set => this.grade = value;  get => this.grade; }


    }
}