namespace ThingsToDoWithOOP;

class Dog : Animal
{
    // Attributes for a Dog Class
    private string _breed;
    private bool _tail;

    // Constructor
    public Dog(string breed, bool tail, string name, int age, string sound = "woof") : base(name, age, sound)
    {
        this._breed = breed;
        this._tail = tail;
    }

    // Alternative to the above constructor [Tom]
    // In the above constructor we are structurally correct and assigning all the attributes
    // however, we are setting a default value with sound. This can be changed at when 
    // instantiating the object [Dog].
    // In the below constructor we are stating that sound is woof and not allowing the 
    // object to be anything except the chosen descriptor.  This is a good constructor
    // when enforcing a rule to an attribute, where as the above is good when no value is 
    // provided and a default rule is implemented.
    // Comment out the next constructor to see the impact that this has.

    public Dog(string breed, bool tail, string name, int age) : base(name, age, "bow wow")
    {
        this._breed = breed;
        this._tail = tail;
    }


    // Getter and Setters
    public string Breed
    {
        get
        {
            return this._breed;
        }
    }

    public bool Tail
    {
        get
        {
            return this._tail;
        }

        set
        {
            this._tail = value;
        }
    }

    public void displayDogInfo()
    {
        Console.WriteLine($"""
    Dog Information:
    ==============================
        Name: {Name}
        Age: {Age}
        Sound: {Sound}
        Breed: {Breed}
        Tail: {Tail}
    ==============================

    """);
    }

    // Example of overriding the MakeSound from Animal
    // and forcing all dogs to use this method instead.
    public new void MakeSound()
    {
        Console.WriteLine($"{Name} barks! (using Dog.MakeSound instead of Animal.MakeSound)");
    }
}
