input :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilangan_prima
{
class Program
{
static void Main(string[] args)
{
int bil, ulang, sisa, jumlahbilangan;
string ket;

Console.Write(“Input integer=”);
bil = Convert.ToInt16(Console.ReadLine());
jumlahbilangan=0;
for (ulang = 1; ulang <= bil; ulang++)
{
sisa = bil % ulang;
if (sisa == 0)
jumlahbilangan = jumlahbilangan + 1;
else
jumlahbilangan = jumlahbilangan ;
}
if (jumlahbilangan > 2)
ket = “Not prime number”;
else
ket = “Prime number”;
Console.WriteLine(“The number entered = ” + ket);
Console.ReadKey();

	}
  }
}