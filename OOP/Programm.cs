namespace OOP
{
    public static class Programm
    {
        public static void Main()
        {
            //Console.WriteLine("Hello World");

            //var helloWorld = new Message("Hello world");

            //var cat = new Cat("Маркиза");
            //Console.WriteLine(cat.Name);
            //Console.WriteLine(cat.GetColor());

            //var sebieianCat = new SibirianCat("Сибирка");
            //Console.WriteLine(sebieianCat.Name);
            //Console.WriteLine(sebieianCat.LengthSherst);
            //Console.WriteLine(sebieianCat.GetColor());

            //Animal animal = new Cat();

            //Cat cat2 = new Cat();
            //cat2.SetColor();

            //Console.WriteLine(animal.GetDescription());

            //animal = new Dog();

            //Dog dog = new Dog();
            //dog.SetName();

            //Console.WriteLine(animal.GetDescription());

            //var animals = new List<Animal> { };

            //animals.Add(new Cat("mark"));
            //animals.Add(new Dog("klop"));
            //animals.Add(new Cat("кот"));
            //animals.Add(new Dog("собака"));
            //animals.Add(new SibirianCat("сибирка"));

            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal.Nick);
            //    Console.WriteLine(animal.GetDescription());
            //    Console.WriteLine();
            //}

            var helloWorldMessage = new Message("Hello world");

            var consolePrinter = new ConsolePrinter();
            consolePrinter.Print(helloWorldMessage);

            var filePrinter = new FilePrinter("./helloWorldMessage.txt");
            filePrinter.Print(helloWorldMessage);
        }
    }
}
