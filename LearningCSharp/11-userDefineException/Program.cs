using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_userDefineException
{
    internal class Program
    {
        public class VoteAppl
        {
            public void VoterRegister(int age)
            {
                if (age < 18)
                {
                    throw new AgeTooSmallException(); //for non-parameter error throws
                    //throw new AgeTooSmallException("Too Young!"); //for parameter error throws
                }
                Console.WriteLine("registered");
            }
        }
        static void Main(string[] args)
        {
            VoteAppl voterAppl = new VoteAppl();

            try
            {
                voterAppl.VoterRegister(2);
            }
            catch (AgeTooSmallException ageE)
            {
                Console.WriteLine("Custom Exception: " + ageE.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("General Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Thaks for registering");
            }
        }
    }
}
