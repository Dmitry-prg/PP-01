using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment.Classes
{
    internal class Invoice
    {

        public static DataTable dtInvoice= new DataTable();


        /// <summary>
        /// Получает список всех накладных из базы данных
        /// </summary>
        public static void GetListInvoice()
        {
            DBConnection.myCommand.CommandText =
                $@"SELECT   invoice.idInvoice,
                            invoice.dateInvoice,
                            s_vendor.nameVendor,
                            invoice.idVendor
                FROM invoice 
                LEFT JOIN s_vendor ON invoice.idVendor = s_vendor.idVendor";
            dtInvoice.Clear();
            DBConnection.myDataAdapter.Fill(dtInvoice);
        }

        /// <summary>
        /// Получает максимальный ID накладной из базы данных 
        /// </summary>
        /// <returns></returns>
        public static string GetMaxIdInvoice()
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"SELECT MAX(idInvoice) FROM invoice;";
                return DBConnection.myCommand.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Обновляет данные существующей накладной в базе данных
        /// </summary>
        /// <param name="idInvoice"></param>
        /// <param name="dateInvoice"></param>
        /// <param name="idVendor"></param>
        /// <returns></returns>

        public static bool Update(string idInvoice, string dateInvoice, string idVendor)
        {
            try
            {
                DBConnection.myCommand.CommandText =
                    $@"UPDATE invoice 
                    SET dateInvoice = '{dateInvoice}',
                        idVendor = '{idVendor}'
                    WHERE idInvoice = '{idInvoice}';";
                if (DBConnection.myCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
        }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Добавляет новую накладную в базу данных
        /// </summary>
        /// <param name="dateInvoice"></param>
        /// <param name="idVendor"></param>
        /// <returns></returns>

        public static bool Add(string dateInvoice, string idVendor)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"INSERT INTO invoice VALUES(null,'{dateInvoice}', '{idVendor}');";
                if (DBConnection.myCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Удаляет наклданую из базы данных
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            try
            {
                DBConnection.myCommand.CommandText = $@"DELETE FROM invoice WHERE idInvoice = '{id}';";
                if (DBConnection.myCommand.ExecuteNonQuery() != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
