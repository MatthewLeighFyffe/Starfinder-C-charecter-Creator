using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starfinder_Charecter_Creator
{// start namespace
    /// <summary>
    /// title: Star finder Charecter creator
    /// Auther: matthew Fyffe
    /// Date: 28/08/17
    /// </summary>
    class Program
    {// start class

       
        static void Main(string[] args)
        {
            
            string Name;
            string race;
            string theme;
            string charecterclass;
            string spells;
            string skills;
            string equipment;
            string feats;
            string laungages;
            string allignment;
            string dety;
            string raceskills;
            int level;
            int totalhp;
            int racehp;
            int classhp;
            int classsp;
            int sp;
            int rp;
            int str;
            int dex;
            int con;
            int intelegnce;
            int wis;
            int cha;
            int strmod;
            int dexmod;
            int conmod;
            int intmod;
            int wismod;
            int chamod;
            int eac;
            int kac;
            int ac;
            int initiative;
            int skillrank;

            Name=Getname();
            level = 1;
            str = 10;
            dex = 10;
            con = 10;
            intelegnce = 10;
            wis = 10;
            cha = 10;
            race = GetRace();
            Console.WriteLine ("{0}",race);
            Console.ReadLine ();

        }

        static string Getname()
        {
            Console.Write("Please state charecters name: ");
            return Console.ReadLine();
            
        }

        static string GetRace()
        {
            int race;
            bool decide;
            Console.WriteLine("Android: +2 dex +2 int -2cha 4hp");
            Console.WriteLine("Android Race skills: \n Constructed: For effects trageting creatures by type android count as both \n humanoids and constructs (whichever effect is worse) they recive a +2 racial \n bounes to saceing throws agaisnt disease, mind effects, posion and sleep, \n unless those effects specifically target constructs. In additon androids do not breather or suffer the normal enviromental effects of being in vacuum. \n Exceptional vision: Androids have low-light vision and dark vision. As a result they can see in dim light as if it were normal light, and they can see with \n no light sorce at all to a range of 60 feet in black and white only. \n Flat affect: Androids find emotions confusing and keep them bottled up. \n They take a -2 penealty to sence motive checks, but the DC's of a Sense motive checks attempted aggaisnt them increase by 2 ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Humans +2 to any 1 ability 4hp \n Human race abilitys: \n Bounus feat humans select one extra feat at 1st level \n skilled: humans give an aiddional skill rank at 1st level and each level \n thereafter ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Kasathas: +2 str +2 wis -2 int 4 hp \n Kasathas abilitys: \n Desert Stride: Kasathas can move thorugh nonmagical diffcult terain in deserts, hils and mountains at there normal speed. \n Four-Armed: Kasathas have four arms which allowes them to wielf and holdup to \n four hands' worth of weapons and equipment. while their multiple arms increase the number of items they can have at the ready it dosent increase the number of attacks they can make dureing combat \n Historian: Due to their in-depth historical training and the wide-ranging \n academic background knowlage they posses, karthas receive a +2 racial bonus to culture checks. \n Natural grace : Kasathas receive a + 2 racial bounces to acrobatics and \n athletics checks.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lashuntas: 4hp \n Subbtype: Korasha +2 str -2 wis +2 cha \n Subtype: Damaya +2 int +2 cha - 2 con \n Lashaunts Abilites: \n Lashunta magtic: Lashuntas gain the following spell-like abilities: \n At will: daze, psychakinitic hand \n 1/day: detect thoughts \n Linited telepathey: Lashuantas can mentaly communicate with any creatures \n within 30 feet with whom they can share a language. conversing telepahticlly \n with multiple creatures simultaneously is just as difficult as listening to \n multiple people speaking \n Student: lashuntas love to learn and they receive +2 racial bounes to any two \n skills of there choice");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Shirans: +2 con +2 wis -2 cha 6 hp \n Blindsense: Shirrens senstive antennae grant them blindsense (vibration)-the \n ability to sense vibrations-out to 30 feet. A shirren ignores the stealth \n bonuses from any form of visual camouflage, invisibillity, and the like when \n attempting a perception check opposed by a creatures stealth check. even on a \n succesful perception check, any foe that cant be seen still has total \n concealment (50% miss chance) agaisnt a shirren and the shirren still has the \n normal miss chance when attacking foes that have concealment. A shirren is \n still flat-footed agaisnts attacks from creatures it cant see \n Communalism: Shirrens are used to working with others as part of a team. Ounce per day, as long as an ally is within 10 feet, a shirren can roll a single \n attack roll or skill check twice and take the higher result \n Cultural fascination : Shirrens are eager to learn about new cultures and \n societes. Shirrens receive a +2 racial bounes to culture and diplomacy checks \n Limited telepathy: Shirrens can comunicate telepathicaly with any creature \n within 30 feet with whom they share a language. conversing telepahically with \n multiple creatures simunltaneously is just as difficult as listening to multple people speak");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Vesk: +2 str +2 con -2 int 6hp \n Vesk Abilitys: \n Armour Savant: Vesk use armor in a way that complements there unqiuly \n sturdy phsyiology. when wearing armour they gain a +1 racial bounes to ac. when they're wearing heavy armour. their armor check penalty is 1 less than normal \n Fearless: Vesk receive a +2 racial bonus to saving throws agasint fear affects Low-Light visioin: vesk can see in dim light as if it were normal light \n Natural weapons: Vesk are always considered armed. they can deal 1d3 leathal \n damage with unarmed strikes and the attack dosent count as archaic. Vesk gain a unique weapon specalization with there natural wapons at 3rd level, allowing \n them to add 1-1/2 x there charecter level to there damage rolls for their \n natural weapons (instead of adding their character level as usual");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ysoki: +2 dex +2 int -2 str 2hp \n Ysoki abilitys: \n Cheek pouchs: Ysoki can store up to 1 cubic foot of items weighing up to one \n bulk in total in their cheek pouchs, and they can transfer a single object \n between and cheek as a swift action. Aysoki can disgorge the entire contents of his pouch into the ground in his square as a move action that does not provoke an attack opportuinity \n Darkvision: Ysoki can see up to 60 feet in the dark \n Moxie: Ysoki are scarappy and nimble even when the odds are agaisnt them. \n A ysoki can stand from prone as a swift action. additonally when off-kilter, a ysoki does not take the normal penalties to attacks or gain the flat footed \n condtion. When attempting an acrobatics check to tumble throgh the space of an oppnent at least one sixe category larger than himself, a yoski receive a +5 \n racial bounes to the check \n Scrounger: Ysoki receive a +2 racial bounes to Engineering, stealth, and \n survival checks");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dwarves: +2 con +2 wis -2 cha 6hp \n Dwarves abilitys: \n Darkvision: Dwarves can see up to 60 feet in the dark \n Slow but Steady: Dwarves have a land speed of 20 feet which is never modified \n when they are encumbered or wearing heavy armour. They also gain a +2 racial \n bounes to saving throws agaisnt posions, spells and spell-like abilites and \n when standing on the ground they gain a +4 racial bounes to their Kac against \n bull rush and trip combat maneuvers. \n Stonecunning: Dwarves gain a +2 perception checks to notice unusal stonework, \n such as traps and hidden doors located in stone walls or floors they receive a check to notice such features whenever they pass within 10 feet of them, \n wheather or not they are actively looking \n Tradional Enemies: Dwarves still train to fight their ancient enemies. A dwarf gains a +1 racial bonus to attaqck rolls agaisnt a creature with the goblonoid \n or orc subtype and a +4 racial bonus to ac agaisnt attacks from a creature with the giant subtype. \n Weapon familiarity: Dwarves are proficient with basic and advanced melee \n weapons and gain specialization with those weapons at 3rd level");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Elves: +2 dex +2int -2 con \n Elves abiitys: \n Elven immunities: Elves are immune to magic sleep effects and receive a +2 \n racial bonus to saving thorws agaisnt enchantment spells and effects. \n Eleven magic: Eleves receive a +2 racial bounes to caster level checks to \n overcome spell resistance. In additon elves receive a +2 racial bonus to \n mysticism skill checks. \n Keen senses: Eleves receive a +2 racial bounes to perception skill checks. \n Low-Light vision: Elves can see in dim light as if it were normal light");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Gnomes: \n subtypes: Feychild: +2 con +2cha -2 str 4hp. Bleachling: +2con +2int -2str 4hp \n Gnome abilites: \n Curious: Gnomes receive a +2 racial bounes to culture checks \n Eternal hope: gnomes receive a +2 racial bounes to saving throws against fear \n and despair effects. Ounce per day, after rolling a 1 on a d20, the gnome can \n reroll and use the second result. \n Gnome magic: Gnomes gain the following spell like abilityes. 1/day \n dancing lights, ghost sound, and token spell. the caster level for these \n effects is equal to the gnomes charcter level. in addition, gnomes get a +2 \n racial bonus agaisnt illusion spells and effects \n Low-light vision: Gnomes can see in dim light as if it were normal light");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Half-Elves: +2 to any one ability score 4hp \n Half-Elves abilitys: \n Adaptability: Half-Elves receive skill focus as a bonus feet at 1st level \n Elven blood: Half-elves are immune to magic sleep effects and receive a +2 \n racial bonus to saveing throws agaisnt enchantment spells and effects \n Keen senses: Half-elves recive a +2 racial bonus to perception skill checks \n Low-Light vision: Half-elves can see dim light as if it were normal light ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Half-Orcs: +2 to any one ability score 6hp \n Half-Orc abilityes \n Darkvision: Half-orcs can see up to 60 fett in the dark \n Intimidateing: Half orcs receive a +2 racial bonus to intimidate skill checks \n Orc ferocity: Ounce per day, a half-orc brought to 0 hit points but not killed can fight on for 1 more round. The half-orc drops to 0hp and is dying but can \n continue to act normally until the end of his next turn, when he becomes \n unconsicous as normal, if he takes additonal damage before this, he ceases \n to be able to act and falls unconcious \n Self-sufficent: Half-orcs receive a +2 racial bounes to survival skill checks ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Halflings: +2 dex +2cha -2str hp 2 \n Halflings abilitys: \n Halfling luck: Halflings receive a +1 racial bonus to all sacing throws. This bouns increases to +3 agaisnt fear effects \n keen senses: ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Clear();
            Console.WriteLine("witch race would you like to be (please use the number next to the race) ? \n 1 : Android \n 2: Humans \n 3: Kasathas \n 4: Lashuntas(Korasha) \n 5: Lashuntas (Damaya) \n 6: Shirans \n 7: Vesk \n 8: Yasoki \n 9: Dwarves \n 10: Elves \n 11: Gnomes(feychild) \n 12: Gnomes (bleechling) \n 13: Half-Elves \n 14: Half-Orc \n 15: Halfling");
            race = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            if (race == 1)
                  Console.WriteLine("Android: +2 dex +2 int -2cha 4hp");
            Console.WriteLine("Android Race skills: \n Constructed: For effects trageting creatures by type android count as both \n humanoids and constructs (whichever effect is worse) they recive a +2 racial \n bounes to saceing throws agaisnt disease, mind effects, posion and sleep, \n unless those effects specifically target constructs. In additon androids do not breather or suffer the normal enviromental effects of being in vacuum. \n Exceptional vision: Androids have low-light vision and dark vision. As a result they can see in dim light as if it were normal light, and they can see with \n no light sorce at all to a range of 60 feet in black and white only. \n Flat affect: Androids find emotions confusing and keep them bottled up. \n They take a -2 penealty to sence motive checks, but the DC's of a Sense motive checks attempted aggaisnt them increase by 2 ");
                
            return ("Android");
            else
                if (race == 2)
                    return ("Human");
                else
                    if (race == 3)
                        return ("Kasathas");
                    else
                        if (race == 4)
                            return ("Lashuntas (Korasha)");
                        else
                            if (race == 5)
                                return ("Lashuntas (Damaya)");
                            else
                                if (race == 6)
                                    return ("Shirams");
                                else
                                    if (race == 7)
                                        return ("Vesk");
                                    else
                                        if (race == 8)
                                            return ("Yasoki");
                                        else
                                            if (race == 9)
                                                return ("Dwarves");
                                            else
                                                if (race == 10)
                                                    return ("Elves");
                                                else
                                                    if (race == 11)
                                                        return ("Gnomes feychild");
                                                    else
                                                        if (race == 12)
                                                            return ("Gnomes Bleechling");
                                                        else
                                                            if (race == 13)
                                                                return ("Half-Elf");
                                                            else
                                                                if (race == 14)
                                                                    return ("Half-orc");
                                                                else
                                                                    if (race == 15)
                                                                        return ("Halfling");

                        



                return Console.ReadLine();
        }
    }
}
