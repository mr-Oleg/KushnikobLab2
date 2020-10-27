using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KushnikovLab2
{
    public partial class Form1 : Form
    {

        private Regex regex;
        private DataWrapperForDistibution wrapper;
        private long number;
        private const string PTTRN = "[0 - 9]";

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            regex = new Regex(PTTRN);
            wrapper = DataWrapperForDistibution.getInstance();
        }

        private bool isValidInput()
        {
            return textBox1.Text != null && regex.IsMatch(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e) //perform
        {
            if (isValidInput())
            {
                number = Convert.ToInt64(textBox1.Text);
                CalculationBehavior alg = AlgoFactory.getImplementation(comboBox1.Text);
                for (int iteration = 0; iteration < number; iteration++)
                {
                    wrapper.addValue(alg.calculate());
                }
                GraphVisualizer newForm = new GraphVisualizer();
                newForm.setTitle(comboBox1.Text);
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid params");
            }
        }
    }
}
