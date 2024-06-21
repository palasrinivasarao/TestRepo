/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/6/24
 * Time: 20:54
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
    /// Description of PhoneNumber.
    /// </summary>
    [TestModule("1D01F308-A793-4681-BD4A-37D02F2292F6", ModuleType.UserCode, 1)]
    public class PhoneNumber : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        
        string _PhoneNoGenerated = "";
        [TestVariable("b606affd-07f6-460e-9f0b-ea7cd8955f83")]
        public string PhoneNoGenerated
        {
        	get { return _PhoneNoGenerated; }
        	set { _PhoneNoGenerated = value; }
        }
        
            
        public PhoneNumber()
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
            string num = generator.Next(1000000000).ToString("D10");
            PhoneNoGenerated = num;
            
            
        }
    }
}