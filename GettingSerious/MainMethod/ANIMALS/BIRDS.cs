﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod.ANIMALS
{
    class BIRDS
    { 
        //variables/xteristics of object BIRDS

        int LEGS = 2;
        int EYES = 2;
        int WINGS = 2;
        int BEAK = 1;

        // method = performance or actions of the objec RUN  

        public void RUN()
        {
            Console.WriteLine("My LEGS can Run");
        }

        public void FLY()
        {
            Console.WriteLine("My WINGS can certianly flap and fly");
        
        }

        public void SING()
        {
            Console.WriteLine("My Beak can produce some fine tunes");
        }

        public void MakeAnnoyingNoises()
        {
            Console.WriteLine("Sometimes I can also MakeAnnoyingNoises");
        }
    }
}
