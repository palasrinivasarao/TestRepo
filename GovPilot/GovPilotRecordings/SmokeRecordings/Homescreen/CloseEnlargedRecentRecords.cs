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

namespace GovPilot.GovPilotRecordings.SmokeRecordings.Homescreen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseEnlargedRecentRecords recording.
    /// </summary>
    [TestModule("bd7fe9b5-9a8b-4fad-b859-b9bf9ad86da2", ModuleType.Recording, 1)]
    public partial class CloseEnlargedRecentRecords : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static CloseEnlargedRecentRecords instance = new CloseEnlargedRecentRecords();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseEnlargedRecentRecords()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseEnlargedRecentRecords Instance
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

            // Validate if the Close button exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Close button exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.RecentRecords_Close'.", repo.ApplicationUnderTest.RecentRecords.RecentRecords_CloseInfo, new RecordItemIndex(0));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.RecentRecords_CloseInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RecentRecords.RecentRecords_Close' at Center.", repo.ApplicationUnderTest.RecentRecords.RecentRecords_CloseInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.RecentRecords.RecentRecords_Close.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'ApplicationUnderTest.HomePage.Table_RecentRecords'", repo.ApplicationUnderTest.HomePage.Table_RecentRecordsInfo, new ActionTimeout(5000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.HomePage.Table_RecentRecordsInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.HomePage.Table_RecentRecords'.", repo.ApplicationUnderTest.HomePage.Table_RecentRecordsInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.Table_RecentRecordsInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "The Value for Close Operation is Verified In Recent Records", new RecordItemIndex(4));
            
            HelperClass.ChangeBackResolution();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "The Resolution got chnaged to 100%", new RecordItemIndex(6));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}