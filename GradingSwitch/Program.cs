NewMethod();

void NewMethod()
{

    //Programm küsib, mis hinde kasutaja sai
    //Kui kasutaja sai 'A', konsool kuvab "suurepärane!";
    //'B', konsool kuvab "Väga hea!;
    // 'C', konsool kuvab "Hea!";
    //'D', konsool kuvab "Rahuldav";
    //'E', konsool kuvab "Kasin";
    //'F', konsool kuvab "Puudulik'"; 
    //kui kasutaja sisestab midagi muud,siis konsool kuvab "Vale väärtus"

    Console.WriteLine("Sisesta oma tulemus:");

    char userResult = Convert.ToChar(Console.ReadLine().ToUpper());


    switch (userResult)
    {

        case 'A': // if(userColor == "punane"
            Console.WriteLine("Suurepärane!");

            break;
        case 'B':
            Console.WriteLine(" Väga hea!");

            break;
        case 'C':

            Console.WriteLine("Hea!");

            break;
        case 'D':

            Console.WriteLine("Rahuldav!");

            break;

        case 'E':

            Console.WriteLine("Kasin!");

            break;
        default:
            Console.WriteLine($"Vale väärtus");

            break;

    }

    
}
