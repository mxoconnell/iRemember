using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This script shows how to call a simple SQL query from a database using the class definition of the
/// database to format the results.
/// 
/// In this example we overwrite the working database since no data is being changed. This is set in the 
/// SimpleSQLManager gameobject in the scene.
/// </summary>
public class displayMemories : MonoBehaviour {

	// reference to our database manager object in the scene
	public SimpleSQL.SimpleSQLManager dbManager;
	
	// reference to the gui text object in our scene that will be used for output
	public GUIText outputText;


    public class Stuff
    {
        public string WeaponName;
        public string Damage;

        public Stuff()
        {
            WeaponName = "milk";
            Damage = "cheese";
        }

        public Stuff(string bul, string gre)
        {
            WeaponName = bul;
            Damage = gre; 
        }
    }

    void Start ()  
	{
        // Gather a list of weapons and their type names pulled from the weapontype table		
        List<global::Stuff> weapons = dbManager.Query<global::Stuff>(
														"SELECT " + 
															"W.WeaponName, " + 
															"W.Damage " + 
														"FROM " + 
															"Weapon W " 
														);
		
		// output the list of weapons
		outputText.text = "Memories...\n\n";
		foreach (global::Stuff weapon in weapons) 
		{
            outputText.text += "Display Name:   " + weapon.WeaponName.ToString() +  "\n"+
							   "Image Location: " + weapon.Damage.ToString() + "\n\n";
		}


	}

   /* private void SavePlayerStats_Simple(string playerName, int totalKills, int points)
    {
        // Initialize our PlayerStats class
        PlayerStats playerStats = new PlayerStats { PlayerName = playerName, TotalKills = totalKills, Points = points };

        // Insert our PlayerStats into the database
        dbManager.Insert(playerStats);
    }*/
}
