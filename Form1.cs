namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.txtSequence.Text;
            int n = int.Parse(this.txtCount.Text);

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
                    return "Некорректный ввод чисел.";
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
                return $"Первая n-ка одинаковых соседних чисел находятся на позициях {index} и {index + 1}.";
            }
            else
            {
                return "В последовательности нет n-ки одинаковых соседних чисел.";
            }
        }
    }
}
