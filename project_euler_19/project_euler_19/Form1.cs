using System;
using System.Windows.Forms;

namespace project_euler_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date date = new Date(1, 1, 1901);
            long numSunDays = 0;

            while (true)
            {
               if (date.year > 2000)
                    break;
                if (date.getDay() == Days.Sonday && date.day == 1)
                    numSunDays++;
                date.nextDay();
            }

            MessageBox.Show(numSunDays.ToString());
        }
    }

    enum Days
    {
        Monday,
        Tuesday,
        Wensday,
        Thursday,
        Friday,
        Saturday,
        Sonday
    }

    class Date
    {
        public int day, month, year;
        Days days;

        public Date()
        {
            day = 1;
            month = 1;
            year = 1900;
            days = Days.Monday;
        }

        public Date(int day, int month, int year)
        {
            this.day = 1;
            this.month = 1;
            this.year = 1900;
            days = Days.Monday;
            setDay(day, month, year);
        }

        public void setDay(int day, int month, int year)
        {
            if (year >= 1900 && day > 0 && month > 0 && month <= 12 && day <= 31)
            {
                if (this.year > year)
                    throw new Exception("Not a valid Date!");

                while (this.day != day && this.month != month && this.year != year)
                    nextDay();
            }
            else
                throw new Exception("Not a valid Date! The year needs to be greater than of equal to 1900");
        }

        public void nextDay()
        {
            day++;
            days++;
            if (days.ToString() == "7")
                days = Days.Monday;
            //test if the day is 28 of februari and if the year is a leap year, keep going, else go to the 29 of Februari
            if ((day == 29 && month == 2) && !(year % 4 == 0 && (!(year % 100 == 0) || (year % 400 == 0))))
            {
                day = 1;
                month++;
            }
            
            //test if the previous date was the 29th of Februari and going to a new month
            if(day > 29 && month == 2)
            {
                day = 1;
                month++;
            }

            //test if the day is larger than 31 and if so, go to the next month
            if(day > 31)
            {
                day = 1;
                month++;
            }

            //if the day is larger than 30, test if the month is September, April, June and November
            else if (day > 30)
            {
                if(month == 4 || month == 6 || month == 9 || month == 11)
                {
                    day = 1;
                    month++;
                }
            }

            //test if the month is larger than 12 and if so, go to the next year
            if(month > 12)
            {
                month = 1;
                year++;
            }
        }

        public Days getDay()
        {
            return days;
        }
    }
}
