using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class TechGigContest
    {
        private static int players;
        private static int maxCount;
        private static int places;
        private static int noOfTimes;
        private static PlayerNode head;
        private class PlayerNode
        {
            public int value;
            public PlayerNode Next;
            public PlayerNode Prev;
            public int count;
        }
        public static int passCount(int input1, int input2, int input3)
        {

            if ((input1 < 3) || (input1 > 1000))
                return -1;
            if ((input2 < 3) || (input2 > 1000))
                return -1;
            players = input1;
            maxCount = input2;
            places = input3;
            CreatePlayers(players);
            int p = Passball(maxCount, places);
            return p;
        }

        private static void CreatePlayers(int p)
        {
            PlayerNode next, prev =null,current = null;
            for (int i = 1; i <= p; i++)
            {
                current = new PlayerNode();
                if (i == 1)
                    head = current;
                if (prev != null)
                {
                    prev.Next = current;
                   
                }
                current.Prev = prev;
                current.value = i;
                prev = current;
            }
            head.Prev = prev;
            current.Next = head;
        }

        private static int Passball(int maxCount,int places)
        {
            PlayerNode current = head;
            while (true)
            {
                current.count++;
             
                if (current.count == maxCount)
                    break;
              
                if (current.count%2 == 0)
                    current = GoLeft(current, places);
                else
                    current = GoRight(current, places);
                noOfTimes++;
               
            }
            return noOfTimes;
        }

        private static PlayerNode GoRight(PlayerNode current, int places)
        {
            int counter = 0;
            while (counter <= places)
            {
                current = current.Next;
                counter++;
            }
            return current;
        }

        private static PlayerNode GoLeft(PlayerNode current, int places)
        {
            int counter = 0;
            while (counter <= places)
            {
                current = current.Prev;
                counter++;
            }
            return current;
        }
    }
}
