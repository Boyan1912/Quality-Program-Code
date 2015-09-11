using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this Singleton class keeps cache of the values already set and can display them without calling other classes

namespace Singleton
{
    public class Settings
    {

        private static Settings instance;
        private Dictionary<string, int> values;
        private readonly string[] pictureSettings = new string[] { "Contrast", "Brightness", "Sharpness" };
        private const int DEFAULT_VALUE = 50;

        private Settings()
        {

        }

        public static Settings Instance()
        {
            if (instance == null)
            {
                instance = new Settings();
            }
            return instance;
        }


        public Dictionary<string, int> Values { 
            get
            {
                if (this.values == null)
                {
                    this.values = new Dictionary<string, int>();
                    foreach (var setting in pictureSettings)
                    {
                        this.values.Add(setting, DEFAULT_VALUE);
                    }
                }
                return this.values;
            }
            set
            {
                this.values = value;
            }
            
        }

        public ISetting SetContrast(int value)
        {
            var contrast = new Contrast();
            contrast.Set(value);
            this.Values["Contrast"] = value;
            return contrast;
        }

     //   public ISetting SetBrightness(int value)
     //   {
     //       ...
     //   }
     //
     //   public ISetting SetSharpness(int value)
     //   {
     //       ...
     //   }

        public void ShowSettings()
        {
            foreach (var setting in this.Values)
            {
                Console.WriteLine(string.Format("{0} : {1}", setting.Key, setting.Value));
            }
        }

    }
}
