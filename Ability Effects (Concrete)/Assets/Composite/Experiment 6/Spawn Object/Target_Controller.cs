using Assets.Composite.Experiment_6.Interfaces;
using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Composite.Experiment_6.Spawn_Object
{
	public class Target_Controller : MonoBehaviour
	{
		public Component_Controller component_Controller;
		public List<GameObject> targets = new List<GameObject>();


		[Button("Execute", EButtonEnableMode.Always)]
		public void Execute()
		{
			component_Controller = component_Controller != null ? component_Controller : GetComponent<Component_Controller>();
			if (component_Controller == null) return;
			int count = targets.Count;
			for (int i = 0; i < count; i++)
			{
				List<Component> components = component_Controller.components;
				int count1 = components.Count;
				for (int x = 0; x < count1; x++)
				{
					if (components[x] is INeed_Target need_Target)
					{
						need_Target.Set_Target(targets[i]);
					}
					components[x].Execute(1);
				}
			}


		}
	}
}
