using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace kis
{
    public class DataBaseManager
    {
        public DataBaseManager() { }

        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=iKONXBI_2015;Database=kis;");
        }

        public String UserAuthorize(String userLogin, String userPassword)
        {
            NpgsqlConnection connection = GetConnection();
            connection.Open();

            var sql = "SELECT * FROM user_system WHERE user_login = @userLogin AND user_password = @userPassword";
            var command = new NpgsqlCommand(sql, connection);
            var loginParam = new NpgsqlParameter("@userLogin", userLogin);
            var passwordParam = new NpgsqlParameter("@userPassword", userPassword);
            command.Parameters.Add(loginParam);
            command.Parameters.Add(passwordParam);            

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            connection.Close();

            if (table.Rows.Count > 0)
                return $"{table.Rows[0][1].ToString()} {table.Rows[0][3].ToString()}";
            else
                return $"error error";
        }

        public DataTable LoadTable(String name)
        {
            NpgsqlConnection connection = GetConnection();
            connection.Open();

            String sql;
            switch (name)
            {
                case "user_system":
                    sql = "SELECT * FROM user_system";
                    break;
                case "customer":
                    sql = "SELECT * FROM customer";
                    break;
                case "genre":
                    sql = "SELECT * FROM genre";
                    break;
                case "country":
                    sql = "SELECT * FROM country";
                    break;
                case "playlist":
                    sql = "SELECT * FROM playlist";
                    break;
                case "song":
                    sql = "SELECT * FROM song";
                    break;
                default:
                    sql = "someTable";
                    break;
            }

            var command = new NpgsqlCommand(sql, connection);

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            table.Columns.Add("Action");

            foreach (DataRow row in table.Rows)
                row["Action"] = "Delete";

            connection.Close();

            return table;
        }

        public void DeleteEntry(String name, String data)
        {
            NpgsqlConnection connection = GetConnection();
            connection.Open();

            String[] userInfo = data.Split(' ');
            String sql;
            switch (name)
            {
                case "Пользователи системы":
                    sql = $"DELETE FROM user_system WHERE user_login = '{userInfo[1]}' AND user_password = '{userInfo[2]}'";
                    name = "user_system";
                    break;
                case "Слушатели приложения":
                    sql = $"DELETE FROM customer WHERE customer_name = '{userInfo[1]}' AND registration_date = '{userInfo[2]}' AND country_id = '{userInfo[3]}'";
                    break;
                case "Жанры приложения":
                    sql = $"DELETE FROM genre WHERE genre_name = '{userInfo[1]}'";
                    break;
                case "Страны слушателей":
                    sql = $"DELETE FROM country WHERE country_name = '{userInfo[1]}'";
                    break;
                case "Плейлисты приложения":
                    sql = $"DELETE FROM playlist WHERE playlist_name = '{userInfo[1]}'";
                    break;
                case "Песни приложения":
                    sql = $"DELETE FROM song song_title = '{userInfo[1]}' AND artist_name = '{userInfo[2]}'";
                    break;
                default:
                    sql = "someTable";
                    break;
            }

            var command = new NpgsqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    
        public void InsertEntry(String name, String data)
        {
            NpgsqlConnection connection = GetConnection();
            connection.Open();

            String[] userInfo = data.Split(' ');
            String sql;
            switch (name)
            {
                case "Пользователи системы":
                    sql = $"INSERT INTO user_system (user_login, user_password, user_status) VALUES ('{userInfo[1]}', '{userInfo[2]}', '{userInfo[3]}')";
                    name = "user_system";
                    break;
                case "Слушатели приложения":
                    sql = $"INSERT INTO customer (customer_name, registration_date, country_id) VALUES ('{userInfo[1]}', '{userInfo[2]}', {Int32.Parse(userInfo[3])})";
                    break;
                case "Жанры приложения":
                    sql = $"INSERT INTO genre (genre_name) VALUES ('{userInfo[1]}')";
                    break;
                case "Страны слушателей":
                    sql = $"INSERT INTO country (country_name) VALUES ('{userInfo[1]}')";
                    break;
                case "Плейлисты приложения":
                    sql = $"INSERT INTO playlist (playlist_name) VALUE ('{userInfo[1]}')";
                    break;
                case "Песни приложения":
                    sql = $"INSERT INTO song (song_title, artist_name, album_name, genre_id) VALUES ('{userInfo[1]}', '{userInfo[2]}', '{userInfo[3]}', {Int32.Parse(userInfo[4])})";
                    break;
                default:
                    sql = "someTable";
                    break;
            }
            var command = new NpgsqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    
        public void UpdateEntry(String name, int editingRowIndex, String data)
        {
            NpgsqlConnection connection = GetConnection();
            connection.Open();

            String[] userInfo = data.Split('/');
            String sql;
            switch (name)
            {
                case "Пользователи системы":
                    sql = $"UPDATE user_system SET user_login = '{userInfo[0]}', user_password = '{userInfo[1]}', user_status = '{userInfo[2]}' " +
                        $"WHERE user_system_id={editingRowIndex + 1}";
                    name = "user_system";
                    break;
                case "Слушатели приложения":
                    sql = $"UPDATE customer SET customer_name = '{userInfo[0]}', registration_date = '{userInfo[1]}', country_id = {Int32.Parse(userInfo[2])} " +
                        $"WHERE customer_id={editingRowIndex + 1}";
                    break;
                case "Жанры приложения":
                    sql = $"UPDATE genre SET genre_name = '{userInfo[0]}' WHERE genre_id={editingRowIndex + 1}";
                    break;
                case "Страны слушателей":
                    sql = $"UPDATE country SET country_name = '{userInfo[0]}' WHERE country_id={editingRowIndex + 1}";
                    break;
                case "Плейлисты приложения":
                    sql = $"UPDATE playlist SET playlist_name = '{userInfo[0]}' WHERE playlist_id={editingRowIndex + 1}";
                    break;
                case "Песни приложения":
                    sql = $"UPDATE song SET song_title = '{userInfo[0]}', artist_name = '{userInfo[1]}', album_name = '{userInfo[2]}', genre_id = {Int32.Parse(userInfo[3])} " +
                        $"WHERE song_id={editingRowIndex + 1}";
                    break;
                default:
                    sql = "someTable";
                    break;
            }

            var command = new NpgsqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();           
        }
    
        public DataTable ReportRequest(String reportName)
        {
            NpgsqlConnection connection = GetConnection();
            connection.Open();

            String sql;
            switch (reportName)
            {
                case "genresRating":
                    sql = $"SELECT G.genre_name AS \"Жанр\", COUNT(DISTINCT CHS.customer_id) AS \"Количество пользователей\" " +
                        $"FROM customer_has_playlist CHS LEFT JOIN playlist_has_song PHS ON PHS.playlist_id = CHS.playlist_id " +
                        $"LEFT JOIN song S ON S.song_id = PHS.song_id LEFT JOIN genre G ON G.genre_id = S.genre_id " +
                        $"GROUP BY \"Жанр\" ORDER BY \"Количество пользователей\" DESC;";
                    break;
                case "playlistsRating":
                    sql = $"SELECT P.playlist_name AS \"Плейлист\", COUNT(CHP.customer_id) AS \"Количество пользователей\" " +
                        $"FROM playlist P JOIN customer_has_playlist CHP ON CHP.playlist_id = P.playlist_id " +
                        $"GROUP BY \"Плейлист\" ORDER BY \"Количество пользователей\" DESC;";
                    break;
                case "countriesRating":
                    sql = $"SELECT CN.country_name AS \"Страна\", COUNT(C.customer_id) AS \"Количество слушателей\" " +
                        $"FROM country CN JOIN customer C ON CN.country_id = C.country_id " +
                        $"GROUP BY \"Страна\" ORDER BY \"Количество слушателей\" DESC;";
                    break;
                case "popularSongs":
                    sql = $"SELECT \"Песня\", \"Жанр\", \"Количество слушателей\" " +
                        $"FROM ( SELECT S.song_title AS \"Песня\", G.genre_name AS \"Жанр\", " +
                        "COALESCE(COUNT(DISTINCT C.customer_id), 0) AS \"Количество слушателей\", " +
                        "ROW_NUMBER() OVER(PARTITION BY G.genre_name ORDER BY COALESCE(COUNT(DISTINCT C.customer_id), 0) DESC) " +
                        "AS most_pop FROM customer C LEFT JOIN customer_has_playlist CHP ON C.customer_id = CHP.customer_id " +
                        "LEFT JOIN playlist_has_song PHS ON CHP.playlist_id = PHS.playlist_id " +
                        "LEFT JOIN song S ON PHS.song_id = S.song_id LEFT JOIN genre G ON G.genre_id = S.genre_id " +
                        "GROUP BY \"Песня\", \"Жанр\" ORDER BY most_pop ) AS ss WHERE most_pop = 1 " +
                        "ORDER BY \"Количество слушателей\" DESC;";
                    break;
                case "songsList":
                    sql = $"SELECT G.genre_name AS \"Жанр\", S.song_title AS \"Песня\" FROM genre G " +
                        $"LEFT JOIN song S ON S.genre_id = G.genre_id; ";
                    break;
                default:
                    sql = "some";
                    break;
            }

            var command = new NpgsqlCommand(sql, connection);

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            connection.Close();

            return table;
        }
    }
}
