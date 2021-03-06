﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace _7._1._56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs ev)
        {
            
            try
            {
                string arrayStr = this.InputArray.Text; //Считываем строку в массив 
                int[] arr = IOUtils.ConvertStringToArray(arrayStr);//Преобразовываем строку в массив

                if (arr.Length == 0)
                {
                    throw new Exception("Массив не задан");
                }

                ArrayUtils utils = new ArrayUtils(arr);//создание объекта класса
                //вывод ответа с использованием метода этого класса
                OutputLabel.Text = utils.Sum().ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OutputText_Enter(object sender, EventArgs e)
        {

        }
    }
}
