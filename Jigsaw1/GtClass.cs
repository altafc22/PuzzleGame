using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinThantSin.OpenSourceGames
{
    class GtClass
    {
        public string imagePath = "";
        System.Media.SoundPlayer player;

        /* public void setImagePath(string path)
         {
             imagePath = path;
         }*/
        public string getResourceDirectory()
        {
            string directory = Application.ExecutablePath;
            string app_name = Path.GetFileName(directory);

            //Console.WriteLine("------ " + directory);
            //Console.WriteLine("------ " + app_name);

            int pos = directory.IndexOf(app_name);
            if (pos >= 0)
            {
                // String after founder  
                return directory.Remove(pos);
            }
            else
                return null;
        }
        public void playAudio(string sound)
        {
            string audio_file = getResourceDirectory() + @"sounds\" + sound;
            player = new System.Media.SoundPlayer(audio_file);
            player.Play();
        }


        public string selectImage()
        {
            string directory = getResourceDirectory() + @"images";
            //Console.WriteLine("------ " + directory);

            //string[] filePaths = Directory.GetFiles(directory, "*.jpg*");
            var ext = new List<string> { ".JPEG", ".jpeg", ".JPG", ".jpg", ".PNG", ".png", ".BMP", ".bmp" };
            var myFiles = Directory.GetFiles(directory, "*.*", SearchOption.TopDirectoryOnly)
                 .Where(s => ext.Contains(Path.GetExtension(s)));
            string[] filePaths = myFiles.ToArray();

            for (int i = 0; i < filePaths.Length; i++)
            {
                Console.WriteLine("+++++ " + filePaths[i]);
            }

            // Create a Random object  
            Random rand = new Random();
            // Generate a random index less than the size of the array.  
            //int index = rand.Next(filePaths.Length);
            int index = rand.Next(0, filePaths.Length);
            Console.WriteLine($"Randomly selected index is" + index);
            // Display the result.  
            Console.WriteLine($"Randomly selected image is {filePaths[index]}");
            //loadImage(filePaths[index]);
            imagePath = filePaths[index];
            Console.WriteLine("Image path found " + imagePath);
            return filePaths[index];
        }

        public string getImagePath()
        {
            if (imagePath != null || imagePath != "")
            {
                Console.WriteLine(imagePath);
                return imagePath;
            }
            else
            {
                return "no image found";
            }
        }
    }
}
