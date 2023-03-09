using GrillaFromBindingList.Models;
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

			dataGridView1.DataSource = datos;
		}

		private void orderDataGrid(string name, int indexOfColumn)
		{
			
			switch (name)
			{
				case "nombre":
					DataGridViewRowCollection rowsnames = dataGridView1.Rows;

					List<string> lst_names = new List<string>();

					for (int i = 0; i < rowsnames.Count; i++)					
						 lst_names.Add((string)rowsnames[i].Cells[indexOfColumn].Value);

					List<string> orderlist = lst_names.OrderBy(x => x).ToList();

					for (int i = 0; i < rowsnames.Count; i++)
						dataGridView1.Rows[i].Cells[indexOfColumn].Value = orderlist[i];					
				break;
				case "edad":
					DataGridViewRowCollection rowsages = dataGridView1.Rows;

					List<int> lst_ages = new List<int>();

					for (int i = 0; i < rowsages.Count; i++)
						lst_ages.Add((int)rowsages[i].Cells[indexOfColumn].Value);

					List<int> orderlistAges = lst_ages.OrderBy(x => x).ToList();

					for (int i = 0; i < rowsages.Count; i++)
						dataGridView1.Rows[i].Cells[indexOfColumn].Value = orderlistAges[i];
					break;
				case "nacimiento":
					DataGridViewRowCollection rowsborns = dataGridView1.Rows;

					List<DateTime> lst_borns = new List<DateTime>();

					for (int i = 0; i < rowsborns.Count; i++)
						lst_borns.Add((DateTime)rowsborns[i].Cells[indexOfColumn].Value);

					List<DateTime> orderlistBorns = lst_borns.OrderBy(x => x).ToList();

					for (int i = 0; i < rowsborns.Count; i++)
						dataGridView1.Rows[i].Cells[indexOfColumn].Value = orderlistBorns[i];
					break;
				case "altura":
					DataGridViewRowCollection rowssices = dataGridView1.Rows;

					List<long> lst_sices = new List<long>();

					for (int i = 0; i < rowssices.Count; i++)
						lst_sices.Add((long)rowssices[i].Cells[indexOfColumn].Value);

					List<long> orderlistSices = lst_sices.OrderBy(x => x).ToList();

					for (int i = 0; i < rowssices.Count; i++)
						dataGridView1.Rows[i].Cells[indexOfColumn].Value = orderlistSices[i];
					break;
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

			string selectedColumn = dataGridView1.Columns[e.ColumnIndex].Name;
			int indexRowOfColumn = dataGridView1.Columns[e.ColumnIndex].Index;

			orderDataGrid(selectedColumn, indexRowOfColumn);
		}
	}
}
