//Осъден на смърт на електрически стол, му се дава възможност да се избави. 
﻿Има два стола един истински и един фалшив. И двама палачи (не са асоциирани към столовете), 
﻿единия винаги казва истината, другия винаги лъже. Осъдения има право на един въпрос, към един от тях. 
﻿В зависимост от отговора, ще разбере кой стол кой е.

using System;

namespace _04.ElectricityChair
{
    class ExamTaskCeco
    {
        static void Main()
        {
            Console.WriteLine("На въпроса: Какво ще каже другия палач, това ли е истинския стол?");
            Console.WriteLine("Въведи хипотетичен отговор с (да) или (не):");

            string PalachNeznaemKoj = Console.ReadLine();

            if (PalachNeznaemKoj == "да") 
                
                //Ако си питал този който лъже, отговора е обратен на това което е казал другия
            {
                PalachNeznaemKoj = "да";

                Console.WriteLine(PalachNeznaemKoj);

            }


            else if (PalachNeznaemKoj == "не") 
                
                //Ако си питал този който казва истината, отговора е това което е казал другия
            {
                PalachNeznaemKoj = "не";

                Console.WriteLine(PalachNeznaemKoj); 
                
                //Два пъти (не), това е истинския стол; Два пъти (да), това е фалшивия стол
            }
        }
    }
}
