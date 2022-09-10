
using System;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;

public class triggerEventBehaviour : MonoBehaviour
{
   public Renderer rend; //making the renderer usable
   public UnityEvent triggerEnterEvent,mouseOver,collisionExit, enable; //making the events public
   public Color meshOverColor = Color.magenta; //set the new color
   public Color originalColor; //setting the original color
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
      //changes the color to the set color
      meshRend.material.color = meshOverColor;
   }

   private void OnMouseExit()
   {
      //Changing the color back to original color
      meshRend.material.color = originalColor;
   }

   private void OnCollisionExit(Collision collision)
   {
      //collisionExit.Invoke();
      Debug.Log("Hit collider");
      mesh = new Mesh();
      GetComponent<MeshFilter>().mesh = mesh;
   }

   private void OnEnable()
   {
      enable.Invoke();
   }
}
