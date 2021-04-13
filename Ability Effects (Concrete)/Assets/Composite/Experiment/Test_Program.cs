using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment
{
	public class Test_Program : MonoBehaviour
	{

		private void Start()
		{
			Composite root = new Composite("Root");
			root.Add(new Leaf("Leaf A"));
			Composite c = new Composite("Composite A");
			root.Add(c);
			c.Add(new Composite("Composite AA"));
			root.Display(1);

				
		}
	}
}
