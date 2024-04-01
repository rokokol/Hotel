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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            splitContainer1 = new SplitContainer();
            outCheckBox = new CheckBox();
            bookCheckBox = new CheckBox();
            freeCheckBox = new CheckBox();
            resCheckBox = new CheckBox();
            StatusLabel = new Label();
            splitContainer2 = new SplitContainer();
            searchBox = new TextBox();
            guestsLabel = new Label();
            dataGrid = new DataGridView();
            userGrid = new DataGridView();
            NumberLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
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
            StatusLabel.Location = new Point(60, 9);
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
            splitContainer2.Panel2.Controls.Add(userGrid);
            splitContainer2.Panel2.Controls.Add(NumberLabel);
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
            // userGrid
            // 
            userGrid.AllowUserToAddRows = false;
            userGrid.AllowUserToDeleteRows = false;
            userGrid.AllowUserToResizeColumns = false;
            userGrid.AllowUserToResizeRows = false;
            userGrid.BackgroundColor = SystemColors.GradientActiveCaption;
            userGrid.Dock = DockStyle.Bottom;
            userGrid.Location = new Point(0, 70);
            userGrid.MinimumSize = new Size(200, 10);
            userGrid.Name = "userGrid";
            userGrid.ReadOnly = true;
            userGrid.Size = new Size(238, 380);
            userGrid.TabIndex = 2;
            // 
            // NumberLabel
            // 
            NumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumberLabel.Location = new Point(89, 9);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(68, 24);
            NumberLabel.TabIndex = 1;
            NumberLabel.Text = "Номер";
            NumberLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private DataGridView dataGrid;
        private Label StatusLabel;
        private Label NumberLabel;
        private Label guestsLabel;
        private CheckBox outCheckBox;
        private CheckBox bookCheckBox;
        private CheckBox freeCheckBox;
        private CheckBox resCheckBox;
        private TextBox searchBox;
        private DataGridView userGrid;
    }
}
