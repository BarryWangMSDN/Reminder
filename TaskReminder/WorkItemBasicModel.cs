using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskReminder
{
    public class WorkItemBasicModel: INotifyPropertyChanged
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
   
        private string workitempriority;

        public string WorkItemPriority
        {
            get { return workitempriority; }
            set { workitempriority = value; }
        }


        private string itemdescription;

       

        public string ItemDescription
        {
            get { return itemdescription; }
            set { itemdescription = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
