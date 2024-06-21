/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/6/24
 * Time: 21:05
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
    /// Description of ZipCodeGeneration.
    /// </summary>
    [TestModule("EB2106DE-1C42-4F09-B530-0F1ACD5CA172", ModuleType.UserCode, 1)]
    public class ZipCodeGeneration : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _ZipCodeGenerated = "";
        [TestVariable("2cdff105-917c-45b9-bec0-0ad72c0a6440")]
        public string ZipCodeGenerated
        {
        	get { return _ZipCodeGenerated; }
        	set { _ZipCodeGenerated = value; }
        }
        
        public ZipCodeGeneration()
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
			int randomNumber = random.Next(10000, 100000); // Generates a random integer between 10000 (inclusive) and 100000 (exclusive)
			string num = randomNumber.ToString();
			ZipCodeGenerated = num;
        }
    }
}
