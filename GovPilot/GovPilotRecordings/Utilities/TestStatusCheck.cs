/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 6/3/24
 * Time: 12:57
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
    /// Description of TestStatusCheck.
    /// </summary>
    [TestModule("3F20D764-D594-4717-A14F-E6AD8A6FB9E1", ModuleType.UserCode, 1)]
    public class TestStatusCheck : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        
        
        public TestStatusCheck()
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
            
            Object result = TestSuite.Current.CurrentTestContainer.Status; //Gets the execution status of current testcase
            
            string TestCaseStatus = result.ToString();
            
            Report.Log(ReportLevel.Info, "Test Case current status is ", TestCaseStatus);
            
            if (TestCaseStatus.Equals ("Success"))
            	
            {
            	Report.Log(ReportLevel.Info, "Test Case Has Passed ", TestCaseStatus);
            }
            else if (TestCaseStatus.Equals ("Failed"))
            {
            	FailureHandlingScript failureObject = new FailureHandlingScript();
				
            	failureObject.ExecuteFailureHandlingScript();
            	          
            }
            }
    }
}
