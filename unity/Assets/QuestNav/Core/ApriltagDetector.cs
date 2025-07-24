using System.Collections;
using UnityEngine;

namespace Assets.QuestNav.Core
{
    public class ApriltagDetector : MonoBehaviour
    {
        private WebCamTexture leftCamera;
        private WebCamTexture rightCamera;
        private Matrix4x4 leftIntrinsics;
        private Matrix4x4 rightIntrinsics;

        // Use this for initialization
        void Start()
        {
            leftCamera = new WebCamTexture(WebCamTexture.devices[0].name);
            rightCamera = new WebCamTexture(WebCamTexture.devices[1].name);
            leftCamera.Play();
            rightCamera.Play();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}