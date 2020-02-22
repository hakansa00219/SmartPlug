namespace SmartPlugApp
{
    partial class Plug
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plug));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.CostAnalysisButton = new System.Windows.Forms.Button();
            this.PowerAnalysisButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Day = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.HourMin = new System.Windows.Forms.Label();
            this.CurrentPanel = new System.Windows.Forms.Panel();
            this.MinutelyLbl = new System.Windows.Forms.Label();
            this.MinuteBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.HourlyButton = new System.Windows.Forms.Button();
            this.DailyButton = new System.Windows.Forms.Button();
            this.Hourlylbl = new System.Windows.Forms.Label();
            this.Dailylbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CostAnalysisPnl2 = new System.Windows.Forms.Panel();
            this.LastDifflbl = new System.Windows.Forms.Label();
            this.ThisDiffLbl = new System.Windows.Forms.Label();
            this.AvgDifflbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.AvgBilllbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LastBilllbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ThisBilllbl = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.PlugPanel = new System.Windows.Forms.Panel();
            this.Relay2lbl = new System.Windows.Forms.Label();
            this.Relay4lbl = new System.Windows.Forms.Label();
            this.Relay3lbl = new System.Windows.Forms.Label();
            this.OFFButton4 = new System.Windows.Forms.Button();
            this.OFFButton3 = new System.Windows.Forms.Button();
            this.OFFButton2 = new System.Windows.Forms.Button();
            this.ONButton4 = new System.Windows.Forms.Button();
            this.ONButton3 = new System.Windows.Forms.Button();
            this.ONButton2 = new System.Windows.Forms.Button();
            this.OFFButton1 = new System.Windows.Forms.Button();
            this.Relay1lbl = new System.Windows.Forms.Label();
            this.ONButton1 = new System.Windows.Forms.Button();
            this.CostAnalysisPnl = new System.Windows.Forms.Panel();
            this.MonthlyBathroom = new System.Windows.Forms.Label();
            this.MonthlyBedroom = new System.Windows.Forms.Label();
            this.MonthlyLR = new System.Windows.Forms.Label();
            this.MonthlyKitchen = new System.Windows.Forms.Label();
            this.WeeklyBathroom = new System.Windows.Forms.Label();
            this.WeeklyBedroom = new System.Windows.Forms.Label();
            this.WeeklyLR = new System.Windows.Forms.Label();
            this.WeeklyKitchen = new System.Windows.Forms.Label();
            this.DailyBathroom = new System.Windows.Forms.Label();
            this.DailyBedroom = new System.Windows.Forms.Label();
            this.DailyLR = new System.Windows.Forms.Label();
            this.DailyKitchen = new System.Windows.Forms.Label();
            this.BathroomBtnCost = new System.Windows.Forms.Button();
            this.BedroomBtnCost = new System.Windows.Forms.Button();
            this.LivingRoomBtnCost = new System.Windows.Forms.Button();
            this.KitchenBtnCost = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.PowerPanel = new System.Windows.Forms.Panel();
            this.Warningmsg2 = new System.Windows.Forms.Label();
            this.Warningmsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Limitlbl = new System.Windows.Forms.Label();
            this.kWmonthlbl = new System.Windows.Forms.Label();
            this.PwrLmtLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.limitBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PwrHourlylbl = new System.Windows.Forms.Label();
            this.PwrDailylbl = new System.Windows.Forms.Label();
            this.PwrWeeklylbl = new System.Windows.Forms.Label();
            this.PwrMonthlylbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PowerPanel2 = new System.Windows.Forms.Panel();
            this.PowerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HBtnPower = new System.Windows.Forms.Button();
            this.BathroomBtn = new System.Windows.Forms.Button();
            this.BedroomBtn = new System.Windows.Forms.Button();
            this.LivingRoomBtn = new System.Windows.Forms.Button();
            this.KitchenBtn = new System.Windows.Forms.Button();
            this.DBtnPower = new System.Windows.Forms.Button();
            this.WBtnPower = new System.Windows.Forms.Button();
            this.MBtnPower = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CurrentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChart)).BeginInit();
            this.CostAnalysisPnl2.SuspendLayout();
            this.PlugPanel.SuspendLayout();
            this.CostAnalysisPnl.SuspendLayout();
            this.PowerPanel.SuspendLayout();
            this.PowerPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.CostAnalysisButton);
            this.panel1.Controls.Add(this.PowerAnalysisButton);
            this.panel1.Controls.Add(this.DashboardButton);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 722);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.GreenYellow;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(162, 164);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 558);
            this.panel8.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.exitButton.Location = new System.Drawing.Point(3, 494);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 102);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CostAnalysisButton
            // 
            this.CostAnalysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CostAnalysisButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.CostAnalysisButton.Location = new System.Drawing.Point(3, 386);
            this.CostAnalysisButton.Name = "CostAnalysisButton";
            this.CostAnalysisButton.Size = new System.Drawing.Size(153, 102);
            this.CostAnalysisButton.TabIndex = 3;
            this.CostAnalysisButton.Text = "Cost Analysis";
            this.CostAnalysisButton.UseVisualStyleBackColor = true;
            this.CostAnalysisButton.Click += new System.EventHandler(this.CostAnalysisButton_Click);
            // 
            // PowerAnalysisButton
            // 
            this.PowerAnalysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerAnalysisButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.PowerAnalysisButton.Location = new System.Drawing.Point(3, 278);
            this.PowerAnalysisButton.Name = "PowerAnalysisButton";
            this.PowerAnalysisButton.Size = new System.Drawing.Size(153, 102);
            this.PowerAnalysisButton.TabIndex = 2;
            this.PowerAnalysisButton.Text = "Power Analysis";
            this.PowerAnalysisButton.UseVisualStyleBackColor = true;
            this.PowerAnalysisButton.Click += new System.EventHandler(this.PowerAnalysisButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.DashboardButton.Location = new System.Drawing.Point(3, 170);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(153, 102);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.GreenYellow;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 164);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Day);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.Second);
            this.panel2.Controls.Add(this.HourMin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 97);
            this.panel2.TabIndex = 1;
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Dock = System.Windows.Forms.DockStyle.Top;
            this.Day.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.ForeColor = System.Drawing.Color.GreenYellow;
            this.Day.Location = new System.Drawing.Point(0, 47);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(212, 47);
            this.Day.TabIndex = 3;
            this.Day.Text = "Saturday";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Dock = System.Windows.Forms.DockStyle.Top;
            this.Date.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.GreenYellow;
            this.Date.Location = new System.Drawing.Point(0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(195, 47);
            this.Date.TabIndex = 2;
            this.Date.Text = "11.05.2019";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Second.ForeColor = System.Drawing.Color.GreenYellow;
            this.Second.Location = new System.Drawing.Point(548, 26);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(89, 63);
            this.Second.TabIndex = 1;
            this.Second.Text = "22";
            // 
            // HourMin
            // 
            this.HourMin.AutoSize = true;
            this.HourMin.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourMin.ForeColor = System.Drawing.Color.GreenYellow;
            this.HourMin.Location = new System.Drawing.Point(321, 0);
            this.HourMin.Name = "HourMin";
            this.HourMin.Size = new System.Drawing.Size(249, 95);
            this.HourMin.TabIndex = 0;
            this.HourMin.Text = "22:22";
            // 
            // CurrentPanel
            // 
            this.CurrentPanel.Controls.Add(this.MinutelyLbl);
            this.CurrentPanel.Controls.Add(this.MinuteBtn);
            this.CurrentPanel.Controls.Add(this.panel7);
            this.CurrentPanel.Controls.Add(this.HourlyButton);
            this.CurrentPanel.Controls.Add(this.DailyButton);
            this.CurrentPanel.Controls.Add(this.Hourlylbl);
            this.CurrentPanel.Controls.Add(this.Dailylbl);
            this.CurrentPanel.Controls.Add(this.label3);
            this.CurrentPanel.Controls.Add(this.label1);
            this.CurrentPanel.Controls.Add(this.CurrentChart);
            this.CurrentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CurrentPanel.Location = new System.Drawing.Point(172, 474);
            this.CurrentPanel.Name = "CurrentPanel";
            this.CurrentPanel.Size = new System.Drawing.Size(713, 248);
            this.CurrentPanel.TabIndex = 2;
            // 
            // MinutelyLbl
            // 
            this.MinutelyLbl.AutoSize = true;
            this.MinutelyLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinutelyLbl.ForeColor = System.Drawing.Color.Coral;
            this.MinutelyLbl.Location = new System.Drawing.Point(534, 166);
            this.MinutelyLbl.Name = "MinutelyLbl";
            this.MinutelyLbl.Size = new System.Drawing.Size(55, 21);
            this.MinutelyLbl.TabIndex = 28;
            this.MinutelyLbl.Text = "Value";
            // 
            // MinuteBtn
            // 
            this.MinuteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinuteBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinuteBtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.MinuteBtn.Location = new System.Drawing.Point(413, 158);
            this.MinuteBtn.Name = "MinuteBtn";
            this.MinuteBtn.Size = new System.Drawing.Size(106, 35);
            this.MinuteBtn.TabIndex = 27;
            this.MinuteBtn.Text = "Live";
            this.MinuteBtn.UseVisualStyleBackColor = true;
            this.MinuteBtn.Click += new System.EventHandler(this.MinuteBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.GreenYellow;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(713, 10);
            this.panel7.TabIndex = 5;
            // 
            // HourlyButton
            // 
            this.HourlyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HourlyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HourlyButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HourlyButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.HourlyButton.Location = new System.Drawing.Point(413, 111);
            this.HourlyButton.Name = "HourlyButton";
            this.HourlyButton.Size = new System.Drawing.Size(106, 35);
            this.HourlyButton.TabIndex = 26;
            this.HourlyButton.Text = "Hourly";
            this.HourlyButton.UseVisualStyleBackColor = true;
            this.HourlyButton.Click += new System.EventHandler(this.HourlyButton_Click);
            // 
            // DailyButton
            // 
            this.DailyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DailyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DailyButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DailyButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.DailyButton.Location = new System.Drawing.Point(413, 64);
            this.DailyButton.Name = "DailyButton";
            this.DailyButton.Size = new System.Drawing.Size(106, 35);
            this.DailyButton.TabIndex = 25;
            this.DailyButton.Text = "Daily";
            this.DailyButton.UseVisualStyleBackColor = true;
            this.DailyButton.Click += new System.EventHandler(this.DailyButton_Click);
            // 
            // Hourlylbl
            // 
            this.Hourlylbl.AutoSize = true;
            this.Hourlylbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hourlylbl.ForeColor = System.Drawing.Color.Coral;
            this.Hourlylbl.Location = new System.Drawing.Point(534, 119);
            this.Hourlylbl.Name = "Hourlylbl";
            this.Hourlylbl.Size = new System.Drawing.Size(55, 21);
            this.Hourlylbl.TabIndex = 24;
            this.Hourlylbl.Text = "Value";
            // 
            // Dailylbl
            // 
            this.Dailylbl.AutoSize = true;
            this.Dailylbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dailylbl.ForeColor = System.Drawing.Color.Coral;
            this.Dailylbl.Location = new System.Drawing.Point(534, 72);
            this.Dailylbl.Name = "Dailylbl";
            this.Dailylbl.Size = new System.Drawing.Size(55, 21);
            this.Dailylbl.TabIndex = 22;
            this.Dailylbl.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(513, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(513, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usage";
            // 
            // CurrentChart
            // 
            this.CurrentChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.GreenYellow;
            chartArea1.AxisX.LineColor = System.Drawing.Color.YellowGreen;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.GreenYellow;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.GreenYellow;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.GreenYellow;
            chartArea1.AxisY.LineColor = System.Drawing.Color.YellowGreen;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.GreenYellow;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.GreenYellow;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea1.Name = "ChartArea1";
            this.CurrentChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.ForeColor = System.Drawing.Color.GreenYellow;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.CurrentChart.Legends.Add(legend1);
            this.CurrentChart.Location = new System.Drawing.Point(0, 6);
            this.CurrentChart.Name = "CurrentChart";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Coral;
            series1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.GreenYellow;
            series1.Legend = "Legend1";
            series1.LegendText = "Current(Kitchen)";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.DeepSkyBlue;
            series2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.GreenYellow;
            series2.Legend = "Legend1";
            series2.LegendText = "Current(LivRoom)";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.Name = "Series2";
            series2.YValuesPerPoint = 2;
            this.CurrentChart.Series.Add(series1);
            this.CurrentChart.Series.Add(series2);
            this.CurrentChart.Size = new System.Drawing.Size(507, 225);
            this.CurrentChart.TabIndex = 0;
            this.CurrentChart.Text = "chart1";
            // 
            // CostAnalysisPnl2
            // 
            this.CostAnalysisPnl2.Controls.Add(this.LastDifflbl);
            this.CostAnalysisPnl2.Controls.Add(this.ThisDiffLbl);
            this.CostAnalysisPnl2.Controls.Add(this.AvgDifflbl);
            this.CostAnalysisPnl2.Controls.Add(this.label20);
            this.CostAnalysisPnl2.Controls.Add(this.label17);
            this.CostAnalysisPnl2.Controls.Add(this.AvgBilllbl);
            this.CostAnalysisPnl2.Controls.Add(this.label19);
            this.CostAnalysisPnl2.Controls.Add(this.label14);
            this.CostAnalysisPnl2.Controls.Add(this.LastBilllbl);
            this.CostAnalysisPnl2.Controls.Add(this.label16);
            this.CostAnalysisPnl2.Controls.Add(this.label13);
            this.CostAnalysisPnl2.Controls.Add(this.ThisBilllbl);
            this.CostAnalysisPnl2.Controls.Add(this.panel9);
            this.CostAnalysisPnl2.Controls.Add(this.label29);
            this.CostAnalysisPnl2.Location = new System.Drawing.Point(185, 240);
            this.CostAnalysisPnl2.Name = "CostAnalysisPnl2";
            this.CostAnalysisPnl2.Size = new System.Drawing.Size(683, 234);
            this.CostAnalysisPnl2.TabIndex = 43;
            this.CostAnalysisPnl2.Visible = false;
            // 
            // LastDifflbl
            // 
            this.LastDifflbl.AutoSize = true;
            this.LastDifflbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastDifflbl.ForeColor = System.Drawing.Color.Coral;
            this.LastDifflbl.Location = new System.Drawing.Point(540, 146);
            this.LastDifflbl.Name = "LastDifflbl";
            this.LastDifflbl.Size = new System.Drawing.Size(49, 33);
            this.LastDifflbl.TabIndex = 29;
            this.LastDifflbl.Text = "%x";
            // 
            // ThisDiffLbl
            // 
            this.ThisDiffLbl.AutoSize = true;
            this.ThisDiffLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ThisDiffLbl.ForeColor = System.Drawing.Color.Coral;
            this.ThisDiffLbl.Location = new System.Drawing.Point(540, 108);
            this.ThisDiffLbl.Name = "ThisDiffLbl";
            this.ThisDiffLbl.Size = new System.Drawing.Size(49, 33);
            this.ThisDiffLbl.TabIndex = 28;
            this.ThisDiffLbl.Text = "%x";
            // 
            // AvgDifflbl
            // 
            this.AvgDifflbl.AutoSize = true;
            this.AvgDifflbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AvgDifflbl.ForeColor = System.Drawing.Color.Coral;
            this.AvgDifflbl.Location = new System.Drawing.Point(540, 73);
            this.AvgDifflbl.Name = "AvgDifflbl";
            this.AvgDifflbl.Size = new System.Drawing.Size(51, 33);
            this.AvgDifflbl.TabIndex = 27;
            this.AvgDifflbl.Text = "0%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.GreenYellow;
            this.label20.Location = new System.Drawing.Point(394, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(310, 33);
            this.label20.TabIndex = 26;
            this.label20.Text = "Difference to Average";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.GreenYellow;
            this.label17.Location = new System.Drawing.Point(405, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 33);
            this.label17.TabIndex = 25;
            this.label17.Text = "TL";
            // 
            // AvgBilllbl
            // 
            this.AvgBilllbl.AutoSize = true;
            this.AvgBilllbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AvgBilllbl.ForeColor = System.Drawing.Color.Coral;
            this.AvgBilllbl.Location = new System.Drawing.Point(347, 73);
            this.AvgBilllbl.Name = "AvgBilllbl";
            this.AvgBilllbl.Size = new System.Drawing.Size(60, 33);
            this.AvgBilllbl.TabIndex = 24;
            this.AvgBilllbl.Text = "666";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.GreenYellow;
            this.label19.Location = new System.Drawing.Point(22, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(292, 33);
            this.label19.TabIndex = 23;
            this.label19.Text = "Average Monthly Bill:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.GreenYellow;
            this.label14.Location = new System.Drawing.Point(405, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 33);
            this.label14.TabIndex = 22;
            this.label14.Text = "TL";
            // 
            // LastBilllbl
            // 
            this.LastBilllbl.AutoSize = true;
            this.LastBilllbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LastBilllbl.ForeColor = System.Drawing.Color.Coral;
            this.LastBilllbl.Location = new System.Drawing.Point(347, 146);
            this.LastBilllbl.Name = "LastBilllbl";
            this.LastBilllbl.Size = new System.Drawing.Size(60, 33);
            this.LastBilllbl.TabIndex = 21;
            this.LastBilllbl.Text = "666";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.GreenYellow;
            this.label16.Location = new System.Drawing.Point(22, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(215, 33);
            this.label16.TabIndex = 20;
            this.label16.Text = "Last Months Bill:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.GreenYellow;
            this.label13.Location = new System.Drawing.Point(405, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 33);
            this.label13.TabIndex = 19;
            this.label13.Text = "TL";
            // 
            // ThisBilllbl
            // 
            this.ThisBilllbl.AutoSize = true;
            this.ThisBilllbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ThisBilllbl.ForeColor = System.Drawing.Color.Coral;
            this.ThisBilllbl.Location = new System.Drawing.Point(347, 108);
            this.ThisBilllbl.Name = "ThisBilllbl";
            this.ThisBilllbl.Size = new System.Drawing.Size(60, 33);
            this.ThisBilllbl.TabIndex = 18;
            this.ThisBilllbl.Text = "666";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.GreenYellow;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(683, 10);
            this.panel9.TabIndex = 6;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.ForeColor = System.Drawing.Color.GreenYellow;
            this.label29.Location = new System.Drawing.Point(22, 108);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(208, 33);
            this.label29.TabIndex = 17;
            this.label29.Text = "This Months Bill:";
            // 
            // PlugPanel
            // 
            this.PlugPanel.Controls.Add(this.Relay2lbl);
            this.PlugPanel.Controls.Add(this.Relay4lbl);
            this.PlugPanel.Controls.Add(this.Relay3lbl);
            this.PlugPanel.Controls.Add(this.OFFButton4);
            this.PlugPanel.Controls.Add(this.OFFButton3);
            this.PlugPanel.Controls.Add(this.OFFButton2);
            this.PlugPanel.Controls.Add(this.ONButton4);
            this.PlugPanel.Controls.Add(this.ONButton3);
            this.PlugPanel.Controls.Add(this.ONButton2);
            this.PlugPanel.Controls.Add(this.OFFButton1);
            this.PlugPanel.Controls.Add(this.Relay1lbl);
            this.PlugPanel.Controls.Add(this.ONButton1);
            this.PlugPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlugPanel.Location = new System.Drawing.Point(172, 97);
            this.PlugPanel.Name = "PlugPanel";
            this.PlugPanel.Size = new System.Drawing.Size(713, 377);
            this.PlugPanel.TabIndex = 3;
            // 
            // Relay2lbl
            // 
            this.Relay2lbl.AutoSize = true;
            this.Relay2lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Relay2lbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.Relay2lbl.Location = new System.Drawing.Point(146, 13);
            this.Relay2lbl.Name = "Relay2lbl";
            this.Relay2lbl.Size = new System.Drawing.Size(175, 33);
            this.Relay2lbl.TabIndex = 17;
            this.Relay2lbl.Text = "Living Room";
            // 
            // Relay4lbl
            // 
            this.Relay4lbl.AutoSize = true;
            this.Relay4lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Relay4lbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.Relay4lbl.Location = new System.Drawing.Point(492, 13);
            this.Relay4lbl.Name = "Relay4lbl";
            this.Relay4lbl.Size = new System.Drawing.Size(145, 33);
            this.Relay4lbl.TabIndex = 16;
            this.Relay4lbl.Text = "Bathroom";
            // 
            // Relay3lbl
            // 
            this.Relay3lbl.AutoSize = true;
            this.Relay3lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Relay3lbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.Relay3lbl.Location = new System.Drawing.Point(331, 13);
            this.Relay3lbl.Name = "Relay3lbl";
            this.Relay3lbl.Size = new System.Drawing.Size(138, 33);
            this.Relay3lbl.TabIndex = 15;
            this.Relay3lbl.Text = "Bedroom";
            // 
            // OFFButton4
            // 
            this.OFFButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OFFButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OFFButton4.ForeColor = System.Drawing.Color.Coral;
            this.OFFButton4.Location = new System.Drawing.Point(499, 150);
            this.OFFButton4.Name = "OFFButton4";
            this.OFFButton4.Size = new System.Drawing.Size(126, 76);
            this.OFFButton4.TabIndex = 14;
            this.OFFButton4.Text = "OFF";
            this.OFFButton4.UseVisualStyleBackColor = true;
            // 
            // OFFButton3
            // 
            this.OFFButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OFFButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OFFButton3.ForeColor = System.Drawing.Color.Coral;
            this.OFFButton3.Location = new System.Drawing.Point(337, 150);
            this.OFFButton3.Name = "OFFButton3";
            this.OFFButton3.Size = new System.Drawing.Size(126, 76);
            this.OFFButton3.TabIndex = 13;
            this.OFFButton3.Text = "OFF";
            this.OFFButton3.UseVisualStyleBackColor = true;
            // 
            // OFFButton2
            // 
            this.OFFButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OFFButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OFFButton2.ForeColor = System.Drawing.Color.Coral;
            this.OFFButton2.Location = new System.Drawing.Point(170, 150);
            this.OFFButton2.Name = "OFFButton2";
            this.OFFButton2.Size = new System.Drawing.Size(126, 76);
            this.OFFButton2.TabIndex = 12;
            this.OFFButton2.Text = "OFF";
            this.OFFButton2.UseVisualStyleBackColor = true;
            this.OFFButton2.Click += new System.EventHandler(this.OFFButton2_Click);
            // 
            // ONButton4
            // 
            this.ONButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ONButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONButton4.ForeColor = System.Drawing.Color.Lime;
            this.ONButton4.Location = new System.Drawing.Point(499, 67);
            this.ONButton4.Name = "ONButton4";
            this.ONButton4.Size = new System.Drawing.Size(126, 71);
            this.ONButton4.TabIndex = 11;
            this.ONButton4.Text = "ON";
            this.ONButton4.UseVisualStyleBackColor = true;
            // 
            // ONButton3
            // 
            this.ONButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ONButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONButton3.ForeColor = System.Drawing.Color.Lime;
            this.ONButton3.Location = new System.Drawing.Point(337, 67);
            this.ONButton3.Name = "ONButton3";
            this.ONButton3.Size = new System.Drawing.Size(126, 71);
            this.ONButton3.TabIndex = 10;
            this.ONButton3.Text = "ON";
            this.ONButton3.UseVisualStyleBackColor = true;
            // 
            // ONButton2
            // 
            this.ONButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ONButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONButton2.ForeColor = System.Drawing.Color.Lime;
            this.ONButton2.Location = new System.Drawing.Point(170, 67);
            this.ONButton2.Name = "ONButton2";
            this.ONButton2.Size = new System.Drawing.Size(126, 71);
            this.ONButton2.TabIndex = 9;
            this.ONButton2.Text = "ON";
            this.ONButton2.UseVisualStyleBackColor = true;
            this.ONButton2.Click += new System.EventHandler(this.ONButton2_Click);
            // 
            // OFFButton1
            // 
            this.OFFButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OFFButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OFFButton1.ForeColor = System.Drawing.Color.Coral;
            this.OFFButton1.Location = new System.Drawing.Point(3, 150);
            this.OFFButton1.Name = "OFFButton1";
            this.OFFButton1.Size = new System.Drawing.Size(126, 76);
            this.OFFButton1.TabIndex = 7;
            this.OFFButton1.Text = "OFF";
            this.OFFButton1.UseVisualStyleBackColor = true;
            this.OFFButton1.Click += new System.EventHandler(this.OFFButton1_Click);
            // 
            // Relay1lbl
            // 
            this.Relay1lbl.AutoSize = true;
            this.Relay1lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Relay1lbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.Relay1lbl.Location = new System.Drawing.Point(9, 13);
            this.Relay1lbl.Name = "Relay1lbl";
            this.Relay1lbl.Size = new System.Drawing.Size(114, 33);
            this.Relay1lbl.TabIndex = 6;
            this.Relay1lbl.Text = "Kitchen";
            // 
            // ONButton1
            // 
            this.ONButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ONButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONButton1.ForeColor = System.Drawing.Color.Lime;
            this.ONButton1.Location = new System.Drawing.Point(3, 67);
            this.ONButton1.Name = "ONButton1";
            this.ONButton1.Size = new System.Drawing.Size(126, 71);
            this.ONButton1.TabIndex = 5;
            this.ONButton1.Text = "ON";
            this.ONButton1.UseVisualStyleBackColor = true;
            this.ONButton1.Click += new System.EventHandler(this.ONButton1_Click);
            // 
            // CostAnalysisPnl
            // 
            this.CostAnalysisPnl.Controls.Add(this.MonthlyBathroom);
            this.CostAnalysisPnl.Controls.Add(this.MonthlyBedroom);
            this.CostAnalysisPnl.Controls.Add(this.MonthlyLR);
            this.CostAnalysisPnl.Controls.Add(this.MonthlyKitchen);
            this.CostAnalysisPnl.Controls.Add(this.WeeklyBathroom);
            this.CostAnalysisPnl.Controls.Add(this.WeeklyBedroom);
            this.CostAnalysisPnl.Controls.Add(this.WeeklyLR);
            this.CostAnalysisPnl.Controls.Add(this.WeeklyKitchen);
            this.CostAnalysisPnl.Controls.Add(this.DailyBathroom);
            this.CostAnalysisPnl.Controls.Add(this.DailyBedroom);
            this.CostAnalysisPnl.Controls.Add(this.DailyLR);
            this.CostAnalysisPnl.Controls.Add(this.DailyKitchen);
            this.CostAnalysisPnl.Controls.Add(this.BathroomBtnCost);
            this.CostAnalysisPnl.Controls.Add(this.BedroomBtnCost);
            this.CostAnalysisPnl.Controls.Add(this.LivingRoomBtnCost);
            this.CostAnalysisPnl.Controls.Add(this.KitchenBtnCost);
            this.CostAnalysisPnl.Controls.Add(this.label30);
            this.CostAnalysisPnl.Controls.Add(this.label31);
            this.CostAnalysisPnl.Controls.Add(this.label32);
            this.CostAnalysisPnl.Location = new System.Drawing.Point(52, 16);
            this.CostAnalysisPnl.Name = "CostAnalysisPnl";
            this.CostAnalysisPnl.Size = new System.Drawing.Size(628, 234);
            this.CostAnalysisPnl.TabIndex = 44;
            this.CostAnalysisPnl.Visible = false;
            // 
            // MonthlyBathroom
            // 
            this.MonthlyBathroom.AutoSize = true;
            this.MonthlyBathroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MonthlyBathroom.ForeColor = System.Drawing.Color.Coral;
            this.MonthlyBathroom.Location = new System.Drawing.Point(526, 145);
            this.MonthlyBathroom.Name = "MonthlyBathroom";
            this.MonthlyBathroom.Size = new System.Drawing.Size(55, 21);
            this.MonthlyBathroom.TabIndex = 53;
            this.MonthlyBathroom.Text = "Value";
            // 
            // MonthlyBedroom
            // 
            this.MonthlyBedroom.AutoSize = true;
            this.MonthlyBedroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MonthlyBedroom.ForeColor = System.Drawing.Color.Coral;
            this.MonthlyBedroom.Location = new System.Drawing.Point(382, 145);
            this.MonthlyBedroom.Name = "MonthlyBedroom";
            this.MonthlyBedroom.Size = new System.Drawing.Size(55, 21);
            this.MonthlyBedroom.TabIndex = 52;
            this.MonthlyBedroom.Text = "Value";
            // 
            // MonthlyLR
            // 
            this.MonthlyLR.AutoSize = true;
            this.MonthlyLR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MonthlyLR.ForeColor = System.Drawing.Color.Coral;
            this.MonthlyLR.Location = new System.Drawing.Point(252, 145);
            this.MonthlyLR.Name = "MonthlyLR";
            this.MonthlyLR.Size = new System.Drawing.Size(55, 21);
            this.MonthlyLR.TabIndex = 51;
            this.MonthlyLR.Text = "Value";
            // 
            // MonthlyKitchen
            // 
            this.MonthlyKitchen.AutoSize = true;
            this.MonthlyKitchen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MonthlyKitchen.ForeColor = System.Drawing.Color.Coral;
            this.MonthlyKitchen.Location = new System.Drawing.Point(117, 145);
            this.MonthlyKitchen.Name = "MonthlyKitchen";
            this.MonthlyKitchen.Size = new System.Drawing.Size(55, 21);
            this.MonthlyKitchen.TabIndex = 50;
            this.MonthlyKitchen.Text = "Value";
            // 
            // WeeklyBathroom
            // 
            this.WeeklyBathroom.AutoSize = true;
            this.WeeklyBathroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WeeklyBathroom.ForeColor = System.Drawing.Color.Coral;
            this.WeeklyBathroom.Location = new System.Drawing.Point(526, 103);
            this.WeeklyBathroom.Name = "WeeklyBathroom";
            this.WeeklyBathroom.Size = new System.Drawing.Size(55, 21);
            this.WeeklyBathroom.TabIndex = 49;
            this.WeeklyBathroom.Text = "Value";
            // 
            // WeeklyBedroom
            // 
            this.WeeklyBedroom.AutoSize = true;
            this.WeeklyBedroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WeeklyBedroom.ForeColor = System.Drawing.Color.Coral;
            this.WeeklyBedroom.Location = new System.Drawing.Point(382, 103);
            this.WeeklyBedroom.Name = "WeeklyBedroom";
            this.WeeklyBedroom.Size = new System.Drawing.Size(55, 21);
            this.WeeklyBedroom.TabIndex = 48;
            this.WeeklyBedroom.Text = "Value";
            // 
            // WeeklyLR
            // 
            this.WeeklyLR.AutoSize = true;
            this.WeeklyLR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WeeklyLR.ForeColor = System.Drawing.Color.Coral;
            this.WeeklyLR.Location = new System.Drawing.Point(252, 103);
            this.WeeklyLR.Name = "WeeklyLR";
            this.WeeklyLR.Size = new System.Drawing.Size(55, 21);
            this.WeeklyLR.TabIndex = 47;
            this.WeeklyLR.Text = "Value";
            // 
            // WeeklyKitchen
            // 
            this.WeeklyKitchen.AutoSize = true;
            this.WeeklyKitchen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WeeklyKitchen.ForeColor = System.Drawing.Color.Coral;
            this.WeeklyKitchen.Location = new System.Drawing.Point(117, 103);
            this.WeeklyKitchen.Name = "WeeklyKitchen";
            this.WeeklyKitchen.Size = new System.Drawing.Size(55, 21);
            this.WeeklyKitchen.TabIndex = 46;
            this.WeeklyKitchen.Text = "Value";
            // 
            // DailyBathroom
            // 
            this.DailyBathroom.AutoSize = true;
            this.DailyBathroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DailyBathroom.ForeColor = System.Drawing.Color.Coral;
            this.DailyBathroom.Location = new System.Drawing.Point(526, 61);
            this.DailyBathroom.Name = "DailyBathroom";
            this.DailyBathroom.Size = new System.Drawing.Size(55, 21);
            this.DailyBathroom.TabIndex = 45;
            this.DailyBathroom.Text = "Value";
            // 
            // DailyBedroom
            // 
            this.DailyBedroom.AutoSize = true;
            this.DailyBedroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DailyBedroom.ForeColor = System.Drawing.Color.Coral;
            this.DailyBedroom.Location = new System.Drawing.Point(382, 61);
            this.DailyBedroom.Name = "DailyBedroom";
            this.DailyBedroom.Size = new System.Drawing.Size(55, 21);
            this.DailyBedroom.TabIndex = 44;
            this.DailyBedroom.Text = "Value";
            // 
            // DailyLR
            // 
            this.DailyLR.AutoSize = true;
            this.DailyLR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DailyLR.ForeColor = System.Drawing.Color.Coral;
            this.DailyLR.Location = new System.Drawing.Point(252, 61);
            this.DailyLR.Name = "DailyLR";
            this.DailyLR.Size = new System.Drawing.Size(55, 21);
            this.DailyLR.TabIndex = 43;
            this.DailyLR.Text = "Value";
            // 
            // DailyKitchen
            // 
            this.DailyKitchen.AutoSize = true;
            this.DailyKitchen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DailyKitchen.ForeColor = System.Drawing.Color.Coral;
            this.DailyKitchen.Location = new System.Drawing.Point(117, 61);
            this.DailyKitchen.Name = "DailyKitchen";
            this.DailyKitchen.Size = new System.Drawing.Size(55, 21);
            this.DailyKitchen.TabIndex = 29;
            this.DailyKitchen.Text = "Value";
            // 
            // BathroomBtnCost
            // 
            this.BathroomBtnCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BathroomBtnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BathroomBtnCost.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BathroomBtnCost.ForeColor = System.Drawing.Color.GreenYellow;
            this.BathroomBtnCost.Location = new System.Drawing.Point(484, 2);
            this.BathroomBtnCost.Name = "BathroomBtnCost";
            this.BathroomBtnCost.Size = new System.Drawing.Size(136, 37);
            this.BathroomBtnCost.TabIndex = 34;
            this.BathroomBtnCost.Text = "Bathroom";
            this.BathroomBtnCost.UseVisualStyleBackColor = true;
            // 
            // BedroomBtnCost
            // 
            this.BedroomBtnCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BedroomBtnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BedroomBtnCost.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BedroomBtnCost.ForeColor = System.Drawing.Color.GreenYellow;
            this.BedroomBtnCost.Location = new System.Drawing.Point(349, 2);
            this.BedroomBtnCost.Name = "BedroomBtnCost";
            this.BedroomBtnCost.Size = new System.Drawing.Size(136, 37);
            this.BedroomBtnCost.TabIndex = 33;
            this.BedroomBtnCost.Text = "Bedroom";
            this.BedroomBtnCost.UseVisualStyleBackColor = true;
            // 
            // LivingRoomBtnCost
            // 
            this.LivingRoomBtnCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LivingRoomBtnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LivingRoomBtnCost.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LivingRoomBtnCost.ForeColor = System.Drawing.Color.GreenYellow;
            this.LivingRoomBtnCost.Location = new System.Drawing.Point(214, 2);
            this.LivingRoomBtnCost.Name = "LivingRoomBtnCost";
            this.LivingRoomBtnCost.Size = new System.Drawing.Size(136, 37);
            this.LivingRoomBtnCost.TabIndex = 33;
            this.LivingRoomBtnCost.Text = "Living Room";
            this.LivingRoomBtnCost.UseVisualStyleBackColor = true;
            // 
            // KitchenBtnCost
            // 
            this.KitchenBtnCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KitchenBtnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitchenBtnCost.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitchenBtnCost.ForeColor = System.Drawing.Color.GreenYellow;
            this.KitchenBtnCost.Location = new System.Drawing.Point(79, 2);
            this.KitchenBtnCost.Name = "KitchenBtnCost";
            this.KitchenBtnCost.Size = new System.Drawing.Size(136, 37);
            this.KitchenBtnCost.TabIndex = 33;
            this.KitchenBtnCost.Text = "Kitchen";
            this.KitchenBtnCost.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.ForeColor = System.Drawing.Color.GreenYellow;
            this.label30.Location = new System.Drawing.Point(3, 145);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 24);
            this.label30.TabIndex = 42;
            this.label30.Text = "Monthly";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.ForeColor = System.Drawing.Color.GreenYellow;
            this.label31.Location = new System.Drawing.Point(4, 103);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 24);
            this.label31.TabIndex = 41;
            this.label31.Text = "Weekly";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.ForeColor = System.Drawing.Color.GreenYellow;
            this.label32.Location = new System.Drawing.Point(3, 61);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 24);
            this.label32.TabIndex = 39;
            this.label32.Text = "Daily";
            // 
            // PowerPanel
            // 
            this.PowerPanel.Controls.Add(this.Warningmsg2);
            this.PowerPanel.Controls.Add(this.Warningmsg);
            this.PowerPanel.Controls.Add(this.button1);
            this.PowerPanel.Controls.Add(this.Limitlbl);
            this.PowerPanel.Controls.Add(this.kWmonthlbl);
            this.PowerPanel.Controls.Add(this.PwrLmtLbl);
            this.PowerPanel.Controls.Add(this.label11);
            this.PowerPanel.Controls.Add(this.CalculateBtn);
            this.PowerPanel.Controls.Add(this.label10);
            this.PowerPanel.Controls.Add(this.label9);
            this.PowerPanel.Controls.Add(this.limitBox);
            this.PowerPanel.Controls.Add(this.label6);
            this.PowerPanel.Controls.Add(this.label5);
            this.PowerPanel.Controls.Add(this.label4);
            this.PowerPanel.Controls.Add(this.label2);
            this.PowerPanel.Controls.Add(this.panel3);
            this.PowerPanel.Controls.Add(this.PwrHourlylbl);
            this.PowerPanel.Controls.Add(this.PwrDailylbl);
            this.PowerPanel.Controls.Add(this.PwrWeeklylbl);
            this.PowerPanel.Controls.Add(this.PwrMonthlylbl);
            this.PowerPanel.Controls.Add(this.label7);
            this.PowerPanel.Controls.Add(this.label8);
            this.PowerPanel.Location = new System.Drawing.Point(16, 13);
            this.PowerPanel.Name = "PowerPanel";
            this.PowerPanel.Size = new System.Drawing.Size(628, 234);
            this.PowerPanel.TabIndex = 29;
            this.PowerPanel.Visible = false;
            // 
            // Warningmsg2
            // 
            this.Warningmsg2.AutoSize = true;
            this.Warningmsg2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Warningmsg2.ForeColor = System.Drawing.Color.GreenYellow;
            this.Warningmsg2.Location = new System.Drawing.Point(22, 196);
            this.Warningmsg2.Name = "Warningmsg2";
            this.Warningmsg2.Size = new System.Drawing.Size(71, 24);
            this.Warningmsg2.TabIndex = 42;
            this.Warningmsg2.Text = "Value";
            this.Warningmsg2.Visible = false;
            // 
            // Warningmsg
            // 
            this.Warningmsg.AutoSize = true;
            this.Warningmsg.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Warningmsg.ForeColor = System.Drawing.Color.GreenYellow;
            this.Warningmsg.Location = new System.Drawing.Point(22, 167);
            this.Warningmsg.Name = "Warningmsg";
            this.Warningmsg.Size = new System.Drawing.Size(71, 24);
            this.Warningmsg.TabIndex = 41;
            this.Warningmsg.Text = "Value";
            this.Warningmsg.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(80, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 40;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Limitlbl
            // 
            this.Limitlbl.AutoSize = true;
            this.Limitlbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Limitlbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.Limitlbl.Location = new System.Drawing.Point(22, 138);
            this.Limitlbl.Name = "Limitlbl";
            this.Limitlbl.Size = new System.Drawing.Size(71, 24);
            this.Limitlbl.TabIndex = 39;
            this.Limitlbl.Text = "Value";
            this.Limitlbl.Visible = false;
            // 
            // kWmonthlbl
            // 
            this.kWmonthlbl.AutoSize = true;
            this.kWmonthlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kWmonthlbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.kWmonthlbl.Location = new System.Drawing.Point(329, 108);
            this.kWmonthlbl.Name = "kWmonthlbl";
            this.kWmonthlbl.Size = new System.Drawing.Size(77, 17);
            this.kWmonthlbl.TabIndex = 38;
            this.kWmonthlbl.Text = "kW/month";
            this.kWmonthlbl.Visible = false;
            // 
            // PwrLmtLbl
            // 
            this.PwrLmtLbl.AutoSize = true;
            this.PwrLmtLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PwrLmtLbl.ForeColor = System.Drawing.Color.Coral;
            this.PwrLmtLbl.Location = new System.Drawing.Point(252, 101);
            this.PwrLmtLbl.Name = "PwrLmtLbl";
            this.PwrLmtLbl.Size = new System.Drawing.Size(71, 24);
            this.PwrLmtLbl.TabIndex = 37;
            this.PwrLmtLbl.Text = "Value";
            this.PwrLmtLbl.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.GreenYellow;
            this.label11.Location = new System.Drawing.Point(3, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Power Consumption Limit:";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.CalculateBtn.Location = new System.Drawing.Point(186, 56);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(100, 32);
            this.CalculateBtn.TabIndex = 5;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.GreenYellow;
            this.label10.Location = new System.Drawing.Point(218, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "TL/month";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(82, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 34;
            this.label9.Text = "Limit:";
            // 
            // limitBox
            // 
            this.limitBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.limitBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.limitBox.ForeColor = System.Drawing.Color.Coral;
            this.limitBox.Location = new System.Drawing.Point(147, 22);
            this.limitBox.Name = "limitBox";
            this.limitBox.Size = new System.Drawing.Size(65, 26);
            this.limitBox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.GreenYellow;
            this.label6.Location = new System.Drawing.Point(426, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hourly";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(426, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Daily";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(426, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Weekly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(426, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Monthly";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GreenYellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 10);
            this.panel3.TabIndex = 6;
            // 
            // PwrHourlylbl
            // 
            this.PwrHourlylbl.AutoSize = true;
            this.PwrHourlylbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PwrHourlylbl.ForeColor = System.Drawing.Color.Coral;
            this.PwrHourlylbl.Location = new System.Drawing.Point(525, 188);
            this.PwrHourlylbl.Name = "PwrHourlylbl";
            this.PwrHourlylbl.Size = new System.Drawing.Size(45, 17);
            this.PwrHourlylbl.TabIndex = 28;
            this.PwrHourlylbl.Text = "Value";
            // 
            // PwrDailylbl
            // 
            this.PwrDailylbl.AutoSize = true;
            this.PwrDailylbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PwrDailylbl.ForeColor = System.Drawing.Color.Coral;
            this.PwrDailylbl.Location = new System.Drawing.Point(525, 147);
            this.PwrDailylbl.Name = "PwrDailylbl";
            this.PwrDailylbl.Size = new System.Drawing.Size(45, 17);
            this.PwrDailylbl.TabIndex = 24;
            this.PwrDailylbl.Text = "Value";
            // 
            // PwrWeeklylbl
            // 
            this.PwrWeeklylbl.AutoSize = true;
            this.PwrWeeklylbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PwrWeeklylbl.ForeColor = System.Drawing.Color.Coral;
            this.PwrWeeklylbl.Location = new System.Drawing.Point(524, 106);
            this.PwrWeeklylbl.Name = "PwrWeeklylbl";
            this.PwrWeeklylbl.Size = new System.Drawing.Size(45, 17);
            this.PwrWeeklylbl.TabIndex = 22;
            this.PwrWeeklylbl.Text = "Value";
            // 
            // PwrMonthlylbl
            // 
            this.PwrMonthlylbl.AutoSize = true;
            this.PwrMonthlylbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PwrMonthlylbl.ForeColor = System.Drawing.Color.Coral;
            this.PwrMonthlylbl.Location = new System.Drawing.Point(525, 65);
            this.PwrMonthlylbl.Name = "PwrMonthlylbl";
            this.PwrMonthlylbl.Size = new System.Drawing.Size(45, 17);
            this.PwrMonthlylbl.TabIndex = 21;
            this.PwrMonthlylbl.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.GreenYellow;
            this.label7.Location = new System.Drawing.Point(513, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 33);
            this.label7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.GreenYellow;
            this.label8.Location = new System.Drawing.Point(513, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 33);
            this.label8.TabIndex = 17;
            this.label8.Text = "Usage";
            // 
            // PowerPanel2
            // 
            this.PowerPanel2.Controls.Add(this.PowerChart);
            this.PowerPanel2.Controls.Add(this.HBtnPower);
            this.PowerPanel2.Controls.Add(this.BathroomBtn);
            this.PowerPanel2.Controls.Add(this.BedroomBtn);
            this.PowerPanel2.Controls.Add(this.LivingRoomBtn);
            this.PowerPanel2.Controls.Add(this.KitchenBtn);
            this.PowerPanel2.Controls.Add(this.DBtnPower);
            this.PowerPanel2.Controls.Add(this.WBtnPower);
            this.PowerPanel2.Controls.Add(this.MBtnPower);
            this.PowerPanel2.Location = new System.Drawing.Point(26, 16);
            this.PowerPanel2.Name = "PowerPanel2";
            this.PowerPanel2.Size = new System.Drawing.Size(628, 269);
            this.PowerPanel2.TabIndex = 18;
            this.PowerPanel2.Visible = false;
            // 
            // PowerChart
            // 
            this.PowerChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PowerChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.GreenYellow;
            chartArea2.AxisX.LineColor = System.Drawing.Color.GreenYellow;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.GreenYellow;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.GreenYellow;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.GreenYellow;
            chartArea2.AxisY.LineColor = System.Drawing.Color.GreenYellow;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.GreenYellow;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.Title = "Power(W)";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.GreenYellow;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            chartArea2.Name = "ChartArea1";
            this.PowerChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend2.ForeColor = System.Drawing.Color.GreenYellow;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.PowerChart.Legends.Add(legend2);
            this.PowerChart.Location = new System.Drawing.Point(49, 38);
            this.PowerChart.Name = "PowerChart";
            series3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series3.BackSecondaryColor = System.Drawing.Color.Transparent;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Coral;
            series3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.LabelBorderColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.GreenYellow;
            series3.Legend = "Legend1";
            series3.LegendText = "Power Consumption";
            series3.MarkerBorderColor = System.Drawing.Color.White;
            series3.MarkerColor = System.Drawing.Color.White;
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            series4.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series4.BackSecondaryColor = System.Drawing.Color.Transparent;
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.DeepSkyBlue;
            series4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.LabelBorderColor = System.Drawing.Color.Transparent;
            series4.LabelForeColor = System.Drawing.Color.GreenYellow;
            series4.Legend = "Legend1";
            series4.LegendText = "Power Consumption";
            series4.MarkerBorderColor = System.Drawing.Color.White;
            series4.MarkerColor = System.Drawing.Color.White;
            series4.Name = "Series2";
            series4.YValuesPerPoint = 2;
            this.PowerChart.Series.Add(series3);
            this.PowerChart.Series.Add(series4);
            this.PowerChart.Size = new System.Drawing.Size(574, 231);
            this.PowerChart.TabIndex = 29;
            this.PowerChart.Text = "chart1";
            // 
            // HBtnPower
            // 
            this.HBtnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HBtnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HBtnPower.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HBtnPower.ForeColor = System.Drawing.Color.GreenYellow;
            this.HBtnPower.Location = new System.Drawing.Point(3, 167);
            this.HBtnPower.Name = "HBtnPower";
            this.HBtnPower.Size = new System.Drawing.Size(40, 35);
            this.HBtnPower.TabIndex = 32;
            this.HBtnPower.Text = "H";
            this.HBtnPower.UseVisualStyleBackColor = true;
            this.HBtnPower.Click += new System.EventHandler(this.HBtnPower_Click);
            // 
            // BathroomBtn
            // 
            this.BathroomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BathroomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BathroomBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BathroomBtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.BathroomBtn.Location = new System.Drawing.Point(476, 3);
            this.BathroomBtn.Name = "BathroomBtn";
            this.BathroomBtn.Size = new System.Drawing.Size(147, 35);
            this.BathroomBtn.TabIndex = 31;
            this.BathroomBtn.Text = "Bathroom";
            this.BathroomBtn.UseVisualStyleBackColor = true;
            // 
            // BedroomBtn
            // 
            this.BedroomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BedroomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BedroomBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BedroomBtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.BedroomBtn.Location = new System.Drawing.Point(323, 3);
            this.BedroomBtn.Name = "BedroomBtn";
            this.BedroomBtn.Size = new System.Drawing.Size(147, 35);
            this.BedroomBtn.TabIndex = 30;
            this.BedroomBtn.Text = "Bedroom";
            this.BedroomBtn.UseVisualStyleBackColor = true;
            // 
            // LivingRoomBtn
            // 
            this.LivingRoomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LivingRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LivingRoomBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LivingRoomBtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.LivingRoomBtn.Location = new System.Drawing.Point(156, 3);
            this.LivingRoomBtn.Name = "LivingRoomBtn";
            this.LivingRoomBtn.Size = new System.Drawing.Size(147, 35);
            this.LivingRoomBtn.TabIndex = 29;
            this.LivingRoomBtn.Text = "Living Room";
            this.LivingRoomBtn.UseVisualStyleBackColor = true;
            this.LivingRoomBtn.Click += new System.EventHandler(this.LivingRoomBtn_Click);
            // 
            // KitchenBtn
            // 
            this.KitchenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KitchenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitchenBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitchenBtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.KitchenBtn.Location = new System.Drawing.Point(3, 3);
            this.KitchenBtn.Name = "KitchenBtn";
            this.KitchenBtn.Size = new System.Drawing.Size(147, 35);
            this.KitchenBtn.TabIndex = 28;
            this.KitchenBtn.Text = "Kitchen";
            this.KitchenBtn.UseVisualStyleBackColor = true;
            this.KitchenBtn.Click += new System.EventHandler(this.KitchenBtn_Click);
            // 
            // DBtnPower
            // 
            this.DBtnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DBtnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DBtnPower.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DBtnPower.ForeColor = System.Drawing.Color.GreenYellow;
            this.DBtnPower.Location = new System.Drawing.Point(3, 126);
            this.DBtnPower.Name = "DBtnPower";
            this.DBtnPower.Size = new System.Drawing.Size(40, 35);
            this.DBtnPower.TabIndex = 27;
            this.DBtnPower.Text = "D";
            this.DBtnPower.UseVisualStyleBackColor = true;
            this.DBtnPower.Click += new System.EventHandler(this.DBtnPower_Click);
            // 
            // WBtnPower
            // 
            this.WBtnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WBtnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WBtnPower.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WBtnPower.ForeColor = System.Drawing.Color.GreenYellow;
            this.WBtnPower.Location = new System.Drawing.Point(3, 85);
            this.WBtnPower.Name = "WBtnPower";
            this.WBtnPower.Size = new System.Drawing.Size(40, 35);
            this.WBtnPower.TabIndex = 27;
            this.WBtnPower.Text = "W";
            this.WBtnPower.UseVisualStyleBackColor = true;
            this.WBtnPower.Click += new System.EventHandler(this.WBtnPower_Click);
            // 
            // MBtnPower
            // 
            this.MBtnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MBtnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtnPower.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MBtnPower.ForeColor = System.Drawing.Color.GreenYellow;
            this.MBtnPower.Location = new System.Drawing.Point(3, 44);
            this.MBtnPower.Name = "MBtnPower";
            this.MBtnPower.Size = new System.Drawing.Size(40, 35);
            this.MBtnPower.TabIndex = 27;
            this.MBtnPower.Text = "M";
            this.MBtnPower.UseVisualStyleBackColor = true;
            this.MBtnPower.Click += new System.EventHandler(this.MBtnPower_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.GreenYellow;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(172, 97);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(713, 10);
            this.panel6.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Plug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(902, 600);
            this.Controls.Add(this.PowerPanel);
            this.Controls.Add(this.CostAnalysisPnl2);
            this.Controls.Add(this.CostAnalysisPnl);
            this.Controls.Add(this.PowerPanel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.PlugPanel);
            this.Controls.Add(this.CurrentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(148)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Plug";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SmartPlugApp";
            this.Load += new System.EventHandler(this.Plug_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CurrentPanel.ResumeLayout(false);
            this.CurrentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentChart)).EndInit();
            this.CostAnalysisPnl2.ResumeLayout(false);
            this.CostAnalysisPnl2.PerformLayout();
            this.PlugPanel.ResumeLayout(false);
            this.PlugPanel.PerformLayout();
            this.CostAnalysisPnl.ResumeLayout(false);
            this.CostAnalysisPnl.PerformLayout();
            this.PowerPanel.ResumeLayout(false);
            this.PowerPanel.PerformLayout();
            this.PowerPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PowerChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CurrentPanel;
        private System.Windows.Forms.Panel PlugPanel;
        private System.Windows.Forms.Button CostAnalysisButton;
        private System.Windows.Forms.Button PowerAnalysisButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label HourMin;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Relay1lbl;
        private System.Windows.Forms.Button ONButton1;
        private System.Windows.Forms.Button OFFButton1;
        private System.Windows.Forms.Label Relay4lbl;
        private System.Windows.Forms.Label Relay3lbl;
        private System.Windows.Forms.Button OFFButton4;
        private System.Windows.Forms.Button OFFButton3;
        private System.Windows.Forms.Button OFFButton2;
        private System.Windows.Forms.Button ONButton4;
        private System.Windows.Forms.Button ONButton3;
        private System.Windows.Forms.Button ONButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart CurrentChart;
        private System.Windows.Forms.Label Dailylbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HourlyButton;
        private System.Windows.Forms.Button DailyButton;
        private System.Windows.Forms.Label Hourlylbl;
        private System.Windows.Forms.Label Relay2lbl;
        private System.Windows.Forms.Panel PowerPanel2;
        private System.Windows.Forms.Button HBtnPower;
        private System.Windows.Forms.Button BathroomBtn;
        private System.Windows.Forms.Button BedroomBtn;
        private System.Windows.Forms.Button LivingRoomBtn;
        private System.Windows.Forms.Button KitchenBtn;
        private System.Windows.Forms.Button DBtnPower;
        private System.Windows.Forms.Button WBtnPower;
        private System.Windows.Forms.Button MBtnPower;
        private System.Windows.Forms.Label MinutelyLbl;
        private System.Windows.Forms.Button MinuteBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart PowerChart;
        private System.Windows.Forms.Panel PowerPanel;
        private System.Windows.Forms.Label PwrHourlylbl;
        private System.Windows.Forms.Label PwrDailylbl;
        private System.Windows.Forms.Label PwrWeeklylbl;
        private System.Windows.Forms.Label PwrMonthlylbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox limitBox;
        private System.Windows.Forms.Label kWmonthlbl;
        private System.Windows.Forms.Label PwrLmtLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Limitlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Warningmsg;
        private System.Windows.Forms.Label Warningmsg2;
        private System.Windows.Forms.Panel CostAnalysisPnl2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel CostAnalysisPnl;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button BathroomBtnCost;
        private System.Windows.Forms.Button BedroomBtnCost;
        private System.Windows.Forms.Button LivingRoomBtnCost;
        private System.Windows.Forms.Button KitchenBtnCost;
        private System.Windows.Forms.Label MonthlyBathroom;
        private System.Windows.Forms.Label MonthlyBedroom;
        private System.Windows.Forms.Label MonthlyLR;
        private System.Windows.Forms.Label MonthlyKitchen;
        private System.Windows.Forms.Label WeeklyBathroom;
        private System.Windows.Forms.Label WeeklyBedroom;
        private System.Windows.Forms.Label WeeklyLR;
        private System.Windows.Forms.Label WeeklyKitchen;
        private System.Windows.Forms.Label DailyBathroom;
        private System.Windows.Forms.Label DailyBedroom;
        private System.Windows.Forms.Label DailyLR;
        private System.Windows.Forms.Label DailyKitchen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label AvgBilllbl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LastBilllbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ThisBilllbl;
        private System.Windows.Forms.Label LastDifflbl;
        private System.Windows.Forms.Label ThisDiffLbl;
        private System.Windows.Forms.Label AvgDifflbl;
        private System.Windows.Forms.Label label20;
    }
}

