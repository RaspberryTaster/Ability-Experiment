using Assets.Composite.Experiment_5.Interfaces;
using Assets.Composite.Experiment_5.Spawn_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment_5.Concrete
{
	public class Spawn_Object_CMP : Composite, INeed_Target
	{
		Spawnable_Object prefab;
		GameObject target;

		public Spawn_Object_CMP(string name, Spawnable_Object prefab, List<Component> children = null) : base(name, children)
		{
			this.prefab = prefab;
		}

		public override void Execute(int depth)
		{
			Spawnable_Object temp = Spawn();
			temp.gameObject.transform.position = target.transform.position;
			Component_Controller component_Controller = temp.gameObject.GetComponent<Component_Controller>();
			if (component_Controller == null)
			{
				component_Controller = temp.gameObject.AddComponent<Component_Controller>();
			}


			component_Controller.Update_Components(_children);
			base.Execute(depth);
		}

		private Spawnable_Object Spawn()
		{
			GameObject g = UnityEngine.Object.Instantiate(prefab.gameObject);
			Spawnable_Object temp = g.GetComponent<Spawnable_Object>();	
			return temp;
		}

		public void Set_Target(GameObject target)
		{
			this.target = target;
		}
	}
}
