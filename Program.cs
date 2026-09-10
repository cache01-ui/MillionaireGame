using System;
using System.Text;

class Question
{
    public string Text { get; set; }
    public string[] Options { get; set; }
    public int CorrectOptionIndex { get; set; } // 1, 2, 3 або 4

    public Question(string text, string[] options, int correctOptionIndex)
    {
        Text = text;
        Options = options;
        CorrectOptionIndex = correctOptionIndex;
    }
}

class Program
{
    static void Main()
    {
        // Налаштування коректного відображення української мови в консолі
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Question[] questions = new Question[]
        {
            new Question(
                "Питання 1: Який метал є єдиним, що перебуває в рідкому стані за кімнатної температури?",
                new string[] { "Свинець", "Ртуть", "Галій", "Цезій" },
                2
            ),
            new Question(
                "Питання 2: Який птах є єдиним у світі, здатним літати хвостом уперед?",
                new string[] { "Колібрі", "Ластівка", "Стриж", "Зимородок" },
                1
            ),
            new Question(
                "Питання 3: Скільки сердець має звичайний восьминіг?",
                new string[] { "1", "2", "3", "4" },
                3
            ),
            new Question(
                "Питання 4: Яка пустеля на Землі є найбільшою за площею?",
                new string[] { "Сахара", "Гобі", "Аравійська", "Антарктична" },
                4
            ),
            new Question(
                "Питання 5: Яка шахова фігура, окрім пішака, не може рухатися назад?",
                new string[] { "Кінь", "Слон", "Тура", "Жодна (тільки пішак)" },
                4
            )
        };

        int score = 0;
        int pointsPerQuestion = 100;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine(questions[i].Text);

            for (int j = 0; j < questions[i].Options.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {questions[i].Options[j]}");
            }

            Console.Write("Ваша відповідь (1-4): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userChoice) && userChoice == questions[i].CorrectOptionIndex)
            {
                score += pointsPerQuestion;
                Console.WriteLine("Correct answer\n");
            }
            else
            {
                Console.WriteLine("Wrong Answer");
                Console.WriteLine("Кінець програми.");
                return;
            }
        }

        Console.WriteLine($"Вітаємо! Ви правильно відповіли на всі питання! Підсумковий рахунок: {score}");
    }
}