﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2014102360_ENT;
using _2014102360_PER;

namespace _2014102360_API.Controllers
{
    public class VolantesController : ApiController
    {
        private EnsambladoraDbContext db = new EnsambladoraDbContext();

        // GET: api/Volantes
        public IQueryable<Volante> GetVolantes()
        {
            return db.Volantes;
        }

        // GET: api/Volantes/5
        [ResponseType(typeof(Volante))]
        public IHttpActionResult GetVolante(int id)
        {
            Volante volante = db.Volantes.Find(id);
            if (volante == null)
            {
                return NotFound();
            }

            return Ok(volante);
        }

        // PUT: api/Volantes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVolante(int id, Volante volante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != volante.VolanteId)
            {
                return BadRequest();
            }

            db.Entry(volante).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolanteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Volantes
        [ResponseType(typeof(Volante))]
        public IHttpActionResult PostVolante(Volante volante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Volantes.Add(volante);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = volante.VolanteId }, volante);
        }

        // DELETE: api/Volantes/5
        [ResponseType(typeof(Volante))]
        public IHttpActionResult DeleteVolante(int id)
        {
            Volante volante = db.Volantes.Find(id);
            if (volante == null)
            {
                return NotFound();
            }

            db.Volantes.Remove(volante);
            db.SaveChanges();

            return Ok(volante);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VolanteExists(int id)
        {
            return db.Volantes.Count(e => e.VolanteId == id) > 0;
        }
    }
}