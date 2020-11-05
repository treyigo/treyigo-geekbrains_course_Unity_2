using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{

    [SerializeField] private int weaponID = 0;
    private int previosWeaponID;
    private Transform GOTransform;
    void Awake()
    {
        GOTransform = transform;
        SelectWeapon();
    }

    private void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in GOTransform)
        {
            if (i == weaponID)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        previosWeaponID = weaponID;
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(weaponID >= GOTransform.childCount - 1)
            {
                weaponID = 0;
            } else
            {
                weaponID++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (weaponID <= 0)
            {
                weaponID = GOTransform.childCount - 1;
            }
            else
            {
                weaponID--;
            }
        }

        if (previosWeaponID != weaponID )
        {
            SelectWeapon();
        }
    }
}
