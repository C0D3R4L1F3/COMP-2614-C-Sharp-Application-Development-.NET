using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP2614Assign03
{
    /// <summary>
    /// Runs the methods if valid args are passed
    /// </summary>
    class Program
    {
        private const int NUMBER_OF_ARGS = 0;
        private const int DATA = 0;

        /// <summary>
        /// Drives the program
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            string path = string.Empty;
            string lineData;

            if (args.Length > NUMBER_OF_ARGS)
            {
                path = args[NUMBER_OF_ARGS];
            }
            else
            {
                Console.WriteLine($"Usage: COMP2614Assign03 invoicedata.txt");
                return;
            }

            if (File.Exists(path))
            {
                try
                {
                    streamReader = new StreamReader(path);
                    InvoiceReader invoiceReader = new InvoiceReader();

                    while (streamReader.Peek() > DATA)
                    {
                        lineData = streamReader.ReadLine();
                        invoiceReader.ReadLineData(lineData);
                    }
                    ConsolePrinter print = new ConsolePrinter();

                    print.PrintInvoices(invoiceReader.Invoices.ToArray());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                }
                finally
                {
                    if (streamReader != null)
                    {
                        streamReader.Close();
                    }
                }
            }
            else
            {
                Console.WriteLine("\nFile not found.\n");
            }
        }
    }
}