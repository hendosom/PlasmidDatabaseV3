using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasmidDatabaseV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.DatabaseProgram();
            
        }

        /* 
         
        Infos zur Programm-Struktur (V3.0):
        Main-Methode initialisiert und controller und startet das Datenbank-Programm

        Dort wird das Windows Form (View) initialisiert und gestartet

        Ein Plasmid-Objekt wird initialisiert und der Input im View wird übergeben

        Über in Modul gespeicherte Methoden wird ein Dateipfad als string gespeichert und anschließend die Plasmiddaten als Datei unter diesem Pfad gespeichert
         
         */
    }
}
