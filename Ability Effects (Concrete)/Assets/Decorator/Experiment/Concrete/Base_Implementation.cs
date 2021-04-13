using Assets.Decorator.Experiment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Decorator.Experiment.Concrete
{

	public class Base_Implementation : IComponent
	{
		public List<GameObject> children;

		public Base_Implementation(List<GameObject> children)
		{
			this.children = children;
		}

		public List<GameObject> Get_All_Children()
		{
			return children;
		}

		public T[] Get_My_Children_Of_Type<T>()
		{
			List<T> temp = new List<T>();
			int count = children.Count;
			for (int i = 0; i < count; i++)
			{
				if (children[i] is T type)
				{
					temp[i] = type;
				}
			}

			return temp.ToArray();
		}
		public T[] Get_All_Children_Of_Type<T>()
		{
			List<T> temp = new List<T>();
			int count = children.Count;
			for (int i = 0; i < count; i++)
			{
				if (children[i] is T type)
				{
					temp[i] = type;
				}
			}

			return temp.ToArray();
		}
	}
}
