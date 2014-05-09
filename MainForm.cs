/*
 * Created by SharpDevelop.
 * User: DANIEL
 * Date: 08/05/2014
 * Time: 06:39 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int contador = 0;
			string  estados = this.numericUpDown1.Text;
			string continente = this.comboBox1.Text;
			String nombre;
			
			
			//nombre+= "nombre: " + this.textBox1.Text + "\n";
			if (estados == "31"){
			 contador++;
			}
			if(checkBox1.Checked){
				contador++;
			}
			if(checkBox4.Checked){
				contador++;
			}
			
			if(radioButton3.Checked){
				contador++;
			}
			
			if(this.monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
				contador++;
			}
			if(continente == "Oceania"){
				contador++;
			}
			MessageBox.Show("tu calificacion es de " +contador +" de 6");
		
		
		}
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
