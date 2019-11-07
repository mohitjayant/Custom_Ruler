using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RulerPrint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Vector windowOrigin = new Vector(0,0);
        ToolTip cursorToolTip;

        public MainWindow()
        {
            InitializeComponent();
            cursorToolTip = new ToolTip();
            myCanvas.ToolTip = cursorToolTip;


            
        }

       
        private void Window_MouseMove_1(object sender, MouseEventArgs e)
        {
            Point myPoint = e.GetPosition(myCanvas);
            windowOrigin.X = myCanvas.ActualWidth / 2;
            windowOrigin.Y = myCanvas.ActualHeight / 2;
            cursorToolTip.HorizontalOffset = myPoint.X - 200;
            cursorToolTip.VerticalOffset = myPoint.Y - 200;
            cursorToolTip.Content = "(" + (1000-(myPoint.X)) + ", " +(600-myPoint.Y) + ")";
            horizontalRuler.RaiseHorizontalRulerMoveEvent(e);
            verticalRuler.RaiseVerticalRulerMoveEvent(e);
        }
    }
}
