using Assets.Decorator.Experiment.Interfaces;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Decorator.Experiment.Concrete
{
	public class Decorator_Implementation : IComponent, ICan_Add_Children
	{
		List<GameObject> actual_Children;
		List<GameObject> children;
		IComponent base_Component;

		public Decorator_Implementation(List<GameObject> children, IComponent base_Component)
		{
			actual_Children = children;
			this.children = children;
			this.base_Component = base_Component;
		}

		public List<GameObject> Get_All_Children()
		{
			Add_Children();
			return children;
		}
		public void Add_Children()
		{
			children.AddRange(base_Component.Get_All_Children().Except(children));
		}

		public T[] Get_My_Children_Of_Type<T>()
		{
			int count = actual_Children.Count;
			T[] temp = new T[count];
			for (int i = 0; i < count; i++)
			{
				if(actual_Children[i] is T type)
				{
					temp[i] = type;
				}
			}

			return temp;
		}

		public T[] Get_All_Children_Of_Type<T>()
		{
			List<T> temp = new List<T>();
			Add_Children();
			int count = Get_All_Children().Count;

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
