using Assets.Decorator.Experiment_3.Interfaces;
using Assets.Decorator.Experiment_3.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Conditional_CMP : Composite, INext_Components
	{
		public Test_Client Client;
		public Conditional_CMP(string name, Test_Client client) : base(name)
		{
			Client = client;
		}

		public Conditional_CMP(string name, List<IComponent> children, Test_Client client) : base(name, children)
		{
			Client = client;
		}

		public override void Execute()
		{
			base.Execute();
			if(Client.conditional)
			{
				Next_Components(Get_My_Children());
			}
		}

		public void Next_Components(IComponent[] components)
		{
			Component_Utilities.Next_Components(components);
		}
	}
}
