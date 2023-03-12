using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_4._7_REPASO___REPETIDOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // nº intro x el usuario
            string[] numerosString = txt_Moda.Text.Split(',');
            int[] numeros = new int[numerosString.Length];
            for (int i = 0; i < numerosString.Length; i++)
            {
                numeros[i] = Convert.ToInt32(numerosString[i]);
            }

            // array
            Dictionary<int, int> frecuencias = new Dictionary<int, int>();
            foreach (int numero in numeros)
            {
                if (frecuencias.ContainsKey(numero))
                {
                    frecuencias[numero]++;
                }
                else
                {
                    frecuencias[numero] = 1;
                }
            }

            int maximo = frecuencias.Values.Max();
            List<int> moda = new List<int>();
            foreach (KeyValuePair<int, int> kvp in frecuencias)
            {
                if (kvp.Value == maximo)
                {
                    moda.Add(kvp.Key);
                }
            }

            // Muestra el resultad
            if (moda.Count == 1)
            {
                MessageBox.Show($"El número que más se repite es el {moda[0]}");
            }
            else
            {
                string numerosModa = string.Join(", ", moda);
                MessageBox.Show($"Los números que más se repiten son: {numerosModa}");
            }
        }

    }
}
