using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LessonWPF_3
{
    class MyCommand
    {
        public static RoutedCommand Exit { get; set; }
        static MyCommand()
        {
            Exit = new RoutedCommand();
            Bold = new RoutedCommand();
            Italic = new RoutedCommand();
            Underline = new RoutedCommand();
            Black = new RoutedCommand();
            Red = new RoutedCommand();
            DarkStyle = new RoutedCommand();
            LightStyle = new RoutedCommand();
        }
        public static RoutedCommand Bold { get; set; }
        public static RoutedCommand Italic { get; set; }
        public static RoutedCommand Underline { get; set; }
        public static RoutedCommand Black { get; set; }
        public static RoutedCommand Red { get; set; }
        public static RoutedCommand DarkStyle { get; set; }
        public static RoutedCommand LightStyle { get; set; }

    }
}
