using CustomException.Exceptions;

namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bug, error, exception, warning
            

            try
            {
                
                throw new StudentNotFoundException();
            }
            catch(StudentNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
