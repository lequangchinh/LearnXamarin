using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;

namespace DemoConverter.ViewModel
{
    public class UserViewModel : BindableObject, INotifyPropertyChanged
    {
        public UserModel User
        {
            get;
            set;
        }
        public int CntClick { get; set; } = 0;
        public ICommand Comman1 { set; get; }
        public UserViewModel()
        {
            GetUser();
            Comman1 = new Command(HandleAction);
        }

        public void HandleAction(object obj)
        {
            CntClick++;
            OnPropertyChanged("CntClick");
        }

        public void GetUser()
        {
            User = new UserModel()
            {
                Name = "User 1",
                Sex = 1
            };
        }
    }

    public class UserModel
    {
        public string Name { set; get; }
        public int Sex { get; set; }
    }
}
