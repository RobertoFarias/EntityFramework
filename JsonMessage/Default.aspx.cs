using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        //string json = "{ 'Title':'Company Ltd','Employees':[{'Name':'Mark CEO','EmployeeType':0},{'Name':'Matija Božičević','EmployeeType':1},{'Name':'Steve Developer','EmployeeType':1}]}";

        //Company company = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Company>(json);


        string json = "{'messages':[{'to':'5511949648002','status':{'groupId':1,'groupName':'PENDING','id':7,'name':'PENDING_ENROUTE','description':'Message sent to next instance'},'smsCount':1,'messageId':'36a0d237-bdf5-4999-a3c1-6b36d259aa54'}]}"  ;

        json = json. Replace("[","");
        json = json.Replace("]", "");

        SmtpPostRequest request = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<SmtpPostRequest>(json);

    }
}