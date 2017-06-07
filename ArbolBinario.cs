using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_ArbolesBinarios
{
    class ArbolBinario
    {
        Nodo raiz;
        public ArbolBinario()
        {
            raiz = null;
        }
        public void Agregar(Nodo nuevo)
        {

            if (raiz == null)
            {
                raiz = nuevo; 
            }
            else
            {
                Agregar(nuevo, raiz);
            }
        }

        private void Agregar(Nodo nuevo, Nodo padre)
        {
            if (nuevo.informacionNodo < padre.informacionNodo)
            {
                if (padre.izquierda == null)
                {
                    padre.izquierda = nuevo;
                }
                else
                {
                    Agregar(nuevo, padre.izquierda);
                }
            }
            else
            {
                if (padre.derecha == null)
                {
                    padre.derecha = nuevo;
                }
                else
                {
                    Agregar(nuevo, padre.derecha);
                }
            }
        }

        public Nodo Buscar(int informacion)
        {
            if (raiz == null)
            {
                return null ;
            }
            else
            {
                return Buscar(informacion,raiz);
            }

        }

        private Nodo Buscar(int informacion, Nodo x)
        {
     
            if (informacion == x.informacionNodo)
            {
                return x;
            }
            else if (informacion < x.informacionNodo)
            {
                if (x.izquierda != null)
                {
                    return Buscar(informacion, x.izquierda);
                }
                else
                {
                    return null;
                } 
            }
            else if(informacion > x.informacionNodo )
            {
                if ( x.derecha != null)
                {
                    return Buscar(informacion, x.derecha);
                }
                else
                {
                    return null;
                }
            }
            
        }

        public string IndOrden()
        {
            if (raiz == null)
            {
                return "";
            }
            else
            {
                return InOrden(raiz);
            }
  
        }
        private string InOrden(Nodo r)
        {
            string salida = "";
            if(r.izquierda != null)
            {
                salida += InOrden(r.izquierda);
            }
            salida += r.ToString();
            if(r.derecha != null)
            {
                salida += InOrden(r.derecha);
            }
            return salida;
        }
        public string PreOrden()
        {
            if (raiz == null)
            {
                return "";
            }
            else
            {
                return PreOrden(raiz);
            }
        }

        private string PreOrden(Nodo r)
        {
            string salida = "";
            salida += r.ToString();
            if (r.izquierda != null)
            {
                salida += PreOrden(r.izquierda);
            }
            if (r.derecha != null)
            {
                salida += PreOrden(r.derecha);
            }
            return salida;


        }

        public string PosOrden()
        {
            if (raiz == null)
            {
                return "";
            }
            else
            {
                return PosOrden(raiz);
            }
        }
        private string PosOrden(Nodo r)
        {
            string salida = "";
            //I
            if (r.izquierda != null)
            {
                salida +=PosOrden(r.izquierda);
            }
            //D
            if (r.derecha != null)
            {
                salida += PosOrden(r.derecha);
            }
            //R
            salida += r.ToString();
            return salida;

        }

    }
}
