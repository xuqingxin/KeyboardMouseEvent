namespace KeyboardMouse
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAppTitle = new System.Windows.Forms.TextBox();
            this.txtHwnd = new System.Windows.Forms.TextBox();
            this.txtClassname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnSendMouse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMouseX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMouseY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMouseKey = new System.Windows.Forms.ComboBox();
            this.btnSendKey = new System.Windows.Forms.Button();
            this.btnGroupSend = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRepeatTimes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(126, 190);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAppTitle
            // 
            this.txtAppTitle.Location = new System.Drawing.Point(100, 36);
            this.txtAppTitle.Name = "txtAppTitle";
            this.txtAppTitle.Size = new System.Drawing.Size(145, 21);
            this.txtAppTitle.TabIndex = 2;
            this.txtAppTitle.Text = "微信";
            // 
            // txtHwnd
            // 
            this.txtHwnd.Location = new System.Drawing.Point(100, 139);
            this.txtHwnd.Name = "txtHwnd";
            this.txtHwnd.Size = new System.Drawing.Size(145, 21);
            this.txtHwnd.TabIndex = 3;
            // 
            // txtClassname
            // 
            this.txtClassname.Location = new System.Drawing.Point(100, 87);
            this.txtClassname.Name = "txtClassname";
            this.txtClassname.Size = new System.Drawing.Size(145, 21);
            this.txtClassname.TabIndex = 4;
            this.txtClassname.Text = "WeChatMainWndForPC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "窗口名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "窗口类名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "窗口句柄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "按键";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(372, 36);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(145, 21);
            this.txtKey.TabIndex = 8;
            this.txtKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKey_KeyDown);
            // 
            // btnSendMouse
            // 
            this.btnSendMouse.Location = new System.Drawing.Point(548, 137);
            this.btnSendMouse.Name = "btnSendMouse";
            this.btnSendMouse.Size = new System.Drawing.Size(75, 23);
            this.btnSendMouse.TabIndex = 10;
            this.btnSendMouse.Text = "发送";
            this.btnSendMouse.UseVisualStyleBackColor = true;
            this.btnSendMouse.Click += new System.EventHandler(this.btnSendMouseKey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "鼠标坐标";
            // 
            // txtMouseX
            // 
            this.txtMouseX.Location = new System.Drawing.Point(389, 87);
            this.txtMouseX.Name = "txtMouseX";
            this.txtMouseX.Size = new System.Drawing.Size(52, 21);
            this.txtMouseX.TabIndex = 11;
            this.txtMouseX.Text = "200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "Y";
            // 
            // txtMouseY
            // 
            this.txtMouseY.Location = new System.Drawing.Point(465, 87);
            this.txtMouseY.Name = "txtMouseY";
            this.txtMouseY.Size = new System.Drawing.Size(52, 21);
            this.txtMouseY.TabIndex = 15;
            this.txtMouseY.Text = "200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "鼠标按键";
            // 
            // cmbMouseKey
            // 
            this.cmbMouseKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMouseKey.FormattingEnabled = true;
            this.cmbMouseKey.Items.AddRange(new object[] {
            "左键",
            "中键",
            "右键"});
            this.cmbMouseKey.Location = new System.Drawing.Point(372, 139);
            this.cmbMouseKey.Name = "cmbMouseKey";
            this.cmbMouseKey.Size = new System.Drawing.Size(145, 20);
            this.cmbMouseKey.TabIndex = 18;
            // 
            // btnSendKey
            // 
            this.btnSendKey.Location = new System.Drawing.Point(548, 34);
            this.btnSendKey.Name = "btnSendKey";
            this.btnSendKey.Size = new System.Drawing.Size(75, 23);
            this.btnSendKey.TabIndex = 19;
            this.btnSendKey.Text = "发送";
            this.btnSendKey.UseVisualStyleBackColor = true;
            this.btnSendKey.Click += new System.EventHandler(this.btnSendKey_Click);
            // 
            // btnGroupSend
            // 
            this.btnGroupSend.Location = new System.Drawing.Point(442, 190);
            this.btnGroupSend.Name = "btnGroupSend";
            this.btnGroupSend.Size = new System.Drawing.Size(75, 23);
            this.btnGroupSend.TabIndex = 20;
            this.btnGroupSend.Text = "组合发送";
            this.btnGroupSend.UseVisualStyleBackColor = true;
            this.btnGroupSend.Click += new System.EventHandler(this.btnGroupSend_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "重复次数";
            // 
            // txtRepeatTimes
            // 
            this.txtRepeatTimes.Location = new System.Drawing.Point(372, 192);
            this.txtRepeatTimes.Name = "txtRepeatTimes";
            this.txtRepeatTimes.Size = new System.Drawing.Size(52, 21);
            this.txtRepeatTimes.TabIndex = 21;
            this.txtRepeatTimes.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 234);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRepeatTimes);
            this.Controls.Add(this.btnGroupSend);
            this.Controls.Add(this.btnSendKey);
            this.Controls.Add(this.cmbMouseKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMouseY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMouseX);
            this.Controls.Add(this.btnSendMouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClassname);
            this.Controls.Add(this.txtHwnd);
            this.Controls.Add(this.txtAppTitle);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAppTitle;
        private System.Windows.Forms.TextBox txtHwnd;
        private System.Windows.Forms.TextBox txtClassname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnSendMouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMouseX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMouseY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMouseKey;
        private System.Windows.Forms.Button btnSendKey;
        private System.Windows.Forms.Button btnGroupSend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRepeatTimes;
    }
}

