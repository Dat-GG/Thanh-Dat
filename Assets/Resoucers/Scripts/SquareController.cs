using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public int i;
    public int a;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Tranpost();
    }

    void Tranpost()
    {
        var a = i + 1; 

        if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y == 0)
        {
            this.gameObject.transform.position += new Vector3(i, 0, 0);
            Debug.LogError(this.gameObject.transform.position.x  + " gia tri cua x ");
            Debug.LogError(this.gameObject.transform.position.y  + " gia tri cua y ");
        }

        else if (this.gameObject.transform.position.x >= i && this.gameObject.transform.position.y == 0)
        {
            this.gameObject.transform.position += new Vector3(0, i, 0);
            Debug.LogError(this.gameObject.transform.position.x + " gia tri cua x ");
            Debug.LogError(this.gameObject.transform.position.y + " gia tri cua y ");
        }
        else if (this.gameObject.transform.position.x >= i && this.gameObject.transform.position.y >= i)
        {
            this.gameObject.transform.position += new Vector3(-i, 0, 0);
            Debug.LogError(this.gameObject.transform.position.x + " gia tri cua x ");
            Debug.LogError(this.gameObject.transform.position.y + " gia tri cua y ");
        }
        else if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y >= 0)
        {
            this.gameObject.transform.position += new Vector3(0, -i, 0);
            Debug.LogError(this.gameObject.transform.position.x + " gia tri cua x ");
            Debug.LogError(this.gameObject.transform.position.y + " gia tri cua y ");
        }
                    }
                }

            
        

    
