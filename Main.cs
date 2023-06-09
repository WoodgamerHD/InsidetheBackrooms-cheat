using MelonLoader;
using UnityEngine;
using static UnityEngine.Object;
using UnityEngine.InputSystem;
using Il2Cpp;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using HarmonyLib;
using static Il2Cpp.AnniversaryEvent;

namespace InsidetheBackrooms
{
    public static class BuildInfo
    {
        public const string Name = "Inside the Backrooms Menu"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Inside the Backrooms Menu"; // Description for the Mod.  (Set as null if none)
        public const string Author = "WoodgamerHD"; // Author of the Mod.  (MUST BE SET)
        public const string Company = "DO NOT FUCKEN REPOST OR CLAIM ARE YOURS"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.4"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "https://github.com/WoodgamerHD/InsidetheBackrooms-cheat"; // Download Link for the Mod.  (Set as null if none)
    }

    public class InsidetheBackrooms : MelonPlugin
    {
    
    
                                                                                        
        string[] itemNames = new string[]
{
    "AlmondWater", "Arm", "BoilerRoomKeys","Bucket", "CalmingPills", "Cassete", "ClockHands", "CodeAbecedary", "CurvedPipe","Dart", "Ear",
    "Extinguisher", "Eye", "Fingers", "Flashlight", "Foot", "FunDoorKey", "Fuse", "GarageCard", "Gear", "GearLeverHandle",
    "GeigerCounter", "Hammer", "Hand", "Ingot6", "Ingot8", "Ingot10", "MotionSensor", "MedallionFish", "MedallionParrot", "MedallionRat",
    "MetalDetector", "MothCoccoon", "MothJelly", "Nose", "PartyHat", "PetrolCanEmpty", "Pipe", "Plier", "ProtectionSuit",
    "Radio", "RedAccesCard", "RedKey","Snowball", "ScrewDriver", "SewerCanalsKey", "SewerEmergencyKey", "SewerStorageKey",
    "StatueFace", "StorageKey", "Teeth", "Valve", "VynilDish"
};
        string[] Boosteritem = new string[]
    {  "AlmondWater","CalmingPills", "MothJelly","Flashlight","Radio" };

        string[] DarkRoomsParking = new string[] {
            "ClockHands", "Cassete", "ScrewDriver", "Hammer", "RedAccesCard", "Fuse", "Plier","GeigerCounter","Extinguisher","ProtectionSuit","Valve","GarageCard",
            "Ear", "Eye", "Fingers", "Foot", "Hand","Nose","Teeth" };

        string[] OfficeItems = new string[] { "MotionSensor", "CodeAbecedary", "PartyHat", "RedAccesCard", "Head" };

        string[] Sewersitems = new string[] { "SewerCanalsKey", "SewerEmergencyKey", "SewerStorageKey",
            "MetalDetector", "MedallionRat", "MedallionFish", "MedallionParrot", "PetrolCanEmpty","Bucket","Gear","GearLeverHandle" };

        string[] terrorhotelitems = new string[] { "Ingot6", "Ingot8", "Ingot10", "StatueFace", "StorageKey", "VyniiDish", "Candle", "BoilerRoomKeys", "Pipe", "CurvedPipe", "MothCoccoon" };



       
        private bool EntitysEsp = false;
        private bool Chamsesp = false;
        private bool ItemsEsp = false;
        private bool giftboxesp = false;
        private bool NumericLockesp = false;
        private bool NumericPad3esp = false;
        private bool InteractablePropESP = false;
        private bool SafeESP = false;
        private bool DoorEsp = false;
        private bool RespawnDoorEsp = false;
        private bool PlayersEsp = false;
        private bool GhostPlayersEsp = false;
        private bool ElevatorEsp = false;
        private bool ExitZoneEsp = false;
        private bool infStamina = false;
        private bool Godmode = false;
      
        private bool Computeresp = false;
        private bool LetterLockesp = false;
        private bool LeverDoorLockesp = false;
        private bool Clockesp = false;
        private bool Boxtoggle = false;
      

        private bool GiveList = false;
       

