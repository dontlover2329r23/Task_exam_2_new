using MySqlConnector;

namespace Task_for_exam_2
{
    public partial class Form1 : Form
    {

        private Painter painter;

        public Form1()
        {
            InitializeComponent();
            painter = new Painter(mainPanel.CreateGraphics());
        }


        private void btn_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(num1.Text);
            double b = Convert.ToDouble(num2.Text);
            double c = Convert.ToDouble(num3.Text);

            painter.maxOX = Convert.ToDouble(val_maxOX.Text);
            painter.maxOY = Convert.ToDouble(val_maxOY.Text);
            painter.minOX = Convert.ToDouble(val_minOX.Text);
            painter.minOY = Convert.ToDouble(val_minOY.Text);
            painter.accuracy = (int)Convert.ToInt64(val_step.Text);
            painter.paint(a, b, c);
            Func<double, double> function = x => a * Math.Exp(b * x) + c * x;
            double result = Result.Integrate(function, Convert.ToDouble(val_minOX.Text), Convert.ToDouble(val_maxOX.Text), 0.0001,1000000,a,b,c);
            res.Text = result.ToString();

            // Save BLOB format in DataBase
            byte[] imageData = painter.SaveGraph();
            MySqlConnection connection = new MySqlConnection("Server = localhost; DataBase = mm_site2023; port = 3306; User Id = root; password =");

            // Create cmd
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request with parameters
            string query = "INSERT INTO Images (image) VALUES (@image)";
            cmd.Parameters.AddWithValue("@image", imageData);
            cmd.CommandText = query;

            // Open connection
            connection.Open();

            cmd.ExecuteNonQuery();

            // Close connection
            connection.Close();

        }
        // Создайте наборы цветов для светлой и тёмной темы
        Color lightBackColor = SystemColors.Control;
        Color lightForeColor = SystemColors.ControlText;
        Color darkBackColor = Color.FromArgb(64, 64, 64);
        Color darkForeColor = Color.White;

        // Создайте метод, который будет применять цветовую схему к вашему приложению
        private void ApplyColorScheme(Color backColor, Color foreColor)
        {
            // Измените цвет фона формы и цвет шрифта
            this.BackColor = backColor;
            this.ForeColor = foreColor;

            // Пройдитесь по всем элементам управления на форме и измените их цвета
            foreach (Control control in this.Controls)
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;

                if (control is Button)
                {
                    ((Button)control).FlatAppearance.BorderColor = foreColor;
                    ((Button)control).FlatAppearance.MouseOverBackColor = foreColor;
                    ((Button)control).FlatAppearance.MouseDownBackColor = foreColor;
                }
            }
        }


        private void darkTheme_Click(object sender, EventArgs e)
        {
            // Если кнопка была нажата первый раз, примените тёмную тему
            if (darkTheme.Tag == null || (bool)darkTheme.Tag == false)
            {
                ApplyColorScheme(darkBackColor, darkForeColor);
                darkTheme.Tag = true;
            }
            // Иначе, примените светлую тему
            else
            {
                ApplyColorScheme(lightBackColor, lightForeColor);
                darkTheme.Tag = false;
            }   
        }
    }
}