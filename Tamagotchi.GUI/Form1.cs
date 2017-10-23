using System;
using System.Windows.Forms;
using Tamagotchi.LOGIC;
using Microsoft.VisualBasic;

namespace we3.tamagotchi
{
    public partial class Form1 : Form
    {
        private Tamagotchi tamagotchi;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Tamagotchi", "Geef je Tamagotchi een naam!", "Default", 0, 0);
            tamagotchi = new Tamagotchi(name);
            tamagotchi.LevensstadiumChangedEvent += Tamagotchi_LevensstadiumChangedEvent; ;
            LoadForm();
        }

        private void Tamagotchi_LevensstadiumChangedEvent(LevensStadium levensStadium)
        {
            LoadForm();
            Console.WriteLine(tamagotchi.IsDead() + ", " + tamagotchi.GetLifeStage());
        }

        public void LoadForm()
        {
            nameLabel.Text = tamagotchi.Naam;
            gelukLabel.Text = tamagotchi.Geluk.ToString();
            hongerLabel.Text = tamagotchi.Honger.ToString();
            intelligentieLabel.Text = tamagotchi.Intelligentie.ToString();
            statusLabel.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(tamagotchi.LevensStadium.ToString().ToLower());

            if (tamagotchi.IsDead())
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                pictureBox1.Load(@"Tamagotch-Dood.jpg");
            }
            else
                pictureBox1.Load(@"Tamagotchi.jpg");

        }

        private void SpeelEvent(object sender, EventArgs e)
        {
            try
            {
                tamagotchi.Geluk += 1;
            } catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Je hebt al teveel gespeeld!", "Hola", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void EetEvent(object sender, EventArgs e)
        {
            try
            {
                tamagotchi.Honger += 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Je hebt al teveel gegeten!", "Hola", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LeerEvent(object sender, EventArgs e)
        {
            try
            {
                tamagotchi.Intelligentie += 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Je hebt al teveel geleerd!", "Hola", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeForm timeForm = new TimeForm();
            timeForm.ShowDialog();
        }
    }
}
