/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 6/6/24
 * Time: 13:45
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

namespace GovPilot.RecordingModules.SmokeRecordings.PublicForms
{
    /// <summary>
    /// Description of HandleFailure.
    /// </summary>
    [TestModule("7C75F439-78D4-4CC4-8A77-50CB12F7569D", ModuleType.UserCode, 1)]
    public class HandleFailure : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        GovPilotRepository repo = GovPilotRepository.Instance;
        public HandleFailure()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        public void ExecuteHandleFailure()
        	
        {
        	Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.ApplicationUnderTest.Self, 10000);
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
        }
    }
}
