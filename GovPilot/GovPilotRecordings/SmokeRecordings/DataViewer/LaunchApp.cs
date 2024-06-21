﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace GovPilot.GovPilotRecordings.SmokeRecordings.DataViewer
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LaunchApp recording.
    /// </summary>
    [TestModule("502fa218-f3ab-43d9-8b0a-28ff51bdc1c5", ModuleType.Recording, 1)]
    public partial class LaunchApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static LaunchApp instance = new LaunchApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchApp()
        {
            TenantUrl = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchApp Instance
        {
            get { return instance; }
        }

#region Variables

        string _TenantUrl;

        /// <summary>
        /// Gets or sets the value of variable TenantUrl.
        /// </summary>
        [TestVariable("4820f0b4-a346-4f4a-998e-e8ffd87550e3")]
        public string TenantUrl
        {
            get { return _TenantUrl; }
            set { _TenantUrl = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $TenantUrl in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(TenantUrl, "Chrome", "", false, true, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}