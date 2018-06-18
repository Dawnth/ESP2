namespace ESP2
{
    partial class Clock_And_Timer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_Clock = new System.Windows.Forms.GroupBox();
            this.button_Clock_Clear = new System.Windows.Forms.Button();
            this.button_Clock_Start = new System.Windows.Forms.Button();
            this.label_Clock = new System.Windows.Forms.Label();
            this.groupBox_Timer = new System.Windows.Forms.GroupBox();
            this.label_Timer = new System.Windows.Forms.Label();
            this.lable_Timer_Seconds = new System.Windows.Forms.Label();
            this.button_Timer_Clear = new System.Windows.Forms.Button();
            this.label_Timer_Minutes = new System.Windows.Forms.Label();
            this.label_Timer_Hours = new System.Windows.Forms.Label();
            this.button_Timer_Start = new System.Windows.Forms.Button();
            this.comboBox_Timer_Seconds = new System.Windows.Forms.ComboBox();
            this.comboBox_Timer_Minutes = new System.Windows.Forms.ComboBox();
            this.comboBox_Timer_Hours = new System.Windows.Forms.ComboBox();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.timer_Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Clock.SuspendLayout();
            this.groupBox_Timer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Clock
            // 
            this.groupBox_Clock.Controls.Add(this.button_Clock_Clear);
            this.groupBox_Clock.Controls.Add(this.button_Clock_Start);
            this.groupBox_Clock.Controls.Add(this.label_Clock);
            this.groupBox_Clock.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Clock.Name = "groupBox_Clock";
            this.groupBox_Clock.Size = new System.Drawing.Size(257, 80);
            this.groupBox_Clock.TabIndex = 0;
            this.groupBox_Clock.TabStop = false;
            this.groupBox_Clock.Text = "Clock";
            // 
            // button_Clock_Clear
            // 
            this.button_Clock_Clear.Location = new System.Drawing.Point(207, 50);
            this.button_Clock_Clear.Name = "button_Clock_Clear";
            this.button_Clock_Clear.Size = new System.Drawing.Size(44, 24);
            this.button_Clock_Clear.TabIndex = 1;
            this.button_Clock_Clear.Text = "Clear";
            this.button_Clock_Clear.UseVisualStyleBackColor = true;
            this.button_Clock_Clear.Click += new System.EventHandler(this.button_Clock_Clear_Click);
            // 
            // button_Clock_Start
            // 
            this.button_Clock_Start.Location = new System.Drawing.Point(207, 20);
            this.button_Clock_Start.Name = "button_Clock_Start";
            this.button_Clock_Start.Size = new System.Drawing.Size(44, 24);
            this.button_Clock_Start.TabIndex = 1;
            this.button_Clock_Start.Text = "Start";
            this.button_Clock_Start.UseVisualStyleBackColor = true;
            this.button_Clock_Start.Click += new System.EventHandler(this.button_Clock_Start_Click);
            // 
            // label_Clock
            // 
            this.label_Clock.AutoSize = true;
            this.label_Clock.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Clock.Location = new System.Drawing.Point(6, 29);
            this.label_Clock.Name = "label_Clock";
            this.label_Clock.Size = new System.Drawing.Size(195, 35);
            this.label_Clock.TabIndex = 0;
            this.label_Clock.Text = "00:00:00:0";
            // 
            // groupBox_Timer
            // 
            this.groupBox_Timer.Controls.Add(this.label_Timer);
            this.groupBox_Timer.Controls.Add(this.lable_Timer_Seconds);
            this.groupBox_Timer.Controls.Add(this.button_Timer_Clear);
            this.groupBox_Timer.Controls.Add(this.label_Timer_Minutes);
            this.groupBox_Timer.Controls.Add(this.label_Timer_Hours);
            this.groupBox_Timer.Controls.Add(this.button_Timer_Start);
            this.groupBox_Timer.Controls.Add(this.comboBox_Timer_Seconds);
            this.groupBox_Timer.Controls.Add(this.comboBox_Timer_Minutes);
            this.groupBox_Timer.Controls.Add(this.comboBox_Timer_Hours);
            this.groupBox_Timer.Location = new System.Drawing.Point(12, 98);
            this.groupBox_Timer.Name = "groupBox_Timer";
            this.groupBox_Timer.Size = new System.Drawing.Size(257, 144);
            this.groupBox_Timer.TabIndex = 1;
            this.groupBox_Timer.TabStop = false;
            this.groupBox_Timer.Text = "Timer";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Timer.Location = new System.Drawing.Point(6, 95);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(195, 35);
            this.label_Timer.TabIndex = 2;
            this.label_Timer.Text = "00:00:00:0";
            // 
            // lable_Timer_Seconds
            // 
            this.lable_Timer_Seconds.AutoSize = true;
            this.lable_Timer_Seconds.Location = new System.Drawing.Point(82, 75);
            this.lable_Timer_Seconds.Name = "lable_Timer_Seconds";
            this.lable_Timer_Seconds.Size = new System.Drawing.Size(47, 12);
            this.lable_Timer_Seconds.TabIndex = 5;
            this.lable_Timer_Seconds.Text = "Seconds";
            // 
            // button_Timer_Clear
            // 
            this.button_Timer_Clear.Location = new System.Drawing.Point(207, 114);
            this.button_Timer_Clear.Name = "button_Timer_Clear";
            this.button_Timer_Clear.Size = new System.Drawing.Size(44, 24);
            this.button_Timer_Clear.TabIndex = 2;
            this.button_Timer_Clear.Text = "Clear";
            this.button_Timer_Clear.UseVisualStyleBackColor = true;
            this.button_Timer_Clear.Click += new System.EventHandler(this.button_Timer_Clear_Click);
            // 
            // label_Timer_Minutes
            // 
            this.label_Timer_Minutes.AutoSize = true;
            this.label_Timer_Minutes.Location = new System.Drawing.Point(82, 49);
            this.label_Timer_Minutes.Name = "label_Timer_Minutes";
            this.label_Timer_Minutes.Size = new System.Drawing.Size(47, 12);
            this.label_Timer_Minutes.TabIndex = 4;
            this.label_Timer_Minutes.Text = "Minutes";
            // 
            // label_Timer_Hours
            // 
            this.label_Timer_Hours.AutoSize = true;
            this.label_Timer_Hours.Location = new System.Drawing.Point(94, 23);
            this.label_Timer_Hours.Name = "label_Timer_Hours";
            this.label_Timer_Hours.Size = new System.Drawing.Size(35, 12);
            this.label_Timer_Hours.TabIndex = 3;
            this.label_Timer_Hours.Text = "Hours";
            // 
            // button_Timer_Start
            // 
            this.button_Timer_Start.Location = new System.Drawing.Point(207, 84);
            this.button_Timer_Start.Name = "button_Timer_Start";
            this.button_Timer_Start.Size = new System.Drawing.Size(44, 24);
            this.button_Timer_Start.TabIndex = 2;
            this.button_Timer_Start.Text = "Start";
            this.button_Timer_Start.UseVisualStyleBackColor = true;
            this.button_Timer_Start.Click += new System.EventHandler(this.button_Timer_Start_Click);
            // 
            // comboBox_Timer_Seconds
            // 
            this.comboBox_Timer_Seconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Timer_Seconds.FormattingEnabled = true;
            this.comboBox_Timer_Seconds.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_Timer_Seconds.Location = new System.Drawing.Point(135, 72);
            this.comboBox_Timer_Seconds.Name = "comboBox_Timer_Seconds";
            this.comboBox_Timer_Seconds.Size = new System.Drawing.Size(40, 20);
            this.comboBox_Timer_Seconds.TabIndex = 2;
            this.comboBox_Timer_Seconds.SelectedIndexChanged += new System.EventHandler(this.comboBox_Timer_Seconds_SelectedIndexChanged);
            // 
            // comboBox_Timer_Minutes
            // 
            this.comboBox_Timer_Minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Timer_Minutes.FormattingEnabled = true;
            this.comboBox_Timer_Minutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_Timer_Minutes.Location = new System.Drawing.Point(135, 46);
            this.comboBox_Timer_Minutes.Name = "comboBox_Timer_Minutes";
            this.comboBox_Timer_Minutes.Size = new System.Drawing.Size(40, 20);
            this.comboBox_Timer_Minutes.TabIndex = 1;
            this.comboBox_Timer_Minutes.SelectedIndexChanged += new System.EventHandler(this.comboBox_Timer_Minutes_SelectedIndexChanged);
            // 
            // comboBox_Timer_Hours
            // 
            this.comboBox_Timer_Hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Timer_Hours.FormattingEnabled = true;
            this.comboBox_Timer_Hours.ItemHeight = 12;
            this.comboBox_Timer_Hours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.comboBox_Timer_Hours.Location = new System.Drawing.Point(135, 20);
            this.comboBox_Timer_Hours.Name = "comboBox_Timer_Hours";
            this.comboBox_Timer_Hours.Size = new System.Drawing.Size(40, 20);
            this.comboBox_Timer_Hours.TabIndex = 0;
            this.comboBox_Timer_Hours.SelectedIndexChanged += new System.EventHandler(this.comboBox_Timer_Hours_SelectedIndexChanged);
            // 
            // timer_Clock
            // 
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // timer_Timer
            // 
            this.timer_Timer.Tick += new System.EventHandler(this.timer_Timer_Tick);
            // 
            // Clock_And_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 254);
            this.Controls.Add(this.groupBox_Timer);
            this.Controls.Add(this.groupBox_Clock);
            this.MaximumSize = new System.Drawing.Size(289, 288);
            this.MinimumSize = new System.Drawing.Size(289, 288);
            this.Name = "Clock_And_Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock And Timer";
            this.groupBox_Clock.ResumeLayout(false);
            this.groupBox_Clock.PerformLayout();
            this.groupBox_Timer.ResumeLayout(false);
            this.groupBox_Timer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_Clock;
        public System.Windows.Forms.Button button_Clock_Clear;
        public System.Windows.Forms.Button button_Clock_Start;
        public System.Windows.Forms.Label label_Clock;
        public System.Windows.Forms.GroupBox groupBox_Timer;
        public System.Windows.Forms.ComboBox comboBox_Timer_Hours;
        public System.Windows.Forms.ComboBox comboBox_Timer_Seconds;
        public System.Windows.Forms.ComboBox comboBox_Timer_Minutes;
        public System.Windows.Forms.Button button_Timer_Clear;
        public System.Windows.Forms.Button button_Timer_Start;
        public System.Windows.Forms.Label label_Timer_Hours;
        public System.Windows.Forms.Label lable_Timer_Seconds;
        public System.Windows.Forms.Label label_Timer_Minutes;
        public System.Windows.Forms.Label label_Timer;
        public System.Windows.Forms.Timer timer_Clock;
        public System.Windows.Forms.Timer timer_Timer;


    }
}