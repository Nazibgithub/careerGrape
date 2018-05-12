using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;

/// <summary>
/// Summary description for Sms
/// </summary>
public class Sms
{
    public Sms()
    {
        //
        // TODO: Add constructor logic here
        //
    }
  
    public static bool _NewRegistration(string phno,string Name)
    {
        try
        {
            string strUrl = "";
            //DEAR XXXX , (INFO TO VENDOR/DISTRIBUTOR)A TRAINING HAS BEEN SCHEDULED IN (ONLY VENDOR CITY) ON XXXX PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.
            strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:mukhtar@1986&senderID=EMAGIC&receipientno=" + phno + "&dcs=0&msgtxt=Dear " + Name + " Welcome to EMAGICTOUR Your Registration has been completed successfully. Thank You. Team EMAGICTOUR";

            WebRequest request = HttpWebRequest.Create(strUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream s = (Stream)response.GetResponseStream();
            StreamReader readStream = new StreamReader(s);
            string dataString = readStream.ReadToEnd();
            response.Close();
            s.Close();
            readStream.Close();
            string[] a = dataString.Split(',');
            if (a[0].ToString() == "Status=0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch(Exception ee)
        {
            return false;
        }
    }

    public static bool NewSubscriptionVoice(string phno)
    {
        string strUrl = "";
        //DEAR XXXX , (INFO TO VENDOR/DISTRIBUTOR)A TRAINING HAS BEEN SCHEDULED IN (ONLY VENDOR CITY) ON XXXX PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.
        strUrl = "https://voiceapi.mvaayoo.com/voiceapi/SendVoice?user=mukhtar@ssmaktak.com:pintu786&da=" + phno + "&campaign_name=campaignname&voice_file=Orbiteer_1.wav";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool SubscriptionCompleted(string phno, string pkg)
    {
        string strUrl = "";
        //DEAR XXXX , (INFO TO VENDOR/DISTRIBUTOR)A TRAINING HAS BEEN SCHEDULED IN (ONLY VENDOR CITY) ON XXXX PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR VENDOR, YOUR SUBSCRIPTION IS APPROVED WITH PACKAGE " + pkg + "&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool Training_Schedule(string phno, string vendorName, string city, string Time)
    {
        string strUrl = "";
        //DEAR XXXX , (INFO TO VENDOR/DISTRIBUTOR)A TRAINING HAS BEEN SCHEDULED IN (ONLY VENDOR CITY) ON XXXX PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR " + vendorName + " ,A TRAINING HAS BEEN SCHEDULED IN " + city + " ON " + Time + " PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool LP_Purchase(string phno, string vendorName, string city, string Time)
    {
        string strUrl = "";
        //DEAR XXXX , WE HAVE PURCHASED YOUR LOYALTY POINTS. PLS CHECK YOUR BANK A/C . ACCNTS.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR " + vendorName + " ,WE HAVE PURCHASED YOUR LOYALTY POINTS.." + city + " PLS CHECK YOUR BANK A/C . ACCNTS.&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool Achieved(string phno, string vendorName, string achieved)
    {
        string strUrl = "";
        //DEAR XXXX , CONGRATULATION!! YOU HAVE ACHIEVED XXXXXXX. THANKS, VENDOR DEPT.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR " + vendorName + " ,CONGRATULATION!! YOU HAVE ACHIEVED " + achieved + " THANKS, VENDOR DEPT.&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool LOYALTY_POINTS(string phno, string vendorName, string lp)
    {
        string strUrl = "";
        // DEAR XXXX , YOUR TOTAL AVBL. LOYALTY POINTS’ BAL IS XXXX ON DD/MM. ACCNTS.

        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR " + vendorName + " , YOUR TOTAL AVBL. LOYALTY POINTS’ BAL IS " + lp + " ON DD/MM. ACCNTS.&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool RECEIVED_LOYALTY_POINTS(string phno, string vendorName, string lp)
    {
        string strUrl = "";
        //DEAR XXXX ,YOU HAVE RECEIVED XXXX LOYALTY POINTS. THANKS, ACCNTS.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR " + vendorName + " , YOU HAVE RECEIVED " + lp + " LOYALTY POINTS. THANKS, ACCNTS.&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool TRANSACTION_CODE(string phno, string vendorName, string code)
    {
        string strUrl = "";
        //DEAR XXXX , YOUR TRXN CODE IS XXXX PLS DO NOT SHARE THIS SENSITIVE INFO WITH ANYONE.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR " + vendorName + " ,YOUR TRXN CODE IS " + code + " PLS DO NOT SHARE THIS SENSITIVE INFO WITH ANYONE.&state=4 ";
        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

  

    public static bool ENQUIRY(string phno, string vendorName, string city, string Time, string achieved, string lp, string code, int cond)
    {
        string strUrl = "";

        //DEAR XXXX , THANKS FOR YOUR ENQUIRY. OUR TEAM WILL CONTACT YOU SOON. ORBIT9X.

        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR " + vendorName + " ,THANKS FOR YOUR ENQUIRY. OUR TEAM WILL CONTACT YOU SOON. ORBIT9X.&state=4 ";


        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool ForgotPassword(string phno)
    {
        string strUrl = "";
        //DEAR XXXX , (INFO TO VENDOR/DISTRIBUTOR)A TRAINING HAS BEEN SCHEDULED IN (ONLY VENDOR CITY) ON XXXX PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=Dear Vendor, We have sent a password reset link at your email address. Please click on the link to reset your password. Orbit9X&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool ChangedPassword(string phno)
    {
        string strUrl = "";
        //DEAR XXXX , (INFO TO VENDOR/DISTRIBUTOR)A TRAINING HAS BEEN SCHEDULED IN (ONLY VENDOR CITY) ON XXXX PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=Dear Vendor, Your password changed successfully.&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool SubscriptionReject(string phno)
    {
        string strUrl = "";
        //DEAR XXXX , (INFO TO VENDOR/DISTRIBUTOR)A TRAINING HAS BEEN SCHEDULED IN (ONLY VENDOR CITY) ON XXXX PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=DEAR VENDOR, THE TRANSACTION PROCESS IS INCOMPLETE PLEASE CHECK YOUR MAIL AND DO THE NEEDFUL.&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool ForgotPassword1(string phno)
    {
        string strUrl = "";
        //DEAR XXXX , (INFO TO VENDOR/DISTRIBUTOR)A TRAINING HAS BEEN SCHEDULED IN (ONLY VENDOR CITY) ON XXXX PLS. BUY YOUR PASS ASAP. TRAINGING DEPT.
        strUrl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=mukhtar@ssmaktak.com:pintu786&senderID=ORBITM&receipientno=" + phno + "&dcs=0&msgtxt=Dear Vendor, We have sent a password reset link to your email address. Click on the link to reset your Transaction Password.&state=4 ";

        WebRequest request = HttpWebRequest.Create(strUrl);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream s = (Stream)response.GetResponseStream();
        StreamReader readStream = new StreamReader(s);
        string dataString = readStream.ReadToEnd();
        response.Close();
        s.Close();
        readStream.Close();
        string[] a = dataString.Split(',');
        if (a[0].ToString() == "Status=0")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}