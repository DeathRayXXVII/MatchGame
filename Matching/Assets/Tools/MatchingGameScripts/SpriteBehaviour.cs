using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;

    // Start is called before the first frame update
    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }
}

