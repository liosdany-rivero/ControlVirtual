using ControlVirtual.Modelos;
using System.Data.SQLite;

namespace ControlVirtual.Logica
{
    public class ProductoLogica
    {
        private static ProductoLogica _Instancia = null;

        public ProductoLogica()
        {

        }

        public static ProductoLogica Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    _Instancia = new ProductoLogica();
                }
                return _Instancia;
            }
        }

        public bool Crear(Productos obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "INSERT INTO Productos(ProductoId,Producto,Costo,Venta) VALUES (@ProductoId,@Producto,@Costo,@Venta)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ProductoId", obj.ProductoId));
                cmd.Parameters.Add(new SQLiteParameter("@Producto", obj.Producto));
                cmd.Parameters.Add(new SQLiteParameter("@Costo", obj.Costo));
                cmd.Parameters.Add(new SQLiteParameter("@Venta", obj.Venta));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool Editar(Productos obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "UPDATE Productos SET Producto=@Producto, Costo=@Costo, Venta=@Venta WHERE ProductoId=@ProductoId";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ProductoId", obj.ProductoId));
                cmd.Parameters.Add(new SQLiteParameter("@Producto", obj.Producto));
                cmd.Parameters.Add(new SQLiteParameter("@Costo", obj.Costo));
                cmd.Parameters.Add(new SQLiteParameter("@Venta", obj.Venta));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<Productos> Listar()
        {
            List<Productos> oLista = new List<Productos>();

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Productos";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Productos()
                        {
                            ProductoId = int.Parse(dr["ProductoId"].ToString()),
                            Producto = (dr["Producto"].ToString()),
                            Costo = Double.Parse(dr["Costo"].ToString()),
                            Venta = Double.Parse(dr["Venta"].ToString()),
                        });
                    }
                }
            }
            return oLista;
        }

        public int UltimoId()
        {
            int id = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "SELECT MAX(ProductoId) AS UltimoProductoId FROM Productos";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read()) // Solo hay una fila (aunque la tabla esté vacía)
                    {
                        // Verificar si el valor es NULL
                        if (!dr.IsDBNull(dr.GetOrdinal("UltimoProductoId")))
                        {
                            id = int.Parse(dr["UltimoProductoId"].ToString());
                        }
                        else
                        {
                            id = VariablesGlobales.CodigoMinimo;
                        }
                    }
                }
            }
            return id;
        }



        public List<Productos> Buscar(string pProductoId = null, string pProducto = null, string pCosto = null, string pventa = null)
        {
            List<Productos> oLista = new List<Productos>();

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();

                // Consulta base
                string query = "SELECT * FROM Productos";
                List<string> condiciones = new List<string>();
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                // Filtro por ProductoId (si se proporciona)
                if (!string.IsNullOrEmpty(pProductoId))
                {
                    condiciones.Add("ProductoId = @ProductoId");
                    cmd.Parameters.AddWithValue("@ProductoId", pProductoId);
                }

                // Filtro por Producto (búsqueda parcial)
                if (!string.IsNullOrEmpty(pProducto))
                {
                    condiciones.Add("Producto LIKE @Producto");
                    cmd.Parameters.AddWithValue("@Producto", "%" + pProducto + "%");
                }

                // Filtro por Costo (si se proporciona)
                if (!string.IsNullOrEmpty(pCosto))
                {
                    condiciones.Add("Costo = @Costo");
                    cmd.Parameters.AddWithValue("@Costo", pCosto);
                }

                // Filtro por Venta (si se proporciona)
                if (!string.IsNullOrEmpty(pventa))
                {
                    condiciones.Add("Venta = @Venta");
                    cmd.Parameters.AddWithValue("@Venta", pventa);
                }

                // Combina las condiciones con AND
                if (condiciones.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", condiciones);
                }

                cmd.CommandText = query;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Productos()
                        {
                            ProductoId = Convert.ToInt32(dr["ProductoId"]),
                            Producto = dr["Producto"].ToString(),
                            Costo = Convert.ToDouble(dr["Costo"]),
                            Venta = Convert.ToDouble(dr["Venta"])
                        });
                    }
                }
            }

            return oLista;
        }

        public bool Eliminar(Productos obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "DELETE FROM Productos WHERE ProductoId=@ProductoId";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ProductoId", obj.ProductoId));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

    }
}
