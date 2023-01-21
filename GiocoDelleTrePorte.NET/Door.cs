using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDelleTrePorte.NET
{
    internal class Door
    {
        Random rd = new Random();//initializze random
        public int EliminateDoor(int NotEliminateThisDoor,int TheWinnerDoor)
        {
            int r = rd.Next(1, 4);// 1 2 3 
            for (int i = 0;i<=100;i++)//useless I think?
            {
                
                if(r== NotEliminateThisDoor || r== TheWinnerDoor)
                {
                    r=rd.Next(1,4);//repeat random choose
                }
                else
                {
                    break;//exit from for
                }
            }
            return r;
        }
        public int remainedDoor(int n, int r)
        {
            int lastDoor = 0;
            if(n==1 && r == 2|| n==2 &&r==1) // for the numeber 3
            {
                lastDoor = 3;
            }
            else if(n==1 && r == 3|| n==3 && r==1)// for the number 2
            {
                lastDoor = 2;
            }
            else
            {
                lastDoor = 1;// of course the last one is 1
            }
            return lastDoor;    
        }
        public int portaVincente()
        {
            int macchina=rd.Next(1, 4);//the door with the car behind
            return macchina;
        }
    }
}
