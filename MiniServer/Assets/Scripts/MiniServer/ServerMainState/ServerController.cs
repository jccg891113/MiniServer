using UnityEngine;
using System.Collections;
using Fsm;

namespace Server.Main
{
	public enum ServerState
	{
		Start,
		Loading,
		Running,
		Pause,
		Ending,
	}

	public class ServerController : FSMController<ServerState>
	{
		public void Init ()
		{
		
		}
	
		public void Update (float deltaTime)
		{
			this.machine.UpdateState (deltaTime);
		}
	}
}