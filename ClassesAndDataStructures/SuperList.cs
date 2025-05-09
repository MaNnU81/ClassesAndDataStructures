﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    internal class SuperList<T>
    {
        private T[] _realArray;

        public SuperList()
        {
            _realArray = [];
        }

        public void Push(T item)
        {
            var originialLenght = _realArray.Length;
            var newArray = new T[originialLenght + 1];
            for (int i = 0; i < originialLenght; i++)
            {
                newArray[i] = _realArray[i];
            }
            newArray[originialLenght] = item;

            _realArray = newArray;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _realArray[index];
        }

        public T Pop()
        {
            int originialLenght = _realArray.Length;
            int newArrayLength = originialLenght - 1;
            var newArray = new T[newArrayLength];
            T element = _realArray[originialLenght - 1];

            for (int i = 0; i < newArrayLength; i++)
            {
                newArray[i] = _realArray[i];
            }
            _realArray = newArray;
            return element;
        }

       

        public void  Delete<T>(ref T[] array, int index)   //delete in js cancella una value senza cancellare l'indice e senza riportare il value eliminato.
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Indice fuori dai limiti dell'array.");
            }

            array[index] = default(T); // Imposta a "default" Se T è un valore (int, float)  diventa 0, se String diventa null
        }




    }
}


//nuovo progetto, classe studente uguale + array interi di marks, funzione per calcolare media, creare nuovo studente e printare nuovo studente.  


//2 creare molti studenti ciclare e printare solo le medie degli studenti

//3 andare a creare scheda studente toSting() compresa media e printare     quella.