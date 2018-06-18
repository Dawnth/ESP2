namespace ESP2
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl_FuctionSelect = new System.Windows.Forms.TabControl();
            this.tabPage_Command = new System.Windows.Forms.TabPage();
            this.uC_ToolStrip1 = new ESP2.UC_ToolStrip();
            this.toolStripDropDownButton_CommandFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_CommandFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_CommandFile_History = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_History1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_History2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_History3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_History4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_History5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator99 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_History_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_CommandFile_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator97 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator98 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_CommandFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_PortName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_PortName = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel_PortStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_BaudRate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_BaudRate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Parity = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_Parity = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_DataBits = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_DataBits = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_StopBits = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_StopBits = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView_CommandTree = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label_SelectedCommand_Name = new System.Windows.Forms.Label();
            this.groupBox_Parameters = new System.Windows.Forms.GroupBox();
            this.button_CommandSend = new System.Windows.Forms.Button();
            this.textBox_Command = new System.Windows.Forms.TextBox();
            this.button_CommandBuild = new System.Windows.Forms.Button();
            this.checkBox_CommandHex = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Commandms = new System.Windows.Forms.NumericUpDown();
            this.checkBox_CommandAuto = new System.Windows.Forms.CheckBox();
            this.uC_ListView_Parameters = new ESP2.UC_ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label_SelectedCommand = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_ManualClear = new System.Windows.Forms.Button();
            this.button_ManualSend = new System.Windows.Forms.Button();
            this.textBox_Manual = new System.Windows.Forms.TextBox();
            this.checkBox_ManualHex = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Manualms = new System.Windows.Forms.NumericUpDown();
            this.checkBox_ManualAuto = new System.Windows.Forms.CheckBox();
            this.groupBox_Response = new System.Windows.Forms.GroupBox();
            this.uC_ListView_Response = new ESP2.UC_ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.button_Where = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.checkBox_ReceiveHex = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_ShowBox = new System.Windows.Forms.TextBox();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.groupBox_ = new System.Windows.Forms.GroupBox();
            this.groupBox_SerialPort = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage_Tools = new System.Windows.Forms.TabPage();
            this.tabPage_Oscilloscopes = new System.Windows.Forms.TabPage();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_SaveReceivedCommand = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl_FuctionSelect.SuspendLayout();
            this.tabPage_Command.SuspendLayout();
            this.uC_ToolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox_Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Commandms)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Manualms)).BeginInit();
            this.groupBox_Response.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.groupBox_.SuspendLayout();
            this.tabPage_Oscilloscopes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_FuctionSelect
            // 
            this.tabControl_FuctionSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_FuctionSelect.Controls.Add(this.tabPage_Command);
            this.tabControl_FuctionSelect.Controls.Add(this.tabPage_Settings);
            this.tabControl_FuctionSelect.Controls.Add(this.tabPage_Tools);
            this.tabControl_FuctionSelect.Controls.Add(this.tabPage_Oscilloscopes);
            this.tabControl_FuctionSelect.Location = new System.Drawing.Point(-2, -1);
            this.tabControl_FuctionSelect.MinimumSize = new System.Drawing.Size(694, 547);
            this.tabControl_FuctionSelect.Name = "tabControl_FuctionSelect";
            this.tabControl_FuctionSelect.SelectedIndex = 0;
            this.tabControl_FuctionSelect.Size = new System.Drawing.Size(696, 549);
            this.tabControl_FuctionSelect.TabIndex = 0;
            // 
            // tabPage_Command
            // 
            this.tabPage_Command.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Command.Controls.Add(this.uC_ToolStrip1);
            this.tabPage_Command.Controls.Add(this.splitContainer1);
            this.tabPage_Command.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Command.Name = "tabPage_Command";
            this.tabPage_Command.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Command.Size = new System.Drawing.Size(688, 523);
            this.tabPage_Command.TabIndex = 0;
            this.tabPage_Command.Text = "Command List";
            // 
            // uC_ToolStrip1
            // 
            this.uC_ToolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton_CommandFile,
            this.toolStripSeparator1,
            this.toolStripLabel_PortName,
            this.toolStripComboBox_PortName,
            this.toolStripLabel_PortStatus,
            this.toolStripSeparator2,
            this.toolStripLabel_BaudRate,
            this.toolStripComboBox_BaudRate,
            this.toolStripSeparator3,
            this.toolStripLabel_Parity,
            this.toolStripComboBox_Parity,
            this.toolStripSeparator6,
            this.toolStripLabel_DataBits,
            this.toolStripComboBox_DataBits,
            this.toolStripSeparator7,
            this.toolStripLabel_StopBits,
            this.toolStripComboBox_StopBits});
            this.uC_ToolStrip1.Location = new System.Drawing.Point(3, 3);
            this.uC_ToolStrip1.Name = "uC_ToolStrip1";
            this.uC_ToolStrip1.Size = new System.Drawing.Size(682, 25);
            this.uC_ToolStrip1.TabIndex = 9;
            this.uC_ToolStrip1.Text = "uC_ToolStrip1";
            // 
            // toolStripDropDownButton_CommandFile
            // 
            this.toolStripDropDownButton_CommandFile.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton_CommandFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_CommandFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_CommandFile_Open,
            this.toolStripMenuItem_CommandFile_History,
            this.toolStripMenuItem_CommandFile_Close,
            this.toolStripSeparator97,
            this.toolStripMenuItem_Top,
            this.toolStripSeparator98,
            this.toolStripMenuItem_CommandFile_Exit});
            this.toolStripDropDownButton_CommandFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_CommandFile.Image")));
            this.toolStripDropDownButton_CommandFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_CommandFile.Name = "toolStripDropDownButton_CommandFile";
            this.toolStripDropDownButton_CommandFile.Size = new System.Drawing.Size(40, 22);
            this.toolStripDropDownButton_CommandFile.Text = "&File";
            // 
            // toolStripMenuItem_CommandFile_Open
            // 
            this.toolStripMenuItem_CommandFile_Open.Name = "toolStripMenuItem_CommandFile_Open";
            this.toolStripMenuItem_CommandFile_Open.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_CommandFile_Open.Text = "&Open Command File";
            this.toolStripMenuItem_CommandFile_Open.Click += new System.EventHandler(this.toolStripMenuItem_CommandFile_Open_Click);
            // 
            // toolStripMenuItem_CommandFile_History
            // 
            this.toolStripMenuItem_CommandFile_History.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_History1,
            this.toolStripMenuItem_History2,
            this.toolStripMenuItem_History3,
            this.toolStripMenuItem_History4,
            this.toolStripMenuItem_History5,
            this.toolStripSeparator99,
            this.toolStripMenuItem_History_Clear});
            this.toolStripMenuItem_CommandFile_History.Name = "toolStripMenuItem_CommandFile_History";
            this.toolStripMenuItem_CommandFile_History.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_CommandFile_History.Text = "&Reopen";
            // 
            // toolStripMenuItem_History1
            // 
            this.toolStripMenuItem_History1.Name = "toolStripMenuItem_History1";
            this.toolStripMenuItem_History1.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_History1.Text = " ";
            this.toolStripMenuItem_History1.TextChanged += new System.EventHandler(this.toolStripMenuItem_History1_TextChanged);
            this.toolStripMenuItem_History1.Click += new System.EventHandler(this.toolStripMenuItem_History1_Click);
            // 
            // toolStripMenuItem_History2
            // 
            this.toolStripMenuItem_History2.Name = "toolStripMenuItem_History2";
            this.toolStripMenuItem_History2.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_History2.Text = " ";
            this.toolStripMenuItem_History2.TextChanged += new System.EventHandler(this.toolStripMenuItem_History2_TextChanged);
            this.toolStripMenuItem_History2.Click += new System.EventHandler(this.toolStripMenuItem_History2_Click);
            // 
            // toolStripMenuItem_History3
            // 
            this.toolStripMenuItem_History3.Name = "toolStripMenuItem_History3";
            this.toolStripMenuItem_History3.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_History3.Text = " ";
            this.toolStripMenuItem_History3.TextChanged += new System.EventHandler(this.toolStripMenuItem_History3_TextChanged);
            this.toolStripMenuItem_History3.Click += new System.EventHandler(this.toolStripMenuItem_History3_Click);
            // 
            // toolStripMenuItem_History4
            // 
            this.toolStripMenuItem_History4.Name = "toolStripMenuItem_History4";
            this.toolStripMenuItem_History4.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_History4.Text = " ";
            this.toolStripMenuItem_History4.TextChanged += new System.EventHandler(this.toolStripMenuItem_History4_TextChanged);
            this.toolStripMenuItem_History4.Click += new System.EventHandler(this.toolStripMenuItem_History4_Click);
            // 
            // toolStripMenuItem_History5
            // 
            this.toolStripMenuItem_History5.Name = "toolStripMenuItem_History5";
            this.toolStripMenuItem_History5.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_History5.Text = " ";
            this.toolStripMenuItem_History5.TextChanged += new System.EventHandler(this.toolStripMenuItem_History5_TextChanged);
            this.toolStripMenuItem_History5.Click += new System.EventHandler(this.toolStripMenuItem_History5_Click);
            // 
            // toolStripSeparator99
            // 
            this.toolStripSeparator99.Name = "toolStripSeparator99";
            this.toolStripSeparator99.Size = new System.Drawing.Size(148, 6);
            // 
            // toolStripMenuItem_History_Clear
            // 
            this.toolStripMenuItem_History_Clear.Name = "toolStripMenuItem_History_Clear";
            this.toolStripMenuItem_History_Clear.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem_History_Clear.Text = "Clear &History";
            this.toolStripMenuItem_History_Clear.Click += new System.EventHandler(this.toolStripMenuItem_History_Clear_Click);
            // 
            // toolStripMenuItem_CommandFile_Close
            // 
            this.toolStripMenuItem_CommandFile_Close.Name = "toolStripMenuItem_CommandFile_Close";
            this.toolStripMenuItem_CommandFile_Close.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_CommandFile_Close.Text = "&Close Command File";
            this.toolStripMenuItem_CommandFile_Close.Click += new System.EventHandler(this.toolStripMenuItem_CommandFile_Close_Click);
            // 
            // toolStripSeparator97
            // 
            this.toolStripSeparator97.Name = "toolStripSeparator97";
            this.toolStripSeparator97.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem_Top
            // 
            this.toolStripMenuItem_Top.CheckOnClick = true;
            this.toolStripMenuItem_Top.Name = "toolStripMenuItem_Top";
            this.toolStripMenuItem_Top.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_Top.Text = "Top";
            this.toolStripMenuItem_Top.CheckedChanged += new System.EventHandler(this.toolStripMenuItem_Top_CheckedChanged);
            // 
            // toolStripSeparator98
            // 
            this.toolStripSeparator98.Name = "toolStripSeparator98";
            this.toolStripSeparator98.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem_CommandFile_Exit
            // 
            this.toolStripMenuItem_CommandFile_Exit.Name = "toolStripMenuItem_CommandFile_Exit";
            this.toolStripMenuItem_CommandFile_Exit.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem_CommandFile_Exit.Text = "E&xit";
            this.toolStripMenuItem_CommandFile_Exit.Click += new System.EventHandler(this.toolStripMenuItem_CommandFile_Exit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_PortName
            // 
            this.toolStripLabel_PortName.Name = "toolStripLabel_PortName";
            this.toolStripLabel_PortName.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel_PortName.Text = "Port";
            // 
            // toolStripComboBox_PortName
            // 
            this.toolStripComboBox_PortName.AutoSize = false;
            this.toolStripComboBox_PortName.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBox_PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_PortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.toolStripComboBox_PortName.Name = "toolStripComboBox_PortName";
            this.toolStripComboBox_PortName.Size = new System.Drawing.Size(68, 25);
            // 
            // toolStripLabel_PortStatus
            // 
            this.toolStripLabel_PortStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel_PortStatus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel_PortStatus.Image")));
            this.toolStripLabel_PortStatus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toolStripLabel_PortStatus.Name = "toolStripLabel_PortStatus";
            this.toolStripLabel_PortStatus.Size = new System.Drawing.Size(16, 23);
            this.toolStripLabel_PortStatus.Text = "    ";
            this.toolStripLabel_PortStatus.Click += new System.EventHandler(this.toolStripLabel_PortStatus_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_BaudRate
            // 
            this.toolStripLabel_BaudRate.Name = "toolStripLabel_BaudRate";
            this.toolStripLabel_BaudRate.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel_BaudRate.Text = "BaudRate";
            // 
            // toolStripComboBox_BaudRate
            // 
            this.toolStripComboBox_BaudRate.AutoSize = false;
            this.toolStripComboBox_BaudRate.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_BaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.toolStripComboBox_BaudRate.Name = "toolStripComboBox_BaudRate";
            this.toolStripComboBox_BaudRate.Size = new System.Drawing.Size(66, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_Parity
            // 
            this.toolStripLabel_Parity.Name = "toolStripLabel_Parity";
            this.toolStripLabel_Parity.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel_Parity.Text = "Parity";
            // 
            // toolStripComboBox_Parity
            // 
            this.toolStripComboBox_Parity.AutoSize = false;
            this.toolStripComboBox_Parity.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBox_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.toolStripComboBox_Parity.Name = "toolStripComboBox_Parity";
            this.toolStripComboBox_Parity.Size = new System.Drawing.Size(57, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_DataBits
            // 
            this.toolStripLabel_DataBits.Name = "toolStripLabel_DataBits";
            this.toolStripLabel_DataBits.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel_DataBits.Text = "DataBits";
            // 
            // toolStripComboBox_DataBits
            // 
            this.toolStripComboBox_DataBits.AutoSize = false;
            this.toolStripComboBox_DataBits.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBox_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_DataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.toolStripComboBox_DataBits.Name = "toolStripComboBox_DataBits";
            this.toolStripComboBox_DataBits.Size = new System.Drawing.Size(32, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_StopBits
            // 
            this.toolStripLabel_StopBits.Name = "toolStripLabel_StopBits";
            this.toolStripLabel_StopBits.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel_StopBits.Text = "StopBits";
            // 
            // toolStripComboBox_StopBits
            // 
            this.toolStripComboBox_StopBits.AutoSize = false;
            this.toolStripComboBox_StopBits.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripComboBox_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_StopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.toolStripComboBox_StopBits.Name = "toolStripComboBox_StopBits";
            this.toolStripComboBox_StopBits.Size = new System.Drawing.Size(57, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_Where);
            this.splitContainer1.Panel2.Controls.Add(this.button_Clear);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_ReceiveHex);
            this.splitContainer1.Panel2.Controls.Add(this.button_Save);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_ShowBox);
            this.splitContainer1.Size = new System.Drawing.Size(688, 490);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.treeView_CommandTree);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2MinSize = 130;
            this.splitContainer2.Size = new System.Drawing.Size(682, 350);
            this.splitContainer2.SplitterDistance = 236;
            this.splitContainer2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 166);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView_CommandTree
            // 
            this.treeView_CommandTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_CommandTree.Location = new System.Drawing.Point(0, 0);
            this.treeView_CommandTree.Name = "treeView_CommandTree";
            this.treeView_CommandTree.Size = new System.Drawing.Size(236, 350);
            this.treeView_CommandTree.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label_SelectedCommand_Name);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_Parameters);
            this.splitContainer3.Panel1.Controls.Add(this.label_SelectedCommand);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox_Response);
            this.splitContainer3.Size = new System.Drawing.Size(436, 344);
            this.splitContainer3.SplitterDistance = 166;
            this.splitContainer3.TabIndex = 5;
            // 
            // label_SelectedCommand_Name
            // 
            this.label_SelectedCommand_Name.AutoSize = true;
            this.label_SelectedCommand_Name.BackColor = System.Drawing.SystemColors.Control;
            this.label_SelectedCommand_Name.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SelectedCommand_Name.ForeColor = System.Drawing.Color.Black;
            this.label_SelectedCommand_Name.Location = new System.Drawing.Point(62, 1);
            this.label_SelectedCommand_Name.Name = "label_SelectedCommand_Name";
            this.label_SelectedCommand_Name.Size = new System.Drawing.Size(12, 12);
            this.label_SelectedCommand_Name.TabIndex = 21;
            this.label_SelectedCommand_Name.Text = " ";
            // 
            // groupBox_Parameters
            // 
            this.groupBox_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Parameters.Controls.Add(this.button_CommandSend);
            this.groupBox_Parameters.Controls.Add(this.textBox_Command);
            this.groupBox_Parameters.Controls.Add(this.button_CommandBuild);
            this.groupBox_Parameters.Controls.Add(this.checkBox_CommandHex);
            this.groupBox_Parameters.Controls.Add(this.numericUpDown_Commandms);
            this.groupBox_Parameters.Controls.Add(this.checkBox_CommandAuto);
            this.groupBox_Parameters.Controls.Add(this.uC_ListView_Parameters);
            this.groupBox_Parameters.Location = new System.Drawing.Point(3, 16);
            this.groupBox_Parameters.Name = "groupBox_Parameters";
            this.groupBox_Parameters.Size = new System.Drawing.Size(430, 148);
            this.groupBox_Parameters.TabIndex = 19;
            this.groupBox_Parameters.TabStop = false;
            this.groupBox_Parameters.Text = "Parameters";
            // 
            // button_CommandSend
            // 
            this.button_CommandSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CommandSend.Location = new System.Drawing.Point(349, 119);
            this.button_CommandSend.Name = "button_CommandSend";
            this.button_CommandSend.Size = new System.Drawing.Size(75, 23);
            this.button_CommandSend.TabIndex = 6;
            this.button_CommandSend.Text = "Send";
            this.button_CommandSend.UseVisualStyleBackColor = true;
            // 
            // textBox_Command
            // 
            this.textBox_Command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Command.Location = new System.Drawing.Point(76, 121);
            this.textBox_Command.Name = "textBox_Command";
            this.textBox_Command.Size = new System.Drawing.Size(267, 21);
            this.textBox_Command.TabIndex = 5;
            // 
            // button_CommandBuild
            // 
            this.button_CommandBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CommandBuild.BackColor = System.Drawing.Color.Transparent;
            this.button_CommandBuild.Location = new System.Drawing.Point(6, 119);
            this.button_CommandBuild.Name = "button_CommandBuild";
            this.button_CommandBuild.Size = new System.Drawing.Size(64, 23);
            this.button_CommandBuild.TabIndex = 4;
            this.button_CommandBuild.Text = "Build";
            this.button_CommandBuild.UseVisualStyleBackColor = false;
            // 
            // checkBox_CommandHex
            // 
            this.checkBox_CommandHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_CommandHex.AutoSize = true;
            this.checkBox_CommandHex.Location = new System.Drawing.Point(349, 99);
            this.checkBox_CommandHex.Name = "checkBox_CommandHex";
            this.checkBox_CommandHex.Size = new System.Drawing.Size(72, 16);
            this.checkBox_CommandHex.TabIndex = 3;
            this.checkBox_CommandHex.Text = "Send Hex";
            this.checkBox_CommandHex.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Commandms
            // 
            this.numericUpDown_Commandms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_Commandms.Location = new System.Drawing.Point(120, 97);
            this.numericUpDown_Commandms.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Commandms.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Commandms.Name = "numericUpDown_Commandms";
            this.numericUpDown_Commandms.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown_Commandms.TabIndex = 2;
            this.numericUpDown_Commandms.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox_CommandAuto
            // 
            this.checkBox_CommandAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_CommandAuto.AutoSize = true;
            this.checkBox_CommandAuto.Location = new System.Drawing.Point(6, 99);
            this.checkBox_CommandAuto.Name = "checkBox_CommandAuto";
            this.checkBox_CommandAuto.Size = new System.Drawing.Size(108, 16);
            this.checkBox_CommandAuto.TabIndex = 1;
            this.checkBox_CommandAuto.Text = "Auto Send (ms)";
            this.checkBox_CommandAuto.UseVisualStyleBackColor = true;
            // 
            // uC_ListView_Parameters
            // 
            this.uC_ListView_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_ListView_Parameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.uC_ListView_Parameters.FullRowSelect = true;
            this.uC_ListView_Parameters.GridLines = true;
            this.uC_ListView_Parameters.Location = new System.Drawing.Point(6, 16);
            this.uC_ListView_Parameters.Name = "uC_ListView_Parameters";
            this.uC_ListView_Parameters.Size = new System.Drawing.Size(418, 75);
            this.uC_ListView_Parameters.TabIndex = 0;
            this.uC_ListView_Parameters.UseCompatibleStateImageBehavior = false;
            this.uC_ListView_Parameters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 205;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Length";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 88;
            // 
            // label_SelectedCommand
            // 
            this.label_SelectedCommand.AutoSize = true;
            this.label_SelectedCommand.Location = new System.Drawing.Point(3, 1);
            this.label_SelectedCommand.Name = "label_SelectedCommand";
            this.label_SelectedCommand.Size = new System.Drawing.Size(53, 12);
            this.label_SelectedCommand.TabIndex = 20;
            this.label_SelectedCommand.Text = "Command:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button_ManualClear);
            this.groupBox3.Controls.Add(this.button_ManualSend);
            this.groupBox3.Controls.Add(this.textBox_Manual);
            this.groupBox3.Controls.Add(this.checkBox_ManualHex);
            this.groupBox3.Controls.Add(this.numericUpDown_Manualms);
            this.groupBox3.Controls.Add(this.checkBox_ManualAuto);
            this.groupBox3.Location = new System.Drawing.Point(3, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 65);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual Command";
            // 
            // button_ManualClear
            // 
            this.button_ManualClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ManualClear.Location = new System.Drawing.Point(6, 36);
            this.button_ManualClear.Name = "button_ManualClear";
            this.button_ManualClear.Size = new System.Drawing.Size(64, 23);
            this.button_ManualClear.TabIndex = 12;
            this.button_ManualClear.Text = "Clear";
            this.button_ManualClear.UseVisualStyleBackColor = true;
            // 
            // button_ManualSend
            // 
            this.button_ManualSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ManualSend.Location = new System.Drawing.Point(349, 36);
            this.button_ManualSend.Name = "button_ManualSend";
            this.button_ManualSend.Size = new System.Drawing.Size(75, 23);
            this.button_ManualSend.TabIndex = 11;
            this.button_ManualSend.Text = "Send";
            this.button_ManualSend.UseVisualStyleBackColor = true;
            // 
            // textBox_Manual
            // 
            this.textBox_Manual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Manual.Location = new System.Drawing.Point(76, 38);
            this.textBox_Manual.Name = "textBox_Manual";
            this.textBox_Manual.Size = new System.Drawing.Size(267, 21);
            this.textBox_Manual.TabIndex = 10;
            // 
            // checkBox_ManualHex
            // 
            this.checkBox_ManualHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ManualHex.AutoSize = true;
            this.checkBox_ManualHex.Location = new System.Drawing.Point(349, 16);
            this.checkBox_ManualHex.Name = "checkBox_ManualHex";
            this.checkBox_ManualHex.Size = new System.Drawing.Size(72, 16);
            this.checkBox_ManualHex.TabIndex = 9;
            this.checkBox_ManualHex.Text = "Send Hex";
            this.checkBox_ManualHex.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Manualms
            // 
            this.numericUpDown_Manualms.Location = new System.Drawing.Point(120, 14);
            this.numericUpDown_Manualms.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Manualms.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Manualms.Name = "numericUpDown_Manualms";
            this.numericUpDown_Manualms.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown_Manualms.TabIndex = 8;
            this.numericUpDown_Manualms.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox_ManualAuto
            // 
            this.checkBox_ManualAuto.AutoSize = true;
            this.checkBox_ManualAuto.Location = new System.Drawing.Point(6, 16);
            this.checkBox_ManualAuto.Name = "checkBox_ManualAuto";
            this.checkBox_ManualAuto.Size = new System.Drawing.Size(108, 16);
            this.checkBox_ManualAuto.TabIndex = 7;
            this.checkBox_ManualAuto.Text = "Auto Send (ms)";
            this.checkBox_ManualAuto.UseVisualStyleBackColor = true;
            // 
            // groupBox_Response
            // 
            this.groupBox_Response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Response.Controls.Add(this.uC_ListView_Response);
            this.groupBox_Response.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Response.Name = "groupBox_Response";
            this.groupBox_Response.Size = new System.Drawing.Size(430, 97);
            this.groupBox_Response.TabIndex = 23;
            this.groupBox_Response.TabStop = false;
            this.groupBox_Response.Text = "Response";
            // 
            // uC_ListView_Response
            // 
            this.uC_ListView_Response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_ListView_Response.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.uC_ListView_Response.FullRowSelect = true;
            this.uC_ListView_Response.GridLines = true;
            this.uC_ListView_Response.Location = new System.Drawing.Point(6, 16);
            this.uC_ListView_Response.Name = "uC_ListView_Response";
            this.uC_ListView_Response.Size = new System.Drawing.Size(418, 75);
            this.uC_ListView_Response.TabIndex = 1;
            this.uC_ListView_Response.UseCompatibleStateImageBehavior = false;
            this.uC_ListView_Response.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 205;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Length";
            this.columnHeader7.Width = 55;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            this.columnHeader8.Width = 88;
            // 
            // button_Where
            // 
            this.button_Where.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Where.Location = new System.Drawing.Point(598, 75);
            this.button_Where.Name = "button_Where";
            this.button_Where.Size = new System.Drawing.Size(75, 23);
            this.button_Where.TabIndex = 12;
            this.button_Where.Text = "Where";
            this.button_Where.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.Location = new System.Drawing.Point(598, 104);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // checkBox_ReceiveHex
            // 
            this.checkBox_ReceiveHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ReceiveHex.AutoSize = true;
            this.checkBox_ReceiveHex.Location = new System.Drawing.Point(598, 3);
            this.checkBox_ReceiveHex.Name = "checkBox_ReceiveHex";
            this.checkBox_ReceiveHex.Size = new System.Drawing.Size(72, 16);
            this.checkBox_ReceiveHex.TabIndex = 13;
            this.checkBox_ReceiveHex.Text = "Show Hex";
            this.checkBox_ReceiveHex.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(598, 46);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // textBox_ShowBox
            // 
            this.textBox_ShowBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ShowBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ShowBox.Location = new System.Drawing.Point(3, 0);
            this.textBox_ShowBox.Multiline = true;
            this.textBox_ShowBox.Name = "textBox_ShowBox";
            this.textBox_ShowBox.ReadOnly = true;
            this.textBox_ShowBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ShowBox.Size = new System.Drawing.Size(589, 130);
            this.textBox_ShowBox.TabIndex = 0;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Settings.Controls.Add(this.groupBox_);
            this.tabPage_Settings.Controls.Add(this.groupBox_SerialPort);
            this.tabPage_Settings.Controls.Add(this.textBox4);
            this.tabPage_Settings.Controls.Add(this.textBox3);
            this.tabPage_Settings.Controls.Add(this.textBox2);
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(688, 523);
            this.tabPage_Settings.TabIndex = 2;
            this.tabPage_Settings.Text = "Settings";
            // 
            // groupBox_
            // 
            this.groupBox_.Controls.Add(this.comboBox1);
            this.groupBox_.Controls.Add(this.textBox5);
            this.groupBox_.Location = new System.Drawing.Point(416, 3);
            this.groupBox_.Name = "groupBox_";
            this.groupBox_.Size = new System.Drawing.Size(262, 321);
            this.groupBox_.TabIndex = 6;
            this.groupBox_.TabStop = false;
            this.groupBox_.Text = "SerialPort";
            // 
            // groupBox_SerialPort
            // 
            this.groupBox_SerialPort.Location = new System.Drawing.Point(10, 3);
            this.groupBox_SerialPort.Name = "groupBox_SerialPort";
            this.groupBox_SerialPort.Size = new System.Drawing.Size(127, 321);
            this.groupBox_SerialPort.TabIndex = 5;
            this.groupBox_SerialPort.TabStop = false;
            this.groupBox_SerialPort.Text = "SerialPort";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(56, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 0;
            // 
            // tabPage_Tools
            // 
            this.tabPage_Tools.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Tools.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Tools.Name = "tabPage_Tools";
            this.tabPage_Tools.Size = new System.Drawing.Size(688, 523);
            this.tabPage_Tools.TabIndex = 3;
            this.tabPage_Tools.Text = "Tools";
            // 
            // tabPage_Oscilloscopes
            // 
            this.tabPage_Oscilloscopes.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Oscilloscopes.Controls.Add(this.treeView2);
            this.tabPage_Oscilloscopes.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Oscilloscopes.Name = "tabPage_Oscilloscopes";
            this.tabPage_Oscilloscopes.Size = new System.Drawing.Size(688, 523);
            this.tabPage_Oscilloscopes.TabIndex = 4;
            this.tabPage_Oscilloscopes.Text = "Oscilloscopes";
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(350, 20);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(121, 97);
            this.treeView2.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog_SaveReceivedCommand
            // 
            this.saveFileDialog_SaveReceivedCommand.CheckFileExists = true;
            this.saveFileDialog_SaveReceivedCommand.CreatePrompt = true;
            this.saveFileDialog_SaveReceivedCommand.Filter = "文本文件(*.txt)|*.txt";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "456",
            "123",
            "234"});
            this.comboBox1.Location = new System.Drawing.Point(56, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(692, 546);
            this.Controls.Add(this.tabControl_FuctionSelect);
            this.MinimumSize = new System.Drawing.Size(700, 580);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESP2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl_FuctionSelect.ResumeLayout(false);
            this.tabPage_Command.ResumeLayout(false);
            this.tabPage_Command.PerformLayout();
            this.uC_ToolStrip1.ResumeLayout(false);
            this.uC_ToolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox_Parameters.ResumeLayout(false);
            this.groupBox_Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Commandms)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Manualms)).EndInit();
            this.groupBox_Response.ResumeLayout(false);
            this.tabPage_Settings.ResumeLayout(false);
            this.tabPage_Settings.PerformLayout();
            this.groupBox_.ResumeLayout(false);
            this.groupBox_.PerformLayout();
            this.tabPage_Oscilloscopes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl_FuctionSelect;
        public System.Windows.Forms.TabPage tabPage_Command;
        public System.Windows.Forms.TabPage tabPage_Settings;
        public System.Windows.Forms.TabPage tabPage_Tools;
        public System.Windows.Forms.TabPage tabPage_Oscilloscopes;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TreeView treeView2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.TreeView treeView_CommandTree;
        public System.Windows.Forms.SplitContainer splitContainer3;
        public System.Windows.Forms.Label label_SelectedCommand_Name;
        public System.Windows.Forms.GroupBox groupBox_Parameters;
        public System.Windows.Forms.Button button_CommandSend;
        public System.Windows.Forms.TextBox textBox_Command;
        public System.Windows.Forms.Button button_CommandBuild;
        public System.Windows.Forms.CheckBox checkBox_CommandHex;
        public System.Windows.Forms.NumericUpDown numericUpDown_Commandms;
        public System.Windows.Forms.CheckBox checkBox_CommandAuto;
        public UC_ListView uC_ListView_Parameters;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.Label label_SelectedCommand;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button button_ManualClear;
        public System.Windows.Forms.Button button_ManualSend;
        public System.Windows.Forms.TextBox textBox_Manual;
        public System.Windows.Forms.CheckBox checkBox_ManualHex;
        public System.Windows.Forms.NumericUpDown numericUpDown_Manualms;
        public System.Windows.Forms.CheckBox checkBox_ManualAuto;
        public System.Windows.Forms.GroupBox groupBox_Response;
        public UC_ListView uC_ListView_Response;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.ColumnHeader columnHeader7;
        public System.Windows.Forms.ColumnHeader columnHeader8;
        public System.Windows.Forms.Button button_Where;
        public System.Windows.Forms.Button button_Clear;
        public System.Windows.Forms.CheckBox checkBox_ReceiveHex;
        public System.Windows.Forms.Button button_Save;
        public System.Windows.Forms.TextBox textBox_ShowBox;
        public UC_ToolStrip uC_ToolStrip1;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_CommandFile;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CommandFile_Open;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CommandFile_History;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CommandFile_Close;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator98;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CommandFile_Exit;
        public System.Windows.Forms.GroupBox groupBox_;
        public System.Windows.Forms.GroupBox groupBox_SerialPort;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SaveReceivedCommand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_History1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_History2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_History3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_History4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_History5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator99;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_History_Clear;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_PortName;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_PortName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_BaudRate;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_BaudRate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Parity;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Parity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_DataBits;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_DataBits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_StopBits;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_StopBits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator97;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Top;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_PortStatus;
        private System.Windows.Forms.ComboBox comboBox1;


    }
}