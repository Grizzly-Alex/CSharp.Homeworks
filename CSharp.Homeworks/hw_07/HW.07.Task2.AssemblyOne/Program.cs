using HW._07.Task2.AssemblyOne;

Motorcycle MyMotor = new Motorcycle();

ushort maxWeight1 = MyMotor.maxWeight;
string color1 = MyMotor.color;
bool gasolineEngine1 = MyMotor.gasolineEngine;
MyMotor.Brake();


/*
ushort maxSpeed = MyMotor.MaxSpeed; ==> Является публичной константой, может быть вызван только из самого класса в любой сборке. Например Motorcycle.MaxSpeed;

ushort MaxTankVolume = MyMotor.maxTankVolume; ==> Является полем с модификатором protected и доступна только для наследника 
                                                 в разных сборках, но не для его экземпляров и экземпляра наследника. Так же доступна внутри класса где определена.

MyMotor.StartMotorcycle(); ==> Метод является методом с модификатором protected и доступен только 
                               для наследника в разных сборках и внутри класса где сам метод определён.

string description = MyMotor.description; ==> Является полем с модификаторо private, доступна только внутри самого класса в которой определена;

MyMotor.Drive(); ==> Метод является приватным и доступен только внутри самого класса, недоступен для экземпляра и потомков.

MyMotor.StopMotorcycle(); ==> Метод доступен только для наследников класса и в текущей сборке.
*/

SportBike MySportBike = new SportBike();

ushort maxWeight2 = MySportBike.maxWeight;
string color2 = MySportBike.color;
bool gasolineEngine2 = MySportBike.gasolineEngine;
MySportBike.Brake();
MySportBike.FastDrive();

/*
ushort maxSpeed = MySportBike.MaxSpeed; ==> Является публичной константой, может быть вызван только из самого класса в любой сборке.

ushort MaxTankVolume = MySportBike.maxTankVolume; ==> Является переменной с модификатором protected и доступна только для наследника в разных
                                                      сборках, но не для его экземпляров. Так же доступна внутри класса где определена.

MySportBike.StartMotorcycle(); ==> Метод является методом с модификатором protected и доступен только для наследника
                                   в разных сборках и внутри класса где сам метод определён и у наследника.

MySportBike.Drive(); ==> Метод является приватным доступен только внутри самого класса, недоступен для экземпляра и потомков.

MySportBike.StopMotorcycle(); ==> Метод доступен только для наследников класса и в текущей сборке. В нашем случае MySportBike
                                  это экземпляр наследника базового класса Motorcycle.            
*/