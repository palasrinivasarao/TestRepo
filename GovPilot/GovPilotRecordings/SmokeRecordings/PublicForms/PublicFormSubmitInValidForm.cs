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

namespace GovPilot.GovPilotRecordings.SmokeRecordings.PublicForms
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PublicFormSubmitInValidForm recording.
    /// </summary>
    [TestModule("d3a85d5a-31a9-494d-afe5-133316de5aed", ModuleType.Recording, 1)]
    public partial class PublicFormSubmitInValidForm : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static PublicFormSubmitInValidForm instance = new PublicFormSubmitInValidForm();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PublicFormSubmitInValidForm()
        {
            SearchByProperty = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PublicFormSubmitInValidForm Instance
        {
            get { return instance; }
        }

#region Variables

        string _SearchByProperty;

        /// <summary>
        /// Gets or sets the value of variable SearchByProperty.
        /// </summary>
        [TestVariable("5cb06b85-6a02-4164-a1f7-730befffe1c5")]
        public string SearchByProperty
        {
            get { return _SearchByProperty; }
            set { _SearchByProperty = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 12s.", new RecordItemIndex(0));
            Delay.Duration(12000, false);
            
            // Click on Search By Property
            Report.Log(ReportLevel.Info, "Mouse", "Click on Search By Property\r\nMouse Left Click item 'ApplicationUnderTest.PublicForms.Input_text_SearchByPropertyIdentifier' at Center.", repo.ApplicationUnderTest.PublicForms.Input_text_SearchByPropertyIdentifierInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.PublicForms.Input_text_SearchByPropertyIdentifier.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(2));
            Delay.Duration(2000, false);
            
            // Enter the property address
            Report.Log(ReportLevel.Info, "Keyboard", "Enter the property address\r\nKey sequence from variable '$SearchByProperty' with focus on 'ApplicationUnderTest.PublicForms.Input_text_SearchByPropertyIdentifier'.", repo.ApplicationUnderTest.PublicForms.Input_text_SearchByPropertyIdentifierInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.PublicForms.Input_text_SearchByPropertyIdentifier.PressKeys(SearchByProperty);
            Delay.Milliseconds(0);
            
            // Delay
            Report.Log(ReportLevel.Info, "Delay", "Delay\r\nWaiting for 5s.", new RecordItemIndex(4));
            Delay.Duration(5000, false);
            
            // Select the address
            Report.Log(ReportLevel.Info, "Keyboard", "Select the address\r\nKey sequence '{Down}'.", new RecordItemIndex(5));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            // Click on Enter
            Report.Log(ReportLevel.Info, "Keyboard", "Click on Enter\r\nKey sequence '{Enter}'.", new RecordItemIndex(6));
            Keyboard.Press("{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'ApplicationUnderTest.PublicForms.Input_text_FirstName'.", repo.ApplicationUnderTest.PublicForms.Input_text_FirstNameInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.PublicForms.Input_text_FirstName.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'ApplicationUnderTest.PublicForms.Btn_Submit'.", repo.ApplicationUnderTest.PublicForms.Btn_SubmitInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.PublicForms.Btn_Submit.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.PublicForms.Btn_Submit'.", repo.ApplicationUnderTest.PublicForms.Btn_SubmitInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.PublicForms.Btn_Submit.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.PublicForms.Validate_Error_Message'", repo.ApplicationUnderTest.PublicForms.Validate_Error_MessageInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.PublicForms.Validate_Error_MessageInfo.WaitForAttributeEqual(40000, "Visible", "True");
            
            // Validating Error Message is displayed or not
            Report.Log(ReportLevel.Info, "Validation", "Validating Error Message is displayed or not\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.PublicForms.Validate_Error_Message'.", repo.ApplicationUnderTest.PublicForms.Validate_Error_MessageInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PublicForms.Validate_Error_MessageInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            // Validating missing fields are listed.
            Report.Log(ReportLevel.Info, "Validation", "Validating missing fields are listed.\r\nValidating AttributeEqual (InnerText='Missing or invalid fields are found, click on each field on the list shown to correct:') on item 'ApplicationUnderTest.PublicForms.Validate_Missing_Fields'.", repo.ApplicationUnderTest.PublicForms.Validate_Missing_FieldsInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PublicForms.Validate_Missing_FieldsInfo, "InnerText", "Missing or invalid fields are found, click on each field on the list shown to correct:");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
