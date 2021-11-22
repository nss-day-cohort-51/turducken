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
            int bank = 100;
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
                    // Console.WriteLine($"Name: {name.Name} Skill Level: {name.SkillLevel} Courage Factor: {name.CourageFactor}");

                    int sumSkillLevels = name.SkillLevel + name.SkillLevel;


                    if (sumSkillLevels >= bank)
                    {
                        Console.WriteLine("Successfull Heist");
                    }

                    else { Console.WriteLine("Not enough Skill level for Successful Heist"); }

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