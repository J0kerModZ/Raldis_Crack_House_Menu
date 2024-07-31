using UnityEngine;


namespace Raldis_Crack_House_Mod_Menu.MenuMods
{
    public class Mods : MonoBehaviour
    {

        public static void BaldiESP()
        {
            GameObject.Find("Game/Characters/Baldi/BaldiSprite").SetActive(false);
            GameObject.Find("Game/Characters/Baldi/RaldiDrip").SetActive(true);
            GameObject.Find("Game/Characters/Baldi/RaldiDrip").GetComponent<SpriteRenderer>().material.shader = Shader.Find("GUI/Text Shader");
            GameObject.Find("Game/Characters/Baldi/RaldiDrip").GetComponent<SpriteRenderer>().material.color = Color.red;

            GameObject gameObject = new GameObject("Line");
            LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
            Color red = Color.red;
            lineRenderer.startColor = red;
            lineRenderer.endColor = red;
            lineRenderer.startWidth = 0.01f;
            lineRenderer.endWidth = 0.01f;
            lineRenderer.positionCount = 2;
            lineRenderer.useWorldSpace = true;
            lineRenderer.SetPosition(0, GameObject.Find("Game/Player/Player").transform.position);
            lineRenderer.SetPosition(1, GameObject.Find("Game/Characters/Baldi/RaldiDrip").GetComponent<RealBillboard>().transform.position);
            lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
            UnityEngine.Object.Destroy(lineRenderer, Time.deltaTime);
            UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
        }

        public static void Speedhack()
        {
            GameObject.Find("Game/Player/Player").GetComponent<PlayerScript>().walkSpeed = 60;
            GameObject.Find("Game/Player/Player").GetComponent<PlayerScript>().runSpeed = 90;
            GameObject.Find("Game/Player/Player").GetComponent<PlayerScript>().infiniteStamina = true;
        }

        public static void SpeedhackOff()
        {
            GameObject.Find("Game/Player/Player").GetComponent<PlayerScript>().walkSpeed = 20;
            GameObject.Find("Game/Player/Player").GetComponent<PlayerScript>().runSpeed = 25;
            GameObject.Find("Game/Player/Player").GetComponent<PlayerScript>().infiniteStamina = false;
        }

        public static void Infinite_Stamina()
        {
            GameObject.Find("Game/Player/Player").GetComponent<PlayerScript>().infiniteStamina = true;
        }

        public static void Infinite_StaminaOff()
        {
            GameObject.Find("Game/Player/Player").GetComponent<PlayerScript>().infiniteStamina = false;
        }



        public static void NoNPC()
        {
            GameObject.Find("Game/Characters").SetActive(false);
        }

        public static void YesNPC()
        {
            GameObject.Find("Game/Characters").SetActive(true);
        }


        public static void Blah()
        {
            NotebookScript[] array = Object.FindObjectsOfType<NotebookScript>();
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Ping();
            }
        }

        public static void FuxkUI()
        {
            GameObject.Find("Game/UI/edpJumpscare").SetActive(false);
            GameObject.Find("Game/UI/Hud/UIEvents").SetActive(false);
        }

        public static void LoveUI()
        {
            GameObject.Find("Game/UI/Hud/UIEvents").SetActive(true);
        }

        public static void Iphone() 
        {
            GameObject.Find("Game/UI/iPhoneSelectScreen").SetActive(true);
        }

        public static void _3rd_Preson() 
        {
            GameObject.Find("Game/Player/Player/DiarreahCamera").SetActive(true);
            GameObject.Find("Game/Player/Player/DiarreahCamera").GetComponent<Camera>().fieldOfView = 120f;
        }

        public static void _3rd_PresonOff()
        {
            GameObject.Find("Game/Player/Player/DiarreahCamera").SetActive(false);
        }

        public static void MoneyHack()
        {
            GameObject.Find("Game/Controllers/MoneyManager").GetComponent<MoneyManager>().money = 9999f;
            GameObject.Find("Game/Controllers/PlayerStats").GetComponent<PlayerStats>().data.cashInPocket = 9999f;
        }
    }
}
