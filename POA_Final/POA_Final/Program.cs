using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemple_1

            #region Chemin_11
            Couleur coul11 = new Couleur(255, 0, 0);
            Chemin ch11 = new Chemin("Chemin", 1, "M 299.6824 31.7717 C 298.0504 31.7717 296.5144 32.6357 295.6504 33.97971 L 165.5696 247.581 L 35.48885 461.1822 C 34.62484 462.5262 34.62484 464.2542 35.48885 465.5982 C 36.35285 466.9422 37.88886 467.8062 39.52087 467.8062 L 559.8439 467.8062 C 561.4759 467.8062 563.0119 466.9422 563.876 465.5982 C 564.74 464.2542 564.74 462.5262 563.876 461.1822 L 303.7144 33.97971 C 302.8504 32.6357 301.3144 31.7717 299.6824 31.7717 z", coul11, 1);

            #endregion

            #region Chemin_12
            Couleur coul12 = new Couleur(255, 0, 0);
            Chemin ch12 = new Chemin("Chemin", 2, "M 299.7514 39.46512 C 298.2057 39.54152 296.7649 40.40413 295.9414 41.68514 L 165.8606 255.2864 L 147.7405 285.0466 C 191.8747 311.5396 243.5133 326.8068 298.7014 326.8068 C 354.6732 326.8068 407.0086 311.1293 451.5523 283.9366 L 304.0114 41.68514 C 303.1474 40.34112 301.6234 39.46512 299.9914 39.46512 C 299.9149 39.46512 299.8274 39.46136 299.7514 39.46512 z", coul12, 3);
            #endregion

            #region Chemin_13
            Couleur coul13 = new Couleur(255, 255, 255);
            Chemin ch13 = new Chemin("Chemin", 3, "M 286.4344 145.7244 L 129.2814 403.678 C 126.5934 408.1901 126.5934 413.7581 129.2814 418.1741 C 131.9695 422.6861 137.0575 425.4702 142.5295 425.4702 L 456.7395 425.4702 C 462.2115 425.4702 467.2996 422.6861 469.9876 418.1741 C 472.6756 413.6621 472.6756 408.1901 469.9876 403.678 L 312.9306 145.7244 C 310.2426 141.2124 305.1545 138.4284 299.6825 138.4284 C 294.2105 138.4284 289.1224 141.2124 286.4344 145.7244 z", coul13, 4);
            #endregion

            #region Chemin_14
            Couleur coul14 = new Couleur(0, 0, 0);
            Chemin ch14 = new Chemin("Chemin", 4, "M 291.3968 416.3174 C 282.3931 412.0051 275.5362 401.6362 275.5362 392.3333 C 275.5362 375.0116 293.6366 361.9634 310.762 366.9398 C 322.3151 370.2971 330.1674 380.7229 330.0712 392.5774 C 329.9891 402.6474 325.6306 410.0656 316.7341 415.2773 C 309.9242 419.2665 298.5306 419.7341 291.3968 416.3174 z M 293.4432 347.9194 C 292.3177 347.3009 289.6669345.1473 287.5529 343.1337 C 280.1664 336.0983 280.1756 336.1602 275.3607 260.8815 C 271.0805 193.9641 271.0451 192.9243 272.8817 188.1175 C 277.0134 177.3028 286.2196 172.5672 301.5485 173.3714 C 311.2922 173.8827 318.7963 177.3045 323.674 183.4607 C 327.8404 188.719 328.7462 191.6916 328.7424 200.0923 C 328.7383 209.2211 322.9068 321.1701 322.0779 328.0305 C 320.9926 337.0156 315.7466 344.3072 308.0575 347.5177 C 303.6637 349.3525 296.4136 349.5518 293.4432 347.9194 z", coul14, 5);
            #endregion

            #region Chemin_15
            Couleur coul15 = new Couleur(255, 0, 0);
            Chemin ch15 = new Chemin("Chemin", 5, "M 299.6464 31.7717 C 298.0144 31.7717 296.4783 32.6357 295.6143 33.97971 L 165.5336 247.581 L 35.45283 461.1822 C 34.58882 462.5262 34.58882 464.2542 35.45283 465.5982 C 36.31683 466.9422 37.85284 467.8062 39.48485 467.8062 L 559.8079 467.8062 C 561.4399 467.8062 562.9759 466.9422 563.8399 465.5982 C 564.7039 464.2542 564.7039 462.5262 563.8399 461.1822 L 303.6784 33.97971 C 302.8144 32.6357 301.2784 31.7717 299.6464 31.7717 z", coul15, 2);
            #endregion

            #endregion

            #region Exemple_2

            #region Rectangle_21
            Point p21 = new Point(6, 6);
            Couleur coul21 = new Couleur(255, 255, 255);
            Rectangle r21 = new Rectangle("Rectangle", 2, p21, 288, 188, coul21, 2);
            #endregion

            #region Cercle_21
            Point p22 = new Point(150, 100);
            Couleur coul22 = new Couleur(190, 0, 38);
            Cercle c21 = new Cercle("Cercle", 3, p22, 60, coul22, 3);
            #endregion

            #region Texte_21
            Point p23 = new Point(150, 220);
            Couleur coul23 = new Couleur(0, 0, 0);
            Texte t21 = new Texte("Cercle", 1, p23, "Japon", coul23, 4);
            #endregion

            #region Rectangle_22
            Point p24 = new Point(0, 0);
            Couleur coul24 = new Couleur(200, 200, 200);
            Rectangle r22 = new Rectangle("Rectangle", 4, p24, 300, 200, coul24, 1);
            #endregion

            #region Translation_21
            #endregion

            #region Translation_22
            #endregion

            #region Translation_23
            #endregion

            #region Rotation_21
            #endregion

            #region Chemin_21
            Couleur coul25 = new Couleur(17, 69, 126);
            Chemin ch21 = new Chemin("Chemin", 5, "M45,30L0,0v60z", coul25, 7);
            #endregion

            #region Chemin_22
            Couleur coul26 = new Couleur(215, 20, 26);
            Chemin ch22 = new Chemin("Chemin", 6, "M0,0h90v60h-90z", coul26, 5);
            #endregion

            #region Chemin_23
            Couleur coul27 = new Couleur(255, 255, 255);
            Chemin ch23 = new Chemin("Chemin", 7, "M0,0h90v30h-90z", coul27, 6);
            #endregion

            #endregion

            #region Exemple_3

            #region Cercle_31
            Point p31 = new Point(0, 0);
            Couleur coul31 = new Couleur(0, 255, 0);
            Cercle c31 = new Cercle("Cercle", 1, p31, 3, coul31, 2);
            #endregion

            #region Cercle_32
            Point p32 = new Point(0, 0);
            Couleur coul32 = new Couleur(0, 255, 0);
            Cercle c32 = new Cercle("Cercle", 2, p32, 3, coul32, 2);
            #endregion

            #region Cercle_33
            Point p33 = new Point(0, 0);
            Couleur coul33 = new Couleur(0, 255, 0);
            Cercle c33 = new Cercle("Cercle", 3, p33, 3, coul33, 2);
            #endregion

            #region Cercle_34
            Point p34 = new Point(0, 0);
            Couleur coul34 = new Couleur(0, 255, 0);
            Cercle c34 = new Cercle("Cercle", 4, p34, 3, coul34, 2);
            #endregion

            #region Cercle_35
            Point p35 = new Point(0, 0);
            Couleur coul35 = new Couleur(0, 255, 0);
            Cercle c35 = new Cercle("Cercle", 5, p35, 3, coul35, 2);
            #endregion

            #region Chemin_31
            Couleur coul36 = new Couleur(255, 0, 255);
            Chemin ch31 = new Chemin("Chemin", 6, "M 75,13.879749 L 90.3454,60.62831 L 139.26563,60.571469 L 99.5471,89.611899 L 114.71834,136.12025 L 74.825551,107.31967 L 35.281661,136.12024 L 50.345081,89.280069 L 10.73437,60.571459 L 59.936881,60.423219 L 75,13.879749 z", coul36, 1);
            #endregion

            #region Translation_31
            #endregion

            #region Translation_32
            #endregion

            #region Translation_33
            #endregion

            #region Translation_35
            #endregion

            #endregion

            #region Exemple_4

            #region Cercle_41
            Point p41 = new Point(0, 0);
            Couleur coul41 = new Couleur(255, 245, 53);
            Cercle c41 = new Cercle("Cercle", 102, p41, 4, coul41, 35);
            #endregion

            #region Cercle_42
            Point p42 = new Point(0, 0);
            Couleur coul42 = new Couleur(0, 0, 0);
            Cercle c42 = new Cercle("Cercle", 111, p41, 3, coul41, 37);
            #endregion

            #region Cercle_43
            Point p43 = new Point(0, 0);
            Couleur coul43 = new Couleur(255, 245, 53);
            Cercle c43 = new Cercle("Cercle", 112, p43, 2, coul43, 40);
            #endregion

            #region Cercle_44
            Point p44 = new Point(50, 50);
            Couleur coul44 = new Couleur(0, 0, 0);
            Cercle c44 = new Cercle("Cercle", 1, p44, 41, coul31, 2);
            #endregion

            #region Cercle_45
            Point p45 = new Point(50, 50);
            Couleur coul45 = new Couleur(255, 255, 255);
            Cercle c45 = new Cercle("Cercle", 12, p45, 40, coul45, 1);
            #endregion

            #region Cercle_46
            Point p46 = new Point(50, 50);
            Couleur coul46 = new Couleur(0, 0, 0);
            Cercle c46 = new Cercle("Cercle", 130, p46, 36, coul46, 2);
            #endregion

            #region Cercle_47
            Point p47 = new Point(50, 50);
            Couleur coul47 = new Couleur(255, 255, 255);
            Cercle c47 = new Cercle("Cercle", 2, p47, 35, coul47, 3);
            #endregion

            #region Cercle_48
            Point p48 = new Point(50, 50);
            Couleur coul48 = new Couleur(0, 0, 0);
            Cercle c48 = new Cercle("Cercle", 3, p48, 32, coul48, 4);
            #endregion

            #region Cercle_49
            Point p49 = new Point(50, 50);
            Couleur coul49 = new Couleur(255, 255, 255);
            Cercle c49 = new Cercle("Cercle", 305, p49, 29, coul49, 5);
            #endregion

            #region Cercle_410
            Point p410 = new Point(50, 50);
            Couleur coul410 = new Couleur(0, 0, 0);
            Cercle c410 = new Cercle("Cercle", 4, p410, 28, coul410, 6);
            #endregion

            #region Cercle_411
            Point p411 = new Point(50, 50);
            Couleur coul411 = new Couleur(65, 183, 200);
            Cercle c411 = new Cercle("Cercle", 5, p411, 24, coul411, 10);
            #endregion

            #region Cercle_412
            Point p412 = new Point(50, 50);
            Couleur coul412 = new Couleur(0, 0, 0);
            Cercle c412 = new Cercle("Cercle", 6, p412, 21, coul412, 12);
            #endregion

            #region Cercle_413
            Point p413 = new Point(50, 50);
            Couleur coul413 = new Couleur(65, 183, 200);
            Cercle c413 = new Cercle("Cercle", 60, p413, 20, coul413, 15);
            #endregion

            #region Cercle_414
            Point p414 = new Point(50, 50);
            Couleur coul414 = new Couleur(253, 27, 20);
            Cercle c414 = new Cercle("Cercle", 7, p414, 16, coul414, 20);
            #endregion

            #region Cercle_415
            Point p415 = new Point(50, 50);
            Couleur coul415 = new Couleur(0, 0, 0);
            Cercle c415 = new Cercle("Cercle", 8, p415, 13, coul415, 22);
            #endregion

            #region Cercle_416
            Point p416 = new Point(50, 50);
            Couleur coul416 = new Couleur(253, 27, 20);
            Cercle c416 = new Cercle("Cercle", 80, p416, 12, coul416, 25);
            #endregion

            #region Cercle_417
            Point p417 = new Point(0, 0);
            Couleur coul417 = new Couleur(255, 245, 53);
            Cercle c417 = new Cercle("Cercle", 9, p417, 8, coul417, 30);
            #endregion

            #region Cercle_418
            Point p418 = new Point(0, 0);
            Couleur coul418 = new Couleur(0, 0, 0);
            Cercle c418 = new Cercle("Cercle", 101, p418, 5, coul417, 32);
            #endregion

            #region Translation_41
            #endregion

            #region Translation_42
            #endregion

            #region Translation_43
            #endregion

            #region Translation_44
            #endregion

            #region Translation_45
            #endregion

            #endregion

            Dessin d1 = new Dessin();
            d1.lireFichier("ExempleTout");
            d1.listElement.Sort();
            d1.ecrireFichier("ExempleTout");

            Dessin d2 = new Dessin();
            d2.lireFichier("exemple1");
            d2.listElement.Sort();
            d2.ecrireFichier("exemple1");

            Dessin d3 = new Dessin();
            d3.lireFichier("exemple2");
            d3.listElement.Sort();
            d3.ecrireFichier("exemple2");

            Dessin d4 = new Dessin();
            d4.lireFichier("exemple3");
            d4.listElement.Sort();
            d4.ecrireFichier("exemple3");

            Dessin d5 = new Dessin();
            d5.lireFichier("exemple4");
            d5.listElement.Sort();
            d5.ecrireFichier("exemple4");

            Dessin d6 = new Dessin();
            d6.lireFichier("MM");
            d6.listElement.Sort();
            d6.ecrireFichier("MM");

            Console.ReadKey();
        }
    }
}

