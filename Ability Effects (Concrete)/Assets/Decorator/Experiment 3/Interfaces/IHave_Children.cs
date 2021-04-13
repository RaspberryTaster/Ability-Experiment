using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Decorator.Experiment_3.Interfaces
{
	public interface IHave_Children
	{
		IComponent[] Get_My_Children();
		IComponent[] Get_Children_And_Grandchildren();
		T[] Get_My_Children_Of_Type<T>();
		T[] Get_Chidlren_And_Grandchildren_of_Type<T>();
	}
}
