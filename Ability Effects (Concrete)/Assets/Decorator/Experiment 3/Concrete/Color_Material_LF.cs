using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Color_Material_LF : Leaf
	{
		public Material material;
		public Color color;
		public Color_Material_LF(string name, Material material, Color color) : base(name)
		{
			this.material = material;
			this.color = color;
		}

		public override void Execute()
		{
			base.Execute();
			material.color = color;
		}
	}
}
