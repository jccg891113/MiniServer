using UnityEngine;
using System.Collections;
using Fsm;

namespace Fsm.JFSM
{
	public interface IFSMController<T> where T : struct {
		
	}
	
	public class FSMController<T> : IFSMController<T> where T : struct {
		protected FSMMachine<T> machine;
	}
	
	public class FSMMonoController<T> : MonoBehaviour, IFSMController<T> where T : struct {
		protected FSMMachine<T> machine;
		
		public virtual void Update () {
			if (machine != null) {
				machine.UpdateState(Time.deltaTime);
			}
		}
	}
}