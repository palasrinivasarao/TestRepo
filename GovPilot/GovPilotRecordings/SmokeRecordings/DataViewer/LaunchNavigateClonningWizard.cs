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
    ///The LaunchNavigateClonningWizard recording.
    /// </summary>
    [TestModule("4109e7f4-c4de-4e5f-a7ad-579e4ef792be", ModuleType.Recording, 1)]
    public partial class LaunchNavigateClonningWizard : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static LaunchNavigateClonningWizard instance = new LaunchNavigateClonningWizard();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchNavigateClonningWizard()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchNavigateClonningWizard Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ViewFormPage.BtnClone' at Center.", repo.ApplicationUnderTest.ViewFormPage.BtnCloneInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ViewFormPage.BtnClone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            // Validating that Cloning Wizard dialog opens up
            Report.Log(ReportLevel.Info, "Validation", "Validating that Cloning Wizard dialog opens up\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.CloningWizard.TitleCloningWizard'.", repo.ApplicationUnderTest.CloningWizard.TitleCloningWizardInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CloningWizard.TitleCloningWizardInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.CloningWizard.BtnNext'.", repo.ApplicationUnderTest.CloningWizard.BtnNextInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.CloningWizard.BtnNext.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.CloningWizard.BtnNext'.", repo.ApplicationUnderTest.CloningWizard.BtnNextInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.CloningWizard.BtnNext.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.CloningWizard.BtnClone'.", repo.ApplicationUnderTest.CloningWizard.BtnCloneInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.CloningWizard.BtnClone.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.BtnCancel' at Center.", repo.ApplicationUnderTest.HomePage.BtnCancelInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.HomePage.BtnCancel.Click();
            Delay.Milliseconds(0);
            
            // Validating that control goes back to DataViewer Screen
            Report.Log(ReportLevel.Info, "Validation", "Validating that control goes back to DataViewer Screen\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.HomePage.BtnCreateNew'.", repo.ApplicationUnderTest.HomePage.BtnCreateNewInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.HomePage.BtnCreateNewInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
