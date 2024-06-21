/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 6/15/24
 * Time: 21:58
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

namespace GovPilot.GovPilotRecordings.Utilities
{
    /// <summary>
    /// Description of StopWatchingPopUp.
    /// </summary>
    [TestModule("6E815EEC-4F08-4D8D-9529-962771A05813", ModuleType.UserCode, 1)]
    public class StopWatchingPopUp : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StopWatchingPopUp()
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
            
            WatchAutoComplete.DoWatchAutoComplete.Stop();
        }
    }
}
