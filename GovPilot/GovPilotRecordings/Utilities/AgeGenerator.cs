/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/6/24
 * Time: 21:07
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
    /// Description of AgeGenerator.
    /// </summary>
    [TestModule("ABCEB62D-C866-4692-A000-1A0DBE0F0E2C", ModuleType.UserCode, 1)]
    public class AgeGenerator : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _AgeGenerated = "";
        [TestVariable("d6de2c32-50ef-45de-857d-a42de99e9e65")]
        public string AgeGenerated
        {
        	get { return _AgeGenerated; }
        	set { _AgeGenerated = value; }
        }
        
        public AgeGenerator()
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
			int randomNumber = random.Next(10, 100); // Generates a random integer between 10 (inclusive) and 100 (exclusive)
			string num = randomNumber.ToString();
			AgeGenerated = num;
			
        }
    }
}
