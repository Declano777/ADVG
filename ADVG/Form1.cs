using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // Allows use of Thread.Sleep for delays
using System.Media;
using System.Net.Http.Headers; // Enables SoundPlayer for playing audio

namespace ADVG
{
    public partial class Form1 : Form
    {
        // --- Game variables ---
        Random randGen = new Random();
        string playerName = "";
        double health = 100;
        double stamina = 100;
        double mana = 100;
        double WKH = 100; // Wizard King health
        bool gronDead = false;
        bool waterPower = false;
        bool firePower = false;
        bool earthPower = false;

        // --- Sound effects ---
        SoundPlayer battle = new SoundPlayer(Properties.Resources.battleAudio);
        SoundPlayer rockSound = new SoundPlayer(Properties.Resources.rockAudio);
        SoundPlayer igniteSound = new SoundPlayer(Properties.Resources.igniteAudio);
        SoundPlayer tideSound = new SoundPlayer(Properties.Resources.tideAudio);
        SoundPlayer fireballSound = new SoundPlayer(Properties.Resources.fireballAudio);
        SoundPlayer tremourSound = new SoundPlayer(Properties.Resources.tremourAudio);
        SoundPlayer stormSound = new SoundPlayer(Properties.Resources.stormAudio);

        public Form1()
        {
            InitializeComponent();

            // Make label transparent and initialize UI values
            textLable.Parent = s1;
            textLable.BackColor = Color.Transparent;
            manaLable.Text = mana.ToString();
            healthLable.Text = health.ToString();
            staminaLable.Text = stamina.ToString();
        }

        // --- Start Button ---
        private void startButton_Click(object sender, EventArgs e)
        {
            playerName = nameInput.Text;

            // Hide menu UI
            titalLable2.Visible = false;
            titleLable.Visible = false;
            nameLable.Visible = false;
            startButton.Visible = false;
            nameInput.Visible = false;
            rulesButton.Visible = false;

            // Show main game UI
            textLable.Visible = true;
            healthLable.Visible = true;
            manaLable.Visible = true;
            staminaLable.Visible = true;
            healthText.Visible = true;
            manaText.Visible = true;
            staminaText.Visible = true;
            s1.Visible = true;

            // --- Story sequence with image updates ---
            s1.Image = Properties.Resources.avg1st;
            s1.Refresh();
            Application.DoEvents();
            textLable.Text = "You begin your journey in a strange place";
            textLable.Refresh();
            Thread.Sleep(5000);

            textLable.Text = "You remember only your name and the wand you chose as a kid";
            textLable.Refresh();
            Thread.Sleep(5000);

            textLable.Text = "You may not remember what happened but you have an urge to defeat the king and reclaim the throne.";
            textLable.Refresh();
            Thread.Sleep(5000);

            s1.Image = Properties.Resources.avg2nd;
            s1.Refresh();
            textLable.Text = "You find a chest in the cave you awoke in and open it";
            textLable.Refresh();
            Thread.Sleep(5000);

            textLable.Text = "Inside you find three books. You only have room on you for one.";
            textLable.Refresh();
            Thread.Sleep(5000);

            textLable.Text = "Which do you choose?";
            fireChoice.Visible = true;
            waterChoice.Visible = true;
            earthChoice.Visible = true;
        }

        // --- Fire Book Choice ---
        private void fireChoice_Click(object sender, EventArgs e)
        {
            firePower = true;
            fireChoice.Visible = false;
            waterChoice.Visible = false;
            earthChoice.Visible = false;
            Application.DoEvents();

            // Narrative progression
            textLable.Text = "You choose the fire book and find that it has spells to unleash light and flames.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You decide to leave the cave and begin your journey.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Just as you leave the cave it attacks you.";
            textLable.Refresh();
            Thread.Sleep(5000);

            // Encounter with Grons
            s1.Image = Properties.Resources.avg3rd;
            s1.Refresh();
            textLable.Text = "A HORD OF GRONS!";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You look to the book and see two spells you can choose from.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Refresh();
            battle.PlayLooping();
            textLable.Text = "Choose your spell and ATTACK!";
            textLable.Refresh();
            fireball.Visible = true;
            ignite.Visible = true;
        }

