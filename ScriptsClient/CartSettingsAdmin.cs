using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CartSettingsAdmin : MonoBehaviour
{

    public int countCart;
    public GameObject prefCart;
    public GameObject parentPanel;
    public List<GameObject> listCart=new List<GameObject>();
    public string nameCart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (listCart.Count < countCart)
        {
            ConnectCartList();  
        }
    }

    public void ConnectCartList()
    {
        if (listCart.Count > 0)
        {
            foreach (GameObject item in listCart) { Destroy(item); }
            listCart.Clear();
        }

        for(int c = 0; c < countCart; c++)
        {
            GameObject cart = Instantiate(prefCart, prefCart.transform.position, Quaternion.identity);
            cart.transform.SetParent(parentPanel.transform);
            cart.transform.localScale = Vector3.one;
            cart.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = nameCart+c; 
            listCart.Add(cart);

        }
      


    }
}
