using MelonLoader;
using UnityEngine;
using static UnityEngine.Object;
using UnityEngine.InputSystem;
using Il2Cpp;
using System.Collections.Generic;
using System.Linq;
using System.IO;
 
using System.Collections;
using Il2CppCrosstales.Common.Util;
using UnityEngine.Events;
using System;

namespace InsidetheBackrooms
{
    public static class BuildInfo
    {
        public const string Name = "Inside the Backrooms Menu"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Inside the Backrooms Menu"; // Description for the Mod.  (Set as null if none)
        public const string Author = "WoodgamerHD"; // Author of the Mod.  (MUST BE SET)
        public const string Company = "DO NOT FUCKEN REPOST OR CLAIM ARE YOURS"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.3"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "https://www.unknowncheats.me/forum/unity/576759-inside-backrooms-esp.html"; // Download Link for the Mod.  (Set as null if none)
    }

    public class InsidetheBackrooms : MelonPlugin
    {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           //new                                                                                    
          string[] itemNames = new string[] { "FunDoorKey","Hammer", "RedKey","MedallionFish", "MedallionParrot", "Cassete", "Plier", "GeigerCounter", "ClockHands", "Fuse", "Hand", "Nose", "MedallionRat", "Valve", "Fingers", "Arm", "ScrewDriver", "AlmondWater", "Radio", "ProtectionSuit", "PartyHat", "MetalDetector", "Ear", "GarageCard", "Extinguisher", "Teeth", "CodeAbecedary", "GearLeverHandle", "Flashlight", "PetrolCanEmpty", "Eye", "Foot", "SewerEmergencyKey", "SewerStorageKey", "SewerCanalsKey", "Gear", "CalmingPills", "RedAccesCard","MothJelly", "BoilerRoomKeys", "VynilDish", "CurvedPipe", "Ingot8", "Pipe", "MothCoccoon", "Ingot10", "StatueFace", "StorageKey", "Ingot6" };



        bool EntitysEsp = false;
        bool Chamsesp = false;
        bool ItemsEsp = false;
        bool giftboxesp = false;
        bool InteractablePropESP = false;
        bool SafeESP = false;
        bool DoorEsp = false;
        bool RespawnDoorEsp = false;
        bool PlayersEsp = false;
        bool ElevatorEsp = false;
        bool ExitZoneEsp = false;
        bool infStamina = false;
        bool flytest = false;
        float fly_speed = 50f;
        bool GiveList = false;
        public static bool NoclipTest = false;
        private Color blackCol;
        private Color entityBoxCol;
        public static List<BaseAIEntity> BaseAI = new List<BaseAIEntity>();
        public static List<HumanDogAI> BaseAIHumanDogAI = new List<HumanDogAI>();
        public static List<PlayerController> Player = new List<PlayerController>();
        public static List<GridButtonPadlock> Elev = new List<GridButtonPadlock>();
        public static List<PlayerStats> BasePlayer = new List<PlayerStats>();
        public static List<CollectableItem> ItemObj = new List<CollectableItem>();
        public static List<Elevator> Elevator = new List<Elevator>();
        public static List<BasePlayerController> BasePlayerlocal = new List<BasePlayerController>();
        public static List<MiscTest> MiscTest = new List<MiscTest>();
        public static List<EndDoor> Door = new List<EndDoor>();
        public static List<VentDoorConnector> VentDoor = new List<VentDoorConnector>();
        public static List<RespawnDoor> RespawnDoor = new List<RespawnDoor>();
        public static List<RoomManager> RoomManager = new List<RoomManager>();
        public static List<ChatManager> ChatManager = new List<ChatManager>();
        public static List<BackroomsExitZone> BackroomsExit = new List<BackroomsExitZone>();
        public static List<BackroomsManager> BackroomsManager = new List<BackroomsManager>();
        public static List<Giftbox> Giftbox = new List<Giftbox>();
        public static List<SafeBox> SafeBox = new List<SafeBox>();
        public static List<PartygoerBalloon> PartygoerBalloon = new List<PartygoerBalloon>();
        public static List<PartygoerRoom> PartygoerRoom = new List<PartygoerRoom>();
        public static List<PartygoerCake> PartygoerCake = new List<PartygoerCake>();
        public static List<InteractableProp> InteractableProp = new List<InteractableProp>();
        public static List<Candles> Candles = new List<Candles>();
        public static List<FunLevelRoom> FunLevelRoom = new List<FunLevelRoom>();
     
    
        private Rect windowRect = new Rect(0, 0, 400, 400); // Window position and size
        private int tab = 0; // Current tab index
        private Color backgroundColor = Color.black; // Background color
        private bool showMenu = true; // Whether to show the menu or not
        private static Camera cam;
        float natNextUpdateTime;
        private static Material chamsMaterial;
        public float verticalMovement = 10f;

