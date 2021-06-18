using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Сoursework.Classes
{
    [Serializable]
    public class TicketsList
    {
        //поля
        public List<Ticket> list;
        // конструктор
        public TicketsList() 
        { 

        }

        public void Add(Ticket t)
        {
            if (list == null)
            {
                list = new List<Ticket>();
            }
            list.Add(t);
        }

        public void Delete(ListView lv)
        {
            if (list != null)
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити цей квиток?", "Видалити", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int t = lv.SelectedIndices[0];
                    lv.Items.RemoveAt(lv.SelectedIndices[0]);
                    list.RemoveAt(t);
                }
            }
            else MessageBox.Show("Колекція пуста");
        }
        //public void Serialize()
        //{
        //    XmlSerializer xml = new XmlSerializer(typeof(TicketsList));
        //    if (File.Exists("List_Of_Tickets.xml"))
        //    {
        //        File.Delete("List_Of_Tickets.xml");
        //    }
        //    using (FileStream fs = new FileStream("List_Of_Tickets.xml", FileMode.OpenOrCreate))
        //    {
        //        xml.Serialize(fs, this);
        //    }
        //}
        //public TicketsList Deserialize()
        //{
        //    try
        //    {
        //        XmlSerializer xml = new XmlSerializer(typeof(TicketsList));
        //        using (FileStream fs = new FileStream("DovidnikFanataIfo.xml", FileMode.OpenOrCreate))
        //        {
        //            return (TicketsList)xml.Deserialize(fs);
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Файл пустий");
        //    }
        //    return new TicketsList();
        //}
        public string SaveToTxt(Ticket t)
        {
            string res = $"\n Номер рейсу: {t.FlightNumber}" +
            $"\n Час відправлення: { t.DepartureTime}" +
            $"\n Час прибуття: { t.ArrivalTime}" +
            $"\n Місто відправлення: { t.DepartureSity}" +
            $"\n Місто прибуття: { t.DestinationSity}" +
            $"\n Сумарний час перельоту: { t.TotalFlightTime}" +
            $"\n Кількість вільних місць: { t.FreeSeats}" +
            $"\n Вартість: { t.Cost}";
            return res;
        }

        public List<Ticket> FlightNumberFilter(string s, TicketsList tl)
        {
            List<Ticket> res = new List<Ticket>();
            int length = tl.list.Count;
            if(s != "")
            {
                foreach(Ticket tt in tl.list)
                {
                    if (Convert.ToString(tt.FlightNumber) == s)
                    {
                        res.Add(tt);
                    }
                }
            }
            return res;
        }

        public List<Ticket> DepatureTimeFilter(string s, TicketsList tl)
        {
            List<Ticket> res = new List<Ticket>();
            int length = tl.list.Count;
            if (s != "")
            {
                foreach (Ticket tt in tl.list)
                {
                    if (Convert.ToString(tt.DepartureTime) == s)
                    {
                        res.Add(tt);
                    }
                }
            }
            return res;
        }

        public List<Ticket> DepatureSityFilter(string s, TicketsList tl)
        {
            List<Ticket> res = new List<Ticket>();
            int length = tl.list.Count;
            if (s != "")
            {
                foreach (Ticket tt in tl.list)
                {
                    if (tt.DepartureSity == s)
                    {
                        res.Add(tt);
                    }
                }
            }
            return res;
        }

        public List<Ticket> MaxCostFilter(string s, TicketsList tl) 
        {
            List<Ticket> res = new List<Ticket>();
            int length = tl.list.Count;
            if (s != "")
            {
                foreach (Ticket tt in tl.list)
                {
                    if (tt.Cost >= Convert.ToInt32(s))
                    {
                        res.Add(tt);
                    }
                }
            }
            return res;
        }

        public TicketsList Find(TicketsList ex, string FlightNumber = "", string DepatureTime = "", string DepatureSity = "", string MaxCost = "")
        {
            TicketsList res = new TicketsList();
            int Len = ex.list.Count();
            for (int i = 0; i < Len; i++)
            {
                Ticket temp = ex.list[i];
                res.Add(temp);
            }
            if (FlightNumber != "")
            {
                res.list = res.FlightNumberFilter(FlightNumber, res);
            }
            if (DepatureTime != "")
            {
                res.list = res.DepatureTimeFilter(DepatureTime, res);
            }
            if (DepatureSity != "")
            {
                res.list = res.DepatureSityFilter(DepatureSity, res);
            }
            if (MaxCost != "")
            {
                res.list = res.MaxCostFilter(MaxCost, res);
            }
            return res;
        }



    }
}
