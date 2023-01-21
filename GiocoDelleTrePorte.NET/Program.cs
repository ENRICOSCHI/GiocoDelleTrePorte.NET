using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDelleTrePorte.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door Porta = new Door();
            int TheWinnerDoor = Porta.portaVincente();//saved the door winner
            int EliminatedDoor=0;
            Console.WriteLine("Buongiorno, questo a cui stai giocando viene chiamato il GIOCO DELLE TRE PORTE.\nIn questo gioco dovrai scegliere una tra le tre porte nelle quali ci potrebbe essere una macchina nuova di zecca oppure una capra.\nQuindi che porta scegli?\n 1\t\t 2\t\t 3\t\t\n"); //first 3 phrases that show up to the user
            int FirstChosenDoor = int.Parse(Console.ReadLine());//user chose the door and it get saved on n
            if (FirstChosenDoor == 1)
            {
               EliminatedDoor = Porta.EliminateDoor(FirstChosenDoor, TheWinnerDoor);
            }
            if(FirstChosenDoor == 2)
            {
                 EliminatedDoor=Porta.EliminateDoor(FirstChosenDoor, TheWinnerDoor);
            }
            if(FirstChosenDoor == 3)
            {
                 EliminatedDoor = Porta.EliminateDoor(FirstChosenDoor, TheWinnerDoor);
            }
            int ChangedDoor = Porta.remainedDoor(FirstChosenDoor, EliminatedDoor); //for know what is the last door remain between the two
            Console.WriteLine("E' stata eliminata la porta numero: "  + EliminatedDoor.ToString() + "\nVolete cambiare porta con la numero:\t "+ ChangedDoor + " \to \tlasciare la scelta precedente?\nScrivere: c\t per cambiare\t o\t l\t per lasciare\n");//second phrase after had chose the door
            string answer = Console.ReadLine();
            if(answer == "c")//door changed answer
            {
                if (TheWinnerDoor == ChangedDoor)
                {
                    Console.WriteLine("HAI VINTO LA MACCHINA COMPLIMENTI!!\n");//win message
                }
                else
                {
                    Console.WriteLine("Peccato hai perso :( ; però hai vinto una capra :) .\n");//lost message
                }
                //add formula of percentage when you put it online in database
            }
            if (answer == "l")//No door changed answer
            {
                if(TheWinnerDoor==FirstChosenDoor)
                {
                    Console.WriteLine("HAI VINTO LA MACCHINA COMPLIMENTI!!\n");//win message
                }
                else
                {
                    Console.WriteLine("Peccato hai perso :( ; però hai vinto una capra :) .\n");//lost message
                }
                //add formula of percentage when you put it online in database
            }
            Console.WriteLine("Premere invio per finire.\n");//end message
            Console.ReadLine();
        }  
    }
}
