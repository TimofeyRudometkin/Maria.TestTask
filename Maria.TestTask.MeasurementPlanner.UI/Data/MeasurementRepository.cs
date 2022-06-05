using Maria.TestTask.MeasurementPlanner.Model;
using System;
using System.Collections.Generic;

namespace Maria.TestTask.MeasurementPlanner.UI.Data
{
    public class MeasurementRepository : IMeasurementRepository
    {
        public IEnumerable<Measuring> GetAll()
        {
            string[] names = { "Александр", "Алексей", "Борис", "Егор", "Дмитрий", "Константин", "Юрий" };
            string[] patronymics = { "Александрович", "Алексеевич", "Борисович", "Егорович", "Дмитриевич", "Константинович", "Юрьевич" };
            string[] surnames = { "Алексеев", "Самсонов", "Иванов", "Кузнецов", "Партизанов", "Лентяев", "Голодный" };
            string[] cities = { "Саратов", "Самара", "Тольятти", "Балаково", "Новгород", "Москва", "Санкт-Петербург" };
            Random randome = new Random();
            for (byte id = 1; id < 15; id++)//почему-то итерирует +2, а не +1
            {
                yield return new Measuring() { Id = id++, City = cities[randome.Next(cities.Length-1)], Name = names[randome.Next(names.Length-1)], Patronymic = patronymics[randome.Next(patronymics.Length-1)], Surname = surnames[randome.Next(surnames.Length-1)] };
            }
        }
    }
}
