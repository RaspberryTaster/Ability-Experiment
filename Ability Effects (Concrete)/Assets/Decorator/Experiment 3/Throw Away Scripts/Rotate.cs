using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Decorator.Throw_Away_Scripts
{
	public class Rotate : MonoBehaviour
	{
		GameObject self;
		public Vector3 rotation_Vector;
		private void Start()
		{
			self = gameObject;
		}

		private void Update()
		{
			self.transform.Rotate(rotation_Vector * Time.deltaTime);
		}
	}
}
