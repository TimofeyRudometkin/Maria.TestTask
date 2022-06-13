using Maria.TestTask.MeasurementPlanner.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Maria.TestTask.MeasurementPlanner.UI.Commands
{
    public class AddMeasuringToPlan:ICommand
    {
        MainViewModel _mainViewModel;
        public AddMeasuringToPlan(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            //попробовать дописать доступность только при выбранном временном диапазоне
            return true;
        }

        public void Execute(object parameter)
        {
            _mainViewModel.AddMeasuringToPlan();
        }
    }
}
