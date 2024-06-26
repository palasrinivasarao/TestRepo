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
    ///The VerifyViewCountForThirdView recording.
    /// </summary>
    [TestModule("af657045-0226-4c0f-82d3-4fd192dcea57", ModuleType.Recording, 1)]
    public partial class VerifyViewCountForThirdView : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static VerifyViewCountForThirdView instance = new VerifyViewCountForThirdView();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyViewCountForThirdView()
        {
            ActualCountValue3 = "";
            RecordID = "";
            ViewName3 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyViewCountForThirdView Instance
        {
            get { return instance; }
        }

#region Variables

        string _ActualCountValue3;

        /// <summary>
        /// Gets or sets the value of variable ActualCountValue3.
        /// </summary>
        [TestVariable("11d9e66a-baf3-497d-8a00-dbf73f8c89fc")]
        public string ActualCountValue3
        {
            get { return _ActualCountValue3; }
            set { _ActualCountValue3 = value; }
        }

        string _RecordID;

        /// <summary>
        /// Gets or sets the value of variable RecordID.
        /// </summary>
        [TestVariable("08d25a1f-c9bf-49ad-836c-64a74dfe496f")]
        public string RecordID
        {
            get { return _RecordID; }
            set { _RecordID = value; }
        }

        string _ViewName3;

        /// <summary>
        /// Gets or sets the value of variable ViewName3.
        /// </summary>
        [TestVariable("34e51431-0d70-4832-9c9e-7d9659ecca0a")]
        public string ViewName3
        {
            get { return _ViewName3; }
            set { _ViewName3 = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.LnkModules'", repo.ApplicationUnderTest.HomePage.LnkModulesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HomePage.LnkModulesInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            // To Verify the Added Tile Exists
            //Report.Log(ReportLevel.Info, "Section", "To Verify the Added Tile Exists", new RecordItemIndex(1));
            
            //Report.Log(ReportLevel.Info, "User", "To Verify the Added Tile Exists", new RecordItemIndex(2));
            
            //HelperClass.ToVerifyAddedTile(ViewName3);
            //Delay.Milliseconds(0);
            
            // To Get the Actual Count Value on the Tile on the Home page
            Report.Log(ReportLevel.Info, "Section", "To Get the Actual Count Value on the Tile on the Home page", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "User", "To Fetch the count value from the Tile", new RecordItemIndex(5));
            
            ActualCountValue3 = HelperClass.ToFetchCountValueOnTile(ViewName3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "The Actual Count on the Tile is", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "User", ActualCountValue3, new RecordItemIndex(8));
            
            // The Third View on the Tile is Clicked
            Report.Log(ReportLevel.Info, "Section", "The Third View on the Tile is Clicked", new RecordItemIndex(9));
            
            // To Verify if the First View Exists on the Tile
            Report.Log(ReportLevel.Info, "Validation", "To Verify if the First View Exists on the Tile\r\nValidating AttributeEqual (InnerText=$ViewName3) on item 'ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTile'.", repo.ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTileInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTileInfo, "InnerText", ViewName3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTile' at Center.", repo.ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTileInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.DogLicensePage.Txt_ViewName_All'", repo.ApplicationUnderTest.DogLicensePage.Txt_ViewName_AllInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.DogLicensePage.Txt_ViewName_AllInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.DogLicensePage.Btn_Filter'", repo.ApplicationUnderTest.DogLicensePage.Btn_FilterInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.DogLicensePage.Btn_FilterInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            HelperClass.ClickOnView(ViewName3);
            Delay.Milliseconds(0);
            
            // To Verify if the Filter Value of the RecordId Column Contains the Value 10
            Report.Log(ReportLevel.Info, "Section", "To Verify if the Filter Value of the RecordId Column Contains the Value 10", new RecordItemIndex(15));
            
            // To Validate if the Filter Value of the RecordIDColumn Contains the Value 10
            Report.Log(ReportLevel.Info, "Wait", "To Validate if the Filter Value of the RecordIDColumn Contains the Value 10\r\nWaiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.DogLicensePage.Txt_TagValue_RecordID'", repo.ApplicationUnderTest.DogLicensePage.Txt_TagValue_RecordIDInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.DogLicensePage.Txt_TagValue_RecordIDInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value=$RecordID) on item 'ApplicationUnderTest.DogLicensePage.Txt_TagValue_RecordID'.", repo.ApplicationUnderTest.DogLicensePage.Txt_TagValue_RecordIDInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ApplicationUnderTest.DogLicensePage.Txt_TagValue_RecordIDInfo, "Value", RecordID);
            Delay.Milliseconds(0);
            
            // To Verify if the Actual Count Value on the Tile Matched with the count Value represented in the Right Most Bottom of the Selected View
            Report.Log(ReportLevel.Info, "Section", "To Verify if the Actual Count Value on the Tile Matched with the count Value represented in the Right Most Bottom of the Selected View", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "User", "To Verify if the Count Value On the right most bottom of the page matches with the Actual Tile Count", new RecordItemIndex(19));
            
            HelperClass.RetrieveAndVerifyExpectedCountValue(ActualCountValue3);
            Delay.Milliseconds(0);
            
            // To Validate if the Close view Button is visible
            Report.Log(ReportLevel.Info, "Validation", "To Validate if the Close view Button is visible\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.DogLicensePage.Btn_Closeview'.", repo.ApplicationUnderTest.DogLicensePage.Btn_CloseviewInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.ApplicationUnderTest.DogLicensePage.Btn_CloseviewInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DogLicensePage.Btn_Closeview' at Center.", repo.ApplicationUnderTest.DogLicensePage.Btn_CloseviewInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.DogLicensePage.Btn_Closeview.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Table_RecentRecords'", repo.ApplicationUnderTest.HomePage.Table_RecentRecordsInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.HomePage.Table_RecentRecordsInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
