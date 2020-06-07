using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeDesignPatternClassLibrary;
using FacadeDesignPatternClassLibrary.Classes;

namespace FacadeDesingPatternImplementation
{
    class Program
    {        

        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            DvdPlayer dvdPlayer = new DvdPlayer();
            CdPlayer cdPlayer = new CdPlayer();
            TheaterLights lights = new TheaterLights();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights theaterLights = new TheaterLights();
            Tuner tuner = new Tuner();
            PopcornPopper popper = new PopcornPopper();
            HomeSystemFacade homeSystem = new HomeSystemFacade(amp, tuner, dvdPlayer, cdPlayer, projector,
               lights, screen, popper);

            homeSystem.watchMovie("Inside out");
            homeSystem.endMovie();
        }
    }
}
