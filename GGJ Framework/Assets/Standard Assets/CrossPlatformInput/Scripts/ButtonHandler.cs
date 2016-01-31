using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler : MonoBehaviour
    {
		public AudioClip Sound;
		private AudioSource enter16;

        public string Name;

        void OnEnable()
        {
			Debug.Log ("Menu loaded");
        }

		void Awake () {
			enter16 = GetComponent<AudioSource>();
		}

        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown(Name);
        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
        }


        public void SetAxisPositiveState()
        {
            CrossPlatformInputManager.SetAxisPositive(Name);
        }


        public void SetAxisNeutralState()
        {
            CrossPlatformInputManager.SetAxisZero(Name);
        }


        public void SetAxisNegativeState()
        {
            CrossPlatformInputManager.SetAxisNegative(Name);
        }

        public void Update()
        {
			//if (Input.GetMouseButtonDown (0)) {
				//Debug.Log ("Mouse is down");
				//enter16.PlayOneShot (Sound);

				//RaycastHit hitInfo = new RaycastHit ();
				// hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

				// Developer Note: Objects under that layer affected by the actions will trigger the event below
				// Example: Objects falling under Layer 9 will be affected when clicked on.
				//if (hit) {
					//if (hitInfo.transform.gameObject.layer == 12) {
					//	Debug.Log ("hit " + hitInfo.transform.gameObject.name);
						//enter16.PlayOneShot (Sound);
					//}
				//}
			//}
			if (Input.GetMouseButtonDown (0)) 
			{
				RaycastHit2D hitinfo = new RaycastHit2D ();
				Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				//Vector2 rayPos = Physics2D.Raycast(pos, pos, Vector2.zero, 0);
				RaycastHit2D command = Physics2D.Raycast(pos, Vector2.zero, 0);
				//Vector2 command = Physics2D.Raycast (Camera.ScreenToWorldPoint(Input.mousePosition).x,Camera.ScreenToWorldPoint(Input.mousePosition).y);
				if (command) {
					Debug.Log ("Mouse is down");
					enter16.PlayOneShot (Sound);
				}
			}
        }
	}
}
