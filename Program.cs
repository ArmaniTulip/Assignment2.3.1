namespace Assignment2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                StreamWriter sw = new StreamWriter("D:\\MSSA-CCAD14\\BasicDetails.txt");
                sw.WriteLine("John Doe");
                sw.WriteLine("30");
                sw.WriteLine("123 That St. North Carolina, USA");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            String line;
            try
            {
                StreamReader sr = new StreamReader("D:\\MSSA-CCAD14\\BasicDetails.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
    
}
