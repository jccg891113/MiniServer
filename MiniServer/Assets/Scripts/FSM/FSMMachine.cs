using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Fsm
{
	public class FSMMachine<T> where T : struct
	{
		
		protected FSMState<T> currentState;
		protected T defaultStateType;
		protected Dictionary<T, FSMState<T>> allStates;
		
		public FSMMachine ()
		{
			allStates = new Dictionary<T, FSMState<T>> ();
		}
		
		public virtual void AddState (FSMState<T> newState)
		{
			if (allStates.ContainsKey (newState.GetStateType ())) {
				allStates [newState.GetStateType ()] = newState;
			} else {
				allStates.Add (newState.GetStateType (), newState);
			}
		}
		
		public FSMState<T> GetState (T stateType)
		{
			return allStates [stateType];
		}
		
		public T GetCurrrentStateType ()
		{
			return currentState.GetStateType ();
		}
		
		public FSMState<T> GetCurrrentState ()
		{
			return currentState;
		}
		
		public virtual void SetDefaultState (T newState)
		{
			defaultStateType = newState;
		}

		public virtual void UpdateState (float deltaTime)
		{
			if (currentState == null) {
				currentState = allStates [defaultStateType];
				currentState.Enter ();
			} else {
				T nextState = currentState.GetNextState ();
				if (!nextState.Equals (currentState.GetStateType ())) {
					currentState.Leave ();
					currentState = allStates [nextState];
					currentState.Enter ();
				}
				currentState.Update (deltaTime);
			}
		}
	}
}