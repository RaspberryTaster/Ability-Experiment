using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment.ScriptableObjects
{
	[CreateAssetMenu(fileName = "Leaf", menuName = "Component / Leaf")]
	public class S_Leaf : S_Component
	{
		public override Component Get_Component()
		{
			return new Leaf(Component_Name);
		}
	}
}
