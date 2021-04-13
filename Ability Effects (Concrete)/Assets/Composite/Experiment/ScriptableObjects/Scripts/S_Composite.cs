using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment.ScriptableObjects
{
	[CreateAssetMenu(fileName = "Composite", menuName ="Component / Composite")]
	public class S_Composite : S_Component
	{
		[SerializeField] S_Component[] component = new S_Component[0];

		public override Component Get_Component()
		{
			Component[] temp = new Component[component.Length];
			for(int i = 0; i < component.Length; i++)
			{
				temp[i] = component[i].Get_Component();
			}

			return new Composite(Component_Name, temp.ToList());
		}	
	}
}
