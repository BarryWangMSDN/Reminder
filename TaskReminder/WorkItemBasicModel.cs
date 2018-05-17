using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskReminder
{
    class WorkItemBasicModel
    {
        private DateTime starttime;

        public DateTime StartTime
        {
            get { return starttime; }
            set { starttime = value; }
        }

        private DateTime duetime;

        public DateTime DueTime
        {
            get { return duetime; }
            set { duetime = value; }
        }

        private string itemurl;

        public string ItemUrl
        {
            get { return itemurl; }
            set { itemurl = value; }
        }
   
        private List<string> workitempriority;

        public List<string> WorkItemPriority
        {
            get { return workitempriority; }
            set { workitempriority = value; }
        }

        


    }
}
