namespace CFTTools
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreateSQLType = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnCreateDbLink = new System.Windows.Forms.Button();
            this.btnCreateToUpper = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreateNumSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateSQLType
            // 
            this.btnCreateSQLType.Location = new System.Drawing.Point(225, 52);
            this.btnCreateSQLType.Name = "btnCreateSQLType";
            this.btnCreateSQLType.Size = new System.Drawing.Size(111, 36);
            this.btnCreateSQLType.TabIndex = 2;
            this.btnCreateSQLType.Text = "SQL格式=>";
            this.btnCreateSQLType.UseVisualStyleBackColor = true;
            this.btnCreateSQLType.Click += new System.EventHandler(this.btnCreateSQLType_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(13, 12);
            this.txtFrom.Multiline = true;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrom.Size = new System.Drawing.Size(206, 434);
            this.txtFrom.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(342, 12);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTo.Size = new System.Drawing.Size(206, 434);
            this.txtTo.TabIndex = 4;
            // 
            // btnCreateDbLink
            // 
            this.btnCreateDbLink.Location = new System.Drawing.Point(225, 94);
            this.btnCreateDbLink.Name = "btnCreateDbLink";
            this.btnCreateDbLink.Size = new System.Drawing.Size(111, 36);
            this.btnCreateDbLink.TabIndex = 5;
            this.btnCreateDbLink.Text = "DBLink格式=>";
            this.btnCreateDbLink.UseVisualStyleBackColor = true;
            this.btnCreateDbLink.Click += new System.EventHandler(this.btnCreateDbLink_Click);
            // 
            // btnCreateToUpper
            // 
            this.btnCreateToUpper.Location = new System.Drawing.Point(225, 136);
            this.btnCreateToUpper.Name = "btnCreateToUpper";
            this.btnCreateToUpper.Size = new System.Drawing.Size(111, 36);
            this.btnCreateToUpper.TabIndex = 6;
            this.btnCreateToUpper.Text = "大写=>";
            this.btnCreateToUpper.UseVisualStyleBackColor = true;
            this.btnCreateToUpper.Click += new System.EventHandler(this.btnCreateToUpper_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(225, 178);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(111, 36);
            this.btnArrange.TabIndex = 7;
            this.btnArrange.Text = "整理=>";
            this.btnArrange.UseVisualStyleBackColor = true;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ping=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreateNumSQL
            // 
            this.btnCreateNumSQL.Location = new System.Drawing.Point(225, 262);
            this.btnCreateNumSQL.Name = "btnCreateNumSQL";
            this.btnCreateNumSQL.Size = new System.Drawing.Size(111, 36);
            this.btnCreateNumSQL.TabIndex = 10;
            this.btnCreateNumSQL.Text = "数字生成SQL";
            this.btnCreateNumSQL.UseVisualStyleBackColor = true;
            this.btnCreateNumSQL.Click += new System.EventHandler(this.btnCreateNumSQL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.btnCreateNumSQL);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.btnCreateToUpper);
            this.Controls.Add(this.btnCreateDbLink);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnCreateSQLType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "编程小帮手";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateSQLType;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnCreateDbLink;
        private System.Windows.Forms.Button btnCreateToUpper;
        private System.Windows.Forms.Button btnArrange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateNumSQL;
    }
}

