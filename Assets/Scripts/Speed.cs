/*
 * Author: Thaqif Adly Bin Mazalan
 * Date: 24/5/24
 * Description: The speed boost child class which inherits from it parent class, Collectible
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : Collectible
{
    /// <summary>
    /// A protected function which is inherited from the parent class
    /// </summary>
    /// <param name="player"></param>
    protected override void Collected(GameObject player)
    {
        base.Collected(player);
        player.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed += 6;
    }

    /// <summary>
    /// Collectible interaction
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        Collected(other.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
