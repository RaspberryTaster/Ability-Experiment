using Assets.Decorator.Experiment.Interfaces;
using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Decorator.Experiment.Concrete
{
	public class Client : MonoBehaviour
	{
		public IComponent component;
		[Space]
		public List<GameObject> base_List;
		public List<GameObject> decorator_List1;
		public List<GameObject> decorator_List2;
		public List<GameObject> result;

		[Button("Construct", EButtonEnableMode.Always)]
		public void Construct()
		{
			IComponent base_Component = new Base_Implementation(base_List);
			IComponent decorator_Component1 = new Decorator_Implementation(decorator_List1, base_Component);
			IComponent decorator_Compoennt2 = new Decorator_Implementation(decorator_List2, decorator_Component1);

			component = decorator_Compoennt2;

		}

		[Button("Execute", EButtonEnableMode.Always)]
		public void Execute()
		{
			result = component.Get_All_Children();
		}
	}
}
