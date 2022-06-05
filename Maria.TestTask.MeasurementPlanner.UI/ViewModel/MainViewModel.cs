using Maria.TestTask.MeasurementPlanner.Model;
using Maria.TestTask.MeasurementPlanner.UI.Data;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

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
                _selectedPlanForTheDay = null;
                UpdatePlansOnWeek();
                OnPropertyChanged();
            }
        }
        private PlanForTheDay _selectedPlanForTheDay;
        public PlanForTheDay SelectedPlanForTheDay
        {
            get => _selectedPlanForTheDay;
            set
            {
                _selectedPlanForTheDay = value;
                //UpdatePlansOnWeek();
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Measuring> Measurings { get; set; }
        private IMeasurementRepository _measurementDataService;
        public IEnumerable<PlanForTheDay> PlansForThetDay { get; set; }
        public ObservableCollection<PlanForTheDay> PlansForTheFirstDay { get; set; }
        public ObservableCollection<PlanForTheDay> PlansForTheSecondDay { get; set; }
        public ObservableCollection<PlanForTheDay> PlansForTheThirdDay { get; set; }
        public ObservableCollection<PlanForTheDay> PlansForTheFourthDay { get; set; }
        public ObservableCollection<PlanForTheDay> PlansForTheFifthDay { get; set; }
        public ObservableCollection<PlanForTheDay> PlansForTheSixthDay { get; set; }
        public ObservableCollection<PlanForTheDay> PlansForTheSeventhDay { get; set; }

        private IPlansForTheDaysRepository _plansForTheDayDataService;
        public MainViewModel(IMeasurementRepository MeasurementDataService, IPlansForTheDaysRepository PlansForTheDayDataService)
        {
            Measurings = new ObservableCollection<Measuring>();
            _measurementDataService = MeasurementDataService;
            PlansForTheFirstDay = new ObservableCollection<PlanForTheDay>();
            PlansForTheSecondDay = new ObservableCollection<PlanForTheDay>();
            PlansForTheThirdDay = new ObservableCollection<PlanForTheDay>();
            PlansForTheFourthDay = new ObservableCollection<PlanForTheDay>();
            PlansForTheFifthDay = new ObservableCollection<PlanForTheDay>();
            PlansForTheSixthDay = new ObservableCollection<PlanForTheDay>();
            PlansForTheSeventhDay = new ObservableCollection<PlanForTheDay>();
            _plansForTheDayDataService = PlansForTheDayDataService;
            PlansForThetDay = _plansForTheDayDataService.GetAll();//прописал здесь, т.к. при вызове GetAll элементы не берутся из хранилица, а вновь создаются, поэтому коллекцию берём 1 раз
                                                                  //не помогло, значение свойства NumberOfAvailableMeasurements всё равно меняется
                                                                  //почему-то конструктор класса срабатывает
                                                                  //если разобраться не получиться доработать конструктор
        }
        private void UpdatePlansOnWeek()
        {
            PlansForTheFirstDay.Clear();
            PlansForTheSecondDay.Clear();
            PlansForTheThirdDay.Clear();
            PlansForTheFourthDay.Clear();
            PlansForTheFifthDay.Clear();
            PlansForTheSixthDay.Clear();
            PlansForTheSeventhDay.Clear();

            DateTime dtTemp = DateTime.Now.Date;
            //var plansForTheDays = _plansForTheDayDataService.GetAll();
            //foreach (var plan in plansForTheDays)
            foreach (var plan in PlansForThetDay)
            {
                if (plan?.DateOfTheDay.Date == dtTemp && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheFirstDay.Add(plan);
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(1) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheSecondDay.Add(plan);
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(2) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheThirdDay.Add(plan);
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(3) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheFourthDay.Add(plan);
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(4) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheFifthDay.Add(plan);
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(5) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheSixthDay.Add(plan);
                }
                else if (plan?.DateOfTheDay.Date == dtTemp.AddDays(6) && plan?.City == _selectedMeasuring?.City)
                {
                    PlansForTheSeventhDay.Add(plan);
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
