using AnimalClass;
using CatClass;
using DogClass;
using BirdClass;
public class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Name = "Snoopy";
        dog.Eat();
        dog.Sleep();
        dog.Bark();

        Cat cat = new Cat();
        cat.Name = "Juno";
        cat.Eat();
        cat.Sleep();
        cat.Meow();


        Bird bird = new Bird();
        bird.Name = "Iago";
        bird.Eat();
        bird.Sleep();
        bird.Fly();

    }
}
