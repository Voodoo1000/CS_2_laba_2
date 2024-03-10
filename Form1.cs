namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtSequence.Text = Properties.Settings.Default.sequenceNum.ToString();
            txtCount.Text = Properties.Settings.Default.countNum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.txtSequence.Text;
            int n;

            try
            {
                n = int.Parse(this.txtCount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.sequenceNum = input;
            Properties.Settings.Default.countNum = n;
            Properties.Settings.Default.Save();

            MessageBox.Show(Logic.IndexesNum(input, n));
        }
    }

    public class Logic
    {
        public static string IndexesNum(string input, int n)
        {
            string[] numbers = input.Split(' ');
            int[] sequence = new int[numbers.Length];



            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbers[i], out sequence[i]))
                {
                    return "������������ ���� �����.";
                }
            }

            int index = -1;

            for (int i = 0; i < sequence.Length - n + 1; i++)
            {
                bool hasEqualAdjacent = true;

                for (int j = 1; j < n; j++)
                {
                    if (sequence[i + j] != sequence[i])
                    {
                        hasEqualAdjacent = false;
                        break;
                    }
                }

                if (hasEqualAdjacent)
                {
                    index = i + 1;
                    break;
                }
            }

            if (index != -1)
            {
                return $"������ n-�� ���������� �������� ����� ��������� �� �������� {index} � {index + 1}.";
            }
            else
            {
                return "� ������������������ ��� n-�� ���������� �������� �����.";
            }
        }
    }
}
