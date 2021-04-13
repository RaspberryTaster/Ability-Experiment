using System.Collections.Generic;
using UnityEngine;

namespace Assets.Composite.Experiment_6.Spawn_Object
{
	public class Component_Controller : MonoBehaviour
	{
		public List<Component> components = new List<Component>();
		public int component_Count;

		public void Update_Components(List<Component> components)
		{
			this.components = components;
			component_Count = components.Count;
		}
	}
}
