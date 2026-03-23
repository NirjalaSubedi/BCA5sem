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
    }
}