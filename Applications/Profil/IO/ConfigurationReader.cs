using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Emash.GeoPat.Layers.Data;
using Microsoft.Practices.ServiceLocation;
using System.Data.Entity;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Applications.Profil.IO
{
    public class ConfigurationReader
    {
        public ConfigurationReader(String fileName)
        {
            List<List<String>> datas = new List<List<string>>();
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream, System.Text.Encoding.GetEncoding(1252)))
                {
                    String content = reader.ReadToEnd();
                    String[] items = content.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);                   
                    foreach (String item in items)
                    {
                        string data = item;
                        if (item.StartsWith("\""))
                        {data = data.Substring(1); }

                        if (item.EndsWith("\""))
                        { data = data.Substring(0,data.Length -1); }
                        datas.Add(data.Split(";".ToCharArray(), StringSplitOptions.None).ToList ());
                    }
                }
            }
            DataContextPrf dataContextPrf = ServiceLocator.Current.GetInstance<DataContextPrf>();


            DbSet<PrfBmUser> setUsers = dataContextPrf.Set<PrfBmUser>();
            foreach (PrfBmUser user in setUsers)
            { setUsers.Remove(user); }
            dataContextPrf.SaveChanges();
            List<List<String>> userItems = (from d in datas where d[0].Equals("USER") select d).ToList();
            foreach (List<String> userItem in userItems)
            {
                PrfBmUser user = new PrfBmUser();
                user.Login = userItem[1];
                user.Nom = userItem[2];
                user.Prenom = userItem[3];
                user.FamDecInf = userItem[4];
                user.CdDecInf = userItem[5];
                if (userItems.Count > 5)
                {user.Passwords = userItem[6];}
                setUsers.Add(user);
            }
            dataContextPrf.SaveChanges();
            List<PrfBmUser> users = setUsers.AsQueryable<PrfBmUser>().ToList();




            DbSet<PrfBmSchema> setSchemas = dataContextPrf.Set<PrfBmSchema>();
            foreach (PrfBmSchema schema in setSchemas)
            { setSchemas.Remove(schema); }
            dataContextPrf.SaveChanges();
            List<List<String> >schemaItems = (from d in datas where d[0].Equals("SCHEMA") select d).ToList();
            foreach (List<String> schemaItem in schemaItems)
            {
                PrfBmSchema schema = new PrfBmSchema();
                schema.Schema = schemaItem[1];
                schema.Libelle = schemaItem[2];
                setSchemas.Add(schema);
            }
            dataContextPrf.SaveChanges();
            List<PrfBmSchema> schemas = setSchemas.AsQueryable<PrfBmSchema>().ToList ();


            DbSet<PrfBmTable> setTables = dataContextPrf.Set<PrfBmTable>();
            foreach (PrfBmTable table in setTables)
            { setTables.Remove(table); }
            dataContextPrf.SaveChanges();
            List<List<String>> tableItems = (from d in datas where d[0].Equals("TABLE") select d).ToList();
            foreach (List<String> tableItem in tableItems)
            {
                PrfBmTable table = new PrfBmTable();               
                foreach (PrfBmSchema s in schemas)
                {
                    if (s.Schema.Equals(tableItem[1]))
                    {table.PrfBmSchema = s;}
                }
                table.Nom = tableItem[2];
                table.Libelle = tableItem[3];
                setTables.Add(table);
            }
            dataContextPrf.SaveChanges();
            List<PrfBmTable> tables = setTables.AsQueryable<PrfBmTable>().ToList ();


            DbSet<PrfBmProfil> setProfils = dataContextPrf.Set<PrfBmProfil>();
            foreach (PrfBmProfil profil in setProfils)
            { setProfils.Remove(profil); }
            dataContextPrf.SaveChanges();
            List<List<String>> profilItems = (from d in datas where d[0].Equals("PROFIL") select d).ToList();
            foreach (List<String> profilItem in profilItems)
            {
                PrfBmProfil profil = new PrfBmProfil();
                
                foreach (PrfBmSchema s in schemas)
                {
                    if (s.Schema.Equals(profilItem[1]))
                    { profil.PrfBmSchema = s; }
                }
                profil.Profil = profilItem[2];
                profil.Libelle = profilItem[3];
                setProfils.Add(profil);
            }
            dataContextPrf.SaveChanges();
            List<PrfBmProfil> profils = setProfils.AsQueryable<PrfBmProfil>().ToList ();

            //PROFIL_TABLE

            DbSet<PrfBmProfilTable> setProfilTables = dataContextPrf.Set<PrfBmProfilTable>();
            foreach (PrfBmProfilTable profilTable in setProfilTables)
            { setProfilTables.Remove(profilTable); }
            dataContextPrf.SaveChanges();
            List<List<String>> profilTableItems = (from d in datas where d[0].Equals("PROFIL_TABLE") select d).ToList();
            foreach (List<String> profilTableItem in profilTableItems)
            {
                PrfBmProfilTable profilTable = new PrfBmProfilTable();

                foreach (PrfBmProfil p in profils)
                {
                    if (p.Profil.Equals(profilTableItem[1]))
                    { profilTable.PrfBmProfil  = p; }
                }

                foreach (PrfBmTable t in tables)
                {
                    if (t.Nom.Equals(profilTableItem[2]))
                    { profilTable.PrfBmTable = t; }
                }
                profilTable.Ecrire = profilTableItem[3].Replace("-", "").Equals("1");
                profilTable.Importer = profilTableItem[1].Replace("-", "").Equals("1");
                profilTable.Afficher = true;
                setProfilTables.Add(profilTable);
              
            }
            dataContextPrf.SaveChanges();



            DbSet<PrfBmUserProfil> setUserProfil = dataContextPrf.Set<PrfBmUserProfil>();
            foreach (PrfBmUserProfil userProfil in setUserProfil)
            { setUserProfil.Remove(userProfil); }
            dataContextPrf.SaveChanges();
            List<List<String>> userProfilItems = (from d in datas where d[0].Equals("USER_PROFIL") select d).ToList();
            foreach (List<String> userProfilItem in userProfilItems)
            {
                PrfBmUserProfil userProfil = new PrfBmUserProfil();

                foreach (PrfBmProfil p in profils)
                {
                    if (p.Profil.Equals(userProfilItem[2]))
                    { userProfil.PrfBmProfil = p; }
                }

                foreach (PrfBmUser u in users)
                {
                    if (u.Login.Equals(userProfilItem[1]))
                    { userProfil.PrfBmUser  = u; }
                }

                setUserProfil.Add(userProfil);

            }
            dataContextPrf.SaveChanges();

        }
    }
}
