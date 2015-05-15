using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ViewState["NameOfUser"] != null)
            NameLabel.Text = ViewState["NameOfUser"].ToString();
        else
            NameLabel.Text = "Not set yet...";
    }

    protected void SubmitForm_OnClick(object sender, EventArgs e)
    {
        ViewState["NameOfUser"] = NameField.Text;
        NameLabel.Text = NameField.Text;
    }

    protected void SendMail_OnClick(object sender, EventArgs e)
    {
        try
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add("gordon.lin@suryani.cn");
            mailMessage.From = new MailAddress("gordon.lin@suryani.cn");
            mailMessage.Subject = "ASP.NET e-mail test";
            mailMessage.Body = "Hello world,\n\nThis is an ASP.NET test e-mail!";
            SmtpClient smtpClient = new SmtpClient("mail.suryani.cn");
            smtpClient.Send(mailMessage);
            NameLabel.Text = "E-mail sent!";
        }
        catch (Exception ex)
        {
            NameLabel.Text = "Could not send the e-mail: " + ex.Message;
        }
    }

    protected void UploadButton_OnClick(object sender, EventArgs e)
    {
        if (FileUploadControl.HasFile)
        {
            try
            {
                if (FileUploadControl.PostedFile.ContentType == "image/jpeg")
                {
                    if (FileUploadControl.PostedFile.ContentLength < 102400)
                    {
                        string filename = Path.GetFileName(FileUploadControl.FileName);
                        FileUploadControl.SaveAs(Server.MapPath("~/") + filename);
                        NameLabel.Text = "Upload status: File uploaded!";
                    }
                    else
                        NameLabel.Text = "Upload status: The file has to be less than 100 kb!";
                }
                else
                    NameLabel.Text = "Upload status: Only JPEG file are accepted!";
            }
            catch (Exception ex)
            {
                NameLabel.Text = "Upload status: File could not be uploaded. " + ex.Message;
                throw;
            }
        }
    }
}