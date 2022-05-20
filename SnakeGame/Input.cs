using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Input
    {
        /*
         Classe para certificar que inputs do teclado sejam detetados.
         */

        //Carrega a lista de butoes disponiveis no teclado.
        private static Hashtable keyTable = new Hashtable();

        //Realiza uma verificacao para verificar se um botao em particular e primido.
        public static bool keypressed(Keys key)
        {
            if(keyTable[key] == null) return false;
            return (bool) keyTable[key];
        }

        //Detetar se uma tecla e carregada.
        public static void changestate(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
