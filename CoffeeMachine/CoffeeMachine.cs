using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineTest
{
    internal class CoffeeMachine
    {
        public async Task HeatWaterAsync()
        {
            Console.WriteLine("Нагрівання води...");
            await Task.Delay(3000);
            Console.WriteLine("Вода нагріта.");
        }

        public async Task GrindCoffeeAsync()
        {
            Console.WriteLine("Помол кавових зерен...");
            await Task.Delay(2000);
            Console.WriteLine("Кавові зерна змелені.");
        }

        public async Task BrewCoffeeAsync()
        {
            Console.WriteLine("Приготування кави...");
            await Task.Delay(5000);
            Console.WriteLine("Кава готова!");
        }

        public async Task MakeCoffeeAsync()
        {
            Console.WriteLine("Запуск кавового автомата...");
            await HeatWaterAsync();
            await GrindCoffeeAsync();
            await BrewCoffeeAsync();
            Console.WriteLine("Ваш напій готовий. Смачного!");
        }
    }
}
