using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrjProductosMVC.Models;

namespace PrjProductosMVC.DAO
{
    public class ProductoDao
    {
        public static List<Producto> listaProd = new List<Producto>();
        public ProductoDao()
        {
            listaProd = new List<Producto>();
        }

        /*public List<Producto> ListaProductos()
        {
            listaProd.Add(new Producto()
            {
                codprod = 1001, nomprod="Televisor", precio=1980, fechareg=new DateTime(2019,10, 25), suspendido

            }
            
        }*/

        public List<Producto> ListaProductos()
        {
            listaProd.Add(new Producto()
            {
                codprod = 1001,
                nomprod = "Televisor",
                precio = 1980,
                fechareg = new DateTime(2019, 10, 25),
                suspendido = false
            });
            //
            return listaProd;
        }

        public string AgregarProducto(Producto obj)
        {
            listaProd.Add(obj);
            return "Nuevo Producto Agregado correctamente";
        }
    }
}