class Student
{
    String? name;
    int age;
    String? subject;

    public String? Name
    {
        set { name = value; }
        get { return this.name; }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }

    }
    public String? Subject
    {

        get { return this.subject; }
        set { this.subject = value; }

    }

}