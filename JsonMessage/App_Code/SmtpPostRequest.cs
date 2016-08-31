using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SmtpPostRequest
/// </summary>
/// 

public class SmtpPostRequest
{

    //public string To { get; set; }
    public SmtpMessage messages { get; set; }

}


public class SmtpMessage
{

    //public string To { get; set; }
    public StatusRequest Status { get; set; }
    public int SmsCount { get; set; }
    public string MessageId { get; set; }

}

public class StatusRequest
{

    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public int  Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    
}




