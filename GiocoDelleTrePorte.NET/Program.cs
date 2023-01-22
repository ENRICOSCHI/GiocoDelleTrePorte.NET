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
            int countC = 0;//for the win change choice count
            int loseC= 0;//for the lose chagne choice count
            int countL= 0;//for leave the old choice count
            int loseL= 0;//for the lose leave choice count
            double  calcoloPercerntualeWinChange = 0;//go to row 70-75 for see what are this variable
            double calcoloPercerntualeLoseChange = 0;
            double calcoloPercerntualeWinLeave = 0;
            double calcoloPercerntualeLoseLeave = 0;
            Door Porta = new Door();
            string FinaleAnswerForLeaveTheGame = "y";//for the final answer in the bottom of the code
            do
            {
                int TheWinnerDoor = Porta.portaVincente();//saved the door winner
                int EliminatedDoor = 0;
                Console.WriteLine("Buongiorno, questo a cui stai giocando viene chiamato il GIOCO DELLE TRE PORTE.\nIn questo gioco dovrai scegliere una tra le tre porte nelle quali ci potrebbe essere una macchina nuova di zecca oppure una capra.\nQuindi che porta scegli?\n 1\t\t 2\t\t 3\t\t\n"); //first 3 phrases that show up to the user
                int FirstChosenDoor = int.Parse(Console.ReadLine());//user chose the door and it get saved on n
                if (FirstChosenDoor == 1)
                {
                    EliminatedDoor = Porta.EliminateDoor(FirstChosenDoor, TheWinnerDoor);
                }
                if (FirstChosenDoor == 2)
                {
                    EliminatedDoor = Porta.EliminateDoor(FirstChosenDoor, TheWinnerDoor);
                }
                if (FirstChosenDoor == 3)
                {
                    EliminatedDoor = Porta.EliminateDoor(FirstChosenDoor, TheWinnerDoor);
                }
                int ChangedDoor = Porta.remainedDoor(FirstChosenDoor, EliminatedDoor); //for know what is the last door remain between the two
                Console.WriteLine("E' stata eliminata la porta numero: " + EliminatedDoor.ToString() + "\nVolete cambiare porta con la numero:\t " + ChangedDoor + " \to \tlasciare la scelta precedente?\nScrivere: c\t per cambiare\t o\t l\t per lasciare\n");//second phrase after had chose the door
                string answer = Console.ReadLine();
                if (answer == "c")//door changed answer
                {
                    if (TheWinnerDoor == ChangedDoor)
                    {
                        Console.WriteLine("HAI VINTO LA MACCHINA COMPLIMENTI!!\n");//win message
                        countC++;
                        calcoloPercerntualeWinChange += (countC / (countL + countC + loseL + loseC)) * 10;//for win change
                    }
                    else
                    {
                        Console.WriteLine("Peccato hai perso :( ; però hai vinto una capra :) .\n");//lost message
                        loseC++;
                        calcoloPercerntualeLoseChange += (loseC / (countL + countC + loseL + loseC)) * 10;//for lose change
                    }
                    //try to save formula online in database
                }
                if (answer == "l")//No door changed answer
                {
                    if (TheWinnerDoor == FirstChosenDoor)
                    {
                        Console.WriteLine("HAI VINTO LA MACCHINA COMPLIMENTI!!\n");//win message
                        countL++;
                        calcoloPercerntualeWinLeave += (countL / (countL + countC + loseL + loseC)) * 10;//for win leave
                    }
                    else
                    {
                        Console.WriteLine("Peccato hai perso :( ; però hai vinto una capra :) .\n");//lost message
                        loseL++;
                        calcoloPercerntualeLoseLeave += (loseL / (countL + countC + loseL + loseC)) * 10;//for lose leave
                    }
                    //try to save formula online in database
                }
                Console.WriteLine("La percentuale di partite vinte cambiando porta sono: " + calcoloPercerntualeWinChange.ToString() + "% invecele partite perse per aver cambiato porta sono: " + calcoloPercerntualeLoseChange.ToString() +"%.\nLe partite vinte per non aver cambiato la porta sono: " + calcoloPercerntualeWinLeave.ToString() + "% mentre le partite perse per non aver cambiato porta sono: " + calcoloPercerntualeLoseLeave.ToString() + "%.\n"); // message that show statics
                Console.WriteLine("Per avere statistiche più precise provare più volte il seguente gioco.\n");                                                                                                                  
                Console.WriteLine("Riprovare il gioco? \ty \toppure \tn\n");//end message
                FinaleAnswerForLeaveTheGame = Console.ReadLine();
            } while (FinaleAnswerForLeaveTheGame != "n"); 
            Console.WriteLine("Premere invio per finire.\n");//end message
            Console.ReadLine();
        }  
    }
}
