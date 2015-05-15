using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Sign_Amazon_Integration.Properties;

namespace Sign_Amazon_Integration
{

    public partial class Form1 : Form
    {
        private const string SignatureAlgorithm = "HmacSHA256";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetEnvironment(Environment.Production);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client_signature.Text = Sign();
        }

        private void SetEnvironment(Environment environment)
        {
            switch (environment)
            {
                case Environment.Dev:
                    request_host.Text = Resources.dev_api_host;
                    secret_key.Text = Resources.dev_secret_key;
                    request_host.ReadOnly = false;
                    break;
                case Environment.Local:
                    request_host.Text = Resources.local_api_host;
                    secret_key.Text = Resources.local_secret_key;
                    request_host.ReadOnly = true;
                    break;
                case Environment.Uat:
                    request_host.Text = Resources.uat_api_host;
                    secret_key.Text = Resources.uat_secret_key;
                    request_host.ReadOnly = true;
                    break;
                case Environment.Qa:
                    request_host.Text = Resources.qa_api_host;
                    secret_key.Text = Resources.qa_secret_key;
                    request_host.ReadOnly = true;
                    break;
                case Environment.Production:
                    request_host.Text = Resources.prod_api_host;
                    secret_key.Text = Resources.prod_secret_key;
                    request_host.ReadOnly = true;
                    break;
            }
        }

        private string Sign()
        {
            HMAC hmac = HMAC.Create(SignatureAlgorithm);
            hmac.Key = Convert.FromBase64String(secret_key.Text);
            string signMessage = ConstructToBeSignedMessage();
            byte[] bytes = hmac.ComputeHash(Encoding.GetEncoding("UTF-8").GetBytes(signMessage));
            return Convert.ToBase64String(bytes);
        }

        private string ConstructToBeSignedMessage()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("uri=").Append(request_host.Text).Append(request_url.Text).Append('&');
            builder.Append("method=").Append(method_get.Checked ? "GET" : "POST").Append('&');
            builder.Append("body=").Append(request_body.Text);

            return builder.ToString();
        }

        private void env_local_CheckedChanged(object sender, EventArgs e)
        {
            SetEnvironment(Environment.Local);
        }

        private void env_uat_CheckedChanged(object sender, EventArgs e)
        {
            SetEnvironment(Environment.Uat);
        }

        private void env_qa_CheckedChanged(object sender, EventArgs e)
        {
            SetEnvironment(Environment.Qa);
        }

        private void env_prod_CheckedChanged(object sender, EventArgs e)
        {
            SetEnvironment(Environment.Production);
        }

        private void env_dev_CheckedChanged(object sender, EventArgs e)
        {
            SetEnvironment(Environment.Dev);
        }

        private void request_host_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action) (() => request_host.SelectAll()));
        }

        private void secret_key_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => secret_key.SelectAll()));
        }

        private void request_url_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => request_url.SelectAll()));
        }

        private void request_body_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => request_body.SelectAll()));
        }

        private void request_id_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => request_id.SelectAll()));
        }

        private void client_signature_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() => client_signature.SelectAll()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            request_id.Text = Guid.NewGuid().ToString();
        }
    }

    internal enum Environment
    {
        Dev,
        Local,
        Uat,
        Qa,
        Production
    };

}

