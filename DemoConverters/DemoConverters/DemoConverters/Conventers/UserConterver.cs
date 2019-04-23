using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace DemoConverters.Convertters
{
    public class UserConterver : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value.ToString() == "")
                return ((Label)parameter).Text;

            string sex = "";

            switch (int.Parse(value.ToString()))
            {
                case 1:
                    sex = "Nam";
                    break;
                case 0:
                    sex = "Nữ";
                    break;
            }

            return sex;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "Không xác định";

            string sex = (string)value;
            int intSex = -1;

            if (sex == "Nam")
            {
                intSex = 1;
            }
            else if (sex == "Nữ")
            {
                intSex = 0;
            }
            return intSex;
        }
    }
}
