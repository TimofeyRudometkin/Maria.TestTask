using Maria.TestTask.MeasurementPlanner.Model;
using System;
using System.Collections.Generic;

namespace Maria.TestTask.MeasurementPlanner.UI.Data
{
    public class PlansForTheDaysRepository:IPlansForTheDaysRepository
    {
        public IEnumerable<PlanForTheDay> GetAll()
        {
            string[] cities = { "Саратов", "Самара", "Тольятти", "Балаково", "Новгород", "Москва", "Санкт-Петербург" };
            byte limitOfMeasurmentsPerDay = 15;
            Random randome = new Random();
            DateTime dtTemp = DateTime.Now.AddDays(-3);
            DateTime dtLastDay = DateTime.Now.AddDays(10);

            for(; dtTemp < dtLastDay; dtTemp = dtTemp.AddDays(1))
            {
                foreach (string city in cities)
                {
                    yield return new PlanForTheDay((byte)randome.Next(limitOfMeasurmentsPerDay), city, dtTemp);
                }
            }
        }
    }
}
