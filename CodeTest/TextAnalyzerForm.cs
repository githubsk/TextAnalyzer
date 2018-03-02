using System;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public partial class TextAnalyzerForm : Form
    {

        public TextAnalyzerForm()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            ITextAnalyzer analyzer = new TextAnalyzer(txtToAnalyze.Text);

            lblCharCount.Text = analyzer.CharacterCount.ToString();
            lblVowelCount.Text = analyzer.VowelCount.ToString();
            lblConsonantCount.Text = analyzer.ConsonantCount.ToString();
            lblFrequencyOfThe.Text = analyzer.FrequencyOfThe.ToString();
            txtVowelSequence.Text = analyzer.FilterNonVowels();
        }
    }
}