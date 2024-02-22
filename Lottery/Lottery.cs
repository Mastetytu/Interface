using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lottery
{
    
    public class Lottery
    {
        public int win = 0;
        int[] tur = new int[5];
        int[] chisla = new int[5];
        int[] vr_chisl = new int[5];
        int y=0;
        
        public void Vnosim_chisla(int m)
        {
            for (int i = 0; i < 1; i++)
            {
                tur[y] = m;
                y++;
            }
        }
        
        public void Random_chisla()
        {
            
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                chisla[i] = rand.Next(0, 100);
                
            }
        }
        public void Proverka()
        {
            for (int i = 0; i < 5; i++)
            {
                if (chisla[i] == tur[i])
                {
                    win++;
                }
                
            }
        }
        
    }
}
