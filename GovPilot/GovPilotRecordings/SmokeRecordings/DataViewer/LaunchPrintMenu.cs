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
    ///The LaunchPrintMenu recording.
    /// </summary>
    [TestModule("c34649cf-c676-44be-aec4-fb313c3147c5", ModuleType.Recording, 1)]
    public partial class LaunchPrintMenu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static LaunchPrintMenu instance = new LaunchPrintMenu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchPrintMenu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchPrintMenu Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ViewFormPage.BtnPrintMenu' at Center.", repo.ApplicationUnderTest.ViewFormPage.BtnPrintMenuInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ViewFormPage.BtnPrintMenu.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.ViewFormPage.WindowPrintMenu'.", repo.ApplicationUnderTest.ViewFormPage.WindowPrintMenuInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ViewFormPage.WindowPrintMenuInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Validate_ChkBoxListItem(repo.ApplicationUnderTest.ViewFormPage.CheckboxSecondInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
