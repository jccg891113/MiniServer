using UnityEngine;
using System.Collections;
using Fsm;

namespace Server.Main
{
	public class Ending : FSMState<ServerState>
	{
		ServerController serverController;
	
		public Ending (ServerState state, ServerController controller):base(state, controller)
		{	
			this.serverController = controller;
		}
	}
}