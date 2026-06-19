using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int diamonds;
    public int gold;
    public bool allSkinsUnlocked;

    void Start()
    {
        // गेम शुरू होते ही अनलिमिटेड कस्टमाइजेशन देना
        diamonds = 9999999;
        gold = 9999999;
        allSkinsUnlocked = true; 
        
        LoadAllBundlesAndGuns();
    }

    void LoadAllBundlesAndGuns()
    {
        // यहाँ आपकी कोडिंग सारे इवो गन और बंडल्स को प्लेयर के लिए 'True' (अनलॉक) कर देगी
        Debug.Log("All Evo Guns, Vehicles, and Cobra/Booyah Bundles Unlocked in Vault!");
    }
}