        public static void DoChams()
        {
            foreach (BaseAIEntity player in BaseAI)
            {
                if (player == null)
                {
                    continue;
                }

                foreach (Renderer renderer in player?.gameObject?.GetComponentsInChildren<Renderer>())
                {
                    

                        renderer.material = chamsMaterial;
                    
                }
            }
        }



        public override void OnUpdate()
        {


            natNextUpdateTime += Time.deltaTime;

            if (natNextUpdateTime >= 3f)
            {
                Player = FindObjectsOfType<PlayerController>().ToList();
                BaseAI = FindObjectsOfType<BaseAIEntity>().ToList();
                ItemObj = FindObjectsOfType<CollectableItem>().ToList();
                BasePlayer = FindObjectsOfType<PlayerStats>().ToList();
                Elevator = FindObjectsOfType<Elevator>().ToList();
                MiscTest = FindObjectsOfType<MiscTest>().ToList();
                Door = FindObjectsOfType<EndDoor>().ToList();
                RespawnDoor = FindObjectsOfType<RespawnDoor>().ToList();
                RoomManager = FindObjectsOfType<RoomManager>().ToList();
                BasePlayerlocal = FindObjectsOfType<BasePlayerController>().ToList();
                ChatManager = FindObjectsOfType<ChatManager>().ToList();
                BackroomsExit = FindObjectsOfType<BackroomsExitZone>().ToList();
                BackroomsManager = FindObjectsOfType<BackroomsManager>().ToList();
                Giftbox = FindObjectsOfType<Giftbox>().ToList();
                SafeBox = FindObjectsOfType<SafeBox>().ToList();
                PartygoerBalloon = FindObjectsOfType<PartygoerBalloon>().ToList();
                PartygoerRoom = FindObjectsOfType<PartygoerRoom>().ToList();
                PartygoerCake = FindObjectsOfType<PartygoerCake>().ToList();
                InteractableProp = FindObjectsOfType<InteractableProp>().ToList();
                Candles = FindObjectsOfType<Candles>().ToList();
                FunLevelRoom = FindObjectsOfType<FunLevelRoom>().ToList();

                if (Chamsesp)
                {
                    DoChams();
                }

                natNextUpdateTime = 0f;
            }


         

            if (Keyboard.current.insertKey.wasPressedThisFrame) // Toggle the menu when the Tab key is pressed
            {
                showMenu = !showMenu;
            
            }
            if (infStamina)
            {
                foreach (PlayerStats player in BasePlayer)
                {

                    player.Stamina = float.MaxValue;

                   

                }


            }
           
            cam = Camera.main;


        }
     


        public override void OnInitializeMelon()
        {
            // Center the window on the screen
            windowRect.x = (Screen.width - windowRect.width) / 2;
            windowRect.y = (Screen.height - windowRect.height) / 2;


            // MelonCoroutines.Start(UpdateObjects());

            // MelonCoroutines.Start(UpdateObjects());
            chamsMaterial = new Material(Shader.Find("Hidden/Internal-Colored"))
            {
                hideFlags = HideFlags.DontSaveInEditor | HideFlags.HideInHierarchy
            };


            chamsMaterial.SetInt("_Cull", 0);
            chamsMaterial.SetInt("_ZTest", 8); // 8 = see through walls.
            chamsMaterial.SetInt("_ZWrite", 0);
            chamsMaterial.SetColor("_Color", Color.red);


            blackCol = new Color(0f, 0f, 0f, 120f);
            entityBoxCol = new Color(1.42f, 0f, 0f, 1f);

        }

