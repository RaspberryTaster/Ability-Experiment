using Assets.Decorator.Experiment_3.Interfaces;
using Assets.Decorator.Experiment_3.Library;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Delegate_CMP : Composite
	{
		Test_Client client;

		public Delegate_CMP(string name, GameObject reciever) : base(name)
		{
			GameObject_Utilities.Reference_Component(reciever, ref client);
		}
		public Delegate_CMP(string name, Test_Client reciever) : base(name)
		{
			client = reciever;
		}

		public Delegate_CMP(string name, GameObject reciever, List<IComponent> children) : base(name, children)
		{
			GameObject_Utilities.Reference_Component(reciever, ref client);
		}
		public Delegate_CMP(string name, Test_Client reciever, List<IComponent> children) : base(name, children)
		{
			client = reciever;
		}

		public override void Execute()
		{
			base.Execute();
			Composite composite = new Basic_Composite("Sent Delegate", Get_My_Children().ToList());
			client.component = composite;
		}
	}
}
