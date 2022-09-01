using UnityEngine;

public class PositionCheak : MonoBehaviour
{
  public GameObject gameObject;
  public Vector3Data dataPos;

  private void UpdateCheakPOint()
  {
    gameObject.transform.position = dataPos.value;
  }
}
