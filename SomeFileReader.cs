using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GRHWLibrary
{
    public class SomeFileReader : ISomeFileReader
    {
        private string _filePath;

        public SomeFileReader(string filePath)
        {
            _filePath = filePath;

        }

        public string[] OpenFile()
        {
            string[] result;
            try
            {
                result = File.ReadAllLines(_filePath);
            }
            // catch and log exception and return generic error message
            catch (ArgumentException)
            {
                throw;
            }
            catch (PathTooLongException)
            {
                throw;
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (UnauthorizedAccessException)
            {
                throw;
            }
            catch (NotSupportedException)
            {
                throw;
            }
            catch (SecurityException)
            {
                throw;
            }
            return result;
        }
    }
}
