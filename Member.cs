using System;

namespace PlanYourHeist
{
    class Member
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public float CourageFactor { get; set; }

        public Member(string name, int skillLevel, float couragefactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = couragefactor;
        }

        public void Info()
        {
            Console.WriteLine($"{this.Name} has a skill level of {this.SkillLevel} and a courage factor of {this.CourageFactor}");
        }
    }
}