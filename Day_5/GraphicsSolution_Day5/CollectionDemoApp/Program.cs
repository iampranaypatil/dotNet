
using CollectionDemoApp;
using System.Collections.Generic;


int[] marks = { 34, 56, 23, 87, 56 };
string[] names = { "Amit", "Rajiv", "Manisha" };
Person[] people =
{
    new Person{ FirstName="Sham",LastName= "Manohar", Age=23,Wealth=100},
    new Person{ FirstName="Ram",LastName= "Gopal",Age=45,Wealth=80},
    new Person{ FirstName="Radha",LastName= "Sharma",Age=13,Wealth=90},
    new Person{ FirstName="Veena",LastName= "Varma",Age=73,Wealth=10},
};

//Rectangular Array
    int[,] matrix = new int[3, 3];
    matrix[0, 1] = 1;
    matrix[0, 2] = 2;
    matrix[1, 0] = 3;
    matrix[1, 1] = 4;
    matrix[1, 2] = 5;
    matrix[2, 0] = 6;
    matrix[2, 1] = 7;
    matrix[2, 2] = 8;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Matrix[{0},{1}] = {2}", i, j, matrix[i, j]);
    }
}


//Jagged Array
//Array of Array
int[][] revenue= new int[3][];
revenue[0] = new []{ 45,67,87,98};
revenue[1] = new[] { 33, 55 };
revenue[2] = new int[5];


List<int> numbers = new List<int>();
numbers.Add(17);
numbers.Add(92); 
numbers.Add(3);

foreach (int i in numbers)
{
    Console.WriteLine(i);
}

int num = numbers[2];

numbers.Sort();
foreach (int i in numbers)
{
    Console.WriteLine(i);
}


List<Person> wealthyPeople= new List<Person>();
wealthyPeople.Add(new Person { FirstName = "Sham", LastName = "Manohar", Age = 23, Wealth = 100 });
wealthyPeople.Add(new Person { FirstName = "Ram", LastName = "Gopal", Age = 45, Wealth = 80 });
wealthyPeople.Add(new Person { FirstName = "Radha", LastName = "Sharma", Age = 13, Wealth = 90 });

wealthyPeople.Sort();


Stack< Person> answerableStudents = new Stack<Person>();

answerableStudents.Push(new Person { FirstName = "Ram", LastName = "Gopal", Age = 45, Wealth = 80 });
answerableStudents.Push(new Person { FirstName = "Ram", LastName = "Gopal", Age = 45, Wealth = 80 });


Team india=new Team();
Player player = india[0];
Player anotherPlayer = india[3]; ;