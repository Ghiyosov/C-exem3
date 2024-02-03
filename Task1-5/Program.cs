//1.List shumorai muayan nadora da spiska bo dob karda metonem , array bosha shumorai muayan dora
//2.Nasl giri yak klass metodo va fieldoy diga claassa megira megiriftagi childe class mesha , medodagi parent class
//3.polimorphism yak kismi OOP buda baroi metodora da diga classo izminit kardan. Virtual method - yak tarzi polomorphizma istifoda burdan tavasuti virtual methodmona da diga classo override meknem
//4.Abstract classes - body fiziki nadora tipsha da program.cs sokhta nametonem fakat da diga classo inherit kardash meshava tamom, Abstract methods - body nadora da diga classo override meshava  



//5
using Task1;

var student = new Student("Ismoil","Mushfiki","C++",23,12.3);
System.Console.WriteLine(student.toString());
student.setName("Ghiyosov");
student.setAddress("Yakachinor");
student.setProgram("C#");
student.setYear(25);
student.setFee(15.8);
System.Console.WriteLine(student.toString());
System.Console.WriteLine("---------------------------------------");

var staff = new Staff("Ismoil","Mushfiki","miyyona",102.5);
System.Console.WriteLine(staff.toString());
staff.setName("Ghiyosov");
staff.setAddress("Yakachinor");
staff.setSchool("Rahnomo");
staff.setPay(1600.58);
System.Console.WriteLine(staff.toString());

