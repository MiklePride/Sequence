class program
{
    static void Main(string[] args)
    {
        int quantityLevels = 96;
        int periodOfBossLevel = 7;
        int numberFirstBossLevel =5;

        for(int i = numberFirstBossLevel; i <= quantityLevels; i+= periodOfBossLevel)
        {
            Console.WriteLine(i);
        }
    }
}
/*Для этой задачи я решил выбрать цикл for,
 * Он лучше всего подходит для этой задачи так-как,
 * Есть четкие границы: начало цикла, шаг цикла и конец цикла.
 */