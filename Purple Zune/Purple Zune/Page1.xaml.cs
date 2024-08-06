using System;

using System.Collections.Generic;

using System.Linq;

using System.Net;

using System.Windows;

using System.Windows.Controls;

using System.Windows.Documents;

using System.Windows.Input;

using System.Windows.Media;

using System.Windows.Media.Animation;

using System.Windows.Shapes;

using Microsoft.Phone.Controls;

namespace Purple_zune
{

    public partial class Page1 : PhoneApplicationPage
    {

        // Constructor

        public Page1()
        {

            InitializeComponent();

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
          
            string Mysiteurl;

            Mysiteurl = textBox.Text;

            if (Mysiteurl != "")

            { MywebBrowser1.Navigate(new Uri("http://" + Mysiteurl, UriKind.Absolute)); }

        }


    }

}
