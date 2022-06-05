using Maria.TestTask.MeasurementPlanner.Model;
using Maria.TestTask.MeasurementPlanner.UI.Data;
using System.Collections.ObjectModel;
using System;

namespace Maria.TestTask.MeasurementPlanner.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private Measuring _selectedMeasuring;
        public Measuring SelectedMeasuring
        {
            get => _selectedMeasuring;
            set
            {
                _selectedMeasuring = value;
                UpdatePlansOnWeek();
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Measuring> Measurings { get; set; }
        private IMeasurementRepository _measurementDataService;
        private PlanForTheDay _planForTheFirstDay;
        public PlanForTheDay PlansForTheFirstDay
        {
            get => _planForTheFirstDay;
            set => _planForTheFirstDay = value;
        }
        private PlanForTheDay _planForTheSecondDay;
        public PlanForTheDay PlansForTheSecondDay
        {
            get => _planForTheSecondDay;
            set => _planForTheSecondDay = value;
        }
        private PlanForTheDay _planForTheThirdDay;
        public PlanForTheDay PlansForTheThirdDay
        {
            get => _planForTheThirdDay;
            set => _planForTheThirdDay = value;
        }
        private PlanForTheDay _planForTheFourthDay;
        public PlanForTheDay PlansForTheFourthDay
        {
            get => _planForTheFourthDay;
            set => _planForTheFourthDay = value;
        }
        private PlanForTheDay _planForTheFifthDay;
        public PlanForTheDay PlansForTheFifthDay
        {
            get => _planForTheFifthDay;
            set => _planForTheFifthDay = value;
        }
        private PlanForTheDay _planForTheSixthDay;
        public PlanForTheDay PlansForTheSixthDay
        {
            get => _planForTheSixthDay;
            set => _planForTheSixthDay = value;
        }
        private PlanForTheDay _planForTheSeventhDay;
        public PlanForTheDay PlansForTheSeventhDay
        {
            get => _planForTheSeventhDay;
            set => _planForTheSeventhDay = value;
        }
        private IPlansForTheDaysRepository _plansForTheDayDataService;
        public MainViewModel(IMeasurementRepository MeasurementDataService, IPlansForTheDaysRepository PlansForTheDayDataService)
        {
            Measurings = new ObservableCollection<Measuring>();
            _measurementDataService = MeasurementDataService;
            _plansForTheDayDataService = PlansForTheDayDataService;
        }
        private void UpdatePlansOnWeek()
        {
            DateTime dtTemp = DateTime.Now.Date;
            _planForTheFirstDay = null;
            _planForTheSecondDay = null;
            _planForTheThirdDay = null;
            _planForTheFourthDay = null;
            _planForTheFifthDay = null;
            _planForTheSixthDay = null;
            _planForTheSeventhDay = null;
            var plansForTheDays = _plansForTheDayDataService.GetAll();
            foreach (var plan in plansForTheDays)
            {
                if (plan?.DateOfTheDay.Date == dtTemp && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheFirstDay = plan;
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(1) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheSecondDay = plan;
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(2) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheThirdDay = plan;
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(3) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheFourthDay = plan;
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(4) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheFifthDay = plan;
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(5) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheSixthDay = plan;
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(6) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheSeventhDay = plan;
                }
            }
        }
        public void Load()
        {
            var measurings = _measurementDataService.GetAll();
            Measurings.Clear();
            foreach (var measuring in measurings)
            {
                Measurings.Add(measuring);
            }
        }
        /// ///////////////////////////////////
        /// Добавить кнопку внесения выделенного замера в план на день
        /// 
        /// ///////////////////////////////////
        /// Дописать внесение изменений в рабочую коллекцию Data, когда данные полей изменены пользователем в форме
        /// 
        /// ///////////////////////////////////
        /// Добавить кнопку удаления плана на день
        /// 
        /// ///////////////////////////////////
        /// Добавить кнопку удаления замера
        /// 
    }
}
