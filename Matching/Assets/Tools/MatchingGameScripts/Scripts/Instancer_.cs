using UnityEngine;

[CreateAssetMenu]
public class Instancer_ : ScriptableObject
{
   public GameObject prefab;
   private int num;
   
   public void CreatInstance()
   {
      Instantiate(prefab);
   }

   public void CreateInstance(Vector3Data obj)
   {
      Instantiate(prefab, obj.value, Quaternion.identity);
   }
   
   public void CreateInstanceFromList(Vector3DataList obj)
   {
      foreach (var t in obj.vector3Dlist) //using a foreach loop to generate the list
      {
         Instantiate(prefab, t.value, Quaternion.identity);
      }
   }
   
   
   public void CreateInstanceFromListCounting(Vector3DataList obj)
   {
      Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity); //instantiate the object at 0
      num++; //add one
      if (num == obj.vector3Dlist.Count) //if it is equal to the count
      {
         num = 0; //setting it back to zero
      }
   }
   
}
