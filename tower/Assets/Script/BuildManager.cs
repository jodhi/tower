﻿using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    
    //nambahin turet
    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one Buildmanager in scene");
            return;
        }
        instance = this;
    }

    public GameObject turet1;
    public GameObject turet2;

    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null;} }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn(Node node)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Uang ga cukup bos");
            return;                                                             
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret dibeli!, Sisa Uang:" + PlayerStats.Money);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
