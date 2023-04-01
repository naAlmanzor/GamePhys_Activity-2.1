using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionHandler : MonoBehaviour
{
  public GameObject particle; // Gets Particle System from Prefab
  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      //Get the contact point and normals
      ContactPoint contact = collision.contacts[0];
      Vector3 normal = contact.normal;

      Destroy(collision.gameObject); // Destroys Player Object
      Instantiate (particle, collision.gameObject.transform.position, Quaternion.identity); // Plays the Particle System Prefab
    }
  }
}