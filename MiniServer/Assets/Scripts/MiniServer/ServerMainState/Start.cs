using UnityEngine;
using System.Collections;
using Fsm;

namespace Server.Main
{
	public class Start : FSMState<ServerState>
	{
		ServerController serverController;
	
		public Start (ServerState state, ServerController controller):base(state, controller)
		{	
			this.serverController = controller;
		}
	}
}