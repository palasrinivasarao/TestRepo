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
    ///The FetchLastEnteredRecordID recording.
    /// </summary>
    [TestModule("6260b7e8-6312-40c2-89fd-11ea0c7277e3", ModuleType.Recording, 1)]
    public partial class FetchLastEnteredRecordID : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static FetchLastEnteredRecordID instance = new FetchLastEnteredRecordID();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FetchLastEnteredRecordID()
        {
            LastRecordIDPresent = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FetchLastEnteredRecordID Instance
        {
            get { return instance; }
        }

#region Variables

        string _LastRecordIDPresent;

        /// <summary>
        /// Gets or sets the value of variable LastRecordIDPresent.
        /// </summary>
        [TestVariable("f0ea7bcf-bf99-469f-9a24-bf5bfef42e7b")]
        public string LastRecordIDPresent
        {
            get { return _LastRecordIDPresent; }
            set { _LastRecordIDPresent = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SuppliClickObject' at Center.", repo.SuppliClickObjectInfo, new RecordItemIndex(0));
            repo.SuppliClickObject.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.LogsScreen.TdRecordIDNew' and assigning its value to variable 'LastRecordIDPresent'.", repo.ApplicationUnderTest.LogsScreen.TdRecordIDNewInfo, new RecordItemIndex(1));
            LastRecordIDPresent = repo.ApplicationUnderTest.LogsScreen.TdRecordIDNew.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", LastRecordIDPresent, new RecordItemIndex(2));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}