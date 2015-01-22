namespace OperationPool
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddParametersBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.function_name = new System.Windows.Forms.TextBox();
            this.AddFunctionBtn = new System.Windows.Forms.Button();
            this.serialize = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DoItBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ptype = new System.Windows.Forms.TextBox();
            this.Pname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pvalue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.AddToListBtn = new System.Windows.Forms.Button();
            this.addP_btn = new System.Windows.Forms.Button();
            this.parameters_window = new System.Windows.Forms.GroupBox();
            this.lan = new System.Windows.Forms.ComboBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.parameters_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(434, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddParametersBtn
            // 
            this.AddParametersBtn.Location = new System.Drawing.Point(636, 157);
            this.AddParametersBtn.Name = "AddParametersBtn";
            this.AddParametersBtn.Size = new System.Drawing.Size(93, 25);
            this.AddParametersBtn.TabIndex = 2;
            this.AddParametersBtn.Text = "Add Parameters";
            this.AddParametersBtn.UseVisualStyleBackColor = true;
            this.AddParametersBtn.Click += new System.EventHandler(this.AddParametersBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(569, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Function Name:";
            // 
            // function_name
            // 
            this.function_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.function_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.function_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.function_name.Location = new System.Drawing.Point(572, 72);
            this.function_name.Name = "function_name";
            this.function_name.Size = new System.Drawing.Size(109, 20);
            this.function_name.TabIndex = 4;
            // 
            // AddFunctionBtn
            // 
            this.AddFunctionBtn.AutoEllipsis = true;
            this.AddFunctionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddFunctionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFunctionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddFunctionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddFunctionBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddFunctionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddFunctionBtn.Location = new System.Drawing.Point(438, 111);
            this.AddFunctionBtn.Name = "AddFunctionBtn";
            this.AddFunctionBtn.Size = new System.Drawing.Size(91, 25);
            this.AddFunctionBtn.TabIndex = 8;
            this.AddFunctionBtn.Text = "Add ";
            this.AddFunctionBtn.UseVisualStyleBackColor = true;
            this.AddFunctionBtn.Click += new System.EventHandler(this.AddFunctionBtn_Click);
            // 
            // serialize
            // 
            this.serialize.Location = new System.Drawing.Point(636, 456);
            this.serialize.Name = "serialize";
            this.serialize.Size = new System.Drawing.Size(79, 29);
            this.serialize.TabIndex = 9;
            this.serialize.Text = "Serialize";
            this.serialize.UseVisualStyleBackColor = true;
            this.serialize.Click += new System.EventHandler(this.serialize_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(20, 456);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(74, 29);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(44, 260);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar2.TabIndex = 12;
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileName.Location = new System.Drawing.Point(515, 465);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 20);
            this.fileName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(435, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = " File Name";
            // 
            // DoItBtn
            // 
            this.DoItBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DoItBtn.Location = new System.Drawing.Point(15, 308);
            this.DoItBtn.Name = "DoItBtn";
            this.DoItBtn.Size = new System.Drawing.Size(75, 29);
            this.DoItBtn.TabIndex = 15;
            this.DoItBtn.Text = "Run";
            this.DoItBtn.UseVisualStyleBackColor = true;
            this.DoItBtn.Click += new System.EventHandler(this.DoItBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(15, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(385, 215);
            this.textBox1.TabIndex = 17;
            this.textBox1.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(17, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Function List:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Ptype
            // 
            this.Ptype.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ptype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ptype.Location = new System.Drawing.Point(81, 98);
            this.Ptype.Name = "Ptype";
            this.Ptype.Size = new System.Drawing.Size(109, 23);
            this.Ptype.TabIndex = 0;
            // 
            // Pname
            // 
            this.Pname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pname.Location = new System.Drawing.Point(81, 52);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(109, 23);
            this.Pname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(27, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type:";
            // 
            // Pvalue
            // 
            this.Pvalue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pvalue.Location = new System.Drawing.Point(81, 144);
            this.Pvalue.Name = "Pvalue";
            this.Pvalue.Size = new System.Drawing.Size(109, 23);
            this.Pvalue.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(29, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value:";
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(98, 190);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(75, 24);
            this.DoneBtn.TabIndex = 7;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // AddToListBtn
            // 
            this.AddToListBtn.Location = new System.Drawing.Point(12, 190);
            this.AddToListBtn.Name = "AddToListBtn";
            this.AddToListBtn.Size = new System.Drawing.Size(80, 24);
            this.AddToListBtn.TabIndex = 9;
            this.AddToListBtn.Text = "View Function";
            this.AddToListBtn.UseVisualStyleBackColor = true;
            this.AddToListBtn.Click += new System.EventHandler(this.AddToListBtn_Click);
            // 
            // addP_btn
            // 
            this.addP_btn.BackColor = System.Drawing.SystemColors.Control;
            this.addP_btn.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.addP_btn.Location = new System.Drawing.Point(188, 190);
            this.addP_btn.Name = "addP_btn";
            this.addP_btn.Size = new System.Drawing.Size(81, 24);
            this.addP_btn.TabIndex = 10;
            this.addP_btn.Text = "Add Parameter";
            this.addP_btn.UseVisualStyleBackColor = true;
            this.addP_btn.Click += new System.EventHandler(this.addP_btn_Click);
            // 
            // parameters_window
            // 
            this.parameters_window.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.parameters_window.AutoSize = true;
            this.parameters_window.BackColor = System.Drawing.Color.Transparent;
            this.parameters_window.Controls.Add(this.addP_btn);
            this.parameters_window.Controls.Add(this.AddToListBtn);
            this.parameters_window.Controls.Add(this.DoneBtn);
            this.parameters_window.Controls.Add(this.label5);
            this.parameters_window.Controls.Add(this.Pvalue);
            this.parameters_window.Controls.Add(this.label4);
            this.parameters_window.Controls.Add(this.label3);
            this.parameters_window.Controls.Add(this.Ptype);
            this.parameters_window.Controls.Add(this.Pname);
            this.parameters_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.parameters_window.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parameters_window.Location = new System.Drawing.Point(425, 197);
            this.parameters_window.Name = "parameters_window";
            this.parameters_window.Size = new System.Drawing.Size(304, 236);
            this.parameters_window.TabIndex = 5;
            this.parameters_window.TabStop = false;
            this.parameters_window.Text = "Parameters";
            // 
            // lan
            // 
            this.lan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lan.FormattingEnabled = true;
            this.lan.Items.AddRange(new object[] {
            "Matlab",
            "Python"});
            this.lan.Location = new System.Drawing.Point(437, 71);
            this.lan.Name = "lan";
            this.lan.Size = new System.Drawing.Size(109, 21);
            this.lan.TabIndex = 20;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoadBtn.Location = new System.Drawing.Point(331, 308);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(69, 29);
            this.LoadBtn.TabIndex = 21;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::OperationPool.Properties.Resources._022895547_prevstill;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 503);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.lan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DoItBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.serialize);
            this.Controls.Add(this.AddFunctionBtn);
            this.Controls.Add(this.parameters_window);
            this.Controls.Add(this.function_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddParametersBtn);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations Pool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.parameters_window.ResumeLayout(false);
            this.parameters_window.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddParametersBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox function_name;
      //  private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button AddFunctionBtn;
        private System.Windows.Forms.Button serialize;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DoItBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Ptype;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pvalue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Button AddToListBtn;
        private System.Windows.Forms.Button addP_btn;
        private System.Windows.Forms.GroupBox parameters_window;
        private System.Windows.Forms.ComboBox lan;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

