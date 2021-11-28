
namespace NameThatTune
{
    partial class TriviaRound
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.chkboxAnswers = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTurn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuestion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNextQuestion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkboxAnswers, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.49353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.99261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.36599F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.832662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNextQuestion.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnNextQuestion.Location = new System.Drawing.Point(3, 502);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(757, 36);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Blue;
            this.lblTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTurn.Font = new System.Drawing.Font("Impact", 24F);
            this.lblTurn.Location = new System.Drawing.Point(3, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(757, 67);
            this.lblTurn.TabIndex = 3;
            this.lblTurn.Text = "{Player 1}\'s Turn";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.lblQuestion.Location = new System.Drawing.Point(3, 67);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(757, 73);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "{Question 1:}";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkboxAnswers
            // 
            this.chkboxAnswers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkboxAnswers.Font = new System.Drawing.Font("Palatino Linotype", 11.75F);
            this.chkboxAnswers.FormattingEnabled = true;
            this.chkboxAnswers.Items.AddRange(new object[] {
            "Answer1",
            "Answer2",
            "Answer3",
            "Answer4"});
            this.chkboxAnswers.Location = new System.Drawing.Point(321, 381);
            this.chkboxAnswers.Name = "chkboxAnswers";
            this.chkboxAnswers.Size = new System.Drawing.Size(120, 100);
            this.chkboxAnswers.TabIndex = 5;
            // 
            // TriviaRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TriviaRound";
            this.Text = "TriviaRound";
            this.Load += new System.EventHandler(this.TriviaRound_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.CheckedListBox chkboxAnswers;
    }
}