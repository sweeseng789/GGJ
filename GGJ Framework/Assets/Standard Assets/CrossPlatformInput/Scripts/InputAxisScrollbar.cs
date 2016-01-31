using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class InputAxisScrollbar : MonoBehaviour
    {
        public string axis;

		public AudioClip Sound;
		private AudioSource enter16;

		void Awake () {
			enter16 = GetComponent<AudioSource>();
		}

	    void Update()
		{
			if (Input.GetKey(KeyCode.KeypadEnter))
				enter16.PlayOneShot (Sound);
		}

	    public void HandleInput(float value)
        {
            CrossPlatformInputManager.SetAxis(axis, (value*2f) - 1f);
        }
    }
}