        public static bool NoclipTest = false;
        private Color blackCol;
        private Color entityBoxCol;
        public static List<BaseAIEntity> BaseAI = new List<BaseAIEntity>();
        public static List<PlayerController> Player = new List<PlayerController>();
        public static List<GhostPlayerController> GhostPlayer = new List<GhostPlayerController>();
        public static List<PlayerStats> BasePlayer = new List<PlayerStats>();
        public static List<CollectableItem> ItemObj = new List<CollectableItem>();
        public static List<Elevator> Elevator = new List<Elevator>();       
        public static List<MiscTest> MiscTest = new List<MiscTest>();
        public static List<EndDoor> Door = new List<EndDoor>();   
        public static List<RespawnDoor> RespawnDoor = new List<RespawnDoor>();
        public static List<BackroomsExitZone> BackroomsExit = new List<BackroomsExitZone>();
        public static List<Giftbox> Giftbox = new List<Giftbox>();
        public static List<SafeBox> SafeBox = new List<SafeBox>();
        public static List<PartygoerBalloon> PartygoerBalloon = new List<PartygoerBalloon>();
        public static List<PartygoerRoom> PartygoerRoom = new List<PartygoerRoom>();
        public static List<PartygoerCake> PartygoerCake = new List<PartygoerCake>();
        public static List<InteractableProp> InteractableProp = new List<InteractableProp>();
        public static List<Candles> Candles = new List<Candles>();
        public static List<FunLevelRoom> FunLevelRoom = new List<FunLevelRoom>();
        public static List<NetworkReparent> NetworkReparent = new List<NetworkReparent>();
        public static List<NumericLock> NumericLock = new List<NumericLock>();
        public static List<MonsterSpawner> MonsterSpawner = new List<MonsterSpawner>();
        public static List<NumericPad3> NumericPad3 = new List<NumericPad3>();
        public static List<OldPhone> OldPhone = new List<OldPhone>();  
        public static List<AirVent> AirVent = new List<AirVent>();
        public static List<ComputersScreenPuzzle> ComputersScreenPuzzle = new List<ComputersScreenPuzzle>();
        public static List<LetterLock> LetterLock = new List<LetterLock>();
        public static List<ClockPuzzle> ClockPuzzle = new List<ClockPuzzle>();
        public static List<InGameLobby> InGameLobby = new List<InGameLobby>();
        public static List<AnniversaryEvent> AnniversaryEvent = new List<AnniversaryEvent>();
        
        public static Color TestColor
        {
            get
            {
                return new Color(1.2f, 3f, 4.1f, 1f);
            }
        }
        public static float customNameR = 1f; // Initial red value
        public static float customNameG = 0f; // Initial green value
        public static float customNameB = 0f; // Initial blue value
        private Rect windowRect = new Rect(0, 0, 400, 400); // Window position and size
        private int tab = 0; // Current tab index
        private int tab2 = 0; // Current tab index
        private int tab3 = 0; // Current tab index
        private int tabitem = 0; // Current tab index
        private Color backgroundColor = Color.black; // Background color
        private bool showMenu = true; // Whether to show the menu or not
        private static Camera cam;
        float natNextUpdateTime;
    
        private static Material xray;

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


                    renderer.material = xray;

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
                Giftbox = FindObjectsOfType<Giftbox>().ToList();
                SafeBox = FindObjectsOfType<SafeBox>().ToList();
                PartygoerBalloon = FindObjectsOfType<PartygoerBalloon>().ToList();
                PartygoerRoom = FindObjectsOfType<PartygoerRoom>().ToList();
                PartygoerCake = FindObjectsOfType<PartygoerCake>().ToList();
                InteractableProp = FindObjectsOfType<InteractableProp>().ToList();
                Candles = FindObjectsOfType<Candles>().ToList();
                FunLevelRoom = FindObjectsOfType<FunLevelRoom>().ToList();
                NetworkReparent = FindObjectsOfType<NetworkReparent>().ToList();
                NumericLock = FindObjectsOfType<NumericLock>().ToList();
                MonsterSpawner = FindObjectsOfType<MonsterSpawner>().ToList();
                NumericPad3 = FindObjectsOfType<NumericPad3>().ToList();
                OldPhone = FindObjectsOfType<OldPhone>().ToList();
                AirVent = FindObjectsOfType<AirVent>().ToList(); 
                ComputersScreenPuzzle = FindObjectsOfType<ComputersScreenPuzzle>().ToList();
                LetterLock = FindObjectsOfType<LetterLock>().ToList();
                ClockPuzzle = FindObjectsOfType<ClockPuzzle>().ToList();
                InGameLobby = FindObjectsOfType<InGameLobby>().ToList();
                AnniversaryEvent = FindObjectsOfType<AnniversaryEvent>().ToList();
               
                
                if(Chamsesp)
                {
                    DoChams();
                }

