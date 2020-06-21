using Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class FilmDataAccessLayer
    {
        FilmContext db = new FilmContext();
        public IEnumerable<Film> GetAllFilms()
        {
            return db.Filmovi.ToList();

        }
        public Film GetFilm(int id)
        {
            var film = db.Filmovi.Include(f => f.Projekcije).Single(x => x.Id == id);
            return film;
        }
        public void AddFilm(Film film)
        {
            db.Filmovi.Add(film);
            db.SaveChanges();
        }
        public void UpdateFilm(Film film)
        {
            db.Entry(film).State = EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteFilm(int id)
        {
            var film = db.Filmovi.Find(id);
            db.Filmovi.Remove(film);
            db.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return db.Korisnici.ToList();

        }
        public User GetUser(int id)
        {
            var user = db.Korisnici.Find(id);
            return user;
        }
        public User GetUser(string email)
        {
            var user = db.Korisnici.Where(item => item.Email == email).ToList().FirstOrDefault();
            return user;
        }
        public void AddUser(User user)
        {
            db.Korisnici.Add(user);
            db.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteUser(int id)
        {
            var user = db.Korisnici.Find(id);
            db.Korisnici.Remove(user);
            db.SaveChanges();
        }

        // REZERVACIJE
        public IEnumerable<Rezervacija> GetAllR()
        {
            return db.Rezervacije.ToList();

        }
        public Rezervacija GetRezervacija(int id)
        {
            var rez = db.Rezervacije.Find(id);
            return rez;
        }
        public void AddRezervacija(Rezervacija rez)
        {
          
            db.Rezervacije.Add(rez);
            db.SaveChanges();
        }
        public void UpdateRezervacija(Rezervacija rez)
        {
            db.Entry(rez).State = EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteRezervacija(int id)
        {
            var rez = db.Rezervacije.Find(id);
            db.Rezervacije.Remove(rez);
            db.SaveChanges();
        }
        // PROJEKCIJE

        public IEnumerable<DatumProjekcije> GetAllP()
        {
            return db.Projekcije.ToList();

        }
        public DatumProjekcije GetDatumProjekcije(int id)
        {
            var pro = db.Projekcije.Find(id);
            return pro;
        }
        public void AddDatumProjekcije(DatumProjekcije pro)
        {
            db.Projekcije.Add(pro);
            db.SaveChanges();
        }
        public void UpdateDatumProjekcije(DatumProjekcije pro)
        {
            db.Entry(pro).State = EntityState.Modified;
            db.SaveChanges();

        }
        public void DeleteDatumProjekcije(int id)
        {
            var pro = db.Projekcije.Find(id);
            db.Projekcije.Remove(pro);
            db.SaveChanges();
        }
    }
}
