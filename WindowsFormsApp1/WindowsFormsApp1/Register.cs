using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Register
    {
        char[] regValue = new char[4];
        

        public Register(string sentence)
        {
            char[] charArr = sentence.ToCharArray();

            if (charArr.Length < 4)
                throw new Exception();


            


            for (int i = 0; i < 4; i++)
            {
                
                int x = charArr[i];        // or, use `int.Parse()`
                if (charArr[i] >  5) { }


                regValue[i] = charArr[i];
            } 

            ////dodaje do tablicy regValue 4 pierwsze chary z tablicy^
        }

        
        public void MOV (Register anotherOne)
        {
            /// moves the value of this register to anotherOne (or the other way around idk)

        }

        public void XCHG(Register anotherOne)
        {
            /// swaps the values or whatever its called


        }
        public string ShowValue()
        {
            string showValue = new string(regValue);
            return showValue;
            //returns the value 
        }
    }
}
