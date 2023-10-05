using System.Text;
using System.Text.RegularExpressions;

namespace Compiladores1
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        #region ENTREGA 1
        public static string ConvertirAPosfija(string expresionRegular)
        {
            string expresionPosfija = "";
            Stack<char> pilaOperadores = new Stack<char>();

            foreach (char caracter in expresionRegular)
            {
                switch(caracter)
                {
                    case '(':
                        pilaOperadores.Push(caracter);
                        break;
                    case ')':
                        while(pilaOperadores.Count > 0 && pilaOperadores.Peek() != '(')
                            expresionPosfija += pilaOperadores.Pop();
                        pilaOperadores.Pop();
                        break;
                    default:
                        if (Char.IsLetterOrDigit(caracter))
                            expresionPosfija += caracter;
                        else if (Precedencia(caracter) != 0)
                        {
                            bool band = true;
                            while(band)
                            {
                                if (pilaOperadores.Count == 0 ||
                                   pilaOperadores.Peek() == '(' ||
                                   Precedencia(caracter) > Precedencia(pilaOperadores.Peek()))
                                {
                                    pilaOperadores.Push(caracter);
                                    band = false;
                                } else
                                    expresionPosfija += pilaOperadores.Pop();
                            }
                        }

                        break;
                }
            }

            while (pilaOperadores.Count > 0)
            {
                expresionPosfija += pilaOperadores.Pop();
            }

            return expresionPosfija.ToString();
        }

        public static string ExpansionAlternativas(string alternativas)
        {
            string resultado = "";
            int caracterInicial = (int)alternativas[0];
            int caracterFinal = (int)alternativas[2]; // a - z <--- ESTA, EL CAST INT NOS VA EL VALOR DE CARACTER A ASCII 

            //EXPANDIR [XX-XX] POR VALOR ASCII
            for (int caracter = caracterInicial; caracter <= caracterFinal; caracter++)
            {
                resultado += (char)caracter;
                if (caracter != caracterFinal)
                    resultado += '|';
            }
            return '(' + resultado + ')';
        }

        public static string SeleccionAlternativas(string cadena)
        {
            string resultado = "";

            if (cadena[0] == '[')
            {
                resultado = cadena.Split('[', ']')[1]; //QUITA LOS CORCHETES A ESA PARTE DE LA CADENA DEJANDO UNICAMENTE LAS LETRAS
                resultado = string.Join('|', resultado.ToList()); //AGREGA EL '|' A LAS LETRAS EN MEDIO DE FORMA AUTOMATICA
            } else if(cadena[0] == '(')// SI TIENE PARENTESIS HACE LO MISMO PERO COLOCANDO UN &
            {
                resultado = cadena.Split('(', ')')[1];
                resultado = string.Join('&', resultado.ToList());
            }

            return '(' + resultado + ')';//AGREGA LOS PARENTESIS DE INICIO Y FIN
        }

        public static string convierteExplicita(string expresionRegular)
        {
            string expresionExplicita = "";
            
            for (int posicion = 0; posicion < expresionRegular.Length; posicion++)
            {
                if (expresionRegular[posicion] == '[')//SI ES CORCHETE
                {
                    string cadenaSeleccionAlt = expresionRegular.Substring(//HACE SUB CADENA DE LA CADENA ORIGINAL
                        posicion + 1, //POSICION INICIAL
                        expresionRegular.Substring(posicion).IndexOf(']') - 1); //TOMA LA CANTIDAD DE CARACTERES QUE SE DESEAN
                    if (expresionExplicita != "" && expresionExplicita.Last() == ')')//CONNDICION ]( SE AGREGA &
                        expresionExplicita += '&';
                    if (cadenaSeleccionAlt.Contains('-')) // - SE EXPANDE SI NO TIENE SOLO SE AGREGA |
                        expresionExplicita += ExpansionAlternativas(cadenaSeleccionAlt);
                    else
                        expresionExplicita += SeleccionAlternativas('[' + cadenaSeleccionAlt + ']');
                    posicion += cadenaSeleccionAlt.Length + 1;
                }
                else if (expresionRegular[posicion] == '(') //SI ES PARENTESIS
                {
                    string cadenaSeleccionAlt = expresionRegular.Substring( //EXTRAE SUBCADENA QUE ESTA DENTRO DEL PARENTESIS
                        posicion + 1,
                        expresionRegular.Substring(posicion).IndexOf(')') - 1);
                    if (expresionExplicita != "" && expresionExplicita.Last() == ')') //)(
                        expresionExplicita += '&';
                    if (cadenaSeleccionAlt.Contains('|')     || //ADENTRO DEL PARENTESIS HAY MAS EXPRESIONES?
                       cadenaSeleccionAlt.Contains('[')     ||
                       cadenaSeleccionAlt.Contains('*')     ||
                       cadenaSeleccionAlt.Contains('+')     ||
                       cadenaSeleccionAlt.Contains('?')     ||
                       cadenaSeleccionAlt.Contains('('))
                    {
                        expresionExplicita += '(' + convierteExplicita(cadenaSeleccionAlt) + ')';//LLAMADA RECURSIVA
                    } else
                    {
                        expresionExplicita += SeleccionAlternativas('(' + cadenaSeleccionAlt + ')'); // SI NO TIENE NADA DE LO ANTERIOR SOLO AGREGA &
                    }
                    posicion += cadenaSeleccionAlt.Length + 1; //RECORRE EL APUNTADOR HASTA EL SIGUIENTE CARACTER DESPUES DE CERRAR EL PARENTESIS
                }
                //CONDICIONES PARA &
                else if(posicion != expresionRegular.Length - 1)// NO HA LLEGADO AL FINAL DE LA EXPRESION
                {
                    if ((expresionRegular[posicion] == '?' && expresionRegular[posicion + 1] != '|') || 
                        (expresionRegular[posicion] == '+' && expresionRegular[posicion + 1] != '|') || 
                        (expresionRegular[posicion] == '*' && expresionRegular[posicion + 1] != '|') ||
                        Char.IsLetter(expresionRegular[posicion]) &&
                        (Char.IsLetter(expresionRegular[posicion + 1]) ||
                        expresionRegular[posicion + 1] == '(' ||
                        expresionRegular[posicion + 1] == '['))
                    {
                        expresionExplicita += expresionRegular[posicion];
                        expresionExplicita += '&';
                    }
                    //SI NO SE CUMPLE NADA DE LO ANTERIOR SOLO AGREGA &
                    else
                        expresionExplicita += expresionRegular[posicion];
                }
                else
                    expresionExplicita += expresionRegular[posicion];
            }
            return expresionExplicita;
        }

        //PRIORIDAD DE LOS OPERADORES
        public static int Precedencia(char operador)
        {
            if (operador == '?' || operador == '*' || operador == '+')
                return 3;
            else if (operador == '&')
                return 2;
            else if (operador == '|')
                return 1;
            else return 0;
        }
        #endregion
    }
}