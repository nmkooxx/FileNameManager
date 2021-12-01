namespace FileNameManager
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Replace = new System.Windows.Forms.Button();
            this.RawInput1 = new System.Windows.Forms.TextBox();
            this.RawInput2 = new System.Windows.Forms.TextBox();
            this.RawInput3 = new System.Windows.Forms.TextBox();
            this.RawInput4 = new System.Windows.Forms.TextBox();
            this.RawInput5 = new System.Windows.Forms.TextBox();
            this.NowInput1 = new System.Windows.Forms.TextBox();
            this.NowInput2 = new System.Windows.Forms.TextBox();
            this.NowInput3 = new System.Windows.Forms.TextBox();
            this.NowInput4 = new System.Windows.Forms.TextBox();
            this.NowInput5 = new System.Windows.Forms.TextBox();
            this.InsertPrefix = new System.Windows.Forms.Button();
            this.InsertSuffix = new System.Windows.Forms.Button();
            this.InsertInput = new System.Windows.Forms.TextBox();
            this.InsertIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathInput = new System.Windows.Forms.TextBox();
            this.SelectDir = new System.Windows.Forms.Button();
            this.Rename = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.replaceInfo = new System.Windows.Forms.CheckBox();
            this.UnixNewline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新名称";
            // 
            // Replace
            // 
            this.Replace.Location = new System.Drawing.Point(349, 41);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(75, 23);
            this.Replace.TabIndex = 0;
            this.Replace.Text = "替换为";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // RawInput1
            // 
            this.RawInput1.Location = new System.Drawing.Point(12, 73);
            this.RawInput1.Name = "RawInput1";
            this.RawInput1.Size = new System.Drawing.Size(367, 21);
            this.RawInput1.TabIndex = 1;
            // 
            // RawInput2
            // 
            this.RawInput2.Location = new System.Drawing.Point(12, 100);
            this.RawInput2.Name = "RawInput2";
            this.RawInput2.Size = new System.Drawing.Size(367, 21);
            this.RawInput2.TabIndex = 5;
            // 
            // RawInput3
            // 
            this.RawInput3.Location = new System.Drawing.Point(12, 127);
            this.RawInput3.Name = "RawInput3";
            this.RawInput3.Size = new System.Drawing.Size(367, 21);
            this.RawInput3.TabIndex = 6;
            // 
            // RawInput4
            // 
            this.RawInput4.Location = new System.Drawing.Point(12, 154);
            this.RawInput4.Name = "RawInput4";
            this.RawInput4.Size = new System.Drawing.Size(367, 21);
            this.RawInput4.TabIndex = 7;
            // 
            // RawInput5
            // 
            this.RawInput5.Location = new System.Drawing.Point(12, 181);
            this.RawInput5.Name = "RawInput5";
            this.RawInput5.Size = new System.Drawing.Size(367, 21);
            this.RawInput5.TabIndex = 8;
            // 
            // NowInput1
            // 
            this.NowInput1.Location = new System.Drawing.Point(397, 73);
            this.NowInput1.Name = "NowInput1";
            this.NowInput1.Size = new System.Drawing.Size(382, 21);
            this.NowInput1.TabIndex = 4;
            // 
            // NowInput2
            // 
            this.NowInput2.Location = new System.Drawing.Point(397, 100);
            this.NowInput2.Name = "NowInput2";
            this.NowInput2.Size = new System.Drawing.Size(382, 21);
            this.NowInput2.TabIndex = 9;
            // 
            // NowInput3
            // 
            this.NowInput3.Location = new System.Drawing.Point(397, 126);
            this.NowInput3.Name = "NowInput3";
            this.NowInput3.Size = new System.Drawing.Size(382, 21);
            this.NowInput3.TabIndex = 10;
            // 
            // NowInput4
            // 
            this.NowInput4.Location = new System.Drawing.Point(397, 153);
            this.NowInput4.Name = "NowInput4";
            this.NowInput4.Size = new System.Drawing.Size(382, 21);
            this.NowInput4.TabIndex = 11;
            // 
            // NowInput5
            // 
            this.NowInput5.Location = new System.Drawing.Point(397, 180);
            this.NowInput5.Name = "NowInput5";
            this.NowInput5.Size = new System.Drawing.Size(382, 21);
            this.NowInput5.TabIndex = 12;
            // 
            // InsertPrefix
            // 
            this.InsertPrefix.Location = new System.Drawing.Point(371, 220);
            this.InsertPrefix.Name = "InsertPrefix";
            this.InsertPrefix.Size = new System.Drawing.Size(94, 23);
            this.InsertPrefix.TabIndex = 13;
            this.InsertPrefix.Text = "从前方插入";
            this.InsertPrefix.UseVisualStyleBackColor = true;
            this.InsertPrefix.Click += new System.EventHandler(this.InsertPrefix_Click);
            // 
            // InsertSuffix
            // 
            this.InsertSuffix.Location = new System.Drawing.Point(484, 220);
            this.InsertSuffix.Name = "InsertSuffix";
            this.InsertSuffix.Size = new System.Drawing.Size(94, 23);
            this.InsertSuffix.TabIndex = 14;
            this.InsertSuffix.Text = "从后方插入";
            this.InsertSuffix.UseVisualStyleBackColor = true;
            this.InsertSuffix.Click += new System.EventHandler(this.InsertSuffix_Click);
            // 
            // InsertInput
            // 
            this.InsertInput.Location = new System.Drawing.Point(66, 220);
            this.InsertInput.Name = "InsertInput";
            this.InsertInput.Size = new System.Drawing.Size(224, 21);
            this.InsertInput.TabIndex = 15;
            // 
            // InsertIndex
            // 
            this.InsertIndex.Location = new System.Drawing.Point(328, 220);
            this.InsertIndex.Name = "InsertIndex";
            this.InsertIndex.Size = new System.Drawing.Size(37, 21);
            this.InsertIndex.TabIndex = 16;
            this.InsertIndex.TextChanged += new System.EventHandler(this.InsertIndex_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "序号";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.PathLabel.Location = new System.Drawing.Point(12, 9);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(88, 16);
            this.PathLabel.TabIndex = 18;
            this.PathLabel.Text = "文件夹路径";
            // 
            // PathInput
            // 
            this.PathInput.Font = new System.Drawing.Font("宋体", 12F);
            this.PathInput.Location = new System.Drawing.Point(106, 4);
            this.PathInput.Name = "PathInput";
            this.PathInput.Size = new System.Drawing.Size(583, 26);
            this.PathInput.TabIndex = 19;
            this.PathInput.TextChanged += new System.EventHandler(this.PathInput_TextChanged);
            // 
            // SelectDir
            // 
            this.SelectDir.Font = new System.Drawing.Font("宋体", 12F);
            this.SelectDir.Location = new System.Drawing.Point(704, 4);
            this.SelectDir.Name = "SelectDir";
            this.SelectDir.Size = new System.Drawing.Size(75, 26);
            this.SelectDir.TabIndex = 20;
            this.SelectDir.Text = "选择";
            this.SelectDir.UseVisualStyleBackColor = true;
            this.SelectDir.Click += new System.EventHandler(this.SelectDir_Click);
            // 
            // Rename
            // 
            this.Rename.Location = new System.Drawing.Point(595, 220);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(94, 23);
            this.Rename.TabIndex = 21;
            this.Rename.Text = "按排序重命名";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(12, 257);
            this.Log.MaximumSize = new System.Drawing.Size(800, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(53, 12);
            this.Log.TabIndex = 22;
            this.Log.Text = "日志输出";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "插入字符";
            // 
            // replaceInfo
            // 
            this.replaceInfo.AutoSize = true;
            this.replaceInfo.Location = new System.Drawing.Point(683, 42);
            this.replaceInfo.Name = "replaceInfo";
            this.replaceInfo.Size = new System.Drawing.Size(96, 16);
            this.replaceInfo.TabIndex = 24;
            this.replaceInfo.Text = "替换文件内容";
            this.replaceInfo.UseVisualStyleBackColor = true;
            // 
            // UnixNewline
            // 
            this.UnixNewline.Location = new System.Drawing.Point(695, 220);
            this.UnixNewline.Name = "UnixNewline";
            this.UnixNewline.Size = new System.Drawing.Size(93, 23);
            this.UnixNewline.TabIndex = 25;
            this.UnixNewline.Text = "切换Unix换行";
            this.UnixNewline.UseVisualStyleBackColor = true;
            this.UnixNewline.Click += new System.EventHandler(this.UnixNewline_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 461);
            this.Controls.Add(this.UnixNewline);
            this.Controls.Add(this.replaceInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.SelectDir);
            this.Controls.Add(this.PathInput);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsertIndex);
            this.Controls.Add(this.InsertInput);
            this.Controls.Add(this.InsertSuffix);
            this.Controls.Add(this.InsertPrefix);
            this.Controls.Add(this.NowInput5);
            this.Controls.Add(this.NowInput4);
            this.Controls.Add(this.NowInput3);
            this.Controls.Add(this.NowInput2);
            this.Controls.Add(this.RawInput5);
            this.Controls.Add(this.RawInput4);
            this.Controls.Add(this.RawInput3);
            this.Controls.Add(this.RawInput2);
            this.Controls.Add(this.NowInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RawInput1);
            this.Controls.Add(this.Replace);
            this.Name = "MainForm";
            this.Text = "文件名批量修改";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.TextBox RawInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NowInput1;
        private System.Windows.Forms.TextBox RawInput2;
        private System.Windows.Forms.TextBox RawInput3;
        private System.Windows.Forms.TextBox RawInput4;
        private System.Windows.Forms.TextBox RawInput5;
        private System.Windows.Forms.TextBox NowInput2;
        private System.Windows.Forms.TextBox NowInput3;
        private System.Windows.Forms.TextBox NowInput4;
        private System.Windows.Forms.TextBox NowInput5;
        private System.Windows.Forms.Button InsertPrefix;
        private System.Windows.Forms.Button InsertSuffix;
        private System.Windows.Forms.TextBox InsertInput;
        private System.Windows.Forms.TextBox InsertIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathInput;
        private System.Windows.Forms.Button SelectDir;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox replaceInfo;
        private System.Windows.Forms.Button UnixNewline;
    }
}

