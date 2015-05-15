namespace Cryptography_and_Encrypt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Decrypted_str = new System.Windows.Forms.TextBox();
            this.Encrypted_str = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Url_decode = new System.Windows.Forms.Button();
            this.Visitor_token_timeout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Switch_it = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WWW_vid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mobile_vid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Visitor_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Test_str = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Encrypt);
            this.groupBox1.Controls.Add(this.Decrypt);
            this.groupBox1.Controls.Add(this.Decrypted_str);
            this.groupBox1.Controls.Add(this.Encrypted_str);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cryptography";
            // 
            // Encrypt
            // 
            this.Encrypt.Image = global::Cryptography_and_Encrypt.Properties.Resources.arrow_up1;
            this.Encrypt.Location = new System.Drawing.Point(303, 132);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(109, 23);
            this.Encrypt.TabIndex = 3;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Encrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Image = global::Cryptography_and_Encrypt.Properties.Resources.arrow_down1;
            this.Decrypt.Location = new System.Drawing.Point(87, 132);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(112, 23);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Decrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Decrypted_str
            // 
            this.Decrypted_str.Location = new System.Drawing.Point(6, 164);
            this.Decrypted_str.Multiline = true;
            this.Decrypted_str.Name = "Decrypted_str";
            this.Decrypted_str.Size = new System.Drawing.Size(495, 105);
            this.Decrypted_str.TabIndex = 1;
            this.Decrypted_str.Enter += new System.EventHandler(this.Decrypted_str_Enter);
            // 
            // Encrypted_str
            // 
            this.Encrypted_str.Location = new System.Drawing.Point(7, 20);
            this.Encrypted_str.Multiline = true;
            this.Encrypted_str.Name = "Encrypted_str";
            this.Encrypted_str.Size = new System.Drawing.Size(495, 105);
            this.Encrypted_str.TabIndex = 0;
            this.Encrypted_str.Enter += new System.EventHandler(this.Encrypted_str_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Url_decode);
            this.groupBox2.Controls.Add(this.Visitor_token_timeout);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Switch_it);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.WWW_vid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Mobile_vid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Visitor_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Test_str);
            this.groupBox2.Location = new System.Drawing.Point(13, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitor Encrypt";
            // 
            // Url_decode
            // 
            this.Url_decode.Location = new System.Drawing.Point(197, 60);
            this.Url_decode.Name = "Url_decode";
            this.Url_decode.Size = new System.Drawing.Size(112, 23);
            this.Url_decode.TabIndex = 11;
            this.Url_decode.Text = "Url Decode";
            this.Url_decode.UseVisualStyleBackColor = true;
            this.Url_decode.Click += new System.EventHandler(this.Url_decode_Click);
            // 
            // Visitor_token_timeout
            // 
            this.Visitor_token_timeout.Location = new System.Drawing.Point(127, 60);
            this.Visitor_token_timeout.Name = "Visitor_token_timeout";
            this.Visitor_token_timeout.Size = new System.Drawing.Size(35, 20);
            this.Visitor_token_timeout.TabIndex = 10;
            this.Visitor_token_timeout.Text = "5";
            this.Visitor_token_timeout.Enter += new System.EventHandler(this.Visitor_token_timeout_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Visitor Token Timeout";
            // 
            // Switch_it
            // 
            this.Switch_it.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Switch_it.Location = new System.Drawing.Point(315, 60);
            this.Switch_it.Name = "Switch_it";
            this.Switch_it.Size = new System.Drawing.Size(187, 23);
            this.Switch_it.TabIndex = 8;
            this.Switch_it.Text = "Switch it!";
            this.Switch_it.UseVisualStyleBackColor = true;
            this.Switch_it.Click += new System.EventHandler(this.Switch_it_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "WWW VID";
            // 
            // WWW_vid
            // 
            this.WWW_vid.Location = new System.Drawing.Point(72, 174);
            this.WWW_vid.Multiline = true;
            this.WWW_vid.Name = "WWW_vid";
            this.WWW_vid.ReadOnly = true;
            this.WWW_vid.Size = new System.Drawing.Size(430, 37);
            this.WWW_vid.TabIndex = 6;
            this.WWW_vid.Enter += new System.EventHandler(this.WWW_vid_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mobile VID";
            // 
            // Mobile_vid
            // 
            this.Mobile_vid.Location = new System.Drawing.Point(72, 131);
            this.Mobile_vid.Multiline = true;
            this.Mobile_vid.Name = "Mobile_vid";
            this.Mobile_vid.ReadOnly = true;
            this.Mobile_vid.Size = new System.Drawing.Size(430, 37);
            this.Mobile_vid.TabIndex = 4;
            this.Mobile_vid.Enter += new System.EventHandler(this.Mobile_vid_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visitor ID";
            // 
            // Visitor_id
            // 
            this.Visitor_id.Location = new System.Drawing.Point(72, 88);
            this.Visitor_id.Multiline = true;
            this.Visitor_id.Name = "Visitor_id";
            this.Visitor_id.ReadOnly = true;
            this.Visitor_id.Size = new System.Drawing.Size(430, 37);
            this.Visitor_id.TabIndex = 2;
            this.Visitor_id.Enter += new System.EventHandler(this.Visitor_id_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test String";
            // 
            // Test_str
            // 
            this.Test_str.Location = new System.Drawing.Point(71, 19);
            this.Test_str.Multiline = true;
            this.Test_str.Name = "Test_str";
            this.Test_str.Size = new System.Drawing.Size(430, 37);
            this.Test_str.TabIndex = 0;
            this.Test_str.Enter += new System.EventHandler(this.Test_str_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cryptography & Visitor Encrypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox Decrypted_str;
        private System.Windows.Forms.TextBox Encrypted_str;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WWW_vid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Mobile_vid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Visitor_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Test_str;
        private System.Windows.Forms.Button Switch_it;
        private System.Windows.Forms.TextBox Visitor_token_timeout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Url_decode;
    }
}

