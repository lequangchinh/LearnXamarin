using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;

namespace DemoCommand
{
    public class TestCommand : BindableObject, INotifyPropertyChanged
    {

        public int CntClick { get; set; } = 0;
        public ICommand Comman1 { set; get; }
        public TestCommand()
        {
            Comman1 = new Command(HandleAction);
        }

        public void HandleAction(object obj)
        {
            CntClick++;
            OnPropertyChanged("CntClick");
        }


    }
}
