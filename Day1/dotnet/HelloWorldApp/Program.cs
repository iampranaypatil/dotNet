using LMS;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int result=56;
bool status=false;
string fullName="Ravi Tambade";
String cdac="iacsd";
DateTime currentTime=DateTime.Now;
Console.WriteLine(currentTime);

DateTime regDate=new DateTime(2023,04,18);
DateTime birthDate=new DateTime(1999,07,1);
Student std1=new Student(76, "pgdac", regDate, 
                   "Parag","Pande","parag.pande@gmail.com",
                   "9881735801",birthDate);

Console.WriteLine(std1);
