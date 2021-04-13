using NaughtyAttributes;
using UnityEngine;
using Assets.Decorator.Experiment_3.Interfaces;
using Assets.Decorator.Experiment_3.Concrete;
using Component = Assets.Decorator.Experiment_3.Concrete.Base.Component;
using Assets.Decorator.Experiment_3.Library;

namespace Assets.Decorator.Experiment_3
{
	public class Test_Client : MonoBehaviour
	{
		public Component component;
		public Renderer myRenderer;
		public Color color;
		public Color color_2;
		public int child_Count;
		public bool conditional;
		public GameObject prefab;
		public GameObject child;
		public Vector3 rotate_Vector;

		public Transform targeting_Object;
		public Transform targeting_Object_2;

		[Button("Construct", EButtonEnableMode.Always)]
		public void Construct()
		{
			Concrete.Composite composite = new Echo_CMP("Echo", 1, 2f);
			//Leaf color_Change = new Color_Material_LF("Color to Red, Delayed, Echo", myRenderer.material,color);
			Leaf spawn_Object = new Instantiate_Object_LF("Instantiate Object", prefab, targeting_Object.position);
			Leaf spawn_Object2 = new Instantiate_Object_LF("Instantiate Object 2", prefab, targeting_Object_2.position);
			composite.Add(spawn_Object);
			composite.Add(spawn_Object2);
			component = composite;
			//TestSpell();
		}

		private void TestSpell()
		{
			Concrete.Composite composite = new Conditional_CMP("Conditional", this);
			composite.Add(new Color_Material_LF("Color to blue", myRenderer.material, color));
			composite.Add(new Instantiate_Object_LF("Instantiate Object", prefab, transform.position));
			composite.Add(new Set_Parent_LF("Parenter", child, gameObject));
			composite.Add(new Rotate_Object_LF("Rotate", child, rotate_Vector));
			composite.Add(new Delegate_CMP("Delegate", child));
			Timed_Delay_CMP timed_Delay = new Timed_Delay_CMP("Time Delay", 2f);
			timed_Delay.Add(new Color_Material_LF("Color to green, delayed", myRenderer.material, color_2));
			composite.Add(timed_Delay);
			component = composite;
		}

		[Button("Execute", EButtonEnableMode.Always)]
		public void Execute()
		{
			Reset_Components();
			component.Execute();
		}

		private void Reset_Components()
		{
			Component_Utilities.Full_Reset(component);
		}
	}
}
