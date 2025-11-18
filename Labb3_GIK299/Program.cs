using System;
namespace Labb3_GIK299
{
    public class Temperature
    {
        //array med 31 dagar för maj
        public int[] mayDays = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31];

        //public Random randomNumber; = new Random();
        //public int maxTemp = 25;
        //public int minTemp = 5;
        public int temp = Random.Next(int 5, int 26);

        //generera data med random och next()-metod
        
        
        

        
        
        //Metoder:
        //1 temperaturdata för varje dag
        //2 medeltemperatur i månaden
        //3 högsta temperatur
        //4 lägsta temperatur
        //5 mediantemperatur i månaden
        //6 sortera, fallande och stigande (ascend och descend)
        //7 filtrera med temperatur som villkor
        //8 välja dag och få temperatur dagen innan, dagen och dagen efter
        //9 vanligaste temperaturen i månaden - typvärde

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Temperature tempPerDays = new Temperature();


            Console.WriteLine(tempPerDays.temp);
            //skriv ut en lista med de 9 valen

            //input med en siffra 1-9

            //switch case med 9 villkor

            //case 1:
            //skriv ut lista med varje dag + temperatur för varje dag

            //case 2:
            //skriv ut medeltemperaturen

            //case 3:
            //skriv ut maxtemperatur samt datumet

            //case 4:
            //skriv ut mintemperaturen och datum

            //case 5:
            //skriv ut mediantemperaturen

            //case 6:
            //skriv ut "fallande eller stigande?"
            //input från användaren
            //if-sats för fallande eller stigande
            //skriv ut temperaturen (och dagarna) antingen stigande eller fallande 

            //case 7:
            //skriv ut "vilken minsta temperatur?"
            //input med värde
            //for-loop som går igenom allt i arrayen
            //if-sats som jämför variabeln med alla temperaturer
            //skriver ut de dagar (och temperatur) som överstiger variabeln

            //case 8:
            //skriv ut "vilken dag?"
            //input med en siffra för dagen
            //skriv ut temperaturen på den indexplatsen
            //ta bort 1 från indexsiffran och skriv ut temp
            //lägg till 1 på indexsiffran och skriv ut temp

            //case 9:
            //skriv ut typvärde för tempen i månaden
        }
    }
}
