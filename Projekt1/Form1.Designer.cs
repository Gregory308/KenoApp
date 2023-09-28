
namespace KenoApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wonNumTextBox = new System.Windows.Forms.TextBox();
            this.winnerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usersTextBox = new System.Windows.Forms.RichTextBox();
            this.userNumTextBox = new System.Windows.Forms.RichTextBox();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.numbersButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hideNumCheckBox = new System.Windows.Forms.CheckBox();
            this.normalTimerSpeed = new System.Windows.Forms.GroupBox();
            this.nx0RadioButton = new System.Windows.Forms.RadioButton();
            this.nx100RadioButton = new System.Windows.Forms.RadioButton();
            this.nx10RadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.premHideNumCheckBox = new System.Windows.Forms.CheckBox();
            this.premiumTimerSpeed = new System.Windows.Forms.GroupBox();
            this.x100RadioButton = new System.Windows.Forms.RadioButton();
            this.x0RadioButton = new System.Windows.Forms.RadioButton();
            this.x10RadioButton = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.premWinnersTextBox = new System.Windows.Forms.RichTextBox();
            this.premTimer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.premWinTextBox = new System.Windows.Forms.TextBox();
            this.premNumTextBox = new System.Windows.Forms.TextBox();
            this.premiumButton = new System.Windows.Forms.Button();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new KenoApp.DataSet1();
            this.sendNumbersToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.normalNumbersToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.normalTimerSpeed.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.premiumTimerSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // wonNumTextBox
            // 
            this.wonNumTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.wonNumTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wonNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.wonNumTextBox.Location = new System.Drawing.Point(273, 62);
            this.wonNumTextBox.Name = "wonNumTextBox";
            this.wonNumTextBox.ReadOnly = true;
            this.wonNumTextBox.Size = new System.Drawing.Size(286, 26);
            this.wonNumTextBox.TabIndex = 0;
            // 
            // winnerTextBox
            // 
            this.winnerTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.winnerTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.winnerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.winnerTextBox.Location = new System.Drawing.Point(273, 102);
            this.winnerTextBox.Name = "winnerTextBox";
            this.winnerTextBox.ReadOnly = true;
            this.winnerTextBox.Size = new System.Drawing.Size(286, 26);
            this.winnerTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(713, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Następne losowanie za";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista uczestników";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(530, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ostatni zwycięzcy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(86, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wygrywające liczby";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(102, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zwycięzca";
            // 
            // usersTextBox
            // 
            this.usersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usersTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usersTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usersTextBox.Location = new System.Drawing.Point(57, 202);
            this.usersTextBox.Name = "usersTextBox";
            this.usersTextBox.ReadOnly = true;
            this.usersTextBox.Size = new System.Drawing.Size(337, 151);
            this.usersTextBox.TabIndex = 8;
            this.usersTextBox.Text = "";
            // 
            // userNumTextBox
            // 
            this.userNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userNumTextBox.Location = new System.Drawing.Point(415, 202);
            this.userNumTextBox.Name = "userNumTextBox";
            this.userNumTextBox.Size = new System.Drawing.Size(100, 151);
            this.userNumTextBox.TabIndex = 9;
            this.userNumTextBox.Text = "";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultsTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultsTextBox.Location = new System.Drawing.Point(534, 198);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(438, 155);
            this.resultsTextBox.TabIndex = 10;
            this.resultsTextBox.Text = "";
            // 
            // numbersButton
            // 
            this.numbersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numbersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numbersButton.Location = new System.Drawing.Point(415, 356);
            this.numbersButton.Name = "numbersButton";
            this.numbersButton.Size = new System.Drawing.Size(100, 46);
            this.numbersButton.TabIndex = 11;
            this.numbersButton.Text = "Prześlij liczby";
            this.numbersButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(892, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 436);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hideNumCheckBox);
            this.tabPage1.Controls.Add(this.normalTimerSpeed);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.numbersButton);
            this.tabPage1.Controls.Add(this.resultsTextBox);
            this.tabPage1.Controls.Add(this.userNumTextBox);
            this.tabPage1.Controls.Add(this.usersTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.winnerTextBox);
            this.tabPage1.Controls.Add(this.wonNumTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hideNumCheckBox
            // 
            this.hideNumCheckBox.AutoSize = true;
            this.hideNumCheckBox.Checked = true;
            this.hideNumCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideNumCheckBox.Location = new System.Drawing.Point(565, 69);
            this.hideNumCheckBox.Name = "hideNumCheckBox";
            this.hideNumCheckBox.Size = new System.Drawing.Size(79, 17);
            this.hideNumCheckBox.TabIndex = 22;
            this.hideNumCheckBox.Text = "Ukryj liczby";
            this.hideNumCheckBox.UseVisualStyleBackColor = true;
            this.hideNumCheckBox.CheckedChanged += new System.EventHandler(this.hideNumbersCheckedChanged);
            // 
            // normalTimerSpeed
            // 
            this.normalTimerSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.normalTimerSpeed.Controls.Add(this.nx0RadioButton);
            this.normalTimerSpeed.Controls.Add(this.nx100RadioButton);
            this.normalTimerSpeed.Controls.Add(this.nx10RadioButton);
            this.normalTimerSpeed.Location = new System.Drawing.Point(866, 32);
            this.normalTimerSpeed.Name = "normalTimerSpeed";
            this.normalTimerSpeed.Size = new System.Drawing.Size(126, 96);
            this.normalTimerSpeed.TabIndex = 21;
            this.normalTimerSpeed.TabStop = false;
            this.normalTimerSpeed.Text = "Szybkość timera";
            // 
            // nx0RadioButton
            // 
            this.nx0RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nx0RadioButton.AutoSize = true;
            this.nx0RadioButton.Checked = true;
            this.nx0RadioButton.Location = new System.Drawing.Point(15, 18);
            this.nx0RadioButton.Name = "nx0RadioButton";
            this.nx0RadioButton.Size = new System.Drawing.Size(36, 17);
            this.nx0RadioButton.TabIndex = 18;
            this.nx0RadioButton.TabStop = true;
            this.nx0RadioButton.Text = "x0";
            this.nx0RadioButton.UseVisualStyleBackColor = true;
            this.nx0RadioButton.CheckedChanged += new System.EventHandler(this.timerSpeedChanged);
            // 
            // nx100RadioButton
            // 
            this.nx100RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nx100RadioButton.AutoSize = true;
            this.nx100RadioButton.Location = new System.Drawing.Point(15, 61);
            this.nx100RadioButton.Name = "nx100RadioButton";
            this.nx100RadioButton.Size = new System.Drawing.Size(48, 17);
            this.nx100RadioButton.TabIndex = 20;
            this.nx100RadioButton.Text = "x100";
            this.nx100RadioButton.UseVisualStyleBackColor = true;
            this.nx100RadioButton.CheckedChanged += new System.EventHandler(this.timerSpeedChanged);
            // 
            // nx10RadioButton
            // 
            this.nx10RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nx10RadioButton.AutoSize = true;
            this.nx10RadioButton.Location = new System.Drawing.Point(15, 38);
            this.nx10RadioButton.Name = "nx10RadioButton";
            this.nx10RadioButton.Size = new System.Drawing.Size(42, 17);
            this.nx10RadioButton.TabIndex = 19;
            this.nx10RadioButton.Text = "x10";
            this.nx10RadioButton.UseVisualStyleBackColor = true;
            this.nx10RadioButton.CheckedChanged += new System.EventHandler(this.timerSpeedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.premHideNumCheckBox);
            this.tabPage2.Controls.Add(this.premiumTimerSpeed);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.premWinnersTextBox);
            this.tabPage2.Controls.Add(this.premTimer);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.premWinTextBox);
            this.tabPage2.Controls.Add(this.premNumTextBox);
            this.tabPage2.Controls.Add(this.premiumButton);
            this.tabPage2.Controls.Add(this.usersGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Premium";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // premHideNumCheckBox
            // 
            this.premHideNumCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.premHideNumCheckBox.AutoSize = true;
            this.premHideNumCheckBox.Checked = true;
            this.premHideNumCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.premHideNumCheckBox.Location = new System.Drawing.Point(533, 318);
            this.premHideNumCheckBox.Name = "premHideNumCheckBox";
            this.premHideNumCheckBox.Size = new System.Drawing.Size(79, 17);
            this.premHideNumCheckBox.TabIndex = 23;
            this.premHideNumCheckBox.Text = "Ukryj liczby";
            this.premHideNumCheckBox.UseVisualStyleBackColor = true;
            this.premHideNumCheckBox.CheckedChanged += new System.EventHandler(this.hideNumbersCheckedChanged);
            // 
            // premiumTimerSpeed
            // 
            this.premiumTimerSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.premiumTimerSpeed.Controls.Add(this.x100RadioButton);
            this.premiumTimerSpeed.Controls.Add(this.x0RadioButton);
            this.premiumTimerSpeed.Controls.Add(this.x10RadioButton);
            this.premiumTimerSpeed.Location = new System.Drawing.Point(892, 294);
            this.premiumTimerSpeed.Name = "premiumTimerSpeed";
            this.premiumTimerSpeed.Size = new System.Drawing.Size(102, 80);
            this.premiumTimerSpeed.TabIndex = 20;
            this.premiumTimerSpeed.TabStop = false;
            this.premiumTimerSpeed.Text = "Szybkość timera";
            // 
            // x100RadioButton
            // 
            this.x100RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.x100RadioButton.AutoSize = true;
            this.x100RadioButton.Location = new System.Drawing.Point(6, 57);
            this.x100RadioButton.Name = "x100RadioButton";
            this.x100RadioButton.Size = new System.Drawing.Size(48, 17);
            this.x100RadioButton.TabIndex = 19;
            this.x100RadioButton.Text = "x100";
            this.x100RadioButton.UseVisualStyleBackColor = true;
            this.x100RadioButton.CheckedChanged += new System.EventHandler(this.timerSpeedChanged);
            // 
            // x0RadioButton
            // 
            this.x0RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.x0RadioButton.AutoSize = true;
            this.x0RadioButton.Checked = true;
            this.x0RadioButton.Location = new System.Drawing.Point(6, 19);
            this.x0RadioButton.Name = "x0RadioButton";
            this.x0RadioButton.Size = new System.Drawing.Size(36, 17);
            this.x0RadioButton.TabIndex = 17;
            this.x0RadioButton.TabStop = true;
            this.x0RadioButton.Text = "x0";
            this.x0RadioButton.UseVisualStyleBackColor = true;
            this.x0RadioButton.CheckedChanged += new System.EventHandler(this.timerSpeedChanged);
            // 
            // x10RadioButton
            // 
            this.x10RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.x10RadioButton.AutoSize = true;
            this.x10RadioButton.Location = new System.Drawing.Point(6, 37);
            this.x10RadioButton.Name = "x10RadioButton";
            this.x10RadioButton.Size = new System.Drawing.Size(42, 17);
            this.x10RadioButton.TabIndex = 18;
            this.x10RadioButton.Text = "x10";
            this.x10RadioButton.UseVisualStyleBackColor = true;
            this.x10RadioButton.CheckedChanged += new System.EventHandler(this.timerSpeedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(774, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ostatni zwycięzcy";
            // 
            // premWinnersTextBox
            // 
            this.premWinnersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.premWinnersTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.premWinnersTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.premWinnersTextBox.Location = new System.Drawing.Point(711, 33);
            this.premWinnersTextBox.Name = "premWinnersTextBox";
            this.premWinnersTextBox.ReadOnly = true;
            this.premWinnersTextBox.Size = new System.Drawing.Size(261, 258);
            this.premWinnersTextBox.TabIndex = 15;
            this.premWinnersTextBox.Text = "";
            // 
            // premTimer
            // 
            this.premTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.premTimer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.premTimer.Location = new System.Drawing.Point(886, 374);
            this.premTimer.Name = "premTimer";
            this.premTimer.ReadOnly = true;
            this.premTimer.Size = new System.Drawing.Size(100, 20);
            this.premTimer.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(707, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Następne losowanie za";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(60, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Zwycięzca";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(44, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wygrywające liczby";
            // 
            // premWinTextBox
            // 
            this.premWinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.premWinTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.premWinTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.premWinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.premWinTextBox.Location = new System.Drawing.Point(231, 354);
            this.premWinTextBox.Name = "premWinTextBox";
            this.premWinTextBox.ReadOnly = true;
            this.premWinTextBox.Size = new System.Drawing.Size(286, 26);
            this.premWinTextBox.TabIndex = 9;
            // 
            // premNumTextBox
            // 
            this.premNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.premNumTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.premNumTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.premNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.premNumTextBox.Location = new System.Drawing.Point(231, 314);
            this.premNumTextBox.Name = "premNumTextBox";
            this.premNumTextBox.ReadOnly = true;
            this.premNumTextBox.Size = new System.Drawing.Size(286, 26);
            this.premNumTextBox.TabIndex = 8;
            // 
            // premiumButton
            // 
            this.premiumButton.Location = new System.Drawing.Point(650, 247);
            this.premiumButton.MinimumSize = new System.Drawing.Size(55, 44);
            this.premiumButton.Name = "premiumButton";
            this.premiumButton.Size = new System.Drawing.Size(55, 44);
            this.premiumButton.TabIndex = 1;
            this.premiumButton.Text = "Prześlij liczby";
            this.premiumButton.UseVisualStyleBackColor = true;
            // 
            // usersGridView
            // 
            this.usersGridView.AutoGenerateColumns = false;
            this.usersGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.numer1DataGridViewTextBoxColumn,
            this.numer2DataGridViewTextBoxColumn,
            this.numer3DataGridViewTextBoxColumn,
            this.numer4DataGridViewTextBoxColumn});
            this.usersGridView.DataSource = this.dataTable1BindingSource;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGridView.Location = new System.Drawing.Point(3, 3);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.Size = new System.Drawing.Size(994, 404);
            this.usersGridView.TabIndex = 0;
            this.usersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellContentClick);
            this.usersGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellValueChanged);
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numer1DataGridViewTextBoxColumn
            // 
            this.numer1DataGridViewTextBoxColumn.DataPropertyName = "numer 1";
            this.numer1DataGridViewTextBoxColumn.HeaderText = "numer 1";
            this.numer1DataGridViewTextBoxColumn.Name = "numer1DataGridViewTextBoxColumn";
            // 
            // numer2DataGridViewTextBoxColumn
            // 
            this.numer2DataGridViewTextBoxColumn.DataPropertyName = "numer 2";
            this.numer2DataGridViewTextBoxColumn.HeaderText = "numer 2";
            this.numer2DataGridViewTextBoxColumn.Name = "numer2DataGridViewTextBoxColumn";
            // 
            // numer3DataGridViewTextBoxColumn
            // 
            this.numer3DataGridViewTextBoxColumn.DataPropertyName = "numer 3";
            this.numer3DataGridViewTextBoxColumn.HeaderText = "numer 3";
            this.numer3DataGridViewTextBoxColumn.Name = "numer3DataGridViewTextBoxColumn";
            // 
            // numer4DataGridViewTextBoxColumn
            // 
            this.numer4DataGridViewTextBoxColumn.DataPropertyName = "numer 4";
            this.numer4DataGridViewTextBoxColumn.HeaderText = "numer 4";
            this.numer4DataGridViewTextBoxColumn.Name = "numer4DataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sendNumbersToolTip
            // 
            this.sendNumbersToolTip.AutoPopDelay = 5000;
            this.sendNumbersToolTip.InitialDelay = 100;
            this.sendNumbersToolTip.ReshowDelay = 100;
            // 
            // normalNumbersToolTip
            // 
            this.normalNumbersToolTip.AutoPopDelay = 5000;
            this.normalNumbersToolTip.InitialDelay = 100;
            this.normalNumbersToolTip.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 436);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 475);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KENO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.normalTimerSpeed.ResumeLayout(false);
            this.normalTimerSpeed.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.premiumTimerSpeed.ResumeLayout(false);
            this.premiumTimerSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox wonNumTextBox;
        private System.Windows.Forms.TextBox winnerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox usersTextBox;
        private System.Windows.Forms.RichTextBox userNumTextBox;
        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.Button numbersButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView usersGridView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer4DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.Button premiumButton;
        private System.Windows.Forms.ToolTip sendNumbersToolTip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox premWinnersTextBox;
        private System.Windows.Forms.TextBox premTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox premWinTextBox;
        private System.Windows.Forms.TextBox premNumTextBox;
        private System.Windows.Forms.ToolTip normalNumbersToolTip;
        private System.Windows.Forms.RadioButton x100RadioButton;
        private System.Windows.Forms.RadioButton x10RadioButton;
        private System.Windows.Forms.RadioButton x0RadioButton;
        private System.Windows.Forms.RadioButton nx100RadioButton;
        private System.Windows.Forms.RadioButton nx10RadioButton;
        private System.Windows.Forms.RadioButton nx0RadioButton;
        private System.Windows.Forms.GroupBox normalTimerSpeed;
        private System.Windows.Forms.GroupBox premiumTimerSpeed;
        private System.Windows.Forms.CheckBox hideNumCheckBox;
        private System.Windows.Forms.CheckBox premHideNumCheckBox;
    }
}

