using EnumIzah.Enums;

namespace EnumIzah
{
    [Flags]
    public enum UserRoles
    {
        None = 0,                          // 0000
        User = 1,                          // 0001
        Moderator = 2,                          // 0010
        Admin = User | Moderator | 4,       // 0111 (7) → User + Moderator + öz rolu
        SuperAdmin = Admin | 8,                  // 1111 (15) → Admin + Moderator + User + öz rolu
        All = SuperAdmin                  // 1111 (15) → bütün hüquqlar
    }

    internal class Program
    {
      

        static void Main(string[] args)
        {

            UserRoles role = UserRoles.Admin;

            if (role.HasFlag(UserRoles.User))
                Console.WriteLine("Admin həm User işini görə bilir");

            if (role.HasFlag(UserRoles.Moderator))
                Console.WriteLine("Admin həm Moderator işini görə bilir");

            if (role.HasFlag(UserRoles.Admin))
                Console.WriteLine("Admin həm öz işini görə bilir");

            int day = 2;
            switch (day)
            {
                case (int)WeekDays.Monday:
                    Console.WriteLine("1 ci gün");
                    break;
                case (int)WeekDays.Tuesday:
                    Console.WriteLine("2 ci gün");
                    break;
                case (int)WeekDays.Wednesday:
                    Console.WriteLine("3 ci gün");
                    break;
                case (int)WeekDays.Thursday:

                    Console.WriteLine("4 ci gün");
                    break;
                case (int)WeekDays.Friday:

                    Console.WriteLine("5 ci gün");
                    break;
                case (int)WeekDays.Saturday:
                    Console.WriteLine("6 ci gün");

                    break;
                case (int)WeekDays.Sunday:
                    Console.WriteLine("7 ci gün");
                    break;
                default:
                    Console.WriteLine("bele bir gun yoxdur");
                    break;
            }
        }
    }
}
