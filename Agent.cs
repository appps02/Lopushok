using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Lopushok
{
    public class Agent
    {
        public string Title { get; set; }
        public int AgentTypeID { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string DirectorName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public int Priority { get; set; }

        public Agent(string title, int agentTypeID, string address, string iNN, string kPP, string directorName, string phone, string email, string logo, int priority)
        {
            Title = title;
            AgentTypeID = agentTypeID;
            Address = address;
            INN = iNN;
            KPP = kPP;
            DirectorName = directorName;
            Phone = phone;
            Email = email;
            Logo = logo;
            Priority = priority;
        }

        public static List<Agent> table_agents(DataTable table)
        {
            List<Agent> list = new List<Agent>();
            foreach (DataRow dr in table.Rows)
            {
                object[] row = dr.ItemArray;
                Agent agents = new Agent(row[1].ToString(), Convert.ToInt32(row[2]), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), Convert.ToInt32(row[10]));
                list.Add(agents);
            }
            return list;
        }
    }
}
