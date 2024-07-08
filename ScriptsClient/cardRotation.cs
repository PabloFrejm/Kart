using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardRotation : MonoBehaviour
{

    public float time;
    public LeanTweenType type = LeanTweenType.notUsed;
    public bool b;// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.rotation.eulerAngles.y == 180)
        {
            b = true;
        }
        if (this.gameObject.transform.rotation.eulerAngles.y <1)
        {
            b = false;
        }

    //  Debug.Log(this.gameObject.transform.rotation.eulerAngles.y);
    }

    private void OnMouseEnter()
    {
      
       if (!b) { LeanTween.rotate(this.gameObject, new Vector3(0, -180, 0), time).setEase(type);  }
       
    }

    private void OnMouseExit()
    {
        if (b) { LeanTween.rotate(this.gameObject, new Vector3(0, 0, 0), time).setEase(type);  }
    }


}
