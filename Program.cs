string time = "Palmeiras";
        ConsoleColor[] cores = { ConsoleColor.Green, ConsoleColor.White }; // Alternando entre verde e branco

        for (int i = 0; i < time.Length; i++)
        {
            Console.BackgroundColor = cores[i % cores.Length]; // Define a cor de fundo
            Console.ForegroundColor = cores[(i + 1) % cores.Length]; // Usa a outra cor para o texto
            Console.Write(time[i]); // Exibe a letra
        }
        Console.WriteLine("");
        Console.ResetColor();
        Console.WriteLine("Maior time do Brasil");


    