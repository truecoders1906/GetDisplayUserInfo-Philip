namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Spot");
            Dog mySecondDog = new Dog("Snoopy");
            Cat mySmallLion = new Cat();

            myDog.Name = "Snoopy";
            myDog.NumberOfLegs = 4;

            mySecondDog.Name = "Champion";
            mySecondDog.NumberOfLegs = 3;

            mySmallLion.Name = "Sneaky";
            mySmallLion.Color = "black";

            myDog.Speak();
            mySecondDog.Speak();
            mySmallLion.Meow();

            
        }
        static void Main(string[])
        {
            Dog myExampleDog = new Dog("Spot");
            //myExampleDog.Name = "Spot"; not needed beacuse of constructor on other file
            myExampleDog.NumberOfLegs = 4;

            Dog mySecondDog = new Dog("Snoopy") { Name = "Snoopy", NumberOfLegs = 4 };

            myExampleDog.Speak();
            mySecondDog.Speak(); // parenthesis are method invocation
    }

    }
}
