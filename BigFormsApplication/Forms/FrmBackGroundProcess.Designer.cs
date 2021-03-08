using System.ComponentModel;

namespace BigFormsApplication.Forms
{
    partial class FrmBackGroundProcess
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
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ButtonStart1Loop = new System.Windows.Forms.Button();
            this.ButtonCancelInfiniteLoop = new System.Windows.Forms.Button();
            this.TextBoxNumberSeconds = new System.Windows.Forms.TextBox();
            this.LabelErrorMsg = new System.Windows.Forms.Label();
            this.LabelStatusMsg = new System.Windows.Forms.Label();
            this.ButtonStartInfiniteLoop = new System.Windows.Forms.Button();
            this.ButtonVeranderKleur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStartLoopWithException = new System.Windows.Forms.Button();
            this.LabelPercentage = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGroundWorker_RunWorkerCompleted);
            // 
            // ButtonStart1Loop
            // 
            this.ButtonStart1Loop.Location = new System.Drawing.Point(361, 40);
            this.ButtonStart1Loop.Name = "ButtonStart1Loop";
            this.ButtonStart1Loop.Size = new System.Drawing.Size(192, 29);
            this.ButtonStart1Loop.TabIndex = 0;
            this.ButtonStart1Loop.Text = "Start 1 loop";
            this.ButtonStart1Loop.UseVisualStyleBackColor = true;
            this.ButtonStart1Loop.Click += new System.EventHandler(this.ButtonStart1Loop_Click);
            // 
            // ButtonCancelInfiniteLoop
            // 
            this.ButtonCancelInfiniteLoop.Location = new System.Drawing.Point(692, 98);
            this.ButtonCancelInfiniteLoop.Name = "ButtonCancelInfiniteLoop";
            this.ButtonCancelInfiniteLoop.Size = new System.Drawing.Size(314, 29);
            this.ButtonCancelInfiniteLoop.TabIndex = 0;
            this.ButtonCancelInfiniteLoop.Text = "Cancel oneindige loop";
            this.ButtonCancelInfiniteLoop.UseVisualStyleBackColor = true;
            this.ButtonCancelInfiniteLoop.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextBoxNumberSeconds
            // 
            this.TextBoxNumberSeconds.Location = new System.Drawing.Point(47, 81);
            this.TextBoxNumberSeconds.Name = "TextBoxNumberSeconds";
            this.TextBoxNumberSeconds.Size = new System.Drawing.Size(218, 27);
            this.TextBoxNumberSeconds.TabIndex = 1;
            // 
            // LabelErrorMsg
            // 
            this.LabelErrorMsg.AutoSize = true;
            this.LabelErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorMsg.Location = new System.Drawing.Point(47, 417);
            this.LabelErrorMsg.Name = "LabelErrorMsg";
            this.LabelErrorMsg.Size = new System.Drawing.Size(94, 15);
            this.LabelErrorMsg.TabIndex = 2;
            this.LabelErrorMsg.Text = "Error boodschap";
            // 
            // LabelStatusMsg
            // 
            this.LabelStatusMsg.AutoSize = true;
            this.LabelStatusMsg.ForeColor = System.Drawing.Color.Blue;
            this.LabelStatusMsg.Location = new System.Drawing.Point(47, 459);
            this.LabelStatusMsg.Name = "LabelStatusMsg";
            this.LabelStatusMsg.Size = new System.Drawing.Size(88, 15);
            this.LabelStatusMsg.TabIndex = 2;
            this.LabelStatusMsg.Text = "Status Message";
            // 
            // ButtonStartInfiniteLoop
            // 
            this.ButtonStartInfiniteLoop.Location = new System.Drawing.Point(361, 98);
            this.ButtonStartInfiniteLoop.Name = "ButtonStartInfiniteLoop";
            this.ButtonStartInfiniteLoop.Size = new System.Drawing.Size(192, 29);
            this.ButtonStartInfiniteLoop.TabIndex = 0;
            this.ButtonStartInfiniteLoop.Text = "Start oneindige loop";
            this.ButtonStartInfiniteLoop.UseVisualStyleBackColor = true;
            this.ButtonStartInfiniteLoop.Click += new System.EventHandler(this.ButtonStartInfiniteLoop_Click);
            // 
            // ButtonVeranderKleur
            // 
            this.ButtonVeranderKleur.Location = new System.Drawing.Point(361, 238);
            this.ButtonVeranderKleur.Name = "ButtonVeranderKleur";
            this.ButtonVeranderKleur.Size = new System.Drawing.Size(251, 29);
            this.ButtonVeranderKleur.TabIndex = 0;
            this.ButtonVeranderKleur.Text = "Verander kleur";
            this.ButtonVeranderKleur.UseVisualStyleBackColor = true;
            this.ButtonVeranderKleur.Click += new System.EventHandler(this.ButtonVeranderKleur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aantal seconden 1 loop";
            // 
            // ButtonStartLoopWithException
            // 
            this.ButtonStartLoopWithException.Location = new System.Drawing.Point(361, 163);
            this.ButtonStartLoopWithException.Name = "ButtonStartLoopWithException";
            this.ButtonStartLoopWithException.Size = new System.Drawing.Size(192, 29);
            this.ButtonStartLoopWithException.TabIndex = 0;
            this.ButtonStartLoopWithException.Text = "Start loop met exception";
            this.ButtonStartLoopWithException.UseVisualStyleBackColor = true;
            this.ButtonStartLoopWithException.Click += new System.EventHandler(this.ButtonStartLoopWithException_Click);
            // 
            // LabelPercentage
            // 
            this.LabelPercentage.AutoSize = true;
            this.LabelPercentage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPercentage.ForeColor = System.Drawing.Color.Blue;
            this.LabelPercentage.Location = new System.Drawing.Point(47, 341);
            this.LabelPercentage.Name = "LabelPercentage";
            this.LabelPercentage.Size = new System.Drawing.Size(116, 30);
            this.LabelPercentage.TabIndex = 2;
            this.LabelPercentage.Text = "Percentage";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(47, 290);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(692, 29);
            this.ProgressBar.TabIndex = 3;
            // 
            // FrmBackGroundProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.LabelPercentage);
            this.Controls.Add(this.LabelStatusMsg);
            this.Controls.Add(this.LabelErrorMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxNumberSeconds);
            this.Controls.Add(this.ButtonCancelInfiniteLoop);
            this.Controls.Add(this.ButtonVeranderKleur);
            this.Controls.Add(this.ButtonStartLoopWithException);
            this.Controls.Add(this.ButtonStartInfiniteLoop);
            this.Controls.Add(this.ButtonStart1Loop);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmBackGroundProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achtergrond proces";
            this.Load += new System.EventHandler(this.FrmBackGroundProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Onderstaande code is handmatig toegevoegd in designer.cs:
        private BackgroundWorker backgroundWorker; // lukt niet via designer zelf
        private System.Windows.Forms.Button ButtonStart1Loop;
        private System.Windows.Forms.Button ButtonCancelInfiniteLoop;
        private System.Windows.Forms.TextBox TextBoxNumberSeconds;
        private System.Windows.Forms.Label LabelErrorMsg;
        private System.Windows.Forms.Label LabelStatusMsg;
        private System.Windows.Forms.Button ButtonStartInfiniteLoop;
        private System.Windows.Forms.Button ButtonVeranderKleur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStartLoopWithException;
        private System.Windows.Forms.Label LabelPercentage;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}