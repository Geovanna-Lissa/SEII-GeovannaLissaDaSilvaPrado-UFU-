using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSCourse2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arquivos = Directory.GetFIles(@"C:\");
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.ReadKey();
        }
    }
}
// Este COmando serve para saber quais arquivos existem num diretorio