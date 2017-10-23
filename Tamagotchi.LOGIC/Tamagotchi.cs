using System;
using System.Timers;
using System.Windows.Forms;

namespace Tamagotchi.LOGIC
{
    class Tamagotchi
    {
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public LevensStadium LevensStadium { get; set; }
        public string Status { get; private set; }
        private int honger, geluk, intelligentie;
        private System.Timers.Timer timer;

        public delegate void LevensstadiumChanged(LevensStadium levensStadium);
        public event LevensstadiumChanged LevensstadiumChangedEvent;

        public Tamagotchi(string naam)
        {
            Naam = naam;
            Geboortedatum = DateTime.Now;
            LevensStadium = LevensStadium.EI;
            Honger = 4;
            Geluk = 4;
            Intelligentie = 4;
            timer = new System.Timers.Timer();

            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 1000;
            timer.Start();
        }

        private void TimerEventProcessor(object source, EventArgs eventArgs)
        {
            Random random = new Random();
            LevensStadium = GetLifeStage();

            int decrease = random.Next(1, 50);

            switch (decrease)
            {
                case 1: // Geluk
                    Geluk--;
                    break;

                case 2: // Honger
                    Honger--;
                    break;

                case 3: // Intelligentie
                    Intelligentie--;
                    break;
            }

            if (IsDead())
            {
                timer.Stop();
                LevensStadium = LevensStadium.DOOD;
            }

            if (LevensstadiumChangedEvent != null)
                LevensstadiumChangedEvent(LevensStadium);
        }

        public int Honger
        {
            get
            {
                return honger;
            }

            set
            {
                if (value < 0 || value > 4)
                    throw new ArgumentOutOfRangeException("Geef een waarde tussen 0 en 4");

                honger = value;
            }
        }

        public int Geluk
        {
            get
            {
                return geluk;
            }

            set
            {
                if (value < 0 || value > 4)
                    throw new ArgumentOutOfRangeException("Geef een waarde tussen 0 en 4");

                geluk = value;
            }
        }

        public int Intelligentie
        {
            get
            {
                return intelligentie;
            }

            set
            {
                if (value < 0 || value > 4)
                    throw new ArgumentOutOfRangeException("Geef een waarde tussen 0 en 4");

                intelligentie = value;
            }
        }

        public bool IsDead()
        {
            if (Honger == 0 || Geluk == 0 || Intelligentie == 0)
                return true;

            return false;
        }

        public LevensStadium GetLifeStage()
        {
            TimeSpan difference = DateTime.Now - Geboortedatum;
            int minutes = (int)Math.Round(difference.TotalSeconds); // todo change to minutes, seconds for debug purposes

            if (IsDead())
            {
                Honger = 0; Geluk = 0; Intelligentie = 0;
                return LevensStadium.DOOD;
            }

            Console.WriteLine(minutes);

            if (minutes < 1)
                return LevensStadium.EI;
            else if (minutes >= 1 && minutes <= 10)
                return LevensStadium.BABY;
            else if (minutes >= 10 && minutes <= 60)
                return LevensStadium.KIND;
            else if (minutes >= 61 && minutes <= 120)
                return LevensStadium.PUBER;
            else if (minutes >= 121 && minutes <= 300)
                return LevensStadium.VOLWASSEN;
            else if (minutes >= 301 && minutes <= 400)
                return LevensStadium.SENIOR;
            else if (minutes >= 400)
            {
                MessageBox.Show("Gefeliciteerd, u heeft het spel uitgespeeld.");
                return LevensStadium.DOOD;
            }
            else
                return LevensStadium.DOOD;
        }
    }
}
