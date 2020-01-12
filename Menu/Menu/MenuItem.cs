using System;
using System.Collections.Generic;

namespace PitGan.Menu {
	public class MenuItem : IMenuInteractable {
		private IMenuInteractable item;
		private MenuItem itemUp;
		private MenuItem itemDown;
		private MenuItem itemLeft;
		private MenuItem itemRight;
		private MenuItem itemAccept;
		private MenuItem itemReject;

		public MenuItem() {
		}

		public MenuItem(IMenuInteractable item) {
			this.item = item;	
		}

		public void Interact(Alphabet letter) {
			switch (letter) {
				case Alphabet.Up: break;
				case Alphabet.Down: break;
				case Alphabet.Left: break;
				case Alphabet.Right: break;
				case Alphabet.Accept: break;
				case Alphabet.Reject: break;
			}
		}

		public MenuItem Traverse(Alphabet letter) {
			MenuItem item;

			switch (letter) {
				case Alphabet.Up: item = itemUp; break;
				case Alphabet.Down: item = itemDown; break;
				case Alphabet.Left: item = itemLeft; break;
				case Alphabet.Right: item = itemRight;  break;
				case Alphabet.Accept: item = itemAccept;  break;
				case Alphabet.Reject: item = itemReject; break;
			}
			
			return null;
		}
	}
}
