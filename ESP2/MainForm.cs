using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace ESP2
{
    // ����ί��
    public delegate void MyDelegate();

    public partial class MainForm : Form
    {

        #region [--------------��������ʼ��]

        // �ö���־
        public int topcount = 0;
        // ���ڼ��ش򿪹����ļ���·��
        string[] reopenfiles = new string[5] { "", "", "", "", "" };

        // �Զ��崮��ʵ����
        //private UC_SerialPort.PortDataDisplay uc_SerialPort_Displ = new UC_SerialPort.PortDataDisplay
        //    (UC_SerialPort.gss_SerialPort_PortName, UC_SerialPort.gsi_SerialPort_BaudRate, UC_SerialPort.gsp_SerialPort_Parity, UC_SerialPort.gsp_SerialPort_DataBits, UC_SerialPort.gsp_SerialPort_StopBits);
        private UC_SerialPort.PortDataDisplay uc_SerialPort = new UC_SerialPort.PortDataDisplay();
        //   (UC_SerialPort.gss_SerialPort_PortName, UC_SerialPort.gsi_SerialPort_BaudRate, UC_SerialPort.gsp_SerialPort_Parity, UC_SerialPort.gsp_SerialPort_DataBits, UC_SerialPort.gsp_SerialPort_StopBits);

        // ���ص��ļ�·��
        public static string gss_FilePath = "";
        public MainForm()
        {
            InitializeComponent();
        }

        // �������
        private void MainForm_Load(object sender, EventArgs e)
        {
            // ����tabpage
            //tabPage_Oscilloscopes.Parent = null;
            // ��ʾtabpage
            //tabPage5.Parent = tabControl1;

            // ����Ĭ������
            toolStripComboBox_PortName.SelectedItem = toolStripComboBox_PortName.Items[0];
            toolStripComboBox_BaudRate.SelectedItem = toolStripComboBox_BaudRate.Items[5];
            toolStripComboBox_Parity.SelectedItem = toolStripComboBox_Parity.Items[0];
            toolStripComboBox_DataBits.SelectedItem = toolStripComboBox_DataBits.Items[0];
            toolStripComboBox_StopBits.SelectedItem = toolStripComboBox_StopBits.Items[0];

            // �õ����ô���
            getPortName();

            // ����򿪵��ĵ�
            toolStripMenuItem_History1.Text = reopenfiles[0];
            toolStripMenuItem_History2.Text = reopenfiles[1];
            toolStripMenuItem_History3.Text = reopenfiles[2];
            toolStripMenuItem_History4.Text = reopenfiles[3];
            toolStripMenuItem_History5.Text = reopenfiles[4];

            // ���ô��ڲ���
            uc_SerialPort.serialPort.Close();
            MySerialPortSet();
        }

        /// <summary>
        /// �õ����ô���
        /// </summary>
        private void getPortName()
        {
            toolStripComboBox_PortName.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                toolStripComboBox_PortName.Items.Add(s);
                toolStripComboBox_PortName.Text = s;
            }
        }
        #endregion

        #region [----------------------����]

        // ���ô��ڿ��͹�
        private void ChangeSerialPortStatus(bool myNowStatus)
        {
            if (myNowStatus == false)
            {
                uc_SerialPort.whenGetNew -= portDispl_whenGetNew;
                uc_SerialPort.whenGetNew += new UC_SerialPort.WhenGetNew(portDispl_whenGetNew);
                uc_SerialPort.ConnectDeveice();
                UC_SerialPort.gsb_SerialPort_IsOpen = true;
            }
            else if (myNowStatus == true)
            {
                uc_SerialPort.DisconnectDeveice();
                UC_SerialPort.gsb_SerialPort_IsOpen = false;
            }
        }

        // ����ί�д����ڽ�������
        private void portDispl_whenGetNew()
        {
            UC_SerialPort.WhenGetNew ehan = delegate
            {
                // �������ݵĴ���
                SerialPortReceive.SerialPortReceiveProcess(this, uc_SerialPort.dataSrc);
            };

            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(ehan);
                }
            }
            catch
            {
            }
        }
        #endregion

        #region [----------------------�¼�]
        // �������ĵ���ť
        private void toolStripMenuItem_CommandFile_Open_Click(object sender, EventArgs e)
        {
            gss_FilePath = Application.StartupPath;
            openFileDialog.InitialDirectory = gss_FilePath;
            openFileDialog.Filter = "�����ļ�(*.xml)|*.xml";
            openFileDialog.ShowDialog();
        }

        // �ر������ĵ���ť
        private void toolStripMenuItem_CommandFile_Close_Click(object sender, EventArgs e)
        {
            // ������м�����Ŀ
            treeView_CommandTree.Nodes.Clear();
            label_SelectedCommand_Name.Text = " ";
            uC_ListView_Parameters.Items.Clear();
            uC_ListView_Response.Items.Clear();
        }

        // �˳���ť
        private void toolStripMenuItem_CommandFile_Exit_Click(object sender, EventArgs e)
        {
            if (uc_SerialPort.serialPort.IsOpen == true)
            {
                // ��Ϊ�򿪴�����رմ���
                ChangeSerialPortStatus(uc_SerialPort.serialPort.IsOpen);
            }

            // ǿ�ƹر����д��뼶����
            System.Environment.Exit(0);
            // ������Դ
            this.Dispose();
            // �رյ�ǰ����
            this.Close();
            // �ر����к�̨����
            Application.Exit();
        }

        // �ö���ť
        private void toolStripMenuItem_Top_CheckedChanged(object sender, EventArgs e)
        {
            topcount++;
            if (topcount % 2 == 1)
            {
                toolStripMenuItem_Top.Checked = true;
                this.TopMost = true;
            }
            else
            {

                toolStripMenuItem_Top.Checked = false;
                this.TopMost = false;
            }

            if (topcount >= 2)
            {
                topcount = 0;
            }
        }

        // ������ĵ���ť��click�¼�
        private void toolStripMenuItem_History1_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadTreeNodes(toolStripMenuItem_History1.Text);
            }
            catch (Exception)
            {
                //MessageBox.Show("��ʧ�ܣ�" + ex.Message);
                toolStripMenuItem_History1.Text = toolStripMenuItem_History2.Text;
                toolStripMenuItem_History2.Text = toolStripMenuItem_History3.Text;
                toolStripMenuItem_History3.Text = toolStripMenuItem_History4.Text;
                toolStripMenuItem_History4.Text = toolStripMenuItem_History5.Text;
                toolStripMenuItem_History5.Text = "";
                this.Text = "ESP2";
            }
        }

        // ������ĵ����ֱ仯
        private void toolStripMenuItem_History1_TextChanged(object sender, EventArgs e)
        {

            if (toolStripMenuItem_History1.Text == "")
            {
                toolStripMenuItem_History1.Visible = false;
                toolStripSeparator99.Visible = false;
                toolStripMenuItem_History_Clear.Enabled = false;
            }
            else
            {
                toolStripMenuItem_History1.Visible = true;
                toolStripSeparator99.Visible = true;
                toolStripMenuItem_History_Clear.Enabled = true;
            }
        }

        // ������ĵ���ť��click�¼�
        private void toolStripMenuItem_History2_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadTreeNodes(toolStripMenuItem_History2.Text);
            }
            catch (Exception)
            {
                //MessageBox.Show("��ʧ�ܣ�" + ex.Message);
                //toolStripMenuItem_History1.Text = toolStripMenuItem_History2.Text;
                toolStripMenuItem_History2.Text = toolStripMenuItem_History3.Text;
                toolStripMenuItem_History3.Text = toolStripMenuItem_History4.Text;
                toolStripMenuItem_History4.Text = toolStripMenuItem_History5.Text;
                toolStripMenuItem_History5.Text = "";
                this.Text = "ESP2";
            }
        }

        // ������ĵ����ֱ仯
        private void toolStripMenuItem_History2_TextChanged(object sender, EventArgs e)
        {

            if (toolStripMenuItem_History2.Text == "")
            {
                toolStripMenuItem_History2.Visible = false;
            }
            else
            {
                toolStripMenuItem_History2.Visible = true;
            }
        }

        // ������ĵ���ť��click�¼�
        private void toolStripMenuItem_History3_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadTreeNodes(toolStripMenuItem_History3.Text);
            }
            catch (Exception)
            {
                //MessageBox.Show("��ʧ�ܣ�" + ex.Message);
                //toolStripMenuItem_History1.Text = toolStripMenuItem_History2.Text;
                //toolStripMenuItem_History2.Text = toolStripMenuItem_History3.Text;
                toolStripMenuItem_History3.Text = toolStripMenuItem_History4.Text;
                toolStripMenuItem_History4.Text = toolStripMenuItem_History5.Text;
                toolStripMenuItem_History5.Text = "";
                this.Text = "ESP2";
            }
        }

        // ������ĵ����ֱ仯
        private void toolStripMenuItem_History3_TextChanged(object sender, EventArgs e)
        {

            if (toolStripMenuItem_History3.Text == "")
            {
                toolStripMenuItem_History3.Visible = false;
            }
            else
            {
                toolStripMenuItem_History3.Visible = true;
            }
        }

        // ������ĵ���ť��click�¼�
        private void toolStripMenuItem_History4_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadTreeNodes(toolStripMenuItem_History4.Text);
            }
            catch (Exception)
            {
                //MessageBox.Show("��ʧ�ܣ�" + ex.Message);
                //toolStripMenuItem_History1.Text = toolStripMenuItem_History2.Text;
                //toolStripMenuItem_History2.Text = toolStripMenuItem_History3.Text;
                //toolStripMenuItem_History3.Text = toolStripMenuItem_History4.Text;
                toolStripMenuItem_History4.Text = toolStripMenuItem_History5.Text;
                toolStripMenuItem_History5.Text = "";
                this.Text = "ESP2";
            }
        }

        // ������ĵ����ֱ仯
        private void toolStripMenuItem_History4_TextChanged(object sender, EventArgs e)
        {

            if (toolStripMenuItem_History4.Text == "")
            {
                toolStripMenuItem_History4.Visible = false;
            }
            else
            {
                toolStripMenuItem_History4.Visible = true;
            }
        }

        // ������ĵ���ť��click�¼�
        private void toolStripMenuItem_History5_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadTreeNodes(toolStripMenuItem_History5.Text);
            }
            catch (Exception)
            {
                //MessageBox.Show("��ʧ�ܣ�" + ex.Message);
                //toolStripMenuItem_History1.Text = toolStripMenuItem_History2.Text;
                //toolStripMenuItem_History2.Text = toolStripMenuItem_History3.Text;
                //toolStripMenuItem_History3.Text = toolStripMenuItem_History4.Text;
                //toolStripMenuItem_History4.Text = toolStripMenuItem_History5.Text;
                toolStripMenuItem_History5.Text = "";
                this.Text = "ESP2";
            }
        }

        // ������ĵ����ֱ仯
        private void toolStripMenuItem_History5_TextChanged(object sender, EventArgs e)
        {

            if (toolStripMenuItem_History5.Text == "")
            {
                toolStripMenuItem_History5.Visible = false;
            }
            else
            {
                toolStripMenuItem_History5.Visible = true;
            }
        }

        // �����ʷ��¼
        private void toolStripMenuItem_History_Clear_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_History5.Text = "";
            toolStripMenuItem_History4.Text = "";
            toolStripMenuItem_History3.Text = "";
            toolStripMenuItem_History2.Text = "";
            toolStripMenuItem_History1.Text = "";
            XmlDocument deletefile = new XmlDocument();
            deletefile.Load(Application.StartupPath + @"\ESPConfig.cds");
            deletefile.SelectSingleNode("Config/MRU/Item_4").InnerText = "";
            deletefile.SelectSingleNode("Config/MRU/Item_3").InnerText = "";
            deletefile.SelectSingleNode("Config/MRU/Item_2").InnerText = "";
            deletefile.SelectSingleNode("Config/MRU/Item_1").InnerText = "";
            deletefile.SelectSingleNode("Config/MRU/Item_0").InnerText = "";
            deletefile.Save(Application.StartupPath + @"\ESPConfig.cds");
        }
        #endregion

        // ��ӽڵ�
        private void LoadTreeNodes(string xmlPath)
        {
            /*
            try
            {
                // ��մ洢ֵ
                //Array.Clear(mystore,0,mystore.Length);
                // �±�����
                //mystorecounter = 0;
                mystoreindex = 0;
                mycountindex = 0;
                mycountin = 0;
                // ��ղ���
                label1.Text = "";
                treeView1.Nodes.Clear();
                listViewEA1.Items.Clear();
                listViewEA2.Items.Clear();
                // ����ַ������adress�У��ڵ���treeView�Ľڵ�ʱ���ȡadress��ֵ
                adress = xmlPath;
                // �жϴ򿪵��ļ�������ʷ��¼�е��ļ����Ƿ�һ��
                if (xmlPath == toolStripMenuItem121.Text)
                { }
                else if (xmlPath == toolStripMenuItem122.Text)
                {
                    toolStripMenuItem122.Text = toolStripMenuItem121.Text;
                    toolStripMenuItem121.Text = xmlPath;
                }
                else if (xmlPath == toolStripMenuItem123.Text)
                {
                    toolStripMenuItem123.Text = toolStripMenuItem122.Text;
                    toolStripMenuItem122.Text = toolStripMenuItem121.Text;
                    toolStripMenuItem121.Text = xmlPath;
                }
                else if (xmlPath == toolStripMenuItem124.Text)
                {
                    toolStripMenuItem124.Text = toolStripMenuItem123.Text;
                    toolStripMenuItem123.Text = toolStripMenuItem122.Text;
                    toolStripMenuItem122.Text = toolStripMenuItem121.Text;
                    toolStripMenuItem121.Text = xmlPath;
                }
                else if (xmlPath == toolStripMenuItem125.Text)
                {
                    toolStripMenuItem125.Text = toolStripMenuItem124.Text;
                    toolStripMenuItem124.Text = toolStripMenuItem123.Text;
                    toolStripMenuItem123.Text = toolStripMenuItem122.Text;
                    toolStripMenuItem122.Text = toolStripMenuItem121.Text;
                    toolStripMenuItem121.Text = xmlPath;
                }
                else if (xmlPath != toolStripMenuItem121.Text && xmlPath != toolStripMenuItem122.Text && xmlPath != toolStripMenuItem123.Text && xmlPath != toolStripMenuItem124.Text && xmlPath != toolStripMenuItem125.Text)
                {
                    toolStripMenuItem125.Text = toolStripMenuItem124.Text;
                    toolStripMenuItem124.Text = toolStripMenuItem123.Text;
                    toolStripMenuItem123.Text = toolStripMenuItem122.Text;
                    toolStripMenuItem122.Text = toolStripMenuItem121.Text;
                    toolStripMenuItem121.Text = xmlPath;
                }
                // ��·����ӵ�ESPConfig.cds��
                XmlDocument savecds = new XmlDocument();
                if (File.Exists(Application.StartupPath + @"\ESPConfig.cds"))
                {
                    savecds.Load(Application.StartupPath + @"\ESPConfig.cds");
                    if (xmlPath == savecds.SelectSingleNode("Config/MRU/Item_0").InnerText)
                    { }
                    else if (xmlPath == savecds.SelectSingleNode("Config/MRU/Item_1").InnerText)
                    {
                        savecds.SelectSingleNode("Config/MRU/Item_1").InnerText = savecds.SelectSingleNode("Config/MRU/Item_0").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_0").InnerText = xmlPath;
                    }
                    else if (xmlPath == savecds.SelectSingleNode("Config/MRU/Item_2").InnerText)
                    {
                        savecds.SelectSingleNode("Config/MRU/Item_2").InnerText = savecds.SelectSingleNode("Config/MRU/Item_1").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_1").InnerText = savecds.SelectSingleNode("Config/MRU/Item_0").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_0").InnerText = xmlPath;
                    }
                    else if (xmlPath == savecds.SelectSingleNode("Config/MRU/Item_3").InnerText)
                    {
                        savecds.SelectSingleNode("Config/MRU/Item_3").InnerText = savecds.SelectSingleNode("Config/MRU/Item_2").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_2").InnerText = savecds.SelectSingleNode("Config/MRU/Item_1").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_1").InnerText = savecds.SelectSingleNode("Config/MRU/Item_0").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_0").InnerText = xmlPath;
                    }
                    else if (xmlPath == savecds.SelectSingleNode("Config/MRU/Item_4").InnerText)
                    {
                        savecds.SelectSingleNode("Config/MRU/Item_4").InnerText = savecds.SelectSingleNode("Config/MRU/Item_3").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_3").InnerText = savecds.SelectSingleNode("Config/MRU/Item_2").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_2").InnerText = savecds.SelectSingleNode("Config/MRU/Item_1").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_1").InnerText = savecds.SelectSingleNode("Config/MRU/Item_0").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_0").InnerText = xmlPath;
                    }
                    else if (xmlPath != savecds.SelectSingleNode("Config/MRU/Item_0").InnerText && xmlPath != savecds.SelectSingleNode("Config/MRU/Item_1").InnerText && xmlPath != savecds.SelectSingleNode("Config/MRU/Item_2").InnerText && xmlPath != savecds.SelectSingleNode("Config/MRU/Item_3").InnerText && xmlPath != savecds.SelectSingleNode("Config/MRU/Item_4").InnerText)
                    {
                        savecds.SelectSingleNode("Config/MRU/Item_4").InnerText = savecds.SelectSingleNode("Config/MRU/Item_3").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_3").InnerText = savecds.SelectSingleNode("Config/MRU/Item_2").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_2").InnerText = savecds.SelectSingleNode("Config/MRU/Item_1").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_1").InnerText = savecds.SelectSingleNode("Config/MRU/Item_0").InnerText;
                        savecds.SelectSingleNode("Config/MRU/Item_0").InnerText = xmlPath;
                    }
                    savecds.Save(Application.StartupPath + @"\ESPConfig.cds");
                }
                else
                {
                    // ���������������
                    buildConfigurationFile();
                }
                // ��·����Ϣȥ����ֻ�����ļ����ƺ��ļ�����
                string filename = xmlPath.Substring(xmlPath.LastIndexOf("\\") + 1);
                // ��ʾ��Form1����ı�����
                this.Text = "ESP" + " - " + filename;
                this.xmlDoc = new XmlDocument();
                this.xmlDoc.Load(xmlPath);


                start = xmlDoc.SelectSingleNode("Personality").Attributes["Start"].InnerText;
                stop = xmlDoc.SelectSingleNode("Personality").Attributes["Stop"].InnerText;
                checkstyle = xmlDoc.SelectSingleNode("Personality").Attributes["CheckStyle"].InnerText;
                ci = xmlDoc.SelectSingleNode("Personality").Attributes["CI"].InnerText;
                cmi = xmlDoc.SelectSingleNode("Personality").Attributes["CMI"].InnerText;
                li = xmlDoc.SelectSingleNode("Personality").Attributes["LI"].InnerText;
                pi = xmlDoc.SelectSingleNode("Personality").Attributes["PI"].InnerText;
                csi = xmlDoc.SelectSingleNode("Personality").Attributes["CSI"].InnerText;
                compare = xmlDoc.SelectSingleNode("Personality").Attributes["Compare"].InnerText;
                relength = xmlDoc.SelectSingleNode("Personality").Attributes["Relength"].InnerText;
                recall = xmlDoc.SelectSingleNode("Personality").Attributes["Recall"].InnerText;
                restop = xmlDoc.SelectSingleNode("Personality").Attributes["Restop"].InnerText;
                ishex = xmlDoc.SelectSingleNode("Personality").Attributes["HEX"].InnerText;
                checkBox5.Checked = Convert.ToBoolean(ishex);
                checkBox3.Checked = Convert.ToBoolean(ishex);
                checkBox1.Checked = Convert.ToBoolean(ishex);

                // �����ڴ����������ȡ��������
                XmlNode nodesp = this.xmlDoc.SelectSingleNode("Personality/Serialport");
                if (nodesp != null)
                {
                    spconfig[1] = nodesp.Attributes["braudrate"].InnerText;
                    spconfig[2] = nodesp.Attributes["parity"].InnerText;
                    serialPort1.BaudRate = Convert.ToInt32(spconfig[1]);
                    if (spconfig[2] == "None")
                    { serialPort1.Parity = Parity.None; }
                    else if (spconfig[2] == "Odd")
                    { serialPort1.Parity = Parity.Odd; }
                    else if (spconfig[2] == "Even")
                    { serialPort1.Parity = Parity.Even; }
                    else if (spconfig[2] == "Mark")
                    { serialPort1.Parity = Parity.Mark; }
                    else if (spconfig[2] == "Space")
                    { serialPort1.Parity = Parity.Space; }
                    toolStripStatusLabel1.Text = serialPort1.PortName + " " + "Closed" + "," + serialPort1.BaudRate + "," + serialPort1.Parity + "," + serialPort1.DataBits + "," + serialPort1.StopBits;
                }

                // ������CRC�����ȡCRC��
                XmlNode CRCNode = this.xmlDoc.SelectSingleNode("Personality/CRC");
                if (CRCNode != null)
                {
                    TempCRCTable = CRCNode.InnerText;
                    CRCType = Convert.ToUInt16(CRCNode.Attributes["crctype"].InnerText);
                    if (checkstyle == "CRC16_1")
                    {
                        if (TempCRCTable.Length == 6 * 256)
                        {
                            for (int cc = 0; cc < 256; cc++)
                            {
                                CRC16LookupTable[cc] = Convert.ToUInt16(TempCRCTable.Substring(cc * 6 + 2, 4), 16);
                            }
                        }
                    }
                    else if (checkstyle == "CRC8_1")
                    {
                        if (TempCRCTable.Length == 4 * 256)
                        {
                            for (int cc = 0; cc < 256; cc++)
                            {
                                CRC8LookupTable[cc] = Convert.ToByte(TempCRCTable.Substring(cc * 4 + 2, 2), 16);
                            }
                        }
                    }
                    else if (checkstyle == "CRC8_2")
                    {
                        if (TempCRCTable.Length == 4 * 256)
                        {
                            for (int cc = 0; cc < 256; cc++)
                            {
                                CRC8LookupTable[cc] = Convert.ToByte(TempCRCTable.Substring(cc * 4 + 2, 2), 16);
                            }
                        }
                    }
                }

                XmlNodeList nodelist = this.xmlDoc.SelectNodes("Personality/Module");
                this.treeView1.BeginUpdate();
                this.treeView1.Nodes.Clear();
                this.ConvertXmlNodeToTreeNode(nodelist, this.treeView1.Nodes);
                this.treeView1.EndUpdate();
            }
            catch (Exception)
            {
                //MessageBox.Show("�������:" + ex.Message, "�쳣", MessageBoxButtons.OK, MessageBoxIcon.Error);
                XmlDocument itemcds = new XmlDocument();
                treeView1.Nodes.Clear();
                itemcds.Load(Application.StartupPath + @"\ESPConfig.cds");
                itemcds.SelectSingleNode("Config/MRU/Item_0").InnerText = itemcds.SelectSingleNode("Config/MRU/Item_1").InnerText;
                itemcds.SelectSingleNode("Config/MRU/Item_1").InnerText = itemcds.SelectSingleNode("Config/MRU/Item_2").InnerText;
                itemcds.SelectSingleNode("Config/MRU/Item_2").InnerText = itemcds.SelectSingleNode("Config/MRU/Item_3").InnerText;
                itemcds.SelectSingleNode("Config/MRU/Item_3").InnerText = itemcds.SelectSingleNode("Config/MRU/Item_4").InnerText;
                itemcds.SelectSingleNode("Config/MRU/Item_4").InnerText = "";
                this.Text = "ESP";
                itemcds.Save(Application.StartupPath + @"\ESPConfig.cds");
                toolStripMenuItem121.Text = toolStripMenuItem122.Text;
                toolStripMenuItem122.Text = toolStripMenuItem123.Text;
                toolStripMenuItem123.Text = toolStripMenuItem124.Text;
                toolStripMenuItem124.Text = toolStripMenuItem125.Text;
                toolStripMenuItem125.Text = "";
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySerialPortSet();

            // ���Դ��������Ƿ���ȷ
            uc_SerialPort.ConnectDeveice();

            textBox1.Text = uc_SerialPort.serialPort.PortName.ToString() + "\r\n" +
                uc_SerialPort.serialPort.BaudRate.ToString() + "\r\n" +
                uc_SerialPort.serialPort.Parity.ToString() + "\r\n" +
                uc_SerialPort.serialPort.DataBits.ToString() + "\r\n" +
                uc_SerialPort.serialPort.StopBits.ToString() + "\r\n" +
                uc_SerialPort.serialPort.IsOpen.ToString();
        }

        // ���ô��ڲ���
        public void MySerialPortSet()
        {

            UC_SerialPort.gss_SerialPort_PortName = toolStripComboBox_PortName.Text;
            UC_SerialPort.gsi_SerialPort_BaudRate = Convert.ToInt32(toolStripComboBox_BaudRate.Text);
            if (toolStripComboBox_Parity.Text == "None")
            {
                UC_SerialPort.gsp_SerialPort_Parity = Parity.None;
            }
            else if (toolStripComboBox_Parity.Text == "Odd")
            {
                UC_SerialPort.gsp_SerialPort_Parity = Parity.Odd;
            }
            else if (toolStripComboBox_Parity.Text == "Even")
            {
                UC_SerialPort.gsp_SerialPort_Parity = Parity.Even;
            }
            else
            {
                UC_SerialPort.gsp_SerialPort_Parity = Parity.None;
            }
            UC_SerialPort.gsp_SerialPort_DataBits = Convert.ToInt32(toolStripComboBox_DataBits.Text);
            if (toolStripComboBox_StopBits.Text == "1")
            {
                UC_SerialPort.gsp_SerialPort_StopBits = StopBits.One;
            }
            else if (toolStripComboBox_StopBits.Text == "2")
            {
                UC_SerialPort.gsp_SerialPort_StopBits = StopBits.Two;
            }
            else
            {
                UC_SerialPort.gsp_SerialPort_StopBits = StopBits.One;
            }

            uc_SerialPort.serialPortSet(UC_SerialPort.gss_SerialPort_PortName, UC_SerialPort.gsi_SerialPort_BaudRate, UC_SerialPort.gsp_SerialPort_Parity, UC_SerialPort.gsp_SerialPort_DataBits, UC_SerialPort.gsp_SerialPort_StopBits);

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //���浽.cds�����ļ�
            try
            {
                //���ص�treeView��
                this.LoadTreeNodes(openFileDialog.FileName);
            }
            catch (Exception)
            {
                //MessageBox.Show("�����ĵ��ṹ����" + ex.Message);
                this.Text = "ESP2";
                XmlDocument itemcds = new XmlDocument();
                treeView_CommandTree.Nodes.Clear();
                itemcds.Load(Application.StartupPath + @"\ESPConfig.cds");
                itemcds.SelectSingleNode("Config/MRU/Item_0").InnerText = itemcds.SelectSingleNode("Config/MRU/Item_1").InnerText;
                itemcds.SelectSingleNode("Config/MRU/Item_1").InnerText = itemcds.SelectSingleNode("Config/MRU/Item_2").InnerText;
                itemcds.SelectSingleNode("Config/MRU/Item_2").InnerText = itemcds.SelectSingleNode("Config/MRU/Item_3").InnerText;
                itemcds.SelectSingleNode("Config/MRU/Item_3").InnerText = itemcds.SelectSingleNode("Config/MRU/Item_4").InnerText;
                itemcds.SelectSingleNode("Config/MRU/Item_4").InnerText = "";
                itemcds.Save(Application.StartupPath + @"\ESPConfig.cds");
                toolStripMenuItem_History1.Text = toolStripMenuItem_History2.Text;
                toolStripMenuItem_History2.Text = toolStripMenuItem_History3.Text;
                toolStripMenuItem_History3.Text = toolStripMenuItem_History4.Text;
                toolStripMenuItem_History4.Text = toolStripMenuItem_History5.Text;
                toolStripMenuItem_History5.Text = "";
            }
        }

        private void toolStripLabel_PortStatus_Click(object sender, EventArgs e)
        {
            if (uc_SerialPort.serialPort.IsOpen)
            {
                uc_SerialPort.DisconnectDeveice();
            }
            else
            {
                uc_SerialPort.ConnectDeveice();
            }

            // �����Ȳ������ڿ��أ�Ȼ��������ݵ�ǰ���ڿ������ж�Ӧ��ʾ��ͼ��
            if (uc_SerialPort.serialPort.IsOpen)
            {
                toolStripLabel_PortStatus.Image = Properties.Resources.connected;
            }
            else
            {
                toolStripLabel_PortStatus.Image = Properties.Resources.disconnected;
            }
        }

        string[] E1E1 = new string[5] { "11", "22", "33", "44", "55" };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "123")
            {
                textBox5.Text = "666";
                comboBox1.Items.AddRange(E1E1);
            }
        }

    }
}