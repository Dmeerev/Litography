namespace Litography
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPZ = new System.Windows.Forms.Button();
            this.buttonPY = new System.Windows.Forms.Button();
            this.buttonPX = new System.Windows.Forms.Button();
            this.buttonNZ = new System.Windows.Forms.Button();
            this.buttonNY = new System.Windows.Forms.Button();
            this.buttonNX = new System.Windows.Forms.Button();
            this.progressBaOne = new System.Windows.Forms.ProgressBar();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonNMult = new System.Windows.Forms.Button();
            this.buttonPMult = new System.Windows.Forms.Button();
            this.buttonSaveLitTime = new System.Windows.Forms.Button();
            this.textBoxCurrX = new System.Windows.Forms.TextBox();
            this.textBoxCurrY = new System.Windows.Forms.TextBox();
            this.textBoxCurrZ = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxButtnMult = new System.Windows.Forms.TextBox();
            this.checkBoxToggleMultiLitProc = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBoxLED = new System.Windows.Forms.CheckBox();
            this.pictureBoxBUSYLED = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBUSYLED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 291);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(14, 13);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 342);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 13);
            label2.TabIndex = 1;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 393);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(13, 13);
            label3.TabIndex = 1;
            label3.Text = "Z";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(674, 35);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(113, 13);
            label8.TabIndex = 8;
            label8.Text = "время засветки (мс)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(674, 87);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(111, 13);
            label4.TabIndex = 1;
            label4.Text = "множитель кнопки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 454);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 13);
            label5.TabIndex = 1;
            label5.Text = "LocalProgress";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 483);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(88, 13);
            label6.TabIndex = 1;
            label6.Text = "Global Progress";
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(47, 393);
            this.trackBarZ.Maximum = 1000;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(607, 45);
            this.trackBarZ.TabIndex = 0;
            this.trackBarZ.Scroll += new System.EventHandler(this.TrackBarZ_Scroll);
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(47, 291);
            this.trackBarX.Maximum = 1000;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(607, 45);
            this.trackBarX.TabIndex = 0;
            this.trackBarX.Scroll += new System.EventHandler(this.TrackBarX_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(30, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Крашить винду при любом чихе";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem4.Text = "1111";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "main ptrn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(174, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "correct mask";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "corr.msk";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonPZ
            // 
            this.buttonPZ.Location = new System.Drawing.Point(706, 393);
            this.buttonPZ.Name = "buttonPZ";
            this.buttonPZ.Size = new System.Drawing.Size(23, 23);
            this.buttonPZ.TabIndex = 6;
            this.buttonPZ.Text = "+";
            this.buttonPZ.UseVisualStyleBackColor = true;
            this.buttonPZ.Click += new System.EventHandler(this.ButtonPZ_Click);
            // 
            // buttonPY
            // 
            this.buttonPY.Location = new System.Drawing.Point(706, 342);
            this.buttonPY.Name = "buttonPY";
            this.buttonPY.Size = new System.Drawing.Size(23, 23);
            this.buttonPY.TabIndex = 6;
            this.buttonPY.Text = "+";
            this.buttonPY.UseVisualStyleBackColor = true;
            this.buttonPY.Click += new System.EventHandler(this.ButtonPY_Click);
            // 
            // buttonPX
            // 
            this.buttonPX.Location = new System.Drawing.Point(706, 291);
            this.buttonPX.Name = "buttonPX";
            this.buttonPX.Size = new System.Drawing.Size(23, 23);
            this.buttonPX.TabIndex = 6;
            this.buttonPX.Text = "+";
            this.buttonPX.UseVisualStyleBackColor = true;
            this.buttonPX.Click += new System.EventHandler(this.ButtonPX_Click);
            // 
            // buttonNZ
            // 
            this.buttonNZ.Location = new System.Drawing.Point(677, 393);
            this.buttonNZ.Name = "buttonNZ";
            this.buttonNZ.Size = new System.Drawing.Size(23, 23);
            this.buttonNZ.TabIndex = 6;
            this.buttonNZ.Text = "-";
            this.buttonNZ.UseVisualStyleBackColor = true;
            this.buttonNZ.Click += new System.EventHandler(this.ButtonNZ_Click);
            // 
            // buttonNY
            // 
            this.buttonNY.Location = new System.Drawing.Point(677, 342);
            this.buttonNY.Name = "buttonNY";
            this.buttonNY.Size = new System.Drawing.Size(23, 23);
            this.buttonNY.TabIndex = 6;
            this.buttonNY.Text = "-";
            this.buttonNY.UseVisualStyleBackColor = true;
            this.buttonNY.Click += new System.EventHandler(this.ButtonNY_Click);
            // 
            // buttonNX
            // 
            this.buttonNX.Location = new System.Drawing.Point(677, 291);
            this.buttonNX.Name = "buttonNX";
            this.buttonNX.Size = new System.Drawing.Size(23, 23);
            this.buttonNX.TabIndex = 6;
            this.buttonNX.Text = "-";
            this.buttonNX.UseVisualStyleBackColor = true;
            this.buttonNX.Click += new System.EventHandler(this.ButtonNX_Click);
            // 
            // progressBaOne
            // 
            this.progressBaOne.Location = new System.Drawing.Point(154, 444);
            this.progressBaOne.Name = "progressBaOne";
            this.progressBaOne.Size = new System.Drawing.Size(273, 23);
            this.progressBaOne.TabIndex = 7;
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Location = new System.Drawing.Point(154, 473);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(273, 23);
            this.progressBarTotal.TabIndex = 7;
            // 
            // buttonNMult
            // 
            this.buttonNMult.Location = new System.Drawing.Point(782, 104);
            this.buttonNMult.Name = "buttonNMult";
            this.buttonNMult.Size = new System.Drawing.Size(23, 23);
            this.buttonNMult.TabIndex = 6;
            this.buttonNMult.Text = "-";
            this.buttonNMult.UseVisualStyleBackColor = true;
            this.buttonNMult.Click += new System.EventHandler(this.ButtonNMult_Click);
            // 
            // buttonPMult
            // 
            this.buttonPMult.Location = new System.Drawing.Point(811, 104);
            this.buttonPMult.Name = "buttonPMult";
            this.buttonPMult.Size = new System.Drawing.Size(23, 23);
            this.buttonPMult.TabIndex = 6;
            this.buttonPMult.Text = "+";
            this.buttonPMult.UseVisualStyleBackColor = true;
            this.buttonPMult.Click += new System.EventHandler(this.ButtonPMult_Click);
            // 
            // buttonSaveLitTime
            // 
            this.buttonSaveLitTime.Location = new System.Drawing.Point(782, 56);
            this.buttonSaveLitTime.Name = "buttonSaveLitTime";
            this.buttonSaveLitTime.Size = new System.Drawing.Size(43, 23);
            this.buttonSaveLitTime.TabIndex = 6;
            this.buttonSaveLitTime.Text = "save";
            this.buttonSaveLitTime.UseVisualStyleBackColor = true;
            // 
            // textBoxCurrX
            // 
            this.textBoxCurrX.Location = new System.Drawing.Point(735, 291);
            this.textBoxCurrX.Name = "textBoxCurrX";
            this.textBoxCurrX.ReadOnly = true;
            this.textBoxCurrX.Size = new System.Drawing.Size(100, 22);
            this.textBoxCurrX.TabIndex = 10;
            // 
            // textBoxCurrY
            // 
            this.textBoxCurrY.Location = new System.Drawing.Point(735, 342);
            this.textBoxCurrY.Name = "textBoxCurrY";
            this.textBoxCurrY.ReadOnly = true;
            this.textBoxCurrY.Size = new System.Drawing.Size(100, 22);
            this.textBoxCurrY.TabIndex = 10;
            // 
            // textBoxCurrZ
            // 
            this.textBoxCurrZ.Location = new System.Drawing.Point(735, 395);
            this.textBoxCurrZ.Name = "textBoxCurrZ";
            this.textBoxCurrZ.ReadOnly = true;
            this.textBoxCurrZ.Size = new System.Drawing.Size(100, 22);
            this.textBoxCurrZ.TabIndex = 10;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(677, 57);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxTime.TabIndex = 10;
            // 
            // textBoxButtnMult
            // 
            this.textBoxButtnMult.Location = new System.Drawing.Point(677, 104);
            this.textBoxButtnMult.Name = "textBoxButtnMult";
            this.textBoxButtnMult.ReadOnly = true;
            this.textBoxButtnMult.Size = new System.Drawing.Size(100, 22);
            this.textBoxButtnMult.TabIndex = 10;
            this.textBoxButtnMult.Text = "1";
            // 
            // checkBoxToggleMultiLitProc
            // 
            this.checkBoxToggleMultiLitProc.AutoSize = true;
            this.checkBoxToggleMultiLitProc.Location = new System.Drawing.Point(677, 148);
            this.checkBoxToggleMultiLitProc.Name = "checkBoxToggleMultiLitProc";
            this.checkBoxToggleMultiLitProc.Size = new System.Drawing.Size(107, 17);
            this.checkBoxToggleMultiLitProc.TabIndex = 11;
            this.checkBoxToggleMultiLitProc.Text = "MultiLitography";
            this.checkBoxToggleMultiLitProc.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(850, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 126);
            this.button4.TabIndex = 12;
            this.button4.Text = "STOP";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(912, 61);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 13);
            label7.TabIndex = 8;
            label7.Text = "Чё то делает";
            // 
            // checkBoxLED
            // 
            this.checkBoxLED.AutoSize = true;
            this.checkBoxLED.Location = new System.Drawing.Point(926, 87);
            this.checkBoxLED.Name = "checkBoxLED";
            this.checkBoxLED.Size = new System.Drawing.Size(45, 17);
            this.checkBoxLED.TabIndex = 11;
            this.checkBoxLED.Text = "LED";
            this.checkBoxLED.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBUSYLED
            // 
            this.pictureBoxBUSYLED.Image = global::govnosoft1.Properties.Resources.RedLedOff1;
            this.pictureBoxBUSYLED.Location = new System.Drawing.Point(992, 57);
            this.pictureBoxBUSYLED.Name = "pictureBoxBUSYLED";
            this.pictureBoxBUSYLED.Size = new System.Drawing.Size(34, 52);
            this.pictureBoxBUSYLED.TabIndex = 13;
            this.pictureBoxBUSYLED.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(336, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(318, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(47, 342);
            this.trackBarY.Maximum = 1000;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(607, 45);
            this.trackBarY.TabIndex = 0;
            this.trackBarY.Scroll += new System.EventHandler(this.TrackBarY_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 530);
            this.Controls.Add(this.pictureBoxBUSYLED);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBoxLED);
            this.Controls.Add(this.checkBoxToggleMultiLitProc);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxButtnMult);
            this.Controls.Add(this.textBoxCurrZ);
            this.Controls.Add(this.textBoxCurrY);
            this.Controls.Add(this.textBoxCurrX);
            this.Controls.Add(label7);
            this.Controls.Add(label8);
            this.Controls.Add(this.progressBarTotal);
            this.Controls.Add(this.progressBaOne);
            this.Controls.Add(this.buttonPMult);
            this.Controls.Add(this.buttonPY);
            this.Controls.Add(this.buttonNMult);
            this.Controls.Add(this.buttonSaveLitTime);
            this.Controls.Add(this.buttonPX);
            this.Controls.Add(this.buttonNX);
            this.Controls.Add(this.buttonNY);
            this.Controls.Add(this.buttonNZ);
            this.Controls.Add(this.buttonPZ);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label4);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label1);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Litography";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBUSYLED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPZ;
        private System.Windows.Forms.Button buttonPY;
        private System.Windows.Forms.Button buttonPX;
        private System.Windows.Forms.Button buttonNZ;
        private System.Windows.Forms.Button buttonNY;
        private System.Windows.Forms.Button buttonNX;
        private System.Windows.Forms.ProgressBar progressBaOne;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonNMult;
        private System.Windows.Forms.Button buttonPMult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSaveLitTime;
        private System.Windows.Forms.TextBox textBoxCurrX;
        private System.Windows.Forms.TextBox textBoxCurrY;
        private System.Windows.Forms.TextBox textBoxCurrZ;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxButtnMult;
        private System.Windows.Forms.CheckBox checkBoxToggleMultiLitProc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBoxBUSYLED;
        private System.Windows.Forms.CheckBox checkBoxLED;
        private System.Windows.Forms.TrackBar trackBarY;
    }
}

