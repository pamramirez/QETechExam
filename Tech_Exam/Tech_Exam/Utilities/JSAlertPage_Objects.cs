using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exam.PageObjects.JavaScript
{
    class JSAlertPage_Objects
    {
        public String urlJS = "https://the-internet.herokuapp.com/javascript_alerts";
        public String hdrJavaScript = "#content > div > h3";
        public String btnJSAlert = "#content > div > ul > li:nth-child(1) > button";
        public String btnJSConfirm = "#content > div > ul > li:nth-child(2) > button";
        public String btnJSPrompt = "#content > div > ul > li:nth-child(3) > button";
        public String hdrResultMsg = "result";
    }
}
