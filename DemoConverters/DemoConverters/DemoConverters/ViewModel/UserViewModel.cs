using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;

namespace DemoConverters.ViewModel
{
    public class UserViewModel : BindableObject, INotifyPropertyChanged
    {
        public UserModel User
        {
            get;
            set;
        }
        
        public UserViewModel()
        {
            GetUser();
           
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
