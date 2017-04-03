using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrSzymkowiakLab2Zad2
{
    public delegate void CrashedEventHandler(object sender, EventArgs e);
    public delegate void RepairedEventHandler(object sender, EventArgs e);

    class Vehicle : IMovable
    {
        protected float _speed;
        protected float _maxSpeed;
        protected bool _isBroken;
        protected int _numberOfWheels;
        protected float _quality;
        protected float _acceleration;

        public event CrashedEventHandler Crashed;
        public event RepairedEventHandler Repaired;
        public float Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                if ( value < 0 ) return;
                _speed = value;
            }
        }

        public float Acceleration
        {
            get
            {
                return _acceleration;
            }

            protected set
            {
                if (value < 0) return;
                _acceleration = value;
            }
        }

        public float Quality
        {
            get
            {
                return _quality;
            }
            protected set
            {
                if (value < 0 || value > 100) return;
                _quality = value;
            }
        }        

        public float MaxSpeed
        {
            get { return _maxSpeed; }
            protected set
            {
                if ( _maxSpeed < 0 ) return;
                _maxSpeed = value;
            }
        }


        public Vehicle()
        {
            _numberOfWheels = 4;
            Quality = 100;
            Speed = 0;
            _isBroken = false;
            MaxSpeed = 100;
            Acceleration = 5;
        }


        protected virtual void OnCrash(EventArgs e)
        {
            if(Crashed != null)                          
                Crashed(this, e);           
        }

        protected virtual void OnRepair(EventArgs e)
        {
            if (Crashed != null)
                Repaired(this, e);
        }

        public void Crash()
        {
            _isBroken = true;
            Speed = 0;
            OnCrash(EventArgs.Empty);
        }

        public void Repair()
        {
            QualityDecreasing();
            if(Quality > 0) _isBroken = false;         
            OnRepair(EventArgs.Empty);
        }

        private void QualityDecreasing()
        {
            Random random = new Random();
            float qualityDecreasingAmount = (float)random.NextDouble() * 50 + 1;
            if (!CanBeRepaired(qualityDecreasingAmount)) Quality = 0;
            else
            {
                Quality -= qualityDecreasingAmount;
            }
        }

        private bool CanBeRepaired(float qualityDecreasingAmount)
        {
            if (Quality - qualityDecreasingAmount <= 0) return false;
            else return true;
        }
        public void SpeedUp()
        {
            if (_isBroken == true) return;
            if (Speed + Acceleration >= MaxSpeed) Speed = MaxSpeed;
            else Speed += Acceleration;
        }

        public void SlowDown()
        {           
            Speed -= Acceleration;
        }

        public void Move()
        {
            if( _isBroken == true ) Console.WriteLine($"{this.ToString()} is broken, can't move");
            else Console.WriteLine($"{this.ToString()} is moving with speed of {Speed}/{MaxSpeed}");
        }

        public override string ToString()
        {
            return "Vehicle";
        }

    }
}
