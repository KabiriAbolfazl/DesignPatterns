
using PrototypePattern;

ComplexObject complex = new(1, "Ali");
complex.DisplayInfo();

ComplexObject clonedObject = (ComplexObject)complex.Clone();
clonedObject.Id = 2;
clonedObject.Name = "Hossein";
clonedObject.DisplayInfo();

Console.ReadKey();