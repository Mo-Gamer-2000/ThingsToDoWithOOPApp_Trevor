namespace ThingsToDoWithOOP;

class Fish : Animal
{
    private string? _colour;

    public Fish(string name, int age, string sound, string? colour) : base(name, age, sound)
    {
        this._colour = colour;
    }

    public string Colour
    {
        get
        {
            return this._colour; 
        }
    }

    // example of base abstract method being used with the override keyword
    public override void Sleep()
    {
        Console.WriteLine("Who me? I don't sleep, I don't have eyelids!");
    }
    
}
