using Assets.Decorator.Experiment_2.Interfaces;
using Assets.Decorator.Experiment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Decorator.Experiment_2.Concrete.Base
{
	public abstract class Component : IComponent
	{
		public string name;
		public IBase_Component current_Strategy;

		protected Component(IBase_Component current_Strategy, string name)
		{
			this.current_Strategy = current_Strategy;
			this.name = name;
		}

		public virtual IComponent Clone()
		{
			return this;
		}

		public virtual IComponent[] Get_All_Children()
		{
			return current_Strategy.Get_All_Children();
		}

		public virtual T[] Get_All_Children_Of_Type<T>()
		{
			return current_Strategy.Get_All_Children_Of_Type<T>();
		}

		public  virtual IComponent[] Get_My_Children()
		{
			return current_Strategy.Get_My_Children();
		}

		public virtual T[] Get_My_Children_Of_Type<T>()
		{
			return current_Strategy.Get_My_Children_Of_Type<T>();
		}
	}
}
