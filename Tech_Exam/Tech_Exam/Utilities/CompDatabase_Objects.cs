using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exam.Utilities
{
    class CompDatabase_Objects
    {
        public String computer_database_url = "http://computer-database.gatling.io/computers";
        public String btnAddNewComp = "add";
        public String lnkHome = "./html/body/header/h1/a";
        public String txtSearchName = "searchbox";
        public String btnFilterName = "searchsubmit";
        public String hdrMessage = "#main > h1";

        public String hdrTxtAdd = "Add a computer";
        public String hdrTxtEdit = "Edit computer";
        public String txtCompName = "name";
        public String txtIntroDate = "introduced";
        public String txtDiscDate = "discontinued";
        public String drpCompany = "company";
        public String btnSave = "#main > form > div > input";
        public String btnCancel = "#main > form > div > a";
        public String btnDelete = "#main > form.topRight > input";
        public String txtFailIntroDate = "#main > form:nth-child(2) > fieldset > div:nth-child(2)";
        public String txtFailDiscoDate = "#main > form:nth-child(2) > fieldset > div:nth-child(3)";
        public String txtFailDate = "clearfix error";
        public String tblResults = "computers";
        public String btnPrevious = "#pagination > ul > li.prev > a";
        public String btnNext = "#pagination > ul > li.next > a";
    }
}
