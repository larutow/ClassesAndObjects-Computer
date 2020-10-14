using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    class AppStore
    {
        public List<Games> availableGames;
        public List<TextEditor> availableTextEditors;
        public List<Messengers> availableMessengers;
        public List<Applications> availableApplications;

        public AppStore()
        {
            availableGames = new List<Games>();
            availableTextEditors = new List<TextEditor>();
            availableMessengers = new List<Messengers>();
            availableApplications = new List<Applications>();
            PopulateAppStore();
        }

        public void PopulateAppStore()
        {
            PopulateGames();
            PopulateTextEditors();
            PopulateMessengers();
            
        }

        public void PopulateGames()
        {
            availableGames.Add(new Games("Doom", 8, 25, 8));
            availableGames.Add(new Games("Katamari", 4, 3, 4));
            availableGames.Add(new Games("CyberPunk 2077", 16, 80, 16));
        }

        public void PopulateTextEditors()
        {
            availableTextEditors.Add(new TextEditor("VS Code", 2, 2));
            availableTextEditors.Add(new TextEditor("VIM", 2, 2));
            availableTextEditors.Add(new TextEditor("Emacs", 2, 2));

        }

        public void PopulateMessengers()
        {
            availableMessengers.Add(new Messengers("Slack", 2, 4));
            availableMessengers.Add(new Messengers("Teams", 3, 4));
            availableMessengers.Add(new Messengers("Discord", 4, 4));

        }
    }
}
