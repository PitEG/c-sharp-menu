using System;

namespace PitGan.Menu {
	public class Menu {
		private MenuItem currentItem;
		private MenuItem[] items;
		private int size;

		public MenuItem CurrentItem {
			get { return currentItem; }
		}

		public Menu() {
		}

		public Menu(MenuItem current, MenuItem[] items) {
			this.currentItem = current;
			this.items = items;
			this.size = items.Length;
		}

		public void Add(MenuItem item) {
			this.items[size] = item;			
		}

		public MenuItem Traverse(Alphabet letter) {
			return currentItem.Traverse(letter);
		}

		public void Interact(Alphabet letter) {
			currentItem.Interact(letter);
		}

	}

	public enum Alphabet {
		Up, Down, Left, Right, Accept, Reject
	}
}
