/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/18/24
 * Time: 11:03
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
    /// Description of LoadConfig.
    /// </summary>
    [TestModule("AF36CBA4-3931-4002-9662-395BD8067C6E", ModuleType.UserCode, 1)]
    public class LoadConfig : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoadConfig()
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
        }
    }
}
