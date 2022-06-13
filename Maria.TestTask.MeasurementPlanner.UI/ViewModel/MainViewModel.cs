using Maria.TestTask.MeasurementPlanner.Model;
using Maria.TestTask.MeasurementPlanner.UI.Data;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using Maria.TestTask.MeasurementPlanner.UI.Commands;
using System.Windows.Input;
using System.Windows;
using System.Text.RegularExpressions;

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
                DateTime dtTemp = DateTime.Now.Date;
                foreach (PlanForTheDay planForTheDay in PlansForThetDay)
                {
                    if (planForTheDay.City == value.City && planForTheDay.DateOfTheDay == dtTemp)
                    {
                        PlanForTheFirstDay = planForTheDay;
                    }else if (planForTheDay.City == value.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(1))
                    {
                        PlansForTheSecondDay = planForTheDay;
                    }
                    else if (planForTheDay.City == value.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(2))
                    {
                        PlansForTheThirdDay = planForTheDay;
                    }
                    else if (planForTheDay.City == value.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(3))
                    {
                        PlansForTheFourthDay = planForTheDay;
                    }
                    else if (planForTheDay.City == value.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(4))
                    {
                        PlansForTheFifthDay = planForTheDay;
                    }
                    else if (planForTheDay.City == value.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(5))
                    {
                        PlansForTheSixthDay = planForTheDay;
                    }
                    else if (planForTheDay.City == value.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(6))
                    {
                        PlansForTheSeventhDay = planForTheDay;
                    }
                }
                OnPropertyChanged();
            }
        }
        //private PlanForTheDay _selectedPlanForTheDay;
        //private PlanForTheDay SelectedPlanForTheDay
        //{
        //    get => _selectedPlanForTheDay;
        //    set
        //    {
        //        _selectedPlanForTheDay = value;
        //    }
        //}
        private PlanForTheDay _planForTheFirstDay;
        public PlanForTheDay PlanForTheFirstDay
        {
            get => _planForTheFirstDay;
            set
            {
                _planForTheFirstDay = value;
                //if(SelectedPlanForTheDay?.DateOfTheDay == value?.DateOfTheDay)
                //{
                //    SelectedPlanForTheDay = value;
                //}
                OnPropertyChanged();
            }
        }
        private PlanForTheDay _plansForTheSecondDay;
        public PlanForTheDay PlansForTheSecondDay
        {
            get => _plansForTheSecondDay;
            set
            {
                _plansForTheSecondDay = value;
                //if(SelectedPlanForTheDay?.DateOfTheDay == value?.DateOfTheDay)
                //{
                //    SelectedPlanForTheDay = value;
                //}
                OnPropertyChanged();
            }
        }
        private PlanForTheDay _plansForTheThirdDay;
        public PlanForTheDay PlansForTheThirdDay
        {
            get => _plansForTheThirdDay;
            set
            {
                _plansForTheThirdDay = value;
                //if (SelectedPlanForTheDay?.DateOfTheDay == value?.DateOfTheDay)
                //{
                //    SelectedPlanForTheDay = value;
                //}
                OnPropertyChanged();
            }
        }
        private PlanForTheDay _plansForTheFourthDay;
        public PlanForTheDay PlansForTheFourthDay
        {
            get => _plansForTheFourthDay;
            set
            {
                _plansForTheFourthDay = value;
                //if (SelectedPlanForTheDay?.DateOfTheDay == value?.DateOfTheDay)
                //{
                //    SelectedPlanForTheDay = value;
                //}
                OnPropertyChanged();
            }
        }
        private PlanForTheDay _plansForTheFifthDay;
        public PlanForTheDay PlansForTheFifthDay
        {
            get => _plansForTheFifthDay;
            set
            {
                _plansForTheFifthDay = value;
                //if (SelectedPlanForTheDay?.DateOfTheDay == value?.DateOfTheDay)
                //{
                //    SelectedPlanForTheDay = value;
                //}
                OnPropertyChanged();
            }
        }
        private PlanForTheDay _plansForTheSixthDay;
        public PlanForTheDay PlansForTheSixthDay
        {
            get => _plansForTheSixthDay;
            set
            {
                _plansForTheSixthDay = value;
                //if (SelectedPlanForTheDay?.DateOfTheDay == value?.DateOfTheDay)
                //{
                //    SelectedPlanForTheDay = value;
                //}
                OnPropertyChanged();
            }
        }
        private PlanForTheDay _plansForTheSeventhDay;
        public PlanForTheDay PlansForTheSeventhDay
        {
            get => _plansForTheSeventhDay;
            set
            {
                _plansForTheSeventhDay = value;
                //if (SelectedPlanForTheDay?.DateOfTheDay == value?.DateOfTheDay)
                //{
                //    SelectedPlanForTheDay = value;
                //}
                OnPropertyChanged();
            }
        }
        private string _selectedTimeRange;
        public string SelectedTimeRange
        {
            get => _selectedTimeRange;
            set
            {
                _selectedTimeRange = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Measuring> Measurings { get; set; }
        private IMeasurementRepository _measurementDataService;
        private ObservableCollection<PlanForTheDay> _plansForThetDay;
        public ObservableCollection<PlanForTheDay> PlansForThetDay { get=> _plansForThetDay; 
            set
            {
                DateTime dtTemp = DateTime.Now.Date;
                foreach (PlanForTheDay planForTheDay in value)
                {
                    if (planForTheDay.City == _selectedMeasuring.City && planForTheDay.DateOfTheDay == dtTemp)
                    {
                        PlanForTheFirstDay = planForTheDay;
                    }
                    else if (planForTheDay.City == _selectedMeasuring.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(1))
                    {
                        PlansForTheSecondDay = planForTheDay;
                    }
                    else if (planForTheDay.City == _selectedMeasuring.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(2))
                    {
                        PlansForTheThirdDay = planForTheDay;
                    }
                    else if (planForTheDay.City == _selectedMeasuring.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(3))
                    {
                        PlansForTheFourthDay = planForTheDay;
                    }
                    else if (planForTheDay.City == _selectedMeasuring.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(4))
                    {
                        PlansForTheFifthDay = planForTheDay;
                    }
                    else if (planForTheDay.City == _selectedMeasuring.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(5))
                    {
                        PlansForTheSixthDay = planForTheDay;
                    }
                    else if (planForTheDay.City == _selectedMeasuring.City && planForTheDay.DateOfTheDay == dtTemp.AddDays(6))
                    {
                        PlansForTheSeventhDay = planForTheDay;
                    }
                }
                _plansForThetDay = value;
            }
        }

        private IPlansForTheDaysRepository _plansForTheDayDataService;
        public AddMeasuringToPlan ButtonAddMeasuringToPlan { get; set; }
        public MainViewModel(IMeasurementRepository MeasurementDataService, IPlansForTheDaysRepository PlansForTheDayDataService)
        {
            Measurings = new ObservableCollection<Measuring>();
            _measurementDataService = MeasurementDataService;
            PlansForThetDay = new ObservableCollection<PlanForTheDay>();
            _plansForTheDayDataService = PlansForTheDayDataService;
            ButtonAddMeasuringToPlan = new AddMeasuringToPlan(this);
        }
        public void AddMeasuringToPlan()
        {
            PlanForTheDay tempPlanForTheDay = null;
            string strTemp = Regex.Match(SelectedTimeRange, @"\[(.*?),").Groups[1].Value;
            foreach (PlanForTheDay plan in PlansForThetDay)
            {
                if (plan.DictDtAndMeasurements.ContainsValue(SelectedMeasuring.Id))
                {
                    MessageBox.Show($"Замер № {SelectedMeasuring.Id} уже был добавлен на {plan.DateOfTheDay.ToShortDateString()}");
                    return;
                }
                if (plan.DictDtAndMeasurements.ContainsKey(strTemp))
                {
                    tempPlanForTheDay = plan;
                }
            }
            if (tempPlanForTheDay?.NumberOfAvailableMeasurements > 0 && tempPlanForTheDay?.DictDtAndMeasurements[strTemp] == 0)
            {
                tempPlanForTheDay.DictDtAndMeasurements[strTemp]= SelectedMeasuring.Id;
                tempPlanForTheDay.NumberOfAvailableMeasurements--;
                PlansForThetDay[PlansForThetDay.IndexOf(tempPlanForTheDay)]= tempPlanForTheDay;
                DateTime dtTemp = DateTime.Now.Date;
                if (tempPlanForTheDay.DateOfTheDay == dtTemp)
                {
                    PlanForTheFirstDay = tempPlanForTheDay;
                }
                else if (tempPlanForTheDay.DateOfTheDay == dtTemp.AddDays(1))
                {
                    PlansForTheSecondDay = tempPlanForTheDay;
                }
                else if (tempPlanForTheDay.DateOfTheDay == dtTemp.AddDays(2))
                {
                    PlansForTheThirdDay = tempPlanForTheDay;
                }
                else if (tempPlanForTheDay.DateOfTheDay == dtTemp.AddDays(3))
                {
                    PlansForTheFourthDay = tempPlanForTheDay;
                }
                else if (tempPlanForTheDay.DateOfTheDay == dtTemp.AddDays(4))
                {
                    PlansForTheFifthDay = tempPlanForTheDay;
                }
                else if (tempPlanForTheDay.DateOfTheDay == dtTemp.AddDays(5))
                {
                    PlansForTheSixthDay = tempPlanForTheDay;
                }
                else if (tempPlanForTheDay.DateOfTheDay == dtTemp.AddDays(6))
                {
                    PlansForTheSeventhDay = tempPlanForTheDay;
                }


                MessageBox.Show($"Замер № {SelectedMeasuring.Id} внесён в план на {strTemp} {tempPlanForTheDay.DateOfTheDay.ToShortDateString()}.");
                return;
            }
            MessageBox.Show($"Замер № {SelectedMeasuring.Id} не удалось добавить на {strTemp} {tempPlanForTheDay.DateOfTheDay.ToShortDateString()}.");
        }
        public void Load()
        {
            var measurings = _measurementDataService.GetAll();
            Measurings.Clear();
            foreach (var measuring in measurings)
            {
                Measurings.Add(measuring);
            }
            var planForTheDays = _plansForTheDayDataService.GetAll();
            foreach (var plan in planForTheDays)
            {
                PlansForThetDay.Add(plan);
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
