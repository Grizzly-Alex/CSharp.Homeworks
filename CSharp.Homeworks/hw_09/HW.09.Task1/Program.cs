using HW._09.Task1;

int age;
Person person = new();
person.Great();

Console.WriteLine("\n***Student***");
Student student = new();
age = 21;
student.SetAge(ref age);
student.Great();
student.GoToClasses();
student.ShowAge();  

Console.WriteLine("\n***Teacher***");
Teacher teacher = new();
age = 30;
teacher.SetAge(ref age);    
teacher.Great();
teacher.Explain();