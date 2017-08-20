using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_6B.Libreria
{
    public class Metodos
    {
        /// <summary>
        /// Metodo publico que envia salido
        /// </summary>
        /// <returns>una cadena</returns>
        public string Saludar()
        {
            return "Hola Mundo";
        }
        /// <summary>
        /// Fincion que realiza la suma de 2 numeros
        /// </summary>
        /// <param name="valor1">flotante</param>
        /// <param name="valor2">flotante</param>
        /// <returns>resultado flotante</returns>
        public float sumar(float valor1, float valor2)
    {
      var resultado=valor1+valor2;
      return resultado;

    }
        /// <summary>
        /// Fincion que realiza la resta de 2 numeros
        /// </summary>
        /// <param name="valor1">flotante</param>
        /// <param name="valor2">flotante</param>
        /// <returns>resultado flotante</returns>
        public float resta(float valor1, float valor2)
        {
            var resultado = valor1 - valor2;
            return resultado;

        }
        /// <summary>
        /// Fincion que realiza la multiplicacion de 2 numeros
        /// </summary>
        /// <param name="valor1">flotante</param>
        /// <param name="valor2">flotante</param>
        /// <returns>resultado flotante</returns>
        public float multiplicacion(float valor1, float valor2)
        {
            var resultado = valor1 * valor2;
            return resultado;

        }
        /// <summary>
        /// Fincion que realiza la division de 2 numeros
        /// </summary>
        /// <param name="valor1">flotante</param>
        /// <param name="valor2">flotante</param>
        /// <returns>resultado flotante</returns>
        public float division(float valor1, float valor2)
        {
            var resultado = valor1 / valor2;
            return resultado;

        }
   
    }
}
