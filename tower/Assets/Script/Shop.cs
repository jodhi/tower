using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint turet1;
    public TurretBlueprint turet2;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectTuret1()
    {
        Debug.Log("Turet 1 telah dipilih");
        buildManager.SelectTurretToBuild(turet1);
    }

    public void SelectTuret2()
    {
        Debug.Log("Turet 2 telah dipilih");
        buildManager.SelectTurretToBuild(turet2);
    }

}
