namespace TestProject1_nunit.Framework.Framework_GenericUtility
{
    internal class C_Utility
    {
        public int Randnum()
        {
            Random rd = new Random();
            int randvals = rd.Next(500);
            Console.WriteLine(randvals);
            return randvals;
        }
        public string ForSystemDataandTime()
        {
            DateTime datetime = DateTime.Now;

            return datetime.ToString("dd MM yyyy hh mm ss");
        }
    }
}
