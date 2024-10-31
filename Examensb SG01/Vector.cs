using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examensb
{
    class Vector
    {
        const int MAX = 50;
        private int[] v;
        private int n;

        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void Cargar(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void cargardato(int nele)
        {
            n = nele;
            int num = n;
            for (int i = 1; i <= num; i++)
            {
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }

        public string Descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }






        //pregunta 1 
        public void EliminarRepetidos()
        {
            int i = 0;
      
            while (i < n)
            {
                int elem = v[i];
                int count = 0;

             
                for (int j = 0; j < n; j++)
                {
                    if (v[j] == elem)
                    {
                        count++;
                    }
                }

           
                if (count > 1)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (v[j] == elem)
                        {
                           
                            for (int k = j; k < n -1 ; k++)
                            {
                                v[k] = v[k + 1];
                            }
                            n--; 
                            j--; 
                        }
                    }
                }
                else
                {
                    i++; 
                }
            }

            n = n - 1;
        }









        //PREGUNTA 2
        public void pregunta2(Vector e, Vector f, int a, int b)
        {
            int num, c1;
            num = n;
            e.n = 0;
            c1 = 0;

            OrdBurbuja(a, b);

            for (int i = a; i <= b; i++)
            {
                if ((v[i] != v[i + 1]) || (i == b))
                {
                    c1++;
                    e.v[c1] = v[i];
                    f.v[c1] = frec_elem_segmento(v[i], a, b);
                }
            }

            e.n = c1;
            f.n = c1;
        }

        public void OrdBurbuja(int a, int b)
        {
            int num = n;

            checked
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = i + 1; j <= b; j++)
                    {
                        if (v[i] < v[j])
                        {
                            Intercambio(i, j);
                        }
                    }
                }
            }
        }

        public void Intercambio(int a, int b)
        {
            int aux;
            aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }

        public int frec_elem_segmento(int elem, int a, int b)
        {
            int c = 0;

            checked
            {
                for (int i = a; i <= b; i++)
                {
                    if (elem == v[i])
                    {
                        c++;
                    }
                }
                return c;
            }
        }



    }
}
