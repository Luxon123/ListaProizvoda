using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Items.Models.Api
{
    public class ProizvodiController : ApiController
    {
        private ItemsContext _context;

        public ProizvodiController()
        {
            _context = new ItemsContext();
        }

        //GET /api/proizvodi
        public IEnumerable<Proizvod> GetProizvod()
        {
            return _context.Items.ToList();
        }

        //GET /api/proizvodi/1
        public IHttpActionResult GetProizvod(int id)
        {
            var proizvod = _context.Items.SingleOrDefault(i => i.Id == id);

            if (proizvod == null)
                return NotFound();

            return Ok(proizvod);
        }

        //POST /api/proizvodi
        [HttpPost]
        public IHttpActionResult CreateProizvod(Proizvod proizvod)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Items.Add(proizvod);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + proizvod.Id), proizvod);
        }

        //PUT /api/proizvodi/1
        [HttpPut]
        public void UpdateProizvod(int id, Proizvod proizvod)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var proizvodInDb =_context.Items.SingleOrDefault(i => i.Id == id);

            if (proizvodInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            proizvodInDb.Naziv = proizvod.Naziv;
            proizvodInDb.Opis = proizvod.Opis;
            proizvodInDb.Kategorija = proizvod.Kategorija;
            proizvodInDb.Proizvodjac = proizvod.Proizvodjac;
            proizvodInDb.Dobavljac = proizvod.Dobavljac;
            proizvodInDb.Cena = proizvod.Cena;

            _context.SaveChanges();
        }

        //DELETE /api/proizvodi/1
        [HttpDelete]
        public void DeleteProizvod(int id)
        {
            var proizvodInDb = _context.Items.SingleOrDefault(i => i.Id == id);

            if (proizvodInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Items.Remove(proizvodInDb);
            _context.SaveChanges();
        }


    }
}
