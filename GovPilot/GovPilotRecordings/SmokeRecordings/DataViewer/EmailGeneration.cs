/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/6/24
 * Time: 20:55
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
    /// Description of EmailGeneration.
    /// </summary>
    [TestModule("AB6724C9-E6FB-40C3-A67C-EE5F72A6C6DC", ModuleType.UserCode, 1)]
    public class EmailGeneration : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _EmailGenerated = "";
        [TestVariable("8422f61b-9061-4e19-8217-bef57db932b1")]
        public string EmailGenerated
        {
        	get { return _EmailGenerated; }
        	set { _EmailGenerated = value; }
        }
        
        public EmailGeneration()
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
        
            Random generator = new Random();
            string num = generator.Next(100).ToString("D5");
            EmailGenerated = "test"+num+"@govpilot.com";
        }
    }
}
