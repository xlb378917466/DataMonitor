﻿namespace DataMonitor.DQ.UI.UIForm
{
    partial class EditDeviceForm
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
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.ipAddressInput1 = new DevComponents.Editors.IpAddressInput();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtTemperatureAlarmLowerLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.txtTemperatureForewarningLowerLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtTemperatureForewarningUpperLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtTemperatureAlarmUpperLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX6 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtHumidityAlarmLowerLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtHumidityForewarningLowerLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.txtHumidityForewarningUpperLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.txtHumidityAlarmUpperLimit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "DeviceName", true));
            this.textBoxX1.Location = new System.Drawing.Point(134, 6);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(284, 21);
            this.textBoxX1.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(62, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(66, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "测点名称：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(77, 104);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(51, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "测点ID";
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "DeviceNum", true));
            this.textBoxX2.Location = new System.Drawing.Point(134, 104);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(131, 21);
            this.textBoxX2.TabIndex = 3;
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SaveRecordInterval", true));
            this.textBoxX3.Location = new System.Drawing.Point(135, 192);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(113, 21);
            this.textBoxX3.TabIndex = 4;
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Port", true));
            this.textBoxX4.Location = new System.Drawing.Point(318, 69);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.PreventEnterBeep = true;
            this.textBoxX4.Size = new System.Drawing.Size(100, 21);
            this.textBoxX4.TabIndex = 4;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(290, 163);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(128, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "超限数据间隔（分钟）";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(275, 65);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(32, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "端口";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(134, 163);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(131, 23);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "记录数据间隔（分钟）";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(75, 65);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(51, 23);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "IP地址";
            // 
            // ipAddressInput1
            // 
            this.ipAddressInput1.AutoOverwrite = true;
            // 
            // 
            // 
            this.ipAddressInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipAddressInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipAddressInput1.ButtonFreeText.Visible = true;
            this.ipAddressInput1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "IPAddress", true));
            this.ipAddressInput1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "IPAddress", true));
            this.ipAddressInput1.Location = new System.Drawing.Point(134, 67);
            this.ipAddressInput1.Name = "ipAddressInput1";
            this.ipAddressInput1.Size = new System.Drawing.Size(131, 21);
            this.ipAddressInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipAddressInput1.TabIndex = 7;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(65, 133);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(54, 23);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "库房属性";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 15;
            this.comboBoxEx1.Location = new System.Drawing.Point(134, 134);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(284, 21);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 9;
            this.comboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEx1_SelectedIndexChanged_1);
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ExceedDataInterval", true));
            this.textBoxX5.Location = new System.Drawing.Point(290, 192);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.PreventEnterBeep = true;
            this.textBoxX5.Size = new System.Drawing.Size(128, 21);
            this.textBoxX5.TabIndex = 10;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel1.Controls.Add(this.checkBoxX2);
            this.groupPanel1.Controls.Add(this.txtTemperatureAlarmLowerLimit);
            this.groupPanel1.Controls.Add(this.labelX14);
            this.groupPanel1.Controls.Add(this.txtTemperatureForewarningLowerLimit);
            this.groupPanel1.Controls.Add(this.labelX13);
            this.groupPanel1.Controls.Add(this.txtTemperatureForewarningUpperLimit);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Controls.Add(this.txtTemperatureAlarmUpperLimit);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(48, 219);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(228, 224);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 11;
            this.groupPanel1.Text = "温度";
            // 
            // checkBoxX2
            // 
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "TemperatureLimitCanUse", true));
            this.checkBoxX2.Location = new System.Drawing.Point(83, 170);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 22;
            this.checkBoxX2.Text = "启用";
            // 
            // txtTemperatureAlarmLowerLimit
            // 
            // 
            // 
            // 
            this.txtTemperatureAlarmLowerLimit.Border.Class = "TextBoxBorder";
            this.txtTemperatureAlarmLowerLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTemperatureAlarmLowerLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TemperatureAlarmLowerLimit", true));
            this.txtTemperatureAlarmLowerLimit.Location = new System.Drawing.Point(85, 54);
            this.txtTemperatureAlarmLowerLimit.Name = "txtTemperatureAlarmLowerLimit";
            this.txtTemperatureAlarmLowerLimit.PreventEnterBeep = true;
            this.txtTemperatureAlarmLowerLimit.Size = new System.Drawing.Size(100, 21);
            this.txtTemperatureAlarmLowerLimit.TabIndex = 20;
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(13, 54);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(64, 23);
            this.labelX14.TabIndex = 19;
            this.labelX14.Text = "报警下限";
            // 
            // txtTemperatureForewarningLowerLimit
            // 
            // 
            // 
            // 
            this.txtTemperatureForewarningLowerLimit.Border.Class = "TextBoxBorder";
            this.txtTemperatureForewarningLowerLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTemperatureForewarningLowerLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TemperatureForewarningLowerLimit", true));
            this.txtTemperatureForewarningLowerLimit.Location = new System.Drawing.Point(86, 133);
            this.txtTemperatureForewarningLowerLimit.Name = "txtTemperatureForewarningLowerLimit";
            this.txtTemperatureForewarningLowerLimit.PreventEnterBeep = true;
            this.txtTemperatureForewarningLowerLimit.Size = new System.Drawing.Size(100, 21);
            this.txtTemperatureForewarningLowerLimit.TabIndex = 18;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(11, 129);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(66, 23);
            this.labelX13.TabIndex = 17;
            this.labelX13.Text = "预警下限";
            // 
            // txtTemperatureForewarningUpperLimit
            // 
            // 
            // 
            // 
            this.txtTemperatureForewarningUpperLimit.Border.Class = "TextBoxBorder";
            this.txtTemperatureForewarningUpperLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTemperatureForewarningUpperLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TemperatureForewarningUpperLimit", true));
            this.txtTemperatureForewarningUpperLimit.Location = new System.Drawing.Point(83, 93);
            this.txtTemperatureForewarningUpperLimit.Name = "txtTemperatureForewarningUpperLimit";
            this.txtTemperatureForewarningUpperLimit.PreventEnterBeep = true;
            this.txtTemperatureForewarningUpperLimit.Size = new System.Drawing.Size(100, 21);
            this.txtTemperatureForewarningUpperLimit.TabIndex = 16;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(11, 93);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(66, 23);
            this.labelX12.TabIndex = 15;
            this.labelX12.Text = "预警上限";
            // 
            // txtTemperatureAlarmUpperLimit
            // 
            // 
            // 
            // 
            this.txtTemperatureAlarmUpperLimit.Border.Class = "TextBoxBorder";
            this.txtTemperatureAlarmUpperLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTemperatureAlarmUpperLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TemperatureAlarmUpperLimit", true));
            this.txtTemperatureAlarmUpperLimit.Location = new System.Drawing.Point(84, 18);
            this.txtTemperatureAlarmUpperLimit.Name = "txtTemperatureAlarmUpperLimit";
            this.txtTemperatureAlarmUpperLimit.PreventEnterBeep = true;
            this.txtTemperatureAlarmUpperLimit.Size = new System.Drawing.Size(100, 21);
            this.txtTemperatureAlarmUpperLimit.TabIndex = 14;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(11, 18);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(66, 23);
            this.labelX11.TabIndex = 3;
            this.labelX11.Text = "报警上限";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(77, 33);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "X坐标";
            // 
            // textBoxX6
            // 
            // 
            // 
            // 
            this.textBoxX6.Border.Class = "TextBoxBorder";
            this.textBoxX6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "X", true));
            this.textBoxX6.Location = new System.Drawing.Point(134, 33);
            this.textBoxX6.Name = "textBoxX6";
            this.textBoxX6.PreventEnterBeep = true;
            this.textBoxX6.Size = new System.Drawing.Size(131, 21);
            this.textBoxX6.TabIndex = 3;
            // 
            // textBoxX7
            // 
            // 
            // 
            // 
            this.textBoxX7.Border.Class = "TextBoxBorder";
            this.textBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Y", true));
            this.textBoxX7.Location = new System.Drawing.Point(318, 33);
            this.textBoxX7.Name = "textBoxX7";
            this.textBoxX7.PreventEnterBeep = true;
            this.textBoxX7.Size = new System.Drawing.Size(100, 21);
            this.textBoxX7.TabIndex = 4;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(275, 31);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(37, 23);
            this.labelX10.TabIndex = 5;
            this.labelX10.Text = "Y坐标";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(443, 455);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 13;
            this.buttonX2.Text = "保存";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel2.Controls.Add(this.checkBoxX1);
            this.groupPanel2.Controls.Add(this.txtHumidityAlarmLowerLimit);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.txtHumidityForewarningLowerLimit);
            this.groupPanel2.Controls.Add(this.labelX15);
            this.groupPanel2.Controls.Add(this.txtHumidityForewarningUpperLimit);
            this.groupPanel2.Controls.Add(this.labelX16);
            this.groupPanel2.Controls.Add(this.txtHumidityAlarmUpperLimit);
            this.groupPanel2.Controls.Add(this.labelX17);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(290, 219);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(228, 224);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 21;
            this.groupPanel2.Text = "湿度";
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "HumidityLimitCanUse", true));
            this.checkBoxX1.Location = new System.Drawing.Point(70, 170);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 21;
            this.checkBoxX1.Text = "启用";
            // 
            // txtHumidityAlarmLowerLimit
            // 
            // 
            // 
            // 
            this.txtHumidityAlarmLowerLimit.Border.Class = "TextBoxBorder";
            this.txtHumidityAlarmLowerLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHumidityAlarmLowerLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "HumidityAlarmLowerLimit", true));
            this.txtHumidityAlarmLowerLimit.Location = new System.Drawing.Point(84, 54);
            this.txtHumidityAlarmLowerLimit.Name = "txtHumidityAlarmLowerLimit";
            this.txtHumidityAlarmLowerLimit.PreventEnterBeep = true;
            this.txtHumidityAlarmLowerLimit.Size = new System.Drawing.Size(100, 21);
            this.txtHumidityAlarmLowerLimit.TabIndex = 20;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(13, 54);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 23);
            this.labelX3.TabIndex = 19;
            this.labelX3.Text = "报警下限";
            // 
            // txtHumidityForewarningLowerLimit
            // 
            // 
            // 
            // 
            this.txtHumidityForewarningLowerLimit.Border.Class = "TextBoxBorder";
            this.txtHumidityForewarningLowerLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHumidityForewarningLowerLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "HumidityForewarningLowerLimit", true));
            this.txtHumidityForewarningLowerLimit.Location = new System.Drawing.Point(84, 133);
            this.txtHumidityForewarningLowerLimit.Name = "txtHumidityForewarningLowerLimit";
            this.txtHumidityForewarningLowerLimit.PreventEnterBeep = true;
            this.txtHumidityForewarningLowerLimit.Size = new System.Drawing.Size(100, 21);
            this.txtHumidityForewarningLowerLimit.TabIndex = 18;
            // 
            // labelX15
            // 
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(11, 129);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(66, 23);
            this.labelX15.TabIndex = 17;
            this.labelX15.Text = "预警下限";
            // 
            // txtHumidityForewarningUpperLimit
            // 
            // 
            // 
            // 
            this.txtHumidityForewarningUpperLimit.Border.Class = "TextBoxBorder";
            this.txtHumidityForewarningUpperLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHumidityForewarningUpperLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "HumidityForewarningUpperLimit", true));
            this.txtHumidityForewarningUpperLimit.Location = new System.Drawing.Point(84, 93);
            this.txtHumidityForewarningUpperLimit.Name = "txtHumidityForewarningUpperLimit";
            this.txtHumidityForewarningUpperLimit.PreventEnterBeep = true;
            this.txtHumidityForewarningUpperLimit.Size = new System.Drawing.Size(100, 21);
            this.txtHumidityForewarningUpperLimit.TabIndex = 16;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Location = new System.Drawing.Point(11, 93);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(66, 23);
            this.labelX16.TabIndex = 15;
            this.labelX16.Text = "预警上限";
            // 
            // txtHumidityAlarmUpperLimit
            // 
            // 
            // 
            // 
            this.txtHumidityAlarmUpperLimit.Border.Class = "TextBoxBorder";
            this.txtHumidityAlarmUpperLimit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHumidityAlarmUpperLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "HumidityAlarmUpperLimit", true));
            this.txtHumidityAlarmUpperLimit.Location = new System.Drawing.Point(84, 18);
            this.txtHumidityAlarmUpperLimit.Name = "txtHumidityAlarmUpperLimit";
            this.txtHumidityAlarmUpperLimit.PreventEnterBeep = true;
            this.txtHumidityAlarmUpperLimit.Size = new System.Drawing.Size(100, 21);
            this.txtHumidityAlarmUpperLimit.TabIndex = 14;
            // 
            // labelX17
            // 
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Location = new System.Drawing.Point(11, 18);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(66, 23);
            this.labelX17.TabIndex = 3;
            this.labelX17.Text = "报警上限";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DataMonitor.DQ.Infrastructure.DataRepository.Models.Device);
            // 
            // EditDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 489);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.textBoxX5);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.ipAddressInput1);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.textBoxX7);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.textBoxX6);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.Name = "EditDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑测点信息";
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.IpAddressInput ipAddressInput1;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX6;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX7;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTemperatureAlarmUpperLimit;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTemperatureAlarmLowerLimit;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTemperatureForewarningLowerLimit;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTemperatureForewarningUpperLimit;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHumidityAlarmLowerLimit;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHumidityForewarningLowerLimit;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHumidityForewarningUpperLimit;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHumidityAlarmUpperLimit;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}