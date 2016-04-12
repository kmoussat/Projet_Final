using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace POA_Final
{
    public class Dessin
    {
        private List<Element> ListElement;


        public Dessin()
        {
            ListElement = new List<Element>();
        }

        public List<Element> listElement
        {
            get { return ListElement; }
        }

        public void lireFichier(String nomDoc)
        {
            try
            {
                StreamReader monStreamReader = new StreamReader(@"..\..\..\" + nomDoc + ".csv");

                string ligne = monStreamReader.ReadLine();

                while (ligne != null)
                {
                    string[] temp = ligne.Split(';');
                    switch (temp[0])
                    {
                        case "Cercle":
                            Cercle c = new Cercle(temp[0], Convert.ToInt32(temp[1]), new Point(double.Parse(temp[2]), double.Parse(temp[3])), Convert.ToInt32(temp[4]), new Couleur(int.Parse(temp[5]), int.Parse(temp[6]), int.Parse(temp[7])), Convert.ToInt32(temp[8]));
                            if (c != null)
                            {
                                ListElement.Add(c);
                            }
                            break;

                        case "Ellipse":
                            Ellipse e = new Ellipse(temp[0], Convert.ToInt32(temp[1]), new Point(double.Parse(temp[2]), double.Parse(temp[3])), Convert.ToInt32(temp[4]), Convert.ToInt32(temp[5]), new Couleur(int.Parse(temp[6]), int.Parse(temp[7]), int.Parse(temp[8])), Convert.ToInt32(temp[9]));
                            if (e != null)
                            {
                                ListElement.Add(e);
                            }
                            break;

                        case "Rectangle":
                            Rectangle r = new Rectangle(temp[0], Convert.ToInt32(temp[1]), new Point(double.Parse(temp[2]), double.Parse(temp[3])), Convert.ToInt32(temp[4]), Convert.ToInt32(temp[5]), new Couleur(int.Parse(temp[6]), int.Parse(temp[7]), int.Parse(temp[8])), Convert.ToInt32(temp[9]));
                            if (r != null)
                            {
                                ListElement.Add(r);
                            }
                            break;

                        case "Polygone":
                            Polygone p = new Polygone(temp[0], Convert.ToInt32(temp[1]), temp[2], new Couleur(int.Parse(temp[3]), int.Parse(temp[4]), int.Parse(temp[5])), Convert.ToInt32(temp[6]));
                            if (p != null)
                            {
                                ListElement.Add(p);
                            }
                            break;

                        case "Chemin":
                            Chemin ch = new Chemin(temp[0], Convert.ToInt32(temp[1]), temp[2], new Couleur(int.Parse(temp[3]), int.Parse(temp[4]), int.Parse(temp[5])), Convert.ToInt32(temp[6]));
                            if (ch != null)
                            {
                                ListElement.Add(ch);
                            }
                            break;

                        case "Texte":
                            Texte t = new Texte(temp[0], Convert.ToInt32(temp[1]), new Point(double.Parse(temp[2]), double.Parse(temp[3])), temp[4], new Couleur(int.Parse(temp[5]), int.Parse(temp[6]), int.Parse(temp[7])), Convert.ToInt32(temp[8]));
                            if (t != null)
                            {
                                ListElement.Add(t);
                            }
                            break;

                        case "Translation":
                            int idTranslation = Convert.ToInt32(temp[1]);
                            double dx = double.Parse(temp[2]);
                            double dy = double.Parse(temp[3]);

                            foreach (Element el in ListElement)
                            {
                                if (idTranslation == el.IdElement)
                                {
                                    if (el.Nom == "Cercle")
                                    {
                                        ((Cercle)el).Translater(dx, dy);
                                    }
                                    else if (el.Nom == "Ellipse")
                                    {
                                        ((Ellipse)el).Translater(dx, dy);
                                    }
                                    else if (el.Nom == "Rectangle")
                                    {
                                        ((Rectangle)el).Translater(dx, dy);
                                    }
                                    else if (el.Nom == "Polygone")
                                    {
                                        ((Polygone)el).Translater(dx, dy);
                                    }
                                    else if (el.Nom == "Chemin")
                                    {
                                        ((Chemin)el).Translater(dx, dy);
                                    }
                                    else if (el.Nom == "Texte")
                                    {
                                        ((Texte)el).Translater(dx, dy);
                                    }
                                }
                            }
                            break;

                        case "Rotation":
                            int idRotation = Convert.ToInt32(temp[1]);
                            double alpha = double.Parse(temp[2]);
                            double cx = double.Parse(temp[3]);
                            double cy = double.Parse(temp[4]);

                            foreach (Element el in ListElement)
                            {
                                if (idRotation == el.IdElement)
                                {
                                    if (el.Nom == "Cercle")
                                    {
                                        ((Cercle)el).Rotation(alpha, cx, cy);
                                    }
                                    else if (el.Nom == "Ellipse")
                                    {
                                        ((Ellipse)el).Rotation(alpha, cx, cy);
                                    }
                                    else if (el.Nom == "Rectangle")
                                    {
                                        ((Rectangle)el).Rotation(alpha, cx, cy);
                                    }
                                    else if (el.Nom == "Polygone")
                                    {
                                        ((Polygone)el).Rotation(alpha, cx, cy);
                                    }
                                    else if (el.Nom == "Chemin")
                                    {
                                        ((Chemin)el).Rotation(alpha, cx, cy);
                                    }
                                    else if (el.Nom == "Texte")
                                    {
                                        ((Texte)el).Rotation(alpha, cx, cy);
                                    }
                                }
                            }
                            break;
                    }
                    ligne = monStreamReader.ReadLine();
                }
                monStreamReader.Close();
            }
            catch
            {
                Console.WriteLine("Il y a eu une erreur dans l'ouverture du fichier");
            }
        }

        public void ecrireFichier(String nomDoc)
        {
            try
            {
                StreamWriter monStreamWriter = new StreamWriter(nomDoc + ".svg");

                monStreamWriter.WriteLine("<svg xmlns='http://www.w3.org/2000/svg' version='1.1'>");

                foreach (Element e in ListElement)
                {
                    monStreamWriter.WriteLine(e.ToString());
                }

                monStreamWriter.WriteLine("</svg>");
                monStreamWriter.Close();
            }
            catch
            {
                Console.WriteLine("Il y a eu une erreur dans l'écriture du fichier");
            }
        }
    }
}
