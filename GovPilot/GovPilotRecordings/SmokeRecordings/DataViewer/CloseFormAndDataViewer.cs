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
    ///The CloseFormAndDataViewer recording.
    /// </summary>
    [TestModule("657c471a-2363-4723-b336-77eeae206c28", ModuleType.Recording, 1)]
    public partial class CloseFormAndDataViewer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static CloseFormAndDataViewer instance = new CloseFormAndDataViewer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseFormAndDataViewer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseFormAndDataViewer Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.CloseXCloseTab' at Center.", repo.ApplicationUnderTest.Property.CloseXCloseTabInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Property.CloseXCloseTab.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.CloseDataViewer' at Center.", repo.ApplicationUnderTest.DataViewerGrid.CloseDataViewerInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.DataViewerGrid.CloseDataViewer.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
