using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace App38
{
    public sealed class MyCustomButton : Button
    {
        public MyCustomButton()
        {
            this.DefaultStyleKey = typeof(MyCustomButton);
        }



        public CornerRadius MyCornerRadius
        {
            get { return (CornerRadius)GetValue(MyCornerRadiusProperty); }
            set { SetValue(MyCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyCornerRadiusProperty =
            DependencyProperty.Register("MyCornerRadius", typeof(CornerRadius), typeof(MyCustomButton), new PropertyMetadata(0));

    }
}