        // --- Earth Book Choice ---
        private void earthChoice_Click(object sender, EventArgs e)
        {
            earthPower = true;
            fireChoice.Visible = false;
            waterChoice.Visible = false;
            earthChoice.Visible = false;
            Application.DoEvents();

            textLable.Text = "You choose the earth book and find that it has spells to unleash rock and mud.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You decide to leave the cave and begin your journey.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Just as you leave the cave it attacks you.";
            textLable.Refresh();
            Thread.Sleep(5000);

            s1.Image = Properties.Resources.avg3rd;
            s1.Refresh();
            textLable.Text = "A HORD OF GRONS!";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You look to the book and see two spells you can choose from.";
            textLable.Refresh();
            Thread.Sleep(5000);
            battle.PlayLooping();
            textLable.Text = "Choose your spell and ATTACK!";
            textLable.Refresh();
            rock.Visible = true;
            tremour.Visible = true;
        }

        // --- Water Book Choice ---
        private void waterChoice_Click(object sender, EventArgs e)
        {
            waterPower = true;
            fireChoice.Visible = false;
            waterChoice.Visible = false;
            earthChoice.Visible = false;
            Application.DoEvents();

            textLable.Text = "You choose the water book and find that it has spells to unleash waves and storms.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You decide to leave the cave and begin your journey.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Just as you leave the cave it attacks you.";
            textLable.Refresh();
            Thread.Sleep(5000);

            s1.Image = Properties.Resources.avg3rd;
            s1.Refresh();
            textLable.Text = "A HORD OF GRONS!";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You look to the book and see two spells you can choose from.";
            textLable.Refresh();
            Thread.Sleep(5000);
            battle.PlayLooping();
            textLable.Text = "Choose your spell and ATTACK!";
            textLable.Refresh();
            storm.Visible = true;
            tide.Visible = true;
        }

        // --- Fireball Spell ---
        private void fireball_Click(object sender, EventArgs e)
        {
            if (!gronDead)
            {
                // First battle (against Grons)
                ignite.Visible = false;
                fireball.Visible = false;
                Application.DoEvents();
                mana -= 10;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - FIREBALL!!!!!!";
                textLable.Refresh();
                fireballSound.Play();
                Thread.Sleep(5000);
                textLable.Text = "With a flick of your wand you are able to defeat the grons!";
                textLable.Refresh();
                gronDead = true;
                afterGronBattle();
            }
            else
            {
                // Wizard King battle
                fireball.Visible = false;
                ignite.Visible = false;
                Application.DoEvents();
                mana -= 10;
                WKH -= 50;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - FIREBALL!!!!!!";
                textLable.Refresh();
                fireballSound.Play();
                Thread.Sleep(5000);
                checkWKH();
            }
        }

        // --- Ignite Spell ---
        private void ignite_Click(object sender, EventArgs e)
        {
            if (!gronDead)
            {
                ignite.Visible = false;
                fireball.Visible = false;
                Application.DoEvents();
                int chance = randGen.Next(0, 4);
                mana -= 5;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - IGNITE!!";
                textLable.Refresh();
                igniteSound.Play();
                Thread.Sleep(5000);

                // Random chance of success/failure
                if (chance < 3)
                {
                    textLable.Text = "With a flick of your wand you are able to defeat the grons, barely.";
                    textLable.Refresh();
                    gronDead = true;
                    afterGronBattle();
                }
                else
                {
                    textLable.Text = "The attack was not enough!";
                    textLable.Refresh();
                    Thread.Sleep(5000);
                    health = 90;
                    textLable.Text = "You can attack again.";
                    textLable.Refresh();
                    ignite.Visible = true;  
                    fireball.Visible = true;
                }
            }
            else
            {
                // Wizard King fight
                fireball.Visible = false;
                ignite.Visible = false;
                Application.DoEvents();
                mana -= 5;
                WKH -= 25;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - IGNITE!!!!!!";
                textLable.Refresh();
                igniteSound.Play();
                Thread.Sleep(5000);
                checkWKH();
            }
        }

        // --- Tide Spell (Water) ---
        private void tide_Click(object sender, EventArgs e)
        {
            if (!gronDead)
            {
                tide.Visible = false;
                storm.Visible = false;
                Application.DoEvents();
                int chance = randGen.Next(0, 4);
                mana -= 5;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - TIDE!!";
                textLable.Refresh();
                tideSound.Play();
                Thread.Sleep(5000);

                if (chance < 3)
                {
                    textLable.Text = "With a flick of your wand you are able to defeat the grons, barely.";
                    textLable.Refresh();
                    gronDead = true;
                    afterGronBattle();
                }
                else
                {
                    textLable.Text = "Your attack wasn’t enough. The Grons strike back!";
                    textLable.Refresh();
                    health = 90;
                    textLable.Text = "You catch your breath and can attack again.";
                    textLable.Refresh();
                    tide.Visible = true;
                    storm.Visible = true;
                }
            }
            else
            {
                storm.Visible = false;
                tide.Visible = false;
                Application.DoEvents();
                mana -= 5;
                WKH -= 25;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - TIDE!!!!!!";
                textLable.Refresh();
                tideSound.Play();
                Thread.Sleep(5000);
                checkWKH();
            }
        }

