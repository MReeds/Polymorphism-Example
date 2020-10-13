using System;

class Animal
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: Bark!")
    }
}

class Bird : Animal
{
    public void animalSound()
    {
        Console.WriteLine("The bird says: Caw!")
    }
}

