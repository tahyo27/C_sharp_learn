namespace CleanCodeExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void ReadFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Access denied: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }



            //File Not Found
            // Unauthorized Access
            // Any Other Exception

        }
    }
}