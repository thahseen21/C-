<Query Kind="Statements" />


var person1 = new Person("Thahseen",23);

//Console.WriteLine(person1.Name);

var persons = new List<Person>() {
	person1,
	new Person() {Name="Mohammed", Age = 24}
};

foreach(var person in persons) {
	Console.WriteLine(person.Name);
}

var anyResult = persons.Any(p => p.Name.ToLower().Contains("thahseeee"));

Console.WriteLine(anyResult);


var findResult = persons.Find(p => p.Name.ToLower().Contains("thahseen"));

Console.WriteLine(findResult);


var text = "Thahseen";

Console.WriteLine(text.Contains("a"));


class Person {
	public string Name { get; set;}
	public int Age { get; set;}
	
	
	public Person() {}
	
	public Person(string name, int age) {
		Name = name;
		Age = age;
	}	
}


