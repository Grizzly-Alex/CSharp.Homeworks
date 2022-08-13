using HW15.Task2;
using System.Reflection;

PurchaseMotorcycle newMoto = new(); 
newMoto.CreditCardNumber = "1234567812345678";

var type = typeof(PurchaseMotorcycle);

foreach (var property in type.GetProperties())
{
    foreach(var attribute in property.GetCustomAttributes(true))
    {
        var cardAttribute = attribute as CreditCardAttribute;

        if (cardAttribute is not null)
        {
            if (cardAttribute.IsValidCard((string)property.GetValue(newMoto)))
            {
                Console.WriteLine("Card is valid");
            }
            else
            {
                Console.WriteLine("Card is not valid");
            }
        }
    }
}