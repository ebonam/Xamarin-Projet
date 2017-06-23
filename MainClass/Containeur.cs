
using System;
using System.Collections.Generic;
using XamarinFinal.BDD;
using XamarinFinal.Vue;

namespace XamarinFinal
{
    public class Containeur
    {
        private static readonly Containeur instance = new Containeur();
        public static Containeur Instance
        {
            get
            {
                return instance;
            }
        }
        public Menu1 m1;
        public DAUVP dauvp;
        public AvecFrais AvecFrais;
        public SansFrais SansFrais;
        public Utilisateur utilisateur;

        internal int nbUser()
        {
            return sql.CountUtilisateur().Count;
        }

        public List<Trajet> listTrajet;


        /// <summary>
        /// Update d'un utilisateur
        /// </summary>
        public void SaveUser()
        {
            this.sql.updateUtilisateur(this.utilisateur);                   
            PageType();
        }

        /// <summary>
        /// Creer un utilisateur
        /// </summary>
        public void CreateUser()
        {
            this.sql.addUtilisateur(this.utilisateur);
        }


        /// <summary>
        /// Change de menu
        /// </summary>
        public void PageType()
        {
            if (Type == 0)
            {
                Menu1.Instance.Change(typeof(DAUVP_Vue),"Fiche DAUVP");
            }
            else if (Type == 1)
            {
                Menu1.Instance.Change(typeof(AvecFrais1), "Avec Frais");
            }
            else {
                Menu1.Instance.Change(typeof(SansFrais1), "Sans Frais");
            }
        }

        internal void delUser(Utilisateur utilisateur)
        {
            sql.deleteUtilisateur(utilisateur);
        }

        public void SetUser(Utilisateur e)
        {
            this.utilisateur = e;
            App.Instance.ToFile();

        }
        public int Type;
        public bool isNew;
        public ConnSql sql;

        /// <summary>
        /// Sauvegarde une fiche
        /// </summary>
        public void Save()
        {
                if (Type == 0)
                {
                    sql.updateDAUVP(dauvp);
                }
                else if (Type == 1)
                {
                    sql.updateAvecFrais(this.AvecFrais);
                }
                else
                {
                    sql.updateSansFrais(this.SansFrais);
                }
            }
        
    public    List<Trajet> getTrajet(int i)
        {
         return   this.sql.getTrajetByFiche(i);


        }



        internal void New(int type, string text)
        {
            Type = type;
            isNew = true;
            dauvp = null;
            AvecFrais = null;
            SansFrais = null;
            if (type == 0)
            {
                dauvp = new DAUVP();

                dauvp.name = text;
                sql.addDAUVP(dauvp);
            }
            else if (type == 1)
            {
                AvecFrais = new AvecFrais();

                AvecFrais.name = text;
                sql.addAvecFrais(this.AvecFrais);

            }
            else
            {
                SansFrais = new SansFrais();

                SansFrais.name = text;
                sql.addSansFrais(this.SansFrais);
            }
            this.PageType();

        }

        /// <summary>
        /// Ajout dans la bdd
        /// </summary>
        internal void addUser()
        {
            sql.addUtilisateur(this.utilisateur);
            App.Instance.ToFile();
        }
        /// <summary>
        /// Nouvelle Fiche
        /// </summary>
        /// <param name="type"></param>
        public void New(int type) {
            Type = type;
            isNew = true;
            dauvp = null;
            AvecFrais = null;
            SansFrais = null;
            if (type == 0)
            {
                dauvp = new DAUVP();
            }
            else if (type == 1) {
                AvecFrais = new AvecFrais(); 
            }
           else{
                SansFrais = new SansFrais();
            }
            this.PageType();
        }

        /// <summary>
        /// Supprime une fiche
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        internal void Delete(int type, int id)
        {
            switch (type) {
                case 0:
                    sql.deleteDAUVP(sql.getDAUVP(id)[0]);
                    break;
                case 1:
                    sql.deleteAvecFrais(sql.GetAF(id));
                    break;
                case 2:
                    sql.deleteSansFrais(sql.GetSF(id));
                    break;
                default:      
                    break;
            }
        }

        /// <summary>
        /// Ouvrir une fiche
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        public void Open(int type, int  id)
        {
            isNew = false;
            Type = type;
            dauvp = null;
            AvecFrais = null;
            SansFrais = null;
            if (type == 0)
            {
                dauvp = this.sql.getD(id);
            }
            else if (type == 1)
            {
                AvecFrais =this.sql.GetAF(id);

            }
            else { SansFrais = this.sql.GetSF(id); }
            //     mm.rebind();

            this.PageType();
        }


        void ModifTrajet(Trajet tr, int id)
        {
            listTrajet.Find(x => x._id == id).moveTo(tr);

        }

        Containeur()
        {   this.sql = ConnSql.Instance;
        
        }
    }
}