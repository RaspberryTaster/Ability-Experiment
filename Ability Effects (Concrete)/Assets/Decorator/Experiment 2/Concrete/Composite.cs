using Assets.Decorator.Experiment_2.Concrete.Base;
using Assets.Decorator.Experiment_2.Interfaces;
using Assets.Decorator.Experiment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Decorator.Experiment_2.Concrete
{
	public class Composite : Component
	{
		List<IComponent> children = new List<IComponent>();
		public Composite(IBase_Component current_Strategy, string name, List<IComponent> children = null) : base(current_Strategy, name)
		{
			if(children == null)
			{
				children = new List<IComponent>();
			}

			this.children = children;
		}

		public override IComponent[] Get_All_Children()
		{
			List<IComponent> temp = children;
			temp.AddRange(current_Strategy.Get_All_Children().Except(temp));
			return temp.ToArray();
		}

		public override T[] Get_All_Children_Of_Type<T>()
		{
			return current_Strategy.Get_All_Children_Of_Type<T>();
		}

		public override IComponent[] Get_My_Children()
		{
			List<IComponent> temp = children;
			temp.AddRange(current_Strategy.Get_My_Children().Except(temp));
			return temp.ToArray();
		}

		public override T[] Get_My_Children_Of_Type<T>()
		{
			return current_Strategy.Get_My_Children_Of_Type<T>();
		}
	}
}
