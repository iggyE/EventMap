using EventMap.Back;
using EventMap.Front.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Input;

namespace EventMap.Front.ViewModel
{
    public class ShowTagsViewModel
    {
        public ObservableCollection<Etiketa> Tags { get; set; }



        //public EventType SelectedType { get; set; }
        public ICommand DeleteCommand { get; private set; }

        public ShowTagsViewModel()
        {
            Tags = TagsManager.GetTags();
            DeleteCommand = new RelayCommand<Etiketa>(DeleteTag, CanDeleteTag);

        }

        private bool CanDeleteTag(Etiketa tag)
        {
            return true;
        }

        private void DeleteTag(Etiketa tag)
        {

            Tags.Remove(tag);

        }


    }
}
