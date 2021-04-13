using Assets.Decorator.Experiment_2.Interfaces;
using Assets.Decorator.Experiment2.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Decorator.Experiment_2.Concrete.Base
{
	public class Decorator_Component : IBase_Component, ICan_Add_Children
	{
		public string name;
		public int depth;
		public IBase_Component base_Component;
		public List<IComponent> my_Children = new List<IComponent>();
		private List<IComponent> all_Children = new List<IComponent>();

		public Decorator_Component(string name, IBase_Component base_Component, List<IComponent> my_Children = null)
		{
			this.name = name;
			this.base_Component = base_Component;
			if(my_Children == null)
			{
				my_Children = new List<IComponent>();
			}
			this.my_Children = my_Children;
		}

		public void Add_Children()
		{
			if (all_Children == null || base_Component == null) return;
			all_Children.AddRange(base_Component.Get_All_Children().Except(all_Children));
		}

		public IComponent Clone()
		{
			return this;
		}

		public int Depth()
		{
			int temp = base_Component.Depth() + depth;
			return temp;
		}

		public IComponent[] Get_All_Children()
		{
			Add_Children();
			return all_Children.ToArray();
		}

		public T[] Get_All_Children_Of_Type<T>()
		{
			List<T> temp = new List<T>();
			int count = Get_All_Children().Length;
			for (int i = 0; i < count; i++)
			{
				if (my_Children[i] is T type)
				{
					temp[i] = type;
				}
			}

			return temp.ToArray();
		}

		public IComponent[] Get_My_Children()
		{
			return my_Children.ToArray();
		}

		public T[] Get_My_Children_Of_Type<T>()
		{
			List<T> temp = new List<T>();
			int count = my_Children.Count;
			for (int i = 0; i < count; i++)
			{
				if (my_Children[i] is T type)
				{
					temp[i] = type;
				}
			}

			return temp.ToArray();
		}


	}
}
