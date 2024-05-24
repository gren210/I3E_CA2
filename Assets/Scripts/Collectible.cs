/*
 * Author: Thaqif Adly Bin Mazalan
 * Date: 24/5/24
 * Description: The collectible parent class with the virtual Collected() function
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>
    /// Protected virtual function which is inherited by the child classes
    /// </summary>
    /// <param name="player"></param>
    protected virtual void Collected(GameObject player)
    {
        Destroy(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
