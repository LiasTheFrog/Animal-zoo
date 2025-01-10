namespace animalzoo;

abstract class Mamal : Animal{
public bool isNocturnal;
abstract public bool isAsleep();
}

class Cat : Mamal{
    public override bool isAsleep()
    {
       return true;
    }

     public override void greeting()
    {
        Console.WriteLine($"jag är en cat. jag heter {name} och är {age} år gammal");
    }
    public Cat(string catName, int catAge){
        isNocturnal = true;
        name = catName;
        age = catAge;
    }
}
