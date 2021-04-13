using Assets.Decorator.Experiment.Interfaces;
using Assets.Decorator.Experiment_2.Interfaces;
using Assets.Decorator.Experiment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IComponent = Assets.Decorator.Experiment2.Interfaces.IComponent;

namespace Assets.Decorator.Experiment_2.Concrete.Base
{
	public class Base_Component : IBase_Component
	{
		public string name;
		public List<IComponent> children;
		public int depth;

		public Base_Component(string name, List<IComponent> children = null)
		{
			this.name = name;

			if(children == null)
			{
				children = new List<IComponent>();
			}
			this.children = children;
		}

		public IComponent Clone()
		{
			return this;
		}

		public int Depth()
		{
			return depth;
		}

		public IComponent[] Get_All_Children()
		{
			return children.ToArray();
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

		public IComponent[] Get_My_Children()
		{
			return children.ToArray();
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
	}
}
