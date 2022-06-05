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
        private Dictionary<DateTime, Measuring> _dictDtAndMeasurements = new Dictionary<DateTime, Measuring>();
        private byte _durationOfMeasurementInMinutes = 30;
        private byte _hourFirstMeasurement = 9;
        private byte _minuteFirstMeasurement = 0;
        private byte _hourLastMeasurement = 18;
        private byte _minuteLastMeasurement = 30;
        public PlanForTheDay(byte limitOfMeasurements, string city, DateTime dtOfMeasurements)
        {
            _city = city;
            _dtOfMeasurements = dtOfMeasurements.Date;
            DateTime dtTemp1 = new DateTime(dtOfMeasurements.Year, dtOfMeasurements.Month, dtOfMeasurements.Day, _hourFirstMeasurement, _minuteFirstMeasurement, 0);
            DateTime dtTemp2 = new DateTime(dtOfMeasurements.Year, dtOfMeasurements.Month, dtOfMeasurements.Day, _hourLastMeasurement, _minuteLastMeasurement, 0);
            for (; dtTemp1.AddMinutes(_durationOfMeasurementInMinutes) <= dtTemp2; dtTemp1 = dtTemp1.AddMinutes(_durationOfMeasurementInMinutes))
            {
                _dictDtAndMeasurements.Add(dtTemp1, null);
            }
            _limitOfMeasurements = limitOfMeasurements < _dictDtAndMeasurements.Count() ? limitOfMeasurements : (byte)_dictDtAndMeasurements.Count();
            _numberOfAvailableMeasurements = _limitOfMeasurements;
        }
        public byte LimitOfMeasurements { get => _limitOfMeasurements; }
        public byte NumberOfAvailableMeasurements { get => _numberOfAvailableMeasurements; }
        public string City { get => _city; }
        public DateTime DateOfTheDay { get => _dtOfMeasurements; }
        public Dictionary<DateTime, Measuring> DictDtAndMeasurements { get => _dictDtAndMeasurements; }
        public Boolean AddMeasuring(DateTime dtMeasuring, Measuring measuring)
        {
            try
            {
                if (_dictDtAndMeasurements[dtMeasuring] == null)
                {
                    _dictDtAndMeasurements[dtMeasuring] = measuring;
                    _numberOfAvailableMeasurements--;
                    return true;
                }
            }
            catch { }
            return false;
        }
    }
}
