using System;

namespace PiotrSzymkowiakLab2Zad2
{
    public delegate void CrashedEventHandler(object sender, EventArgs e);
    public delegate void RepairedEventHandler(object sender, EventArgs e);

    class Vehicle : IMovable
    {
        private float speed;
        private float maxSpeed;
        private float quality;
        private float acceleration;
        protected bool isBroken { get; set; }
        protected int numberOfWheels { get; set; }


        public event CrashedEventHandler Crashed;
        public event RepairedEventHandler Repaired;
        public float Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                speed = value;
            }
        }

        public float Acceleration
        {
            get
            {
                return acceleration;
            }

            protected set
            {
                if (value < 0)
                {
                    return;
                }
                acceleration = value;
            }
        }

        public float Quality
        {
            get
            {
                return quality;
            }
            protected set
            {
                if (value < 0 || value > 100)
                {
                    return;
                }
                quality = value;
            }
        }        

        public float MaxSpeed
        {
            get { return maxSpeed; }
            protected set
            {
                if (maxSpeed < 0)
                {
                    return;
                }
                maxSpeed = value;
            }
        }

        public Vehicle(float maxSpeed, float acceleration)
        {
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            Quality = 100;
            isBroken = false;
            Speed = 0;
        }

        public Vehicle()
        {
            Quality = 100;
            Speed = 0;
            isBroken = false;
            MaxSpeed = 100;
            Acceleration = 5;
        }

        protected virtual void OnCrash(EventArgs e)
        {
            if(Crashed != null)                          
                Crashed.Invoke(this, e);           
        }

        protected virtual void OnRepair(EventArgs e)
        {
            if (Repaired != null)
                Repaired.Invoke(this, e);
        }

        public void Crash()
        {
            isBroken = true;
            Speed = 0;
            OnCrash(EventArgs.Empty);
        }

        public void Repair()
        {
            QualityDecreasing();
            if (Quality > 0)
            {
                isBroken = false;
            }         
            OnRepair(EventArgs.Empty);
        }

        private void QualityDecreasing()
        {
            Random random = new Random();
            float qualityDecreasingAmount = (float)random.NextDouble() * 50 + 1;
            if (!CanBeRepaired(qualityDecreasingAmount))
            {
                Quality = 0;
            }
            else
            {
                Quality -= qualityDecreasingAmount;
            }
        }

        private bool CanBeRepaired(float qualityDecreasingAmount)
        {
            if (Quality - qualityDecreasingAmount <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void SpeedUp()
        {
            if (isBroken)
            {
                return;
            }

            if (Speed + Acceleration >= MaxSpeed)
            {
                Speed = MaxSpeed;
            }
            else
            {
                Speed += Acceleration;
            }
        }

        public void SlowDown()
        {           
            Speed -= Acceleration;
        }

        public void Move()
        {
            if (isBroken)
            {
                Console.WriteLine($"{this.ToString()} is broken, can't move");
            }
            else
            {
                Console.WriteLine($"{this.ToString()} is moving with speed of {Speed}/{MaxSpeed}");
            }
        }

        public override string ToString()
        {
            return "Vehicle";
        }

    }
}
