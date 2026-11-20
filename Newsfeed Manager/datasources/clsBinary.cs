using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newsfeed_Manager.datasources
{
    public class clsBinary : datenInterface
    {
        public List<wrpNewsfeed> leseDaten()
        {
            Stream stream = File.Open(Application.UserAppDataPath + "\\daten.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<wrpNewsfeed> feeds= (List<wrpNewsfeed>) bf.Deserialize(stream);
            stream.Close();
            return feeds;
        }

        public void schreibeDaten(List<wrpNewsfeed> newsliste)
        {
            Stream stream = File.Open(Application.UserAppDataPath + "\\daten.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, newsliste);
            stream.Close();
        }
    }
}
