using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOPAssignment05
{
    internal class TimeDetails
    {
        public double Seconds { get; set; }
        public double Minutes { get; set; }
        public double Hours { get; set; }
        #region Needed Constructors
        public TimeDetails(double h, double m, double s)
        {
            Seconds = s; Minutes = m; Hours = h;
        }
        public TimeDetails(double h, double m) : this(h, m, 0)
        {

        }

        public TimeDetails() : this(0, 0, 0)
        {

        }
        public TimeDetails(double totalSeconds)
        {
            Hours = totalSeconds / 3600;
            double remaining = totalSeconds % 3600;
            Minutes = remaining / 60;
            Seconds = remaining % 60;
        }
        #endregion
        private double TotlaTimeInSeconds() => (Hours * 3600) + (Minutes * 60) + Seconds;
        public override string ToString()
        {
            return $"The Exact Time is Hours: {(int)Hours} ,Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(TimeDetails))
                return false;

            TimeDetails other = (TimeDetails)obj;

            return this.Hours == other.Hours &&
                   this.Minutes == other.Minutes &&
                   this.Seconds == other.Seconds;
        }
        #region Binary Operators Overloadign
        public static TimeDetails operator +(TimeDetails left, TimeDetails right)
        {
            return new TimeDetails
            {
                Hours = (left?.Hours ?? 0) + (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) + (right?.Seconds ?? 0)
            };
        }
        public static TimeDetails operator +(TimeDetails opreand, double seconds)
        {
            TimeDetails td = new TimeDetails(seconds); // I used the constructor that deals with(double seconds) to create an objecte
            TimeDetails result = (opreand + td); // then i used the previous overload
            return result;
        }

        public static TimeDetails operator -(TimeDetails operand1, TimeDetails operand2)
        {
            return new TimeDetails()
            {
                Hours = Math.Abs((operand1?.Hours ?? 0) - (operand2?.Hours ?? 0)),
                Minutes = Math.Abs((operand1?.Minutes ?? 0) - (operand2?.Minutes ?? 0)),
                Seconds = Math.Abs((operand1?.Seconds ?? 0) - (operand2?.Seconds ?? 0))
            };
        }

        #endregion
        #region Unary Operators Overloadign
        public static TimeDetails operator ++(TimeDetails timeDetails)
        {
            if (timeDetails == null) throw new ArgumentNullException("invalid object");
            else
            {
                return new TimeDetails()
                {
                    Hours = timeDetails.Hours,
                    Minutes = timeDetails.Minutes + 1,
                    Seconds = timeDetails.Seconds
                };
            }
        }
        public static TimeDetails operator --(TimeDetails timeDetails)
        {

            return new TimeDetails()
            {
                Hours = timeDetails?.Hours ?? 0,
                Minutes = ((timeDetails?.Minutes ?? 0 - 1) < 0) ? 0 : (timeDetails?.Minutes ?? 0 - 1),
                Seconds = timeDetails?.Seconds ?? 0
            };
        }
        #endregion
        #region Relational Operators Overloadign
        public static bool operator >(TimeDetails? left, TimeDetails? right)
        {
            if (left is null && right is null) return false;
            if (left is null) return false;
            if (right is null) return true;
            return left.TotlaTimeInSeconds() > right.TotlaTimeInSeconds();
        }
        public static bool operator <(TimeDetails? left, TimeDetails? right)
        {
            if (left is null && right is null) return false;
            if (left is null) return true;
            if (right is null) return false;
            return left.TotlaTimeInSeconds() < right.TotlaTimeInSeconds();
        }
        public static bool operator <=(TimeDetails? left, TimeDetails? right)
        {
            if (left is null && right is null) return true;
            if (left is null) return true;
            if (right is null) return false;

            return left.TotlaTimeInSeconds() <= right.TotlaTimeInSeconds();
        }

        public static bool operator >=(TimeDetails? left, TimeDetails? right)
        {
            if (left is null && right is null) return true;
            if (left is null) return false;
            if (right is null) return true;
            return left.TotlaTimeInSeconds() >= right.TotlaTimeInSeconds();
        }
        #endregion
        #region Casting Operators Overloadign
        public static explicit operator DateTime(TimeDetails? value)
        {
            if (value is not null)
            {
                return new DateTime
                    (year: DateTime.Now.Year,
                    month: DateTime.Now.Month,
                    day: DateTime.Now.Day,
                    hour: (int)value.Hours,
                    minute: (int)value.Minutes,
                    second: (int)value.Seconds
                    );




            }
            throw new ArgumentNullException(nameof(value), "Cannot convert null TimeDetails to DateTime.");

        }

        #endregion
    }

}

