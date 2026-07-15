using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipment.Classes
{
    public class DBConnection
    {
        static string connectString = @"Database=equipment;
                                           DataSource=localhost;
                                           user=root; password=root;
                                           charset=utf8mb4;";
        static MySqlConnection myConnect; //Для установки соедининие БД
        static public MySqlCommand myCommand; //Для выполнения запросов и команд
        static public MySqlDataAdapter myDataAdapter; // для вывода информации в таблицу 

        /// <summary>
        /// Метод установки соединения с БД
        /// </summary>
        /// <returns></returns>
        static public bool ConnectBD()
        {
            try
            {
                myConnect = new MySqlConnection(connectString);
                myConnect.Open();
                myCommand = new MySqlCommand(); //Для выполнения запрососв 
                myCommand.Connection = myConnect;
                myDataAdapter = new MySqlDataAdapter(myCommand);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Метод отключения соединения с БД
        /// </summary>
        /// <returns></returns>
        static public bool CloseBD()
        {
            try
            {
                myConnect.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
