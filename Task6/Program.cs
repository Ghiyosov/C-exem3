

using Task6;

var cat = new Cat("pishak");
cat.greats();

var dog = new Dog("Rex");
dog.greats();
dog.greats(dog);

var bigDog = new BigDog("Palvon");
bigDog.greats();
bigDog.greats(dog);
bigDog.greats(bigDog);