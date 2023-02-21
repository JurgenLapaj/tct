// See https://aka.ms/new-console-template for more information
using c_sharp_._net;

Console.WriteLine("Hello, World!");



funksioni_me_array_me_lista instanca = new funksioni_me_array_me_lista();



Console.WriteLine("Ju lutem jepni nje array me int :");

int n;
Console.WriteLine("Sa doni te jete madhesia e array?");

 n = Convert.ToInt32(Console.ReadLine());

int[] array= new int[n]; 


// kemi array te mbushue me element
for (int i = 0;i < n; i++)
{
    Console.WriteLine("Jepni elementin ne pozicionin: " + i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}


int shuma = instanca.GjejShumenEArray(array);
int meIMadhi = instanca.GjejMeTeMadhin(array);
List<int> shumaCift = instanca.GjejShumenENumrvaCift(array);  




Console.WriteLine("Shuma: " + shuma);
Console.WriteLine("Me i madhi:" + meIMadhi);
Console.WriteLine("Shuma Cift: " + shumaCift);





List<int> listaMeInterger = new List<int>();











IEnumerable<int> ints= new List<int>();



foreach(int i in shumaCift)
{
    Console.WriteLine();
}



Person p = new Person();

p.Age = 10;
p.Name = "Jurgen";
p.Surname = "Lapaj";
p.Address = "Rruga e kavajes";
p.City = "Tirana";
p.phones = "0683314888";