                natNextUpdateTime = 0f;
            }




            if (Keyboard.current.insertKey.wasPressedThisFrame)
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
         
           

            if (Godmode)
            {
                foreach (PlayerStats player in BasePlayer)
                {
                 
                        player.health = float.MaxValue;
                        player.anxiety = 0;
                        player.m_Radiation = 0;
                        player.m_HasEnergyBoost = true;
                        player.m_Paralized = false;
                        player.m_HasInvulnerability = true;
                        player.Networkm_HasInvulnerability = true;
                  
                     
                }
            }
            
            cam = Camera.main;


        }
    
      


        public override void OnInitializeMelon()
        {
            // Center the window on the screen
            windowRect.x = (Screen.width - windowRect.width) / 2;
            windowRect.y = (Screen.height - windowRect.height) / 2;

            xray = new Material(Shader.Find("Hidden/Internal-Colored"))
            {
                hideFlags = HideFlags.HideAndDontSave | HideFlags.DontUnloadUnusedAsset
             };

            xray.SetInt("_ZTest", 8);
            xray.SetColor("_Color", Color.green);

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
            if (GUILayout.Toggle(tab == 4, "Level-Stuff", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 4;
            }
            if (GUILayout.Toggle(tab == 5, "Debug", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 5;
            }
             if (GUILayout.Toggle(tab == 6, "Unlocker", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 6;
            }
         
            GUILayout.EndVertical();

            // Display content for the selected tab


            GUILayout.BeginArea(new Rect(10, windowRect.height - 30, windowRect.width - 20, 40));
            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Save Config"))
            {
                SaveConfig();
            }

            if (GUILayout.Button("Load Config"))
            {
                LoadConfig();

            }

            GUILayout.EndHorizontal();
            GUILayout.EndArea();



            GUILayout.BeginVertical();


            // Display content for the selected tab
            switch (tab)
            {
                case 0:
                    GUILayout.BeginVertical(GUI.skin.box);

                    GUILayout.BeginHorizontal();
                    GUILayout.BeginVertical();
                    Godmode = GUILayout.Toggle(Godmode, "GodMode<WIP>");
                    infStamina = GUILayout.Toggle(infStamina, "infStamina");
                    GUILayout.EndVertical();

                    GUILayout.Space(10);

                    GUILayout.BeginVertical();
                    GiveList = GUILayout.Toggle(GiveList, "GiveList");
                  
                 
                    GUILayout.EndVertical();

                    GUILayout.EndHorizontal();

                    GUILayout.EndVertical();

              

                    break;

                case 1:

                    GUILayout.BeginHorizontal();
                    if (GUILayout.Toggle(tab2 == 0, "Main", "Button", GUILayout.ExpandWidth(true)))
                    {
                        tab2 = 0;
                    }

                    if (GUILayout.Toggle(tab2 == 1, "Locks", "Button", GUILayout.ExpandWidth(true)))
                    {
                        tab2 = 1;
                    }
                    GUILayout.EndHorizontal();

                    switch (tab2)
                    {
                        case 0:
                            GUILayout.BeginVertical(GUI.skin.box);

                            GUILayout.BeginHorizontal();
                            GUILayout.BeginVertical();
                            PlayersEsp = GUILayout.Toggle(PlayersEsp, "Players");
                            GhostPlayersEsp = GUILayout.Toggle(GhostPlayersEsp, "GhostPlayers");

                            GUILayout.EndVertical();

                            GUILayout.Space(10);

                            GUILayout.BeginVertical();
                            EntitysEsp = GUILayout.Toggle(EntitysEsp, "Entitys");
                            Chamsesp = GUILayout.Toggle(Chamsesp, "Chams");
                            Boxtoggle = GUILayout.Toggle(Boxtoggle, "Box");
                           
                            GUILayout.EndVertical();

                            GUILayout.EndHorizontal();

                            GUILayout.EndVertical();
                            break;
                          
                        case 1:
                            GUILayout.BeginVertical(GUI.skin.box);

                            GUILayout.BeginHorizontal();
                            GUILayout.BeginVertical();
                            LetterLockesp = GUILayout.Toggle(LetterLockesp, "LetterLock");
                            Computeresp = GUILayout.Toggle(Computeresp, "Computer");
                            giftboxesp = GUILayout.Toggle(giftboxesp, "Gift");
                            NumericLockesp = GUILayout.Toggle(NumericLockesp, "NumericLock");
                            RespawnDoorEsp = GUILayout.Toggle(RespawnDoorEsp, "RespawnDoor");
                            Clockesp = GUILayout.Toggle(Clockesp, "Clock");

                            GUILayout.EndVertical();

                            GUILayout.Space(10);

                            GUILayout.BeginVertical();
                            ItemsEsp = GUILayout.Toggle(ItemsEsp, "Items");
                            SafeESP = GUILayout.Toggle(SafeESP, "Safe");
                            ElevatorEsp = GUILayout.Toggle(ElevatorEsp, "Elevator");
                            DoorEsp = GUILayout.Toggle(DoorEsp, "Door");
                            NumericPad3esp = GUILayout.Toggle(NumericPad3esp, "NumericPad");
                            LeverDoorLockesp = GUILayout.Toggle(LeverDoorLockesp, "LeverDoor");
                            GUILayout.EndVertical();

                            GUILayout.EndHorizontal();

                            GUILayout.EndVertical();


                            break;

                           

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

                           
                            player.TeleportPlayer(player.funLevelPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("First-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                           
                            player.TeleportPlayer(player.firstLevelPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Second-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                           
                            player.TeleportPlayer(player.secondLevelPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Third-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                           
                            player.TeleportPlayer(player.thirdLevelPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Drainage-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                           
                            player.TeleportPlayer(player.drainagePos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Parking-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                           
                            player.TeleportPlayer(player.parkingPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Hallway-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                           
                            player.TeleportPlayer(player.hallwayPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("Pool-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                           
                            player.TeleportPlayer(player.poolPos.transform.position);

                        }
                    }
                    if (GUILayout.Button("End-Level"))
                    {

                        foreach (MiscTest player in MiscTest)
                        {
                           
                            player.TeleportPlayer(player.endPos.transform.position);

                        }
                    }
                   


                    break;
                case 4:
                    if (GUILayout.Button("Close Vents<idk>"))
                    {
                        
                        foreach (AirVent player in AirVent)
                        {
                            player.UserCode_CmdClose();
                        }
                    }
                 

                    break;
                case 5:
                    if (GUILayout.Button("CmdKillPlayer<wip>"))
                    {
                        foreach (PlayerStats player in BasePlayer)
                        {
                            if (player.isLocalPlayer)
                            {

                                player.UserCode_CmdKillPlayer();
                                player.CmdKillPlayer();
                            }
                        }
                    }
                    if (GUILayout.Button("DoRespawn<wip>"))
                    {
                        foreach (RespawnDoor player in RespawnDoor)
                        {
                            
                                player.DoRespawn();
                                player._DoRespawn_b__27_0();
                            
                        }
                    }
                   
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
              
                case 6:
                    GUILayout.BeginHorizontal();
                    if (GUILayout.Toggle(tab3 == 0, "Main", "Button", GUILayout.ExpandWidth(true)))
                    {
                        tab3 = 0;
                    }

                    if (GUILayout.Toggle(tab3 == 1, "Anniversary", "Button", GUILayout.ExpandWidth(true)))
                    {
                        tab3 = 1;
                    }
                    GUILayout.EndHorizontal();

                 

                    switch (tab3)
                    {
                        case 0:
                            GUILayout.Label("Reach levels and complete time to 69");
                            if (GUILayout.Button("SteamStat<Levels>"))
                            {
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.COMPLETE_TIME, 69);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.REACH_DARKROOMS, 1);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.REACH_FUNROOM, 1);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.REACH_OFFICEROOMS, 1);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.REACH_PARKING, 1);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.REACH_SEWER, 1);

                            }
                              GUILayout.Label("Unlocks 1-5 levels");
                            if (GUILayout.Button("UnlockAchievements<Levels>"))
                            {
                            
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LEVEL_1);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LEVEL_2);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LEVEL_3);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LEVEL_4);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_SEWER_LEVEL);
                               
                            }
                            GUILayout.Label("Unlocks all Achievements");
                            if (GUILayout.Button("UnlockAchievements"))
                            {
                     

                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LEVEL_1);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LEVEL_2);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LEVEL_3);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LEVEL_4);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.HOUND_VICTIM);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.BACT_VICTIM);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.SMILER_VICTIM);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.PARTYGOER_VICTIM);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.SKINSTEALER_VICTIM);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.CLUMPS_VICTIM);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_ESCAPE_BACKROOMS);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_NO_DIE);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_SPEEDRUNNER);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_SEWER_LEVEL);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_FUNLEVEL_ENDING);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_LOST_ENDING);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_HOTEL_LEVEL);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_EASY_COMPLETE);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_MEDIUM_COMPLETE);
                                AchievmentManager.UnlockAchievement(AchievmentManager.Achievement.ACH_HARD_COMPLETE);
                            
                              
                            }
                          
                            break;
                        case 1:
                            GUILayout.Label("Do this in Game Singleplayer only");

                            if (GUILayout.Button("AnniversaryEventComplete"))
                            {
                                foreach (AnniversaryEvent player in AnniversaryEvent)
                                {

                                    player.CompleteEvent();

                                }
                            }
                            if (GUILayout.Button("StartAnniversaryEvent"))
                            {
                                foreach (AnniversaryEvent player in AnniversaryEvent)
                                {

                                    player.UserCode_RpcStartGame();

                                }

                            }
                            if (GUILayout.Button("EndAnniversaryEvent"))
                            {
                                foreach (AnniversaryEvent player in AnniversaryEvent)
                                {

                                    player.UserCode_RpcEndEvent();

                                }
                            }
                            GUILayout.Label("Press SteamStat to unlock all the event stuff");

                            if (GUILayout.Button("SteamStat event"))
                            {
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.ANNIVERSARY_EV_23, 1);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.ANNIVERSARY_EV_23_RWD1, 1);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.ANNIVERSARY_EV_23_RWD2, 1);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.ANNIVERSARY_EV_23_RWD3, 1);
                                AchievmentManager.SetNewStatValue(AchievmentManager.SteamStat.ANNIVERSARY_EV_23_RWD4, 1);
                            }
                        
                            break;
                    }
                            break;
               

                  
            }

            GUILayout.EndVertical();

            GUILayout.EndHorizontal();
            GUI.DragWindow(); // Allow the user to drag the window around
        }
        private Vector2 scrollPosition5 = Vector2.zero;
        private Vector2 scrollPosition7 = Vector2.zero;
        private static Rect Itemgivewindow = new Rect(60f, 250f, 400, 400);
        public void GiveitemsWindow(int windowID)
        {
            GUILayout.BeginHorizontal();


            if (GUILayout.Toggle(tabitem == 0, "All-items", "Button", GUILayout.ExpandWidth(true)))
            {
                tabitem = 0;
            }
            if (GUILayout.Toggle(tabitem == 1, "Aid", "Button", GUILayout.ExpandWidth(true)))
            {
                tabitem = 1;
            }
            if (GUILayout.Toggle(tabitem == 2, "Parking", "Button", GUILayout.ExpandWidth(true)))
            {
                tabitem = 2;
            }
            if (GUILayout.Toggle(tabitem == 3, "Office", "Button", GUILayout.ExpandWidth(true)))
            {
                tabitem = 3;
            }
            if (GUILayout.Toggle(tabitem == 4, "Sewers", "Button", GUILayout.ExpandWidth(true)))
            {
                tabitem = 4;
            }
            if (GUILayout.Toggle(tabitem == 5, "Hotel", "Button", GUILayout.ExpandWidth(true)))
            {
                tabitem = 5;
            }
            GUILayout.EndHorizontal();




            switch (tabitem)
            {
                case 0:
                    // Begin a scroll view to allow scrolling through the button list
                    scrollPosition5 = GUILayout.BeginScrollView(scrollPosition5);

                    // Create a button for each option in the options array
                    for (int i = 0; i < itemNames.Length; i++)
                    {
                        if (GUILayout.Button(itemNames[i]))
                        {
                            // Get the selected location from the locations array
                            string selectedLocation = itemNames[i];

                            foreach (NetworkReparent playert in NetworkReparent)
                            {
                                foreach (MiscTest player in MiscTest)
                                {
                                   
                                    player.CmdSpawnItem(selectedLocation, playert.localplayerParent.position);

                                }
                            }
                        }
                    }
                    GUILayout.EndScrollView();
                    break;
                case 1:
                    // Begin a scroll view to allow scrolling through the button list
                    scrollPosition5 = GUILayout.BeginScrollView(scrollPosition5);

                    // Create a button for each option in the options array
                    for (int i = 0; i < Boosteritem.Length; i++)
                    {
                        if (GUILayout.Button(Boosteritem[i]))
                        {
                            // Get the selected location from the locations array
                            string selectedLocation = Boosteritem[i];

                            foreach (NetworkReparent playert in NetworkReparent)
                            {
                                foreach (MiscTest player in MiscTest)
                                {
                                   
                                    player.CmdSpawnItem(selectedLocation, playert.localplayerParent.position);

                                }
                            }
                        }
                    }
                    GUILayout.EndScrollView();

                    break;
                case 2:
                    // Begin a scroll view to allow scrolling through the button list
                    scrollPosition5 = GUILayout.BeginScrollView(scrollPosition5);

                    // Create a button for each option in the options array
                    for (int i = 0; i < DarkRoomsParking.Length; i++)
                    {
                        if (GUILayout.Button(DarkRoomsParking[i]))
                        {
                            // Get the selected location from the locations array
                            string selectedLocation = DarkRoomsParking[i];

                            foreach (NetworkReparent playert in NetworkReparent)
                            {
                                foreach (MiscTest player in MiscTest)
                                {
                                   
                                    player.CmdSpawnItem(selectedLocation, playert.localplayerParent.position);

                                }
                            }
                        }
                    }
                    GUILayout.EndScrollView();

                    break;
                case 3:
                    // Begin a scroll view to allow scrolling through the button list
                    scrollPosition5 = GUILayout.BeginScrollView(scrollPosition5);

                    // Create a button for each option in the options array
                    for (int i = 0; i < OfficeItems.Length; i++)
                    {
                        if (GUILayout.Button(OfficeItems[i]))
                        {
                            // Get the selected location from the locations array
                            string selectedLocation = OfficeItems[i];

                            foreach (NetworkReparent playert in NetworkReparent)
                            {
                                foreach (MiscTest player in MiscTest)
                                {
                                   
                                    player.CmdSpawnItem(selectedLocation, playert.localplayerParent.position);

                                }
                            }
                        }
                    }
                    GUILayout.EndScrollView();
                    break;
                case 4:
                    // Begin a scroll view to allow scrolling through the button list
                    scrollPosition5 = GUILayout.BeginScrollView(scrollPosition5);

                    // Create a button for each option in the options array
                    for (int i = 0; i < Sewersitems.Length; i++)
                    {
                        if (GUILayout.Button(Sewersitems[i]))
                        {
                            // Get the selected location from the locations array
                            string selectedLocation = Sewersitems[i];

                            foreach (NetworkReparent playert in NetworkReparent)
                            {
                                foreach (MiscTest player in MiscTest)
                                {
                                   
                                    player.CmdSpawnItem(selectedLocation, playert.localplayerParent.position);

                                }
                            }
                        }
                    }
                    GUILayout.EndScrollView();
                    break;
                case 5:
                    // Begin a scroll view to allow scrolling through the button list
                    scrollPosition5 = GUILayout.BeginScrollView(scrollPosition5);
                 
                    // Create a button for each option in the options array
                    for (int i = 0; i < terrorhotelitems.Length; i++)
                    {
                        if (GUILayout.Button(terrorhotelitems[i], GUILayout.ExpandWidth(true)))
                        {
                            // Get the selected location from the locations array
                            string selectedLocation = terrorhotelitems[i];

                            foreach (NetworkReparent playert in NetworkReparent)
                            {
                                foreach (MiscTest player in MiscTest)
                                {
                                   
                                    player.CmdSpawnItem(selectedLocation, playert.localplayerParent.position);

                                }
                            }
                        }
                    }
                   
                    GUILayout.EndScrollView();
                    break;
            }


            GUI.DragWindow(); // Allow the user to drag the window around



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



        void SaveConfig()
        {
            PlayerPrefs.SetInt("EntitysEsp", EntitysEsp ? 1 : 0);
            PlayerPrefs.SetInt("Chamsesp", Chamsesp ? 1 : 0);
            PlayerPrefs.SetInt("ItemsEsp", ItemsEsp ? 1 : 0);
            PlayerPrefs.SetInt("giftboxesp", giftboxesp ? 1 : 0);
            PlayerPrefs.SetInt("NumericLockesp", NumericLockesp ? 1 : 0);
            PlayerPrefs.SetInt("NumericPad3esp", NumericPad3esp ? 1 : 0);
            PlayerPrefs.SetInt("InteractablePropESP", InteractablePropESP ? 1 : 0);
            PlayerPrefs.SetInt("SafeESP", SafeESP ? 1 : 0);
            PlayerPrefs.SetInt("DoorEsp", DoorEsp ? 1 : 0);
            PlayerPrefs.SetInt("RespawnDoorEsp", RespawnDoorEsp ? 1 : 0);
            PlayerPrefs.SetInt("PlayersEsp", PlayersEsp ? 1 : 0);
            PlayerPrefs.SetInt("GhostPlayersEsp", GhostPlayersEsp ? 1 : 0);
            PlayerPrefs.SetInt("ElevatorEsp", ElevatorEsp ? 1 : 0);
            PlayerPrefs.SetInt("ExitZoneEsp", ExitZoneEsp ? 1 : 0);
            PlayerPrefs.SetInt("infStamina", infStamina ? 1 : 0);
            PlayerPrefs.SetInt("Godmode", Godmode ? 1 : 0);
            PlayerPrefs.SetInt("Computeresp", Computeresp ? 1 : 0);
            PlayerPrefs.SetInt("LetterLockesp", LetterLockesp ? 1 : 0);
            PlayerPrefs.SetInt("LeverDoorLockesp", LeverDoorLockesp ? 1 : 0);
            PlayerPrefs.SetInt("Clockesp", Clockesp ? 1 : 0);
            PlayerPrefs.SetInt("Boxtoggle", Boxtoggle ? 1 : 0);
            PlayerPrefs.SetInt("GiveList", GiveList ? 1 : 0);

            PlayerPrefs.Save();
            Debug.Log("Config saved.");
        }

        void LoadConfig()
        {
            if (PlayerPrefs.HasKey("EntitysEsp"))
            {
                EntitysEsp = PlayerPrefs.GetInt("EntitysEsp") == 1;
                Chamsesp = PlayerPrefs.GetInt("Chamsesp") == 1;
                ItemsEsp = PlayerPrefs.GetInt("ItemsEsp") == 1;
                giftboxesp = PlayerPrefs.GetInt("giftboxesp") == 1;
                NumericLockesp = PlayerPrefs.GetInt("NumericLockesp") == 1;
                NumericPad3esp = PlayerPrefs.GetInt("NumericPad3esp") == 1;
                InteractablePropESP = PlayerPrefs.GetInt("InteractablePropESP") == 1;
                SafeESP = PlayerPrefs.GetInt("SafeESP") == 1;
                DoorEsp = PlayerPrefs.GetInt("DoorEsp") == 1;
                RespawnDoorEsp = PlayerPrefs.GetInt("RespawnDoorEsp") == 1;
                PlayersEsp = PlayerPrefs.GetInt("PlayersEsp") == 1;
                GhostPlayersEsp = PlayerPrefs.GetInt("GhostPlayersEsp") == 1;
                ElevatorEsp = PlayerPrefs.GetInt("ElevatorEsp") == 1;
                ExitZoneEsp = PlayerPrefs.GetInt("ExitZoneEsp") == 1;
                infStamina = PlayerPrefs.GetInt("infStamina") == 1;
                Godmode = PlayerPrefs.GetInt("Godmode") == 1;
                Computeresp = PlayerPrefs.GetInt("Computeresp") == 1;
                LetterLockesp = PlayerPrefs.GetInt("LetterLockesp") == 1;
                LeverDoorLockesp = PlayerPrefs.GetInt("LeverDoorLockesp") == 1;
                Clockesp = PlayerPrefs.GetInt("Clockesp") == 1;
                Boxtoggle = PlayerPrefs.GetInt("Boxtoggle") == 1;
                GiveList = PlayerPrefs.GetInt("GiveList") == 1;

                Debug.Log("Config loaded.");
            }
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


                    if (ESPUtils.IsOnScreen(w2s) && !player.isLocalPlayer)
                    {

                        ESPUtils.DrawAllBones(GetAllBones(player.PlayerAnimator), Color.green);

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       player.components.Info.m_PlayerName + "\n" + "Hidding: " + player.IsHidding + "\n" + "Rank: " + player.components.Info.PlayerEmblem + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.green, true, 12, FontStyle.Bold);
                    }

                }

            }
            if(GhostPlayersEsp)
            {
                foreach (GhostPlayerController player in GhostPlayer)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);


                    if (ESPUtils.IsOnScreen(w2s) && !player.isLocalPlayer)
                    {

                        ESPUtils.DrawAllBones(GetAllBones(player.PlayerAnimator), TestColor);

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       player.m_PlayerName + "\n" + "Ghost" + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", TestColor, true, 12, FontStyle.Bold);
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
                       player.name.Replace("(Clone)", "") + "\n" + "Code: " + player.m_InternalElevatorCode + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.magenta, true, 12, FontStyle.Bold);
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
                        player.name.Replace("(Clone)", "") + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.yellow, true, 12, FontStyle.Bold);


                    }

                }

            }
           
            if (InteractablePropESP)
            {
                foreach (InteractableProp player in InteractableProp)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s) && DistanceFromCamera(player.transform.position) < 80)
                    {

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                        player.name.Replace("(Clone)", "") + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.blue, true, 12, FontStyle.Bold);


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
                        player.name.Replace("(Clone)", "") + "\n" + "Code: " + player.UnlockCode + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.cyan, true, 12, FontStyle.Bold);


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
                        "Respawn Door" + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.yellow, true, 12, FontStyle.Bold);


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
                        "End Door" + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.cyan, true, 12, FontStyle.Bold);


                    }

                }

            }
            if (NumericLockesp)
            {
                foreach (NumericLock player in NumericLock)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s))
                    {
                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       "Pad-lock" + "\n" + "Code: " + player.m_NeededCode + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.cyan, true, 12, FontStyle.Bold);
                    }

                }
            }
            if (NumericPad3esp)
            {
                foreach (NumericPad3 player in NumericPad3)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s))
                    {
                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       "Pad" + "\n" + "Code: " + player.m_CorrectCode + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.cyan, true, 12, FontStyle.Bold);
                    }

                }
            }
            if (Clockesp)
            {
                foreach (ClockPuzzle player in ClockPuzzle)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s))
                    {
                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       "Clock" + "\n" + "Hour: " + player.GetHourText() + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.cyan, true, 12, FontStyle.Bold);
                    }

                }
            }
            if (Computeresp)
            {
                foreach (ComputersScreenPuzzle player in ComputersScreenPuzzle)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s))
                    {
                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       "Computer" + "\n" + "Code: " + player.m_PuzzleCode + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.cyan, true, 12, FontStyle.Bold);
                    }

                }
            }

            if (LetterLockesp)
            {
                foreach (LetterLock player in LetterLock)
                {
                    Vector3 w2s = cam.WorldToScreenPoint(player.transform.position);

                    if (ESPUtils.IsOnScreen(w2s))
                    {
                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                       "Letter-Lock" + "\n" + "Code: " + player.m_CorrectCode + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.cyan, true, 12, FontStyle.Bold);
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
                        if (Boxtoggle)
                        {
                            Vector3 p = player.transform.position;
                            Vector3 s = player.transform.localScale;
                            if (p != null & s != null)
                                ESPUtils.Draw3DBox(new Bounds(p + new Vector3(0, 1.1f, 0), s + new Vector3(0, .95f, 0)), Color.red);
                        }
                  

                        ESPUtils.DrawString(new Vector2(w2s.x, UnityEngine.Screen.height - w2s.y + 8f),
                          player.name.Replace("(Clone)", "") +  "\n" + "State: " + player.State + "\n" + $"M:{DistanceFromCamera(player.transform.position).ToString("F1")}", Color.red, true, 12, FontStyle.Bold);


                    }

                }

            }

        }




    }
}
