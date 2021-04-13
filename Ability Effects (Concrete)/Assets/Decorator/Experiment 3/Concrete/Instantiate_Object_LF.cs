using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Instantiate_Object_LF : Leaf
	{
		public GameObject prefab;
		public Vector3 target_Position;
		public Instantiate_Object_LF(string name, GameObject prefab, Vector3 target_Position) : base(name)
		{
			this.prefab = prefab;
			this.target_Position = target_Position;
		}

		public override void Execute()
		{
			base.Execute();
			GameObject g = UnityEngine.Object.Instantiate(prefab.gameObject);
			g.transform.position = target_Position;
		}
	}
}
