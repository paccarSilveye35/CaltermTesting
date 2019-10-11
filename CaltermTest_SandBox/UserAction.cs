/*
 * Created by Ranorex
 * User: edgar.silveyra
 * Date: 10/10/2019
 * Time: 10:06 AM
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
using System.Diagnostics;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace CaltermTest_SandBox
{
    /// <summary>
    /// Description of UserAction.
    /// </summary>
    [TestModule("D35B0AAA-4B88-4C3E-AD94-D648A5242E92", ModuleType.UserCode, 1)]
    public class UserAction : ITestModule
    {
    	public static CaltermTest_SandBoxRepository repo = CaltermTest_SandBoxRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserAction()
        {
            // Do not delete - a parameterless constructor is required!
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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;
            
            if(repo.ManualConnect.ButtonOkInfo.Exists()) {
            	Report.Success("Message", "ButtonOkInfo exists");
            	Delay.Milliseconds(10000);
            } else {
            	Report.Success("Message", "ButtonOkInfo DOES NOT exists");
            	Delay.Milliseconds(10000);
            }
            Report.Success("Message", "--------------------------------Check-----------------------");
            
            if(3==4) {
            	Report.Failure("Message", "3!=4");
            } else {
            	Report.Failure("Message", "idk what's going on");
            }
            
            Report.Success("message", "Checkpoint");
            Delay.Milliseconds(6000);
            
            if(repo.ManualConnect.ButtonOkInfo.Exists()) {
            	Report.Success("Message", "ButtonOkInfo exists");
            	Delay.Milliseconds(10000);
            } else if(!repo.ManualConnect.ButtonOkInfo.Exists()) {
            	Report.Success("Message", "ButtonOkInfo DOES NOT exists");
            	Delay.Milliseconds(10000);
            } else {
            	Report.Failure("Message", "Didn't even check");
            	Delay.Milliseconds(5000);
            }
            
            Report.Success("message", "Checkpoint");
            Delay.Milliseconds(6000);
                   
    	}
    }
}
