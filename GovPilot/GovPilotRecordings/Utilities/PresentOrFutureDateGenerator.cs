/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 4/23/24
 * Time: 16:09
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
    /// Description of DateGenerator.
    /// </summary>
    [TestModule("9CDDB983-2FAD-4342-BC2B-3BE382193A88", ModuleType.UserCode, 1)]
    public class PresentOrFutureDateGenerator : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        
        string _Date = "";
        [TestVariable("b9278714-7986-45d0-a5e5-151b4ee0881a")]
        public string Date
        {
        	get { return _Date; }
        	set { _Date = value; }
        }
        
        
        
        public PresentOrFutureDateGenerator()
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
                     
        	Date = System.DateTime.Now.AddDays(1).ToString("MM/dd/yy");
        
        }
    }
}
