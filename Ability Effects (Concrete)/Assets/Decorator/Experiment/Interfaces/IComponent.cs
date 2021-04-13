using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Decorator.Experiment.Interfaces
{
	public interface IComponent
	{
		List<GameObject> Get_All_Children();
		T[] Get_My_Children_Of_Type<T>();
		T[] Get_All_Children_Of_Type<T>();
	}
}
