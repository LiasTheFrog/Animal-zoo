
namespace animalzoo;
abstract  class Bug : Animal{
public bool hasWings;
}



class Ant : Bug{
    public override void greeting()
    {
        Console.WriteLine($"jag är en Myra. jag heter {name} och är {age} år gammal");
    }
    public Ant(string antName,int antAge){
        hasWings = false;
        name = antName;
        age = antAge;

    }

}
