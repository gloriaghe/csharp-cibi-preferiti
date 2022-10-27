// See https://aka.ms/new-console-template for more information

using System;
using System.Linq.Expressions;

//Create un progetto App Console csharp-cibi-preferiti con VS2022.
//Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
//L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
//La lunghezza della classifica
//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
//Il vostro cibo top (prima posizione della classifica)
//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
//Le modalità di consegna sono le solite: repo GitHub, commit e push
//BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
//Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari.
//In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.

string[] cibiPreferiti = { "Pizza", "Carbonara", "Torta al cioccolato", "Lasagna", "Tagliata al sangue", "Tiramisù", "Fragole" , "Mango" };

Console.WriteLine("Lunghezza: " + cibiPreferiti.Length);

//altri modi per stampare:
//Console.WriteLine("Lunghezza: {0}", cibiPreferiti.Length);
//Console.WriteLine($"Lunghezza: {cibiPreferiti.Length}");


Console.WriteLine();
Console.WriteLine("Classifica cibi:");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.Write(i + 1 + " - "); //riga stampata che non va a capo
    Console.WriteLine(cibiPreferiti[i]);

    //Console.WriteLine(i+1 + cibiPreferiti[i]);

}


Console.WriteLine();

Console.WriteLine("Primo: " + cibiPreferiti[0]);

if(cibiPreferiti.Length % 2 == 0)
{
    //pari
    int mediana = cibiPreferiti.Length / 2;
    Console.WriteLine("Centrale: {0} e {1}", cibiPreferiti[mediana - 1], cibiPreferiti[mediana]);
} else
{
    // dispari
    int mediana = cibiPreferiti.Length / 2;
    Console.WriteLine("Centrale: " + cibiPreferiti[mediana]);


}
Console.WriteLine("Ultimo: " + cibiPreferiti[cibiPreferiti.Length-1]);


//for (int i = 0; i < cibiPreferiti.Length; i++)
//{
//    switch (i)
//    {
//        case 0:
//            Console.WriteLine("Primo-" + cibiPreferiti[i]);

//            break;
//        case 3:
//        case 4:
//            Console.WriteLine("Medio-" + cibiPreferiti[i]);

//            break;
//        case 7:
//            Console.WriteLine("Ultimo-" + cibiPreferiti[i]);
//            break;
       
//    }
//}