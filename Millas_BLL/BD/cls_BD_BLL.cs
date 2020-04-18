using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Millas_DAL.BD;
using System.Configuration;

namespace Millas_BLL.BD
{
    public class cls_BD_BLL
    {
        #region Variables globales

        SqlDbType DB_TYPE = SqlDbType.VarChar;

        #endregion

        public void CrearCNX(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                //convertir el string en un objeto de el motor de BD entienda para ejecutar 
                Obj_BD_DAL.Obj_SQL_CNX = new SqlConnection(ConfigurationManager.ConnectionStrings["CNX_WIN_AUT"].ToString());

                Obj_BD_DAL.sMsError = string.Empty;
            }
            catch (Exception ex)
            {

                Obj_BD_DAL.sMsError = ex.Message.ToString();
            }
        }

        // List and Fill
        public void Excute_DataAdapter(ref cls_BD_DAL Obj_BD_DAL)
        {
            #region Try
            try
            {

                // Firts, Create the connection
                CrearCNX(ref Obj_BD_DAL);

                // Now, open connection
                if (Obj_BD_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_BD_DAL.Obj_SQL_CNX.State == ConnectionState.Closed)
                    {
                        Obj_BD_DAL.Obj_SQL_CNX.Open();
                    }

                    // Create the object however it have not been executed yet
                    Obj_BD_DAL.Obj_SQL_DAP = new SqlDataAdapter(Obj_BD_DAL.sParametro, Obj_BD_DAL.Obj_SQL_CNX);

                    // I insert security to data adapter, to avoid SQL ejection 
                    Obj_BD_DAL.Obj_SQL_DAP.SelectCommand.CommandType = CommandType.StoredProcedure;

                    if (Obj_BD_DAL.Dt_Parametros != null)
                    {
                        if (Obj_BD_DAL.Dt_Parametros.Rows.Count >= 1)
                        {
                            foreach (DataRow dr in Obj_BD_DAL.Dt_Parametros.Rows)
                            {
                                switch (dr[1].ToString())
                                {
                                    case "1":
                                        DB_TYPE = SqlDbType.NVarChar;
                                        break;
                                    case "2":
                                        DB_TYPE = SqlDbType.Int;
                                        break;
                                    case "3":
                                        DB_TYPE = SqlDbType.Char;
                                        break;
                                    case "4":
                                        DB_TYPE = SqlDbType.Decimal;
                                        break;
                                    default:
                                        DB_TYPE = SqlDbType.VarChar;
                                        break;
                                }
                                Obj_BD_DAL.Obj_SQL_DAP.SelectCommand.Parameters.Add(dr[0].ToString(), DB_TYPE).Value = dr[2].ToString();
                            }
                        }
                        //Obj_BD_DAL.DT_Parametros = null;
                    }

                    // to execute data adapter
                    Obj_BD_DAL.Ds = new DataSet();
                    Obj_BD_DAL.Obj_SQL_DAP.Fill(Obj_BD_DAL.Ds, Obj_BD_DAL.sNombreTabla);

                    Obj_BD_DAL.sMsError = string.Empty;
                }
                else
                {
                    Obj_BD_DAL.sMsError = "No se puede ejecutar el metodo Execute_DataAdapter()";
                }


            }
            #endregion

            #region Catch
            catch (Exception ex)
            {

                Obj_BD_DAL.sMsError = ex.Message.ToString();
            }
            #endregion

