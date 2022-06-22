using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Condiciones
{//==================================== INICIO del namespace ====================================//
	public partial class Promedio3 : System.Web.UI.Page
	{//===================================== INICIO de la Clase =====================================//
		protected void Page_Load(object sender, EventArgs e)
		{//======================================= INICIO del Load =======================================//
			double v_nota_1;
			double v_nota_2;
			double v_nota_3;
			double v_pronedio;

			v_nota_1 = 65;
			v_nota_2 = 65;
			v_nota_3 = 65;
			v_pronedio = ((v_nota_1 + v_nota_2 + v_nota_3) / 3);
			//===================================== INICIO del If =====================================//
			if (v_pronedio >= 70)
			{
				Obj_Resultado.Text = "Aprobado";
			}
			else if (v_pronedio >= 60)
			{
				Obj_Resultado.Text = "Extraordinario";
			}
			else
			{
				Obj_Resultado.Text = "Reprobado";
			}//===================================== FIN del If =====================================//
		}//=======================================    FIN del Load =======================================//
	}//=====================================    FIN de la Clase =====================================//
}//====================================    FIN del namespace ====================================//