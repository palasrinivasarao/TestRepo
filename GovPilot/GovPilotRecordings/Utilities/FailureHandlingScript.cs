/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 6/3/24
 * Time: 12:28
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace GovPilot
{
    /// <summary>
    /// Description of FailureHandlingScript.
    /// </summary>
    [TestModule("DFBE9C54-B135-4317-8AF9-4D9C45A03893", ModuleType.UserCode, 1)]
    public class FailureHandlingScript : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        GovPilotRepository repo = GovPilotRepository.Instance;
       
        	 string _FailureUsername = "rvinothini_admin@jackson";
        [TestVariable("b9885320-494e-44de-a6c1-d59b5464945f")]
        public string FailureUsername
        {
        	get { return _FailureUsername; }
        	set { _FailureUsername = value; }
        }
        
         string _FailurePassword = "jackson";
        [TestVariable("9658d98e-fa47-4ddc-88fe-b5202938180e")]
        public string FailurePassword
        {
        	get { return _FailurePassword; }
        	set { _FailurePassword = value; }
        }
        
              
         public FailureHandlingScript()
        {
            // Do not delete - a parameterless constructor is required!
            
        }       
      
        
       public void ExecuteFailureHandlingScript() {
        	
        
            //Click LogOut dropdown
            Delay.Milliseconds(1000);
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.DrpDwnLogOut' at Center.", repo.ApplicationUnderTest.HomePage.DrpDwnLogOutInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.DrpDwnLogOut.Click();
            Delay.Milliseconds(1000);
            //Click LogOut button
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.BtnLogOut' at Center.", repo.ApplicationUnderTest.HomePage.BtnLogOutInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.HomePage.BtnLogOut.Click();
            Delay.Milliseconds(1000);
            //Click into Username field
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginPage.Username' at Center.", repo.ApplicationUnderTest.LoginPage.UsernameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.LoginPage.Username.Click();
            Delay.Milliseconds(1000);
            //Ctrl+A into Username Field
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.LoginPage.Username'.", repo.ApplicationUnderTest.LoginPage.UsernameInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.LoginPage.Username);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(1000);
            //EnterUsername
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Username' with focus on 'ApplicationUnderTest.LoginPage.Username'.", repo.ApplicationUnderTest.LoginPage.UsernameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LoginPage.Username.PressKeys(FailureUsername);
            Delay.Milliseconds(2000);
            //Click into Password Field
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LoginPage.Password' at CenterLeft.", repo.ApplicationUnderTest.LoginPage.PasswordInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.LoginPage.Password.Click(Location.CenterLeft);
            Delay.Milliseconds(0);
            //Ctrl+A into Password Field
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.LoginPage.Password'.", repo.ApplicationUnderTest.LoginPage.PasswordInfo, new RecordItemIndex(5));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.LoginPage.Password);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            //EnterPassword
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Password' with focus on 'ApplicationUnderTest.LoginPage.Password'.", repo.ApplicationUnderTest.LoginPage.PasswordInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.LoginPage.Password.PressKeys(FailurePassword);
            Delay.Milliseconds(2000);
            //Press Tab Key Once
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(9));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(1000);
            //Click Login
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.LoginPage.BtnLogin'.", repo.ApplicationUnderTest.LoginPage.BtnLoginInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.LoginPage.BtnLogin.PerformClick();
            Delay.Milliseconds(0);
            
            }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
                     
            
        }
         }
    }

