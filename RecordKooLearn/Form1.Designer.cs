namespace RecordKooLearn
{
    partial class FormMainWindow
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
            this.components = new System.ComponentModel.Container();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.textBoxCurrentURL = new System.Windows.Forms.TextBox();
            this.labelNextUrl = new System.Windows.Forms.Label();
            this.textBoxNextURL = new System.Windows.Forms.TextBox();
            this.textBoxTimeDur = new System.Windows.Forms.TextBox();
            this.labelTimeDuration = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonBeginRecord = new System.Windows.Forms.Button();
            this.buttonStopRecord = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Location = new System.Drawing.Point(33, 57);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(66, 13);
            this.labelCurrentPage.TabIndex = 0;
            this.labelCurrentPage.Text = "Current URL";
            // 
            // textBoxCurrentURL
            // 
            this.textBoxCurrentURL.Location = new System.Drawing.Point(123, 49);
            this.textBoxCurrentURL.Name = "textBoxCurrentURL";
            this.textBoxCurrentURL.Size = new System.Drawing.Size(484, 20);
            this.textBoxCurrentURL.TabIndex = 1;
            // 
            // labelNextUrl
            // 
            this.labelNextUrl.AutoSize = true;
            this.labelNextUrl.Location = new System.Drawing.Point(36, 145);
            this.labelNextUrl.Name = "labelNextUrl";
            this.labelNextUrl.Size = new System.Drawing.Size(45, 13);
            this.labelNextUrl.TabIndex = 2;
            this.labelNextUrl.Text = "Next Url";
            // 
            // textBoxNextURL
            // 
            this.textBoxNextURL.Location = new System.Drawing.Point(123, 138);
            this.textBoxNextURL.Name = "textBoxNextURL";
            this.textBoxNextURL.Size = new System.Drawing.Size(484, 20);
            this.textBoxNextURL.TabIndex = 3;
            // 
            // textBoxTimeDur
            // 
            this.textBoxTimeDur.Location = new System.Drawing.Point(123, 230);
            this.textBoxTimeDur.Name = "textBoxTimeDur";
            this.textBoxTimeDur.Size = new System.Drawing.Size(484, 20);
            this.textBoxTimeDur.TabIndex = 4;
            // 
            // labelTimeDuration
            // 
            this.labelTimeDuration.AutoSize = true;
            this.labelTimeDuration.Location = new System.Drawing.Point(36, 236);
            this.labelTimeDuration.Name = "labelTimeDuration";
            this.labelTimeDuration.Size = new System.Drawing.Size(73, 13);
            this.labelTimeDuration.TabIndex = 5;
            this.labelTimeDuration.Text = "Time Duration";
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(123, 333);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPage.TabIndex = 6;
            this.buttonNextPage.Text = "Next Page";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonBeginRecord
            // 
            this.buttonBeginRecord.Location = new System.Drawing.Point(273, 333);
            this.buttonBeginRecord.Name = "buttonBeginRecord";
            this.buttonBeginRecord.Size = new System.Drawing.Size(119, 23);
            this.buttonBeginRecord.TabIndex = 7;
            this.buttonBeginRecord.Text = "Begin Record";
            this.buttonBeginRecord.UseVisualStyleBackColor = true;
            this.buttonBeginRecord.Click += new System.EventHandler(this.buttonBeginRecord_Click);
            // 
            // buttonStopRecord
            // 
            this.buttonStopRecord.Location = new System.Drawing.Point(453, 333);
            this.buttonStopRecord.Name = "buttonStopRecord";
            this.buttonStopRecord.Size = new System.Drawing.Size(119, 23);
            this.buttonStopRecord.TabIndex = 8;
            this.buttonStopRecord.Text = "Stop Record";
            this.buttonStopRecord.UseVisualStyleBackColor = true;
            this.buttonStopRecord.Click += new System.EventHandler(this.buttonStopRecord_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(123, 95);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 9;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 434);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonStopRecord);
            this.Controls.Add(this.buttonBeginRecord);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.labelTimeDuration);
            this.Controls.Add(this.textBoxTimeDur);
            this.Controls.Add(this.textBoxNextURL);
            this.Controls.Add(this.labelNextUrl);
            this.Controls.Add(this.textBoxCurrentURL);
            this.Controls.Add(this.labelCurrentPage);
            this.Name = "FormMainWindow";
            this.Text = "FormMainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.TextBox textBoxCurrentURL;
        private System.Windows.Forms.Label labelNextUrl;
        private System.Windows.Forms.TextBox textBoxNextURL;
        private System.Windows.Forms.TextBox textBoxTimeDur;
        private System.Windows.Forms.Label labelTimeDuration;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonBeginRecord;
        private System.Windows.Forms.Button buttonStopRecord;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Timer timer1;
    }
}

