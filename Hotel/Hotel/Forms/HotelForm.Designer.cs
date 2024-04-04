namespace Hotel
{
    partial class HotelForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            splitContainer1 = new SplitContainer();
            timeLabel = new Label();
            outCheckBox = new CheckBox();
            bookCheckBox = new CheckBox();
            freeCheckBox = new CheckBox();
            resCheckBox = new CheckBox();
            StatusLabel = new Label();
            splitContainer2 = new SplitContainer();
            searchBox = new TextBox();
            guestsLabel = new Label();
            dataGrid = new DataGridView();
            outcomeDate = new Label();
            outcomeDateLabel = new Label();
            statusValueLabel = new Label();
            incomeDate = new Label();
            incomeDateLabel = new Label();
            nameLabel = new Label();
            statusTypeLabel = new Label();
            imageBox = new PictureBox();
            numberLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.PowderBlue;
            splitContainer1.Panel1.Controls.Add(timeLabel);
            splitContainer1.Panel1.Controls.Add(outCheckBox);
            splitContainer1.Panel1.Controls.Add(bookCheckBox);
            splitContainer1.Panel1.Controls.Add(freeCheckBox);
            splitContainer1.Panel1.Controls.Add(resCheckBox);
            splitContainer1.Panel1.Controls.Add(StatusLabel);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.OldLace;
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 204;
            splitContainer1.TabIndex = 0;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Sitka Text", 10F);
            timeLabel.Location = new Point(12, 36);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(89, 20);
            timeLabel.TabIndex = 5;
            timeLabel.Text = "00 : 00 : 00";
            // 
            // outCheckBox
            // 
            outCheckBox.AutoSize = true;
            outCheckBox.Location = new Point(12, 145);
            outCheckBox.Name = "outCheckBox";
            outCheckBox.Size = new Size(110, 19);
            outCheckBox.TabIndex = 4;
            outCheckBox.Text = "Выписываются";
            outCheckBox.UseVisualStyleBackColor = true;
            outCheckBox.CheckedChanged += outCheckBox_CheckedChanged;
            // 
            // bookCheckBox
            // 
            bookCheckBox.AutoSize = true;
            bookCheckBox.Location = new Point(12, 120);
            bookCheckBox.Name = "bookCheckBox";
            bookCheckBox.Size = new Size(66, 19);
            bookCheckBox.TabIndex = 3;
            bookCheckBox.Text = "Заняты";
            bookCheckBox.UseVisualStyleBackColor = true;
            bookCheckBox.CheckedChanged += bookCheckBox_CheckedChanged;
            // 
            // freeCheckBox
            // 
            freeCheckBox.AutoSize = true;
            freeCheckBox.Location = new Point(12, 95);
            freeCheckBox.Name = "freeCheckBox";
            freeCheckBox.Size = new Size(89, 19);
            freeCheckBox.TabIndex = 2;
            freeCheckBox.Text = "Свободные";
            freeCheckBox.UseVisualStyleBackColor = true;
            freeCheckBox.CheckedChanged += freeCheckBox_CheckedChanged;
            // 
            // resCheckBox
            // 
            resCheckBox.AutoSize = true;
            resCheckBox.Location = new Point(12, 70);
            resCheckBox.Name = "resCheckBox";
            resCheckBox.Size = new Size(130, 19);
            resCheckBox.TabIndex = 1;
            resCheckBox.Text = "Зарезервированно";
            resCheckBox.UseVisualStyleBackColor = true;
            resCheckBox.CheckedChanged += resCheckBox_CheckedChanged;
            // 
            // StatusLabel
            // 
            StatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StatusLabel.Location = new Point(53, 9);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(69, 24);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Статус";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer2.Panel1.Controls.Add(searchBox);
            splitContainer2.Panel1.Controls.Add(guestsLabel);
            splitContainer2.Panel1.Controls.Add(dataGrid);
            splitContainer2.Panel1MinSize = 350;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.LightBlue;
            splitContainer2.Panel2.Controls.Add(outcomeDate);
            splitContainer2.Panel2.Controls.Add(outcomeDateLabel);
            splitContainer2.Panel2.Controls.Add(statusValueLabel);
            splitContainer2.Panel2.Controls.Add(incomeDate);
            splitContainer2.Panel2.Controls.Add(incomeDateLabel);
            splitContainer2.Panel2.Controls.Add(nameLabel);
            splitContainer2.Panel2.Controls.Add(statusTypeLabel);
            splitContainer2.Panel2.Controls.Add(imageBox);
            splitContainer2.Panel2.Controls.Add(numberLabel);
            splitContainer2.Panel2MinSize = 230;
            splitContainer2.Size = new Size(592, 450);
            splitContainer2.SplitterDistance = 350;
            splitContainer2.TabIndex = 0;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(3, 36);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Поиск";
            searchBox.Size = new Size(344, 28);
            searchBox.TabIndex = 2;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // guestsLabel
            // 
            guestsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guestsLabel.AutoSize = true;
            guestsLabel.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            guestsLabel.Location = new Point(110, 9);
            guestsLabel.Name = "guestsLabel";
            guestsLabel.Size = new Size(135, 24);
            guestsLabel.TabIndex = 1;
            guestsLabel.Text = "Список гостей";
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.Dock = DockStyle.Bottom;
            dataGrid.Location = new Point(0, 70);
            dataGrid.MinimumSize = new Size(200, 10);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.ShowEditingIcon = false;
            dataGrid.Size = new Size(350, 380);
            dataGrid.StandardTab = true;
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // outcomeDate
            // 
            outcomeDate.AutoSize = true;
            outcomeDate.BackColor = SystemColors.GradientActiveCaption;
            outcomeDate.BorderStyle = BorderStyle.FixedSingle;
            outcomeDate.Font = new Font("Sitka Text", 10F);
            outcomeDate.Location = new Point(13, 399);
            outcomeDate.Name = "outcomeDate";
            outcomeDate.Size = new Size(2, 22);
            outcomeDate.TabIndex = 9;
            // 
            // outcomeDateLabel
            // 
            outcomeDateLabel.AutoSize = true;
            outcomeDateLabel.BackColor = SystemColors.GradientActiveCaption;
            outcomeDateLabel.BorderStyle = BorderStyle.FixedSingle;
            outcomeDateLabel.Font = new Font("Sitka Text", 10F);
            outcomeDateLabel.Location = new Point(13, 368);
            outcomeDateLabel.Name = "outcomeDateLabel";
            outcomeDateLabel.Size = new Size(94, 22);
            outcomeDateLabel.TabIndex = 8;
            outcomeDateLabel.Text = "Дата заезда";
            // 
            // statusValueLabel
            // 
            statusValueLabel.AutoSize = true;
            statusValueLabel.BackColor = SystemColors.GradientActiveCaption;
            statusValueLabel.BorderStyle = BorderStyle.FixedSingle;
            statusValueLabel.Font = new Font("Sitka Text", 10F);
            statusValueLabel.Location = new Point(90, 196);
            statusValueLabel.Name = "statusValueLabel";
            statusValueLabel.Size = new Size(57, 22);
            statusValueLabel.TabIndex = 7;
            statusValueLabel.Text = "Статус";
            // 
            // incomeDate
            // 
            incomeDate.AutoSize = true;
            incomeDate.BackColor = SystemColors.GradientActiveCaption;
            incomeDate.BorderStyle = BorderStyle.FixedSingle;
            incomeDate.Font = new Font("Sitka Text", 10F);
            incomeDate.Location = new Point(13, 324);
            incomeDate.Name = "incomeDate";
            incomeDate.Size = new Size(2, 22);
            incomeDate.TabIndex = 6;
            // 
            // incomeDateLabel
            // 
            incomeDateLabel.AutoSize = true;
            incomeDateLabel.BackColor = SystemColors.GradientActiveCaption;
            incomeDateLabel.BorderStyle = BorderStyle.FixedSingle;
            incomeDateLabel.Font = new Font("Sitka Text", 10F);
            incomeDateLabel.Location = new Point(13, 293);
            incomeDateLabel.Name = "incomeDateLabel";
            incomeDateLabel.Size = new Size(94, 22);
            incomeDateLabel.TabIndex = 5;
            incomeDateLabel.Text = "Дата заезда";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = SystemColors.GradientActiveCaption;
            nameLabel.BorderStyle = BorderStyle.FixedSingle;
            nameLabel.Font = new Font("Sitka Text", 10F);
            nameLabel.Location = new Point(13, 245);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 22);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "ФИО";
            // 
            // statusTypeLabel
            // 
            statusTypeLabel.AutoSize = true;
            statusTypeLabel.BackColor = SystemColors.GradientActiveCaption;
            statusTypeLabel.BorderStyle = BorderStyle.FixedSingle;
            statusTypeLabel.Font = new Font("Sitka Text", 10F);
            statusTypeLabel.Location = new Point(13, 196);
            statusTypeLabel.Name = "statusTypeLabel";
            statusTypeLabel.Size = new Size(57, 22);
            statusTypeLabel.TabIndex = 3;
            statusTypeLabel.Text = "Статус";
            // 
            // imageBox
            // 
            imageBox.BackColor = SystemColors.GradientActiveCaption;
            imageBox.BorderStyle = BorderStyle.FixedSingle;
            imageBox.Image = (Image)resources.GetObject("imageBox.Image");
            imageBox.Location = new Point(68, 70);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(100, 94);
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.TabIndex = 2;
            imageBox.TabStop = false;
            // 
            // numberLabel
            // 
            numberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberLabel.Location = new Point(75, 9);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(93, 24);
            numberLabel.TabIndex = 1;
            numberLabel.Text = "Номер №";
            numberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // HotelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotelForm";
            Text = "Hotel";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private DataGridView dataGrid;
        private Label StatusLabel;
        private Label numberLabel;
        private Label guestsLabel;
        private CheckBox outCheckBox;
        private CheckBox bookCheckBox;
        private CheckBox freeCheckBox;
        private CheckBox resCheckBox;
        private TextBox searchBox;
        private Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private PictureBox imageBox;
        private Label incomeDateLabel;
        private Label nameLabel;
        private Label statusTypeLabel;
        private Label incomeDate;
        private Label statusValueLabel;
        private Label outcomeDate;
        private Label outcomeDateLabel;
    }
}
