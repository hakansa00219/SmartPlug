using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SmartPlugApp
{
    public partial class Plug : Form
    {
        private string Relay1ONfilepath = "C:\\Users\\Hakan\\Desktop\\Bitirme\\SmartPlugApp\\SmartPlugApp\\mqtt_relay1_ON.py";
        private string Relay1OFFfilepath = "C:\\Users\\Hakan\\Desktop\\Bitirme\\SmartPlugApp\\SmartPlugApp\\mqtt_relay1_OFF.py";
        private string Relay2ONfilepath = "C:\\Users\\Hakan\\Desktop\\Bitirme\\SmartPlugApp\\SmartPlugApp\\mqtt_relay2_ON.py";
        private string Relay2OFFfilepath = "C:\\Users\\Hakan\\Desktop\\Bitirme\\SmartPlugApp\\SmartPlugApp\\mqtt_relay2_OFF.py";
        private string CurrentTextfilepath = "C:\\Users\\Hakan\\Desktop\\Bitirme\\CurrentData.txt";
        string Relay1 = "Relay1", Relays = "Relays", Relay2 = "Relay2";
        string _ON = "_ON", _OFF = "_OFF";
        string[] RealDatess;
        string[] FirstCurrent, SecondCurrent;
        public bool KisPressed = false, LVisPressed = false;
        string[] RealCurrentss;
        double AvgPowerMonthly;
        double TotalFirstCurrentDaily, TotalSecondCurrentDaily,TotalFirstCurrentHourly,TotalSecondCurrentHourly,TotalFirstCurrentWeekly,TotalSecondCurrentWeekly;
        double AvgFirstPowerDaily, AvgSecondPowerDaily,FakeAvgFirstPowerDaily,FakeAvgSecondPowerDaily,FakeAvgFirstPowerWeekly,FakeAvgFirstPowerMonthly,FakeAvgSecondPowerWeekly,FakeAvgSecondPowerMonthly;


        public Plug()
        {
            InitializeComponent();
            // read all text in file
            TestError();
            CalculateValues();
            InitTimer();
        }
        public void CalculateValues()
        {
            double TotalCurrentMinutely = 0, TotalCurrentHourly = 0, TotalCurrentDaily = 0,TotalCurrentWeekly = 0;
            TotalFirstCurrentDaily = 0;
            TotalSecondCurrentDaily = 0;
            TotalFirstCurrentHourly = 0;
            TotalSecondCurrentHourly = 0;
            TotalFirstCurrentWeekly = 0;
            TotalSecondCurrentWeekly = 0;
            for (int i = RealCurrentss.Length; i >= RealCurrentss.Length - 60; i--)
            {
                try
                {
                    TotalCurrentMinutely += double.Parse(FirstCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalCurrentMinutely += double.Parse(SecondCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("bla bla1");

                }

            }
            for (int i = RealCurrentss.Length; i >= RealCurrentss.Length - 3600; i--)
            {
                try
                {
                    TotalFirstCurrentHourly += double.Parse(FirstCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalSecondCurrentHourly += double.Parse(SecondCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalCurrentHourly += double.Parse(FirstCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalCurrentHourly += double.Parse(SecondCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                } catch
                {
                    Console.WriteLine("Some error occured.");
                }
                 
                    
            }
            for (int i = RealCurrentss.Length; i >= RealCurrentss.Length - 86400; i--)
            {
                try
                {
                    TotalFirstCurrentDaily += double.Parse(FirstCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalSecondCurrentDaily += double.Parse(SecondCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalCurrentDaily += double.Parse(FirstCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalCurrentDaily += double.Parse(SecondCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("Some error occured.");
                }
            }
            for (int i = RealCurrentss.Length; i >= RealCurrentss.Length - 604800; i--)
            {
                try
                {
                    TotalFirstCurrentWeekly += double.Parse(FirstCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalSecondCurrentWeekly += double.Parse(SecondCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalCurrentWeekly += double.Parse(FirstCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                    TotalCurrentWeekly += double.Parse(SecondCurrent[i - 1], System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    Console.WriteLine("lel");
                }
                
            }
            double AvgCurrentMinutely = Math.Round(TotalCurrentMinutely / 60, 4);
            double AvgCurrentHourly = Math.Round(TotalCurrentHourly / 3600, 2);
            double AvgCurrentDaily = Math.Round(TotalCurrentDaily / 3600, 2);
            double AvgCurrentMonthly = Math.Round(TotalCurrentWeekly * 4 / 3600, 2);
            double AvgCurrentWeekly = Math.Round(TotalCurrentWeekly / 3600, 2);
            double AvgFirstCurrentDaily = Math.Round(TotalFirstCurrentDaily / 3600, 2);
            double AvgSecondCurrentDaily = Math.Round(TotalSecondCurrentDaily / 3600, 2);
            double AvgFirstCurrentWeekly = Math.Round(TotalFirstCurrentWeekly / 3600, 2);
            double AvgSecondCurrentWeekly = Math.Round(TotalSecondCurrentWeekly / 3600, 2);
            double AvgFirstCurrentMonthly = Math.Round(TotalFirstCurrentWeekly * 4 / 3600, 2);
            double AvgSecondCurrentMonthly= Math.Round(TotalSecondCurrentWeekly * 4 / 3600, 2);
            //Gecici
            double FakeAvgFirstCurrentDaily = Math.Round(TotalFirstCurrentHourly * 24 / 3600, 2);
            double FakeAvgSecondCurrentDaily = Math.Round(TotalSecondCurrentHourly * 24 / 3600, 2);
            //Gecici

            MinutelyLbl.Text = Convert.ToString(AvgCurrentMinutely) + " Amp";
            Hourlylbl.Text = Convert.ToString(AvgCurrentHourly) + " Amp";
            Dailylbl.Text = Convert.ToString(AvgCurrentDaily) + " Amp";


            double AvgPowerHourly = Math.Round(AvgCurrentHourly * 230 / 1000, 2);
            double AvgPowerDaily = Math.Round(AvgCurrentDaily * 230 / 1000, 2);
            AvgPowerMonthly = Math.Round(AvgCurrentMonthly * 230 / 1000, 2);
            double AvgPowerWeekly = Math.Round(AvgCurrentWeekly * 230 / 1000, 2);
            AvgFirstPowerDaily = Math.Round(AvgFirstCurrentDaily * 230 / 1000, 2);
            AvgSecondPowerDaily = Math.Round(AvgSecondCurrentDaily * 230 / 1000, 2);
            // GECİCİ OLARak fake kullanıyorum
            FakeAvgFirstPowerDaily = Math.Round(AvgFirstCurrentDaily * 230 / 1000, 2);
            FakeAvgSecondPowerDaily = Math.Round(AvgSecondCurrentDaily * 230 / 1000, 2);
            FakeAvgFirstPowerWeekly = Math.Round(AvgFirstCurrentWeekly * 230 / 1000, 2);
            FakeAvgSecondPowerWeekly = Math.Round(AvgSecondCurrentWeekly * 230 / 1000, 2);
            FakeAvgFirstPowerMonthly = Math.Round(AvgFirstCurrentMonthly * 230 / 1000, 2);
            FakeAvgSecondPowerMonthly = Math.Round(AvgSecondCurrentMonthly * 230 / 1000, 2);
            // GECİCİ GECİCİ
            PwrDailylbl.Text = Convert.ToString(AvgPowerDaily) + " kWatt";
            PwrHourlylbl.Text = Convert.ToString(AvgPowerHourly) + " kWatt";
            PwrMonthlylbl.Text = Convert.ToString(AvgPowerMonthly) + " kWatt";
            PwrWeeklylbl.Text = Convert.ToString(AvgPowerWeekly) + " kWatt";
        }


        public void TestError()
        {
            // read all text in file
            string text = File.ReadAllText(CurrentTextfilepath);
            // -------------------------------------------------------------------------------------THIS PART is to fix the Date and Current Values in text file-----------------------
            // -------------------------------------------------------------------------------------and Make them usable for the program.----------------------------------------------
            string[] TimeCurrentList = text.Split('n');
            string[] TimeCurrentArray = new string[TimeCurrentList.Length];
            int a = 0;
            foreach (string TimeCurrent in TimeCurrentList)
            {
                TimeCurrentArray[a] = TimeCurrent;
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace("b'Relay1 ON'", "");
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace("b'Relay2 ON'", "");
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace("b'Relay1 OFF'", "");
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace("b'Relay2 OFF'", "");
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace("'b'", "");
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace("\\", "");
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace("b'", "");
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace(" [", "[");
                TimeCurrentArray[a] = TimeCurrentArray[a].Replace("[", " [");

                a++;
            }
            string Values = string.Join(" ", TimeCurrentArray);
            string[] TCValues = Values.Split(' ');
            string[] RealTC = TCValues.Where(item => item != string.Empty).ToArray();
            string[] Currents = new string[RealTC.Length / 2];
            string[] Dates = new string[RealTC.Length / 2];
            for (int i = 0; i < RealTC.Length / 2; i++)
            {
                Dates[i] = RealTC[2 * i];
                Currents[i] = RealTC[2 * i + 1];
            }
            // --------------------------------------------------------------- Delete the error dates-----------------------------------
            int b = 0;
            int bb = 0;
            string[] ErroredLinesforDates = new string[1000];
            foreach (string Lines in Dates)
            {
                if (Dates[b].Length < 10)
                {
                    ErroredLinesforDates[bb] = Convert.ToString(b);
                    bb++;
                }
                b++;
            }
            string[] RealErroredLinesforDates = ErroredLinesforDates.Where(item => !string.IsNullOrEmpty(item)).ToArray();
            var DateList = new List<String>(Dates);
            for (int i = RealErroredLinesforDates.Length - 1; i >= 0; i--)
            {
                DateList.RemoveAt(Convert.ToInt32(RealErroredLinesforDates[i]));
            }
            RealDatess = DateList.ToArray();
            // ---------------------------------------------------------------- Delete the error currents by the string length----------------
            int c = 0;
            int cc = 0;
            string[] ErroredLinesforCurrents = new string[10000];
            foreach (string Lines in Currents)
            {
                if (Currents[c].Length < 9 || Currents[c].Length > 10)
                {
                    ErroredLinesforCurrents[cc] = Convert.ToString(c);
                    cc++;
                }
                c++;
            }
            string[] RealErroredLinesforCurrents = ErroredLinesforCurrents.Where(item => !string.IsNullOrEmpty(item)).ToArray();
            var CurList = new List<String>(Currents);
            for (int i = RealErroredLinesforCurrents.Length - 1; i >= 0; i--)
            {
                CurList.RemoveAt(Convert.ToInt32(RealErroredLinesforCurrents[i]));
            }
            RealCurrentss = CurList.ToArray();
            RealCurrentss = RealCurrentss.Where(item => !string.IsNullOrEmpty(item)).ToArray();
            // ---------------------------------------------------------------------------------------------------------------------
            FirstCurrent = new string[RealCurrentss.Length];
            SecondCurrent = new string[RealCurrentss.Length];
            for (int i = 0; i < RealCurrentss.Length; i++)
            {
                FirstCurrent[i] = RealCurrentss[i].Substring(0, 4);
                SecondCurrent[i] = RealCurrentss[i].Substring(5, 4);
            }
            // ---------------First Current Sensors and Second Current Sensor Values Obtained.-----------------------------------


            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }


        public void OpenPythonFile(string relayNo , string ONOFF)
        {
            if (string.Equals(relayNo, "Relay1"))
            {
                if (string.Equals(ONOFF, "_ON"))
                {
                    System.Diagnostics.Process.Start(Relay1ONfilepath);
                    Console.WriteLine("Relay1 ON");

                }
                else if (string.Equals(ONOFF, "_OFF"))
                {
                    System.Diagnostics.Process.Start(Relay1OFFfilepath);
                    Console.WriteLine("Relay1 OFF");
                }
            }
            else if (string.Equals(relayNo, "Relay2"))
            {
                if (string.Equals(ONOFF, "_ON"))
                {
                    System.Diagnostics.Process.Start(Relay2ONfilepath);
                    Console.WriteLine("Relay2 ON");

                }
                else if (string.Equals(ONOFF, "_OFF"))
                {
                    System.Diagnostics.Process.Start(Relay2OFFfilepath);
                    Console.WriteLine("Relay2 OFF");
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            HourMin.Text = DateTime.Now.ToString("HH:mm");
            Second.Text = DateTime.Now.ToString("ss");
            Date.Text = DateTime.Now.ToString("dd MMM yyyy");
            Day.Text = DateTime.Now.ToString("dddd");
        }

        private void Plug_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ONButton1_Click(object sender, EventArgs e)
        {
            Relay1lbl.ForeColor = ONButton1.ForeColor;
            OpenPythonFile(Relay1, _ON);
        }

        private void OFFButton1_Click(object sender, EventArgs e)
        {
            Relay1lbl.ForeColor = OFFButton1.ForeColor;
            OpenPythonFile(Relay1, _OFF);
        }

        private void PowerAnalysisButton_Click(object sender, EventArgs e)
        {
            CurrentPanel.Visible = false;
            CostAnalysisPnl.Visible = false;
            CostAnalysisPnl2.Visible = false;
            PlugPanel.Visible = false;
            PowerPanel.Visible = true;
            PowerPanel.Size = CurrentPanel.Size;
            PowerPanel.Location = PlugPanel.Location;
            PowerPanel.Dock = DockStyle.Bottom;
            PowerPanel2.Visible = true;
            PowerPanel2.Size = PlugPanel.Size;
            PowerPanel2.Location = PlugPanel.Location;
            PowerPanel2.Dock = DockStyle.Fill;
            timer1.Stop();

            
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            CostAnalysisPnl.Visible = false;
            CostAnalysisPnl2.Visible = false;
            PowerPanel2.Visible = false;
            PowerPanel.Visible = false;
            PlugPanel.Visible = true;
            CurrentPanel.Visible = true;
            
            
        }


        private void ONButton2_Click(object sender, EventArgs e)
        {
            Relay2lbl.ForeColor = ONButton2.ForeColor;
            OpenPythonFile(Relay2, _OFF);
        }

        private void DailyButton_Click(object sender, EventArgs e)
        {
            TestError();
            CalculateValues();
            GraphFunction(RealDatess, FirstCurrent,SecondCurrent, 3);
            timer1.Stop();
        }
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(MinuteBtn_Click);
            timer1.Interval = 10000; // in miliseconds

        }
        public void StartFunctions(object sender, EventArgs e)
        {
            TestError();
            CalculateValues();
        }

        private void MinuteBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            TestError();
            CalculateValues();
            GraphFunction(RealDatess, FirstCurrent, SecondCurrent, 1);

        }

        private void HourlyButton_Click(object sender, EventArgs e)
        {
            TestError();
            CalculateValues();
            GraphFunction(RealDatess, FirstCurrent, SecondCurrent, 2);
            timer1.Stop();
        }

        private void LivingRoomBtn_Click(object sender, EventArgs e)
        {
            KisPressed = false;
            LVisPressed = true;
            LivingRoomBtn.Enabled = false;
            KitchenBtn.Enabled = true;
            
        }

        private void HBtnPower_Click(object sender, EventArgs e)
        {
            TestError();
            CalculateValues();
            GraphFunction2(RealDatess, FirstCurrent, SecondCurrent, 2);
        }

        private void DBtnPower_Click(object sender, EventArgs e)
        {
            TestError();
            CalculateValues();
            GraphFunction2(RealDatess, FirstCurrent, SecondCurrent, 3);
        }

        private void WBtnPower_Click(object sender, EventArgs e)
        {
            TestError();
            CalculateValues();
            GraphFunction2(RealDatess, FirstCurrent, SecondCurrent, 5);
        }

        private void MBtnPower_Click(object sender, EventArgs e)
        {
            TestError();
            CalculateValues();
            GraphFunction2(RealDatess, FirstCurrent, SecondCurrent, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PwrLmtLbl.Text = Convert.ToString(Math.Round(Convert.ToDouble(limitBox.Text)/0.4612,2));
            limitBox.ReadOnly = true;
            limitBox.BackColor = panel1.BackColor;
            limitBox.ForeColor = OFFButton2.ForeColor;
            PwrLmtLbl.Visible = true;
            kWmonthlbl.Visible = true;
            double LimitCalc = Math.Round(AvgPowerMonthly / Convert.ToDouble(PwrLmtLbl.Text), 2) * 100;
            Limitlbl.Text = "You reached your limit by " + LimitCalc + "%.";
            Limitlbl.Visible = true;
            if (LimitCalc < 25)
            {
                Warningmsg.Text = "You should be good for the rest";
                Warningmsg2.Text = "of the month.";
            }
            if (LimitCalc >= 25 & LimitCalc < 50) 
            {
                Warningmsg.Text = "You used almost half of your limit.";
                Warningmsg2.Text = "";
            }
            if (LimitCalc >= 50 & LimitCalc < 75) 
            {
                Warningmsg.Text = "You should consider using less power.";
                Warningmsg2.Text = "";
            }
            if (LimitCalc >= 75 & LimitCalc < 100) 
            {
                Warningmsg.Text = "Be careful! You almost reached ";
                Warningmsg2.Text ="your limit.";
            }
            if (LimitCalc >= 100) 
            {
                Warningmsg.Text = "Your limit is reached.";
                Warningmsg2.Text = "Your bill is going to be more than " + limitBox.Text +" TL";

            }
            Warningmsg.Visible = true;
            Warningmsg2.Visible = true;



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limitBox.ReadOnly = false;
            limitBox.BackColor = Color.White;
        }

        private void CostAnalysisButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            PowerPanel.Visible = false;
            PlugPanel.Visible = false;
            CurrentPanel.Visible = false;
            PowerPanel2.Visible = false;
            CostAnalysisPnl2.Visible = true;
            CostAnalysisPnl.Visible = true;
            CostAnalysisPnl2.Size = CurrentPanel.Size;
            CostAnalysisPnl2.Location = CurrentPanel.Location;
            CostAnalysisPnl2.Dock = DockStyle.Bottom;
            CostAnalysisPnl.Size = PlugPanel.Size;
            CostAnalysisPnl.Location = PlugPanel.Location;
            CostAnalysisPnl.Dock = DockStyle.Fill;
            DailyBedroom.Text = "----------";
            WeeklyBedroom.Text = "----------";
            MonthlyBedroom.Text = "----------";
            DailyBathroom.Text = "----------";
            WeeklyBathroom.Text = "----------";
            MonthlyBathroom.Text = "----------";
            DailyKitchen.Text = Convert.ToString(Math.Round(FakeAvgFirstPowerDaily * 0.4612, 2)) + " TL";
            DailyLR.Text = Convert.ToString(Math.Round(FakeAvgSecondPowerDaily * 0.4612, 2)) + " TL";
            WeeklyKitchen.Text = Convert.ToString(Math.Round(FakeAvgFirstPowerWeekly * 0.4612 , 2)) + " TL";
            WeeklyLR.Text = Convert.ToString(Math.Round(FakeAvgSecondPowerWeekly * 0.4612 , 2)) + " TL";
            MonthlyKitchen.Text = Convert.ToString(Math.Round(FakeAvgFirstPowerMonthly * 0.4612 , 2)) + " TL";
            MonthlyLR.Text = Convert.ToString(Math.Round(FakeAvgSecondPowerMonthly * 0.4612, 2)) + " TL";
            double Albl = 50;
            double Llbl = 40;
            AvgBilllbl.Text = Convert.ToString(Albl);
            LastBilllbl.Text = Convert.ToString(Llbl);
            double Tlbl = Math.Round((FakeAvgFirstPowerMonthly + FakeAvgSecondPowerMonthly) * 0.4612, 1);
            ThisBilllbl.Text = Convert.ToString(Tlbl);
            if(Tlbl >= Albl)
            {
                ThisDiffLbl.Text = Convert.ToString(Math.Round(((Albl -Tlbl)*100)/Albl,2)) + "%";
            } else
            {
                ThisDiffLbl.Text = "-" + Convert.ToString(Math.Round(((Albl - Tlbl) * 100) / Albl, 2)) + "%";
            }
            if(Llbl >= Albl)
            {
                LastDifflbl.Text = Convert.ToString(Math.Round(((Albl - Llbl) * 100) / Albl, 2)) + "%";
            } else
            {
                LastDifflbl.Text = "-" + Convert.ToString(Math.Round(((Albl - Llbl) * 100) / Albl, 2)) + "%";
            }


        }

        private void KitchenBtn_Click(object sender, EventArgs e)
        {
            LVisPressed = false;
            KisPressed = true;
            KitchenBtn.Enabled = false;
            LivingRoomBtn.Enabled = true;
        }

        private void OFFButton2_Click(object sender, EventArgs e)
        {
            Relay2lbl.ForeColor = OFFButton2.ForeColor;
            OpenPythonFile(Relay2, _ON);
        }

        private void AllOff_Click(object sender, EventArgs e)
        {
            OpenPythonFile(Relays, _OFF);
        }
        public void GraphFunction2(string[] Dates,string[] Values1,string[] Values2,int A)
        {
            foreach (var series in PowerChart.Series)
            {
                series.Points.Clear();
            }
            PowerChart.ChartAreas.FirstOrDefault().AxisX.Interval = 10;
            PowerChart.ChartAreas.FirstOrDefault().AxisX.Title = "Time";
            PowerChart.ChartAreas.FirstOrDefault().AxisY.Title = "Power[W]";
            string abcd = "{00:00:00}";
            PowerChart.ChartAreas.FirstOrDefault().AxisX.LabelStyle.Format = abcd;
            PowerChart.ChartAreas.FirstOrDefault().AxisY.LabelStyle.Format = "{0.00}";
            string[] FirstCurrentValuePwr = Values1;
            string[] SecondCurrentValuePwr = Values2;
            int TimeInterval = 0;
            string[] UsableDates;
            UsableDates = new string[TimeInterval];
            double[] AvgHourValues1 = new double[60];
            double[] AvgHourValues2 = new double[60];
            if (A == 2)
            {
                TimeInterval = 60;
                UsableDates = new string[TimeInterval];
                for (int i = 0; i < AvgHourValues1.Length; i++)
                {
                    for (int j = FirstCurrentValuePwr.Length; j >= FirstCurrentValuePwr.Length - 59; j--)
                    {
                        AvgHourValues1[i] += Convert.ToDouble(FirstCurrentValuePwr[(j - 1) - (60 * i)])*230;
                        AvgHourValues2[i] += Convert.ToDouble(SecondCurrentValuePwr[(j - 1) - (60 * i)])*230;
                    }
                    AvgHourValues1[i] = Math.Round(AvgHourValues1[i] / 60, 4);
                    AvgHourValues2[i] = Math.Round(AvgHourValues2[i] / 60, 4);
                    //Console.WriteLine(AvgHourValues[i]);

                }
                int a = TimeInterval;
                for (int i = Dates.Length; i >= Dates.Length - TimeInterval + 1; i--)
                {
                    UsableDates[a - 1] = Dates[(i - 1) - (60-1) * (60 - a)];
                    a--;
                }
                Array.Reverse(AvgHourValues1);
                Array.Reverse(AvgHourValues2);
            }
            double[] AvgDayValues1 = new double[60];
            double[] AvgDayValues2 = new double[60];
            if (A == 3)
            {
                TimeInterval = 60;
                UsableDates = new string[TimeInterval];
                for (int i = 0; i < AvgDayValues1.Length; i++)
                {
                    for (int j = FirstCurrentValuePwr.Length; j >= FirstCurrentValuePwr.Length - (60 * 24) - 1; j--)
                    {
                        AvgDayValues1[i] += Convert.ToDouble(FirstCurrentValuePwr[(j - 1) - (60 * 24 * i)])*230;
                        AvgDayValues2[i] += Convert.ToDouble(SecondCurrentValuePwr[(j - 1) - (60 * 24 * i)])*230;
                    }
                    AvgDayValues1[i] = Math.Round(AvgDayValues1[i] / (24* 60), 4);
                    AvgDayValues2[i] = Math.Round(AvgDayValues2[i] / (24* 60), 4);

                }
                int a = TimeInterval;
                for (int i = Dates.Length; i >= Dates.Length - TimeInterval + 1; i--)
                {
                    UsableDates[a - 1] = Dates[(i - 1) - (1440-1) * (60 - a)];
                    a--;
                }
                Array.Reverse(AvgDayValues1);
                Array.Reverse(AvgDayValues2);
            }
            double[] AvgMonthValues1 = new double[60];
            double[] AvgMonthValues2 = new double[60];
            if (A == 4) 
            {
                TimeInterval = 60;
                UsableDates = new string[TimeInterval];
                bool NoData = false;
                for (int i = 0; i < AvgMonthValues1.Length; i++)
                {
                    for (int j = FirstCurrentValuePwr.Length; j >= FirstCurrentValuePwr.Length - 59; j--)
                    {
                        try
                        {
                            AvgMonthValues1[i] += Convert.ToDouble(FirstCurrentValuePwr[(j - 1) - (60 * 24 * 30 * i)]) * 230;
                            AvgMonthValues2[i] += Convert.ToDouble(SecondCurrentValuePwr[(j - 1) - (60 * 24 * 30 * i)]) * 230;

                        }
                        catch
                        {
                            NoData = true;
                            break;
                        }

                    }
                    AvgMonthValues1[i] = Math.Round(AvgMonthValues1[i] / (60) , 4);
                    AvgMonthValues2[i] = Math.Round(AvgMonthValues2[i] / (60), 4);

                }
                int a = TimeInterval;
                if (NoData == false)
                {
                    for (int i = Dates.Length; i >= Dates.Length - TimeInterval + 1; i--)
                    {
                        UsableDates[a - 1] = Dates[(i - 1) - (43200 - 1) * (60 - a)];
                        a--;
                    }
                }
               
                Array.Reverse(AvgMonthValues1);
                Array.Reverse(AvgMonthValues2);
            }
            double[] AvgWeekValues1 = new double[60];
            double[] AvgWeekValues2 = new double[60];
            if (A == 5)
            {
                TimeInterval = 60;
                UsableDates = new string[TimeInterval];
                for (int i = 0; i < AvgWeekValues1.Length; i++)
                {
                    for (int j = FirstCurrentValuePwr.Length; j >= FirstCurrentValuePwr.Length - 59; j--)
                    {
                        AvgWeekValues1[i] += Convert.ToDouble(FirstCurrentValuePwr[(j - 1) - (60 * 24 * 7 * i)])*230;
                        AvgWeekValues2[i] += Convert.ToDouble(SecondCurrentValuePwr[(j - 1) - (60 * 24 * 7 * i)])*230;
                    }
                    AvgWeekValues1[i] = Math.Round(AvgWeekValues1[i] / (60), 4);
                    AvgWeekValues2[i] = Math.Round(AvgWeekValues2[i] / (60) , 4);

                }
                int a = TimeInterval;
                for (int i = Dates.Length; i >= Dates.Length - TimeInterval + 1; i--)
                {
                    UsableDates[a - 1] = Dates[(i - 1) - (10080 - 1) * (60 - a)];
                    a--;
                }
                Array.Reverse(AvgWeekValues1);
                Array.Reverse(AvgWeekValues2);
            }


            int b = 0;
            for (int i = 0; i < 60; i++)
            {
                if (A == 2)
                {
                    if(KisPressed == true) PowerChart.Series["Series1"].Points.AddXY(UsableDates[b], AvgHourValues1[b] / 100);
                    if (LVisPressed == true) PowerChart.Series["Series2"].Points.AddXY(UsableDates[b], AvgHourValues2[b] / 100);
                }
                if (A == 3)
                {
                    if (KisPressed == true) PowerChart.Series["Series1"].Points.AddXY(UsableDates[b], AvgDayValues1[b] / 100);
                    if (LVisPressed == true) PowerChart.Series["Series2"].Points.AddXY(UsableDates[b], AvgDayValues2[b] / 100);

                }
                if(A == 4)
                {
                    try
                    {
                        if (KisPressed == true) PowerChart.Series["Series1"].Points.AddXY(UsableDates[b], AvgMonthValues1[b] / 100);
                        if (LVisPressed == true) PowerChart.Series["Series2"].Points.AddXY(UsableDates[b], AvgMonthValues2[b] / 100);
                    } catch
                    {
                        MessageBox.Show("Not Enough Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    
                }
                if(A == 5)
                {
                    if (KisPressed == true) PowerChart.Series["Series1"].Points.AddXY(UsableDates[b], AvgWeekValues1[b] / 100);
                    if (LVisPressed == true) PowerChart.Series["Series2"].Points.AddXY(UsableDates[b], AvgWeekValues2[b] / 100);
                }
                b++;
            }
        }

        public void GraphFunction(string[] Dates,string[] Values1,string[] Values2,int A)
        {
            foreach (var series in CurrentChart.Series)
            {
                series.Points.Clear();
            }
            CurrentChart.ChartAreas.FirstOrDefault().AxisX.Interval = 10;
            CurrentChart.ChartAreas.FirstOrDefault().AxisX.Title = "Time";
            CurrentChart.ChartAreas.FirstOrDefault().AxisY.Title = "Current[Amper]";
            string abcd = "{00:00:00}";
            CurrentChart.ChartAreas.FirstOrDefault().AxisX.LabelStyle.Format = abcd;
            CurrentChart.ChartAreas.FirstOrDefault().AxisY.LabelStyle.Format = "{0.00}";
            string[] FirstCurrentValue = Values1;
            string[] SecondCurrentvalue = Values2;
            int TimeInterval = 0 ;
            string[] UsableDates;
            UsableDates = new string[TimeInterval];
            if (A == 1) 
            {
                TimeInterval = 60;
                UsableDates = new string[TimeInterval];
                int a = TimeInterval;
                for (int i = Dates.Length; i >= Dates.Length - TimeInterval + 1; i--)
                {
                    UsableDates[a - 1] = Dates[i - 1];
                    a--;
                }
                //for (int i = 0; i< Values1.Length; i++) Console.WriteLine(Values1[i]);
                Array.Reverse(FirstCurrentValue);
                Array.Reverse(SecondCurrentvalue);
                //for (int i = 0; i < Values1.Length; i++) Console.WriteLine(Values1[i]);
            }
            double[] AvgHourValues1 = new double[60];
            double[] AvgHourValues2 = new double[60];
            if (A == 2)
            {
                TimeInterval = 60;
                UsableDates = new string[TimeInterval];
                for(int i = 0; i < AvgHourValues1.Length; i++)
                {
                    for(int j= FirstCurrentValue.Length; j >= FirstCurrentValue.Length-59; j--)
                    {
                        AvgHourValues1[i] += Convert.ToDouble(FirstCurrentValue[(j-1) - (60 * i)]);
                        AvgHourValues2[i] += Convert.ToDouble(SecondCurrentvalue[(j - 1) - (60 * i)]);
                    }
                    AvgHourValues1[i] = Math.Round(AvgHourValues1[i] / 60,4);
                    AvgHourValues2[i] = Math.Round(AvgHourValues2[i] / 60, 4);

                }
                int a = TimeInterval;
                for (int i = Dates.Length; i >= Dates.Length - TimeInterval + 1; i--)
                {
                    UsableDates[a - 1] = Dates[(i-1)-(60-1)*(60-a)];
                    a--;
                }
                Array.Reverse(AvgHourValues1);
                Array.Reverse(AvgHourValues2);
            }
            double[] AvgDayValues1 = new double[60];
            double[] AvgDayValues2 = new double[60];
            if (A == 3)
            {
                TimeInterval = 60;
                UsableDates = new string[TimeInterval];
                for (int i = 0; i < AvgDayValues1.Length; i++)
                {
                    for (int j = FirstCurrentValue.Length; j >= FirstCurrentValue.Length - (60*24)-1; j--)
                    {
                        AvgDayValues1[i] += Convert.ToDouble(FirstCurrentValue[(j - 1) - (60*24 * i)]);
                        AvgDayValues2[i] += Convert.ToDouble(SecondCurrentvalue[(j - 1) - (60 * 24 * i)]);
                    }
                    AvgDayValues1[i] = Math.Round(AvgDayValues1[i]/(24*60) , 4);
                    AvgDayValues2[i] = Math.Round(AvgDayValues2[i]/(24*60), 4);

                }
                int a = 60;
                for (int i = Dates.Length; i >= Dates.Length - TimeInterval + 1; i--)
                {
                    UsableDates[a - 1] = Dates[(i - 1) - (1440-1)*(60-a)];
                    a--;
                }
                Array.Reverse(AvgDayValues1);
                Array.Reverse(AvgDayValues2);
            }
            double[] AvgMonthValues1 = new double[60];
            double[] AvgMonthValues2 = new double[60];
            if (A == 4) 
            {
                TimeInterval = 60;
                UsableDates = new string[TimeInterval];
                for (int i = 0; i < AvgMonthValues1.Length; i++)
                {
                    for (int j = FirstCurrentValue.Length; j >= FirstCurrentValue.Length - 59; j--)
                    {
                        AvgMonthValues1[i] += Convert.ToDouble(FirstCurrentValue[(j - 1) - (60 *24*30 *i)]);
                        AvgMonthValues2[i] += Convert.ToDouble(SecondCurrentvalue[(j - 1) - (60 *24*30* i)]);
                    }
                    AvgMonthValues1[i] = Math.Round(AvgMonthValues1[i] / (60*24*30), 4);
                    AvgMonthValues2[i] = Math.Round(AvgMonthValues2[i] / (60*24*30), 4);

                }
                int a = TimeInterval;
                for (int i = Dates.Length; i >= Dates.Length - TimeInterval + 1; i--)
                {
                    UsableDates[a - 1] = Dates[(i - 1) - (43200-1)* (60- a)];
                    a--;
                }
                Array.Reverse(AvgMonthValues1);
                Array.Reverse(AvgMonthValues2);
            }

            // Arraylerin reverse ler alınır.



            // -----------------------------

            int b = 0;
            //for (int i = Values1.Length; i >= Values1.Length - TimeInterval+1; i--)
            for (int i = 0; i < 60; i++)
            {
                if(A == 1)
                {
                    CurrentChart.Series["Series1"].Points.AddXY(UsableDates[b], Convert.ToDouble(FirstCurrentValue[59-i]) / 100);
                    CurrentChart.Series["Series2"].Points.AddXY(UsableDates[b], Convert.ToDouble(SecondCurrentvalue[59-i]) / 100);
                }
                   
                if(A == 2) 
                {
                    CurrentChart.Series["Series1"].Points.AddXY(UsableDates[b], AvgHourValues1[b] / 100);
                    CurrentChart.Series["Series2"].Points.AddXY(UsableDates[b], AvgHourValues2[b] / 100);
                }
                if(A == 3)
                {
                    CurrentChart.Series["Series1"].Points.AddXY(UsableDates[b], AvgDayValues1[b] / 100);
                    CurrentChart.Series["Series2"].Points.AddXY(UsableDates[b], AvgDayValues2[b] / 100);
                }
                if(A == 4)
                {
                    CurrentChart.Series["Series1"].Points.AddXY(UsableDates[b], AvgMonthValues1[b] / 100);
                    CurrentChart.Series["Series2"].Points.AddXY(UsableDates[b], AvgMonthValues2[b] / 100);
                }
                b++;
            }

               
        }

    }
}

