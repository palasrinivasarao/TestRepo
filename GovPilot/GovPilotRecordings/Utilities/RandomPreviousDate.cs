/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/6/24
 * Time: 21:09
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;


namespace GovPilot
{
    /// <summary>
    /// Description of RandomPreviousDate.
    /// </summary>
    [TestModule("5045A398-8770-475E-985E-FDD5F89D13EC", ModuleType.UserCode, 1)]
    public class RandomPreviousDate : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _PreviousDateGenerated = "";
        [TestVariable("48e8a237-96b7-4f19-bc76-14258e40cbe9")]
        public string PreviousDateGenerated
        {
        	get { return _PreviousDateGenerated; }
        	set { _PreviousDateGenerated = value; }
        }
        
        public RandomPreviousDate()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            Random random = new Random();
			int currentYear = System.DateTime.Now.Year;
			// Generate a random month between 1 and 12
			int month = random.Next(1, 13);
			// Generate a random day based on the selected month (taking into account leap years)
			int daysInMonth = System.DateTime.DaysInMonth(currentYear, month);
			int day = random.Next(1, daysInMonth + 1);
			PreviousDateGenerated = new System.DateTime(currentYear, month, day).ToString();
        }
    }
}
