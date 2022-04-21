////INSTANCES=Objects
////Core of OOP: Thinking of things in terms of objects

using Classes;

//var newDog = new Dog();

////Let's be specific
////newDog.Breed = "Pitbull";
////newDog.Age = 56;
////newDog.Name = "Simba";
////newDog.Weight = 45.60;      

////var secondDog = new Dog();

////secondDog.Breed = "Great Dane";
////secondDog.Age = 7;
////secondDog.Name = "Blue";
////secondDog.Weight = 50;

////var thirdNewDog = new Dog();

////thirdNewDog.Breed = "Labrador Retriever";
////thirdNewDog.Age = 2;
////thirdNewDog.Name = "Fido";
////thirdNewDog.Weight = 65;


////Console.WriteLine(newDog.Name);
////Console.WriteLine(secondDog.Weight);

//Console.WriteLine(newDog.Bark());

//List<Dog> dogList = new List<Dog>();

//dogList.Add(newDog);
//dogList.Add(secondDog);
//dogList.Add(thirdNewDog);

//Console.WriteLine("Give me the name of a dog you want");

//var userInput = Console.ReadLine();

//var dogToFind = dogList.Where(d => d.Name == userInput).FirstOrDefault();

//if (dogToFind == null)
//{
//    Console.WriteLine("No, we do not have it");
//}
//else
//{
//    Console.WriteLine("Yes, we have it");
//}

//foreach (Dog dog in dogList)
//{
//    Console.WriteLine(dog.Name);
//}

List<Dog> dogList = new List<Dog>()
{
    new Dog() { Name = "Fido", Size = "Small"},
    new Dog { Name ="Simba"}
};

var newDog = new Dog();
//or
newDog.Name = "Katie";

dogList.Add(newDog);

//dogList.Add(new Dog() { Name = "Simba", Age = 2, Breed = "German Shephard", Size = "Medium" });

dogList.Sum(x => x.Age);