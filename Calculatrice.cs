using Calculatrice.classGlobale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
	public partial class Calculatrice : Form
	{
		public Calculatrice()
		{
			InitializeComponent();
		}

		//Additionne les 2 valeurs
		private void Button1_Click(object sender, EventArgs e)
		{
			if (cbBType.Text=="Decimal")
			{
				decimal rslt = nmUD1.Value + nmUD2.Value;
				this.lbRslt.Text = rslt.ToString();
			}
			else if (cbBType.Text == "Hexadecimal")
			{
				int rslt = (int)(nmUD1.Value + nmUD2.Value);
				this.lbRslt.Text = Convert.ToString(rslt, 16).ToUpper()+"(Hexadecimal)";
					
			}

		}

		//Soustraie les 2 valeurs
		private void BtMoins_Click(object sender, EventArgs e)
		{
			if (cbBType.Text == "Decimal")
			{
				decimal rslt = nmUD1.Value - nmUD2.Value;
				this.lbRslt.Text = rslt.ToString();
			}
			else if (cbBType.Text == "Hexadecimal")
			{
				int rslt = (int)(nmUD1.Value - nmUD2.Value);
				this.lbRslt.Text = Convert.ToString(rslt, 16).ToUpper() + "(Hexadecimal)";
				
			}
		}

		//Multiplie les 2 valeurs
		private void BtFois_Click(object sender, EventArgs e)
		{
			if (cbBType.Text == "Decimal")
			{
				decimal rslt = nmUD1.Value * nmUD2.Value;
				this.lbRslt.Text = rslt.ToString();
			}
			else if (cbBType.Text == "Hexadecimal")
			{
				int rslt = (int)(nmUD1.Value * nmUD2.Value);
				this.lbRslt.Text = Convert.ToString(rslt, 16).ToUpper() + "(Hexadecimal)";
				
			}
		}

		//Diviser les 2 valeurs
		private void BtDiviser_Click(object sender, EventArgs e)
		{
			if (nmUD2.Value != 0)
			{
				if (cbBType.Text == "Decimal")
				{
					decimal rslt = nmUD1.Value / nmUD2.Value;
					this.lbRslt.Text = rslt.ToString();
				}
				else if (cbBType.Text == "Hexadecimal")
				{
					int rslt = (int)(nmUD1.Value / nmUD2.Value);
					this.lbRslt.Text = Convert.ToString(rslt, 16).ToUpper() + "(Hexadecimal)";
					
				}
			}
			else
			{
				MessageBox.Show(" division par 0 est impossible");
			}
		}

		private void Calculatrice_Load(object sender, EventArgs e)
		{
			cbBType.SelectedIndex = ClassConstante.iValeurIndice_ChoixCalculatrice_Dec;
		}

		//Quand on change l'index de la combobox avec decimal et hexadecimal on change le type de nombre
		private void CbBType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbBType.SelectedIndex == ClassConstante.iValeurIndice_ChoixCalculatrice_Hex)
			{
				this.nmUD1.Hexadecimal = true;
				this.nmUD2.Hexadecimal = true;
				this.nmUD1.DecimalPlaces=ClassConstante.iNombreDecimalesChoixCalculatrice_Hex;
				this.nmUD2.DecimalPlaces = ClassConstante.iNombreDecimalesChoixCalculatrice_Hex;
			}
			else
			{
				this.nmUD1.Hexadecimal = false;
				this.nmUD2.Hexadecimal = false;
				this.nmUD1.DecimalPlaces = ClassConstante.iNombreDecimalesChoixCalculatrice_Dec;
				this.nmUD2.DecimalPlaces = ClassConstante.iNombreDecimalesChoixCalculatrice_Dec
					
					;
			}
			lbRslt.Text = "";
		}
	}
}
