using Raldis_Crack_House_Mod_Menu.MenuMods;
using UnityEngine;
using BepInEx;

namespace Raldis_Crack_House_Mod_Menu.ModMenu
{
    [BepInPlugin("com.j0ker.modz.raldi", "J0kersRaldiMenu", "1.0.0")]
    public class Menu : BaseUnityPlugin
    {
        private bool besp;
        private Rect guiBoxRect = new Rect(0, 35, 245, 385);
        private bool sh;
        private bool inf;
        private bool thirdp;

        void OnGUI()
        {
            GUI.backgroundColor = Color.black;
            GUI.color = Color.red;
            guiBoxRect = GUI.Window(0, guiBoxRect, DragWindow, "J0kers RALDI Menu");

        }

        void DragWindow(int windowID)
        {
            GUI.color = Color.red;
            GUI.backgroundColor = Color.black;

            if (GUI.Button(new Rect(0f, 85f, 245f, 25f), "Quit Game"))
            {
                Application.Quit();
            }

            if (GUI.Button(new Rect(0f, 125f, 120f, 25f), "Raldi ESP"))
            {
                this.besp = !this.besp;
            }
            if (this.besp)
            {
                Mods.BaldiESP();
            }

            if (GUI.Button(new Rect(125f, 125f, 120f, 25f), "Ping Books [ESP]"))
            {
                Mods.Blah();
            }

            if (GUI.Button(new Rect(0f, 155f, 245f, 25f), "Speed Hack"))
            {
                this.sh = !this.sh;
            }
            if (this.sh)
            {
                Mods.Speedhack();
            }
            else
            {
                Mods.SpeedhackOff();
            }

            if (GUI.Button(new Rect(0f, 185f, 120f, 25f), "Inf Stamina"))
            {
                this.inf = !this.inf;
            }
            if (this.inf)
            {
                Mods.Infinite_Stamina();
            }
            else
            {
                Mods.Infinite_StaminaOff();
            }

            if (GUI.Button(new Rect(125f, 185f, 120f, 25f), "God Mode"))
            {
                Mods.FuxkUI();
            }

            if (GUI.Button(new Rect(0f, 225f, 245f, 25f), "Money Hack"))
            {
                Mods.MoneyHack();
            }

            if (GUI.Button(new Rect(0f, 255f, 120f, 25f), "Spawn Iphone"))
            {
                Mods.Iphone();
            }

            if (GUI.Button(new Rect(125f, 255f, 120f, 25f), "Look At Player"))
            {
                this.thirdp = !this.thirdp;
            }
            if (this.thirdp)
            {
                Mods._3rd_Preson();
            }
            else
            {
                Mods._3rd_PresonOff();
            }

            if (GUI.Button(new Rect(0f, 285f, 245f, 25f), "God Mode"))
            {

            }

            GUI.DragWindow();
        }
    }
}