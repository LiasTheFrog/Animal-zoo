
namespace animalzoo;
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