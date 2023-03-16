using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImportData
{
    class UtilsLib
    {
        public static ArrayList ReadFile(string fileName)
        {
            ArrayList arrConfig = new ArrayList();

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        arrConfig.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The file config could not be read");
            }

            return arrConfig;
        }
    }
}
