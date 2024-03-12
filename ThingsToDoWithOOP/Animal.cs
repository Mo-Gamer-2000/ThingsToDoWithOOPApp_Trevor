namespace ThingsToDoWithOOP;


// Now that the class is abstract, we are unable
// to instantiate it as an object.

internal abstract class Animal
{
    // Attributes
    private string _name;
    private int _age;
    private string? _sound;

    // Public constructor to instantiate an animal object using all attributes
    public Animal(string name, int age, string sound)
    {
        this._name = name;
        this._age = age;
        this._sound = sound;
    }

    // Public constructor to instantiate an animal object without sound [OVERLOADING]
    //public Animal(string name, int age)
    //{
    //    this._name = name;
    //    this._age = age;
    //    this._sound = "No sound";
    //}


    // Getter and Setter for Name
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Getter and Setter for Sound
    public string Sound
    {
        get { return _sound; }
        set { _sound = value; }
    }

    // Getter for Age
    public int Age
    { 
        get { return _age; }
    }

    // Behaviour methods
    public void GrowsOlder()
    {
        _age++;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{ _name} makes a { _sound} sound!");
    }

    // Example of creating an abstract method that MUST be implemented in
    // all derived classes
    public abstract void Sleep();

}
