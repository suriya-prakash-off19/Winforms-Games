using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Calender
{
    class InheritCalender : MonthCalendar 
    {

        protected override void OnDateSelected(DateRangeEventArgs drevent)
        {
            base.OnDateSelected(drevent);
            BackColor = Color.AliceBlue;
        }
    }
}
