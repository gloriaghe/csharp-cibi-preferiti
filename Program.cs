//ESERCIZI 28/10

//Snack 1
//Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.

Console.WriteLine("Inserisci due parole");
string PrimaParola = Console.ReadLine();
string SecondaParola = Console.ReadLine();

string ParolaLunga = "";
Console.WriteLine(LunghezzaParole(PrimaParola, SecondaParola));
;

string LunghezzaParole(string parola1, string parola2)
{
    if (parola1.Length == parola2.Length)
    {
        ParolaLunga = parola1 + " " + parola2;
        return ParolaLunga;

    }
    else if (parola1.Length > parola2.Length)
        return parola1;
    else
        return parola2;

}


//Snack 2
//Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.

string ParioDispari(int numero)
{
    if(numero % 2 == 0)
    {
        return "Il numero è pari";

    }
    else
    {
        return "Il numero è dispari";

    }
}

Console.WriteLine("Scegli un numero!");
int numeroScelto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ParioDispari(numeroScelto));



////ESERCIZI POMERIGGIO

////Istruzioni condizionali
////Snack1. L’utente inserisce due numeri in successione.
////Il software stampa il maggiore.

//using System;
//using System.Runtime.ConstrainedExecution;

//Console.WriteLine("Inserisci un numero");
//int primoNumero = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserisci un altro numero");
//int secondoNumero = Convert.ToInt32(Console.ReadLine());

//if (primoNumero > secondoNumero)
//{
//    Console.WriteLine(primoNumero);
//}
//else
//{
//    Console.WriteLine(secondoNumero);
//}

////Snack2. L’utente inserisce due parole in successione.
////Il software stampa prima la parola più corta, poi la parola più lunga.

//Console.WriteLine("Inserisci una parola");
//string primaParola = Console.ReadLine();

//Console.WriteLine("Inserisci un altra parola");
//string secondaParola = Console.ReadLine();

//if (primaParola.Length < secondaParola.Length)
//{
//    Console.WriteLine("La parola più corta è: " + primaParola + " mentre la più lunga è: " + secondaParola);
//}
//else
//{
//    Console.WriteLine("La parola più corta è: " + secondaParola + " mentre la più lunga è: " + primaParola);
//}

////Ciclo for
////Snack3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
////Il programma stampa la somma di tutti i numeri inseriti.

//int[] numeri = new int[10];

//int somma = 0;
//for (int i = 0; i < numeri.Length; i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    numeri[i] = Convert.ToInt32(Console.ReadLine());
//    somma = somma + numeri[i];
//}
//Console.WriteLine(somma);

////Snack4. Calcola la somma e la media dei numeri da 2 a 10.

//int sommaDueDieci = 0;
//int media;

//for (int i = 2; i <= 10; i++)
//{
//    sommaDueDieci += i;

//}
//media = sommaDueDieci / 9;
//Console.WriteLine("somma: " + sommaDueDieci);
//Console.WriteLine("media: " + media);

////Operatore modulo
////Snack5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,
////stampa il numero, se è dispari, stampa il numero successivo

//Console.WriteLine("Inserisci un numero");
//int numeroUtente = Convert.ToInt32(Console.ReadLine());

//if (numeroUtente % 2 == 0)
//{
//    Console.WriteLine(numeroUtente);
//}
//else
//{
//    Console.WriteLine(numeroUtente + 1);

//}

////Array
////Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
////Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla
////festa.

//string[] invitatiFesta = { "Gloria", "Luca", "Nathan" };
//Console.WriteLine("Come ti chiami?");
//string nomeUser = Console.ReadLine();
//bool YesOrNot = false;

//for (int i = 0; i < invitatiFesta.Length; i++)
//{
//    if (nomeUser == invitatiFesta[i])
//    {
//        YesOrNot = true;
//        break;
//    }
//}

//if (YesOrNot == true)
//{
//    Console.WriteLine("Puoi partecipare!");
//}
//else
//{
//    Console.WriteLine("Mi dispiace ma non puoi partecipare!");

//}
//Snack7.Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
//nell’array.

//int[] arrNumeri = new int[6];

//for (int i = 0; i < arrNumeri.Length; i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    if (numero % 2 != 0)
//    {
//        arrNumeri[i] = numero;
//        Console.WriteLine("Inserito nell'array");

//    }

//}


//Snack8.Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
//posizione dispari

//int[] arrNumeriInt = { 2, 0, 5, 10, 9, 5, 13 };
//int sommaArrayDispari = 0;

//for (int i = 0; i < arrNumeriInt.Length; i++)
//{

//    if (i  % 2 != 0)
//        sommaArrayDispari = sommaArrayDispari + arrNumeriInt[i];


//}

//Console.WriteLine("La somma dell'array in posizione dispari è: " + sommaArrayDispari);

//Ciclo while
//Snack9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
//somma degli elementi è minore di 50.

//int[] ArrayVuoto = new int[50];

//int SommaArrayCinquanta = 0;
// Console.WriteLine("Inserisci un numero fino ad arivare a 50");

//while ( SommaArrayCinquanta < 50)
//{
//    int i = 0;
//    int NumeroFinoaCinquanta = Convert.ToInt32(Console.ReadLine());
//    SommaArrayCinquanta = SommaArrayCinquanta + NumeroFinoaCinquanta;
//    i++;
//}
//Console.WriteLine("La somma è: " + SommaArrayCinquanta);


////Random
////Snack10. Fai inserire un numero, che chiameremo N, all’utente.
////Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
////Ogni volta che ne crei uno, stampalo a schermo.

//Console.WriteLine("Inserisci un numero con cui creare degli array");
//int N = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < N; i++)
//{
//    Console.WriteLine("Array " + i);

//    int[] arrayCasuale = new int[10];
//    for (int j = 0; j < 10; j++)
//    {
//        Random rnd = new Random();
//        int numCasuale = rnd.Next(1, 101);
//        arrayCasuale[j] = numCasuale;
//        Console.Write(arrayCasuale[j] + " ");
//    }
//    Console.WriteLine();
//}





//ESERCIZIO MATTINA

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

//string[] cibiPreferiti = { "Pizza", "Carbonara", "Torta al cioccolato", "Lasagna", "Tagliata al sangue", "Tiramisù", "Fragole" , "Mango" };

//Console.WriteLine("Lunghezza: " + cibiPreferiti.Length);

////altri modi per stampare:
////Console.WriteLine("Lunghezza: {0}", cibiPreferiti.Length);
////Console.WriteLine($"Lunghezza: {cibiPreferiti.Length}");


//Console.WriteLine();
//Console.WriteLine("Classifica cibi:");
//for (int i = 0; i < cibiPreferiti.Length; i++)
//{
//    Console.Write(i + 1 + " - "); //riga stampata che non va a capo
//    Console.WriteLine(cibiPreferiti[i]);

//    //Console.WriteLine(i+1 + cibiPreferiti[i]);

//}


//Console.WriteLine();

//Console.WriteLine("Primo: " + cibiPreferiti[0]);

//if(cibiPreferiti.Length % 2 == 0)
//{
//    //pari
//    int mediana = cibiPreferiti.Length / 2;
//    Console.WriteLine("Centrale: {0} e {1}", cibiPreferiti[mediana - 1], cibiPreferiti[mediana]);
//} else
//{
//    // dispari
//    int mediana = cibiPreferiti.Length / 2;
//    Console.WriteLine("Centrale: " + cibiPreferiti[mediana]);


//}
//Console.WriteLine("Ultimo: " + cibiPreferiti[cibiPreferiti.Length-1]);


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