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
    ///The ValidateRemovedFilters recording.
    /// </summary>
    [TestModule("b3fe178c-c762-44f0-9a75-8a45cd2580de", ModuleType.Recording, 1)]
    public partial class ValidateRemovedFilters : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static ValidateRemovedFilters instance = new ValidateRemovedFilters();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateRemovedFilters()
        {
            CompareRecordID = "yourValue";
            CompareAddress = "yourValue";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateRemovedFilters Instance
        {
            get { return instance; }
        }

#region Variables

        string _CompareRecordID;

        /// <summary>
        /// Gets or sets the value of variable CompareRecordID.
        /// </summary>
        [TestVariable("188b4bb8-7ba2-4b61-8198-05abf2fa0514")]
        public string CompareRecordID
        {
            get { return _CompareRecordID; }
            set { _CompareRecordID = value; }
        }

        string _CompareAddress;

        /// <summary>
        /// Gets or sets the value of variable CompareAddress.
        /// </summary>
        [TestVariable("b2aad6f0-c860-4f15-a321-268a2f9f4c84")]
        public string CompareAddress
        {
            get { return _CompareAddress; }
            set { _CompareAddress = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            // Validating that Record ID does not match the Record ID filtered earlier
            Report.Log(ReportLevel.Info, "Validation", "Validating that Record ID does not match the Record ID filtered earlier\r\nValidating AttributeNotEqual (InnerText!=$CompareRecordID) on item 'ApplicationUnderTest.DataViewerGrid.TDTopMostRecordID'.", repo.ApplicationUnderTest.DataViewerGrid.TDTopMostRecordIDInfo, new RecordItemIndex(1));
            Validate.AttributeNotEqual(repo.ApplicationUnderTest.DataViewerGrid.TDTopMostRecordIDInfo, "InnerText", CompareRecordID);
            Delay.Milliseconds(0);
            
            // Validating that address does not match the address filtered earlier
            Report.Log(ReportLevel.Info, "Validation", "Validating that address does not match the address filtered earlier\r\nValidating AttributeNotEqual (InnerText!=$CompareAddress) on item 'ApplicationUnderTest.DataViewerGrid.TDTopMostAddress'.", repo.ApplicationUnderTest.DataViewerGrid.TDTopMostAddressInfo, new RecordItemIndex(2));
            Validate.AttributeNotEqual(repo.ApplicationUnderTest.DataViewerGrid.TDTopMostAddressInfo, "InnerText", CompareAddress);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
