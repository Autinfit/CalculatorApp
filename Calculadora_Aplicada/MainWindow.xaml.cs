using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora_Aplicada
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // CREAREMOS NUEVAS VARIABLES PARA INCLUIR 2 NÚMEROS MÁS SU RESULTADO FINAL..

        double numero1; // PRIMER NÚMERO A REALIZAR DICHA OPERACIÓN.
        double numero2; // SEGUNDO NÚMERO A REALIZAR DICHA OPERACIÓN.
        double resultadoFinal; // RESULTADO TRAS REALIZAR UNA OPERACIÓN CON 2 NÚMEROS INGRESADOS MANUALMENTE EN LA INTERFAZ.

        public MainWindow()
        {
            InitializeComponent();

            // EN ESTE PROYECTO SOLAMENTE SE CREA UN EMULADOR DE CALCULADORAS MEDIANTE ARCHIVO .XAML!
        }

        private void SumarNumeros(object sender, RoutedEventArgs e)
        {
            // ESTE EVENTO CORRESPONDE MEDIANTE UN BOTÓN PARA PODER SUMAR 2 NÚMEROS...

            // INGRESAMOS 2 NÚMEROS A EFECTUAR DICHA OPERACIÓN...

            numero1 = Convert.ToDouble(variableA.Text); // EL PRIMER NÚMERO SE VERIFICA CON UN DOUBLE A INGRESAR EN LA INTERFAZ.
            numero2 = Convert.ToDouble(variableB.Text); // EL SEGUNDO NÚMERO SE VERIFICA CON UN DOUBLE A INGRESAR EN LA INTERFAZ.

            // LUEGO DE INGRESAR ESTOS NÚMEROS, SE DESPLIEGA UN RESULTADO FINAL AHÍ MISMO...

            resultadoFinal = numero1 + numero2;

            // EN ESTE TEXTO, LUEGO DE HABER REALIZADO ESTE PROCEDIMIENTO, SE MOSTRARÁ UN TEXTO ESTE RESULTADO...

            Resultados.Content = resultadoFinal.ToString();

        }

        private void RestarNumeros(object sender, RoutedEventArgs e)
        {
            // ESTE EVENTO CORRESPONDE MEDIANTE UN BOTÓN PARA PODER RESTAR 2 NÚMEROS...

            // INGRESAMOS 2 NÚMEROS A EFECTUAR DICHA OPERACIÓN...

            numero1 = Convert.ToDouble(variableA.Text); // EL PRIMER NÚMERO SE VERIFICA CON UN DOUBLE A INGRESAR EN LA INTERFAZ.
            numero2 = Convert.ToDouble(variableB.Text); // EL SEGUNDO NÚMERO SE VERIFICA CON UN DOUBLE A INGRESAR EN LA INTERFAZ.

            // LUEGO DE INGRESAR ESTOS NÚMEROS, SE DESPLIEGA UN RESULTADO FINAL AHÍ MISMO...

            resultadoFinal = numero1 - numero2; // RESTA TOTAL DE 2 NÚMEROS.

            // EN ESTE TEXTO, LUEGO DE HABER REALIZADO ESTE PROCEDIMIENTO, SE MOSTRARÁ UN TEXTO ESTE RESULTADO...

            Resultados.Content = resultadoFinal.ToString();
        }

        private void MultiplicarNumeros(object sender, RoutedEventArgs e)
        {
            // ESTE EVENTO CORRESPONDE MEDIANTE UN BOTÓN PARA PODER MULTIPLICAR 2 NÚMEROS...

            // EN INSTANTES...
        }

        private void DividirNumeros(object sender, RoutedEventArgs e)
        {
            // ESTE EVENTO CORRESPONDE MEDIANTE UN BOTÓN PARA PODER DIVIDIR 2 NÚMEROS...

            // EN INSTANTES...
        }
    }
}
