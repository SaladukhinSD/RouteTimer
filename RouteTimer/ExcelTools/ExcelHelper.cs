using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace RouteTimer
{
    class ExcelHelper : IDisposable
    {
        private Application _excel;
        private Workbook _workbook;
        private string _filePath;

        public ExcelHelper()
        {
            _excel = new Excel.Application();
        }

        public void Dispose()
        {
            try
            {

                _workbook.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal bool Open(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    _workbook = _excel.Workbooks.Open(filePath);
                }
                else
                {
                    _workbook = _excel.Workbooks.Add();
                    _filePath = filePath;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }


        public class Route
        {
            internal string numberRoute;
            internal string nameRoute;
            internal string directionRoute;
            internal string distanceAboutBusStop;
            internal string kindOfTransport;
            internal string allTime;
            public Route(string number, string name, string direction,string distance, string transport, string time)
            {
                numberRoute = number;
                nameRoute = name;
                directionRoute = direction;
                distanceAboutBusStop = distance;
                kindOfTransport = transport;
                allTime = time;
            }

        }

        internal void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                _workbook.SaveAs(_filePath);
                _filePath = null;
            }
            else
            {
                _workbook.Save();
            }
        }

        internal bool Set(string column, int row, object data)
        {
            try
            {
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].Value = data;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        internal string Get(string column, int row)
        {
            try
            {
                return Convert.ToString(((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].Value);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Exception";
        }

        internal int SearchRouteByNumber(string numberRoute)
        {
            int rowOfExcel = 1;
            string emptyRoute = Convert.ToString(((Excel.Worksheet)_excel.ActiveSheet).Cells[rowOfExcel, "A"].Value);
            while (emptyRoute != numberRoute)
            {
                rowOfExcel++;
                emptyRoute = Convert.ToString(((Excel.Worksheet)_excel.ActiveSheet).Cells[rowOfExcel, "A"].Value);
            }
            return rowOfExcel;
        }

        internal int SearchLastRoute()
        {
            int rowOfExcel = 1;
            string emptyRoute = Convert.ToString(((Excel.Worksheet)_excel.ActiveSheet).Cells[rowOfExcel, "A"].Value);
            while (emptyRoute != null)
            {
                rowOfExcel++;
                emptyRoute = Convert.ToString(((Excel.Worksheet)_excel.ActiveSheet).Cells[rowOfExcel, "A"].Value);
            }
            return rowOfExcel;
        }


        internal void AddRoute(Route newRoute)
        {
            int row = this.SearchLastRoute();
            this.Set("A", row, newRoute.numberRoute);
            this.Set("B", row, newRoute.nameRoute);
            this.Set("C", row, newRoute.directionRoute);
            this.Set("D", row, newRoute.distanceAboutBusStop);
            this.Set("E", row, newRoute.kindOfTransport);
            this.Set("F", row, newRoute.allTime);
        }

        internal void DeliteRoute(string numberRoute)
        {
            int row = this.SearchRouteByNumber(numberRoute);
            this.Set("A", row, "");
            this.Set("B", row, "");
            this.Set("C", row, "");
            this.Set("D", row, "");
            this.Set("E", row, "");
            this.Set("F", row, "");
        }

        internal Route DataRoute(string numberRoute)
        {
            int row = this.SearchRouteByNumber(numberRoute);
            string dataAboutNumber = this.Get("A", row);
            string dataAboutName = this.Get("B", row);
            string dataAboutDistring = this.Get("C", row);
            string dataAboutDistance = this.Get("D", row);
            string dataAboutTransport = this.Get("E", row);
            string dataAboutTime = this.Get("F", row);
            Route allData = new Route(dataAboutNumber,dataAboutName,dataAboutDistring, dataAboutDistance, dataAboutTransport, dataAboutTime);

            return allData;
        }

        internal string[] DataAboutRoute(string numberRoute)
        {
            Route serchRoute = this.DataRoute(numberRoute);
            string[] dataAboutRoute = new string[] {serchRoute.numberRoute,serchRoute.nameRoute, serchRoute.directionRoute, serchRoute.distanceAboutBusStop, serchRoute.kindOfTransport, serchRoute.allTime };
            return dataAboutRoute;
        }

        internal string InformationAboutRoute(string numberRoute)
        {
            Route allData = this.DataRoute(numberRoute);
            string AllDataAboutRoute = $"Number: {allData.numberRoute} \r\nName: {allData.nameRoute} \r\n" +
                $"Distring: {allData.directionRoute} \r\nDistance about bus stop: {allData.distanceAboutBusStop} \r\n" +
                $"Kind of Transport: {allData.kindOfTransport} \r\nDeparture time: {allData.allTime}";
            return AllDataAboutRoute;
        }

        internal void ModifyRoute(List<string> dataAboutRoute)
        {
            int row = this.SearchRouteByNumber(dataAboutRoute[0]);
            this.Set("B", row, dataAboutRoute[1]);
            this.Set("C", row, dataAboutRoute[2]);
            this.Set("D", row, dataAboutRoute[3]);
            this.Set("E", row, dataAboutRoute[4]);
            this.Set("F", row, dataAboutRoute[5]);
        }

        internal object[] AllNumbersRoute()
        {
            var allNumberRoute = new List<string> { };    //?????????
            int precentNumberRoute = 4;
            bool numberRouteNotNull = true;
            string numberRoute;

            while (numberRouteNotNull)
            {
                numberRoute =  this.Get("A", precentNumberRoute);
                if (numberRoute != null)
                {
                    allNumberRoute.Add(numberRoute);
                    precentNumberRoute++;
                }
                else numberRouteNotNull= false;
            }

            object[] dataAllNumbers = allNumberRoute.ToArray();
            return dataAllNumbers;
        }

        

        internal TimeSpan TimeBeforeBusStop(TimeSpan timeBeforeDepartureBusStop, string distanceAboutBusStop)
        {
            double speedUser = Convert.ToDouble(this.Get("A", 2));
            if (speedUser == 0)
            {
                double minutesSpeedUser = Convert.ToDouble(this.Get("B", 2));
                double distanceUser = Convert.ToDouble(this.Get("C", 2));
                speedUser = distanceUser/minutesSpeedUser;
            }

            int minutesOvercomingDistance = Convert.ToInt32(Convert.ToDouble(distanceAboutBusStop)/speedUser);

            timeBeforeDepartureBusStop = timeBeforeDepartureBusStop - new TimeSpan(0, minutesOvercomingDistance, 0);
            return timeBeforeDepartureBusStop;
        }

        internal string OutputInformationAboutTime(TimeSpan firstTime, TimeSpan secondTime)
        {
            string outputInformtion;
            if (firstTime.Minutes < 10)
                outputInformtion = firstTime.Hours.ToString() + ":0" + firstTime.Minutes.ToString();
            else
                outputInformtion = firstTime.Hours.ToString() + ":" + firstTime.Minutes.ToString();
            if (secondTime.Minutes < 10)
                outputInformtion += "; " + secondTime.Hours.ToString() + ":0" + secondTime.Minutes.ToString();
            else
                outputInformtion += "; " + secondTime.Hours.ToString() + ":" + secondTime.Minutes.ToString();
            return outputInformtion;
        }

        internal string MinutesBeforeDeparture(TimeSpan firstTime, TimeSpan secondTime)
        {
            string timeBeforeDeparture;
            DateTime timeNowDate = DateTime.Now;
            TimeSpan timeNow = new TimeSpan(timeNowDate.Hour, timeNowDate.Minute,0);
            TimeSpan timeZero = new TimeSpan(0, 0, 0);
            TimeSpan firstTimeSpan = firstTime.Subtract(timeNow);
            if(firstTimeSpan < timeZero)
                firstTimeSpan = new TimeSpan(24,00,00) + firstTimeSpan;

            TimeSpan secondTimeSpan = secondTime.Subtract(timeNow);
            if (secondTimeSpan < timeZero)
                secondTimeSpan = new TimeSpan(24, 00, 00) + secondTimeSpan;


            timeBeforeDeparture = OutputInformationAboutTime(firstTimeSpan,secondTimeSpan);
            
            return timeBeforeDeparture;
        }

        internal object[] AllData()
        {
            DateTime timeDateHelp = DateTime.Now;
            TimeSpan timeNow = new TimeSpan(timeDateHelp.Hour, timeDateHelp.Minute, 0);
            string timeRoute;
            int filledArraayElement = 0;
            List<Route> dataAllRouts = new List<Route>();
            object[] timeRouts = this.AllNumbersRoute();
            object[] stringTimes = new object[timeRouts.Length];

            //функция по сбору всей иформации всех рейсов
            foreach (object times in timeRouts)
            {
                dataAllRouts.Add(this.DataRoute(Convert.ToString(times)));

            }
            //функция по подсчету времени за которое нужно выйти для каждого рейса
            foreach (Route data in dataAllRouts)
            {

                TimeSpan firstTimeRoute = TimeSpan.Zero, secondTimeRoute = TimeSpan.Zero;
                timeRoute = data.allTime;
                //цикл по преобразованию строки времени в два значения
                for (int i = 0; i < timeRoute.Length; i++)
                {

                    if (timeRoute.Substring(i,1) == ":")
                    {
                        timeDateHelp = Convert.ToDateTime(timeRoute.Substring(i-2, 5));
                        firstTimeRoute = new TimeSpan(timeDateHelp.Hour, timeDateHelp.Minute, 0);
                        firstTimeRoute =  TimeBeforeBusStop(firstTimeRoute, data.distanceAboutBusStop);

                        if (firstTimeRoute >= timeNow)
                        {
                            if (i + 8 <= timeRoute.Length)
                            {
                                timeDateHelp = Convert.ToDateTime(timeRoute.Substring(i+5, 5));
                                secondTimeRoute = new TimeSpan(timeDateHelp.Hour, timeDateHelp.Minute, 0);
                                secondTimeRoute = TimeBeforeBusStop(secondTimeRoute, data.distanceAboutBusStop);

                            }
                            else
                            {
                                timeDateHelp = Convert.ToDateTime(timeRoute.Substring(0, 5));
                                secondTimeRoute = new TimeSpan(timeDateHelp.Hour, timeDateHelp.Minute, 0);
                                secondTimeRoute = TimeBeforeBusStop(secondTimeRoute, data.distanceAboutBusStop);
                            }
                            data.allTime = this.MinutesBeforeDeparture(firstTimeRoute, secondTimeRoute);
                            break;
                        }

                        i+=6;
                    }
                }
                if (secondTimeRoute == TimeSpan.Zero)
                {
                    timeDateHelp = Convert.ToDateTime(timeRoute.Substring(0, 5));
                    firstTimeRoute = new TimeSpan(timeDateHelp.Hour, timeDateHelp.Minute, 0);
                    firstTimeRoute = TimeBeforeBusStop(firstTimeRoute, data.distanceAboutBusStop);
                    
                    timeDateHelp = Convert.ToDateTime(timeRoute.Substring(7, 5));
                    secondTimeRoute = new TimeSpan(timeDateHelp.Hour, timeDateHelp.Minute, 0);
                    secondTimeRoute = TimeBeforeBusStop(secondTimeRoute, data.distanceAboutBusStop);
                            
                    data.allTime = this.MinutesBeforeDeparture(firstTimeRoute, secondTimeRoute);
                }
                stringTimes [filledArraayElement] = data.numberRoute + "\t " + data.nameRoute + " \t" + data.allTime;
                filledArraayElement++;
            }
            return stringTimes; 
        }
    }
}
