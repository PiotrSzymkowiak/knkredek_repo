using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrSzymkowiakLab2Zad2
{
    interface IMovable
    {
        float Speed { get; set; }
        void Move();

    }
}
