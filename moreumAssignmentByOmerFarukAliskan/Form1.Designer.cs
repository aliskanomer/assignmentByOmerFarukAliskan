
namespace moreumAssignmentByOmerFarukAliskan
{
    partial class assignmentByOmerFarukAliskan
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerTxt = new System.Windows.Forms.Label();
            this.msgTxt = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerTxt
            // 
            this.headerTxt.AutoSize = true;
            this.headerTxt.Font = new System.Drawing.Font("Bahnschrift", 81.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTxt.ForeColor = System.Drawing.Color.Yellow;
            this.headerTxt.Location = new System.Drawing.Point(184, 9);
            this.headerTxt.Name = "headerTxt";
            this.headerTxt.Size = new System.Drawing.Size(339, 130);
            this.headerTxt.TabIndex = 0;
            this.headerTxt.Text = "Hello!";
            this.headerTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // msgTxt
            // 
            this.msgTxt.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.msgTxt.ForeColor = System.Drawing.Color.White;
            this.msgTxt.Location = new System.Drawing.Point(32, 152);
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(634, 243);
            this.msgTxt.TabIndex = 1;
            this.msgTxt.Text = "Please upload a CSV file to start.\r\n\r\nPlease be aware of that rows with more then" +
    " four semicolon\'s surplus data sets wil cause troubles!";
            this.msgTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.White;
            this.uploadBtn.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.uploadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.uploadBtn.Location = new System.Drawing.Point(193, 398);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(162, 56);
            this.uploadBtn.TabIndex = 2;
            this.uploadBtn.Text = "Upload CVS";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.BackColor = System.Drawing.Color.White;
            this.runBtn.Enabled = false;
            this.runBtn.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.runBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.runBtn.Location = new System.Drawing.Point(361, 398);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(162, 56);
            this.runBtn.TabIndex = 3;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = false;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designed,Developed and Created by Ömer Faruk ALIŞKAN for assignment given by More" +
    "um A.Ş.";
            // 
            // assignmentByOmerFarukAliskan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(685, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.msgTxt);
            this.Controls.Add(this.headerTxt);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "assignmentByOmerFarukAliskan";
            this.ShowIcon = false;
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerTxt;
        private System.Windows.Forms.Label msgTxt;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

