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
    ///The RecentRecordsEnlargedView recording.
    /// </summary>
    [TestModule("861f4b92-4b71-4bfe-9c20-c97faf131531", ModuleType.Recording, 1)]
    public partial class RecentRecordsEnlargedView : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static RecentRecordsEnlargedView instance = new RecentRecordsEnlargedView();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RecentRecordsEnlargedView()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RecentRecordsEnlargedView Instance
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

            // Validate if the View More Button Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the View More Button Exists\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.Btn_ViewMore'.", repo.ApplicationUnderTest.HomePage.Btn_ViewMoreInfo, new RecordItemIndex(0));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.Btn_ViewMoreInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Btn_ViewMore' at Center.", repo.ApplicationUnderTest.HomePage.Btn_ViewMoreInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.Btn_ViewMore.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2s to exist. Associated repository item: 'ApplicationUnderTest.RecentRecords.Table_RecordsContent_EnlargedView'", repo.ApplicationUnderTest.RecentRecords.Table_RecordsContent_EnlargedViewInfo, new ActionTimeout(2000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.RecentRecords.Table_RecordsContent_EnlargedViewInfo.WaitForExists(2000);
            
            // Validate if the Record Content Exists in Enlarged Format
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Record Content Exists in Enlarged Format\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Table_RecordsContent_EnlargedView'.", repo.ApplicationUnderTest.RecentRecords.Table_RecordsContent_EnlargedViewInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Table_RecordsContent_EnlargedViewInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Title Recently Viewed exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Title Recently Viewed exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Title_RecentlyViewed'.", repo.ApplicationUnderTest.RecentRecords.Title_RecentlyViewedInfo, new RecordItemIndex(4));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Title_RecentlyViewedInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Property Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Property Exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Column_Property'.", repo.ApplicationUnderTest.RecentRecords.Column_PropertyInfo, new RecordItemIndex(5));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Column_PropertyInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Form Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Form Exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Column_Form'.", repo.ApplicationUnderTest.RecentRecords.Column_FormInfo, new RecordItemIndex(6));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Column_FormInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Record Type Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Record Type Exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Column_RecordType'.", repo.ApplicationUnderTest.RecentRecords.Column_RecordTypeInfo, new RecordItemIndex(7));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Column_RecordTypeInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Reference Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Reference Exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Column_Reference'.", repo.ApplicationUnderTest.RecentRecords.Column_ReferenceInfo, new RecordItemIndex(8));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Column_ReferenceInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Status Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Status Exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Column_Status'.", repo.ApplicationUnderTest.RecentRecords.Column_StatusInfo, new RecordItemIndex(9));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Column_StatusInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Other Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Other Exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Column_Other'.", repo.ApplicationUnderTest.RecentRecords.Column_OtherInfo, new RecordItemIndex(10));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Column_OtherInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Last Modified Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Last Modified Exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Column_LastModified'.", repo.ApplicationUnderTest.RecentRecords.Column_LastModifiedInfo, new RecordItemIndex(11));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Column_LastModifiedInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Property Address Exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Property Address Exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.Column_PropertyAddress'.", repo.ApplicationUnderTest.RecentRecords.Column_PropertyAddressInfo, new RecordItemIndex(12));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.Column_PropertyAddressInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Recent Records' close button exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Recent Records' close button exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.RecentRecords_Close'.", repo.ApplicationUnderTest.RecentRecords.RecentRecords_CloseInfo, new RecordItemIndex(13));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.RecentRecords_CloseInfo);
            Delay.Milliseconds(0);
            
            // Validate if the Column Recent Records' minimize button exists
            Report.Log(ReportLevel.Info, "Validation", "Validate if the Column Recent Records' minimize button exists\r\nValidating Exists on item 'ApplicationUnderTest.RecentRecords.RecentRecords_Minimize'.", repo.ApplicationUnderTest.RecentRecords.RecentRecords_MinimizeInfo, new RecordItemIndex(14));
            Validate.Exists(repo.ApplicationUnderTest.RecentRecords.RecentRecords_MinimizeInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
