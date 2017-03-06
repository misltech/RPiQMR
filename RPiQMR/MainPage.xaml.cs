using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace RPiQMR
{

    public sealed partial class MainPage : Page
    {
        Sensor sensor1;

        public MainPage()
        {
            this.InitializeComponent();
             sensor1 = new Sensor(5, 10000, 6, 4, 19);
            SensorValidation();
        }

        private void SensorValidation()
        {
            if (sensor1.active())
            {
                sensor1.Start();
            }
            else
            {
                return;
            }
        }

    }
}
