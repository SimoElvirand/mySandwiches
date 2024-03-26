using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace testPY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string Sensormes2;
        string Sensormes3;
        string Sensormes4;
        string Sensormes8;
        string Sensormes9;
        string Sensormes10;
        string Sensormes11;
        string Sensormes13;
        string Sensormes14;
        string Sensormes16;
        string Sensormes17;
        string Unitnumber;
        string Timeincycles;
        //string Rul;
        string output;
      
        private void set()
        {
            string sensor = SensorMes11.Text;
            float sensornum = float.Parse(sensor);
            float min = 36.04f;
            float max = 48.36f;
            float diff1 = (sensornum - min);
            float diff2 = (max - min);
            float sensorresult = (diff1 / diff2);
            SensorMes11.Text = sensorresult.ToString();
            Sensormes11 = SensorMes11.Text;
            //sensormes9
            sensor = SensorMes9.Text;
            sensornum = float.Parse(sensor);
            min = 7984.51f;
            max = 9196.81f;
            diff1 = (sensornum - min);
            diff2 = (max - min);
            sensorresult = (diff1 / diff2);
           SensorMes9.Text = sensorresult.ToString();
           Sensormes9 = SensorMes9.Text;
            //sensormes4
             sensor = SensorMes4.Text;
             sensornum = float.Parse(sensor);
             min = 1024.42f;
             max = 1440.77f;
             diff1 = (sensornum - min);
             diff2 = (max - min);
             sensorresult = (diff1 / diff2);
            SensorMes4.Text = sensorresult.ToString();
            Sensormes4 = SensorMes4.Text;
            //sensormes8
            //sensormes3
             sensor = SensorMes3.Text;
             sensornum = float.Parse(sensor);
             min = 1242.67f;
             max = 1613.0f;
             diff1 = (sensornum - min);
             diff2 = (max - min);
             sensorresult = (diff1 / diff2);
            SensorMes3.Text = sensorresult.ToString();
            Sensormes3 = SensorMes3.Text;

            //sensormes10
             sensor = SensorMes10.Text;
            sensornum = float.Parse(sensor);
             min = 0.93f;
             max = 1.32f;
             diff1 = (sensornum - min);
             diff2 = (max - min);
             sensorresult = (diff1 / diff2);
            SensorMes10.Text = sensorresult.ToString();
            Sensormes10 = SensorMes10.Text;
            //sensormes2
            sensor = SensorMes2.Text;
            sensornum = float.Parse(sensor);
             min = 535.48f;
            max = 644.42f;
            diff1 = (sensornum - min);
            diff2 = (max - min);
            sensorresult = (diff1 / diff2);
            SensorMes2.Text =  sensorresult.ToString();
            Sensormes2 = SensorMes2.Text;
            //sensormes13
            sensor = SensorMes13.Text;
            sensornum = float.Parse(sensor);
            min = 2027.57f;
            max = 2390.49f;
            diff1 = (sensornum - min);
            diff2 = (max - min);
            sensorresult = (diff1 / diff2);
            SensorMes13.Text = sensorresult.ToString();
            Sensormes13 = SensorMes13.Text;
            //sensormes14
            sensor = SensorMes14.Text;
            sensornum = float.Parse(sensor);
            min = 7845.78f;
            max = 8261.65f;
            diff1 = (sensornum - min);
            diff2 = (max - min);
           sensorresult = (diff1 / diff2);
           SensorMes14.Text = sensorresult.ToString();
           Sensormes14 = SensorMes14.Text;
            //sensormes16
            sensor = SensorMes16.Text;
            sensornum = float.Parse(sensor);
            min = 0.02f;
            max = 0.03f;
            diff1 = (sensornum - min);
            diff2 = (max - min);
            sensorresult = (diff1 / diff2);
            SensorMes16.Text = sensorresult.ToString();
            Sensormes16 = SensorMes16.Text;
            //sensormes17
            sensor = SensorMes17.Text;
            sensornum = float.Parse(sensor);
            min = 302f;
            max = 399f;
            diff1 = (sensornum - min);
            diff2 = (max - min);
            sensorresult = (diff1 / diff2);
            SensorMes17.Text = sensorresult.ToString();
            Sensormes17 = SensorMes17.Text;
            //unitnumber
            string unit = UnitNumber.Text;
            float unitnum = float.Parse(unit);
             min = 1f;
             max = 249f;
             diff1 = (unitnum - min);
             diff2 = (max - min);
            float unitresult = (diff1 / diff2);
            UnitNumber.Text = unitresult.ToString();
            Unitnumber = UnitNumber.Text;
            //timecycles
            string time = TimeInCycle.Text;
            float timenum = float.Parse(time);
             min = 1f;
             max = 543f;
            diff1 = (timenum - min);
            diff2 = (max - min);
            float timeresult = (diff1 / diff2);
            TimeInCycle.Text = timeresult.ToString();
            Timeincycles = TimeInCycle.Text;

        }
        private void displayRUL()
        {
            string gold = output;
            //float goldnum = float.Parse(gold);
            float min = 0f;
            float max = 542f;
            float diff2 = (max - min);
            //float goldresult = ((diff2*goldnum)+min);
            rul.Text = gold;
            ;
        }

        private void SensorMes11_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SensorMes9_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void SensorMes4_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SensorMes3_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void SensorMes2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TimeInCycle_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void UnitNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SensorMes14_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SensorMes10_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SensorMes13_TextChanged(object sender, TextChangedEventArgs e)
        {
       
        }

        private void SensorMes16_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SensorMes17_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void rul_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void send_Click(object sender, RoutedEventArgs e)
        {
            //string p = "oui";
            set();
            string p = Unitnumber + " " + Timeincycles + " " + Sensormes2 + " " + Sensormes3 + " " + Sensormes4 + " " + Sensormes8 + " " + Sensormes9 + " " + Sensormes10 + " " + Sensormes11 + " " + Sensormes13 + " " + Sensormes14 + " " + Sensormes16 + " " + Sensormes17;
            StreamWriter writer = new StreamWriter(@"C:\Users\simog\Downloads\NASA-Turbofan-Jet-Engine-RUL-prediction-C-MAPSS-main\NASA-Turbofan-Jet-Engine-RUL-prediction-C-MAPSS-main\Failure prediction\testpy.txt");
            writer.Write(p);
            writer.Close();
            processRUL c = new processRUL();
            string s = c.getRul();
            output = s;
            writer = new StreamWriter(@"C:\Users\simog\Downloads\NASA-Turbofan-Jet-Engine-RUL-prediction-C-MAPSS-main\NASA-Turbofan-Jet-Engine-RUL-prediction-C-MAPSS-main\Failure prediction\test.txt");
            writer.Write(s);
            writer.Close();
            displayRUL();
        }
    }
}