            #region Finally, Instruccion final sin importar si el output del Try, catch
            finally
            {
                if (Obj_BD_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_BD_DAL.Obj_SQL_CNX.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.Obj_SQL_CNX.Close();
                    }

                    Obj_BD_DAL.Obj_SQL_CNX.Dispose();
                }
            }
            #endregion
        }

        // Insert, update and Delete
        // Insert, only if the table does not have entity key
        public void Excute_NonQuery(ref cls_BD_DAL Obj_BD_DAL)
        {
            #region Try
            try
            {

                // Firts, Create the connection
                CrearCNX(ref Obj_BD_DAL);

                // Now, open connection
                if (Obj_BD_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_BD_DAL.Obj_SQL_CNX.State == ConnectionState.Closed)
                    {
                        Obj_BD_DAL.Obj_SQL_CNX.Open();
                    }

                    // Create the object however it have not been executed yet
                    Obj_BD_DAL.Obj_SQL_CMD = new SqlCommand(Obj_BD_DAL.sParametro, Obj_BD_DAL.Obj_SQL_CNX);

                    // I insert security to data adapter, to avoid SQL ejection 
                    Obj_BD_DAL.Obj_SQL_CMD.CommandType = CommandType.StoredProcedure;

                    if (Obj_BD_DAL.Dt_Parametros != null)
                    {
                        if (Obj_BD_DAL.Dt_Parametros.Rows.Count >= 1)
                        {
                            foreach (DataRow dr in Obj_BD_DAL.Dt_Parametros.Rows)
                            {
                                switch (dr[1].ToString())
                                {
                                    case "1":
                                        DB_TYPE = SqlDbType.NVarChar;
                                        break;
                                    case "2":
                                        DB_TYPE = SqlDbType.Int;
                                        break;
                                    case "3":
                                        DB_TYPE = SqlDbType.Char;
                                        break;
                                    case "4":
                                        DB_TYPE = SqlDbType.Decimal;
                                        break;
                                    case "5":
                                        DB_TYPE = SqlDbType.Time;
                                        break;
                                    default:
                                        DB_TYPE = SqlDbType.VarChar;
                                        break;
                                }
                                Obj_BD_DAL.Obj_SQL_CMD.Parameters.Add(dr[0].ToString(), DB_TYPE).Value = dr[2].ToString();
                            }
                        }
                        Obj_BD_DAL.Dt_Parametros = null;
                    }

                    // to execute data adapter
                    Obj_BD_DAL.Obj_SQL_CMD.ExecuteNonQuery();

                    Obj_BD_DAL.sMsError = string.Empty;
                }
                else
                {
                    Obj_BD_DAL.sMsError = "No se puede ejecutar el metodo Execute_NonQuery()";
                }


            }
            #endregion

            #region Catch
            catch (Exception ex)
            {

                Obj_BD_DAL.sMsError = ex.Message.ToString();
            }
            #endregion

            #region Finally, Instruccion final sin importar si el output del Try, catch
            finally
            {
                if (Obj_BD_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_BD_DAL.Obj_SQL_CNX.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.Obj_SQL_CNX.Close();
                    }

                    Obj_BD_DAL.Obj_SQL_CNX.Dispose();
                }
            }
            #endregion
        }

        // Only use for Insert with entity key
        public void Excute_Scalar(ref cls_BD_DAL Obj_BD_DAL)
        {
            #region Try
            try
            {

                // Firts, Create the connection
                CrearCNX(ref Obj_BD_DAL);

                // Now, open connection
                if (Obj_BD_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_BD_DAL.Obj_SQL_CNX.State == ConnectionState.Closed)
                    {
                        Obj_BD_DAL.Obj_SQL_CNX.Open();
                    }

                    // Create the object however it have not been executed yet
                    Obj_BD_DAL.Obj_SQL_CMD = new SqlCommand(Obj_BD_DAL.sParametro, Obj_BD_DAL.Obj_SQL_CNX);

                    // I insert security to data adapter, to avoid SQL ejection 
                    Obj_BD_DAL.Obj_SQL_CMD.CommandType = CommandType.StoredProcedure;

                    if (Obj_BD_DAL.Dt_Parametros != null)
                    {
                        if (Obj_BD_DAL.Dt_Parametros.Rows.Count >= 1)
                        {
                            foreach (DataRow dr in Obj_BD_DAL.Dt_Parametros.Rows)
                            {
                                switch (dr[1].ToString())
                                {
                                    case "1":
                                        DB_TYPE = SqlDbType.NVarChar;
                                        break;
                                    case "2":
                                        DB_TYPE = SqlDbType.Int;
                                        break;
                                    case "3":
                                        DB_TYPE = SqlDbType.Char;
                                        break;
                                    case "4":
                                        DB_TYPE = SqlDbType.Float;
                                        break;
                                    case "5":
                                        DB_TYPE = SqlDbType.Time;
                                        break;
                                    case "6":
                                        DB_TYPE = SqlDbType.DateTime;
                                        break;
                                    case "7":
                                        DB_TYPE = SqlDbType.Bit;
                                        break;
                                    default:
                                        DB_TYPE = SqlDbType.VarChar;
                                        break;
                                }
                                Obj_BD_DAL.Obj_SQL_CMD.Parameters.Add(dr[0].ToString(), DB_TYPE).Value = dr[2].ToString();
                            }
                        }
                    }
                    Obj_BD_DAL.sValorScalar = Convert.ToString(Obj_BD_DAL.Obj_SQL_CMD.ExecuteScalar());
                    Obj_BD_DAL.sMsError = string.Empty;
                }
                else
                {
                    Obj_BD_DAL.sMsError = "No se puede ejecutar el metodo ExecuteScalar()";
                }


            }
            #endregion

            #region Catch
            catch (Exception ex)
            {

                Obj_BD_DAL.sMsError = ex.Message.ToString();
            }
            #endregion

            #region Finally, Instruccion final sin importar si el output del Try, catch
            finally
            {
                if (Obj_BD_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_BD_DAL.Obj_SQL_CNX.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.Obj_SQL_CNX.Close();
                    }

                    Obj_BD_DAL.Obj_SQL_CNX.Dispose();
                }
            }
            #endregion
        }
    }
}
