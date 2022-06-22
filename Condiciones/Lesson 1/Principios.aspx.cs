using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Condiciones.Lesson_1
{//==================================== INICIO del namespace ====================================//
	public partial class Principios : System.Web.UI.Page
	{//===================================== INICIO de la Clase =====================================//
		protected void Page_Load(object sender, EventArgs e)
		{//======================================= INICIO del Load =======================================//
			double var_edad;

			var_edad = 15;

			if(var_edad >= 18)
			{
				Obj_Resultado.Text = "Mayor de Edad";  // ========================= Obj = forma de definor que es un objeto =================================//
			}
			else
			{
				Obj_Resultado.Text = "Menor de Edad";
			}
		}//=======================================    FIN del Load =======================================//
	}//=====================================    FIN de la Clase =====================================//
}//====================================    FIN del namespace ====================================//