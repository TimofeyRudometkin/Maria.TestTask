using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Maria.TestTask.MeasurementPlanner.Model
{
    public class Measuring
    {
        private uint _id;
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _telephoneNumber;
        private string _city;
        public uint Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public string Patronymic
        {
            get => _patronymic;
            set => _patronymic = value;
        }
        public string TelephoneNumber
        {
            get => _telephoneNumber;
            set => _telephoneNumber = Regex.Replace(value, "[^\\d]", "");
        }
        public string City
        {
            get => _city;
            set => _city = value;
        }
    }
}
