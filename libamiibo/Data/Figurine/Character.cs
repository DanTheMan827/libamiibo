﻿/*
 * Copyright (C) 2016 Benjamin Krämer
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System.Collections.Generic;

namespace LibAmiibo.Data.Figurine
{
    public class Character
    {
        private static Dictionary<int, string> dict = new Dictionary<int, string>
        {
            { 0x0000,   "Mario" },
            { 0x0001,   "Luigi" },
            { 0x0002,   "Peach" },
            { 0x0003,   "Yoshi" },
            { 0x0004,   "Rosalina" },
            { 0x0005,   "Bowser" },
            { 0x0006,   "Bowser Jr." },
            { 0x0007,   "Wario" },
            { 0x0008,   "Donkey Kong" },
            { 0x0009,   "Diddy Kong" },
            { 0x000A,   "Toad" },
            { 0x0013,   "Daisy" },
            { 0x0014,   "Waluigi" },
            { 0x0015,   "Goomba" },
            { 0x0017,   "Boo" },
            { 0x0023,   "Koopa Troopa" },
            { 0x0080,   "Poochy" },
            { 0x0100,   "Link" },
            { 0x0101,   "Zelda" },
            { 0x0102,   "Ganon" },
            { 0x0103,   "Midna" },
            { 0x0105,   "Daruk" },
            { 0x0106,   "Urbosa" },
            { 0x0107,   "Mipha" },
            { 0x0108,   "Revali" },
            { 0x0140,   "Guardian" },
            { 0x0141,   "Bokoblin" },
            { 0x0180,   "Villager" },
            { 0x0181,   "Isabelle" },
            { 0x0182,   "K.K. Slider" },
            { 0x0183,   "Tom Nook" },
            { 0x0184,   "Timmy & Tommy" },
            { 0x0185,   "Timmy" },
            { 0x0186,   "Tommy" },
            { 0x0187,   "Sable" },
            { 0x0188,   "Mabel" },
            { 0x0189,   "Labelle" },
            { 0x018A,   "Reese" },
            { 0x018B,   "Cyrus" },
            { 0x018C,   "Digby" },
            { 0x018D,   "Rover" },
            { 0x018E,   "Mr. Resetti" },
            { 0x018F,   "Don Resetti" },
            { 0x0190,   "Brewster" },
            { 0x0191,   "Harriet" },
            { 0x0192,   "Blathers" },
            { 0x0193,   "Celeste" },
            { 0x0194,   "Kicks" },
            { 0x0195,   "Porter" },
            { 0x0196,   "Kapp'n" },
            { 0x0197,   "Leilani" },
            { 0x0198,   "Lelia" },
            { 0x0199,   "Grams" },
            { 0x019A,   "Chip" },
            { 0x019B,   "Nat" },
            { 0x019C,   "Phineas" },
            { 0x019D,   "Copper" },
            { 0x019E,   "Booker" },
            { 0x019F,   "Pete" },
            { 0x01A0,   "Pelly" },
            { 0x01A1,   "Phyllis" },
            { 0x01A2,   "Gulliver" },
            { 0x01A3,   "Joan" },
            { 0x01A4,   "Pascal" },
            { 0x01A5,   "Katarina" },
            { 0x01A6,   "Sahara" },
            { 0x01A7,   "Wendell" },
            { 0x01A8,   "Redd" },
            { 0x01A9,   "Gracie" },
            { 0x01AA,   "Lyle" },
            { 0x01AB,   "Pave" },
            { 0x01AC,   "Zipper" },
            { 0x01AD,   "Jack" },
            { 0x01AE,   "Franklin" },
            { 0x01AF,   "Jingle" },
            { 0x01B0,   "Tortimer" },
            { 0x01B1,   "Dr. Shrunk" },
            { 0x01B3,   "Blanca" },
            { 0x01B4,   "Leif" },
            { 0x01B5,   "Luna" },
            { 0x01B6,   "Katie" },
            { 0x01C1,   "Lottie" },
            { 0x0200,   "Cyrano" },
            { 0x0201,   "Antonio" },
            { 0x0202,   "Pango" },
            { 0x0203,   "Anabelle" },
            { 0x0206,   "Snooty" },
            { 0x0208,   "Annalisa" },
            { 0x0209,   "Olaf" },
            { 0x0214,   "Teddy" },
            { 0x0215,   "Pinky" },
            { 0x0216,   "Curt" },
            { 0x0217,   "Chow" },
            { 0x0219,   "Nate" },
            { 0x021A,   "Groucho" },
            { 0x021B,   "Tutu" },
            { 0x021C,   "Ursala" },
            { 0x021D,   "Grizzly" },
            { 0x021E,   "Paula" },
            { 0x021F,   "Ike" },
            { 0x0220,   "Charlise" },
            { 0x0221,   "Beardo" },
            { 0x0222,   "Klaus" },
            { 0x022D,   "Jay" },
            { 0x022E,   "Robin" },
            { 0x022F,   "Anchovy" },
            { 0x0230,   "Twiggy" },
            { 0x0231,   "Jitters" },
            { 0x0232,   "Piper" },
            { 0x0233,   "Admiral" },
            { 0x0235,   "Midge" },
            { 0x0238,   "Jacob" },
            { 0x023C,   "Lucha" },
            { 0x023D,   "Jacques" },
            { 0x023E,   "Peck" },
            { 0x023F,   "Sparro" },
            { 0x024A,   "Angus" },
            { 0x024B,   "Rodeo" },
            { 0x024D,   "Stu" },
            { 0x024F,   "T-Bone" },
            { 0x0251,   "Coach" },
            { 0x0252,   "Vic" },
            { 0x025D,   "Bob" },
            { 0x025E,   "Mitzi" },
            { 0x025F,   "Rosie" },
            { 0x0260,   "Olivia" },
            { 0x0261,   "Kiki" },
            { 0x0262,   "Tangy" },
            { 0x0263,   "Punchy" },
            { 0x0264,   "Purrl" },
            { 0x0265,   "Moe" },
            { 0x0266,   "Kabuki" },
            { 0x0267,   "Kid Cat" },
            { 0x0268,   "Monique" },
            { 0x0269,   "Tabby" },
            { 0x026A,   "Stinky" },
            { 0x026B,   "Kitty" },
            { 0x026C,   "Tom" },
            { 0x026D,   "Merry" },
            { 0x026E,   "Felicity" },
            { 0x026F,   "Lolly" },
            { 0x0270,   "Ankha" },
            { 0x0271,   "Rudy" },
            { 0x0272,   "Katt" },
            { 0x027D,   "Bluebear" },
            { 0x027E,   "Maple" },
            { 0x027F,   "Poncho" },
            { 0x0280,   "Pudge" },
            { 0x0281,   "Kody" },
            { 0x0282,   "Stitches" },
            { 0x0283,   "Vladimir" },
            { 0x0284,   "Murphy" },
            { 0x0286,   "Olive" },
            { 0x0287,   "Cheri" },
            { 0x028A,   "June" },
            { 0x028B,   "Pekoe" },
            { 0x028C,   "Chester" },
            { 0x028D,   "Barold" },
            { 0x028E,   "Tammy" },
            { 0x028F,   "Marty" },
            { 0x0299,   "Goose" },
            { 0x029A,   "Benedict" },
            { 0x029B,   "Egbert" },
            { 0x029E,   "Ava" },
            { 0x02A2,   "Becky" },
            { 0x02A3,   "Plucky" },
            { 0x02A4,   "Knox" },
            { 0x02A5,   "Broffina" },
            { 0x02A6,   "Ken" },
            { 0x02B1,   "Patty" },
            { 0x02B2,   "Tipper" },
            { 0x02B7,   "Norma" },
            { 0x02B8,   "Naomi" },
            { 0x02C3,   "Alfonso" },
            { 0x02C4,   "Alli" },
            { 0x02C5,   "Boots" },
            { 0x02C7,   "Del" },
            { 0x02C9,   "Sly" },
            { 0x02CA,   "Gayle" },
            { 0x02CB,   "Drago" },
            { 0x02D6,   "Fauna" },
            { 0x02D7,   "Bam" },
            { 0x02D8,   "Zell" },
            { 0x02D9,   "Bruce" },
            { 0x02DA,   "Deidre" },
            { 0x02DB,   "Lopez" },
            { 0x02DC,   "Fuchsia" },
            { 0x02DD,   "Beau" },
            { 0x02DE,   "Diana" },
            { 0x02DF,   "Erik" },
            { 0x02E0,   "Chelsea" },
            { 0x02EA,   "Goldie" },
            { 0x02EB,   "Butch" },
            { 0x02EC,   "Lucky" },
            { 0x02ED,   "Biskit" },
            { 0x02EE,   "Bones" },
            { 0x02EF,   "Portia" },
            { 0x02F0,   "Walker" },
            { 0x02F1,   "Daisy" },
            { 0x02F2,   "Cookie" },
            { 0x02F3,   "Maddie" },
            { 0x02F4,   "Bea" },
            { 0x02F8,   "Mac" },
            { 0x02F9,   "Marcel" },
            { 0x02FA,   "Benjamin" },
            { 0x02FB,   "Cherry" },
            { 0x02FC,   "Shep" },
            { 0x0307,   "Bill" },
            { 0x0308,   "Joey" },
            { 0x0309,   "Pate" },
            { 0x030A,   "Maelle" },
            { 0x030B,   "Deena" },
            { 0x030C,   "Pompom" },
            { 0x030D,   "Mallary" },
            { 0x030E,   "Freckles" },
            { 0x030F,   "Derwin" },
            { 0x0310,   "Drake" },
            { 0x0311,   "Scoot" },
            { 0x0312,   "Weber" },
            { 0x0313,   "Miranda" },
            { 0x0314,   "Ketchup" },
            { 0x0316,   "Gloria" },
            { 0x0317,   "Molly" },
            { 0x0318,   "Quillson" },
            { 0x0323,   "Opal" },
            { 0x0324,   "Dizzy" },
            { 0x0325,   "Big Top" },
            { 0x0326,   "Eloise" },
            { 0x0327,   "Margie" },
            { 0x0328,   "Paolo" },
            { 0x0329,   "Axel" },
            { 0x032A,   "Ellie" },
            { 0x032C,   "Tucker" },
            { 0x032D,   "Tia" },
            { 0x032E,   "Chai" },
            { 0x0338,   "Lily" },
            { 0x0339,   "Ribbot" },
            { 0x033A,   "Frobert" },
            { 0x033B,   "Camofrog" },
            { 0x033C,   "Drift" },
            { 0x033D,   "Wart Jr." },
            { 0x033E,   "Puddles" },
            { 0x033F,   "Jeremiah" },
            { 0x0341,   "Tad" },
            { 0x0342,   "Cousteau" },
            { 0x0343,   "Huck" },
            { 0x0344,   "Prince" },
            { 0x0345,   "Jambette" },
            { 0x0347,   "Raddle" },
            { 0x0348,   "Gigi" },
            { 0x0349,   "Croque" },
            { 0x034A,   "Diva" },
            { 0x034B,   "Henry" },
            { 0x0356,   "Chevre" },
            { 0x0357,   "Nan" },
            { 0x0358,   "Billy" },
            { 0x035A,   "Gruff" },
            { 0x035C,   "Velma" },
            { 0x035D,   "Kidd" },
            { 0x035E,   "Pashmina" },
            { 0x0369,   "Cesar" },
            { 0x036A,   "Peewee" },
            { 0x036B,   "Boone" },
            { 0x036D,   "Louie" },
            { 0x036E,   "Boyd" },
            { 0x0370,   "Violet" },
            { 0x0371,   "Al" },
            { 0x0372,   "Rocket" },
            { 0x0373,   "Hans" },
            { 0x0374,   "Rilla" },
            { 0x037E,   "Hamlet" },
            { 0x037F,   "Apple" },
            { 0x0380,   "Graham" },
            { 0x0381,   "Rodney" },
            { 0x0382,   "Soleil" },
            { 0x0383,   "Clay" },
            { 0x0384,   "Flurry" },
            { 0x0385,   "Hamphrey" },
            { 0x0390,   "Rocco" },
            { 0x0392,   "Bubbles" },
            { 0x0393,   "Bertha" },
            { 0x0394,   "Biff" },
            { 0x0395,   "Bitty" },
            { 0x0398,   "Harry" },
            { 0x0399,   "Hippeux" },
            { 0x03A4,   "Buck" },
            { 0x03A5,   "Victoria" },
            { 0x03A6,   "Savannah" },
            { 0x03A7,   "Elmer" },
            { 0x03A8,   "Rosco" },
            { 0x03A9,   "Winnie" },
            { 0x03AA,   "Ed" },
            { 0x03AB,   "Cleo" },
            { 0x03AC,   "Peaches" },
            { 0x03AD,   "Annalise" },
            { 0x03AE,   "Clyde" },
            { 0x03AF,   "Colton" },
            { 0x03B0,   "Papi" },
            { 0x03B1,   "Julian" },
            { 0x03BC,   "Yuka" },
            { 0x03BD,   "Alice" },
            { 0x03BE,   "Melba" },
            { 0x03BF,   "Sydney" },
            { 0x03C0,   "Gonzo" },
            { 0x03C1,   "Ozzie" },
            { 0x03C4,   "Canberra" },
            { 0x03C5,   "Lyman" },
            { 0x03C6,   "Eugene" },
            { 0x03D0,   "Carrie" },
            { 0x03D1,   "Kitt" },
            { 0x03D2,   "Mathilda" },
            { 0x03D3,   "Carrie" },
            { 0x03D6,   "Astrid" },
            { 0x03D7,   "Sylvia" },
            { 0x03D9,   "Walt" },
            { 0x03DA,   "Rodney" },
            { 0x03DB,   "Marcie" },
            { 0x03E6,   "Bud" },
            { 0x03E7,   "Elvis" },
            { 0x03E8,   "Rex" },
            { 0x03EA,   "Leopold" },
            { 0x03EC,   "Mott" },
            { 0x03ED,   "Rory" },
            { 0x03EE,   "Lionel" },
            { 0x03FA,   "Nana" },
            { 0x03FB,   "Simon" },
            { 0x03FC,   "Tammi" },
            { 0x03FD,   "Monty" },
            { 0x03FE,   "Elise" },
            { 0x03FF,   "Flip" },
            { 0x0400,   "Shari" },
            { 0x0401,   "Deli" },
            { 0x040C,   "Dora" },
            { 0x040D,   "Limberg" },
            { 0x040E,   "Bella" },
            { 0x040F,   "Bree" },
            { 0x0410,   "Samson" },
            { 0x0411,   "Rod" },
            { 0x0414,   "Candi" },
            { 0x0415,   "Rizzo" },
            { 0x0416,   "Anicotti" },
            { 0x0418,   "Broccolo" },
            { 0x041A,   "Moose" },
            { 0x041B,   "Bettina" },
            { 0x041C,   "Greta" },
            { 0x041D,   "Penelope" },
            { 0x041E,   "Chadder" },
            { 0x0429,   "Octavian" },
            { 0x042A,   "Marina" },
            { 0x042B,   "Zucker" },
            { 0x0436,   "Queenie" },
            { 0x0437,   "Gladys" },
            { 0x0438,   "Sandy" },
            { 0x0439,   "Sprocket" },
            { 0x043B,   "Julia" },
            { 0x043C,   "Cranston" },
            { 0x043D,   "Phil" },
            { 0x043E,   "Blanche" },
            { 0x043F,   "Flora" },
            { 0x0440,   "Phoebe" },
            { 0x044B,   "Apollo" },
            { 0x044C,   "Amelia" },
            { 0x044D,   "Pierce" },
            { 0x044E,   "Buzz" },
            { 0x0450,   "Avery" },
            { 0x0451,   "Frank" },
            { 0x0452,   "Sterling" },
            { 0x0453,   "Keaton" },
            { 0x0454,   "Celia" },
            { 0x045F,   "Aurora" },
            { 0x0460,   "Roald" },
            { 0x0461,   "Cube" },
            { 0x0462,   "Hopper" },
            { 0x0463,   "Friga" },
            { 0x0464,   "Gwen" },
            { 0x0465,   "Puck" },
            { 0x0468,   "Wade" },
            { 0x0469,   "Boomer" },
            { 0x046A,   "Iggly" },
            { 0x046B,   "Tex" },
            { 0x046C,   "Flo" },
            { 0x046D,   "Sprinkle" },
            { 0x0478,   "Curly" },
            { 0x0479,   "Truffles" },
            { 0x047A,   "Rasher" },
            { 0x047B,   "Hugh" },
            { 0x047C,   "Lucy" },
            { 0x047D,   "Spork/Crackle" },
            { 0x0480,   "Cobb" },
            { 0x0481,   "Boris" },
            { 0x0482,   "Maggie" },
            { 0x0483,   "Peggy" },
            { 0x0485,   "Gala" },
            { 0x0486,   "Chops" },
            { 0x0487,   "Kevin" },
            { 0x0488,   "Pancetti" },
            { 0x0489,   "Agnes" },
            { 0x0494,   "Bunnie" },
            { 0x0495,   "Dotty" },
            { 0x0496,   "Coco" },
            { 0x0497,   "Snake" },
            { 0x0498,   "Gaston" },
            { 0x0499,   "Gabi" },
            { 0x049A,   "Pippy" },
            { 0x049B,   "Tiffany" },
            { 0x049C,   "Genji" },
            { 0x049D,   "Ruby" },
            { 0x049E,   "Doc" },
            { 0x049F,   "Claude" },
            { 0x04A0,   "Francine" },
            { 0x04A1,   "Chrissy" },
            { 0x04A2,   "Hopkins" },
            { 0x04A3,   "O'Hare" },
            { 0x04A4,   "Carmen" },
            { 0x04A5,   "Bonbon" },
            { 0x04A6,   "Cole" },
            { 0x04A7,   "Mira" },
            { 0x04A8,   "Toby" },
            { 0x04B2,   "Tank" },
            { 0x04B3,   "Rhonda" },
            { 0x04B4,   "Spike" },
            { 0x04B6,   "Hornsby" },
            { 0x04B9,   "Merengue" },
            { 0x04BA,   "Renée" },
            { 0x04C5,   "Vesta" },
            { 0x04C6,   "Baabara" },
            { 0x04C7,   "Eunice" },
            { 0x04C8,   "Stella" },
            { 0x04C9,   "Cashmere" },
            { 0x04CC,   "Willow" },
            { 0x04CD,   "Curlos" },
            { 0x04CE,   "Wendy" },
            { 0x04CF,   "Timbra" },
            { 0x04D0,   "Frita" },
            { 0x04D1,   "Muffy" },
            { 0x04D2,   "Pietro" },
            { 0x04D3,   "Etoile" },
            { 0x04DD,   "Peanut" },
            { 0x04DE,   "Blaire" },
            { 0x04DF,   "Filbert" },
            { 0x04E0,   "Pecan" },
            { 0x04E1,   "Nibbles" },
            { 0x04E2,   "Agent S" },
            { 0x04E3,   "Caroline" },
            { 0x04E4,   "Sally" },
            { 0x04E5,   "Static" },
            { 0x04E6,   "Mint" },
            { 0x04E7,   "Ricky" },
            { 0x04E8,   "Cally" },
            { 0x04EA,   "Tasha" },
            { 0x04EB,   "Sylvana" },
            { 0x04EC,   "Poppy" },
            { 0x04ED,   "Sheldon" },
            { 0x04EE,   "Marshal" },
            { 0x04EF,   "Hazel" },
            { 0x04FA,   "Rolf" },
            { 0x04FB,   "Rowan" },
            { 0x04FC,   "Tybalt" },
            { 0x04FD,   "Bangle" },
            { 0x04FE,   "Leonardo" },
            { 0x04FF,   "Claudia" },
            { 0x0500,   "Bianca" },
            { 0x050B,   "Chief" },
            { 0x050C,   "Lobo" },
            { 0x050D,   "Wolfgang" },
            { 0x050E,   "Whitney" },
            { 0x050F,   "Dobie" },
            { 0x0510,   "Freya" },
            { 0x0511,   "Fang" },
            { 0x0513,   "Vivian" },
            { 0x0514,   "Skye" },
            { 0x0515,   "Kyle" },
            { 0x0580,   "Fox" },
            { 0x0581,   "Falco" },
            { 0x05c0,   "Samus" },
            { 0x05c1,   "Metroid" },
            { 0x0600,   "Captain Falcon" },
            { 0x0640,   "Olimar" },
            { 0x0642,   "Pikmin" },
            { 0x06c0,   "Little Mac" },
            { 0x0700,   "Wii Fit Trainer" },
            { 0x0740,   "Pit" },
            { 0x0741,   "Dark Pit" },
            { 0x0742,   "Palutena" },
            { 0x0780,   "Mr. G&W" },
            { 0x0781,   "R.O.B." },
            { 0x0782,   "Duck Hunt" },
            { 0x07c0,   "Mii" },
            { 0x0800,   "Inkling" },
            { 0x0801,   "Callie" },
            { 0x0802,   "Marie" },
            { 0x0803,   "Pearl" },
            { 0x0804,   "Marina" },
            { 0x09C0,   "Mario (MSS)" },
            { 0x09C1,   "Luigi (MSS)" },
            { 0x09C2,   "Peach (MSS)" },
            { 0x09C3,   "Daisy (MSS)" },
            { 0x09C4,   "Yoshi (MSS)" },
            { 0x09C5,   "Wario (MSS)" },
            { 0x09C6,   "Waluigi (MSS)" },
            { 0x09C7,   "Donkey Kong (MSS)" },
            { 0x09C8,   "Diddy Kong (MSS)" },
            { 0x09C9,   "Bowser (MSS)" },
            { 0x09CA,   "Bowser Jr. (MSS)" },
            { 0x09CB,   "Boo (MSS)" },
            { 0x09CC,   "Baby Mario (MSS)" },
            { 0x09CD,   "Baby Luigi (MSS)" },
            { 0x09CE,   "Birdo (MSS)" },
            { 0x09CF,   "Rosalina (MSS)" },
            { 0x09D0,   "Metal Mario (MSS)" },
            { 0x09D1,   "Pink Gold Peach (MSS)" },
            { 0x1906,   "Charizard" },
            { 0x1919,   "Pikachu" },
            { 0x1927,   "Jigglypuff" },
            { 0x1996,   "Mewtwo" },
            { 0x1ac0,   "Lucario" },
            { 0x1b92,   "Greninja" },
            { 0x1d00,   "Shadow Mewtwo" },
            { 0x1d01,   "Detective Pikachu" },
            { 0x1f00,   "Kirby" },
            { 0x1f01,   "Meta Knight" },
            { 0x1f02,   "King Dedede" },
            { 0x1f03,   "Waddle Dee" },
            { 0x1f40,   "Qbby" },
            { 0x2100,   "Marth" },
            { 0x2101,   "Ike" },
            { 0x2102,   "Lucina" },
            { 0x2103,   "Robin" },
            { 0x2104,   "Roy" },
            { 0x2105,   "Corrin" },
            { 0x2106,   "Alm" },
            { 0x2107,   "Celica" },
            { 0x2108,   "Chrom" },
            { 0x2109,   "Tiki" },
            { 0x2240,   "Shulk" },
            { 0x2280,   "Ness" },
            { 0x2281,   "Lucas" },
            { 0x22c0,   "Chibi-Robo" },
            { 0x3200,   "Sonic" },
            { 0x3240,   "Bayonetta" },
            { 0x3340,   "PAC-MAN" },
            { 0x3380,   "Solaire of Astora" },
            { 0x3480,   "Mega Man" },
            { 0x34C0,   "Ryu" },
            { 0x3500,   "One-Eyed Rathalos" },
            { 0x3501,   "Nabiru" },
            { 0x3502,   "Rathian" },
            { 0x3503,   "Barioth" },
            { 0x3504,   "Qurupeco" },
            { 0x35C0,   "Shovel Knight" },
            { 0x3600,   "Cloud Strife" },
            { 0x3740,   "Super Mario Cereal" },
        };

        internal static string GetName(int id)
        {
            string name;
            if (dict.TryGetValue(id, out name))
                return name;

            return null;
        }
    }
}