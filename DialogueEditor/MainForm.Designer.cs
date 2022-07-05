namespace DialogueEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_What = new System.Windows.Forms.RichTextBox();
            this.Txt_Who = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_Messages = new System.Windows.Forms.DataGridView();
            this.Dgv_Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Col_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Messages)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_What
            // 
            this.Txt_What.Location = new System.Drawing.Point(13, 104);
            this.Txt_What.Name = "Txt_What";
            this.Txt_What.Size = new System.Drawing.Size(386, 134);
            this.Txt_What.TabIndex = 0;
            this.Txt_What.Text = "";
            // 
            // Txt_Who
            // 
            this.Txt_Who.Location = new System.Drawing.Point(205, 58);
            this.Txt_Who.Name = "Txt_Who";
            this.Txt_Who.Size = new System.Drawing.Size(194, 23);
            this.Txt_Who.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кто пишет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Что пишет";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv_Messages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(418, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 423);
            this.panel1.TabIndex = 4;
            // 
            // Dgv_Messages
            // 
            this.Dgv_Messages.AllowUserToAddRows = false;
            this.Dgv_Messages.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_Messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Messages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgv_Col_Name,
            this.Dgv_Col_Text});
            this.Dgv_Messages.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dgv_Messages.Location = new System.Drawing.Point(3, 0);
            this.Dgv_Messages.Name = "Dgv_Messages";
            this.Dgv_Messages.RowTemplate.Height = 25;
            this.Dgv_Messages.Size = new System.Drawing.Size(379, 423);
            this.Dgv_Messages.TabIndex = 0;
            this.Dgv_Messages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Messages_CellClick);
            // 
            // Dgv_Col_Name
            // 
            this.Dgv_Col_Name.HeaderText = "Name";
            this.Dgv_Col_Name.Name = "Dgv_Col_Name";
            this.Dgv_Col_Name.Width = 80;
            // 
            // Dgv_Col_Text
            // 
            this.Dgv_Col_Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dgv_Col_Text.HeaderText = "Message";
            this.Dgv_Col_Text.MinimumWidth = 20;
            this.Dgv_Col_Text.Name = "Dgv_Col_Text";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Controls.Add(this.Txt_Who);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Txt_What);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 423);
            this.panel2.TabIndex = 5;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(297, 283);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(102, 31);
            this.Btn_Add.TabIndex = 4;
            this.Btn_Add.Text = "Добавить";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Export,
            this.TSMI_Import});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // TSMI_Export
            // 
            this.TSMI_Export.Name = "TSMI_Export";
            this.TSMI_Export.Size = new System.Drawing.Size(110, 22);
            this.TSMI_Export.Text = "Export";
            this.TSMI_Export.Click += new System.EventHandler(this.TSMI_Export_Click);
            // 
            // TSMI_Import
            // 
            this.TSMI_Import.Name = "TSMI_Import";
            this.TSMI_Import.Size = new System.Drawing.Size(110, 22);
            this.TSMI_Import.Text = "Import";
            this.TSMI_Import.Click += new System.EventHandler(this.TSMI_Import_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 423);
            this.panel3.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Messages)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox Txt_What;
        private TextBox Txt_Who;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button Btn_Add;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem TSMI_Export;
        private ToolStripMenuItem TSMI_Import;
        private Panel panel3;
        private DataGridView Dgv_Messages;
        private DataGridViewTextBoxColumn Dgv_Col_Name;
        private DataGridViewTextBoxColumn Dgv_Col_Text;
    }
}