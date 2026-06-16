using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Primitives;
using System.Xml;
using System.IO;
using ScratchUtility;

namespace FileParser
{
    public static class X3DFile
    {
        public static Coord CameraPosition { get; set; }

        /// <summary>Parses the x3d file that this X3dFile represents and extracts the IndexedFaces and CameraPosition.</summary>
        public static List<IndexedFaceSet> Parse(string fullPath, double scale)
        {
            List<IndexedFaceSet> results = new List<IndexedFaceSet>();

            StreamReader sr = new StreamReader(fullPath);
            string s = "";
            while (!s.Contains("</head>", StringComparison.InvariantCultureIgnoreCase) && !sr.EndOfStream)
            {
                s = sr.ReadLine();
            }

            XmlTextReader reader = new XmlTextReader(sr);

            string name = "";
            string coordIndices = "";
            string points = "";

            while (reader.Read())
            {
                //Console.WriteLine(reader.Name);
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        if (reader.Name == "Transform")
                        {
                            name = reader["DEF"];
                        }
                        else if (reader.Name == "IndexedFaceSet")
                        {
                            coordIndices = reader["coordIndex"];
                        }
                        else if (reader.Name == "Coordinate")
                        {
                            points = reader["point"];
                        }
                        else if (reader.Name == "Viewpoint")
                        {
                            string[] camera = reader["position"].Split(' ');
                            CameraPosition = new Coord(double.Parse(camera[1]) * scale, double.Parse(camera[2]) * scale, -double.Parse(camera[0]) * scale);
                        }
                        break;
                }

                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "IndexedFaceSet")
                {
                    IndexedFaceSet ifs = new IndexedFaceSet(name, coordIndices, points, scale);
                    results.Add(ifs);
                }
                if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Scene")
                {
                    break;
                }
            }

            return results;
        }
    }
}
