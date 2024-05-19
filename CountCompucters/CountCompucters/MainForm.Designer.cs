namespace CountCompucters
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            treeView1 = new TreeView();
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            файлToolStripMenuItem = new ToolStripMenuItem();
            экспортироватьToolStripMenuItem = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            toolStrip1 = new ToolStrip();
            toolStripButtonCreate = new ToolStripButton();
            toolStripButtonDelete = new ToolStripButton();
            toolStripButtonUpdate = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(0, 91);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(199, 526);
            treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(889, 500);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Location = new Point(205, 91);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(766, 23);
            textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(977, 88);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(117, 23);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { экспортироватьToolStripMenuItem, отчетToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 25);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // экспортироватьToolStripMenuItem
            // 
            экспортироватьToolStripMenuItem.Name = "экспортироватьToolStripMenuItem";
            экспортироватьToolStripMenuItem.Size = new Size(197, 26);
            экспортироватьToolStripMenuItem.Text = "Экспортировать";
            // 
            // отчетToolStripMenuItem
            // 
            отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            отчетToolStripMenuItem.Size = new Size(197, 26);
            отчетToolStripMenuItem.Text = "Отчет";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(197, 26);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1106, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Font = new Font("Segoe UI", 12F);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonCreate, toolStripButtonDelete, toolStripButtonUpdate, toolStripButton1 });
            toolStrip1.Location = new Point(0, 60);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(362, 28);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCreate
            // 
            toolStripButtonCreate.Image = (Image)resources.GetObject("toolStripButtonCreate.Image");
            toolStripButtonCreate.ImageTransparentColor = Color.Magenta;
            toolStripButtonCreate.Name = "toolStripButtonCreate";
            toolStripButtonCreate.Size = new Size(88, 25);
            toolStripButtonCreate.Text = "Создать";
            toolStripButtonCreate.Click += toolStripButtonCreate_Click;
            // 
            // toolStripButtonDelete
            // 
            toolStripButtonDelete.Image = (Image)resources.GetObject("toolStripButtonDelete.Image");
            toolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete.Name = "toolStripButtonDelete";
            toolStripButtonDelete.Size = new Size(88, 25);
            toolStripButtonDelete.Text = "Удалить";
            // 
            // toolStripButtonUpdate
            // 
            toolStripButtonUpdate.Image = (Image)resources.GetObject("toolStripButtonUpdate.Image");
            toolStripButtonUpdate.ImageTransparentColor = Color.Magenta;
            toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            toolStripButtonUpdate.Size = new Size(101, 25);
            toolStripButtonUpdate.Text = "Обновить";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(73, 25);
            toolStripButton1.Text = "Отчет";
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new Size(150, 150);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 645);
            Controls.Add(toolStrip1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1122, 684);
            MinimumSize = new Size(1122, 684);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет оборудования";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonCreate;
        private ToolStripButton toolStripButtonDelete;
        private ToolStripButton toolStripButtonUpdate;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private ToolStripMenuItem экспортироватьToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        public DataGridView dataGridView1;
    }
}