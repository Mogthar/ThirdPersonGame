using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private string itemName;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider Other)
    {
      Debug.Log("Item collected: " + itemName);
      Destroy(this.gameObject);
    }
}
