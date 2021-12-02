
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
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Choice1 = new System.Windows.Forms.Button();
            this.Btn_Choice2 = new System.Windows.Forms.Button();
            this.Btn_Choice3 = new System.Windows.Forms.Button();
            this.Btn_Choice4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.49353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.36494F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.18247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.832662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Blue;
            this.lblTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTurn.Font = new System.Drawing.Font("Impact", 24F);
            this.lblTurn.Location = new System.Drawing.Point(3, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(757, 69);
            this.lblTurn.TabIndex = 3;
            this.lblTurn.Text = "{Player 1}\'s Turn";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(3, 69);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(757, 75);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "{Question 1:}";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNextQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNextQuestion.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnNextQuestion.Location = new System.Drawing.Point(3, 520);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(757, 36);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.Btn_Choice1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Choice2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Choice3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Choice4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 395);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(757, 118);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Btn_Choice1
            // 
            this.Btn_Choice1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_Choice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Choice1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Choice1.Location = new System.Drawing.Point(5, 5);
            this.Btn_Choice1.Name = "Btn_Choice1";
            this.Btn_Choice1.Size = new System.Drawing.Size(751, 21);
            this.Btn_Choice1.TabIndex = 0;
            this.Btn_Choice1.UseVisualStyleBackColor = false;
            this.Btn_Choice1.BackColorChanged += new System.EventHandler(this.Btn_Choice1_BackColorChanged);
            this.Btn_Choice1.Click += new System.EventHandler(this.Btn_Choice1_Click);
            // 
            // Btn_Choice2
            // 
            this.Btn_Choice2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_Choice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Choice2.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Choice2.Location = new System.Drawing.Point(5, 34);
            this.Btn_Choice2.Name = "Btn_Choice2";
            this.Btn_Choice2.Size = new System.Drawing.Size(751, 21);
            this.Btn_Choice2.TabIndex = 1;
            this.Btn_Choice2.UseVisualStyleBackColor = false;
            this.Btn_Choice2.Click += new System.EventHandler(this.Btn_Choice2_Click);
            // 
            // Btn_Choice3
            // 
            this.Btn_Choice3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_Choice3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Choice3.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Choice3.Location = new System.Drawing.Point(5, 63);
            this.Btn_Choice3.Name = "Btn_Choice3";
            this.Btn_Choice3.Size = new System.Drawing.Size(751, 21);
            this.Btn_Choice3.TabIndex = 2;
            this.Btn_Choice3.UseVisualStyleBackColor = false;
            this.Btn_Choice3.Click += new System.EventHandler(this.Btn_Choice3_Click);
            // 
            // Btn_Choice4
            // 
            this.Btn_Choice4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Btn_Choice4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Choice4.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Choice4.Location = new System.Drawing.Point(5, 92);
            this.Btn_Choice4.Name = "Btn_Choice4";
            this.Btn_Choice4.Size = new System.Drawing.Size(751, 21);
            this.Btn_Choice4.TabIndex = 3;
            this.Btn_Choice4.UseVisualStyleBackColor = false;
            this.Btn_Choice4.Click += new System.EventHandler(this.Btn_Choice4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_Choice1;
        private System.Windows.Forms.Button Btn_Choice2;
        private System.Windows.Forms.Button Btn_Choice3;
        private System.Windows.Forms.Button Btn_Choice4;
    }
}