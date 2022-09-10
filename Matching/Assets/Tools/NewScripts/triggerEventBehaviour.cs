
using System;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;

public class triggerEventBehaviour : MonoBehaviour
{
   public Renderer rend;
   public UnityEvent triggerEnterEvent,mouseOver,collisionExit;
   public Color meshOverColor = Color.magenta;
   public Color originalColor;
   public MeshRenderer meshRend;
   public Mesh mesh;
   

   private void Start()
   {
      rend = GetComponent<Renderer>();
      //Grabs the mesh render from the gameobject
      meshRend = GetComponent<MeshRenderer>();
      //Grabs the original color of the gameobject
      originalColor = meshRend.material.color;
      //OnCollisionExit();
      
   }

   private void OnTriggerEnter(Collider other)
   {
      triggerEnterEvent.Invoke();
   }

   private void OnMouseOver()
   {
      mouseOver.Invoke();
      meshRend.material.color = meshOverColor;
   }

   private void OnMouseExit()
   {
      meshRend.material.color = originalColor;
   }

   private void OnCollisionExit(Collision collision)
   {
      //collisionExit.Invoke();
      mesh = new Mesh();
      GetComponent<MeshFilter>().mesh = mesh;
   }
}
