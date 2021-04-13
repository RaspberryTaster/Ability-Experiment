using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment.ScriptableObjects
{
	public class S_Test_Program : MonoBehaviour
	{
		public S_Component S_Component;

		private void Start()
		{
			Component temp = S_Component.Get_Component();
			temp.Display(1);
		}
	}
}
