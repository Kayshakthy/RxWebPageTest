﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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

namespace WebPageTest
{
    public partial class VFWebTest
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void NavigateVFPage()
        {
        	 Ranorex.WebDocument doc = Host.Local.FindSingle("/dom[@domain='www.virginmedia.com']");
        	
        	//Ranorex.WebDocument doc= Host.Local.FindSingle("/dom[@childIndex='1']");
        	//doc.Navigate("http://www.twitter.com" class="postlink">http://www.twitter.com");  
        	 doc.Navigate("https://www.vodafone.com/",true);
        	 Delay.Seconds(10);
        	          
        }

    }
}