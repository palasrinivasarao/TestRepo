/*
 * Created by Ranorex
 * User: ZahidUmarShah
 * Date: 4/22/24
 * Time: 22:57
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
    /// Description of LoadConfigData.
    /// </summary>
    [TestModule("0809F601-D581-43D1-BCC0-A74B2C9CB652", ModuleType.UserCode, 1)]
    public class LoadConfigData : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoadConfigData()
        {
            // Do not delete - a parameterless constructor is required!
            
            Password = "";
            Username = "";
            url = "";
            browser = "";
        }
        
        
        string _Password = "";
        [TestVariable("cf965aaa-97a7-4f99-b876-531855c68e0b")]
        public string Password
        {
        	get { return _Password; }
        	set { _Password = value; }
        }
        
        string _Username = "";
        [TestVariable("58b453e2-65e7-4d56-9121-c14cd2e00281")]
        public string Username
        {
        	get { return _Username; }
        	set { _Username = value; }
        }     
          
		string _url = "";
       [TestVariable("939d42a1-f0e8-4737-bbb6-ea528ddf43e3")]
       public string url

		{
			get { return _url; }
			set { _url = value; }
		} 
		       
		
		string _browser = "";
		[TestVariable("ca2333ac-7c2e-497b-b408-545247601884")]
		public string browser
		{
			get { return _browser; }
			set { _browser = value; }
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
            
            if(Username.ToString().Equals(""))
				{
					Username = HelperClass.GetConfigurationValue("Username");
					TestSuite.Current.Parameters["Username"] = Username;
					Delay.Milliseconds(0);
				}
				
				if(Password.ToString().Equals(""))
				{
					Password = HelperClass.GetConfigurationValue("Password");
					TestSuite.Current.Parameters["Password"] = Password;
					Delay.Milliseconds(0);
				}
				if(url.ToString().Equals(""))
				{
					url = HelperClass.GetConfigurationValue("url");
					TestSuite.Current.Parameters["url"] = url;
					Delay.Milliseconds(0);
				}
				
				if(browser.ToString().Equals(""))
				{
					browser = HelperClass.GetConfigurationValue("browser");
					TestSuite.Current.Parameters["browser"] = browser;
					Delay.Milliseconds(0);
				}
        }
    }
}
