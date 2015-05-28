﻿using UnityEngine;

/**
 * The UI.Panel namespace
 */
namespace UI.Panel
{
	/**
	 * The UI panel core class
	 */
	public abstract class Core : MonoBehaviour
	{
		/**
		 * The panel
		 */
		public Enum.UIPanel panel;

		
		/**
		 * Abstract initalize method of the panel
		 * Will automaticly be called if a panel is enabled
		 */
		protected abstract void Initialize();
		
		
		/**
		 * Abstract reset method of the panel
		 * Will automaticly be called if a panel is disabled
		 */
		protected abstract void Reset();


		/**
		 * Enables the panel
		 */
		public void Enable()
		{
			this.Initialize();
			this.gameObject.SetActive(true);
		}
		
		
		/**
		 * Disables the panel
		 */
		public void Disable()
		{
			this.gameObject.SetActive(false);
			this.Reset();
		}
	}
}