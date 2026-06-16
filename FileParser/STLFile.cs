using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primitives;
using ScratchUtility;

namespace FileParser
{
    public static class STLFile
    {
        public static int Precision = 4;

        public static IndexedFaceSet Parse(string filePath)
        {
            double scale = 1.0;
            string name = Path.GetFileNameWithoutExtension(filePath);
            StreamReader sr = new StreamReader(filePath);
            var parsedFaceCoords = new List<Coord>();
            var parsedModel = new List<List<Coord>>();

            try
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine().Trim();
                    string[] lineParts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (lineParts[0] == "vertex")
                    {
                        Coord coord = new Coord(
                            Math.Round(double.Parse(lineParts[1]), Precision),
                            Math.Round(double.Parse(lineParts[2]), Precision),
                            Math.Round(double.Parse(lineParts[3]), Precision));
                        parsedFaceCoords.Add(coord);
                    }

                    if (lineParts[0] == "endloop")
                    {
                        parsedModel.Add(parsedFaceCoords);
                        parsedFaceCoords = new List<Coord>();
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }

            // IndexedFaceSet internally transformDo post parsing initialization to update Vertex/Edge graph references
            // XYZ
            IndexedFaceSet result = new IndexedFaceSet(name, parsedModel, scale);
            return result;
        }
    }
}
