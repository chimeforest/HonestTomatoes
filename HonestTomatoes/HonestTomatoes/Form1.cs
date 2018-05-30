using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonestTomatoes
{
    public partial class Form1 : Form
    {
        //vars
        string url;
        string htmlStr = "";
        int pageCnt = 1;
        List<int> reviewScores = new List<int>();
        string[] reviewStrs;
        double averageScore;
        int lastPage;
        string endStatus;
        float pLiked;

        public bool running = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void GObtn_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                //change button
                running = true;
                GObtn.Text = "Cancel";

                //vars
                pageCnt = 1;
                reviewScores = new List<int>();
                endStatus = "Finished Completely";

                //find number of pages
                lastPage = GetNumOfPages();
                
                //clear text
                DebugOut.Text = "Page: 0/" + lastPage +": 0.00%";

                //start work
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                running = false;
                GObtn.Text = "GO";

                //cancel work
                backgroundWorker1.CancelAsync();

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //check if valid page
            while (pageCnt <= lastPage)
            {

                if (backgroundWorker1.CancellationPending)
                {
                    //CANCEL
                    e.Cancel = true;
                    endStatus = "Cancelled";
                    break;
                }
                else
                {
                    //construct url
                    url = GetURL();

                    //get page string
                    htmlStr = GetHTML();

                    //divide by users
                    reviewStrs = htmlStr.Split(new string[] { CountTxt.Text }, StringSplitOptions.None);

                    //check if at end by seeing if there is even a single review on the page
                    if(reviewStrs.Length == 1)
                    {
                        if(reviewScores.Count != 0)
                        {
                            endStatus = "Reached Limit of Public Reviews";
                        }
                        else
                        {
                            endStatus = "No Movie Found";
                        }
                        break;
                    }

                    //DebugOut.Text = reviewStrs.Length.ToString();

                    foreach (string str in reviewStrs)
                    {
                        int score;
                        if (str.Contains(StarTxt.Text))
                        {
                            score = Regex.Matches(str, StarTxt.Text).Count * 20;

                            if (str.Contains(HalfStarTxt.Text))
                            {
                                score += 10;
                            }
                            reviewScores.Add(score);
                            //DebugOut.AppendText(score + "\r\n");
                        }
                        else if (HalfStarChk.Checked && str.Contains(HalfStarTxt.Text))
                        {
                            score = 10;

                            reviewScores.Add(score);
                            //DebugOut.AppendText(score + "\r\n");
                        }
                        else if (NoStarChk.Checked && str.Contains(NoStarTxt.Text))
                        {
                            score = 0;

                            reviewScores.Add(score);
                            //DebugOut.AppendText(score + "\r\n");
                        }
                    }
                    pageCnt++;
                    backgroundWorker1.ReportProgress(0);//((pageCnt / lastPage) * 100));
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DebugOut.Text = "Page: " + pageCnt + "/" + lastPage + ": " + (pageCnt/(float)lastPage*100).ToString("0.00") + "%"; ;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (e.Cancelled)
            //{
            DebugOut.AppendText("\r\n\r\n" + endStatus + "\r\n");
            //}

            if (reviewScores.Count > 0)
            {
                //calulate
                averageScore = reviewScores.Average();
                pLiked = PercentLiked();

                DebugOut.AppendText("\r\nAudience Score");
                //output
                if (averageScore >= 70)     //The full popcorn bucket means the movie received 3.5 stars or higher by users. (3.5 stars = 70%)
                {
                    DebugOut.AppendText("\r\n\tPopcorn: Full");
                }
                else
                {
                    DebugOut.AppendText("\r\n\tPopcorn: Spilled");
                }
                DebugOut.AppendText("\r\n\t" + pLiked.ToString("0.00") + "% liked it");

                DebugOut.AppendText("\r\n\tAverage Rating: " + (averageScore/20).ToString("0.0") + "/5 (" + averageScore.ToString("0.00") + "%)");
                DebugOut.AppendText("\r\n\tUser Ratings: " + reviewScores.Count);
            }

            //reset go button
            running = false;
            GObtn.Text = "GO";

        }

        private int GetNumOfPages()
        {
            string text = GetHTML(GetURL(1));
            string[] texts = text.Split('\n');
            string number;
            int num = 0;

            foreach(string str in texts)
            {
                if (str.Contains("pageInfo"))
                {
                    number = str.Substring(str.IndexOf("pageInfo")+20);
                    number = number.Substring(0, number.IndexOf('<'));
                    num = Int32.Parse(number);
                    Console.WriteLine(number);
                    break;
                }
            }
            return num;
        }

        private string GetURL()
        {
            return URLParseTxt.Text.Replace("[ID]", IDTxt.Text).Replace("[PAGE]", pageCnt.ToString());
        }

        private string GetURL(int page)
        {
            return URLParseTxt.Text.Replace("[ID]", IDTxt.Text).Replace("[PAGE]", page.ToString());
        }

        private string GetHTML()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(url);
                }
            }
            catch(Exception e)
            {
                return e.ToString();
                //if an error is thrown, return it. In the loop, this will cause it to stop.
            }
        }

        private string GetHTML(string URL)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(URL);
            }
        }

        private float PercentLiked(float likeBar = 70)
        {

            return PercentLiked(reviewScores, likeBar);
        }

        //The percentage of people who have rated this film 3.5 or higher (3.5 stars = 70%)
        private float PercentLiked(List<int> scores, float likeBar = 70)
        {
            int liked = 0;

            foreach(int i in scores)
            {
                if (i >= likeBar)
                {
                    liked++;
                }
            }

            return liked/(float)scores.Count*100;
        }
    }
}
