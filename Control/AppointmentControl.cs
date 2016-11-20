using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Control
{
    class AppointmentControl
    {
        public Schedule schedule;

        public void openAppointment()
        {

        }

        public void makeApp(string doc, string pat, string dat, string tim)
        {

        }

        public void setSchedule(string doc, string pat, string dat, string tim)
        {
            schedule.Schedule(doc, pat, dat, tim);
        }

        public Schedule getSchedule()
        {
            return schedule;
        }

        public void confirm()
        {

        }

        public void change()
        {

        }

        public void openMain()
        {

        }
    }
}
