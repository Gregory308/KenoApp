using log4net;
using RandomNumbersGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace KenoApp
{
    public partial class Form1 : Form
    {
        RandomNumberGenerator generator;
        int usersCount = 0;
        int basicTime = 240;
        int runda = 1;
        bool premiumVersion = false;
        bool validationOk = true;
        string hide = "* * * *";


        public Form1()
        {
            InitializeComponent();
         //nie wywoływać nic wiecej w konstruktorze
        }

        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));


        private void NewMethod()
        {

            Console.WriteLine("test i test");
            log.Error("Dacko chce podwyżkę!!!");
            generator = new RandomNumberGenerator();
            generator.GenerateNumbers();
            this.timer1.Enabled = true;
            showUsers(this, EventArgs.Empty);
            this.numbersButton.Click += new System.EventHandler(this.saveToFile);
            this.premiumButton.Click += new System.EventHandler(this.premiumSaveToFile);
            //showWinNumbers();
            wonNumTextBox.Text = hide;
            premNumTextBox.Text = hide;
            //string filePath = "C:\\Users\\aziobro\\source\\repos\\Projekt1\\Projekt1\\winners.txt";
            //GroupBox normalTimerSpeed = new GroupBox();
            //GroupBox premiumTimerSpeed = new GroupBox();
            premiumTimerSpeed.Controls.Add(x0RadioButton);
            premiumTimerSpeed.Controls.Add(x10RadioButton);
            premiumTimerSpeed.Controls.Add(x100RadioButton);
            normalTimerSpeed.Controls.Add(nx0RadioButton);
            normalTimerSpeed.Controls.Add(nx10RadioButton);
            normalTimerSpeed.Controls.Add(nx100RadioButton);
           
        }

        private void showUsers(object sender, EventArgs e)
        {
            string filePath = "test.csv";

            string[] lines = File.ReadAllLines(filePath);

            List<User> users = new List<User>();
            
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                User user = new User
                {
                    id = int.Parse(fields[0]),
                    name = fields[1],
                    lastName = fields[2],
                    address = fields[3],
                    email = fields[4],
                    coNumber = fields[5],
                    //numbers = userNumTextBox.Text.Split(',').Select(int.Parse).ToArray()
                };

                users.Add(user);
            }
            usersCount = users.Count; 


            foreach (User user in users)
            {
                usersTextBox.AppendText($"Id: {user.id}, Name: {user.name} {user.lastName}\r\n");
                dataSet1.DataTable1.Rows.Add(user.name, user.lastName);
                
                //userNumTextBox.AppendText($"Numbers: {string.Join(", ", user.numbers)}\r\n");
            }
        }

        private void saveToFile(object sender, EventArgs e)
        {
            string[] tbLine1 = usersTextBox.Lines;
            string[] tbLine2 = userNumTextBox.Lines;
            premiumVersion = false;

            string mergedText = "";

            int minLength = Math.Min(tbLine1.Length, tbLine2.Length);

            for (int i = 0; i < minLength; i++)
            {
                string mergedLine;
                if (tbLine2[i].Split(',').Length == 4 || tbLine2[i].Split(' ').Length == 4)
                {
                    mergedLine = $"{tbLine1[i]} {tbLine2[i]}";
                }
                else
                {
                    mergedLine = $"{tbLine1[i]} ";
                }
                mergedText += mergedLine + Environment.NewLine;
                if (i == usersCount - 1)
                {
                    break;
                }
            }

            string filePath = "result.txt";
            File.WriteAllText(filePath, mergedText);
        }

        private void premiumSaveToFile(object sender, EventArgs e)
        {
            premiumVersion = true;
            if (!validationOk)
            {
                MessageBox.Show(Properties.Resources.InvalidNumbers);
            }
            else if (!usersGridView.DataExists())
            {
                MessageBox.Show(Properties.Resources.NoPlayers);
            }
            else
            {
                string filePath = "premiumResult.txt";
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        for (int i = 0; i < usersGridView.ColumnCount; i++)
                        {
                            writer.Write(usersGridView.Columns[i].HeaderText);
                            if (i < usersGridView.ColumnCount - 1)
                                writer.Write("\t");
                        }
                        writer.WriteLine();

                        foreach (DataGridViewRow row in usersGridView.Rows)
                        {
                            for (int i = 0; i < usersGridView.ColumnCount; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < usersGridView.ColumnCount - 1)
                                    writer.Write("\t");
                            }
                            writer.WriteLine();
                        }
                    }
                    validationOk = true;
                    MessageBox.Show(Properties.Resources.DataSaved, "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.DataNotSaved + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearResults()
        {
            string filePath = "result.txt";
            File.WriteAllText(filePath, "");
        }

        private void addWinner(String actualWinner)
        {
            
            winnerTextBox.Text = actualWinner;
            premWinTextBox.Text = actualWinner;
            String winners = resultsTextBox.Text;
            String premWinners = premWinnersTextBox.Text;
            String log;
            if (actualWinner == null)
            {
                log = Properties.Resources.Round1 + runda + Properties.Resources.Round2 +
                    Properties.Resources.NextRound + Math.Floor(basicTime / 60.0).ToString() + " min " + (basicTime % 60).ToString() + " s\n";
            }
            else
            {
                log = Properties.Resources.WinnerInfo + runda + ".: " + actualWinner + "\n";
            }
            resultsTextBox.Text = winners + log;
            premWinnersTextBox.Text = premWinners + log;
            string filePath = "winners.txt";

            using(StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(log);
            }
        }

        private String showWinNumbers()
        {
            int[] numbers = generator.GetGeneratedNumbers;
            String numString = "";
            foreach(int n in numbers)
            {
                numString = numString + n + " ";
            }
            wonNumTextBox.Text = numString;
            premNumTextBox.Text = numString;
            return numString;
        }


        private void clearData()
        {
            userNumTextBox.Text = "";
            for(int i=0; i<dataSet1.DataTable1.Rows.Count; i++)
            {
                usersGridView[2, i].Value = "";
                usersGridView[3, i].Value = "";
                usersGridView[4, i].Value = "";
                usersGridView[5, i].Value = "";
            }
            usersGridView.ClearErrorText();
        }

        private string numbersComparison()
        {
            
            string[] tbLine1 = wonNumTextBox.Lines;
            string[] tbLine2 = userNumTextBox.Lines;
            int idWinner = -1;
            //int[] numbers1 = tbLine1.Select(int.Parse).ToArray();
            //int[] numbers2 = tbLine2.Select(int.Parse).ToArray();

            bool containsAllNumbers = false; //= numbers1.All(num => numbers2.Contains(num));

            for (int i = 0; i < tbLine2.Length; i++)
            {
                string[] numbers = tbLine2[i].Split(' ');
                int goodAns = 0;
                foreach (string n in numbers)
                {
                    if (tbLine1[0].IndexOf(n) == -1)
                    {
                        break;
                    }
                    else
                    {
                        goodAns++;
                    }
                }
                if (goodAns == 4)
                {
                    containsAllNumbers = true; idWinner = i;
                }
                else
                {
                    containsAllNumbers = false;
                }
            }

            string[] users = usersTextBox.Lines;
            string winner;
            if (idWinner != -1)
            {
                winner = users[idWinner];
            }
            else
            {
                winner = null;
            }
            return winner;

        }

        private string premiumNumbersComparison()
        {
            int max_numbers = generator.GetNumbersToGenerate;
           
            string[] tbLine1 = wonNumTextBox.Lines;
            //string[] tbLine2 = userNumTextBox.Lines;
            string[,] tbLine2 = new string[usersCount,max_numbers];
            for(int i=0; i<usersCount; i++)
            {
                for(int j=0; j<max_numbers; j++)
                {
                    tbLine2[i, j] = usersGridView[2 + j, i].Value.ToString();
                }
            }
            int idWinner = -1;
            //int[] numbers1 = tbLine1.Select(int.Parse).ToArray();
            //int[] numbers2 = tbLine2.Select(int.Parse).ToArray();

            bool containsAllNumbers = false; //= numbers1.All(num => numbers2.Contains(num));

            for (int i = 0; i < usersCount; i++)
            {
                //string[] numbers = tbLine2[i].Split(' ');
                int goodAns = 0;
                for(int j=0; j<max_numbers; j++)
                {
                    if (tbLine2[i, j] == "" || tbLine1[0].IndexOf(tbLine2[i, j]) == -1)
                    {
                        break;
                    }
                    else 
                    {
                        goodAns++;
                    }
                }
                if (goodAns == 4)
                {
                    containsAllNumbers = true; idWinner = i; break;
                }
                else
                {
                    containsAllNumbers = false;
                }
            }

            
            string winner;
            if (idWinner != -1)
            {
                winner = usersGridView[0, idWinner].Value.ToString();
            }
            else
            {
                winner = null;
            }
            return winner;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (basicTime > 0)
            {
                basicTime--;
                int minutes = basicTime / 60;
                int seconds = basicTime - (minutes * 60);
                this.textBox1.Text = minutes.ToString() + ":" + ((seconds>9)?seconds.ToString():"0"+ seconds.ToString());
                this.premTimer.Text = minutes.ToString() + ":" + ((seconds > 9) ? seconds.ToString() : "0" + seconds.ToString());
            }
            else
            {
                this.timer1.Stop();
                basicTime = 240;
                String actualWinner = premiumVersion?premiumNumbersComparison():numbersComparison();
                addWinner(actualWinner);
                if (actualWinner == null)
                {
                    actualWinner = "Brak";
                }
                
                clearData();
                clearResults();
                generator.GenerateNumbers();
                //MessageBox.Show(this, winInfo,
                     //              "Losowanie", MessageBoxButtons.OK);
                runda++;
                this.timer1.Start();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();
            usersGridView.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in usersGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            sendNumbersToolTip.SetToolTip(this.premiumButton, Properties.Resources.Info1);
            sendNumbersToolTip.SetToolTip(this.numbersButton, Properties.Resources.Info1);
            normalNumbersToolTip.SetToolTip(this.userNumTextBox, Properties.Resources.Info2);
        }

        private void usersGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //ErrorText kasować
                DataGridViewCell cell = usersGridView[e.ColumnIndex, e.RowIndex];
                validationOk = cell.ValidationCell();
            }

        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timerSpeedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;
                if(rb.Text == "x0")
                {
                    timer1.Interval = 1000;
                    x0RadioButton.Checked = true;
                    nx0RadioButton.Checked = true;
                }
                else if(rb.Text == "x10")
                {
                    timer1.Interval = 100;
                    x10RadioButton.Checked = true;
                    nx10RadioButton.Checked = true;
                }
                else if(rb.Text == "x100")
                {
                    timer1.Interval = 10;
                    x100RadioButton.Checked = true;
                    nx100RadioButton.Checked = true;
                }
            }
        }

        private void hideNumbersCheckedChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked)
            {
                
                wonNumTextBox.Text = hide;
                premNumTextBox.Text = hide;
                hideNumCheckBox.Checked = true;
                premHideNumCheckBox.Checked = true;
            }
            else
            {
                hideNumCheckBox.Checked = false;
                premHideNumCheckBox.Checked = false;
                showWinNumbers();
            }
        }
    }
}
