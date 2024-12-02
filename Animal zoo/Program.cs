using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Zoo{
public List<Animal> Animals;

public Zoo(){
    Animals = new List<Animal>();
}

public void greetAnimals(){
foreach(Animal c in Animals){
c.greeting();
}
}
public void addAnimal(Animal x){
Animals.Add(x);
}
public void removeAnimal(int y){
Animals.RemoveAt(y);
}
public Animal firstAnimal(){
    Animals[0].greeting();
return Animals[0];
}
}
abstract class Animal{
public string name;
public int age;

public abstract void greeting();

}

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


class Program{

static void Main(){
    bool exit = false;
    Zoo Zoo1 = new Zoo();

while(!exit){



Console.Clear();
Console.WriteLine("Add/add/a.....Remove/remove/r......First/first/f......Exit/Quit/Q");
string chooseAction = Console.ReadLine();
string chooseAnimal;
int removeAtIndex;

switch(chooseAction){
case "Add" or "add" or "a":
Console.WriteLine("ange vilket djur du vill skapa(Cat,Ant,Parrot,Penguin)");
  chooseAnimal = Console.ReadLine();
  switch(chooseAnimal){
    case "Cat" or "cat":
    Console.WriteLine("ge katten ett namn: ");
    string name = Console.ReadLine();
    Console.WriteLine("ange kattens ålder: ");
    int age = Convert.ToInt32(Console.ReadLine());
Cat newCat = new Cat(name,age);
Zoo1.addAnimal(newCat);
break;

case "Ant" or "ant":
Console.WriteLine("ge myran ett namn: ");
   name = Console.ReadLine();
   Console.WriteLine("ange myrans ålder: ");
age = Convert.ToInt32(Console.ReadLine());
Ant newAnt = new Ant(name,age);
Zoo1.addAnimal(newAnt);
break;

case "Parrot" or "parrot":
Console.WriteLine("ge papegojan ett namn: ");
   name = Console.ReadLine();
   Console.WriteLine("ange papejojans ålder: ");
    age = Convert.ToInt32(Console.ReadLine());
Parrot newParrot = new Parrot(name,age);
newParrot.speak("hej, hallå");
Zoo1.addAnimal(newParrot);
break;

case "Penguin" or "penguin":
Console.WriteLine("ge pingvinen ett namn: ");
   name = Console.ReadLine();
   Console.WriteLine("ange papegojans ålder: ");
    age = Convert.ToInt32(Console.ReadLine());
Penguin newPenguin = new Penguin(name,age);

Zoo1.addAnimal(newPenguin);
break;
  }

  Console.WriteLine("Tryck ENTER för att komma vidare.");
  Console.ReadKey();
  break;
case "Remove" or "remove" or "r":
Console.WriteLine("ange vilket index du vill ta bort: ");
  removeAtIndex = Convert.ToInt32(Console.ReadLine());
  
  if(0 <= removeAtIndex && removeAtIndex < Zoo1.Animals.Count()){
Zoo1.removeAnimal(removeAtIndex);
  }else{
    Console.WriteLine($"Zoo innehåller inte ett djur på index {removeAtIndex}");
  }
    
Console.WriteLine("Tryck ENTER för att komma vidare.");
Console.ReadKey();
break;

case "First" or "first" or "f":
if(Zoo1.Animals.Count() == 0){
    Console.WriteLine("det finns inga djur i ditt Zoo");
}else{
    Zoo1.firstAnimal();
}

Console.WriteLine("Tryck ENTER för att komma vidare.");
Console.ReadKey();
break;

case "Exit" or "Quit" or "q":
Console.WriteLine("tack för ditt besök, Välkommen åter.");
exit = true;
break;
}
}
}
}