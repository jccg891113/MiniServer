using UnityEngine;
using System.Collections;

namespace Fsm
{
	public class FSMState<T> where T : struct
	{
		
		protected readonly T stateType;
		protected readonly IFSMController<T> controller;
		
		public FSMState (T stateType, IFSMController<T> controller)
		{
			this.stateType = stateType;
			this.controller = controller;
		}
		
		public virtual void Enter ()
		{
			
		}
		
		public virtual void Leave ()
		{
			
		}
		
		public virtual void Update (float deltaTime)
		{
        
		}
		
		public T GetStateType ()
		{
			return stateType;
		}
		
		public virtual T GetNextState ()
		{
			return stateType;
		}
		
	}
}