using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Control
{
    class DBConnect
    {
        public Account getAccount(string acct)
        {
            //make SQL queary for Account with userName acct
            return new Entity.Account();
        }

        public Schedule getSchedule()
        {
            //make SQL queary for Schedule
            return getSchedule();
        }

        public void setSchedule(Shedule sched)
        {
            //update Shcedule in DB
        }
    }
}
