using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment.ScriptableObjects
{
	public abstract class S_Component : ScriptableObject
	{
		public string Component_Name;
		public abstract Component Get_Component();
	}
}
