using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeDesignPatternClassLibrary.Classes;

namespace FacadeDesignPatternClassLibrary
{
    public class HomeSystemFacade
    {
        Amplifier amp;
        Tuner tuner;
        DvdPlayer dvdPlayer;
        CdPlayer cdPlayer;
        Projector projector;
        TheaterLights theaterLights;
        Screen screen;
        PopcornPopper popper;

        public HomeSystemFacade(Amplifier amp,
            Tuner tuner,
            DvdPlayer dvdPlayer,
            CdPlayer cdPlayer,
            Projector projector,
            TheaterLights theaterLights,
            Screen screen, 
            PopcornPopper popper
            )
        {
            this.amp = amp;
            this.dvdPlayer = dvdPlayer;
            this.cdPlayer = cdPlayer;
            this.projector = projector;
            this.theaterLights = theaterLights;
            this.screen = screen;
            this.popper = popper;

        }

        public void watchMovie(String movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.On();
            popper.Pop();
            theaterLights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amp.On();
            amp.SetDvd(dvdPlayer);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            theaterLights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();
        }
    }
}
