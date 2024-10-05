using CoffeeMachineTest;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

CoffeeMachine coffeeMachine = new CoffeeMachine();

await coffeeMachine.MakeCoffeeAsync();