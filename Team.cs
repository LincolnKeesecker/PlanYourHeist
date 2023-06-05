using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Team
    {
        public Dictionary<string, Member> Members { get; set; }

        public Team()
        {
            Members = new Dictionary<string, Member>();
        }

        public void Info()
        {
            Console.WriteLine($"This team has {this.Members.Count} members.");
        }

        public int skillLevel()
        {
            int totalSkill = 0;
            foreach (KeyValuePair<string, Member> pair in this.Members)
            {
                totalSkill += pair.Value.SkillLevel;
            }

            return totalSkill;
        }
    }
}