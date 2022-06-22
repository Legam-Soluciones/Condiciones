using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Condiciones
{
	public partial class Promedio : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			double v_nota_1;
			double v_nota_2;
			double v_nota_3;
			double v_promedio;

			v_nota_1 = 100;
			v_nota_2 = 100;
			v_nota_3 = 100;
			v_promedio = (v_nota_1 + v_nota_2 + v_nota_3) / 3;

			// Obj_Resultado.Text = v_promedio.ToString();

			if (v_promedio >= 70)
			{
				Obj_Resultado.Text = "Aprobado";
			}
			else
			{
				Obj_Resultado.Text = "Reprobado";
			}



		}
	}
}