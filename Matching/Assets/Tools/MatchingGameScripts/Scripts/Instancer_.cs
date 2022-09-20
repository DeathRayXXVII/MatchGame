using UnityEngine;

[CreateAssetMenu]
public class Instancer_ : ScriptableObject
{
   public GameObject prefab;
   
   public void CreatInstance()
   {
      Instantiate(prefab);
   }

   public void CreateInstance(Vector3Data obj)
   {
      Instantiate(prefab, obj.value, Quaternion.identity);
   }
}