        // --- Storm Spell (Water) ---
        private void storm_Click(object sender, EventArgs e)
        {
            if (!gronDead)
            {
                tide.Visible = false;
                storm.Visible = false;
                Application.DoEvents();
                mana -= 10;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - STORM!!!!!!";
                textLable.Refresh();
                stormSound.Play();
                Thread.Sleep(5000);
                textLable.Text = "With a flick of your wand you defeat the grons!";
                textLable.Refresh();
                gronDead = true;
                afterGronBattle();
            }
            else
            {
                storm.Visible = false;
                tide.Visible = false;
                Application.DoEvents();
                mana -= 10;
                WKH -= 50;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - STORM!!!!!!";
                textLable.Refresh();
                stormSound.Play();
                Thread.Sleep(5000);
                checkWKH();
            }
        }

        // --- Tremour Spell (Earth) ---
        private void tremour_Click(object sender, EventArgs e)
        {
            if (!gronDead)
            {
                tremour.Visible = false;
                rock.Visible = false;
                Application.DoEvents();
                int chance = randGen.Next(0, 4);
                mana -= 5;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - TREMOUR!!";
                textLable.Refresh();
                tremourSound.Play();
                Thread.Sleep(5000);

                if (chance < 3)
                {
                    textLable.Text = "You manage to defeat the grons, barely.";
                    textLable.Refresh();
                    gronDead = true;
                    afterGronBattle();
                }
                else
                {
                    textLable.Text = "The attack was weak, the Grons counter!";
                    textLable.Refresh();
                    health = 90;
                    textLable.Text = "You catch your breath and can attack again.";
                    textLable.Refresh();
                    tremour.Visible = true;
                    rock.Visible = true;
                }
            }
            else
            {
                tremour.Visible = false;
                rock.Visible = false;
                Application.DoEvents();
                mana -= 5;
                WKH -= 25;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - TREMOUR!!!!!!";
                textLable.Refresh();
                tremourSound.Play();
                Thread.Sleep(5000);
                checkWKH();
            }
        }

        // --- Rock Spell (Earth) ---
        private void rock_Click(object sender, EventArgs e)
        {
            if (!gronDead)
            {
                tremour.Visible = false;
                rock.Visible = false;
                Application.DoEvents();
                mana -= 10;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - ROCK!!!!!!";
                textLable.Refresh();
                rockSound.Play();
                Thread.Sleep(5000);
                textLable.Text = "You crush the grons with rock magic!";
                textLable.Refresh();
                gronDead = true;
                afterGronBattle();
            }
            else
            {
                tremour.Visible = false;
                rock.Visible = false;
                Application.DoEvents();
                mana -= 10;
                WKH -= 50;
                manaLable.Text = mana.ToString();
                textLable.Text = "You - ROCK!!!!!!";
                textLable.Refresh();
                rockSound.Play();
                Thread.Sleep(5000);
                checkWKH();
            }
        }

        // --- Fire path decision ---
        private void firePathButton_Click(object sender, EventArgs e)
        {
            icePathButton.Visible = false;
            firePathButton.Visible = false;
            Application.DoEvents();
            textLable.Text = "You chose the fire path";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "It’s scorching hot; you sprint through the flames.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Exhausted, you reach the end, low on stamina.";
            textLable.Refresh();
            stamina -= 30;
            staminaLable.Text = stamina.ToString();
            Application.DoEvents();
            Thread.Sleep(5000);
            afterpath();
        }

        // --- Ice path decision ---
        private void icePathButton_Click(object sender, EventArgs e)
        {
            icePathButton.Visible = false;
            firePathButton.Visible = false;
            Application.DoEvents();
            textLable.Text = "You chose the ice path";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "The cold chills you, forcing you to use mana to stay warm.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You make it through, but your mana is drained.";
            textLable.Refresh();
            mana -= 30;
            manaLable.Text = mana.ToString();
            Application.DoEvents();
            Thread.Sleep(5000);
            afterpath();
        }

