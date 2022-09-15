
// === LINQ ===
// Usa le fluent-api di Linq per risolvere i problemi indicati.
// ============

using System.Collections;
using System.Linq;


// == DATI ==

// numeri da 0 a 9 in ordine casuale
IEnumerable<int> numeri = new int[] { 6, 8, 5, 1, 2, 7, 9, 4, 0, 3 };

Console.WriteLine($"Numeri: {string.Join(", ", numeri)}");
Console.WriteLine();


// == PROBLEMI ==

// trova il valore massimo
#region Soluzione

//int max = numeri.Max();

#endregion

int max = 0;  // TODO

VerificaSoluzione("Valore massimo", max, 9);


// trova il valore minimo
#region Soluzione

//int min = numeri.Min();

#endregion

int min = 0;  // TODO

VerificaSoluzione("Valore minimo", min, 0);


// calcola il valore medio
#region Soluzione

//double average = numeri.Average();

#endregion

double average = 0;  // TODO

VerificaSoluzione("Valore medio", average, 4.5);


// calcola la somma
#region Soluzione

//int sum = numeri.Sum();

#endregion

int sum = 0;  // TODO

VerificaSoluzione("Somma", sum, 45);


// ordina in ordine crescente
#region Soluzione

//IEnumerable<int> ordered = numeri.OrderBy(n => n);

#endregion

IEnumerable<int> ordered = new int[0];  // TODO

VerificaSoluzione("In ordine crescente", ordered, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });


// ordina in ordine decrescente
#region Soluzione

//IEnumerable<int> orderedDescending = numeri.OrderByDescending(n => n);

#endregion

IEnumerable<int> orderedDescending = new int[0]; // TODO

VerificaSoluzione("In ordine decrescente", orderedDescending, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });


// filtra solo i numeri maggiori di 5
#region Soluzione

//IEnumerable<int> aboveFive = numeri.Where(n => n > 5);

#endregion

IEnumerable<int> aboveFive = new int[0];  // TODO

VerificaSoluzione("Maggiori di 5", aboveFive, new int[] { 6, 8, 7, 9 });


// prendi il primo numero nella sequenza
#region Soluzione

//int first = numeri.First();

#endregion

int first = 0;  // TODO

VerificaSoluzione("Primo", first, 6);


// prendi i primi 5 numeri nella sequenza
#region Soluzione

//IEnumerable<int> firstFive = numeri.Take(5);

#endregion

IEnumerable<int> firstFive = new int[0];  // TODO

VerificaSoluzione("Primi 5", firstFive, new[] { 6, 8, 5, 1, 2 });


// prendi i numeri dal 7 in poi nella squenza
#region Soluzione

//IEnumerable<int> sevenAndAfter = numeri.SkipWhile(n => n != 7);

#endregion

IEnumerable<int> sevenAndAfter = new int[0];  // TODO

VerificaSoluzione("Dal 7 in poi", sevenAndAfter, new[] { 7, 9, 4, 0, 3 });


// prendi i numeri maggiori di 5 che appaiono dopo il 2 nella sequenza, ordinati in ordine decrescente
#region Soluzione

// NOTA: "SkipWhile" deve essere prima di "Where", altrimenti il "Where" filtrerebbe via il numero 2 dalla sequenza.

//IEnumerable<int> aboveFiveAfterSevenDescending = numeri.SkipWhile(n => n != 2).Where(n => n > 5).OrderByDescending(n => n);

#endregion

IEnumerable<int> aboveFiveAfterSevenDescending = new int[0];  // TODO

VerificaSoluzione("Maggiori di 5, dopo il 2, in ordine decrescente", aboveFiveAfterSevenDescending, new[] { 7, 9 });


// == SUPPORTO ==

#region Supporto

void VerificaSoluzione(string consegna, object risultato, object soluzione) {
    ConsoleColor fc = Console.ForegroundColor;
    try {
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        Console.Write($"{consegna}: ");

        Console.ForegroundColor = fc;

        Console.WriteLine(risultato is IEnumerable r ? string.Join(", ", r.Cast<object>()) : risultato);

        bool isOk = soluzione is IEnumerable s ? risultato is IEnumerable r2 && s.Cast<object>().SequenceEqual(r2.Cast<object>()) : soluzione.Equals(risultato);
        if (isOk) {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("OK");
        } else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERRORE, dovrebbe essere: {(soluzione is IEnumerable s2 ? string.Join(", ", s2.Cast<object>()) : soluzione)}");
        }
    } finally {
        Console.ForegroundColor = fc;
    }

    Console.WriteLine();
}

#endregion