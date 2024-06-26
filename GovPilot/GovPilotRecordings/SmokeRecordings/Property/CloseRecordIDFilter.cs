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

namespace GovPilot.GovPilotRecordings.SmokeRecordings.Property
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseRecordIDFilter recording.
    /// </summary>
    [TestModule("a346189f-fa47-43b0-a629-0782652dd1e3", ModuleType.Recording, 1)]
    public partial class CloseRecordIDFilter : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static CloseRecordIDFilter instance = new CloseRecordIDFilter();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseRecordIDFilter()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseRecordIDFilter Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.Click_Filters' at Center.", repo.ApplicationUnderTest.Property.Click_FiltersInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Property.Click_Filters.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            // Verifying RecordId value was displayed
            Report.Log(ReportLevel.Info, "Validation", "Verifying RecordId value was displayed\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.Property.RecordId_Value'.", repo.ApplicationUnderTest.Property.RecordId_ValueInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Property.RecordId_ValueInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.Property.DogLicense_DG20200009'.", repo.ApplicationUnderTest.Property.DogLicense_DG20200009Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Property.DogLicense_DG20200009Info, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.Click_Filters' at Center.", repo.ApplicationUnderTest.Property.Click_FiltersInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Property.Click_Filters.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.CloseFilter' at Center.", repo.ApplicationUnderTest.Property.CloseFilterInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Property.CloseFilter.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
