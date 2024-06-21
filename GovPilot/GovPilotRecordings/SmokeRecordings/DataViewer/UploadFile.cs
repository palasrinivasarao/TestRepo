/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 5/15/24
 * Time: 17:05
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
using System.IO;

namespace GovPilot
{
    /// <summary>
    /// Description of UploadFile.
    /// </summary>
    [TestModule("A2DCBC9C-9572-4D22-9A58-7905D3975BA1", ModuleType.UserCode, 1)]
    public class UploadFile : ITestModule
    {
    string _PathOfFileinPWD = "";
    [TestVariable("c777403c-fabe-48f6-b8fd-7f523d82ad6b")]
    public string PathOfFileinPWD
    {
    	get { return _PathOfFileinPWD; }
    	set { _PathOfFileinPWD = value; }
    }
    string _RelativePathOfFile = "";
    [TestVariable("cbbef116-66f9-4b9b-9a01-e119c925469a")]
    public string RelativePathOfFile
    {
    	get { return _RelativePathOfFile; }
    	set { _RelativePathOfFile = value; }
    }
    
    string _FullPath = "";
    [TestVariable("27da5ddf-3198-49a3-b99a-f5d2c2596047")]
    public string FullPath
    {
    	get { return _FullPath; }
    	set { _FullPath = value; }
    }
    
    
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UploadFile()
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
            
           PathOfFileinPWD = Ranorex.Core.Testing.TestSuite.WorkingDirectory; //File should be in Bin/Debug folder
           string FullPath = Path.Combine(PathOfFileinPWD, RelativePathOfFile);
           Report.Log(ReportLevel.Info, "Path", FullPath);
        }
    }
}
