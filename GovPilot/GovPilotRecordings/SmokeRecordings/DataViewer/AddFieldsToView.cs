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
    ///The AddFieldsToView recording.
    /// </summary>
    [TestModule("cdd81c1f-bea3-4ab8-a01c-cf03a19d6d94", ModuleType.Recording, 1)]
    public partial class AddFieldsToView : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static AddFieldsToView instance = new AddFieldsToView();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddFieldsToView()
        {
            DateEnteredView = "yourtext";
            SequenceNum = "yourtext";
            RecordID = "";
            DateEnteredField = "yourtext";
            EditedOn = "yourtext";
            Status = "yourtext";
            FirstName = "yourtext";
            LastName = "yourtext";
            ApplicantAddress = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddFieldsToView Instance
        {
            get { return instance; }
        }

#region Variables

        string _SequenceNum;

        /// <summary>
        /// Gets or sets the value of variable SequenceNum.
        /// </summary>
        [TestVariable("e82b9348-a4ac-4de3-8585-ca8439756d74")]
        public string SequenceNum
        {
            get { return _SequenceNum; }
            set { _SequenceNum = value; }
        }

        string _RecordID;

        /// <summary>
        /// Gets or sets the value of variable RecordID.
        /// </summary>
        [TestVariable("5e97045d-af56-4040-b8e1-8a82f5d9d421")]
        public string RecordID
        {
            get { return _RecordID; }
            set { _RecordID = value; }
        }

        string _DateEnteredField;

        /// <summary>
        /// Gets or sets the value of variable DateEnteredField.
        /// </summary>
        [TestVariable("968617c9-0b8d-4aee-aad9-a3206e598f5d")]
        public string DateEnteredField
        {
            get { return _DateEnteredField; }
            set { _DateEnteredField = value; }
        }

        string _EditedOn;

        /// <summary>
        /// Gets or sets the value of variable EditedOn.
        /// </summary>
        [TestVariable("919c3a6a-505e-407a-88fa-748e02094469")]
        public string EditedOn
        {
            get { return _EditedOn; }
            set { _EditedOn = value; }
        }

        string _Status;

        /// <summary>
        /// Gets or sets the value of variable Status.
        /// </summary>
        [TestVariable("f6829416-c71a-431b-9980-f27caaa54bb1")]
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("961a68cd-9cd2-42d1-be1b-4f5b7252153d")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("5f576098-f940-471a-9a1f-ac0acb937a7f")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _ApplicantAddress;

        /// <summary>
        /// Gets or sets the value of variable ApplicantAddress.
        /// </summary>
        [TestVariable("d469dfdf-23d8-4da0-845b-a27760cad74f")]
        public string ApplicantAddress
        {
            get { return _ApplicantAddress; }
            set { _ApplicantAddress = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DateEnteredView.
        /// </summary>
        [TestVariable("83d79fb8-c2b7-46a2-9337-9a26cc1b09b2")]
        public string DateEnteredView
        {
            get { return repo.DateEnteredView; }
            set { repo.DateEnteredView = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(0));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.BtnSaveAs' at Center.", repo.ApplicationUnderTest.HomePage.BtnSaveAsInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.BtnSaveAs.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtEnterViewName' at Center.", repo.ApplicationUnderTest.HomePage.TxtEnterViewNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.HomePage.TxtEnterViewName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.HomePage.TxtEnterViewName'.", repo.ApplicationUnderTest.HomePage.TxtEnterViewNameInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.HomePage.TxtEnterViewName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DateEnteredView' with focus on 'ApplicationUnderTest.HomePage.TxtEnterViewName'.", repo.ApplicationUnderTest.HomePage.TxtEnterViewNameInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.HomePage.TxtEnterViewName.PressKeys(DateEnteredView);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Save' at Center.", repo.ApplicationUnderTest.HomePage.SaveInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.HomePage.Save.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.HomePage.LinkViewNameCreated'.", repo.ApplicationUnderTest.HomePage.LinkViewNameCreatedInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.HomePage.LinkViewNameCreated.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.HomePage.LinkViewNameCreated'.", repo.ApplicationUnderTest.HomePage.LinkViewNameCreatedInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.HomePage.LinkViewNameCreated.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.BtnFields' at Center.", repo.ApplicationUnderTest.HomePage.BtnFieldsInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.HomePage.BtnFields.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.HideAll' at Center.", repo.ApplicationUnderTest.HomePage.HideAllInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.HomePage.HideAll.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtFindField' at Center.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.HomePage.TxtFindField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SequenceNum' with focus on 'ApplicationUnderTest.HomePage.TxtFindField'.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.HomePage.TxtFindField.PressKeys(SequenceNum);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(13));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.SpanRefNum' at Center.", repo.ApplicationUnderTest.DataViewerGrid.SpanRefNumInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.DataViewerGrid.SpanRefNum.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtFindField' at Center.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.HomePage.TxtFindField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RecordID' with focus on 'ApplicationUnderTest.HomePage.TxtFindField'.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.HomePage.TxtFindField.PressKeys(RecordID);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(17));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.ATagRecordID' at Center.", repo.ApplicationUnderTest.HomePage.ATagRecordIDInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.HomePage.ATagRecordID.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtFindField' at Center.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.HomePage.TxtFindField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DateEnteredField' with focus on 'ApplicationUnderTest.HomePage.TxtFindField'.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.HomePage.TxtFindField.PressKeys(DateEnteredField);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(21));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.DateEnteredField' at Center.", repo.ApplicationUnderTest.HomePage.DateEnteredFieldInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.HomePage.DateEnteredField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtFindField' at Center.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.HomePage.TxtFindField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EditedOn' with focus on 'ApplicationUnderTest.HomePage.TxtFindField'.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.HomePage.TxtFindField.PressKeys(EditedOn);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(25));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.EditOnDate' at Center.", repo.ApplicationUnderTest.DataViewerGrid.EditOnDateInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.DataViewerGrid.EditOnDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtFindField' at Center.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.HomePage.TxtFindField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Status' with focus on 'ApplicationUnderTest.HomePage.TxtFindField'.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.HomePage.TxtFindField.PressKeys(Status);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(29));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.ListItemStatus' at Center.", repo.ApplicationUnderTest.DataViewerGrid.ListItemStatusInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.DataViewerGrid.ListItemStatus.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtFindField' at Center.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.HomePage.TxtFindField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FirstName' with focus on 'ApplicationUnderTest.HomePage.TxtFindField'.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.HomePage.TxtFindField.PressKeys(FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(33));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.ListItem1FirstName' at Center.", repo.ApplicationUnderTest.DataViewerGrid.ListItem1FirstNameInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.DataViewerGrid.ListItem1FirstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtFindField' at Center.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.HomePage.TxtFindField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LastName' with focus on 'ApplicationUnderTest.HomePage.TxtFindField'.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.HomePage.TxtFindField.PressKeys(LastName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(37));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.ListItem1LastName' at Center.", repo.ApplicationUnderTest.DataViewerGrid.ListItem1LastNameInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.DataViewerGrid.ListItem1LastName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.TxtFindField' at Center.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.HomePage.TxtFindField.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ApplicantAddress' with focus on 'ApplicationUnderTest.HomePage.TxtFindField'.", repo.ApplicationUnderTest.HomePage.TxtFindFieldInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.HomePage.TxtFindField.PressKeys(ApplicantAddress);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(41));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.ListItemApplicantAddress' at Center.", repo.ApplicationUnderTest.DataViewerGrid.ListItemApplicantAddressInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.DataViewerGrid.ListItemApplicantAddress.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuppliClickObject' at Center.", repo.SuppliClickObjectInfo, new RecordItemIndex(43));
            repo.SuppliClickObject.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}