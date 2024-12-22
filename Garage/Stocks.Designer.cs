namespace Garage
{
    partial class Stocks
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stocks));
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            CarDGV = new DataGridView();
            OwnerNameTb = new TextBox();
            DeleteBtn = new Button();
            ColorTb = new TextBox();
            EditBtn = new Button();
            CarModelTb = new TextBox();
            AddBtn = new Button();
            CarBrandTb = new TextBox();
            CDate = new DateTimePicker();
            CarNumTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            manuButton = new PictureBox();
            panel5 = new Panel();
            button2 = new Button();
            panel6 = new Panel();
            button3 = new Button();
            panel7 = new Panel();
            button4 = new Button();
            panel8 = new Panel();
            button5 = new Button();
            panel9 = new Panel();
            button6 = new Button();
            panel10 = new Panel();
            button7 = new Button();
            panel2 = new Panel();
            label8 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manuButton).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 43);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(CarDGV);
            panel3.Controls.Add(OwnerNameTb);
            panel3.Controls.Add(DeleteBtn);
            panel3.Controls.Add(ColorTb);
            panel3.Controls.Add(EditBtn);
            panel3.Controls.Add(CarModelTb);
            panel3.Controls.Add(AddBtn);
            panel3.Controls.Add(CarBrandTb);
            panel3.Controls.Add(CDate);
            panel3.Controls.Add(CarNumTb);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(266, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(1048, 643);
            panel3.TabIndex = 19;
            // 
            // CarDGV
            // 
            CarDGV.BackgroundColor = SystemColors.ControlLight;
            CarDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDGV.Location = new Point(2, 256);
            CarDGV.Name = "CarDGV";
            CarDGV.RowHeadersWidth = 62;
            CarDGV.Size = new Size(1046, 387);
            CarDGV.TabIndex = 26;
            // 
            // OwnerNameTb
            // 
            OwnerNameTb.Location = new Point(447, 131);
            OwnerNameTb.Name = "OwnerNameTb";
            OwnerNameTb.Size = new Size(150, 31);
            OwnerNameTb.TabIndex = 22;
            OwnerNameTb.Text = "Owner Name";
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(546, 178);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(112, 34);
            DeleteBtn.TabIndex = 25;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ColorTb
            // 
            ColorTb.Location = new Point(249, 131);
            ColorTb.Name = "ColorTb";
            ColorTb.Size = new Size(150, 31);
            ColorTb.TabIndex = 20;
            ColorTb.Text = "Color";
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(392, 178);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(112, 34);
            EditBtn.TabIndex = 24;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // CarModelTb
            // 
            CarModelTb.Location = new Point(447, 70);
            CarModelTb.Name = "CarModelTb";
            CarModelTb.Size = new Size(150, 31);
            CarModelTb.TabIndex = 19;
            CarModelTb.Text = "Car Model";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(249, 178);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(112, 34);
            AddBtn.TabIndex = 23;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // CarBrandTb
            // 
            CarBrandTb.Location = new Point(249, 70);
            CarBrandTb.Name = "CarBrandTb";
            CarBrandTb.Size = new Size(150, 31);
            CarBrandTb.TabIndex = 18;
            CarBrandTb.Text = "Car Brand";
            // 
            // CDate
            // 
            CDate.Location = new Point(679, 70);
            CDate.Name = "CDate";
            CDate.Size = new Size(300, 31);
            CDate.TabIndex = 21;
            // 
            // CarNumTb
            // 
            CarNumTb.Location = new Point(45, 70);
            CarNumTb.Name = "CarNumTb";
            CarNumTb.Size = new Size(150, 31);
            CarNumTb.TabIndex = 17;
            CarNumTb.Text = "Cars Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(7, 221);
            label1.Name = "label1";
            label1.Size = new Size(287, 32);
            label1.TabIndex = 15;
            label1.Text = "Record Cars for Servicing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(7, 19);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 16;
            label2.Text = "Car informasjon";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(manuButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 122);
            panel1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 36);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 1;
            label3.Text = "Manu";
            // 
            // manuButton
            // 
            manuButton.Cursor = Cursors.Hand;
            manuButton.Image = (Image)resources.GetObject("manuButton.Image");
            manuButton.Location = new Point(12, 26);
            manuButton.Name = "manuButton";
            manuButton.Size = new Size(47, 40);
            manuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            manuButton.TabIndex = 0;
            manuButton.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Location = new Point(0, 202);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 55);
            panel5.TabIndex = 22;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-21, -14);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(326, 88);
            button2.TabIndex = 21;
            button2.Text = "          Stock";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button3);
            panel6.Location = new Point(0, 263);
            panel6.Name = "panel6";
            panel6.Size = new Size(266, 55);
            panel6.TabIndex = 22;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-21, -14);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(326, 88);
            button3.TabIndex = 21;
            button3.Text = "          Employee";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(button4);
            panel7.Location = new Point(0, 324);
            panel7.Name = "panel7";
            panel7.Size = new Size(266, 55);
            panel7.TabIndex = 22;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-21, -14);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(326, 88);
            button4.TabIndex = 21;
            button4.Text = "          Billing";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(button5);
            panel8.Location = new Point(0, 385);
            panel8.Name = "panel8";
            panel8.Size = new Size(266, 55);
            panel8.TabIndex = 22;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-21, -14);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 0);
            button5.Size = new Size(326, 88);
            button5.TabIndex = 21;
            button5.Text = "          Analytics";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(button6);
            panel9.Location = new Point(0, 446);
            panel9.Name = "panel9";
            panel9.Size = new Size(266, 55);
            panel9.TabIndex = 22;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-21, -14);
            button6.Name = "button6";
            button6.Padding = new Padding(30, 0, 0, 0);
            button6.Size = new Size(326, 88);
            button6.TabIndex = 21;
            button6.Text = "          Home";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(button7);
            panel10.Location = new Point(0, 605);
            panel10.Name = "panel10";
            panel10.Size = new Size(266, 55);
            panel10.TabIndex = 22;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-21, -14);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 0);
            button7.Size = new Size(326, 88);
            button7.TabIndex = 21;
            button7.Text = "          Logout";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 40, 45);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(266, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 52);
            panel2.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(44, 9);
            label8.Name = "label8";
            label8.Size = new Size(131, 32);
            label8.TabIndex = 5;
            label8.Text = "Garage HS";
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Location = new Point(0, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 55);
            panel4.TabIndex = 20;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-21, -14);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(326, 88);
            button1.TabIndex = 21;
            button1.Text = "          Cars";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel10);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel4);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(266, 692);
            sidebar.MinimumSize = new Size(65, 692);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(266, 692);
            sidebar.TabIndex = 17;
            // 
            // Stocks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 695);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            Name = "Stocks";
            Text = "Stocks";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CarDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)manuButton).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel3;
        private DataGridView CarDGV;
        private TextBox OwnerNameTb;
        private Button DeleteBtn;
        private TextBox ColorTb;
        private Button EditBtn;
        private TextBox CarModelTb;
        private Button AddBtn;
        private TextBox CarBrandTb;
        private DateTimePicker CDate;
        private TextBox CarNumTb;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private PictureBox manuButton;
        private Panel panel5;
        private Button button2;
        private Panel panel6;
        private Button button3;
        private Panel panel7;
        private Button button4;
        private Panel panel8;
        private Button button5;
        private Panel panel9;
        private Button button6;
        private Panel panel10;
        private Button button7;
        private Panel panel2;
        private Label label8;
        private Panel panel4;
        private Button button1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel sidebar;
    }
}