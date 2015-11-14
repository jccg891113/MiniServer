using UnityEngine;
using System.Collections;
using Fsm;

namespace Server.Main
{
	public class Running : FSMState<ServerState>
	{
		ServerController serverController;
	
		public Running (ServerState state, ServerController controller):base(state, controller)
		{	
			this.serverController = controller;
		}
	}
}