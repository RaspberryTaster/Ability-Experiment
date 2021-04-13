using UnityEngine;
using Assets.Decorator.Experiment_2.Concrete.Base;
using Component = Assets.Decorator.Experiment_2.Concrete.Base.Component;
using Assets.Decorator.Experiment_2.Interfaces;
using NaughtyAttributes;

namespace Assets.Decorator.Experiment_2
{
	public class Client : MonoBehaviour
	{
		public Component component;
		public int child_Count;

		[Button("Construct", EButtonEnableMode.Always)]
		public void Construct()
		{
			IBase_Component base_Component = new Base_Component("Base_Component");
			IBase_Component decorator_Component = new Decorator_Component("Decorator_Component", base_Component);
			component = new Concrete.Composite(decorator_Component, "Composite");
		}

		[Button("Execute", EButtonEnableMode.Always)]
		public void Execute()
		{
			child_Count = component.Get_All_Children().Length;
		}
	}
}
