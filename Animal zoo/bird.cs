namespace animalzoo;

abstract class Bird : Animal{
public bool canFly;

}

class Parrot : Bird{

    public void speak(string text){
Console.WriteLine(text);
    }
 public override void greeting()
    {
        Console.WriteLine($"jag är en papegoja. jag heter {name} och är {age} år gammal");
    }
    public Parrot(string parrotName,int parrotAge){
        canFly = true;
        name = parrotName;
        age = parrotAge;
    }
    
public void Fly(int a){
Console.WriteLine($"fågeln flög: {a}meter");
}
}

class Penguin : Bird{
 public override void greeting()
    {
        Console.WriteLine($"jag är en pingvin. jag heter {name} och är {age} år gammal.");
    }
    public Penguin(string penguinName, int penguinAge){
        canFly = false;
        name = penguinName;
        age = penguinAge;
    }
public void Fly(int a){
Console.WriteLine($"pingviner kan inte flyga");
}
    
}