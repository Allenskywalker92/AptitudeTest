namespace JohnTheRobot
{
    class Humanoid
    {
        public Skill Skill { get; set; }
        public Humanoid()
        {
        }

        public Humanoid(Skill skill)
        {
            Skill = skill;
        }

        public string ShowSkill()
        {
            if (Skill==null)
            {
                return "no skill is defined";
            }

            return Skill.SkillName;
        }
    }
}
