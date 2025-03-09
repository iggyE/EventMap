using EventMap.Back;
using EventMap.Front.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventMap.Front.ViewModel
{
    public class ShowTypeViewModel
    {

        public ObservableCollection<TipDogadjaja> Types { get; set; }



        //public EventType SelectedType { get; set; }
        public ICommand DeleteCommand { get; private set; }

        public ShowTypeViewModel()
        {
            Types = TypeManager.GetTypes();
            DeleteCommand = new RelayCommand<TipDogadjaja>(DeleteType, CanDeleteType);

        }

        private bool CanDeleteType(TipDogadjaja tip)
        {
            return true;
        }

        private void DeleteType(TipDogadjaja tip)
        {

            Types.Remove(tip);

        }

    }
}
