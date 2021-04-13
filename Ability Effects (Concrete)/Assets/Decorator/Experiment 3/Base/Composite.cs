using Assets.Decorator.Experiment_3.Interfaces;
using Assets.Decorator.Experiment_3.Library;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Component = Assets.Decorator.Experiment_3.Concrete.Base.Component;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public abstract class Composite : Component, IComposite, IExecute
	{
		protected List<IComponent> children = new List<IComponent>();
		public Composite(string name, List<IComponent> children) : base(name)
		{
			this.children = children;
		}

		public Composite(string name) : base(name)
		{
		}

		public virtual IComponent[] Get_Children_And_Grandchildren()
		{
			List<IComponent> temp = Get_My_Children().ToList();
			IComposite[] composites = Get_Grandchildren_Of_Type<IComposite, IComposite>(List_Utility.Convert_From_Mixed<IComposite, IComponent>(children).ToArray());
			IComponent[] grand_Children = (IComponent[])composites;
			temp.AddRange(grand_Children.Except(temp));

			return temp.ToArray();
		}

		
		public virtual T[] Get_Chidlren_And_Grandchildren_of_Type<T>()
		{
			List<T> temp = Get_My_Children_Of_Type<T>().ToList();
			IComposite[] composites = Get_Grandchildren_Of_Type<IComposite, IComposite>(List_Utility.Convert_From_Mixed<IComposite, IComponent>(children).ToArray());
			T[] grand_Children = Get_Grandchildren_Of_Type<IComposite, T>(composites);
			temp.AddRange(grand_Children.Except(temp));

			return temp.ToArray();
		}
	
		public virtual IComponent[] Get_My_Children()
		{
			return children.ToArray();
		}
		protected subject[] Get_Grandchildren_Of_Type<children__Type, subject>(children__Type[] children) where children__Type : IComposite
		{
			List<subject> temp = new List<subject>();
			for (int i = 0; i < children.Length; i++)
			{
				foreach (children__Type child in children)
				{
					foreach (children__Type grandchild in child.Get_Chidlren_And_Grandchildren_of_Type<children__Type>())
					{
						if (grandchild is subject type)
						{
							temp.Add(type);
						}

					}
				}
			}

			return temp.ToArray();
		}

		public virtual T[] Get_My_Children_Of_Type<T>()
		{
			List<T> temp = new List<T>();
			int count = children.Count;
			for (int i = 0; i < count; i++)
			{
				if (children[i] is T type)
				{
					temp.Add(type);
				}
			}
			return temp.ToArray();
		}

		public void Add(IComponent component)
		{
			component.Set_Root(this);
			children.Add(component);
		}

		public void Remove(IComponent component)
		{
			if (children.Contains(component))
			{
				children.Remove(component);
			}

		}

	}
}
