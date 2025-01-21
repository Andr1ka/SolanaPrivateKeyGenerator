using System;
using Solnet.Wallet;
using Solnet.Wallet.Bip39;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("count of private keys ");
        if (int.TryParse(Console.ReadLine(), out int numberOfKeys) && numberOfKeys > 0)
        {
            for (int i = 0; i < numberOfKeys; i++)
            {
                // Генерируем новую мнемоническую фразу
                var newMnemonic = new Mnemonic(WordList.English, WordCount.Twelve);

                // Инициализируем кошелек с использованием сгенерированной мнемонической фразы
                var wallet = new Wallet(newMnemonic);

                // Получаем приватный ключ
                var privateKey = wallet.Account.PrivateKey;

                Console.WriteLine(privateKey);
            }
        }
        else
        {
            Console.WriteLine("Некорректное количество. Пожалуйста, введите положительное целое число.");
        }
    }
}
