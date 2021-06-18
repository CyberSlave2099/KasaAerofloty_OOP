using System;
using System.Collections.Generic;
using System.Text;

namespace Сoursework
{
    [Serializable]
    public class Ticket
    {
        //Розклад: номер рейсу, маршрут, пункти проміжної посадки, час відправлення, дні польоту.
        //Кількість вільних місць на кожному рейсі. 
        //Вибір найближчого рейсу до заданого пункту (при наявності вільних місць),
        //оформлення заданого числа квитків із узгодженням з пасажиром (зі зменшенням числа вільних місць), оформлення посадкової відомості.
        public int FlightNumber;
        public int ArrivalTime;
        public int DepartureTime;
        public int TotalFlightTime;
        public string DestinationSity;
        public string DepartureSity;
        public int Cost;
        public int FreeSeats;
        
        public Ticket(int FlightNumber, int ArrivalTime, int DepartureTime, int TotalFlightTime, string DestinationSity, string DepartureSity, int Cost, int FreeSeats)
        {
            this.FlightNumber = FlightNumber;
            this.ArrivalTime = ArrivalTime;
            this.DepartureTime = DepartureTime;
            this.TotalFlightTime = TotalFlightTime;
            this.DestinationSity = DestinationSity;
            this.DepartureSity = DepartureSity;
            this.Cost = Cost;
            this.FreeSeats = FreeSeats;
        }

        public string [] GetRowString()
        {
            string[] t = new string[8];
            t[0] = Convert.ToString(FlightNumber);
            t[1] = Convert.ToString(ArrivalTime);
            t[2] = Convert.ToString(DepartureTime);
            t[3] = Convert.ToString(TotalFlightTime);
            t[4] = DestinationSity;
            t[5] = DepartureSity;
            t[6] = Convert.ToString(Cost);
            t[7] = Convert.ToString(FreeSeats);

            return t;
        }
    }
}
