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

        public void Agregar(Nodo nuevo) {
			if (raiz == null)
			{
				raiz = nuevo;
			}
			else {
				agregar(nuevo, raiz);
			}
		}

		private void Agregar(Nodo nuevo, Nodo padre) {
			if (nuevo<padre.informacionNodo)
			{
				if (padre.izquierda == null)
				{
					padre.izquierda = nuevo;
				}
				else
				{
					agregar(nuevo, padre.izquierda);
				}
			}
			else
			{
				if (padre.derecha==null)
				{
					padre.derecha = nuevo;
				}
				else
				{
					agregar(nuevo, padre.derecha);
				}
			}
		}

        public string InOrden(Nodo raiz)
        {
            string salida = "";
            if(raiz.izquierda != null)
            {
                salida += InOrden(raiz.izquierda);
            }
            salida += raiz.ToString();
            if(raiz.derecha != null)
            {
                salida += InOrden(raiz.derecha);
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
