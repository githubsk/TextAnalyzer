namespace TextAnalyzer
{
    partial class TextAnalyzerForm
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
            this.txtToAnalyze = new System.Windows.Forms.TextBox();
            this.lblTextToAnalyze = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblTotalVowels = new System.Windows.Forms.Label();
            this.lblTotalCharacters = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.lblVowelCount = new System.Windows.Forms.Label();
            this.lblTotalConsonants = new System.Windows.Forms.Label();
            this.lblConsonantCount = new System.Windows.Forms.Label();
            this.lblTotalThes = new System.Windows.Forms.Label();
            this.lblFrequencyOfThe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVowelSequence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtToAnalyze
            // 
            this.txtToAnalyze.Location = new System.Drawing.Point(15, 25);
            this.txtToAnalyze.Multiline = true;
            this.txtToAnalyze.Name = "txtToAnalyze";
            this.txtToAnalyze.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToAnalyze.Size = new System.Drawing.Size(470, 253);
            this.txtToAnalyze.TabIndex = 0;
            // 
            // lblTextToAnalyze
            // 
            this.lblTextToAnalyze.AutoSize = true;
            this.lblTextToAnalyze.Location = new System.Drawing.Point(12, 9);
            this.lblTextToAnalyze.Name = "lblTextToAnalyze";
            this.lblTextToAnalyze.Size = new System.Drawing.Size(83, 13);
            this.lblTextToAnalyze.TabIndex = 1;
            this.lblTextToAnalyze.Text = "Text to Analyze:";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(410, 284);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblTotalVowels
            // 
            this.lblTotalVowels.AutoSize = true;
            this.lblTotalVowels.Location = new System.Drawing.Point(12, 312);
            this.lblTotalVowels.Name = "lblTotalVowels";
            this.lblTotalVowels.Size = new System.Drawing.Size(71, 13);
            this.lblTotalVowels.TabIndex = 3;
            this.lblTotalVowels.Text = "Total Vowels:";
            // 
            // lblTotalCharacters
            // 
            this.lblTotalCharacters.AutoSize = true;
            this.lblTotalCharacters.Location = new System.Drawing.Point(12, 289);
            this.lblTotalCharacters.Name = "lblTotalCharacters";
            this.lblTotalCharacters.Size = new System.Drawing.Size(88, 13);
            this.lblTotalCharacters.TabIndex = 4;
            this.lblTotalCharacters.Text = "Total Characters:";
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(134, 290);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(0, 13);
            this.lblCharCount.TabIndex = 6;
            this.lblCharCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVowelCount
            // 
            this.lblVowelCount.AutoSize = true;
            this.lblVowelCount.Location = new System.Drawing.Point(134, 312);
            this.lblVowelCount.Name = "lblVowelCount";
            this.lblVowelCount.Size = new System.Drawing.Size(0, 13);
            this.lblVowelCount.TabIndex = 7;
            this.lblVowelCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalConsonants
            // 
            this.lblTotalConsonants.AutoSize = true;
            this.lblTotalConsonants.Location = new System.Drawing.Point(212, 289);
            this.lblTotalConsonants.Name = "lblTotalConsonants";
            this.lblTotalConsonants.Size = new System.Drawing.Size(93, 13);
            this.lblTotalConsonants.TabIndex = 8;
            this.lblTotalConsonants.Text = "Total Consonants:";
            // 
            // lblConsonantCount
            // 
            this.lblConsonantCount.AutoSize = true;
            this.lblConsonantCount.Location = new System.Drawing.Point(334, 289);
            this.lblConsonantCount.Name = "lblConsonantCount";
            this.lblConsonantCount.Size = new System.Drawing.Size(0, 13);
            this.lblConsonantCount.TabIndex = 9;
            this.lblConsonantCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalThes
            // 
            this.lblTotalThes.AutoSize = true;
            this.lblTotalThes.Location = new System.Drawing.Point(212, 312);
            this.lblTotalThes.Name = "lblTotalThes";
            this.lblTotalThes.Size = new System.Drawing.Size(71, 13);
            this.lblTotalThes.TabIndex = 10;
            this.lblTotalThes.Text = "Total \"The\"s:";
            // 
            // lblFrequencyOfThe
            // 
            this.lblFrequencyOfThe.AutoSize = true;
            this.lblFrequencyOfThe.Location = new System.Drawing.Point(334, 312);
            this.lblFrequencyOfThe.Name = "lblFrequencyOfThe";
            this.lblFrequencyOfThe.Size = new System.Drawing.Size(0, 13);
            this.lblFrequencyOfThe.TabIndex = 11;
            this.lblFrequencyOfThe.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vowels in Text:";
            // 
            // txtVowelSequence
            // 
            this.txtVowelSequence.Location = new System.Drawing.Point(15, 353);
            this.txtVowelSequence.Multiline = true;
            this.txtVowelSequence.Name = "txtVowelSequence";
            this.txtVowelSequence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVowelSequence.Size = new System.Drawing.Size(470, 142);
            this.txtVowelSequence.TabIndex = 13;
            // 
            // TextAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 512);
            this.Controls.Add(this.txtVowelSequence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFrequencyOfThe);
            this.Controls.Add(this.lblTotalThes);
            this.Controls.Add(this.lblConsonantCount);
            this.Controls.Add(this.lblTotalConsonants);
            this.Controls.Add(this.lblVowelCount);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.lblTotalCharacters);
            this.Controls.Add(this.lblTotalVowels);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.lblTextToAnalyze);
            this.Controls.Add(this.txtToAnalyze);
            this.Name = "TextAnalyzerForm";
            this.Text = "Text Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToAnalyze;
        private System.Windows.Forms.Label lblTextToAnalyze;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblTotalVowels;
        private System.Windows.Forms.Label lblTotalCharacters;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Label lblVowelCount;
        private System.Windows.Forms.Label lblTotalConsonants;
        private System.Windows.Forms.Label lblConsonantCount;
        private System.Windows.Forms.Label lblTotalThes;
        private System.Windows.Forms.Label lblFrequencyOfThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVowelSequence;

    }
}

