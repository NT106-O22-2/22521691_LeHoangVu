using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_22521691
{
    public class seatBuy
    {
        bool[,] selectedState = new bool[3, 5];
        int[,] ticketClass = new int[3, 5];
        int[,] ticketPrice = new int[3, 5];

        public seatBuy(string name_film)
        {
            ticketClass[0, 1] = 1;
            ticketClass[0, 2] = 1;
            ticketClass[0, 3] = 1;
            ticketClass[2, 1] = 1;
            ticketClass[2, 2] = 1;
            ticketClass[2, 3] = 1;  //Vé thường

            ticketClass[1, 1] = 2;
            ticketClass[1, 2] = 2;
            ticketClass[1, 3] = 2;  //Vé vip

            if (name_film == "Đào, phở và piano")
            {
                ticketPrice[0, 0] = 11250;
                ticketPrice[0, 4] = 11250;
                ticketPrice[1, 0] = 11250;
                ticketPrice[1, 4] = 11250;
                ticketPrice[2, 0] = 11250;
                ticketPrice[2, 4] = 11250;

                ticketPrice[0, 1] = 45000;
                ticketPrice[0, 2] = 45000;
                ticketPrice[0, 3] = 45000;
                ticketPrice[2, 1] = 45000;
                ticketPrice[2, 2] = 45000;
                ticketPrice[2, 3] = 45000;

                ticketPrice[1, 1] = 90000;
                ticketPrice[1, 2] = 90000;
                ticketPrice[1, 3] = 90000;
            } else if (name_film == "Mai")
            {
                ticketPrice[0, 0] = 25000;
                ticketPrice[0, 4] = 25000;
                ticketPrice[1, 0] = 25000;
                ticketPrice[1, 4] = 25000;
                ticketPrice[2, 0] = 25000;
                ticketPrice[2, 4] = 25000;

                ticketPrice[0, 1] = 100000;
                ticketPrice[0, 2] = 100000;
                ticketPrice[0, 3] = 100000;
                ticketPrice[2, 1] = 100000;
                ticketPrice[2, 2] = 100000;
                ticketPrice[2, 3] = 100000;

                ticketPrice[1, 1] = 200000;
                ticketPrice[1, 2] = 200000;
                ticketPrice[1, 3] = 200000;
            } else if (name_film == "Gặp lại chị bầu")
            {
                ticketPrice[0, 0] = 17500;
                ticketPrice[0, 4] = 17500;
                ticketPrice[1, 0] = 17500;
                ticketPrice[1, 4] = 17500;
                ticketPrice[2, 0] = 17500;
                ticketPrice[2, 4] = 17500;

                ticketPrice[0, 1] = 70000;
                ticketPrice[0, 2] = 70000;
                ticketPrice[0, 3] = 70000;
                ticketPrice[2, 1] = 70000;
                ticketPrice[2, 2] = 70000;
                ticketPrice[2, 3] = 70000;

                ticketPrice[1, 1] = 140000;
                ticketPrice[1, 2] = 140000;
                ticketPrice[1, 3] = 140000;
            } else if(name_film == "Tarot")
            {
                ticketPrice[0, 0] = 22500;
                ticketPrice[0, 4] = 22500;
                ticketPrice[1, 0] = 22500;
                ticketPrice[1, 4] = 22500;
                ticketPrice[2, 0] = 22500;
                ticketPrice[2, 4] = 22500;

                ticketPrice[0, 1] = 90000;
                ticketPrice[0, 2] = 90000;
                ticketPrice[0, 3] = 90000;
                ticketPrice[2, 1] = 90000;
                ticketPrice[2, 2] = 90000;
                ticketPrice[2, 3] = 90000;

                ticketPrice[1, 1] = 180000;
                ticketPrice[1, 2] = 180000;
                ticketPrice[1, 3] = 180000;
            }
        }
        public bool get_state (int x, int y)
        {
            return selectedState[x, y];
        }

        public int get_price (int x, int y)
        {
            return ticketPrice[x, y];
        }

        public void set_state(int x, int y, bool state)
        {
            selectedState[x, y] = state;
        }
    }

}
