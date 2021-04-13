using Assets.Composite.Experiment_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment_5.Concrete
{
	public class Spawn_Object_LF : Leaf, INeed_Target
	{
		Spawnable_Object prefab;
		GameObject target;
		public Spawn_Object_LF(string name, Spawnable_Object prefab) : base(name)
		{
			this.prefab = prefab;
		}

		public override void Execute(int depth)
		{
			base.Execute(depth);

			GameObject g = UnityEngine.Object.Instantiate(prefab.gameObject);
			g.transform.position = target.transform.position;
			Spawnable_Object temp = g.GetComponent<Spawnable_Object>();
			temp.my_Renderer.material.color = Color.green;
			Debug.Log("SPAWN THE OBJECT " + target.name);
		}

		public void Set_Target(GameObject target)
		{
			this.target = target;
		}
	}
}
