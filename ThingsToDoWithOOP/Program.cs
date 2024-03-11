using ThingsToDoWithOOP;

Animal animal1 = new Animal("Fidi", 3, "bark");

//animal1.Name = "Fred";
//animal1.Age = 6;
//animal1.Sound = "bark";

Console.WriteLine($"{animal1.Name} is {animal1.Age} years old and makes a {animal1.Sound} noise!");

animal1.growsOlder();

Console.WriteLine($"{animal1.Name} is {animal1.Age} years old and makes a {animal1.Sound} noise!");

animal1.makeSound();

Dog dog1 = new Dog("Border Collie",true,"Fred",5);
Dog dog2 = new Dog("Yorkshire Terrier", true, "Yappy", 6, "yip");


dog1.makeSound();
dog1.displayDogInfo();
dog1.growsOlder();
dog1.displayDogInfo();

dog2.displayDogInfo();