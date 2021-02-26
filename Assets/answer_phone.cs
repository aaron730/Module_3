using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
    public class answer_phone : MonoBehaviour
    {
        // Start is called before the first frame update

        public SteamVR_Action_Boolean jumpAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("platformer", "Jump");

        public Renderer jumpHighlight;
        private bool jump;
        private SteamVR_Input_Sources hand;
        private Interactable interactable;
        public AudioSource ringTone;
        public AudioSource phoneCall;

        private UnityEngine.Vector3 originalPostion;
        private bool hasAnswered = false;

        void Start()
        {
            interactable = GetComponent<Interactable>();
        }

        // Update is called once per frame
        void Update()
        {
            if (interactable.attachedToHand)
            {
                hand = interactable.attachedToHand.handType;
                jump = jumpAction[hand].stateDown;
                if (jump && hasAnswered == false)
                {
                    ringTone.Stop();
                    phoneCall.Play(0);
                    hasAnswered = true;
                    Invoke("End", 110f);
                }
            }
        }

        void End()
        {
            Application.Quit();
        }
    }
}

