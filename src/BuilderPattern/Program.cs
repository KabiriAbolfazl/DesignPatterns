using BuilderPattern.ConcreteBuilders;
using BuilderPattern.Directors;

ComputerDirector computerDirector = new();
GamingComputerBuilder gamingComputerBuilder = new();
computerDirector.Build(gamingComputerBuilder);
gamingComputerBuilder.GetComputer()
                       .DisplayInfo();

Console.ReadKey();