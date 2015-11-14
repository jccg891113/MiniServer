using UnityEngine;
using System.Collections;
using Fsm;

namespace Server.Main
{
	public class Pause : FSMState<ServerState>
	{
		ServerController serverController;
	
		public Pause (ServerState state, ServerController controller):base(state, controller)
		{	
			this.serverController = controller;
		}
	}
}