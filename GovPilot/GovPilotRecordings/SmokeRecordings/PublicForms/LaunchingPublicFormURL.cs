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

namespace GovPilot.GovPilotRecordings.SmokeRecordings.PublicForms
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LaunchingPublicFormURL recording.
    /// </summary>
    [TestModule("48125876-a0d6-4eb0-bae2-eb1aeeb1c70b", ModuleType.Recording, 1)]
    public partial class LaunchingPublicFormURL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static LaunchingPublicFormURL instance = new LaunchingPublicFormURL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchingPublicFormURL()
        {
            publicFormUrl = "https://platformqa.govpilot.com/web/public/8eee716a-9f9_Dog-License-Township-of-Jackson?uid=7305&ust=NJ&pu=1&id=0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchingPublicFormURL Instance
        {
            get { return instance; }
        }

#region Variables

        string _publicFormUrl;

        /// <summary>
        /// Gets or sets the value of variable publicFormUrl.
        /// </summary>
        [TestVariable("8ef78f5e-98ae-41f0-8567-424d09155014")]
        public string publicFormUrl
        {
            get { return _publicFormUrl; }
            set { _publicFormUrl = value; }
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site URL in variable $publicFormUrl in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser(publicFormUrl, "Chrome", "", false, true, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}