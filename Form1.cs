using GrillaFromBindingList.Models;
using GrillaFromBindingList.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GrillaFromBindingList
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List<Datos> datos = new List<Datos>
			{
				new Datos()
				{
					altura = 105,
					edad = 55,
					nacimiento = DateTime.ParseExact("3/3/2023", "M/d/yyyy", CultureInfo.InvariantCulture),
					nombre = "pepe"				
				},								
				new Datos()						
				{								
					altura = 132,				
					edad = 16,					
					nacimiento = DateTime.ParseExact("2/3/2023", "M/d/yyyy", CultureInfo.InvariantCulture),
					nombre = "juana"			
				},								
				new Datos()						
				{								
					altura = 115,				
					edad = 15,					
					nacimiento = DateTime.ParseExact("5/7/2022", "M/d/yyyy", CultureInfo.InvariantCulture),
					nombre = "ignacio"			
				},								
				new Datos()						
				{								
					altura = 110,				
					edad = 8,					
					nacimiento = DateTime.ParseExact("6/6/2021", "M/d/yyyy", CultureInfo.InvariantCulture),
					nombre = "noha"				
				},								
				new Datos()						
				{								
					altura = 180,				
					edad = 90,					
					nacimiento = DateTime.ParseExact("1/2/2020", "M/d/yyyy", CultureInfo.InvariantCulture),
					nombre = "alejandro"
				},

			};

			dataGridView1.DataSource = new MySortableBindingList<Datos>(datos);
		}		
	}
}
