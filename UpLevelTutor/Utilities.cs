namespace MyNamespace
{
    public static class Utilities
    {
        public static async Task ShowConsoleAnimation()
        {
            for (int i = 0; i < 10; i++)
            {
                foreach (string s in new[] { "| -", "/ \\", "- |", "\\ /", })
                {
                    Console.Write(s);
                    await Task.Delay(100);
                    Console.Write("\b\b\b");
                }
            }
            Console.WriteLine();
        }
        public static string GetRandomAnswer()
        {
            string[] answers =
            {
            "Это точно.",                       "Ответ туманный, попробуйте еще раз.",      "Не рассчитывайте на это.",
            "Это решительно так.",              "Спроси позже.",                            "Мой ответ - нет.",
            "Без сомнения.",                    "Лучше не говорить тебе сейчас.",                 "Мои источники говорят, что нет.",
            "Определенно да.",                  "Не могу предсказать сейчас.",              "Перспективы не очень.",
            "Вы можете положиться на него.",    "Сконцентрируйтесь и спросите снова.",      "Очень сомнительно.",
            "Как я вижу, да.",
            "Более вероятно.",
            "Перспектива хорошая.",
            "Да.",
            "Знаки указывают на да.",
            };

            var index = new Random().Next(answers.Length - 1);

            return answers[index];
        }
        public static void ShowArgs(string[] args)
        {
            foreach (var s in args)
            {
                Console.Write(s);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }


}