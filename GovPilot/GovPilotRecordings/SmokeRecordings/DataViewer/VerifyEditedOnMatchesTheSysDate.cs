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
    ///The VerifyEditedOnMatchesTheSysDate recording.
    /// </summary>
    [TestModule("cf0c08d3-340a-4b02-b026-5aefed102624", ModuleType.Recording, 1)]
    public partial class VerifyEditedOnMatchesTheSysDate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static VerifyEditedOnMatchesTheSysDate instance = new VerifyEditedOnMatchesTheSysDate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyEditedOnMatchesTheSysDate()
        {
            EditedOnGenerated = "";
            EditedOnGrid = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyEditedOnMatchesTheSysDate Instance
        {
            get { return instance; }
        }

#region Variables

        string _EditedOnGenerated;

        /// <summary>
        /// Gets or sets the value of variable EditedOnGenerated.
        /// </summary>
        [TestVariable("28fa1f78-8e99-49e3-8fce-9b96e865105d")]
        public string EditedOnGenerated
        {
            get { return _EditedOnGenerated; }
            set { _EditedOnGenerated = value; }
        }

        string _EditedOnGrid;

        /// <summary>
        /// Gets or sets the value of variable EditedOnGrid.
        /// </summary>
        [TestVariable("5acdd2cb-d327-4421-8201-0ccc0d7267e7")]
        public string EditedOnGrid
        {
            get { return _EditedOnGrid; }
            set { _EditedOnGrid = value; }
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

            Get_value_ValueEditedOnDate(repo.ApplicationUnderTest.DataViewerGrid.ValueEditedOnDateInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.DataViewerGrid.ValueEditedOnDate' and assigning its value to variable 'EditedOnGrid'.", repo.ApplicationUnderTest.DataViewerGrid.ValueEditedOnDateInfo, new RecordItemIndex(1));
            EditedOnGrid = repo.ApplicationUnderTest.DataViewerGrid.ValueEditedOnDate.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", EditedOnGrid, new RecordItemIndex(2));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}