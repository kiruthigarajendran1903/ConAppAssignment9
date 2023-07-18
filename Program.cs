using ConAppAssignment9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name;
                string email;
                string password;
                Console.WriteLine("Enter the name ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the email");
                email = Console.ReadLine();
                Console.WriteLine("Enter the password");
                password = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    throw new ValidationException("Name is required.");
                }

                else if (string.IsNullOrEmpty(email))
                {
                    throw new ValidationException("Email is required.");
                }

                else if (string.IsNullOrEmpty(password))
                {
                    throw new ValidationException("Password is required.");
                }

                else if (name.Length < 6)
                {
                    throw new ValidationException("Name must have at least 6 characters.");
                }

                else if (password.Length < 8)
                {
                    throw new ValidationException("Password must have at least 8 characters.");
                }
                else
                {
                    Console.WriteLine("\nLogin Successfully!!!");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine($"Name:\t\t{name}\nEmail:\t\t{email}\nPassword:\t{password}");
                }
            }
            catch (ValidationException ce)
            {
                Console.WriteLine("ValidationException Error!!!" + ce.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Fomat Error!!!"+fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            
            finally
            {
                Console.WriteLine("\nEnd of the program");
            }
        }
    }
}

