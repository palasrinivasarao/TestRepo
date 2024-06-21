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
    ///The CloseApplicantAddressFilter recording.
    /// </summary>
    [TestModule("f44df1ba-b893-48b7-b49b-3411cc007ae8", ModuleType.Recording, 1)]
    public partial class CloseApplicantAddressFilter : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static CloseApplicantAddressFilter instance = new CloseApplicantAddressFilter();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseApplicantAddressFilter()
        {
            Applicant_Address = "678 brewers bridge rd";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseApplicantAddressFilter Instance
        {
            get { return instance; }
        }

#region Variables

        string _Applicant_Address;

        /// <summary>
        /// Gets or sets the value of variable Applicant_Address.
        /// </summary>
        [TestVariable("1293c04c-0727-4948-8486-aa9bb7fdb8c8")]
        public string Applicant_Address
        {
            get { return _Applicant_Address; }
            set { _Applicant_Address = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.Click_Filters' at Center.", repo.ApplicationUnderTest.Property.Click_FiltersInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Property.Click_Filters.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.Property.ValidationAddress'.", repo.ApplicationUnderTest.Property.ValidationAddressInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Property.ValidationAddress.EnsureVisible();
            Delay.Milliseconds(0);
            
            // Verifying address was displayed in PHYSICAL ADDRESS INFORMATION
            Report.Log(ReportLevel.Info, "Validation", "Verifying address was displayed in PHYSICAL ADDRESS INFORMATION\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.Property.ValidationAddress'.", repo.ApplicationUnderTest.Property.ValidationAddressInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Property.ValidationAddressInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.Click_Filters' at Center.", repo.ApplicationUnderTest.Property.Click_FiltersInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Property.Click_Filters.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.CloseFilter' at Center.", repo.ApplicationUnderTest.Property.CloseFilterInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Property.CloseFilter.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.IconHome' at Center.", repo.ApplicationUnderTest.HomePage.IconHomeInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.HomePage.IconHome.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(9));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.Search_DogLicense' at Center.", repo.ApplicationUnderTest.Property.Search_DogLicenseInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Property.Search_DogLicense.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.Property.Search_DogLicense'.", repo.ApplicationUnderTest.Property.Search_DogLicenseInfo, new RecordItemIndex(11));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.Property.Search_DogLicense);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'ApplicationUnderTest.Property.Search_DogLicense'.", repo.ApplicationUnderTest.Property.Search_DogLicenseInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.Property.Search_DogLicense);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Applicant_Address' with focus on 'ApplicationUnderTest.Property.Search_DogLicense'.", repo.ApplicationUnderTest.Property.Search_DogLicenseInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Property.Search_DogLicense.PressKeys(Applicant_Address);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Property.Search_DogLicense'.", repo.ApplicationUnderTest.Property.Search_DogLicenseInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Property.Search_DogLicense.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            // Validating applicant address was displayed
            Report.Log(ReportLevel.Info, "Validation", "Validating applicant address was displayed\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.Property.Validation_ApplicantAddress'.", repo.ApplicationUnderTest.Property.Validation_ApplicantAddressInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Property.Validation_ApplicantAddressInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(16));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Applicant_Address) on item 'ApplicationUnderTest.Property.Validation_ApplicantAddress'.", repo.ApplicationUnderTest.Property.Validation_ApplicantAddressInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Property.Validation_ApplicantAddressInfo, "InnerText", Applicant_Address);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}