namespace ESP2
{
    partial class layout2
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "111",
            "22",
            "33",
            "44"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "222",
            "22",
            "33",
            "44"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "111",
            "22",
            "33",
            "44"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "222",
            "22",
            "33",
            "44"}, -1);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView_CommandList = new System.Windows.Forms.TreeView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
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
            this.uC_ListView2 = new ESP2.UC_ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
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
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(6, 27);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView_CommandList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(682, 350);
            this.splitContainer2.SplitterDistance = 236;
            this.splitContainer2.TabIndex = 13;
            // 
            // treeView_CommandList
            // 
            this.treeView_CommandList.Location = new System.Drawing.Point(0, 0);
            this.treeView_CommandList.Name = "treeView_CommandList";
            this.treeView_CommandList.Size = new System.Drawing.Size(236, 350);
            this.treeView_CommandList.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Test Command ABCDEFGHIJKLMN";
            // 
            // groupBox_Parameters
            // 
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
            this.uC_ListView_Parameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.uC_ListView_Parameters.FullRowSelect = true;
            this.uC_ListView_Parameters.GridLines = true;
            this.uC_ListView_Parameters.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
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
            this.button_ManualSend.Location = new System.Drawing.Point(346, 36);
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
            this.textBox_Manual.Size = new System.Drawing.Size(264, 21);
            this.textBox_Manual.TabIndex = 10;
            // 
            // checkBox_ManualHex
            // 
            this.checkBox_ManualHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ManualHex.AutoSize = true;
            this.checkBox_ManualHex.Location = new System.Drawing.Point(346, 16);
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
            this.groupBox_Response.Controls.Add(this.uC_ListView2);
            this.groupBox_Response.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Response.Name = "groupBox_Response";
            this.groupBox_Response.Size = new System.Drawing.Size(430, 97);
            this.groupBox_Response.TabIndex = 23;
            this.groupBox_Response.TabStop = false;
            this.groupBox_Response.Text = "Response";
            // 
            // uC_ListView2
            // 
            this.uC_ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.uC_ListView2.FullRowSelect = true;
            this.uC_ListView2.GridLines = true;
            this.uC_ListView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.uC_ListView2.Location = new System.Drawing.Point(6, 16);
            this.uC_ListView2.Name = "uC_ListView2";
            this.uC_ListView2.Size = new System.Drawing.Size(418, 75);
            this.uC_ListView2.TabIndex = 1;
            this.uC_ListView2.UseCompatibleStateImageBehavior = false;
            this.uC_ListView2.View = System.Windows.Forms.View.Details;
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
            // layout2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 546);
            this.Controls.Add(this.splitContainer2);
            this.Name = "layout2";
            this.Text = "layout2";
            this.splitContainer2.Panel1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView_CommandList;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Parameters;
        private System.Windows.Forms.Button button_CommandSend;
        private System.Windows.Forms.TextBox textBox_Command;
        private System.Windows.Forms.Button button_CommandBuild;
        private System.Windows.Forms.CheckBox checkBox_CommandHex;
        private System.Windows.Forms.NumericUpDown numericUpDown_Commandms;
        private System.Windows.Forms.CheckBox checkBox_CommandAuto;
        private UC_ListView uC_ListView_Parameters;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label_SelectedCommand;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_ManualClear;
        private System.Windows.Forms.Button button_ManualSend;
        private System.Windows.Forms.TextBox textBox_Manual;
        private System.Windows.Forms.CheckBox checkBox_ManualHex;
        private System.Windows.Forms.NumericUpDown numericUpDown_Manualms;
        private System.Windows.Forms.CheckBox checkBox_ManualAuto;
        private System.Windows.Forms.GroupBox groupBox_Response;
        private UC_ListView uC_ListView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}