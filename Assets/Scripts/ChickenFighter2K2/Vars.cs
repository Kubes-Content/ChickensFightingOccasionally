using System;
using System.Linq;
using UnityEngine;

namespace ChickenFighter2K2
{
    // ReSharper disable InconsistentNaming
    public static class Vars // default values assumed // Dec. 21, 2021
    {
        //public const VbSrcPaint = &HEE00C6;
        //public const VbSrcAnd = &H8800C6;

        public static byte DrawTheWeather = 1; // 'For slow machines, it will not autorefresh the map. 1 means yes, 0 means no
        public static byte MidiEnabled = 1; // '1 means yes, 0 means no
        public static string NameOfFile = string.Empty; // 'for opening files
        public static string CustomName = string.Empty; // 'the custom character
        public static byte[,] MapTile = new byte[40,30]; // WARNING: CF2k2 source uses a 1-based array, not 0-based
        public static bool AutoEnable = false; // 'true means autobattle
        public static byte AutoTaunt = 0; // '1 means yes, 0 means no
        public static byte HeroX = 0;
        public static byte HeroY = 0; // 'hero xy cordinates
        public static byte Map = 0; // '0-5
        public static byte MoveHero = 0; // 'used to figure out walk animation
        public static byte MoveDirection = 0; // 'direction hero is facing
        public static byte MoveChicken = 0; // 'used to figure out walk animation for chicken
        public static byte MoveDirection2 = 0; // 'direction chicken is facing
        public static byte ChickenX = 0;
        public static byte ChickenY = 0;
        public static byte ChickenXX = 0;
        public static byte ChickenYY = 0;
        public static byte GameType = 0; // '0 = story, 1 = arcade
        public static KeyCode KeyRight = KeyCode.D; // 'keycode for move right
        public static KeyCode KeyLeft = KeyCode.A; // 'keycode for move left
        public static KeyCode KeyUp = KeyCode.W; // 'keycode for move up
        public static KeyCode KeyDown = KeyCode.S; // 'keycode for move down
        public static KeyCode KeySELECT = KeyCode.Space; // 'keycode for move select
        public static KeyCode KeyTAUNT = KeyCode.R; // 'keycode for taunting
        public static byte BackTile = 0; // 'refers to backtile
        public static string CommandLine = string.Empty; // 'commandline arguments
        public static byte Talk = 0; // 'how far hero is in game
        public static byte MyType = 0; // '1 for just ok, 2 for buy/exit
        public static int Cash = 0; // 'total number of money hero has
        public static byte SONG = 0; // 'what song needs to be played
        public static bool QUIT = false; // 'if true then quit to menu screen
        public static bool DOSAVE = false; // 'if true then we are saving
        public static string[] SAVEINI = Enumerable.Repeat(string.Empty, 4).ToArray(); // 'the save.ini file
        public static byte ChickenMapType = 0;
        public static byte ChooseType = 0; // 'for the frmchoose, 0 = fight, 1 = slaughterhouse
        public static byte Chicken = 0; // '0-2, the number that was chosen (for items)
        public static byte FightType = 0; // '0-5, the difficulty of the fight and how much exp/cash you get
        public static string[] Taunts = new string[29]; // 'orginal taunts you can do by pressing space
        public static string[] Taunts2 = new string[29]; // 'custom taunts you can do by pressing space
        public static byte ArcadeType = 0;
        public static byte WhoAmI = 0; // '1 = server, 2 = client
        public static bool DospecialBlock2 = false; // 'need for multiplayer fight
        public static byte UseOnlyDefaultTaunts = 0; // '1 = yes, 0 = no
        public static int NumTile = 0; // 'for map editor

        // 'Enemy
        public static int HP2 = 0;
        public static byte HPMAX2 = 0;
        public static string NAME2 = string.Empty;
        public static byte PIC2 = 0;
        public static byte POW2 = 0;
        public static byte DEF2 = 0;
        public static byte SPE2 = 0;
        public static byte SNK2 = 0;
        public static byte WPN2 = 0;
        public static byte ARM2 = 0;
        public static byte ChickenType2 = 0;

        // 'HERO
        public static int HP1 = 0;
        public static string HeroName = string.Empty; // 'chicken fighter's name
        public static byte HeroPic = 0; // 'who is the chicken fighter
        public static byte SNK1 = 0; // 'type of snack
        public static byte Level = 0; // 'type of area your allowed into

        public static byte[] ChickenPow = new byte[2];
        public static byte[] ChickenDef = new byte[2];
        public static byte[] ChickenSpe = new byte[2];
        public static byte[] ChickenHp = new byte[2];
        public static byte[] ChickenHpMax = new byte[2];
        public static string[] ChickenName = { string.Empty, string.Empty };
        public static byte[] ChickenWPN = new byte[2];
        public static byte[] ChickenARM = new byte[2];
        public static int[] ChickenEXP = new int[2];
        public static byte[] ChickenTYPE = new byte[2];
        public static byte[] ChickenRANK = new byte[2];
        public static int[] ChickenEXPNEXT = new int[2];

        public static bool IsFightVisible = false; // 'if true, multiplayer fight is visible
    }
}