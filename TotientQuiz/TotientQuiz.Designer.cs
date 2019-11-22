namespace TotQuiz
{
    partial class TotientQuiz
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.rankLabel = new System.Windows.Forms.Label();
            this.joinerLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.problemNumLabel = new System.Windows.Forms.Label();
            this.nowNumOfProblem = new System.Windows.Forms.NumericUpDown();
            this.returnButton = new System.Windows.Forms.Button();
            this.yokokuLabel = new System.Windows.Forms.Label();
            this.yokokuLabel2 = new System.Windows.Forms.Label();
            this.yokokuBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nowNumOfProblem)).BeginInit();
            this.SuspendLayout();
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rankLabel.Location = new System.Drawing.Point(104, 6);
            this.rankLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(79, 33);
            this.rankLabel.TabIndex = 0;
            this.rankLabel.Text = "順位";
            // 
            // joinerLabel
            // 
            this.joinerLabel.AutoSize = true;
            this.joinerLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.joinerLabel.Location = new System.Drawing.Point(250, 6);
            this.joinerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.joinerLabel.Name = "joinerLabel";
            this.joinerLabel.Size = new System.Drawing.Size(111, 33);
            this.joinerLabel.TabIndex = 1;
            this.joinerLabel.Text = "参加者";
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pointLabel.Location = new System.Drawing.Point(422, 6);
            this.pointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(111, 33);
            this.pointLabel.TabIndex = 2;
            this.pointLabel.Text = "ポイント";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rightLabel.Location = new System.Drawing.Point(602, 6);
            this.rightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(79, 33);
            this.rightLabel.TabIndex = 3;
            this.rightLabel.Text = "正解";
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.wrongLabel.Location = new System.Drawing.Point(785, 6);
            this.wrongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(111, 33);
            this.wrongLabel.TabIndex = 4;
            this.wrongLabel.Text = "不正解";
            // 
            // problemNumLabel
            // 
            this.problemNumLabel.AutoSize = true;
            this.problemNumLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.problemNumLabel.Location = new System.Drawing.Point(106, 422);
            this.problemNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.problemNumLabel.Name = "problemNumLabel";
            this.problemNumLabel.Size = new System.Drawing.Size(79, 33);
            this.problemNumLabel.TabIndex = 5;
            this.problemNumLabel.Text = "問目";
            // 
            // nowNumOfProblem
            // 
            this.nowNumOfProblem.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nowNumOfProblem.Location = new System.Drawing.Point(33, 421);
            this.nowNumOfProblem.Margin = new System.Windows.Forms.Padding(2);
            this.nowNumOfProblem.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.nowNumOfProblem.Name = "nowNumOfProblem";
            this.nowNumOfProblem.Size = new System.Drawing.Size(65, 39);
            this.nowNumOfProblem.TabIndex = 6;
            this.nowNumOfProblem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nowNumOfProblem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nowNumOfProblem.ValueChanged += new System.EventHandler(this.nowNumOfProblem_ValueChanged);
            // 
            // returnButton
            // 
            this.returnButton.AutoSize = true;
            this.returnButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.returnButton.Location = new System.Drawing.Point(659, 422);
            this.returnButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(81, 44);
            this.returnButton.TabIndex = 42;
            this.returnButton.Text = "戻る";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // yokokuLabel
            // 
            this.yokokuLabel.AutoSize = true;
            this.yokokuLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yokokuLabel.Location = new System.Drawing.Point(217, 445);
            this.yokokuLabel.Name = "yokokuLabel";
            this.yokokuLabel.Size = new System.Drawing.Size(207, 33);
            this.yokokuLabel.TabIndex = 55;
            this.yokokuLabel.Text = "次に正解すると";
            // 
            // yokokuLabel2
            // 
            this.yokokuLabel2.AutoSize = true;
            this.yokokuLabel2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yokokuLabel2.Location = new System.Drawing.Point(542, 445);
            this.yokokuLabel2.Name = "yokokuLabel2";
            this.yokokuLabel2.Size = new System.Drawing.Size(79, 33);
            this.yokokuLabel2.TabIndex = 56;
            this.yokokuLabel2.Text = "点！";
            // 
            // yokokuBox
            // 
            this.yokokuBox.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yokokuBox.Location = new System.Drawing.Point(429, 436);
            this.yokokuBox.Margin = new System.Windows.Forms.Padding(2);
            this.yokokuBox.Name = "yokokuBox";
            this.yokokuBox.Size = new System.Drawing.Size(108, 47);
            this.yokokuBox.TabIndex = 57;
            this.yokokuBox.Text = "0";
            this.yokokuBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotientQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 487);
            this.Controls.Add(this.yokokuBox);
            this.Controls.Add(this.yokokuLabel2);
            this.Controls.Add(this.yokokuLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.nowNumOfProblem);
            this.Controls.Add(this.problemNumLabel);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.joinerLabel);
            this.Controls.Add(this.rankLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TotientQuiz";
            this.Text = "TotientQuiz";
            this.Load += new System.EventHandler(this.TotientQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nowNumOfProblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label joinerLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.Label problemNumLabel;
        private System.Windows.Forms.NumericUpDown nowNumOfProblem;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label yokokuLabel;
        private System.Windows.Forms.Label yokokuLabel2;
        private System.Windows.Forms.TextBox yokokuBox;
    }
}

