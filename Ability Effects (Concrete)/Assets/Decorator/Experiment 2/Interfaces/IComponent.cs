using Assets.Decorator.Experiment_2.Interfaces;

namespace Assets.Decorator.Experiment2.Interfaces
{
	public interface IComponent : ICloneable<IComponent>
	{
		IComponent[] Get_My_Children();
		IComponent[] Get_All_Children();
		T[] Get_My_Children_Of_Type<T>();
		T[] Get_All_Children_Of_Type<T>();
	}
}
