using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using CSDeskBand;

namespace WinNetSpeedMonitor
{
    [ComVisible(true)]
    [Guid("1DB5314E-6AFB-4F31-8C52-0898620C3088")]
    [CSDeskBandRegistration(Name = "WinNetSpeedMonitor", ShowDeskBand = true)]
    public class NetSpeedDeskBand : CSDeskBand.CSDeskBandWin
    {
        private static Control _control;
    }
}
