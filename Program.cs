using System;

namespace Fechas

{
    public static class Fechas
    {
        static void Main(string[] args)
        {
            //DateTime Fecha1 = Convert.ToDateTime("01/01/2020 00:00:00");
            //DateTime Fecha2 = Convert.ToDateTime("01/05/2020 00:00:00");
            //Periodo periodo1 = new Periodo(Fecha1, Fecha2);
            //Console.WriteLine(periodo1.EspacioTiempo());

            DateTime[] Fecha1 = {Convert.ToDateTime("01/01/2020 00:00:00"), Convert.ToDateTime("01/05/2020 00:00:00")};
            DateTime[] Fecha2 = { Convert.ToDateTime("02/02/2020 00:00:00"), Convert.ToDateTime("01/06/2020 00:00:00") };
            DateTime[] Fecha3 = { Convert.ToDateTime("04/02/2020 00:00:00"), Convert.ToDateTime("01/03/2020 00:00:00") };
            DateTime[] Fecha4 = { Convert.ToDateTime("01/07/2020 00:00:00"), Convert.ToDateTime("01/08/2020 00:00:00") };

            DateTime[][] Fechas = {Fecha1, Fecha2, Fecha3, Fecha4};

            Periodo periodo1 = new Periodo(Fecha1[0], Fecha1[1]);
            
        }

        //public static void Unir()
        //{
        //    foreach (DateTime[] Fecha in Fechas)
        //    {

        //    }
        //}
    }
    
}