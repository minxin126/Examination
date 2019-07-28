namespace Examination
{
    partial class FormOne
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnJustify = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lstDisp = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(158, 239);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 49);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "出题";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "自动出题系统";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(621, 146);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(58, 35);
            this.txtAnswer.TabIndex = 5;
            // 
            // btnJustify
            // 
            this.btnJustify.Location = new System.Drawing.Point(584, 239);
            this.btnJustify.Name = "btnJustify";
            this.btnJustify.Size = new System.Drawing.Size(95, 49);
            this.btnJustify.TabIndex = 6;
            this.btnJustify.Text = "评分";
            this.btnJustify.UseVisualStyleBackColor = true;
            this.btnJustify.Click += new System.EventHandler(this.btnJustify_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(31, 149);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(46, 24);
            this.lblA.TabIndex = 9;
            this.lblA.Text = "   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "   ";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(154, 149);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(46, 24);
            this.lblOp.TabIndex = 11;
            this.lblOp.Text = "   ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(309, 149);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(46, 24);
            this.lblB.TabIndex = 12;
            this.lblB.Text = "   ";
            // 
            // lstDisp
            // 
            this.lstDisp.FormattingEnabled = true;
            this.lstDisp.ItemHeight = 24;
            this.lstDisp.Location = new System.Drawing.Point(281, 360);
            this.lstDisp.Name = "lstDisp";
            this.lstDisp.Size = new System.Drawing.Size(398, 220);
            this.lstDisp.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 690);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstDisp);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnJustify);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnJustify;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.ListBox lstDisp;
        private System.Windows.Forms.Label label6;
    }
}

