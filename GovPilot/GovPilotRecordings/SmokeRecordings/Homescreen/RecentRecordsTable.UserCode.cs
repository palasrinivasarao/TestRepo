﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace GovPilot.GovPilotRecordings.SmokeRecordings.Homescreen
{
    public partial class RecentRecordsTable
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void adjustResolution()
        {
        	var lnkModules = repo.ApplicationUnderTest.HomePage.LnkModules;
        	lnkModules.EnsureVisible();
        	Ranorex.Report.Info("Adjusts Resolution to 67%");
        	for(int i=0;i<4;i++)
        	{
        	Keyboard.Press("{ControlKey down}"); // Press the Control key
        	Delay.Milliseconds(500); // Delay for 500 milliseconds (optional)
        	Keyboard.Press("{Subtract}"); // Press the Subtract key
        	Delay.Milliseconds(500); // Delay for 500 milliseconds (optional)
        	Keyboard.Press("{ControlKey up}"); // Release the Control key			
        	}
        	Ranorex.Report.Success("Changed to smaller Resolution");
        }

    }
}