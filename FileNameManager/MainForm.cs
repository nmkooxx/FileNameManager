using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FileNameManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            m_rawTexts = new TextBox[5];
            m_rawTexts[0] = RawInput1;
            m_rawTexts[1] = RawInput2;
            m_rawTexts[2] = RawInput3;
            m_rawTexts[3] = RawInput4;
            m_rawTexts[4] = RawInput5;

            m_replaceTexts = new TextBox[5];
            m_replaceTexts[0] = NowInput1;
            m_replaceTexts[1] = NowInput2;
            m_replaceTexts[2] = NowInput3;
            m_replaceTexts[3] = NowInput4;
            m_replaceTexts[4] = NowInput5;

            //使用映射获取执行程序集路径
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //将该路径传递给 System.IO.Path.GetDirectoryName(path)，获得执行程序集所在的目录
            string directory = System.IO.Path.GetDirectoryName(path);
            PathInput.Text = directory;
        }

        private void LogInfo(string log) {
            Log.Text = log;
            Log.BackColor = Color.White;
        }

        private void LogWraning(string log) {
            Log.Text = log;
            Log.BackColor = Color.Yellow;
        }

        private void LogError(string log) {
            Log.Text = log;
            Log.BackColor = Color.Red;
        }

        private TextBox[] m_rawTexts;
        private TextBox[] m_replaceTexts;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private List<string> m_rawStrings = new List<string>(5);
        private List<string> m_replaceStrings = new List<string>(5);
        private void Replace_Click(object sender, EventArgs e)
        {
            m_rawStrings.Clear();
            m_replaceStrings.Clear();

            for (int i = 0; i < m_rawTexts.Length; i++) {
                var rawText = m_rawTexts[i];
                if (string.IsNullOrEmpty(rawText.Text)) {
                    continue;
                }
                m_rawStrings.Add(rawText.Text);
                var replaceText = m_replaceTexts[i];
                if (string.IsNullOrEmpty(replaceText.Text)) {
                    m_replaceStrings.Add("");                    
                }
                else {
                    m_replaceStrings.Add(replaceText.Text);
                }
            }

            string path = PathInput.Text;
            if (!Directory.Exists(path)) {
                LogError("文件夹路径错误");
                return;
            }

            DirectoryInfo info = new DirectoryInfo(path);
            var fileInfos = info.GetFiles();
            for (int i = 0; i < fileInfos.Length; i++) {
                FileInfo fileInfo = fileInfos[i];
                string name = fileInfo.Name;
                bool changed = false;
                for (int j = 0; j < m_rawStrings.Count; j++) {
                    string rawString = m_rawStrings[j];
                    if (name.IndexOf(rawString) >= 0) {
                        name = name.Replace(rawString, m_replaceStrings[j]);
                        changed = true;
                    }
                }
                if (changed) {
                    string fullPath = fileInfo.FullName;
                    fileInfo.MoveTo(System.IO.Path.Combine(info.FullName, name));
                }
            }

            LogInfo("替换完成");
        }

        private int m_insertIndex = 0;
        private void InsertIndex_TextChanged(object sender, EventArgs e)
        {
            int index;
            if (!int.TryParse(InsertIndex.Text, out index)) {
                LogError("插入位置错误");
                InsertIndex.Text = m_insertIndex.ToString();
                return;
            }

            m_insertIndex = index;
        }

        private void InsertPrefix_Click(object sender, EventArgs e)
        {
            string path = PathInput.Text;
            if (!Directory.Exists(path)) {
                LogError("文件夹路径错误");
                return;
            }

            string prefix = InsertInput.Text;
            if (string.IsNullOrEmpty(prefix)) {
                LogError("插入字符串为空");
                return;
            }

            DirectoryInfo info = new DirectoryInfo(path);
            var fileInfos = info.GetFiles();
            for (int i = 0; i < fileInfos.Length; i++) {
                FileInfo fileInfo = fileInfos[i];
                string name = fileInfo.Name;
                bool changed = false;
                if (name.IndexOf(prefix) != m_insertIndex) {
                    name = name.Insert(m_insertIndex, prefix);
                    changed = true;
                }
                if (changed) {
                    string fullPath = fileInfo.FullName;
                    fileInfo.MoveTo(Path.Combine(info.FullName, name));
                }
            }

            LogInfo("插入完成");
        }

        private void InsertSuffix_Click(object sender, EventArgs e)
        {
            string path = PathInput.Text;
            if (!Directory.Exists(path)) {
                LogError("文件夹路径错误");
                return;
            }

            string suffix = InsertInput.Text;
            if (string.IsNullOrEmpty(suffix)) {
                LogError("插入字符串为空");
                return;
            }

            DirectoryInfo info = new DirectoryInfo(path);
            var fileInfos = info.GetFiles();
            for (int i = 0; i < fileInfos.Length; i++) {
                FileInfo fileInfo = fileInfos[i];
                string name = fileInfo.Name;
                bool changed = false;
                if (name.LastIndexOf(suffix) != m_insertIndex) {
                    name = name.Insert(name.Length - m_insertIndex, suffix);
                    changed = true;
                }
                if (changed) {
                    string fullPath = fileInfo.FullName;
                    fileInfo.MoveTo(Path.Combine(info.FullName, name));
                }
            }

            LogInfo("插入完成");
        }

        private void SelectDir_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            dialog.SelectedPath = PathInput.Text;

            if (dialog.ShowDialog() == DialogResult.OK) {
                PathInput.Text = dialog.SelectedPath;
            }
            else {
                LogError("选择文件路径失败：" + dialog.ShowDialog());
            }
        }

        private void Rename_Click(object sender, EventArgs e) {
            string path = PathInput.Text;
            if (!Directory.Exists(path)) {
                LogError("文件夹路径错误");
                return;
            }

            string perfix = InsertInput.Text;
            if (string.IsNullOrEmpty(perfix)) {
                LogError("插入字符串为空");
                return;
            }

            DirectoryInfo info = new DirectoryInfo(path);
            var fileInfos = info.GetFiles();
            int index = m_insertIndex;
            Dictionary<string, string> name2newName = new Dictionary<string, string>(fileInfos.Length);
            for (int i = 0; i < fileInfos.Length; i++) {
                FileInfo fileInfo = fileInfos[i];
                string name;
                string pureName = fileInfo.Name.Remove(fileInfo.Name.Length - fileInfo.Extension.Length);
                //保证meta文件与原文件同名
                if (name2newName.TryGetValue(pureName, out name)) {
                    name = name + fileInfo.Extension;
                }
                else {
                    name = perfix + index + fileInfo.Extension;
                    name2newName[fileInfo.Name] = name;
                    ++index;
                }
                if (name != fileInfo.Name) {
                    string fullPath = fileInfo.FullName;
                    fileInfo.MoveTo(Path.Combine(info.FullName, name));
                }
            }

            LogInfo("重命名完成");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
