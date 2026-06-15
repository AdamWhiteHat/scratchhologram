namespace ScratchTest
{
    partial class ScratchTest
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
            mViewAngleTrack = new System.Windows.Forms.TrackBar();
            mArcSweepAngleTrack = new System.Windows.Forms.TrackBar();
            mArcCheckBox = new System.Windows.Forms.CheckBox();
            mPointSizeTextBox = new System.Windows.Forms.TextBox();
            mLineResolutionTrack = new System.Windows.Forms.TrackBar();
            mNormalRadioButton = new System.Windows.Forms.RadioButton();
            mRedBlueRadioButton = new System.Windows.Forms.RadioButton();
            mStereoscopicRadioButton = new System.Windows.Forms.RadioButton();
            mPrintRadioButton = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            mDebugCheckBox = new System.Windows.Forms.CheckBox();
            zf = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            zfTrackBar = new System.Windows.Forms.TrackBar();
            mSwitchCheckBox = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            mEyesTrackBar = new System.Windows.Forms.TrackBar();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            quickModeCheckBox = new System.Windows.Forms.CheckBox();
            mHiddenLineCheckBox = new System.Windows.Forms.CheckBox();
            mVectorsCheckBox = new System.Windows.Forms.CheckBox();
            mSwitchBackFrontCheckBox = new System.Windows.Forms.CheckBox();
            mOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            mOpenButton = new System.Windows.Forms.Button();
            mView = new ScratchView.View();
            mGenerateButton = new System.Windows.Forms.Button();
            labelOpenFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)mViewAngleTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mArcSweepAngleTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mLineResolutionTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zfTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mEyesTrackBar).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // mViewAngleTrack
            // 
            mViewAngleTrack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mViewAngleTrack.Location = new System.Drawing.Point(15, 14);
            mViewAngleTrack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mViewAngleTrack.Maximum = 90;
            mViewAngleTrack.Minimum = -90;
            mViewAngleTrack.Name = "mViewAngleTrack";
            mViewAngleTrack.Size = new System.Drawing.Size(950, 45);
            mViewAngleTrack.TabIndex = 1;
            mViewAngleTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            mViewAngleTrack.Scroll += mViewAngleTrack_Scroll;
            mViewAngleTrack.ValueChanged += mViewAngleTrack_ValueChanged;
            mViewAngleTrack.KeyDown += mViewAngleTrack_KeyDown;
            // 
            // mArcSweepAngleTrack
            // 
            mArcSweepAngleTrack.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            mArcSweepAngleTrack.Location = new System.Drawing.Point(974, 91);
            mArcSweepAngleTrack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mArcSweepAngleTrack.Maximum = 180;
            mArcSweepAngleTrack.Name = "mArcSweepAngleTrack";
            mArcSweepAngleTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            mArcSweepAngleTrack.Size = new System.Drawing.Size(45, 187);
            mArcSweepAngleTrack.TabIndex = 2;
            mArcSweepAngleTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            mArcSweepAngleTrack.Value = 180;
            mArcSweepAngleTrack.Scroll += mArcSweepAngleTrack_Scroll;
            // 
            // mArcCheckBox
            // 
            mArcCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            mArcCheckBox.AutoSize = true;
            mArcCheckBox.Location = new System.Drawing.Point(978, 14);
            mArcCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mArcCheckBox.Name = "mArcCheckBox";
            mArcCheckBox.Size = new System.Drawing.Size(43, 19);
            mArcCheckBox.TabIndex = 3;
            mArcCheckBox.Text = "Arc";
            mArcCheckBox.UseVisualStyleBackColor = true;
            mArcCheckBox.CheckedChanged += mArcCheckBox_CheckedChanged;
            // 
            // mPointSizeTextBox
            // 
            mPointSizeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            mPointSizeTextBox.Location = new System.Drawing.Point(988, 759);
            mPointSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mPointSizeTextBox.Name = "mPointSizeTextBox";
            mPointSizeTextBox.Size = new System.Drawing.Size(32, 21);
            mPointSizeTextBox.TabIndex = 5;
            mPointSizeTextBox.Text = "5";
            mPointSizeTextBox.TextChanged += mPointSizeTextBox_TextChanged;
            // 
            // mLineResolutionTrack
            // 
            mLineResolutionTrack.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mLineResolutionTrack.Location = new System.Drawing.Point(14, 708);
            mLineResolutionTrack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mLineResolutionTrack.Maximum = 2000;
            mLineResolutionTrack.Minimum = 1;
            mLineResolutionTrack.Name = "mLineResolutionTrack";
            mLineResolutionTrack.Size = new System.Drawing.Size(639, 45);
            mLineResolutionTrack.TabIndex = 6;
            mLineResolutionTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            mLineResolutionTrack.Value = 800;
            mLineResolutionTrack.Scroll += mLineResolutionTrack_Scroll;
            // 
            // mNormalRadioButton
            // 
            mNormalRadioButton.AutoSize = true;
            mNormalRadioButton.Checked = true;
            mNormalRadioButton.Location = new System.Drawing.Point(7, 22);
            mNormalRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mNormalRadioButton.Name = "mNormalRadioButton";
            mNormalRadioButton.Size = new System.Drawing.Size(66, 19);
            mNormalRadioButton.TabIndex = 7;
            mNormalRadioButton.TabStop = true;
            mNormalRadioButton.Text = "Normal";
            mNormalRadioButton.UseVisualStyleBackColor = true;
            mNormalRadioButton.CheckedChanged += mViewModeRadioButton_CheckedChanged;
            // 
            // mRedBlueRadioButton
            // 
            mRedBlueRadioButton.AutoSize = true;
            mRedBlueRadioButton.Location = new System.Drawing.Point(7, 48);
            mRedBlueRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mRedBlueRadioButton.Name = "mRedBlueRadioButton";
            mRedBlueRadioButton.Size = new System.Drawing.Size(76, 19);
            mRedBlueRadioButton.TabIndex = 8;
            mRedBlueRadioButton.Text = "Red/Blue";
            mRedBlueRadioButton.UseVisualStyleBackColor = true;
            mRedBlueRadioButton.CheckedChanged += mViewModeRadioButton_CheckedChanged;
            // 
            // mStereoscopicRadioButton
            // 
            mStereoscopicRadioButton.AutoSize = true;
            mStereoscopicRadioButton.Location = new System.Drawing.Point(7, 75);
            mStereoscopicRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mStereoscopicRadioButton.Name = "mStereoscopicRadioButton";
            mStereoscopicRadioButton.Size = new System.Drawing.Size(96, 19);
            mStereoscopicRadioButton.TabIndex = 9;
            mStereoscopicRadioButton.Text = "Stereoscopic";
            mStereoscopicRadioButton.UseVisualStyleBackColor = true;
            mStereoscopicRadioButton.CheckedChanged += mViewModeRadioButton_CheckedChanged;
            // 
            // mPrintRadioButton
            // 
            mPrintRadioButton.AutoSize = true;
            mPrintRadioButton.Location = new System.Drawing.Point(7, 100);
            mPrintRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mPrintRadioButton.Name = "mPrintRadioButton";
            mPrintRadioButton.Size = new System.Drawing.Size(50, 19);
            mPrintRadioButton.TabIndex = 11;
            mPrintRadioButton.TabStop = true;
            mPrintRadioButton.Text = "Print";
            mPrintRadioButton.UseVisualStyleBackColor = true;
            mPrintRadioButton.CheckedChanged += mViewModeRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(896, 764);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 12;
            label1.Text = "Point diameter:";
            // 
            // mDebugCheckBox
            // 
            mDebugCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            mDebugCheckBox.AutoSize = true;
            mDebugCheckBox.Location = new System.Drawing.Point(977, 40);
            mDebugCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mDebugCheckBox.Name = "mDebugCheckBox";
            mDebugCheckBox.Size = new System.Drawing.Size(63, 19);
            mDebugCheckBox.TabIndex = 15;
            mDebugCheckBox.Text = "Debug";
            mDebugCheckBox.UseVisualStyleBackColor = true;
            mDebugCheckBox.CheckedChanged += mDebugCheckBox_CheckedChanged;
            // 
            // zf
            // 
            zf.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            zf.Location = new System.Drawing.Point(978, 502);
            zf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            zf.Name = "zf";
            zf.Size = new System.Drawing.Size(48, 21);
            zf.TabIndex = 21;
            zf.Text = "25";
            zf.TextChanged += zf_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(974, 73);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 15);
            label2.TabIndex = 23;
            label2.Text = "Arcs:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(972, 286);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(20, 15);
            label3.TabIndex = 24;
            label3.Text = "Zf:";
            // 
            // zfTrackBar
            // 
            zfTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            zfTrackBar.Location = new System.Drawing.Point(978, 305);
            zfTrackBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            zfTrackBar.Maximum = 10000;
            zfTrackBar.Name = "zfTrackBar";
            zfTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            zfTrackBar.Size = new System.Drawing.Size(45, 190);
            zfTrackBar.TabIndex = 25;
            zfTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            zfTrackBar.Value = 2500;
            zfTrackBar.Scroll += zfTrackBar_Scroll;
            // 
            // mSwitchCheckBox
            // 
            mSwitchCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            mSwitchCheckBox.AutoSize = true;
            mSwitchCheckBox.Location = new System.Drawing.Point(909, 709);
            mSwitchCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mSwitchCheckBox.Name = "mSwitchCheckBox";
            mSwitchCheckBox.Size = new System.Drawing.Size(117, 19);
            mSwitchCheckBox.TabIndex = 26;
            mSwitchCheckBox.Text = "Switch Left/Right";
            mSwitchCheckBox.UseVisualStyleBackColor = true;
            mSwitchCheckBox.CheckedChanged += mSwitchCheckBox_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(975, 533);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 15);
            label4.TabIndex = 27;
            label4.Text = "Eyes:";
            // 
            // mEyesTrackBar
            // 
            mEyesTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            mEyesTrackBar.Location = new System.Drawing.Point(978, 554);
            mEyesTrackBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mEyesTrackBar.Maximum = 40;
            mEyesTrackBar.Name = "mEyesTrackBar";
            mEyesTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            mEyesTrackBar.Size = new System.Drawing.Size(45, 148);
            mEyesTrackBar.TabIndex = 28;
            mEyesTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            mEyesTrackBar.Value = 10;
            mEyesTrackBar.Scroll += mEyesTrackBar_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(mNormalRadioButton);
            groupBox1.Controls.Add(mRedBlueRadioButton);
            groupBox1.Controls.Add(mStereoscopicRadioButton);
            groupBox1.Controls.Add(mPrintRadioButton);
            groupBox1.Location = new System.Drawing.Point(660, 689);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(113, 132);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mode";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(quickModeCheckBox);
            groupBox2.Controls.Add(mHiddenLineCheckBox);
            groupBox2.Controls.Add(mVectorsCheckBox);
            groupBox2.Location = new System.Drawing.Point(780, 690);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(108, 130);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "View";
            // 
            // quickModeCheckBox
            // 
            quickModeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            quickModeCheckBox.AutoSize = true;
            quickModeCheckBox.Checked = true;
            quickModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            quickModeCheckBox.Location = new System.Drawing.Point(13, 99);
            quickModeCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            quickModeCheckBox.Name = "quickModeCheckBox";
            quickModeCheckBox.Size = new System.Drawing.Size(92, 19);
            quickModeCheckBox.TabIndex = 23;
            quickModeCheckBox.Text = "Quick Mode";
            quickModeCheckBox.UseVisualStyleBackColor = true;
            quickModeCheckBox.CheckedChanged += quickModeCheckBox_CheckedChanged;
            // 
            // mHiddenLineCheckBox
            // 
            mHiddenLineCheckBox.AutoSize = true;
            mHiddenLineCheckBox.Checked = true;
            mHiddenLineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            mHiddenLineCheckBox.Location = new System.Drawing.Point(8, 18);
            mHiddenLineCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mHiddenLineCheckBox.Name = "mHiddenLineCheckBox";
            mHiddenLineCheckBox.Size = new System.Drawing.Size(93, 19);
            mHiddenLineCheckBox.TabIndex = 3;
            mHiddenLineCheckBox.Text = "Hidden Line";
            mHiddenLineCheckBox.UseVisualStyleBackColor = true;
            mHiddenLineCheckBox.CheckedChanged += mHiddenLineCheckBox_CheckedChanged;
            // 
            // mVectorsCheckBox
            // 
            mVectorsCheckBox.AutoSize = true;
            mVectorsCheckBox.Checked = true;
            mVectorsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            mVectorsCheckBox.Location = new System.Drawing.Point(8, 45);
            mVectorsCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mVectorsCheckBox.Name = "mVectorsCheckBox";
            mVectorsCheckBox.Size = new System.Drawing.Size(66, 19);
            mVectorsCheckBox.TabIndex = 2;
            mVectorsCheckBox.Text = "Vectors";
            mVectorsCheckBox.UseVisualStyleBackColor = true;
            mVectorsCheckBox.CheckedChanged += mVectorsCheckBox_CheckedChanged;
            // 
            // mSwitchBackFrontCheckBox
            // 
            mSwitchBackFrontCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            mSwitchBackFrontCheckBox.AutoSize = true;
            mSwitchBackFrontCheckBox.Location = new System.Drawing.Point(909, 736);
            mSwitchBackFrontCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mSwitchBackFrontCheckBox.Name = "mSwitchBackFrontCheckBox";
            mSwitchBackFrontCheckBox.Size = new System.Drawing.Size(117, 19);
            mSwitchBackFrontCheckBox.TabIndex = 32;
            mSwitchBackFrontCheckBox.Text = "Swith Back/Front";
            mSwitchBackFrontCheckBox.UseVisualStyleBackColor = true;
            mSwitchBackFrontCheckBox.CheckedChanged += mSwitchBackFrontCheckBox_CheckedChanged;
            // 
            // mOpenFileDialog
            // 
            mOpenFileDialog.Filter = "(*.x3d)|*.x3d|All files (*.*)|*.*\"";
            mOpenFileDialog.InitialDirectory = "c:\\Program Files\\Blender Foundation\\Blender";
            mOpenFileDialog.Title = "Select an x3d file";
            // 
            // mOpenButton
            // 
            mOpenButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            mOpenButton.Location = new System.Drawing.Point(15, 767);
            mOpenButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mOpenButton.Name = "mOpenButton";
            mOpenButton.Size = new System.Drawing.Size(88, 27);
            mOpenButton.TabIndex = 33;
            mOpenButton.Text = "Open";
            mOpenButton.UseVisualStyleBackColor = true;
            mOpenButton.Click += mOpenButton_Click;
            // 
            // mView
            // 
            mView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mView.ArcAngleResolution = 10F;
            mView.ArcSweepAngle = 90F;
            mView.BackColor = System.Drawing.Color.White;
            mView.Location = new System.Drawing.Point(15, 73);
            mView.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            mView.Name = "mView";
            mView.PaddingPercent = 0.1D;
            mView.PointWidth = 5D;
            mView.RotateCanvas = false;
            mView.ShowArcs = true;
            mView.Size = new System.Drawing.Size(950, 609);
            mView.StereoscopicDisparityAngle = 8D;
            mView.StereoscopicMode = ScratchUtility.StereoscopicMode.NonStereoscopic;
            mView.SwitchBackFront = false;
            mView.SwitchLeftRight = false;
            mView.TabIndex = 29;
            mView.VectorMode = true;
            mView.ViewAngle = 0D;
            mView.ViewMode = ViewSupport.ViewMode.Normal;
            mView.ViewPointsPerUnitLength = 0D;
            mView.VisibilityMode = ViewSupport.VisibilityMode.Transparent;
            // 
            // mGenerateButton
            // 
            mGenerateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            mGenerateButton.Location = new System.Drawing.Point(432, 767);
            mGenerateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mGenerateButton.Name = "mGenerateButton";
            mGenerateButton.Size = new System.Drawing.Size(88, 27);
            mGenerateButton.TabIndex = 35;
            mGenerateButton.Text = "Generate";
            mGenerateButton.UseVisualStyleBackColor = true;
            mGenerateButton.Click += mGenerateButton_Click;
            // 
            // labelOpenFile
            // 
            labelOpenFile.AutoSize = true;
            labelOpenFile.Location = new System.Drawing.Point(26, 805);
            labelOpenFile.Name = "labelOpenFile";
            labelOpenFile.Size = new System.Drawing.Size(49, 15);
            labelOpenFile.TabIndex = 36;
            labelOpenFile.Text = "              ";
            // 
            // ScratchTest
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1041, 834);
            Controls.Add(labelOpenFile);
            Controls.Add(mGenerateButton);
            Controls.Add(mOpenButton);
            Controls.Add(mSwitchBackFrontCheckBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(mView);
            Controls.Add(mEyesTrackBar);
            Controls.Add(label4);
            Controls.Add(mSwitchCheckBox);
            Controls.Add(zfTrackBar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(zf);
            Controls.Add(mDebugCheckBox);
            Controls.Add(label1);
            Controls.Add(mLineResolutionTrack);
            Controls.Add(mPointSizeTextBox);
            Controls.Add(mArcCheckBox);
            Controls.Add(mArcSweepAngleTrack);
            Controls.Add(mViewAngleTrack);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ScratchTest";
            Text = "Scratch Test";
            ((System.ComponentModel.ISupportInitialize)mViewAngleTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)mArcSweepAngleTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)mLineResolutionTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)zfTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)mEyesTrackBar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar mViewAngleTrack;
        private System.Windows.Forms.TrackBar mArcSweepAngleTrack;
        private System.Windows.Forms.CheckBox mArcCheckBox;
        private System.Windows.Forms.TextBox mPointSizeTextBox;
        private System.Windows.Forms.TrackBar mLineResolutionTrack;
        private System.Windows.Forms.RadioButton mNormalRadioButton;
        private System.Windows.Forms.RadioButton mRedBlueRadioButton;
        private System.Windows.Forms.RadioButton mStereoscopicRadioButton;
        private System.Windows.Forms.RadioButton mPrintRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox mDebugCheckBox;
        private System.Windows.Forms.TextBox zf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar zfTrackBar;
        private System.Windows.Forms.CheckBox mSwitchCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar mEyesTrackBar;
        private ScratchView.View mView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox mSwitchBackFrontCheckBox;
        private System.Windows.Forms.OpenFileDialog mOpenFileDialog;
        private System.Windows.Forms.Button mOpenButton;
        private System.Windows.Forms.CheckBox mVectorsCheckBox;
        private System.Windows.Forms.CheckBox mHiddenLineCheckBox;
        private System.Windows.Forms.CheckBox quickModeCheckBox;
        private System.Windows.Forms.Button mGenerateButton;
        private System.Windows.Forms.Label labelOpenFile;
    }
}

