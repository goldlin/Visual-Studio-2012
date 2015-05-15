using System;
using System.Web;
using System.Windows.Forms;
using Cryptography_and_Encrypt.Properties;
using Cryptography_and_Encrypt.Util;


namespace Cryptography_and_Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Decrypted_str.Text = CryptographyUtility.DecryptString(Encrypted_str.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Encrypted_str.Text = CryptographyUtility.EncryptString(Decrypted_str.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Switch_it_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Test_str.Text))
            {
                Visitor_id.Text = string.Empty;
                Mobile_vid.Text = string.Empty;
                WWW_vid.Text = string.Empty;
                return;
            }
            Guid guid;
            // raw visitor id
            if (Guid.TryParse(Test_str.Text, out guid))
            {
                Visitor_id.Text = Test_str.Text;
                do
                {
                    Mobile_vid.Text = CryptographyUtility.EncryptString(Test_str.Text);
                } while (Mobile_vid.Text.Contains("+"));
                WWW_vid.Text = HttpUtility.UrlDecode(VisitorEncryptor.EncryptVisitorId(guid, DataConvert.TryToInt(Visitor_token_timeout.Text)));
                return;
            }
            // mobile encrypted visitor id
            string rawVisitorId;
            try
            {
                rawVisitorId = CryptographyUtility.DecryptString(Test_str.Text);
            }
            catch (Exception)
            {
                rawVisitorId = string.Empty;
            }
            if (Guid.TryParse(rawVisitorId, out guid))
            {
                Visitor_id.Text = guid.ToString();
                Mobile_vid.Text = Test_str.Text;
                WWW_vid.Text = HttpUtility.UrlDecode(VisitorEncryptor.EncryptVisitorId(guid, DataConvert.TryToInt(Visitor_token_timeout.Text)));
                return;
            }
            // www encrypted visitor id
            DeEncryptResult deEncryptResult = VisitorEncryptor.DeEncryptVisitorId(Test_str.Text);
            switch (deEncryptResult.Status)
            {
                case DeEncryptStatus.Ok:
                case DeEncryptStatus.Expired:
                    Visitor_id.Text = deEncryptResult.VisitorId.ToString();
                    do
                    {
                        Mobile_vid.Text = CryptographyUtility.EncryptString(Visitor_id.Text);
                    } while (Mobile_vid.Text.Contains("+"));
                    WWW_vid.Text = Test_str.Text;
                    break;
                case DeEncryptStatus.InvalidFormat:
                    Visitor_id.Text = Mobile_vid.Text = WWW_vid.Text = Resources.Result_Invalid_format_;
                    break;
            }
        }

        private void Url_decode_Click(object sender, EventArgs e)
        {
            Test_str.Text = HttpUtility.UrlDecode(Test_str.Text);
        }

        private void Encrypted_str_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => Encrypted_str.SelectAll()));
        }

        private void Visitor_id_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => Visitor_id.SelectAll()));
        }

        private void Decrypted_str_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => Decrypted_str.SelectAll()));
        }

        private void Test_str_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => Test_str.SelectAll()));
        }

        private void Visitor_token_timeout_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => Visitor_token_timeout.SelectAll()));
        }

        private void Mobile_vid_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => Mobile_vid.SelectAll()));
        }

        private void WWW_vid_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => WWW_vid.SelectAll()));
        }
    }
}

