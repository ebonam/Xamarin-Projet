
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using XamarinFinal;
using XamarinFinal.BDD;
using Android.Util;
public  class ConnSql
{


    private static readonly ConnSql instance = new ConnSql();
    SQLiteConnection db;

    public static ConnSql Instance
    {
        get
        {
            return instance;
        }
    }

    protected ConnSql()
    {
        string dbPath = Path.Combine(
          Environment.GetFolderPath(Environment.SpecialFolder.Personal),
          "ormdemo.db3");
        db = new SQLiteConnection(dbPath);
        db.CreateTable<Utilisateur>();
        db.CreateTable<DAUVP>();
    //    db.CreateTable<Marque>();
        db.CreateTable<Trajet>();
        db.CreateTable<Addresse>();
        db.CreateTable<SansFrais>();
        db.CreateTable<AvecFrais>();
        //tout les createTable

    }
    public List<Utilisateur> CountUtilisateur()
    {

        var i = db.Query<Utilisateur>("select * from Utilisateur ;", 4);
        return i;
    }

    public List<Utilisateur> getUtilisateur(int id)
    {

        var i = db.Query<Utilisateur>("select * from Utilisateur where _id = ? ;", id);
        return i;
    }
    public List<DAUVP> getDAUVP(int id)
    {

        var i = db.Query<DAUVP>("select * from DAUVP where _id = ? ;", id);
        return i;
    }

    public List<DAUVP> getDAUVP(Utilisateur s)
    {

        var i = db.Query<DAUVP>("select * from DAUVP where idUser = ? ;", s._id);
        return i;
    }



    public AvecFrais GetAF(int id)
    {

     return   db.Get<AvecFrais>(id);
    }

    public SansFrais GetSF(int id)
    {

return        db.Get<SansFrais>(id);
    }

    public SansFrais Test(int id)
    {
        var ssss = db.Table<AvecFrais>();
        foreach (AvecFrais s in ssss)
            Log.Info("help", "Test1" + s._id);
        var sss=  db.Table<SansFrais>();
        foreach(SansFrais s in sss)
            Log.Info("help","Test2"+ s._id);

        return null; //      this.db.Get<SansFrais>(id);
    }
    public List<SansFrais> getSansFrais(int id)
    {

        var i = db.Query<SansFrais>("select * from SansFrais where _id = ? ;", id);
        return i;
    }

    public List<SansFrais> getSansFrais(Utilisateur s)
    {

        var i = db.Query<SansFrais>("select * from SansFrais where idUser = ? ;", s._id);
        return i;
    }


    public List<Trajet> getTrajetByFiche(int  id) {

        var i = db.Query<Trajet>("Select * from Trajet where _id = ?", id);
        return i;


    }

    public List<AvecFrais> getAvecFrais(int id)
    {

        var i = db.Query<AvecFrais>("select * from AvecFrais where _id = ? ;", id);
        return i;
    }

    public List<AvecFrais> getAvecFrais(Utilisateur s)
    {

        var i = db.Query<AvecFrais>("select * from AvecFrais where idUser = ? ;", s._id);
        return i;
    }





    public List<FileInterface> getAllFile(Utilisateur s)
    {
        List<FileInterface> i = new List<FileInterface>();
       i.AddRange(db.Query<DAUVP>("select * from DAUVP;"));
      i.AddRange(db.Query<SansFrais>("select * from SansFrais ;"));
       i.AddRange(db.Query<AvecFrais>("select * from AvecFrais;"));

        /*        i.AddRange(db.Query<DAUVP>("select * from DAUVP where idUser = ? ;", s._id));
                i.AddRange(db.Query<SansFrais>("select * from SansFrais where idUser= ? ;", s._id));
                i.AddRange(db.Query<AvecFrais>("select * from AvecFrais where idUser = ? ;", s._id));
                */
        int d = db.Table<SansFrais>().Count();
        Log.Info("help Open",""+d );
        //   Debug.WriteLine(db.Table<SansFrais>().Count);
        return i;
    }



  /*  public List<Marque> getMarque()
    {

        var i = db.Query<Marque>("select * from Marque;", null);
        return i;
    }

    public List<Marque> getMarque(int id)
    {

        var i = db.Query<Marque>("select * from Marque where _id=?;", id);
        return i;
    }*/
    public List<Addresse> getAddresse(Addresse s)
    {

        var i = db.Query<Addresse>("select * from Marque where _id= ?;", s._id);
        return i;
    }
    public List<Addresse> getAddresse(int s)
    {

        var i = db.Query<Addresse>("select * from Marque where _id= ?;", s);
        return i;
    }


    public void addDAUVP(DAUVP s)
    {
        db.Insert(s);
    }
    public void updateDAUVP(DAUVP s)
    {
        db.Update(s);
    }
    public void deleteDAUVP(DAUVP s)
    {
        db.Delete(s);
    }



    public void addSansFrais(SansFrais s)
    {
        db.Insert(s);
    }

    public void addAvecFrais(AvecFrais s)
    {
        db.Insert(s);
    }

    public void updateSansFrais(SansFrais s)
    {
        db.Update(s);
    }

    internal DAUVP getD(int id)
    {
        return db.Get<DAUVP>(id);
    }

    public void updateAvecFrais(AvecFrais s)
    {
        db.Update(s);
    }

    public void deleteSansFrais(SansFrais s)
    {
        db.Delete(s);
    }

    public void deleteAvecFrais(AvecFrais s)
    {
        db.Delete(s);
    }


    public void addTrajet(Trajet s)
    {
        db.Insert(s);
    }


    public void updateTrajet(Trajet s)
    {
        db.Update(s);
    }
    public void deleteTrajet(Trajet s)
    {
        db.Delete(s);
    }
    public void addUtilisateur(Utilisateur s)
    {
        db.Insert(s);
    }

    public void updateUtilisateur(Utilisateur s)
    {
        db.Update(s);

    }
    public void deleteUtilisateur(Utilisateur s)
    {
        db.Delete(s);

    }
    public void addAddresse(Addresse s)
    {
        db.Insert(s);
    }
    public void updateAddresse(Addresse s)
    {
        db.Update(s);
    }
    public void deleteAddresse(Addresse s)
    {
        db.Delete(s);
    }

}

