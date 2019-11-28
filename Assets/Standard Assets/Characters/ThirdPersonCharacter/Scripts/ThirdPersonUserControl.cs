//using System;
//using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;

//namespace UnityStandardAssets.Characters.ThirdPerson
//{
//    [RequireComponent(typeof(ThirdPersonCharacter))]
//    public class ThirdPersonUserControl : MonoBehaviour
//    {
//        private ThirdPersonCharacter m_Character;    // A reference to the ThirdPersonCharacter on the object
//        private Transform m_Cam;                     // A reference to the main camera in the scenes transform
//        private Vector3 m_Move;                     // the world-relative desired move direction, calculated from the camForward and user input.
//        private bool m_Jump;


//        private void Start()
//        {
//            // get the third person character ( this should never be null due to require component )
//            m_Character = GetComponent<ThirdPersonCharacter>();
//        }


//        private void Update()
//        {
//            if (!m_Jump)
//            {
//                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
//            }
//        }


//        // Fixed update is called in sync with physics
//        private void FixedUpdate()
//        {
//            // read inputs
//            float h = CrossPlatformInputManager.GetAxis("Horizontal");
//            float v = CrossPlatformInputManager.GetAxis("Vertical");
//            bool crouch = Input.GetKey(KeyCode.C);

//            // pass all parameters to the character control script
//            m_Character.Move(m_Move, crouch, m_Jump);
//            m_Jump = false;
//        }
//    }
//}
