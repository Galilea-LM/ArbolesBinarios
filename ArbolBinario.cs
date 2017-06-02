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

        public void Insertar(int informacionNodo)
        {
            Nodo nuevo = new Nodo();
            nuevo.informacionNodo = informacionNodo;
            nuevo.izquierda = null;
            nuevo.derecha = null;
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                Nodo anterior = null, reco;
                reco = raiz; 
                while(reco != null)
                {
                    anterior = reco;
                    if (informacionNodo < reco.informacionNodo)
                    {
                        reco = reco.izquierda;
                    }
                    else
                    {
                        reco = reco.derecha;
                    }
                }
                if (informacionNodo < anterior.informacionNodo)
                {
                    anterior.izquierda = nuevo;
                }
                else
                {
                    anterior.derecha = nuevo;
                }
            }
        }

        public string InOrden(Nodo r)
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

        public string PreOrden(Nodo raiz)
        {
            string salida = "";
            salida += raiz.ToString();
            if (raiz.izquierda != null)
            {
                salida += InOrden(raiz.izquierda);
            }
            if (raiz.derecha != null)
            {
                salida += InOrden(raiz.derecha);
            }
            return salida;


        }

        public string PosOrden(Nodo raiz)
        {
            string salida = "";
            //I
            if (raiz.izquierda != null)
            {
                salida += InOrden(raiz.izquierda);
            }
            //D
            if (raiz.derecha != null)
            {
                salida += InOrden(raiz.derecha);
            }
            //R
            salida += raiz.ToString();
            return salida;

        }

    }
}
