using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskReminder
{
    public class WorkItemVM
    {
        WorkItemVM()
        {
            ObservableCollection<WorkItemBasicModel> workitems = new ObservableCollection<WorkItemBasicModel>();

        }

        public void InsertWorkItemTest(string connectingString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectingString))
                {
                    

                }
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }

        }

    }
}
