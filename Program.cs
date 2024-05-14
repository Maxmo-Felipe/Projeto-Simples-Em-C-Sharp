Console.WriteLine("#######- Jogo Matématica - ####### \n");

Console.WriteLine("Quanto é 2 + 3: ");
int pergunta_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quanto é 10 / 2: ");
int pergunta_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quanto é 20 * 2: ");
int pergunta_3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quanto é 10 - 5: ");
int pergunta_4 = Convert.ToInt32(Console.ReadLine());

if((pergunta_1 == 5) && (pergunta_2 == 5) && (pergunta_3 == 40) && (pergunta_4 == 5)){
    Console.WriteLine("####PARABÉNS####Você acertou todas e fez 4 Pontos!");
}else if((pergunta_1 != 5) && (pergunta_2 == 5) && (pergunta_3 == 40) && (pergunta_4 == 5)){
    Console.WriteLine("Você acertou 3 perguntas e fez 3 Pontos");
}
