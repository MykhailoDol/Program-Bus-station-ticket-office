using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_avtovokzalu
{
    class MainForm
    {
        public static ProgramForm Form;
        public static Account Account;
        public static TicketList Tickets;
        public static WayList Way;
        public static CostList Cost;

        public static void loadAll()
        {
            loadTickets();
            loadWays();
            loadCosts();
        }
        public static void saveAll()
        {
            saveTickets();
            saveWays();
            saveCosts();
        }

        public static void loadTickets()
        {
            TicketList tickets = new TicketList();
            string str = Environment.ExpandEnvironmentVariables(@"%appdata%\BD\tickets.txt");
            //string str = @"C:\Users\user\AppData\Roaming\BD\tickets.txt";
            using (StreamReader r = new StreamReader(str))
            {
                for (string reader = r.ReadLine(); reader != null; reader = r.ReadLine())
                {
                    tickets.Add(reader);
                }
            }
            Tickets = tickets;
        }
        public static void loadWays()
        {
            WayList ways = new WayList();
            string str = Environment.ExpandEnvironmentVariables(@"%appdata%\BD\timetable.txt");
            //string str = @"C:\Users\user\AppData\Roaming\BD\timetable.txt";
            using (StreamReader r = new StreamReader(str))
            {
                for (string reader = r.ReadLine(); reader != null; reader = r.ReadLine())
                {
                    ways.Add(reader);
                }
            }
            Way = ways;
        }
        public static void loadCosts()
        {
            CostList cost = new CostList();
            string str = Environment.ExpandEnvironmentVariables(@"%appdata%\BD\cost.txt");
            //string str = @"C:\Users\user\AppData\Roaming\BD\cost.txt";
            using (StreamReader r = new StreamReader(str))
            {
                for (string reader = r.ReadLine(); reader != null; reader = r.ReadLine())
                {
                    cost.Add(reader);
                }
            }
            Cost = cost;
        }
        public static void saveTickets()
        {
            string str = Environment.ExpandEnvironmentVariables(@"%appdata%\BD\tickets.txt");
            //string str = @"C:\Users\user\AppData\Roaming\BD\tickets.txt";
            using (StreamWriter r = new StreamWriter(str, false))
            {
                for (Tickets node = Tickets.head; node != null; node = node.Next)
                {
                    r.WriteLine(node.String());
                }
            }
        }
        public static void saveWays()
        {
            string str = Environment.ExpandEnvironmentVariables(@"%appdata%\BD\timetable.txt");
            //string str = @"C:\Users\user\AppData\Roaming\BD\timetable.txt";
            using (StreamWriter r = new StreamWriter(str, false))
            {
                for (Way node = Way.head; node != null; node = node.Next)
                {
                    r.WriteLine(node.String());
                }
            }
        }
        public static void saveCosts()
        {
            string str = Environment.ExpandEnvironmentVariables(@"%appdata%\BD\cost.txt");
            //string str = @"C:\Users\user\AppData\Roaming\BD\cost.txt";
            using (StreamWriter r = new StreamWriter(str, false))
            {
                for (Costs node = Cost.head; node != null; node = node.Next)
                {
                    r.WriteLine(node.String());
                }
            }
        }
    }
}
