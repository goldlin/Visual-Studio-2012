namespace Sign_Amazon_Integration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.request_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.method_get = new System.Windows.Forms.RadioButton();
            this.method_post = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.request_body = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.request_id = new System.Windows.Forms.TextBox();
            this.client_signature = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.secret_key = new System.Windows.Forms.TextBox();
            this.request_host = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.env_dev = new System.Windows.Forms.RadioButton();
            this.env_prod = new System.Windows.Forms.RadioButton();
            this.env_qa = new System.Windows.Forms.RadioButton();
            this.env_uat = new System.Windows.Forms.RadioButton();
            this.env_local = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // request_url
            // 
            this.request_url.Location = new System.Drawing.Point(111, 152);
            this.request_url.Name = "request_url";
            this.request_url.Size = new System.Drawing.Size(243, 20);
            this.request_url.TabIndex = 0;
            this.request_url.Enter += new System.EventHandler(this.request_url_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "request-url";
            // 
            // method_get
            // 
            this.method_get.AutoSize = true;
            this.method_get.Checked = true;
            this.method_get.Location = new System.Drawing.Point(111, 178);
            this.method_get.Name = "method_get";
            this.method_get.Size = new System.Drawing.Size(47, 17);
            this.method_get.TabIndex = 2;
            this.method_get.TabStop = true;
            this.method_get.Text = "GET";
            this.method_get.UseVisualStyleBackColor = true;
            // 
            // method_post
            // 
            this.method_post.AutoSize = true;
            this.method_post.Location = new System.Drawing.Point(164, 178);
            this.method_post.Name = "method_post";
            this.method_post.Size = new System.Drawing.Size(54, 17);
            this.method_post.TabIndex = 3;
            this.method_post.Text = "POST";
            this.method_post.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "request-method";
            // 
            // request_body
            // 
            this.request_body.Location = new System.Drawing.Point(111, 201);
            this.request_body.Multiline = true;
            this.request_body.Name = "request_body";
            this.request_body.Size = new System.Drawing.Size(243, 59);
            this.request_body.TabIndex = 7;
            this.request_body.Enter += new System.EventHandler(this.request_body_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "request-body";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(18, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generate client-signature";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // request_id
            // 
            this.request_id.Location = new System.Drawing.Point(111, 296);
            this.request_id.Name = "request_id";
            this.request_id.Size = new System.Drawing.Size(243, 20);
            this.request_id.TabIndex = 12;
            this.request_id.Enter += new System.EventHandler(this.request_id_Enter);
            // 
            // client_signature
            // 
            this.client_signature.Location = new System.Drawing.Point(111, 323);
            this.client_signature.Multiline = true;
            this.client_signature.Name = "client_signature";
            this.client_signature.Size = new System.Drawing.Size(243, 94);
            this.client_signature.TabIndex = 14;
            this.client_signature.Enter += new System.EventHandler(this.client_signature_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "secret-key";
            // 
            // secret_key
            // 
            this.secret_key.Location = new System.Drawing.Point(99, 82);
            this.secret_key.Name = "secret_key";
            this.secret_key.ReadOnly = true;
            this.secret_key.Size = new System.Drawing.Size(243, 20);
            this.secret_key.TabIndex = 9;
            this.secret_key.TabStop = false;
            this.secret_key.Enter += new System.EventHandler(this.secret_key_Enter);
            // 
            // request_host
            // 
            this.request_host.Location = new System.Drawing.Point(99, 55);
            this.request_host.Name = "request_host";
            this.request_host.ReadOnly = true;
            this.request_host.Size = new System.Drawing.Size(243, 20);
            this.request_host.TabIndex = 5;
            this.request_host.TabStop = false;
            this.request_host.Enter += new System.EventHandler(this.request_host_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "request-host";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.env_dev);
            this.groupBox1.Controls.Add(this.env_prod);
            this.groupBox1.Controls.Add(this.env_qa);
            this.groupBox1.Controls.Add(this.env_uat);
            this.groupBox1.Controls.Add(this.env_local);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.request_host);
            this.groupBox1.Controls.Add(this.secret_key);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 120);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Environment";
            // 
            // env_dev
            // 
            this.env_dev.AutoSize = true;
            this.env_dev.Location = new System.Drawing.Point(37, 24);
            this.env_dev.Name = "env_dev";
            this.env_dev.Size = new System.Drawing.Size(45, 17);
            this.env_dev.TabIndex = 15;
            this.env_dev.TabStop = true;
            this.env_dev.Text = "Dev";
            this.env_dev.UseVisualStyleBackColor = true;
            this.env_dev.CheckedChanged += new System.EventHandler(this.env_dev_CheckedChanged);
            // 
            // env_prod
            // 
            this.env_prod.AutoSize = true;
            this.env_prod.Checked = true;
            this.env_prod.Location = new System.Drawing.Point(244, 24);
            this.env_prod.Name = "env_prod";
            this.env_prod.Size = new System.Drawing.Size(76, 17);
            this.env_prod.TabIndex = 14;
            this.env_prod.TabStop = true;
            this.env_prod.Text = "Production";
            this.env_prod.UseVisualStyleBackColor = true;
            this.env_prod.CheckedChanged += new System.EventHandler(this.env_prod_CheckedChanged);
            // 
            // env_qa
            // 
            this.env_qa.AutoSize = true;
            this.env_qa.Location = new System.Drawing.Point(198, 24);
            this.env_qa.Name = "env_qa";
            this.env_qa.Size = new System.Drawing.Size(40, 17);
            this.env_qa.TabIndex = 13;
            this.env_qa.TabStop = true;
            this.env_qa.Text = "QA";
            this.env_qa.UseVisualStyleBackColor = true;
            this.env_qa.CheckedChanged += new System.EventHandler(this.env_qa_CheckedChanged);
            // 
            // env_uat
            // 
            this.env_uat.AutoSize = true;
            this.env_uat.Location = new System.Drawing.Point(145, 24);
            this.env_uat.Name = "env_uat";
            this.env_uat.Size = new System.Drawing.Size(47, 17);
            this.env_uat.TabIndex = 12;
            this.env_uat.TabStop = true;
            this.env_uat.Text = "UAT";
            this.env_uat.UseVisualStyleBackColor = true;
            this.env_uat.CheckedChanged += new System.EventHandler(this.env_uat_CheckedChanged);
            // 
            // env_local
            // 
            this.env_local.AutoSize = true;
            this.env_local.Location = new System.Drawing.Point(88, 24);
            this.env_local.Name = "env_local";
            this.env_local.Size = new System.Drawing.Size(51, 17);
            this.env_local.TabIndex = 11;
            this.env_local.TabStop = true;
            this.env_local.Text = "Local";
            this.env_local.UseVisualStyleBackColor = true;
            this.env_local.CheckedChanged += new System.EventHandler(this.env_local_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 152);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate request-id && client-signature";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "New request-id";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.client_signature);
            this.Controls.Add(this.request_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.request_body);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.method_post);
            this.Controls.Add(this.method_get);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.request_url);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Sign Tool for Amazon Integration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox request_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton method_get;
        private System.Windows.Forms.RadioButton method_post;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox request_body;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox request_id;
        private System.Windows.Forms.TextBox client_signature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secret_key;
        private System.Windows.Forms.TextBox request_host;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton env_prod;
        private System.Windows.Forms.RadioButton env_qa;
        private System.Windows.Forms.RadioButton env_uat;
        private System.Windows.Forms.RadioButton env_local;
        private System.Windows.Forms.RadioButton env_dev;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
    }
}