        // --- After defeating Grons ---
        private void afterGronBattle()
        {
            textLable.ForeColor = Color.Black;
            s1.Image = Properties.Resources.avg4th;
            s1.Refresh();
            battle.Stop();
            textLable.Text = "After defeating the grons you set off on your journey.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You reach a split in the path.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Right: fiery hell. Left: icy tundra.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Both paths lead to the king’s castle.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Which do you choose?";
            textLable.Refresh();
            icePathButton.Visible = true;
            firePathButton.Visible = true;
        }

        // --- After completing path ---
        private void afterpath()
        {
            s1.Image = Properties.Resources.avg5th;
            s1.Refresh();
            textLable.Text = "You arrive at the wizard king’s castle.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You confront him in a final duel!";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.ForeColor = Color.White;
            s1.Image = Properties.Resources.avg6th;
            s1.Refresh();
            battle.PlayLooping();
            textLable.Text = "Attack with everything you have!";
            textLable.Refresh();

            // Show attack options based on chosen element
            if (waterPower)
            {
                tide.Visible = true;
                storm.Visible = true;
            }
            else if (firePower)
            {
                fireball.Visible = true;
                ignite.Visible = true;
            }
            else if (earthPower)
            {
                tremour.Visible = true;
                rock.Visible = true;
            }
        }

        // --- Check Wizard King health ---
        private void checkWKH()
        {
            if (WKH <= 0)
            {
                battle.Stop();
                textLable.Text = "You defeated the wizard king!";
                textLable.Refresh();
                Thread.Sleep(5000);
                afterWKB();
            }
            else
            {
                battle.PlayLooping();
                textLable.Text = "The king still lives!";
                textLable.Refresh();
                Thread.Sleep(5000);
                textLable.Text = "Wizard King - Obliterate!";
                textLable.Refresh();
                health -= 30;
                healthLable.Text = health.ToString();
                Thread.Sleep(5000);
                textLable.Text = "Attack with everything you have!";
                textLable.Refresh();


                // Re-enable spell buttons for another round
                if (waterPower)
                {
                    tide.Visible = true;
                    storm.Visible = true;
                }
                else if (firePower)
                {
                    fireball.Visible = true;
                    ignite.Visible = true;
                }
                else if (earthPower)
                {
                    tremour.Visible = true;
                    rock.Visible = true;
                }
            }
        }

        // --- After Wizard King Battle ---
        private void afterWKB()
        {
            s1.Image = Properties.Resources.avg7th;
            s1.Refresh();
            textLable.Text = "A light shines from the king’s body...";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "He was possessed by a cursed amulet.";// dio
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "You must choose: take the amulet or destroy it.";
            textLable.Refresh();
            Thread.Sleep(5000);
            kingButton.Visible = true;
            saveButton.Visible = true;
        }

        // --- Ending: Sacrifice yourself ---
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            kingButton.Visible = false;
            Application.DoEvents();
            s1.Image = Properties.Resources.avg8th;
            s1.Refresh();
            textLable.Text = "You hold the amulet tightly and leap from the peak.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Memories flash as everything fades to black.";
            textLable.Refresh();
            Thread.Sleep(5000);
            replayButton.Visible = true;

        }

        // --- Ending: Become the king ---
        private void kingButton_Click(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            kingButton.Visible = false;
            Application.DoEvents();
            s1.Image = Properties.Resources.avg9th;
            s1.Refresh();
            textLable.Text = "You take the amulet and ascend the throne.";
            textLable.Refresh();
            Thread.Sleep(5000);
            textLable.Text = "Dark power fills you as you become the new king.";
            textLable.Refresh();
            Thread.Sleep(5000);
            replayButton.Visible = true;
        }

        private void textLable_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e) { }

        private void replayButton_Click(object sender, EventArgs e)
        {

            // Show menu UI
            titalLable2.Visible = true;
            titleLable.Visible = true;
            nameLable.Visible = true;
            startButton.Visible = true;
            nameInput.Visible = true;
            rulesButton.Visible = true;

            // Hide main game UI
            replayButton.Visible = false;
            textLable.Visible = false;
            healthLable.Visible = false;
            manaLable.Visible = false;
            staminaLable.Visible = false;
            healthText.Visible = false;
            manaText.Visible = false;
            staminaText.Visible = false;
            s1.Visible = false;
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            rules rulesForm = new rules();
            rulesForm.Show();
        }
    }
}
