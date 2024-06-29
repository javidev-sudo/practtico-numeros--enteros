using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_numeros_enteros
{
    class Nenter
    {
        private int n;

        public Nenter()
        {
            n = 0;
            
        }

        public void Cargar(int date)
        {
            n = date;
        }

        public int Descargar()
        {
            return n;
        }

        public int Facto()
        {
            int nr = n;
            int i = 1; 
           

            if (n==0)
            {
                nr = 1;
            }
            else
            {
               
                
                while (i < n)
                {
                    nr = nr * (n - i);
                    i++;
                }

            }
           
            return nr;
        }


        public bool EsFibo()
        {
            int a, b, c;
            a = -1; b = 1;
            do
            {
               
                c = a + b;
                a = b;
                b = c;


            } while (!((c==n)||(c>n)));

            return ((c == n));
        }

        public bool EsExpone()
        {
            int a, c;
            a = 0;
            
            do
            {

                c = (int)(Math.Pow(2, a));
                a++;


            } while (!((c == n) || (c > n)));


           


            return  (c==n);
        }

        public bool EsMult(Nenter nu)
        {

            return (n % nu.n == 0);

        }

        public bool EsSubMult(Nenter nu)
        {

            return (nu.n % n == 0);

        }

        public int NumDig()
        {
            if (n==0)
            {
                return 1;
            }
          
            return (int)(Math.Truncate(Math.Log10(n) + 1));
        }

        public void Unir2NAs(Nenter nu, Nenter nr )
        {
            
            int expo;
            if (n < nu.n)
            {
                expo = nu.NumDig();
                nr.n = (int)(n * Math.Pow(10,expo)) + nu.n;
            }
            else
            {
                expo = this.NumDig();
                nr.n = (int)(nu.n * Math.Pow(10, expo)) + n;

            }
        }




        public void Unir3N(Nenter nu1, Nenter nu2, Nenter nr)
        {
            int menor, mayor, medio;
            int expo, aux, expo2;
            medio = 1;

            if (n==nu1.n)
            {
                medio = n;
            }
            else
            {
                medio = nu2.n;
            }

               
            if (n < nu1.n)
            {
                menor = n;
            }
            else
            {
                menor = nu1.n;
            }
            if (nu2.n < menor)
            {
                menor = nu2.n;
            }

            if (n > nu1.n)
            {
                mayor = n;
            }
            else
            {
                mayor = nu1.n;
            }
            if (nu2.n > mayor)
            {
                mayor = nu2.n;
            }

            if ((n > menor) && (n < mayor))
            {
                medio = n;
            }
            if ((nu1.n > menor) && (nu1.n < mayor))
            {
                medio = nu1.n;
            }
            if ((nu2.n > menor) && (nu2.n < mayor))
            {
                medio = nu2.n;
            }

            expo = (int)(Math.Truncate(Math.Log10(medio) + 1));

            aux = (int)((menor * Math.Pow(10, expo)) + medio);

            expo2 = (int)(Math.Truncate(Math.Log10(mayor) + 1));

            nr.n = (int)((aux * Math.Pow(10, expo2)) + mayor);

        }

        public void MayorNUm(Nenter nu1, Nenter nu2, Nenter nr)
        {
            int index;
            if (n > nu1.n)
            {
                nr.n = n;
                index = 1;

            }
            else
            {
                nr.n = nu1.n;
                index = 2;
            }
            if (nu2.n > nr.n)
            {
                nr.n = nu2.n;
                index = 3;
            }

            nr.n = index;

            
        }

        public bool VerifToNum()
        {
            int d,aux,refe;
            refe = n % 10;
            bool b = true;
            aux = n;

            while ((n>0)&&(b==true))
            {
                d = n % 10;
                n = n / 10;

                if (d!=refe)
                {
                    b = false;
                }
            }
            n = aux;
            return b;
        }

        public bool EsImpar(int dig)
        {
            return (dig % 2 != 0);
        }

        public bool VerifTodoPar()
        {
            bool b = true;
            int d, aux;
            aux = n;


            while ((n>0)&&(b==true))
            {
                d = n % 10;
                n = n / 10;
                if (EsImpar(d))
                {
                    b = false;
                }
            }
            n = aux;
            return b;
        }

       


       
    }
}
