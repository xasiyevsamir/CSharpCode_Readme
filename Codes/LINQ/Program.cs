using LINQ.DAL;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqDbContext linqDbContext = new LinqDbContext();

            // LINQ Methodlar

            #region 1.Filtering(Süzgəc) metodları

            //  1.Filtering(Süzgəc) metodları
            //-----------------------------------------------------------------------------------

            // 1.1 Where(cond)   --> Verilmiş şərtə uyğun elementləri seçir
            // 1.2 Take(n) --> İlk n elementi götürür
            // 1.3 TakeLast(n) --> Sondan n elementi seçir (IEnumerable<T>)
            // 1.4 TakeWhile(cond)	 --> Şərt ödənənə qədər elementləri götürür
            // 1.5 Skip(n) --> İlk n elementi buraxır
            // 1.6 SkipLast(n) --> Sondan n elementi buraxır (IEnumerable<T>)
            // 1.7 SkipWhile(cond) --> Şərt ödənənə qədər buraxır, sonra seçir


            //1.1  Where(cond)
            //List<Group> group1= linqDbContext.Groups.Where(g=>g.Id>3).ToList();
            //foreach (var item in group1)
            //    Console.WriteLine(item);


            //1.2  Take(n)
            //List<Group> group2 = linqDbContext.Groups.Take(4).ToList();
            //foreach (var item in group2)
            //    Console.WriteLine(item);


            //1.3  TakeLast(n)
            //List<Group> group3 = linqDbContext.Groups.ToList().TakeLast(2).ToList(); //Yalnız Ram-da
            //foreach (var item in group3)
            //    Console.WriteLine(item);


            //1.4  TakeWhile(cond)
            //List<Group> group4 = linqDbContext.Groups.ToList().TakeWhile(g => g.Name.StartsWith("P")).ToList(); //Yalnız Ram-da
            //foreach (var item in group4)
            //    Console.WriteLine(item);



            //1.5  Skip(n)
            //List<Group> group5 = linqDbContext.Groups.Skip(3).ToList();
            //foreach (var item in group5)
            //    Console.WriteLine(item);



            //1.6  SkipLast(n)
            //List<Group> group6 = linqDbContext.Groups.ToList().SkipLast(4).ToList(); //Yalnız Ram-da
            //foreach (var item in group6)
            //    Console.WriteLine(item);



            //1.7  SkipWhile(cond)
            //List<Group> group7 = linqDbContext.Groups.ToList().SkipWhile(g => g.Name.StartsWith("P")).ToList(); //Yalnız Ram-da
            //foreach (var item in group7)
            //    Console.WriteLine(item);

            //-------------------------------------------------------------------------------------

            #endregion

            #region 2.Proyeksiya (Seçim) (Projection)

            //  2.Proyeksiya (Seçim) (Projection)
            //-----------------------------------------------------------------------------------

            // 2.1 Select()   --> Tək sütun və ya transformasiya seçir
            // 2.2 SelectMany() --> Nested kolleksiyanı düzləşdirir



            //2.1  Select()
            //var group1 = linqDbContext.Groups.Select(g => new { g.Id, g.Name }).ToList();
            //foreach (var item in group1)
            //    Console.WriteLine(item);

            //-------------------------------------------------------------------------------------
            #endregion

            #region 3.Joining

            //  3.Joining
            //-----------------------------------------------------------------------------------

            // 3.1 Join()   --> İki kolleksiyanı şərtə görə birləşdirir
            // 3.2 GroupJoin() --> İki kolleksiyanı birləşdirir, amma qruplaşdırılmış formada saxlayır
            // 3.3 Zip() --> Eyni indeksdəki elementləri birləşdirir

            //-------------------------------------------------------------------------------------

            #endregion

            #region 4.Ordering

            //  4.Ordering
            //-----------------------------------------------------------------------------------

            // 4.1 OrderBy()   --> Artan Sıralama (ASC)
            // 4.2 OrderByDescending() --> Azalan Sıralama (DESC)
            // 4.3 ThenBy() --> Artan Çoxsəviyyəli Sıralama
            // 4.4 ThenByDescending() --> Azalan Çoxsəviyyəli Sıralama
            // 4.5 Reverse() --> Mövcud sıralamanı tərsinə çevirir

            //-------------------------------------------------------------------------------------

            #endregion

            #region 5.Grouping

            //  5.Grouping
            //-----------------------------------------------------------------------------------

            // 5.1 GroupBy()   --> Verilən dəyərlər üzrə qruplaşdırma


            //-------------------------------------------------------------------------------------

            #endregion

            #region 6.Conversion

            //  6.Conversion
            //-----------------------------------------------------------------------------------

            // 6.1 ToArray()        --> Kolleksiyanı T[] tipində massivə çevirir
            // 6.2 ToList()         --> Kolleksiyanı List<T> tipinə çevirir
            // 6.3 ToDictionary()   --> Kolleksiyanı Dictionary<TKey, TValue> tipinə çevirir
            // 6.4 ToLookup()       --> Kolleksiyanı ILookup<TKey, TValue> tipinə çevirir
            // 6.5 AsEnumerable()   --> IQueryable<T>-i IEnumerable<T>-ə çevirir
            // 6.6 AsQueryable()    --> IEnumerable<T>-i IQueryable<T>-ə çevirir
            // 6.7 Cast<T>()        --> Kolleksiyanın bütün elementlərini T tipinə çevirir
            // 6.8 OfType<T>()      --> Müəyyən tipə uyğun elementləri seçir



            // 6.2 ToList()                    
            //var studentsArray = linqDbContext.Groups
            //  .Where(s => s.Limit > 28) // ✅ SQL Query-yə çevrilir
            //  .ToList();

            //var students = linqDbContext.Groups.ToList(); // ❌ Bütün `Students` RAM-a gətirilir

            //var studentsArrayram = students
            //    .Where(s => s.Limit > 28);  // ❌ SQL Query-yə çevrilmir, RAM-da icra olunur

            //-------------------------------------------------------------------------------------

            #endregion

            #region 7.Set Operations (Cütləşmələr)

            //  7.Set Operations (Cütləşmələr)
            //-----------------------------------------------------------------------------------

            // 7.1 Intersect()       --> Hər iki kolleksiyada olan ortaq elementləri qaytarır	
            // 7.2 Except()	         --> Birinci kolleksiyada olub, ikinci kolleksiyada olmayanları qaytarır
            // 7.3 Union()           --> Hər iki kolleksiyanı birləşdirir və unikal elementləri qaytarır
            // 7.4 Concat()          --> Hər iki kolleksiyanı birləşdirir, lakin təkrarlananları saxlayır

            //-------------------------------------------------------------------------------------

            #endregion

            #region 8.Element Selection

            //  8.Element Selection
            //-----------------------------------------------------------------------------------

            // 8.1 First()               --> Şərtə uyğun ilk elementi qaytarır, tapılmazsa xəta atır	
            // 8.2 FirstOrDefault()	     --> Şərtə uyğun ilk elementi qaytarır, tapılmazsa null və ya default qaytarır
            // 8.3 Single()              --> Şərtə uyğun yalnız bir elementi qaytarır, əgər 0 və ya >1 nəticə olarsa, xəta atır
            // 8.4 SingleOrDefault()     --> Şərtə uyğun yalnız bir elementi qaytarır, tapılmazsa null qaytarır, >1 nəticə olarsa, xəta atır
            // 8.5 Last()                --> Şərtə uyğun sonuncu elementi qaytarır, tapılmazsa xəta atır
            // 8.6 LastOrDefault()       --> Şərtə uyğun sonuncu elementi qaytarır, tapılmazsa null qaytarır
            // 8.7 ElementAt()           --> Verilmiş index-dəki elementi qaytarır, əgər indeks aralıqdan kənardadırsa xəta atır
            // 8.8 ElementAtOrDefault()  --> Verilmiş index-dəki elementi qaytarır, əgər indeks aralıqdan kənardadırsa null və ya default qaytarır

            // 8.1
            //Group group= linqDbContext.Groups.First(g=>g.Id>5000);

            //Console.WriteLine(group);


            // var lastEmployee = linqDbContext.Groups.ToList();

            // Console.WriteLine(lastEmployee.Last());

            //var thirdEmployee = linqDbContext.Groups.OrderBy(e => e.Id).ElementAt(2);           

            //-------------------------------------------------------------------------------------

            #endregion

            #region 9.Aggregation (Toplama Əməliyyatları)

            //  9.Aggregation (Toplama Əməliyyatları)
            //-----------------------------------------------------------------------------------

            // 9.1 Count()          --> Verilənlər toplusundakı elementlərin sayını qaytarır.
            // 9.2 Sum()	        --> Rəqəmsal verilənlər toplusunun cəmini qaytarır.
            // 9.3 Min()            --> Verilənlər toplusundakı ən kiçik dəyəri qaytarır.
            // 9.4 Max()            --> Verilənlər toplusundakı ən böyük dəyəri qaytarır.
            // 9.5 Average()        --> Rəqəmsal verilənlərin orta qiymətini qaytarır.
            // 9.6 Aggregate()      --> İstifadəçinin təyin etdiyi xüsusi bir funksiyaya əsasən toplama əməliyyatı icra edir.
            // 9.7 LongCount()      --> Count() metodu kimi işləyir, lakin long tipində nəticə qaytarır.


            // 9.1 Count()

            //int count = linqDbContext.Groups.Count(g=>g.Limit>20);
            //Console.WriteLine(count);

            // 9.2 Sum()

            //int sum=linqDbContext.Groups.Sum(g=>g.Limit);
            //Console.WriteLine(sum);

            // 9.3 Min()

            //int min = linqDbContext.Groups.Min(g => g.Limit);
            //Console.WriteLine(min);

            // 9.4 Max()

            //int max = linqDbContext.Groups.Max(g => g.Limit);
            //Console.WriteLine(max);

            // 9.5 Average()

            //double average = linqDbContext.Groups.Average(g => g.Limit);
            //Console.WriteLine(average);



            //-------------------------------------------------------------------------------------

            #endregion

            #region 10.Quantifiers (Kəmiyyət göstəriciləri)

            //  10.Aggregation (Toplama Əməliyyatları)
            //-----------------------------------------------------------------------------------

            // 10.1 Any()                 --> Any() metodu kolleksiyada element olub-olmadığını yoxlamaq üçün istifadə olunur.
            // 10.2 All()	              --> All() metodu kolleksiyadakı bütün elementlərin müəyyən bir şərtə uyğun olub-olmadığını yoxlayır.
            // 10.3 Contains()            --> Bir kolleksiyada (List<T>, Array<T>, DbSet<T>) müəyyən bir dəyərin olub-olmadığını yoxlayır.
            // 10.4 SequenceEqual()       --> İki kolleksiyanı müqayisə edir və onların elementlərinin sırasıyla eyni olub-olmadığını yoxlayır.


            //-------------------------------------------------------------------------------------

            #endregion

        }


    }
}
