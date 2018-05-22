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
            workitems.Add(new WorkItemBasicModel {StartTime=DateTime.Parse("26/10/2009 8:47:39 AM", CultureInfo.CreateSpecificCulture("en-US")),DueTime= DateTime.Now,ItemUrl="http://www.sina.com",ItemDescription="test1",WorkItemPriority="Low" });
            InsertWorkItemTest((App.Current as App).ConnectionString,workitems[0]);
        }

        public void InsertWorkItemTest(string connectingString, WorkItemBasicModel singleitem)
        {
            string InsertWorkitemQuery = "insert into" + "WorkItemTable" + "(StartDate,DueDate,URL,Description,Priority) Values("
               + singleitem.StartTime.ToString()+","
               + singleitem.DueTime.ToShortDateString() + ","
               + singleitem.ItemUrl + ","
               + singleitem.ItemDescription + ","
               + singleitem.WorkItemPriority
               +")";
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
