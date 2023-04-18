using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZomController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float Length;

   private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
      cameraController.FollowtTarget(bola.transform,Length);
    }
  }
}
