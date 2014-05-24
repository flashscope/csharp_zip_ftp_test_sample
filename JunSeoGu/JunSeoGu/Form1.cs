using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace JunSeoGu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private static List<string> fileList;
        private static ftp ftpClient;

        private void Form1_Load(object sender, EventArgs e)
        {
            fileList = new List<string>();
            ftpClient = new ftp(@"ftp://10.73.45.142/", "", "");
            
        }



        private void parsePage()
        {

            String result = null;
            String url = "http://10.73.45.142:8080";
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                result = reader.ReadToEnd();


                String[] splitResult1 = result.Split(new string[] { "job_yamang" }, StringSplitOptions.None);
                String[] splitResult2 = splitResult1[1].Split(new string[] { "</td>" }, StringSplitOptions.None);
                String splitResult3 = splitResult2[0];
                Console.WriteLine(splitResult2[0]);

                if(splitResult3.Contains("blue.png"))
                {
                    lb_Notice.Text = "정상적으로 젠킨스 빌드중";
                }
                else
                {
                    lb_Notice.Text = "젠킨스에 문제가 있습니다!";
                }
            }
            catch (Exception ex)
            {
                // handle error
                MessageBox.Show(ex.Message);
                MessageBox.Show("학교에서 접속하신게 맞으신가요?");
                lb_Notice.Text = "학교에서 접속하신게 맞으신가요?";
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();
            }
        }

        private void bu_Connect_Click(object sender, EventArgs e)
        {
            parsePage();

            try
            {
                
                
                string[] simpleDirectoryListing = ftpClient.directoryListDetailed("/");

                if (simpleDirectoryListing.Count() == 1 || simpleDirectoryListing.Count() == 0)
                {
                    MessageBox.Show("ERROR");
                    return;
                }

                for (int i = 0; i < simpleDirectoryListing.Count(); i++)
                {
                    String data = simpleDirectoryListing[i];
                    
                    if (data.Contains(".zip"))
                    {

                        String[] fileNameSplit = data.Split(' ');
                        String fileName = fileNameSplit[fileNameSplit.Count() - 1];
                        fileList.Add(fileName);
                        
                    }

                }

                fileList.Reverse();

                lb_files.Items.Clear();
                foreach (String file in fileList)
                {
                    lb_files.Items.Add(file);
                    Console.WriteLine(file);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void bu_Down_Click(object sender, EventArgs e)
        {
            if ( -1 == lb_files.SelectedIndex )
            {
                MessageBox.Show("다운받을 파일을 선택해주세요");
            }
            else
            {
                //MessageBox.Show("SELECTED:" + fileList[lb_files.SelectedIndex]);
                string curDir = Directory.GetCurrentDirectory();
                //Console.WriteLine("cur:" + curDir);
                ftpClient.download("/" + fileList[lb_files.SelectedIndex], curDir + "\\" + fileList[lb_files.SelectedIndex]);
                MessageBox.Show("다운로드가 완료되었습니다.");
            }
            
        }

        private void bu_DownAndUnCompress_Click(object sender, EventArgs e)
        {
            if (-1 == lb_files.SelectedIndex)
            {
                MessageBox.Show("다운받을 파일을 선택해주세요");
            }
            else
            {
                string curDir = Directory.GetCurrentDirectory();
                ftpClient.download("/" + fileList[lb_files.SelectedIndex], curDir + "\\" + fileList[lb_files.SelectedIndex]);

                ZipManager.UnZipFiles(curDir + "\\" + fileList[lb_files.SelectedIndex], curDir + "\\" + "DownloadedFiles" + "\\", "", false);
                
                MessageBox.Show("다운로드와 압축풀기가 완료되었습니다.");
            }
        }



    }
}
