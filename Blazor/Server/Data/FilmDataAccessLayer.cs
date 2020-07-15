//using Blazor.Shared;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Blazor.Server.Data
//{
//    public class FilmDataAccessLayer
//    {
//        FilmContext db = new FilmContext();
//        // FILMOVI
//        public IEnumerable<Film> GetAllFilms()
//        {
//            return db.Filmovi.ToList();

//        }
//        public Film GetFilm(int id)
//        {
//            var film = db.Filmovi.Include(f => f.Projekcije).Single(x => x.Id == id);
//            return film;
//        }
//        public void AddFilm(Film film)
//        {
//            db.Filmovi.Add(film);
//            db.SaveChanges();
//        }
//        public void UpdateFilm(Film film)
//        {
//            db.Entry(film).State = EntityState.Modified;
//            db.SaveChanges();

//        }
//        public void DeleteFilm(int id)
//        {
//            var film = db.Filmovi.Find(id);
//            db.Filmovi.Remove(film);
//            db.SaveChanges();
//        }
//        //    KORISNICI
//        public IEnumerable<User> GetAll()
//        {
//            return db.Korisnici.ToList();

//        }
//        public User GetUser(int id)
//        {
//            var user = db.Korisnici.Find(id);
//            return user;
//        }
//        public User GetUser(string email)
//        {
//            var user = db.Korisnici.Where(item => item.Email == email).ToList().FirstOrDefault();
//            return user;
//        }
//        public void AddUser(User user)
//        {
//            db.Korisnici.Add(user);
//            db.SaveChanges();
//        }
//        public void UpdateUser(User user)
//        {
//            db.Entry(user).State = EntityState.Modified;
//            db.SaveChanges();

//        }
//        public void DeleteUser(int id)
//        {
//            var user = db.Korisnici.Find(id);
//            db.Korisnici.Remove(user);
//            db.SaveChanges();
//        }

//        // REZERVACIJE
//        public IEnumerable<Rezervacija> GetAllR()
//        {
//            return db.Rezervacije.Include(item => item.User).Include(item => item.Film).Include(item=> item.Datum).ToList();

//        }
//        public Rezervacija GetRezervacija(int id)
//        {
//            var rez = db.Rezervacije.Find(id);
//            return rez;
//        }

//        public List<Rezervacija> GetRezervacijaZaFilm(int filmId)
//        {
//            var rezervacije = db.Rezervacije.Where(item => item.Film.Id == filmId).Include(item => item.Datum).Include(item => item.Sediste).ToList();
//            return rezervacije;
//        }

//        public void AddRezervacija(Rezervacija rez)
//        {
//            db.Entry(rez).State = EntityState.Modified;
//            db.Rezervacije.Add(rez);
//            db.SaveChanges();
//        }
//        public void UpdateRezervacija(Rezervacija rez)
//        {
//            db.Entry(rez).State = EntityState.Modified;
//            db.SaveChanges();

//        }
//        public void DeleteRezervacija(Guid id)
//        {
//            var rez = db.Rezervacije.Find(id);
//            db.Rezervacije.Remove(rez);
//            db.SaveChanges();
//        }
//        // PROJEKCIJE

//        public IEnumerable<DatumProjekcije> GetAllP()
//        {
//            return db.Projekcije.ToList();

//        }
//        public DatumProjekcije GetDatumProjekcije(int id)
//        {
//            var pro = db.Projekcije.Find(id);
//            return pro;
//        }
//        public void AddDatumProjekcije(DatumProjekcije pro)
//        {
//            db.Projekcije.Add(pro);
//            db.SaveChanges();
//        }
//        public void UpdateDatumProjekcije(DatumProjekcije pro)
//        {
//            db.Entry(pro).State = EntityState.Modified;
//            db.SaveChanges();

//        }
//        public void DeleteDatumProjekcije(int id)
//        {
//            var pro = db.Projekcije.Find(id);
//            db.Projekcije.Remove(pro);
//            db.SaveChanges();
//        }

//        // SEDISTA
//        public void AddSedista(List<Sediste> sedista)
//        {
//            foreach(var sediste in sedista)
//            {
//                db.Entry(sediste).State = EntityState.Modified;
//                db.Sediste.Add(sediste);
//                db.SaveChanges();
//            }
//        }
//    }
//}
