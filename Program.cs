using System;

namespace turducken
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist");
            Console.WriteLine("---------------");

            int MemberNum = 0;

            string MemberList = null;
            while (MemberList != "")
            {
                try
                {
                    Console.WriteLine("Enter Team Member Name");
                    string TeamMemberName = Console.ReadLine();

                    Console.WriteLine("Enter Team Member Skill Level");
                    int TeamMemberSkill = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Team Member Courage Factor");
                    double TeamMemberCourage = Convert.ToDouble(Console.ReadLine());

                    MemberNum++;
                    Console.WriteLine($"Member Count; {MemberNum}");

                    TeamMember name = new TeamMember
                    {
                        Name = TeamMemberName,
                        SkillLevel = TeamMemberSkill,
                        CourageFactor = TeamMemberCourage
                    };

                    Console.WriteLine($"Name: {name.Name} Skill Level: {name.SkillLevel} Courage Factor: {name.CourageFactor}");
                }
                catch (Exception)
                {
                    Console.WriteLine("No input provided");
                    return;
                }

            }

        }

    }

}
