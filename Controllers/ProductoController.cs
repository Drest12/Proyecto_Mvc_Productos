using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjProductosMVC.DAO; // importar al DAO
using PrjProductosMVC.Models; // importar al Modelo

namespace PrjProductosMVC.Controllers
{
    public class ProductoController : Controller
    {
        // definir la variable del DAO
        ProductoDao dao = new ProductoDao();

        // GET: Producto
        public ActionResult IndexProducto() // Listado, pantalla de inicio
        {
            //traer los datos del modelo

            var hola = dao.ListaProductos();

            //enviarlo a la vista
            return View(hola);
        }

        // GET: Producto/Details/5
        public ActionResult DetailsProducto(int id) // Detalle de un elemento
        {
            //traer los datos del modelo

            var listado = dao.ListaProductos();

            // buscar el producto a mostrar que coincida con el valor de "id"
            var obj = listado.Find(prod => prod.codprod == id);

            // el producto encontrado será enviado para mostrarlo en la vista
            //enviarlo a la vista

            return View(obj);
        }

        // GET: Producto/Create
        public ActionResult CreateProducto(Producto nuevoProd) // Grabar un elemento
        {
            // definimos un nuevo objeto
           // Producto obj = new Producto();
           //grabando el nuevo producto
           string  mensaje= dao.AgregarProducto(nuevoProd);
            // enviar el objeto producto a la vista
            ViewBag.Mensaje = mensaje;
            return View(nuevoProd);
        }

        // POST: Producto/Create
        /*[HttpPost]
        public ActionResult CreateProducto(FormCollection collection)
        {
            Producto nuevo = new Producto();
            nuevo.codprod = int.Parse(collection.Get("codprod"));
            nuevo.nomprod = collection.Get("nomprod");

            //string mensaje = dao.AgregarProducto(nuevo);

           return View(nuevo);}*/ 
        

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            // buscar el producto a eliminar

            // el producto encontrado será enviado para mostrarlo en la vista
            return View();
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
