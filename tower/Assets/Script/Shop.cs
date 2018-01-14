using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint StandardTurret;
    public TurretBlueprint MisileLauncher;
    public TurretBlueprint LaserBeamer;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Telah Dipilih");
        buildManager.SelectTurretToBuild(StandardTurret);
    }

    public void SelectMisileLauncher()
    {
        Debug.Log("Misile Launcher Telah Dipilih");
        buildManager.SelectTurretToBuild(MisileLauncher);
    }

    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Telah Dipilih");
        buildManager.SelectTurretToBuild(LaserBeamer);
    }
}
