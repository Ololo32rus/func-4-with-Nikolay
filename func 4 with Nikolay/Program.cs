// Рост каждого из 22 учеников класса представлен в виде массиваю Определить количество учеников, рост которых не привышает значения r.
static int Stud (int[] rostStudent, int rost)
{ 
   int Count = 0; int countStudent = 0; 
do
    {
        Console.WriteLine("Введите рост учеников: ");
        rostStudent[Count] = Convert.ToInt32(Console.ReadLine());

        if (rostStudent[Count] < rost)
         {
         countStudent++;
         }
        Count++;
    } while (Count < 5);
   
    return countStudent;
}


int[] rostStudent = new int[5];
Console.WriteLine("Введите рост средний: ");
int rost = int.Parse(Console.ReadLine());

int countStudent = Stud(rostStudent, rost);

Console.WriteLine($" Колитчество учиников с ростом {rost} не привышает количества - {countStudent}");
