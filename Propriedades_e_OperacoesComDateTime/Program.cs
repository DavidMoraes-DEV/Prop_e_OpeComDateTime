using System;

namespace Propriedades_e_OperacoesComDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A PARTIR DE UM OBJETO DATETIME PODEMOS PEGAR:
             
            Date(Data) = (DateTime)

            Day(Dia) = (int)

            DayOfWeek(Dia da Semana) = (DayOfWeek)

            DayOfYear(Dia do Ano) = (int)

            Hour(Horas) = int

            Kind(Tipo) = (DateTimeKind)

            Milisecond(Milisegundos) = (int)

            Minute(Minuto) = (int)

            Month(Mês) = (int)

            Second(Segundos) = (int)

            Ticks = (long)

            TimeOfDay(TempoDoDia) = (TimeSpan)

            Year(Ano) = (int)
            */

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            /*PROPRIEDADES DO DateTime:*/

            Console.WriteLine("1) Data completa: " + d.Date); /* .Date desconsidera o horário e utiliza apenas a data*/
            Console.WriteLine("2) Dia: " + d.Day); /* .Day mostra apenas a quantidade de dias dentro da data completa*/
            Console.WriteLine("3) Dia da semana: " + d.DayOfWeek); /* .DayOfWeek mostra o dia da semana*/
            Console.WriteLine("4) Dia do ano: " + d.DayOfYear); /* .DayOfYear mostra o dia do ano*/
            Console.WriteLine("5) Hora: "+ d.Hour); /* .Hour mostra a hora*/
            Console.WriteLine("6) Tipo: "+ d.Kind); /* .Kind mostra o tipo*/
            Console.WriteLine("7) Milisegundos: "+ d.Millisecond); /* .Milliseconds mostra os Milisegundos*/
            Console.WriteLine("8) Minutos: "+ d.Minute); /* .Minute mostra os minutos*/
            Console.WriteLine("9) Mês: "+ d.Month); /* .Month mostra o mes*/
            Console.WriteLine("10) Segundos: "+ d.Second); /* .Second mostra os segundos*/
            Console.WriteLine("11) Ticks: "+d.Ticks); /* .Ticks Mostra os Ticks*/
            Console.WriteLine("12) Tempo do Dia: "+d.TimeOfDay); /* .TimeOfDay mostra o tempo do dia*/
            Console.WriteLine("13) Ano: "+d.Year); /* .Year mostra o ano*/
            Console.WriteLine();

            /*FORMATAÇÃO DO DateTime:*/

            Console.WriteLine("ToLongDateString: " + d.ToLongDateString()); /* .ToLongDateString Função para converter o tipo DateTime para string em formato por extenso*/
            Console.WriteLine();
            Console.WriteLine("ToShortDateString: " + d.ToShortDateString()); /* .ToShortDateString Função para converter o tipo DateTime em string porém dessa vez de forma resumida*/
            Console.WriteLine();
            Console.WriteLine("ToLongTimeString: " + d.ToLongTimeString()); /* .ToLongDateString Função para converter o tempo em formato por extenso*/
            Console.WriteLine();
            Console.WriteLine("ToShortTimeString: " + d.ToShortTimeString()); /* .ToShortTimeString Função para converter o tempo em formato resumido*/
            Console.WriteLine();
            Console.WriteLine("ToString: " + d.ToString()); /*Mostra o formato padrão de impressão*/
            Console.WriteLine();
            Console.WriteLine("Mascara de Foormatação com o .ToString(yyyy-MM-dd HH:mm:ss): " + d.ToString("yyyy-MM-dd HH:mm:ss")); /* .ToString("yyyy-MM-dd HH:mm:ss") formata o DateTime do jeito que for especificado no .ToString*/
            Console.WriteLine();
            Console.WriteLine("Mascara de Foormatação com o .ToString(yyyy-MM-dd HH:mm:ss.fff): " + d.ToString("yyyy-MM-dd HH:mm:ss.fff")); /* .ToString("yyyy-MM-dd HH:mm:ss.fff") formata o DateTime do jeito que for especificado no .ToString incluindo os milisegundos*/

            /*OPERAÇÕES COM DateTime:*/

            Console.WriteLine();
            DateTime d2 = d.AddHours(2); /*Adiciona as horas especificadas entre parenteses ao DateTime*/
            Console.WriteLine("Adiociona 2 horas com .AddHours: " + d2);
            Console.WriteLine();
            DateTime d3 = d.AddMinutes(3); /*Adiciona os minutos especificados entre parenteses ao DateTime*/
            Console.WriteLine("Adiciona 3 minutos com o .AddMinutes: " + d3);
            Console.WriteLine();
            DateTime d4 = d.AddDays(7); /*Adiciona os dias especificados entre parenteses ao DateTime*/
            Console.WriteLine("Adiciona 7 dias com o .AddDays: " + d4);
            Console.WriteLine();
            TimeSpan t = d4.Subtract(d); /*Compara duas datas distintas e mostra a diferença de data/tempo entre elas*/
            Console.WriteLine("Diferença entre duas datas com o .Subtract: " + t);
            Console.WriteLine();

            /*Existem muitas outras operações com o .Add como Adicionar MESES, SEGUNDOS, TICKS, ANOS, MILISEGUNDOS entre outros.*/
        }
    }
}
