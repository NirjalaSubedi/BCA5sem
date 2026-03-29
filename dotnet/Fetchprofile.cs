using System.Text;
namespace fetchprofile
{
    class ResumeBuilder
    {
        public static void GenerateResume(string name, string skills)
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("==========================");
            sb.AppendLine("========Candidate==========");
            sb.AppendLine($"name:{name} skills: {skills}");
            Console.WriteLine(sb.ToString());
            

        }
        static void taketitle()
        {
            Console.WriteLine("Enter title:");
            String str=Console.ReadLine()??string.Empty;
            StringBuilder sb=new StringBuilder();
            bool wordStarted=true;
            foreach(Char c in str)
            {
                
            }

        }
    }
}