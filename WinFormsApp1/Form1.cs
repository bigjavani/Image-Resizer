using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!InterFace.folderBasedProccessing)
            {
                string ext = System.IO.Path.GetExtension(InterFace.outputPath);
                InterFace.outputPath = InterFace.outputPath.Replace(ext, "." + InterFace.format);
            }

            string param = BuildParamString();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = Application.StartupPath + "App\\realesrgan-ncnn-vulkan.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = param;
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string BuildParamString()
        {
            string param = " -i \"" + InterFace.inputPath + "\"";
            param += " -o \"" + InterFace.outputPath + "\"";
            param += " -s " + InterFace.scale;
            param += " -f " + InterFace.format;
            param += " -n " + InterFace.modelName;
            return param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InterFace.folderBasedProccessing)
            {
                SelectInputFolder();
            }
            else
            {
                SelectInputFile();
            }
            UpdateLabels();
        }

        private void SelectInputFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select Input Folder";
                fbd.UseDescriptionForTitle = true;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    InterFace.inputPath = fbd.SelectedPath;
                    SetOutput();
                }
            }
        }

        private void SelectInputFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image File";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "png files |*.png|jpg files |*.jpg|webp files |*.webp";
            openFileDialog.ShowDialog();
            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                InterFace.inputPath = openFileDialog.FileName;
                SetOutput();
            }
        }

        private void SetOutput()
        {
            if (InterFace.folderBasedProccessing)
            {
                SelectOutputFolder();
            }
            else
            {
                SelectOutputFile();
            }

        }

        private void SelectOutputFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select Output Folder";
                fbd.UseDescriptionForTitle = true;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    InterFace.outputPath = fbd.SelectedPath;
                }
            }
        }

        private void SelectOutputFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string ext = System.IO.Path.GetExtension(InterFace.inputPath);
            string filename = "New " + System.IO.Path.GetFileName(InterFace.inputPath);
            filename.Replace(ext, "");
            InterFace.format = ext.Substring(1, ext.Length - 1);

            saveFileDialog1.Filter = "png files |*.png|jpg files |*.jpg|webp files |*.webp";
            saveFileDialog1.FileName = filename;
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if (!String.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                InterFace.outputPath = saveFileDialog1.FileName;
                comboBox2.SelectedItem = InterFace.format;
            }
        }

        private void UpdateLabels()
        {
            lblFilePath.Text = "Input:\n " + InterFace.inputPath + "\nOutput:\n" + InterFace.outputPath;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InterFace.scale = int.Parse(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            InterFace.format = comboBox2.Text;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            InterFace.folderBasedProccessing = checkBox1.Checked;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            InterFace.modelName = comboBox3.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = @"http://www.instagram.com/Bigjavani";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = true;
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
