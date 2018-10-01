namespace TTF_Test
{
	partial class MainWindow
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;


		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnSave = new System.Windows.Forms.Button();
			this.TxtNumber = new System.Windows.Forms.TextBox();
			this.LblNumber = new System.Windows.Forms.Label();
			this.ComboFont = new System.Windows.Forms.ComboBox();
			this.ComboSize = new System.Windows.Forms.ComboBox();
			this.ComboStyle = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RdNone = new System.Windows.Forms.RadioButton();
			this.RdInvalid = new System.Windows.Forms.RadioButton();
			this.RdHighSpeed = new System.Windows.Forms.RadioButton();
			this.RdHighQuality = new System.Windows.Forms.RadioButton();
			this.RdDefault = new System.Windows.Forms.RadioButton();
			this.RdAntiAlias = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RdNearestNeigbor = new System.Windows.Forms.RadioButton();
			this.RdLow = new System.Windows.Forms.RadioButton();
			this.RdInvalidInterpolation = new System.Windows.Forms.RadioButton();
			this.RdHighQualityLinear = new System.Windows.Forms.RadioButton();
			this.RdHighQualityBicubic = new System.Windows.Forms.RadioButton();
			this.RdHigh = new System.Windows.Forms.RadioButton();
			this.RdDefaultInterpolation = new System.Windows.Forms.RadioButton();
			this.RdBilinear = new System.Windows.Forms.RadioButton();
			this.RdBicubic = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.RdTextSystemDefault = new System.Windows.Forms.RadioButton();
			this.RdTextSingleBitPerPixelGridFit = new System.Windows.Forms.RadioButton();
			this.RdTextSingleBitPerPixel = new System.Windows.Forms.RadioButton();
			this.RdTextClearTypeGridFit = new System.Windows.Forms.RadioButton();
			this.RdTextAntiALiasGridFit = new System.Windows.Forms.RadioButton();
			this.RdTextAntiAlias = new System.Windows.Forms.RadioButton();
			this.TxtPath = new System.Windows.Forms.TextBox();
			this.BtnPath = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnSave
			// 
			this.BtnSave.Location = new System.Drawing.Point(15, 51);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(75, 23);
			this.BtnSave.TabIndex = 0;
			this.BtnSave.Text = "Save";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// TxtNumber
			// 
			this.TxtNumber.Location = new System.Drawing.Point(15, 25);
			this.TxtNumber.Name = "TxtNumber";
			this.TxtNumber.Size = new System.Drawing.Size(75, 20);
			this.TxtNumber.TabIndex = 1;
			this.TxtNumber.Text = "10";
			// 
			// LblNumber
			// 
			this.LblNumber.AutoSize = true;
			this.LblNumber.Location = new System.Drawing.Point(12, 9);
			this.LblNumber.Name = "LblNumber";
			this.LblNumber.Size = new System.Drawing.Size(47, 13);
			this.LblNumber.TabIndex = 2;
			this.LblNumber.Text = "Number:";
			// 
			// ComboFont
			// 
			this.ComboFont.FormattingEnabled = true;
			this.ComboFont.Location = new System.Drawing.Point(12, 100);
			this.ComboFont.Name = "ComboFont";
			this.ComboFont.Size = new System.Drawing.Size(154, 21);
			this.ComboFont.TabIndex = 3;
			// 
			// ComboSize
			// 
			this.ComboSize.FormattingEnabled = true;
			this.ComboSize.Location = new System.Drawing.Point(12, 127);
			this.ComboSize.Name = "ComboSize";
			this.ComboSize.Size = new System.Drawing.Size(154, 21);
			this.ComboSize.TabIndex = 3;
			// 
			// ComboStyle
			// 
			this.ComboStyle.FormattingEnabled = true;
			this.ComboStyle.Location = new System.Drawing.Point(12, 154);
			this.ComboStyle.Name = "ComboStyle";
			this.ComboStyle.Size = new System.Drawing.Size(154, 21);
			this.ComboStyle.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RdNone);
			this.groupBox1.Controls.Add(this.RdInvalid);
			this.groupBox1.Controls.Add(this.RdHighSpeed);
			this.groupBox1.Controls.Add(this.RdHighQuality);
			this.groupBox1.Controls.Add(this.RdDefault);
			this.groupBox1.Controls.Add(this.RdAntiAlias);
			this.groupBox1.Location = new System.Drawing.Point(12, 499);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(133, 160);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Smooth mode";
			this.groupBox1.Visible = false;
			// 
			// RdNone
			// 
			this.RdNone.AutoSize = true;
			this.RdNone.Location = new System.Drawing.Point(13, 134);
			this.RdNone.Name = "RdNone";
			this.RdNone.Size = new System.Drawing.Size(51, 17);
			this.RdNone.TabIndex = 0;
			this.RdNone.TabStop = true;
			this.RdNone.Text = "None";
			this.RdNone.UseVisualStyleBackColor = true;
			this.RdNone.CheckedChanged += new System.EventHandler(this.RdNone_CheckedChanged);
			// 
			// RdInvalid
			// 
			this.RdInvalid.AutoSize = true;
			this.RdInvalid.Location = new System.Drawing.Point(13, 111);
			this.RdInvalid.Name = "RdInvalid";
			this.RdInvalid.Size = new System.Drawing.Size(56, 17);
			this.RdInvalid.TabIndex = 0;
			this.RdInvalid.TabStop = true;
			this.RdInvalid.Text = "Invalid";
			this.RdInvalid.UseVisualStyleBackColor = true;
			this.RdInvalid.Visible = false;
			this.RdInvalid.CheckedChanged += new System.EventHandler(this.RdInvalid_CheckedChanged);
			// 
			// RdHighSpeed
			// 
			this.RdHighSpeed.AutoSize = true;
			this.RdHighSpeed.Location = new System.Drawing.Point(13, 88);
			this.RdHighSpeed.Name = "RdHighSpeed";
			this.RdHighSpeed.Size = new System.Drawing.Size(78, 17);
			this.RdHighSpeed.TabIndex = 0;
			this.RdHighSpeed.TabStop = true;
			this.RdHighSpeed.Text = "HighSpeed";
			this.RdHighSpeed.UseVisualStyleBackColor = true;
			this.RdHighSpeed.CheckedChanged += new System.EventHandler(this.RdHighSpeed_CheckedChanged);
			// 
			// RdHighQuality
			// 
			this.RdHighQuality.AutoSize = true;
			this.RdHighQuality.Location = new System.Drawing.Point(13, 65);
			this.RdHighQuality.Name = "RdHighQuality";
			this.RdHighQuality.Size = new System.Drawing.Size(79, 17);
			this.RdHighQuality.TabIndex = 0;
			this.RdHighQuality.TabStop = true;
			this.RdHighQuality.Text = "HighQuality";
			this.RdHighQuality.UseVisualStyleBackColor = true;
			this.RdHighQuality.CheckedChanged += new System.EventHandler(this.RdHighQuality_CheckedChanged);
			// 
			// RdDefault
			// 
			this.RdDefault.AutoSize = true;
			this.RdDefault.Location = new System.Drawing.Point(13, 42);
			this.RdDefault.Name = "RdDefault";
			this.RdDefault.Size = new System.Drawing.Size(59, 17);
			this.RdDefault.TabIndex = 0;
			this.RdDefault.TabStop = true;
			this.RdDefault.Text = "Default";
			this.RdDefault.UseVisualStyleBackColor = true;
			this.RdDefault.CheckedChanged += new System.EventHandler(this.RdDefault_CheckedChanged);
			// 
			// RdAntiAlias
			// 
			this.RdAntiAlias.AutoSize = true;
			this.RdAntiAlias.Location = new System.Drawing.Point(13, 19);
			this.RdAntiAlias.Name = "RdAntiAlias";
			this.RdAntiAlias.Size = new System.Drawing.Size(65, 17);
			this.RdAntiAlias.TabIndex = 0;
			this.RdAntiAlias.TabStop = true;
			this.RdAntiAlias.Text = "AntiAlias";
			this.RdAntiAlias.UseVisualStyleBackColor = true;
			this.RdAntiAlias.CheckedChanged += new System.EventHandler(this.RdAntiAlias_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.RdNearestNeigbor);
			this.groupBox2.Controls.Add(this.RdLow);
			this.groupBox2.Controls.Add(this.RdInvalidInterpolation);
			this.groupBox2.Controls.Add(this.RdHighQualityLinear);
			this.groupBox2.Controls.Add(this.RdHighQualityBicubic);
			this.groupBox2.Controls.Add(this.RdHigh);
			this.groupBox2.Controls.Add(this.RdDefaultInterpolation);
			this.groupBox2.Controls.Add(this.RdBilinear);
			this.groupBox2.Controls.Add(this.RdBicubic);
			this.groupBox2.Location = new System.Drawing.Point(39, 484);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(133, 255);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Interpolation mode";
			this.groupBox2.Visible = false;
			// 
			// RdNearestNeigbor
			// 
			this.RdNearestNeigbor.AutoSize = true;
			this.RdNearestNeigbor.Location = new System.Drawing.Point(13, 203);
			this.RdNearestNeigbor.Name = "RdNearestNeigbor";
			this.RdNearestNeigbor.Size = new System.Drawing.Size(99, 17);
			this.RdNearestNeigbor.TabIndex = 0;
			this.RdNearestNeigbor.TabStop = true;
			this.RdNearestNeigbor.Text = "NearestNeigbor";
			this.RdNearestNeigbor.UseVisualStyleBackColor = true;
			this.RdNearestNeigbor.CheckedChanged += new System.EventHandler(this.RdNearestNeigbor_CheckedChanged);
			// 
			// RdLow
			// 
			this.RdLow.AutoSize = true;
			this.RdLow.Location = new System.Drawing.Point(13, 180);
			this.RdLow.Name = "RdLow";
			this.RdLow.Size = new System.Drawing.Size(45, 17);
			this.RdLow.TabIndex = 0;
			this.RdLow.TabStop = true;
			this.RdLow.Text = "Low";
			this.RdLow.UseVisualStyleBackColor = true;
			this.RdLow.CheckedChanged += new System.EventHandler(this.RdLow_CheckedChanged);
			// 
			// RdInvalidInterpolation
			// 
			this.RdInvalidInterpolation.AutoSize = true;
			this.RdInvalidInterpolation.Location = new System.Drawing.Point(13, 157);
			this.RdInvalidInterpolation.Name = "RdInvalidInterpolation";
			this.RdInvalidInterpolation.Size = new System.Drawing.Size(56, 17);
			this.RdInvalidInterpolation.TabIndex = 0;
			this.RdInvalidInterpolation.TabStop = true;
			this.RdInvalidInterpolation.Text = "Invalid";
			this.RdInvalidInterpolation.UseVisualStyleBackColor = true;
			this.RdInvalidInterpolation.Visible = false;
			this.RdInvalidInterpolation.CheckedChanged += new System.EventHandler(this.RdInvalidInterpolation_CheckedChanged);
			// 
			// RdHighQualityLinear
			// 
			this.RdHighQualityLinear.AutoSize = true;
			this.RdHighQualityLinear.Location = new System.Drawing.Point(13, 134);
			this.RdHighQualityLinear.Name = "RdHighQualityLinear";
			this.RdHighQualityLinear.Size = new System.Drawing.Size(108, 17);
			this.RdHighQualityLinear.TabIndex = 0;
			this.RdHighQualityLinear.TabStop = true;
			this.RdHighQualityLinear.Text = "HighQualityLinear";
			this.RdHighQualityLinear.UseVisualStyleBackColor = true;
			this.RdHighQualityLinear.CheckedChanged += new System.EventHandler(this.RdHighQualityLinear_CheckedChanged);
			// 
			// RdHighQualityBicubic
			// 
			this.RdHighQualityBicubic.AutoSize = true;
			this.RdHighQualityBicubic.Location = new System.Drawing.Point(13, 111);
			this.RdHighQualityBicubic.Name = "RdHighQualityBicubic";
			this.RdHighQualityBicubic.Size = new System.Drawing.Size(114, 17);
			this.RdHighQualityBicubic.TabIndex = 0;
			this.RdHighQualityBicubic.TabStop = true;
			this.RdHighQualityBicubic.Text = "HighQualityBicubic";
			this.RdHighQualityBicubic.UseVisualStyleBackColor = true;
			this.RdHighQualityBicubic.CheckedChanged += new System.EventHandler(this.RdHighQualityBicubic_CheckedChanged);
			// 
			// RdHigh
			// 
			this.RdHigh.AutoSize = true;
			this.RdHigh.Location = new System.Drawing.Point(13, 88);
			this.RdHigh.Name = "RdHigh";
			this.RdHigh.Size = new System.Drawing.Size(47, 17);
			this.RdHigh.TabIndex = 0;
			this.RdHigh.TabStop = true;
			this.RdHigh.Text = "High";
			this.RdHigh.UseVisualStyleBackColor = true;
			this.RdHigh.CheckedChanged += new System.EventHandler(this.RdHigh_CheckedChanged);
			// 
			// RdDefaultInterpolation
			// 
			this.RdDefaultInterpolation.AutoSize = true;
			this.RdDefaultInterpolation.Location = new System.Drawing.Point(13, 65);
			this.RdDefaultInterpolation.Name = "RdDefaultInterpolation";
			this.RdDefaultInterpolation.Size = new System.Drawing.Size(59, 17);
			this.RdDefaultInterpolation.TabIndex = 0;
			this.RdDefaultInterpolation.TabStop = true;
			this.RdDefaultInterpolation.Text = "Default";
			this.RdDefaultInterpolation.UseVisualStyleBackColor = true;
			this.RdDefaultInterpolation.CheckedChanged += new System.EventHandler(this.RdDefaultInterpolation_CheckedChanged);
			// 
			// RdBilinear
			// 
			this.RdBilinear.AutoSize = true;
			this.RdBilinear.Location = new System.Drawing.Point(13, 42);
			this.RdBilinear.Name = "RdBilinear";
			this.RdBilinear.Size = new System.Drawing.Size(59, 17);
			this.RdBilinear.TabIndex = 0;
			this.RdBilinear.TabStop = true;
			this.RdBilinear.Text = "Bilinear";
			this.RdBilinear.UseVisualStyleBackColor = true;
			this.RdBilinear.CheckedChanged += new System.EventHandler(this.RdBilinear_CheckedChanged);
			// 
			// RdBicubic
			// 
			this.RdBicubic.AutoSize = true;
			this.RdBicubic.Location = new System.Drawing.Point(13, 19);
			this.RdBicubic.Name = "RdBicubic";
			this.RdBicubic.Size = new System.Drawing.Size(60, 17);
			this.RdBicubic.TabIndex = 0;
			this.RdBicubic.TabStop = true;
			this.RdBicubic.Text = "Bicubic";
			this.RdBicubic.UseVisualStyleBackColor = true;
			this.RdBicubic.CheckedChanged += new System.EventHandler(this.RdBicubic_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.RdTextSystemDefault);
			this.groupBox3.Controls.Add(this.RdTextSingleBitPerPixelGridFit);
			this.groupBox3.Controls.Add(this.RdTextSingleBitPerPixel);
			this.groupBox3.Controls.Add(this.RdTextClearTypeGridFit);
			this.groupBox3.Controls.Add(this.RdTextAntiALiasGridFit);
			this.groupBox3.Controls.Add(this.RdTextAntiAlias);
			this.groupBox3.Location = new System.Drawing.Point(12, 181);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(154, 166);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "TextRenderingHint";
			// 
			// RdTextSystemDefault
			// 
			this.RdTextSystemDefault.AutoSize = true;
			this.RdTextSystemDefault.Location = new System.Drawing.Point(13, 134);
			this.RdTextSystemDefault.Name = "RdTextSystemDefault";
			this.RdTextSystemDefault.Size = new System.Drawing.Size(93, 17);
			this.RdTextSystemDefault.TabIndex = 0;
			this.RdTextSystemDefault.Text = "SystemDefault";
			this.RdTextSystemDefault.UseVisualStyleBackColor = true;
			this.RdTextSystemDefault.CheckedChanged += new System.EventHandler(this.RdTextSystemDefault_CheckedChanged);
			// 
			// RdTextSingleBitPerPixelGridFit
			// 
			this.RdTextSingleBitPerPixelGridFit.AutoSize = true;
			this.RdTextSingleBitPerPixelGridFit.Checked = true;
			this.RdTextSingleBitPerPixelGridFit.Location = new System.Drawing.Point(13, 111);
			this.RdTextSingleBitPerPixelGridFit.Name = "RdTextSingleBitPerPixelGridFit";
			this.RdTextSingleBitPerPixelGridFit.Size = new System.Drawing.Size(134, 17);
			this.RdTextSingleBitPerPixelGridFit.TabIndex = 0;
			this.RdTextSingleBitPerPixelGridFit.TabStop = true;
			this.RdTextSingleBitPerPixelGridFit.Text = "SingleBitPerPixelGridFit";
			this.RdTextSingleBitPerPixelGridFit.UseVisualStyleBackColor = true;
			this.RdTextSingleBitPerPixelGridFit.CheckedChanged += new System.EventHandler(this.RdTextSingleBitPerPixelGridFit_CheckedChanged);
			// 
			// RdTextSingleBitPerPixel
			// 
			this.RdTextSingleBitPerPixel.AutoSize = true;
			this.RdTextSingleBitPerPixel.Location = new System.Drawing.Point(13, 88);
			this.RdTextSingleBitPerPixel.Name = "RdTextSingleBitPerPixel";
			this.RdTextSingleBitPerPixel.Size = new System.Drawing.Size(104, 17);
			this.RdTextSingleBitPerPixel.TabIndex = 0;
			this.RdTextSingleBitPerPixel.Text = "SingleBitPerPixel";
			this.RdTextSingleBitPerPixel.UseVisualStyleBackColor = true;
			this.RdTextSingleBitPerPixel.CheckedChanged += new System.EventHandler(this.RdTextSingleBitPerPixel_CheckedChanged);
			// 
			// RdTextClearTypeGridFit
			// 
			this.RdTextClearTypeGridFit.AutoSize = true;
			this.RdTextClearTypeGridFit.Location = new System.Drawing.Point(13, 65);
			this.RdTextClearTypeGridFit.Name = "RdTextClearTypeGridFit";
			this.RdTextClearTypeGridFit.Size = new System.Drawing.Size(103, 17);
			this.RdTextClearTypeGridFit.TabIndex = 0;
			this.RdTextClearTypeGridFit.Text = "ClearTypeGridFit";
			this.RdTextClearTypeGridFit.UseVisualStyleBackColor = true;
			this.RdTextClearTypeGridFit.CheckedChanged += new System.EventHandler(this.RdTextClearTypeGridFit_CheckedChanged);
			// 
			// RdTextAntiALiasGridFit
			// 
			this.RdTextAntiALiasGridFit.AutoSize = true;
			this.RdTextAntiALiasGridFit.Location = new System.Drawing.Point(13, 42);
			this.RdTextAntiALiasGridFit.Name = "RdTextAntiALiasGridFit";
			this.RdTextAntiALiasGridFit.Size = new System.Drawing.Size(95, 17);
			this.RdTextAntiALiasGridFit.TabIndex = 0;
			this.RdTextAntiALiasGridFit.Text = "AntiAliasGridFit";
			this.RdTextAntiALiasGridFit.UseVisualStyleBackColor = true;
			this.RdTextAntiALiasGridFit.CheckedChanged += new System.EventHandler(this.RdTextAntiALiasGridFit_CheckedChanged);
			// 
			// RdTextAntiAlias
			// 
			this.RdTextAntiAlias.AutoSize = true;
			this.RdTextAntiAlias.Location = new System.Drawing.Point(13, 19);
			this.RdTextAntiAlias.Name = "RdTextAntiAlias";
			this.RdTextAntiAlias.Size = new System.Drawing.Size(65, 17);
			this.RdTextAntiAlias.TabIndex = 0;
			this.RdTextAntiAlias.Text = "AntiAlias";
			this.RdTextAntiAlias.UseVisualStyleBackColor = true;
			this.RdTextAntiAlias.CheckedChanged += new System.EventHandler(this.RdTextAntiAlias_CheckedChanged);
			// 
			// TxtPath
			// 
			this.TxtPath.Location = new System.Drawing.Point(96, 25);
			this.TxtPath.Name = "TxtPath";
			this.TxtPath.Size = new System.Drawing.Size(100, 20);
			this.TxtPath.TabIndex = 7;
			// 
			// BtnPath
			// 
			this.BtnPath.Location = new System.Drawing.Point(96, 52);
			this.BtnPath.Name = "BtnPath";
			this.BtnPath.Size = new System.Drawing.Size(75, 23);
			this.BtnPath.TabIndex = 8;
			this.BtnPath.Text = "Path …";
			this.BtnPath.UseVisualStyleBackColor = true;
			this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 614);
			this.Controls.Add(this.BtnPath);
			this.Controls.Add(this.TxtPath);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ComboStyle);
			this.Controls.Add(this.ComboSize);
			this.Controls.Add(this.ComboFont);
			this.Controls.Add(this.LblNumber);
			this.Controls.Add(this.TxtNumber);
			this.Controls.Add(this.BtnSave);
			this.Name = "MainWindow";
			this.Text = "TTF to WFN";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
			this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
			this.Click += new System.EventHandler(this.MainWindow_Click);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnSave;
		private System.Windows.Forms.TextBox TxtNumber;
		private System.Windows.Forms.Label LblNumber;
		private System.Windows.Forms.ComboBox ComboFont;
		private System.Windows.Forms.ComboBox ComboSize;
		private System.Windows.Forms.ComboBox ComboStyle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton RdNone;
		private System.Windows.Forms.RadioButton RdInvalid;
		private System.Windows.Forms.RadioButton RdHighSpeed;
		private System.Windows.Forms.RadioButton RdHighQuality;
		private System.Windows.Forms.RadioButton RdDefault;
		private System.Windows.Forms.RadioButton RdAntiAlias;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton RdNearestNeigbor;
		private System.Windows.Forms.RadioButton RdLow;
		private System.Windows.Forms.RadioButton RdInvalidInterpolation;
		private System.Windows.Forms.RadioButton RdHighQualityLinear;
		private System.Windows.Forms.RadioButton RdHighQualityBicubic;
		private System.Windows.Forms.RadioButton RdDefaultInterpolation;
		private System.Windows.Forms.RadioButton RdBilinear;
		private System.Windows.Forms.RadioButton RdBicubic;
		private System.Windows.Forms.RadioButton RdHigh;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton RdTextAntiALiasGridFit;
		private System.Windows.Forms.RadioButton RdTextAntiAlias;
		private System.Windows.Forms.RadioButton RdTextSystemDefault;
		private System.Windows.Forms.RadioButton RdTextSingleBitPerPixelGridFit;
		private System.Windows.Forms.RadioButton RdTextSingleBitPerPixel;
		private System.Windows.Forms.RadioButton RdTextClearTypeGridFit;
		private System.Windows.Forms.TextBox TxtPath;
		private System.Windows.Forms.Button BtnPath;
	}
}

