using System;

namespace PlanYourHeist
{
    class Bank
    {
        public int difficultyLevel { get; set; }
        public int luckValue { get; set; }

        public Bank()
        {
            difficultyLevel = 100;
        }

        public void LuckValue()
        {
            Random random = new Random();
            luckValue = random.Next(-10, 10);
            this.difficultyLevel += luckValue;
        }
    }
}