using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    class Schedule
    {
        public string patient;
        public string doctor;
        public string date;
        public string time;

        public Schedule(string pat, string doc, string dat, string tim)
        {
            patient = pat;
            doctor = doc;
            date = dat;
            time = tim;
        }

        //takes in Schedule, passes to database, and deletes from database
        void delete(Schedule sched)
        {
            sched.patient = null;
            sched.doctor = null;
            sched.date = null;
            sched.time = null;
        }
    }
}
