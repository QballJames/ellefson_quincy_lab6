/*
 * Author: Quincy Ellefson
 * 
 * Program Title:ellefson_quincy_lab6
 * 
 * File Description:
 *          This is a simple temperature calculator that allows the user to select Celcius,
 *          Farhenheit, or Kelvin and convert it to the other two units. There's also a 
 *          pictureBox that displays the general temperature ie. if it's hot the guage is red
 *          if it's cold the guage is blue. 
 * 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ellefson_quincy_lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void numberboxTempValue_ValueChanged(object sender, EventArgs e)//ValueChanged updates every time the value is changed so it made sense to me to put everything here
        {
            int selected = comboUnits.SelectedIndex;//0=Celcius, 1 = Farhenheit, 2= Kelvin

            decimal currentTemp = numberboxTempValue.Value;//annotating the decimal for the current temperature
            double tempDouble;

            tempDouble = Convert.ToDouble(currentTemp);//Creating a double from the currentTemp so math is easier

            if (selected is 0) //if and else if statement for selection from the comboUnits, celcius selection
            {
                double value1 = (tempDouble * 1.8) + 32; //celcious to farhenheit using value1 variable
                lblConversion1Value.Text = Convert.ToString(value1 + "°. Farhenheit.");//converts value1 to a string and outputs it in value1

                if (value1 >= 95)//else if statement to check farhenheit temperature and select the correct image
                {
                    imageTempGauge.Image = Properties.Resources.tempHot;
                }
                else if(value1 > 75 && value1 < 95)
                {
                    imageTempGauge.Image = Properties.Resources.tempWarm;
                }
                else if (value1 > 55 && value1 < 75)
                {
                    imageTempGauge.Image = Properties.Resources.tempMild;
                }
                else if (value1 > 33 && value1 < 55)
                {
                    imageTempGauge.Image = Properties.Resources.tempCold;
                }
                else if (value1 < 33)
                {
                    imageTempGauge.Image = Properties.Resources.tempFreezing;
                }
                else
                {

                }

                double value2 = (tempDouble + 273.15);//celcius to kelvin
                lblConversion2Value.Text = Convert.ToString(value2 + "°. Kelvin.");//kelvin output
                }

            else if (selected is 1)//Farhenheit selection
            {

                if (currentTemp >= 95)//else if statement to check farhenheit temperature and select the correct image
                {
                    imageTempGauge.Image = Properties.Resources.tempHot;
                }
                else if (currentTemp > 75 && currentTemp < 95)
                {
                    imageTempGauge.Image = Properties.Resources.tempWarm;
                }
                else if (currentTemp > 55 && currentTemp < 75)
                {
                    imageTempGauge.Image = Properties.Resources.tempMild;
                }
                else if (currentTemp > 33 && currentTemp < 55)
                {
                    imageTempGauge.Image = Properties.Resources.tempCold;
                }
                else if (currentTemp < 33)
                {
                    imageTempGauge.Image = Properties.Resources.tempFreezing;
                }
                else
                {

                }

                double value1 = (tempDouble - 32) / 1.8;//Farhenheit to Celcius

                lblConversion1Value.Text = Convert.ToString(value1 + "°. Celcius.");//Celcius output

                double value2 = (tempDouble - 32) * .556 + 273.15;//Farhenheit to Kelvin

                lblConversion2Value.Text = Convert.ToString(value2 + "°. Kelvin.");//Kelvin output
            }

            else if (selected is 2)//kelvin selection
            {

                if (currentTemp >= 0)//checking to make sure they havent selected a negative number
                {
                
                double value1 = (tempDouble - 273.15) * 1.8 + 32;//caluclation for fahrenheit

                    lblConversion1Value.Text = Convert.ToString(value1 + "°. Farhenheit.");//Farhenheit output

                    if (value1 >= 95)//else if statement to check farhenheit temperature and select the correct image
                    {
                        imageTempGauge.Image = Properties.Resources.tempHot;
                    }
                    else if (value1 > 75 && value1 < 95)
                    {
                        imageTempGauge.Image = Properties.Resources.tempWarm;
                    }
                    else if (value1 > 55 && value1 < 75)
                    {
                        imageTempGauge.Image = Properties.Resources.tempMild;
                    }
                    else if (value1 > 33 && value1 < 55)
                    {
                        imageTempGauge.Image = Properties.Resources.tempCold;
                    }
                    else if (value1 < 33)
                    {
                        imageTempGauge.Image = Properties.Resources.tempFreezing;
                    }
                    else
                    {

                    }
                    
                    double value2 = (tempDouble - 273.15);//Kelvin to Celcius

                    lblConversion2Value.Text = Convert.ToString(value2) + "°. Celcius.";//Celcius output
                }
                else //if number is negative
                {
                    numberboxTempValue.Value = 0;//resets numberbox to 0 
                    
                    MessageBox.Show("This Kelvin value is less than 0.", "Error", MessageBoxButtons.OK);//dialouge explaining what happened
                    if (DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                    
            }
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
