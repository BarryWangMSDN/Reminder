using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskReminder
{
    public class WorkItemVM
    {

        public WorkItemVM()
        {
            ObservableCollection<WorkItemBasicModel> workitems = new ObservableCollection<WorkItemBasicModel>();
           //var testtime=DateTime.ParseExact(DateTime.Now.ToString(), "yyyy-mm-dd hh:mm:ss",CultureInfo.InvariantCulture);
            workitems.Add(new WorkItemBasicModel {StartTime=DateTime.Now, DueTime= DateTime.Now,ItemUrl="test",ItemDescription="test1",WorkItemPriority="Low" });
            InsertWorkItem(((App.Current as App).ConnectionString), workitems[0]);


        }

        public void InsertWorkItem(string connectingString, WorkItemBasicModel singleitem)
        {
            string InsertWorkitemQuery = "insert into" + " WorkItemTable" + "(StartDate,DueDate,URL,Description,Priority) Values("
               + "'" + singleitem.StartTime.ToShortDateString()+" " + singleitem.StartTime.ToShortTimeString()+"',"
               + "'" + singleitem.DueTime.ToShortDateString() + " " + singleitem.DueTime.ToShortTimeString() + "',"
               + "'" + singleitem.ItemUrl + "',"
               + "'" + singleitem.ItemDescription + "',"
               + "'" + singleitem.WorkItemPriority
               + "')";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectingString))
                {
                    conn.Open();
                    if(conn.State==System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = InsertWorkitemQuery;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                    }

                }
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }

        }

    }
}
