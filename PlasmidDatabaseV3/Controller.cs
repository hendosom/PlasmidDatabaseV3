using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlasmidDatabaseV3
{
    public class Controller
    {
        public void DatabaseProgram()
        {
            View view = new View();
            Application.Run(view);

            Modul modul = new Modul();

            if (true)
            {
                Plasmid plasmid = new Plasmid();
                plasmid.PlasmidName = view.NameInput.ToString();
                plasmid.PlasmidSequence = view.SequenceInput.ToString();

                
                plasmid.FilePath= modul.CreateFilePath(plasmid.PlasmidName.ToString());
                modul.CreatePlasmid(plasmid.PlasmidName, plasmid.PlasmidSequence, plasmid.FilePath);

                if (modul.CheckFileExistence(plasmid.FilePath) == true)
                {
                    Console.WriteLine("File angelegt!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("File nicht angelegt!");
                    Console.ReadLine();
                }
            }

            
        }

    }
}
