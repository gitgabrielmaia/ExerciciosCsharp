  Console.WriteLine("Escolha uma operação (+, -, *, /): ");
        string operacao = Console.ReadLine();

        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        switch (operacao)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Não é possível dividir por zero.");
                break;
            default:
                Console.WriteLine("Operação inválida.");
                return;
        }

        Console.WriteLine("O resultado é: " + resultado);
 