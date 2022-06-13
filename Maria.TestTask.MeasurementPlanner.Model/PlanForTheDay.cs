using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maria.TestTask.MeasurementPlanner.Model
{
    public class PlanForTheDay
    {
        private byte _limitOfMeasurements;
        private byte _numberOfAvailableMeasurements;
        private string _city;
        private DateTime _dtOfMeasurements;
        private Dictionary<string, uint> _dictDtAndMeasurements = new Dictionary<string, uint>();
        //private string[] _scheduleOfAvailable;
        private byte _durationOfMeasurementInMinutes = 30;
        private byte _hourFirstMeasurement = 9;
        private byte _minuteFirstMeasurement = 0;
        private byte _hourLastMeasurement = 18;
        private byte _minuteLastMeasurement = 30;
        public PlanForTheDay(byte limitOfMeasurements, string city, DateTime dtOfMeasurements)
        {
            //var dfd = _dictDtAndMeasurements.Keys;
            List<string> listTemp = new List<string>();
            _city = city;
            _dtOfMeasurements = dtOfMeasurements.Date;
            DateTime dtTemp1 = new DateTime(dtOfMeasurements.Year, dtOfMeasurements.Month, dtOfMeasurements.Day, _hourFirstMeasurement, _minuteFirstMeasurement, 0);
            DateTime dtTemp2 = new DateTime(dtOfMeasurements.Year, dtOfMeasurements.Month, dtOfMeasurements.Day, _hourLastMeasurement, _minuteLastMeasurement, 0);
            for (; dtTemp1.AddMinutes(_durationOfMeasurementInMinutes) <= dtTemp2; dtTemp1 = dtTemp1.AddMinutes(_durationOfMeasurementInMinutes))
            {
                _dictDtAndMeasurements.Add($"{dtTemp1.ToString("dd MM")} c {dtTemp1.ToString("HH mm")} до {dtTemp1.AddMinutes(_durationOfMeasurementInMinutes).ToString("HH mm")}", 0);
            }
            //_scheduleOfAvailable = listTemp.ToArray();
            _limitOfMeasurements = limitOfMeasurements < _dictDtAndMeasurements.Count() ? limitOfMeasurements : (byte)_dictDtAndMeasurements.Count();
            _numberOfAvailableMeasurements = _limitOfMeasurements;
        }
        public byte LimitOfMeasurements { get => _limitOfMeasurements; }
        public byte NumberOfAvailableMeasurements { get => _numberOfAvailableMeasurements; set => _numberOfAvailableMeasurements = value; }
        public string City { get => _city; }
        public DateTime DateOfTheDay { get => _dtOfMeasurements; }
        //public string[] ScheduleOfAvailable { get => _scheduleOfAvailable; set => _scheduleOfAvailable = value; }
        //public DateTime[] AvailableDateTime { get => _dictDtAndMeasurements.Keys.ToArray(); }
        public Dictionary<string, uint> DictDtAndMeasurements { get => _dictDtAndMeasurements; set => _dictDtAndMeasurements = value; }
        //public Boolean AddMeasuring(string dtMeasuring, Measuring measuring)
        //{
        //    try
        //    {
        //        if (_dictDtAndMeasurements[dtMeasuring] == null)
        //        {
        //            _dictDtAndMeasurements[dtMeasuring] = measuring;
        //            _numberOfAvailableMeasurements--;
        //            return true;
        //        }
        //    }
        //    catch { }
        //    return false;
        //}
    }
}
