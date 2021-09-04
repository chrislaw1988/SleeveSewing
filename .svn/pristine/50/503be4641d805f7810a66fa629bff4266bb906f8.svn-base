using Gore.Config.ViewModels;
using Gore.Generic;
using Gore.ProcessControlBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleeveSewing
{
    public class MainWindowViewModel : BindableItem
    {
        private bool showRecipeComboBox;

        public bool ShowRecipeComboBox
        {
            get { return showRecipeComboBox; }
            set { showRecipeComboBox = value; OnPropertyChanged(); }
        }

        private CustomManualPromptViewModel _SubProcessManualPromptViewModel = new CustomManualPromptViewModel(null, null);

        public CustomManualPromptViewModel SubProcessManualPromptViewModel
        {
            get { return _SubProcessManualPromptViewModel; }
            set { _SubProcessManualPromptViewModel = value;  OnPropertyChanged(); }
        }

        private KeyValueObjectsViewModel _KeyValueObjectsViewModel;

        public KeyValueObjectsViewModel KeyValueObjectsViewModel
        {
            get { return _KeyValueObjectsViewModel; }
            set { _KeyValueObjectsViewModel = value; OnPropertyChanged(); }
        }

        

        public MainWindowViewModel()
        {
            //Globals.StockPumpSubProcess = new StockPumpSubProcess(SetManualPromptViewModel);
            //Globals.LoadFilmSubProcess = new LoadFilmSubProcess(SetManualPromptViewModel);

            KeyValueObjectsViewModel = new KeyValueObjectsViewModel("Wrap Head Runtime Info");
           

            KeyValueObjectsViewModel.LoadItem();
            
        }

        public void SetManualPromptViewModel(CustomManualPromptViewModel CustomManualPromptViewModel)
        {
            this.SubProcessManualPromptViewModel = CustomManualPromptViewModel;
        }
    }
}
