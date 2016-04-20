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
        //Un dessin est une combinaison de plusieurs éléments. Un dessin contient donc une liste d'éléments.
        //Attribut
        private List<Element> ListElement;

        // Constructeur
        public Dessin()
        {
            ListElement = new List<Element>();
        }

        public List<Element> listElement
        {
            get { return ListElement; }
        }
        
        /* 
        La méthode lireFichier implémente un StreamReader capable de lire les caractères d'un fichier.
        Les données sont ensuite stockées dans des variables qui seront reconverties dans d'autres méthodes.
        */
        public void lireFichier(String nomDoc)
        {
            try
            {
                StreamReader monStreamReader = new StreamReader(@"" + nomDoc + ".csv");

                string ligne = monStreamReader.ReadLine();

                while (ligne != null)
                {
                    // A chaque ligne, le code différencie le type de figure et génère une classe en fonction du premier élément de la ligne avant le premier ';'
                    //temp prend toutes les valeurs de la ligne
                    string[] temp = ligne.Split(';');
                    switch (temp[0])
                    {
                        case "Cercle":
                        //La classe s'implémente avec tous les éléments de temp
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
                        
                        //si une ligne commence par une rotation ou une translation, c'est tout le dessin qui est affecté
                        //on modifie donc chaque élément de la liste du dessin en utilisant les méthodes des classes concernées
                        case "Translation":
                            int idTranslation = Convert.ToInt32(temp[1]);
                            double dx = double.Parse(temp[2]);
                            double dy = double.Parse(temp[3]);
                            
                            //le foreach est utilisé pour parcourir chaque élément de la liste
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
                    // Le code change de ligne
                    ligne = monStreamReader.ReadLine();
                }
                //fermeture de la lecture du fichier
                monStreamReader.Close();
            }
            //try/catch pour gérer la gestion d'erreur par exeption - ici, gère l'echec de génération du streamread
            catch
            {
                Console.WriteLine("Erreur - Lecture");
            }
        }
        
        //ecrireFichier est la méthode de convertion des données extraites, en SVG
        public void ecrireFichier(String nomDoc)
        {
            try
            {
                //Ouverture d'un StreamWriter capable de générer et d'écrire des fichiers
                StreamWriter monStreamWriter = new StreamWriter(nomDoc + ".svg");
                
                //xmlnx donne le type de rédaction du fichier svg avec les balises associées
                monStreamWriter.WriteLine("<svg xmlns='http://www.w3.org/2000/svg' version='1.1'>");
                
                //le code parcours la liste d'élément et utilise la méthode ToString de chaque élément pour y écrire les balises.
                //Les ToString ont été prévus pour renvoyer les balises avec les données stockées dans les attributs de chaque élément.
                foreach (Element e in ListElement)
                {
                    monStreamWriter.WriteLine(e.ToString());
                }

                monStreamWriter.WriteLine("</svg>");
                //fermeture du stream
                monStreamWriter.Close();
            }
            catch // gestion d'erreur par exception - ici en cas d'échec de génération du StreamWriter
            {
                Console.WriteLine("Erreur- Ecriture");
            }
        }
    }
}
