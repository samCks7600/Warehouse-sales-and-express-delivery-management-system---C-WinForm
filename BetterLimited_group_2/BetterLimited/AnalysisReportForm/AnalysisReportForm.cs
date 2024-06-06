using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BetterLimited
{
    public partial class AnalysisReportForm : Form
    {
        // Setting for MySql Database.
        MySqlConnection conn = new MySqlConnection("server=localhost;user id =root;password=;database=betterlimited");
        MySqlDataAdapter adpt;
        DataSet ds = new DataSet();
        string sql = "SELECT month(Date) AS MONTH, count(SalesOrderID) AS COUNT FROM salesorder GROUP BY MONTH";
        //sql = "SELECT month(Date) AS MONTH, sum(PaidAmt) AS COUNT FROM salesorder GROUP BY MONTH";
        string staffID, department, position;
        public decimal salesOrderAmount, sales;
        public object this[string propertyName] {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
        
        public string setStaffID
        {
            set
            {
                staffID = value;
            }
        }
        public string getStaffID
        {
            get
            {
                return staffID;
            }
        }

        public string setDepartment
        {
            set
            {
                department = value;
            }
        }

        public string getDepartment
        {
            get
            {
                return department;
            }
        }
        public string setPosition
        {
            set
            {
                position = value;
            }
        }

        public string getPosition
        {
            get
            {
                return position;
            }
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public AnalysisReportForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //cbxChangeData.SelectedIndex = 0;
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 7;
            

            objChart.AxisY.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 1;
            objChart.AxisY.Maximum = 50;

            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
            {
                chart1.ChartAreas[0].AxisX.Title = "Month";
            }
            else
            {
                chart1.ChartAreas[0].AxisX.Title = Properties.Settings.Default.MonthZh;
            }

            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
            {
                chart1.ChartAreas[0].AxisY.Title = "Sales Order Count";
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Title = Properties.Settings.Default.SocZh;
            }

            chart1.Series.Clear();

            if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
            {
                var series = chart1.Series.Add("Sales");
                series.Name = "Sales";
                chart1.Series["Sales"].ChartType = SeriesChartType.Line;
                chart1.Series["Sales"].IsValueShownAsLabel = true;
            }
            else
            {
                var series = chart1.Series.Add(Properties.Settings.Default.SalesZh);
                series.Name = Properties.Settings.Default.SalesZh;
                chart1.Series[Properties.Settings.Default.SalesZh].ChartType = SeriesChartType.Line;
                chart1.Series[Properties.Settings.Default.SalesZh].IsValueShownAsLabel = true;
            }
    
           


            getChartData(sql);
        }

        private void getChartData(string sql)
        {
            openConnection();
            try
            {
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds);
                chart1.DataSource = ds;
                if (Thread.CurrentThread.CurrentUICulture.ToString().Equals("en"))
                {
                    chart1.Series["Sales"].XValueMember = "MONTH";
                    chart1.Series["Sales"].YValueMembers = "COUNT";
                }
                else
                {
                    chart1.Series[Properties.Settings.Default.SalesZh].XValueMember = "MONTH";
                    chart1.Series[Properties.Settings.Default.SalesZh].YValueMembers = "COUNT";                    
                }                
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
            closeConnection();
        }
    }
}
