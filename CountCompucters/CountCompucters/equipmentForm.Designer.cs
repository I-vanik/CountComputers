namespace CountCompucters
{
    partial class EquipmentForm
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
            dateTabControl = new TabControl();
            dateEquipment = new TabPage();
            buttonNON = new Button();
            buttonYes = new Button();
            labelField = new Label();
            comboBox2 = new ComboBox();
            labelDate = new Label();
            textBox4 = new TextBox();
            labelStatus = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            labelType = new Label();
            labelSeria = new Label();
            textBox2 = new TextBox();
            labelName = new Label();
            textBox1 = new TextBox();
            labelID = new Label();
            textBoxID = new TextBox();
            menuStrip1 = new MenuStrip();
            dateTabControl.SuspendLayout();
            dateEquipment.SuspendLayout();
            SuspendLayout();
            // 
            // dateTabControl
            // 
            dateTabControl.Controls.Add(dateEquipment);
            dateTabControl.Location = new Point(1, 0);
            dateTabControl.Name = "dateTabControl";
            dateTabControl.SelectedIndex = 0;
            dateTabControl.Size = new Size(799, 450);
            dateTabControl.TabIndex = 0;
            // 
            // dateEquipment
            // 
            dateEquipment.Controls.Add(buttonNON);
            dateEquipment.Controls.Add(buttonYes);
            dateEquipment.Controls.Add(labelField);
            dateEquipment.Controls.Add(comboBox2);
            dateEquipment.Controls.Add(labelDate);
            dateEquipment.Controls.Add(textBox4);
            dateEquipment.Controls.Add(labelStatus);
            dateEquipment.Controls.Add(textBox3);
            dateEquipment.Controls.Add(comboBox1);
            dateEquipment.Controls.Add(labelType);
            dateEquipment.Controls.Add(labelSeria);
            dateEquipment.Controls.Add(textBox2);
            dateEquipment.Controls.Add(labelName);
            dateEquipment.Controls.Add(textBox1);
            dateEquipment.Controls.Add(labelID);
            dateEquipment.Controls.Add(textBoxID);
            dateEquipment.Location = new Point(4, 24);
            dateEquipment.Name = "dateEquipment";
            dateEquipment.Padding = new Padding(3);
            dateEquipment.Size = new Size(791, 422);
            dateEquipment.TabIndex = 0;
            dateEquipment.Text = "Свойства";
            dateEquipment.UseVisualStyleBackColor = true;
            // 
            // buttonNON
            // 
            buttonNON.Location = new Point(673, 239);
            buttonNON.Name = "buttonNON";
            buttonNON.Size = new Size(107, 23);
            buttonNON.TabIndex = 15;
            buttonNON.Text = "Отмена";
            buttonNON.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(560, 239);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(107, 23);
            buttonYes.TabIndex = 14;
            buttonYes.Text = "ОК";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // labelField
            // 
            labelField.AutoSize = true;
            labelField.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelField.Location = new Point(425, 144);
            labelField.Name = "labelField";
            labelField.Size = new Size(105, 21);
            labelField.TabIndex = 13;
            labelField.Text = "Помещение";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Компьютер", "Моноблок", "Ноутбук", "Принтер", "Клавиатура", "ИСПО \\ Этаж 1 \\ Кабинет 105" });
            comboBox2.Location = new Point(425, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(334, 23);
            comboBox2.TabIndex = 12;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDate.Location = new Point(244, 145);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(112, 21);
            labelDate.TabIndex = 11;
            labelDate.Text = "Дата статуса:";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(244, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 23);
            textBox4.TabIndex = 10;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelStatus.Location = new Point(26, 145);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(64, 21);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "Статус:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(26, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 23);
            textBox3.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Компьютер", "Моноблок", "Ноутбук", "Принтер", "Клавиатура" });
            comboBox1.Location = new Point(585, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 23);
            comboBox1.TabIndex = 7;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelType.Location = new Point(585, 23);
            labelType.Name = "labelType";
            labelType.Size = new Size(161, 21);
            labelType.TabIndex = 6;
            labelType.Text = "Тип оборудования:";
            // 
            // labelSeria
            // 
            labelSeria.AutoSize = true;
            labelSeria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelSeria.Location = new Point(295, 23);
            labelSeria.Name = "labelSeria";
            labelSeria.Size = new Size(119, 21);
            labelSeria.TabIndex = 5;
            labelSeria.Text = "Серийный №:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(295, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelName.Location = new Point(26, 79);
            labelName.Name = "labelName";
            labelName.Size = new Size(133, 21);
            labelName.TabIndex = 3;
            labelName.Text = "Наименование:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(26, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(733, 23);
            textBox1.TabIndex = 2;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelID.Location = new Point(26, 22);
            labelID.Name = "labelID";
            labelID.Size = new Size(73, 21);
            labelID.TabIndex = 1;
            labelID.Text = "Код(ID):";
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Location = new Point(26, 46);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 298);
            Controls.Add(dateTabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EquipmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление оборудования";
            dateTabControl.ResumeLayout(false);
            dateEquipment.ResumeLayout(false);
            dateEquipment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl dateTabControl;
        private TabPage dateEquipment;
        private MenuStrip menuStrip1;
        private Label labelID;
        private TextBox textBoxID;
        private Label labelName;
        private TextBox textBox1;
        private Label labelSeria;
        private TextBox textBox2;
        private Label labelType;
        private ComboBox comboBox1;
        private Label labelDate;
        private TextBox textBox4;
        private Label labelStatus;
        private TextBox textBox3;
        private Label labelField;
        private ComboBox comboBox2;
        private Button buttonNON;
        private Button buttonYes;
    }
}