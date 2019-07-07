using Dominio;
using Servicios.DataBase;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Servicios
{
    class ServicioItem : IServicioItem
    {
        public IEnumerable<Item> ObtenerItems()
        {
            using (var db = new AppDataBaseContext())
            {
                return db
                    .Items
                    .Include(item => item.Pedidos)
                    .ToList();
            }

        }
        /*public Categoria ObtenerCategoria(int Id)
        {
            using (var db = new AppDataBaseContext())
            {
                return db
                    .Categorias
                    .Where(categoria => categoria.Item.Id == Id);
                    
            }
        }*/
        //TODO

        public void AddItem(string nombre, float precio, Categoria categoria)
        {
            using (var db = new AppDataBaseContext())
            {
                db.Items
                    .AddOrUpdate(new Item()
                    {
                        /*Dni = dni,
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaNacimiento*/
                        Nombre = nombre,
                        Precio = precio,
                        Categoria = categoria
                    });

                db.SaveChanges();
            }
        }

    }
}