        public void MenuWindow(int windowID)
        {
            GUILayout.BeginHorizontal();

            // Create toggle buttons for each tab
            GUILayout.BeginVertical(GUILayout.Width(100));
            if (GUILayout.Toggle(tab == 0, "Main", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 0;
            }

            if (GUILayout.Toggle(tab == 1, "Esp", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 1;
            }
            if (GUILayout.Toggle(tab == 2, "Easter-egg", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 2;
            }
            if (GUILayout.Toggle(tab == 3, "Levels", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 3;
            }
            GUILayout.EndVertical();

            // Display content for the selected tab

            GUILayout.BeginVertical();


            // Display content for the selected tab
            switch (tab)
            {
                case 0:
              
                    infStamina = GUILayout.Toggle(infStamina, "infStamina");

                    if (GUILayout.Button("CmdKillPlayer"))
                    {
                        foreach (PlayerStats player in BasePlayer)
                        {
                            
                            player.CmdKillPlayer();

                        }
                    }

                    if (GUILayout.Button("Give List"))
                    {
                        GiveList = !GiveList;
                    }
                  
                    //PartygoerCake

                    if (GUILayout.Button("ItemDumper"))
                    {

                        StreamWriter SW = new StreamWriter("m_ItemName.txt");
                        // Find all objects in the scene
                        CollectableItem[] objects = FindObjectsOfType<CollectableItem>();



                        // Loop through the objects and print their names to the console
                        foreach (CollectableItem obj in objects)
                        {
                            SW.WriteLine(obj.m_ItemName);
                        }

                    }
                  
                    break;

                case 1:
                    // Content for tab 2
                    if (GUILayout.Button(PlayersEsp ? "Players on" : "Players off"))
                    {
                        PlayersEsp = !PlayersEsp;
                    }
                    if (GUILayout.Button(EntitysEsp ? "Entitys on" : "Entitys off"))
                    {
                        EntitysEsp = !EntitysEsp;
                    }
                    if (GUILayout.Button(ElevatorEsp ? "Elevator on" : "Elevator off"))
                    {
                        ElevatorEsp = !ElevatorEsp;
                    }
                    if (GUILayout.Button(ExitZoneEsp ? "ExitZone on" : "ExitZone off"))
                    {
                        ExitZoneEsp = !ExitZoneEsp;
                    }
                    if (GUILayout.Button(ItemsEsp ? "Items on" : "Items off"))
                    {
                        ItemsEsp = !ItemsEsp;
                    }
                    if (GUILayout.Button(giftboxesp ? "Gift on" : "Gift off"))
                    {
                        giftboxesp = !giftboxesp;
                    }
                    if (GUILayout.Button(SafeESP ? "Safe on" : "Safe off"))
                    {
                        SafeESP = !SafeESP;
                    }
                    if (GUILayout.Button(InteractablePropESP ? "Props on" : "Props off"))
                    {
                        InteractablePropESP = !InteractablePropESP;
                    }
                    if (GUILayout.Button(DoorEsp ? "Door on" : "Door off"))
                    {
                        DoorEsp = !DoorEsp;
                    }
                    if (GUILayout.Button(RespawnDoorEsp ? "RespawnDoor on" : "RespawnDoor off"))
                    {
                        RespawnDoorEsp = !RespawnDoorEsp;
                    }
                    if (GUILayout.Button(Chamsesp ? "Chams on" : "Chams off"))
                    {
                        Chamsesp = !Chamsesp;
                    }
                    break;
                case 2:
                    if (GUILayout.Button("safe unlock"))
                    {
                        foreach (SafeBox player in SafeBox)
                        {
                            player.CmdValidateCode(player.UnlockCode);
                        }
                    }
                    if (GUILayout.Button("Destroy Balloons"))
                    {
                        foreach (PartygoerBalloon player in PartygoerBalloon)
                        {
                            player.UserCode_CmdExplode();
                        }
                    }
                    if (GUILayout.Button("Open all Gifts"))
                    {
                        foreach (Giftbox player in Giftbox)
                        {
                            player.UserCode_CmdOpenGift();
                        }
                    }
                    if (GUILayout.Button("Blow all Candles"))
                    {
                        foreach (Candles player in Candles)
                        {
                            player.UserCode_CmdBlowCandle();
                        }
                    }
                    if (GUILayout.Button("Blow Candles on Cake"))
                    {
                        foreach (PartygoerCake player in PartygoerCake)
                        {
                            player.UserCode_CmdBlowCandle();
                        }
                    }
                    //EndPartyGames
                    if (GUILayout.Button("End Party Games"))
                    {
                        foreach (PartygoerRoom player in PartygoerRoom)
                        {
                            player.EndPartyGames();
                        }
                    }
                    if (GUILayout.Button("End Fun Level Room<All Players>"))
                    {
                        foreach (FunLevelRoom player in FunLevelRoom)
                        {
                            player.PerformEndForAll();
                        }
                    }

                    break;

                case 3:
                    if (GUILayout.Button("Fun-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.funLevelPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("First-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.firstLevelPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Second-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.secondLevelPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Third-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.thirdLevelPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Drainage-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.drainagePos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Parking-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.parkingPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Hallway-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.hallwayPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Pool-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.poolPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("End-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.TeleportPlayer(player.endPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("ExitZone"))
                    {
                        foreach (MiscTest playerc in MiscTest)
                        {
                                foreach (BackroomsExitZone player in BackroomsExit)
                                {  //player.DEVMODE_ENABLED = true;
                                    playerc.TeleportPlayer(player.teleportPoint.transform.position);

                            }
                        }
                    }


                    break;
            }

            GUILayout.EndVertical();

            GUILayout.EndHorizontal();
            GUI.DragWindow(); // Allow the user to drag the window around
        }
        private Vector2 scrollPosition5 = Vector2.zero;
        private static Rect Itemgivewindow = new Rect(60f, 250f, 400, 400);
        public void GiveitemsWindow(int windowID)
        {

            // Begin a scroll view to allow scrolling through the button list
            scrollPosition5 = GUILayout.BeginScrollView(scrollPosition5);

            // Create a button for each option in the options array
            for (int i = 0; i < itemNames.Length; i++)
            {
                if (GUILayout.Button(itemNames[i]))
                {
                    // Get the selected location from the locations array
                    string selectedLocation = itemNames[i];

                    foreach (PlayerStats playert in BasePlayer)
                    {
                        foreach (MiscTest player in MiscTest)
                        {
                            //player.DEVMODE_ENABLED = true;
                            player.CmdSpawnItem(selectedLocation, playert.transform.position);

                        }
                    }
                }
            }
            GUILayout.EndScrollView();

            GUI.DragWindow(); // Allow the user to drag the window around



        }

        public string bundlePath;
        public string outputPath;



        public void DumpAllPrefabs()
        {
            List<GameObject> prefabList = new List<GameObject>();

            // Loop through all the game objects in the scene
            foreach (GameObject obj in FindObjectsOfType<GameObject>())
            {
                // Check if the object is a prefab
                if (!obj.scene.IsValid())
                {
                    // Add the prefab to the list
                    prefabList.Add(obj);
                }
            }

            // Dump the list to a file
            StreamWriter writer = new StreamWriter("prefabdump.txt");
            foreach (GameObject prefab in prefabList)
            {
                writer.WriteLine(prefab.name);
            }
            writer.Close();
        }




        private float DistanceFromCamera(Vector3 worldPos)
        {
            return Vector3.Distance(cam.transform.position, worldPos);
        }
  

     

        public static List<Transform> GetAllBones(Animator a)
        {
            List<Transform> Bones = new List<Transform>
            {
                a.GetBoneTransform(HumanBodyBones.Head), // 0
                a.GetBoneTransform(HumanBodyBones.Neck), // 1
                a.GetBoneTransform(HumanBodyBones.Spine), // 2
                a.GetBoneTransform(HumanBodyBones.Hips), // 3

                a.GetBoneTransform(HumanBodyBones.LeftShoulder), // 4
                a.GetBoneTransform(HumanBodyBones.LeftUpperArm), // 5
                a.GetBoneTransform(HumanBodyBones.LeftLowerArm), // 6
                a.GetBoneTransform(HumanBodyBones.LeftHand), // 7

                a.GetBoneTransform(HumanBodyBones.RightShoulder), // 8
                a.GetBoneTransform(HumanBodyBones.RightUpperArm), // 9
                a.GetBoneTransform(HumanBodyBones.RightLowerArm), // 10
                a.GetBoneTransform(HumanBodyBones.RightHand), // 11

                a.GetBoneTransform(HumanBodyBones.LeftUpperLeg), // 12
                a.GetBoneTransform(HumanBodyBones.LeftLowerLeg), // 13
                a.GetBoneTransform(HumanBodyBones.LeftFoot), // 14

                a.GetBoneTransform(HumanBodyBones.RightUpperLeg), // 15
                a.GetBoneTransform(HumanBodyBones.RightLowerLeg), // 16
                a.GetBoneTransform(HumanBodyBones.RightFoot) // 17
            };

            return Bones;
        }
        public override void OnGUI()
        {


            if (showMenu) // Only draw the menu when showMenu is true
            {
                // Set the background color
                GUI.backgroundColor = backgroundColor;

                windowRect = GUI.Window(0, windowRect, (GUI.WindowFunction)MenuWindow, "Inside the Backrooms<WoodgamerHD>"); // Create the window with title "Menu"


                if (GiveList)
                {
                    Itemgivewindow = GUI.Window(1, Itemgivewindow, (GUI.WindowFunction)GiveitemsWindow, "Item Menu");
                }

            }



            if (PlayersEsp)
            {
                foreach (PlayerController player in Player)
                {

                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);


                    if (ESPUtils.IsOnScreen(w2s))
                    {

                        ESPUtils.DrawAllBones(GetAllBones(player.PlayerAnimator), Color.green);

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       player.components.Info.Networkm_PlayerName + "\n" + "Hidding: " + player.IsHidding + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.green, true, 12, FontStyle.Bold);
                    }

                }

            }

            if (ExitZoneEsp)
            {
                foreach (BackroomsExitZone player in BackroomsExit)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);


                    if (ESPUtils.IsOnScreen(w2s))
                    {


                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       player.name.Replace("(Clone)", "") + "\n" + "Point: " + player.teleportPoint.transform.position + "\n" + "EndGameType: " + player.endGameType, Color.magenta, true, 12, FontStyle.Bold);
                    }
                }
               
            }

          
                if (ElevatorEsp)
                {
                    foreach (Elevator player in Elevator)
                    {
                        Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);


                        if (ESPUtils.IsOnScreen(w2s))
                        {

                            ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                           player.name.Replace("(Clone)", "") + "\n" + "Code: " + player.m_InternalElevatorCode, Color.magenta, true, 12, FontStyle.Bold);
                        }
                    }
                }
            
          
                if (ItemsEsp)
                {
                    foreach (CollectableItem player in ItemObj)
                    {
                        Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                        if (ESPUtils.IsOnScreen(w2s) && DistanceFromCamera(player.transform.position) < 80)
                        {

                            ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                            player.m_ItemName, Color.blue, true, 12, FontStyle.Bold);


                        }

                    }
                }

           
            if (giftboxesp)
            {
                foreach (Giftbox player in Giftbox)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s) && DistanceFromCamera(player.transform.position) < 100)
                    {

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                        player.name.Replace("(Clone)", "") + "\n", Color.yellow, true, 12, FontStyle.Bold);


                    }

                }

            }
            //InteractableProp
            if (InteractablePropESP)
            {
                foreach (InteractableProp player in InteractableProp)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s) && DistanceFromCamera(player.transform.position) < 80)
                    {

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                        player.name.Replace("(Clone)", "") + "\n", Color.cyan, true, 12, FontStyle.Bold);


                    }

                }
            }
            if (SafeESP)
            {
                foreach (SafeBox player in SafeBox)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s) && DistanceFromCamera(player.transform.position) < 80)
                    {

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                        player.name.Replace("(Clone)", "") + "\n" + "Code: " + player.UnlockCode, Color.cyan, true, 12, FontStyle.Bold);


                    }

                }
            }
            if (RespawnDoorEsp)
            {
                foreach (RespawnDoor player in RespawnDoor)
            {

                

                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s))
                    {
                   

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                        "Respawn Door" + "\n", Color.yellow, true, 12, FontStyle.Bold);


                    }

                }

            }
            if (DoorEsp)
            {
                foreach (EndDoor player in Door)
                    {        


                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s))
                    {
                     
                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                        "End Door" + "\n", Color.cyan, true, 12, FontStyle.Bold);


                    }

                }

            }
            if (EntitysEsp)
            {
                foreach (BaseAIEntity player in BaseAI)
            {

              

                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);
                
                    if (ESPUtils.IsOnScreen(w2s))
                    {



                        //     ESPUtils.DrawAllBones(GetAllBones(player.b), Color.red);

                        Vector3 p = player.transform.position;
                        Vector3 s = player.transform.localScale;
                        if (p != null & s != null)
                            ESPUtils.Draw3DBox(new Bounds(p + new Vector3(0, 1.1f, 0), s + new Vector3(0, .95f, 0)), Color.red);


                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                          player.name.Replace("(Clone)", "") + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}" + "\n" + "State: " + player.State, Color.red, true, 12, FontStyle.Bold);


                    }

                }

            }
          
        }



     
    }
}
