
namespace trtpo_fractal_lab1
{
    partial class MainForm
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
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.GenerateFractalButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BlueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.GreenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.RedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RedTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FractalPictureBox
            // 
            this.FractalPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.FractalPictureBox.Location = new System.Drawing.Point(648, 12);
            this.FractalPictureBox.Name = "FractalPictureBox";
            this.FractalPictureBox.Size = new System.Drawing.Size(512, 512);
            this.FractalPictureBox.TabIndex = 0;
            this.FractalPictureBox.TabStop = false;
            // 
            // GenerateFractalButton
            // 
            this.GenerateFractalButton.Location = new System.Drawing.Point(428, 12);
            this.GenerateFractalButton.Name = "GenerateFractalButton";
            this.GenerateFractalButton.Size = new System.Drawing.Size(214, 99);
            this.GenerateFractalButton.TabIndex = 1;
            this.GenerateFractalButton.Text = "Generate fractal";
            this.GenerateFractalButton.UseVisualStyleBackColor = true;
            this.GenerateFractalButton.Click += new System.EventHandler(this.GenerateFractalButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BlueNumericUpDown);
            this.groupBox1.Controls.Add(this.BlueTrackBar);
            this.groupBox1.Controls.Add(this.GreenNumericUpDown);
            this.groupBox1.Controls.Add(this.GreenTrackBar);
            this.groupBox1.Controls.Add(this.RedNumericUpDown);
            this.groupBox1.Controls.Add(this.RedTrackBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 225);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // BlueNumericUpDown
            // 
            this.BlueNumericUpDown.Location = new System.Drawing.Point(276, 155);
            this.BlueNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueNumericUpDown.Name = "BlueNumericUpDown";
            this.BlueNumericUpDown.Size = new System.Drawing.Size(120, 34);
            this.BlueNumericUpDown.TabIndex = 8;
            this.BlueNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.BlueNumericUpDown.ValueChanged += new System.EventHandler(this.BlueNumericUpDown_ValueChanged);
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Location = new System.Drawing.Point(83, 157);
            this.BlueTrackBar.Maximum = 255;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(187, 56);
            this.BlueTrackBar.TabIndex = 7;
            this.BlueTrackBar.Value = 2;
            this.BlueTrackBar.ValueChanged += new System.EventHandler(this.BlueTrackBar_ValueChanged);
            // 
            // GreenNumericUpDown
            // 
            this.GreenNumericUpDown.Location = new System.Drawing.Point(276, 93);
            this.GreenNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenNumericUpDown.Name = "GreenNumericUpDown";
            this.GreenNumericUpDown.Size = new System.Drawing.Size(120, 34);
            this.GreenNumericUpDown.TabIndex = 7;
            this.GreenNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.GreenNumericUpDown.ValueChanged += new System.EventHandler(this.GreenNumericUpDown_ValueChanged);
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.Location = new System.Drawing.Point(83, 95);
            this.GreenTrackBar.Maximum = 255;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(187, 56);
            this.GreenTrackBar.TabIndex = 8;
            this.GreenTrackBar.Value = 4;
            this.GreenTrackBar.ValueChanged += new System.EventHandler(this.GreenTrackBar_ValueChanged);
            // 
            // RedNumericUpDown
            // 
            this.RedNumericUpDown.Location = new System.Drawing.Point(276, 31);
            this.RedNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedNumericUpDown.Name = "RedNumericUpDown";
            this.RedNumericUpDown.Size = new System.Drawing.Size(120, 34);
            this.RedNumericUpDown.TabIndex = 2;
            this.RedNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.RedNumericUpDown.ValueChanged += new System.EventHandler(this.RedNumericUpDown_ValueChanged);
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.Location = new System.Drawing.Point(83, 33);
            this.RedTrackBar.Maximum = 255;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(187, 56);
            this.RedTrackBar.TabIndex = 9;
            this.RedTrackBar.Value = 8;
            this.RedTrackBar.ValueChanged += new System.EventHandler(this.RedTrackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1176, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GenerateFractalButton);
            this.Controls.Add(this.FractalPictureBox);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FractalPictureBox;
        private System.Windows.Forms.Button GenerateFractalButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown BlueNumericUpDown;
        private System.Windows.Forms.TrackBar BlueTrackBar;
        private System.Windows.Forms.NumericUpDown GreenNumericUpDown;
        private System.Windows.Forms.TrackBar GreenTrackBar;
        private System.Windows.Forms.NumericUpDown RedNumericUpDown;
        private System.Windows.Forms.TrackBar RedTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

