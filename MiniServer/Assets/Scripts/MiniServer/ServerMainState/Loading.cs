using UnityEngine;
using System.Collections;
using Fsm;

namespace Server.Main
{
	public class Loading : FSMState<ServerState>
	{
		ServerController serverController;
	
		public Loading (ServerState state, ServerController controller):base(state, controller)
		{	
			this.serverController = controller;
		}
	}
}