using Gore.Config.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleeveSewing
{
    public class KeyValueObjectsViewModel : SaveLoadObjectsViewModel<KeyValueObjectViewModel>
    {
        public KeyValueObjectsViewModel(string Name) : base(Name)
        {
            //max of 4 heads on a given wrapper
            for (int i = 0; i < 4; i++)
            {
                var newDefaultItem = AddItem();
                newDefaultItem.Header = (i + 1).ToString();
            }
        }
    }
}
