using ControlVirtual.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlVirtual.Logica.Gestion;

namespace ControlVirtual.Logica
{
    public class TurnoLogica
    {
        private static TurnoLogica _Instancia = null;

        public TurnoLogica()
        {

        }

        public static TurnoLogica Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    _Instancia = new TurnoLogica();
                }
                return _Instancia;
            }
        }

        public bool Crear(Turnos obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "INSERT INTO Turnos(TurnoId,EsApertura) VALUES (@TurnoId,@EsApertura)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@TurnoId", obj.TurnoId));
                cmd.Parameters.Add(new SQLiteParameter("@EsApertura", obj.EsApertura));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<Turnos> Listar(int TurnoIdApertura)
        {
            List<Turnos> oLista = new List<Turnos>();

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Turnos WHERE TurnoId >= @TurnoId";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@TurnoId", TurnoIdApertura));
                cmd.CommandType = System.Data.CommandType.Text;


                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    int TurnoId_;
                    while (dr.Read())
                    {
                        TurnoId_ = int.Parse(dr["TurnoId"].ToString());
                        var conversion = Conversiones.ObtenerPeriodo(TurnoId_);

                        oLista.Add(new Turnos()
                        {
                            TurnoId = TurnoId_,
                            EsApertura = int.Parse(dr["EsApertura"].ToString()),
                            Año = conversion.Año,
                            Desde = conversion.DiaInicial,
                            Hasta = conversion.DiaFinal,
                            Turno = conversion.Turno,
                        });
                    }
                }
            }
            return oLista;
        }
        public List<Turnos> ListarApertura()
        {
            List<Turnos> oLista = new List<Turnos>();

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Turnos WHERE EsApertura = 1";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    int TurnoId_;
                    while (dr.Read())
                    {
                        TurnoId_ = int.Parse(dr["TurnoId"].ToString());
                        var conversion = Conversiones.ObtenerPeriodo(TurnoId_);

                        oLista.Add(new Turnos()
                        {
                            TurnoId = TurnoId_,
                            EsApertura = int.Parse(dr["EsApertura"].ToString()),
                            Año = conversion.Año,
                            Desde = conversion.DiaInicial,
                            Hasta = conversion.DiaFinal,
                            Turno = conversion.Turno,
                        });
                    }
                }
            }
            return oLista;
        }

        public List<Turnos> ListarAperturaAnterior(int TurnoIdInicial, int TurnoIdFinal)
        {
            List<Turnos> oLista = new List<Turnos>();

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Turnos WHERE TurnoId >= @MinTurnoId AND TurnoId < @MaxTurnoId";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.AddWithValue("@MinTurnoId", TurnoIdInicial);
                cmd.Parameters.AddWithValue("@MaxTurnoId", TurnoIdFinal);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    int TurnoId_;
                    while (dr.Read())
                    {
                        TurnoId_ = int.Parse(dr["TurnoId"].ToString());
                        var conversion = Conversiones.ObtenerPeriodo(TurnoId_);

                        oLista.Add(new Turnos()
                        {
                            TurnoId = TurnoId_,
                            EsApertura = int.Parse(dr["EsApertura"].ToString()),
                            Año = conversion.Año,
                            Desde = conversion.DiaInicial,
                            Hasta = conversion.DiaFinal,
                            Turno = conversion.Turno,
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
                string query = "SELECT MAX(TurnoId) AS UltimoTurnoId FROM Turnos";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read()) // Solo hay una fila (aunque la tabla esté vacía)
                    {
                        // Verificar si el valor es NULL
                        if (!dr.IsDBNull(dr.GetOrdinal("UltimoTurnoId")))
                        {
                            id = int.Parse(dr["UltimoTurnoId"].ToString());
                        }
                    }
                }
            }
            return id;
        }

        public int UltimoIdApertura()
        {
            int id = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "SELECT MAX(TurnoId) AS UltimoTurnoId FROM Turnos WHERE EsApertura = 1";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read()) // Solo hay una fila (aunque la tabla esté vacía)
                    {
                        // Verificar si el valor es NULL
                        if (!dr.IsDBNull(dr.GetOrdinal("UltimoTurnoId")))
                        {
                            id = int.Parse(dr["UltimoTurnoId"].ToString());
                        }
                    }
                }
            }
            return id;
        }


        public bool Eliminar(Turnos obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "DELETE FROM Turnos WHERE TurnoId=@TurnoId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@TurnoId", obj.TurnoId);
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }
            return respuesta;
        }
    }
}
