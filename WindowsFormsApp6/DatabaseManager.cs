using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public static class DatabaseManager
    {
        private const string ConnectionString =
            "Data Source=users.db;Version=3;Journal Mode=WAL;";

        // ----------------------------------------------------
        // DATABASE INIT
        // ----------------------------------------------------
        public static void InitializeDatabase()
        {
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                string usersTable = @"
                CREATE TABLE IF NOT EXISTS Users(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    surname TEXT NOT NULL,
                    password TEXT NOT NULL,
                    role INTEGER NOT NULL,   -- 1=Admin 2=Teacher 3=Student
                    class1 INTEGER NOT NULL, -- 0 or level
                    class2 INTEGER NOT NULL,
                    class3 INTEGER NOT NULL
                );";

                string examsTable = @"
                CREATE TABLE IF NOT EXISTS Exams(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    studentId INTEGER NOT NULL,
                    classNo INTEGER NOT NULL,   -- 1,2,3 (course)
                    examNo INTEGER NOT NULL,    -- 1-4
                    score INTEGER NOT NULL,
                    UNIQUE(studentId, classNo, examNo),
                    FOREIGN KEY(studentId) REFERENCES Users(id) ON DELETE CASCADE
                );";

                new SQLiteCommand(usersTable, con).ExecuteNonQuery();
                new SQLiteCommand(examsTable, con).ExecuteNonQuery();
            }
        }

        // ----------------------------------------------------
        // LOGIN
        // ----------------------------------------------------
        public static int? CheckLogin(string userId, string hashedPassword)
        {
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                var cmd = new SQLiteCommand(
                    "SELECT role FROM Users WHERE id=@id AND password=@pass", con);

                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@pass", hashedPassword);

                object result = cmd.ExecuteScalar();
                return result == null ? (int?)null : Convert.ToInt32(result);
            }
        }

        // ----------------------------------------------------
        // BASIC USER INFO
        // ----------------------------------------------------
        public static (string name, string surname) GetUserInfo(string userId)
        {
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                var cmd = new SQLiteCommand(
                    "SELECT name, surname FROM Users WHERE id=@id", con);

                cmd.Parameters.AddWithValue("@id", userId);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        return (dr["name"].ToString(), dr["surname"].ToString());
                }
            }
            return ("", "");
        }

        // ----------------------------------------------------
        // CREATE EMPTY EXAMS FOR STUDENT
        // ----------------------------------------------------
        public static void CreateEmptyExamsForStudent(long studentId, int class1, int class2, int class3)
        {
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                for (int c = 1; c <= 3; c++)
                {
                    int level = c == 1 ? class1 : c == 2 ? class2 : class3;
                    if (level == 0) continue;

                    for (int exam = 1; exam <= 4; exam++)
                    {
                        var cmd = new SQLiteCommand(@"
                            INSERT OR IGNORE INTO Exams (studentId, classNo, examNo, score)
                            VALUES (@sid, @class, @exam, 0)
                        ", con);

                        cmd.Parameters.AddWithValue("@sid", studentId);
                        cmd.Parameters.AddWithValue("@class", c);
                        cmd.Parameters.AddWithValue("@exam", exam);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // ----------------------------------------------------
        // UPDATE / INSERT SCORE
        // ----------------------------------------------------
        public static void UpsertStudentScore(long studentId, int classNo, int examNo, int score)
        {
            if (score < 0 || score > 100)
            {
                MessageBox.Show(
                    $"Exam score ({score}) must be between 0 and 100.",
                    "Invalid Score",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();

                    var cmd = new SQLiteCommand(@"
                INSERT INTO Exams (studentId, classNo, examNo, score)
                VALUES (@sid,@class,@exam,@score)
                ON CONFLICT(studentId,classNo,examNo)
                DO UPDATE SET score=@score
            ", con);

                    cmd.Parameters.AddWithValue("@sid", studentId);
                    cmd.Parameters.AddWithValue("@class", classNo);
                    cmd.Parameters.AddWithValue("@exam", examNo);
                    cmd.Parameters.AddWithValue("@score", score);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        System.Diagnostics.Debug.WriteLine(
                            $"WARN: Score not updated. ID: {studentId}, Class: {classNo}, Exam: {examNo}");
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(
                    $"Database operation failed:\n{ex.Message}\n\nStudent ID: {studentId}\nClass: {classNo}\nExam: {examNo}",
                    "Critical Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An unexpected error occurred:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // RANDOM SCORE
        // ----------------------------------------------------
        private static Random rnd = new Random();

        public static int GetWeightedRandom() =>
            rnd.NextDouble() < 0.7 ? rnd.Next(50, 101) : rnd.Next(1, 50);

        public static void FillAllZeroScoresWithRandom()
        {
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();
                var select = new SQLiteCommand(
                    "SELECT studentId, classNo, examNo FROM Exams WHERE score=0", con);

                using (var dr = select.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        UpsertStudentScore(
                            Convert.ToInt64(dr["studentId"]),
                            Convert.ToInt32(dr["classNo"]),
                            Convert.ToInt32(dr["examNo"]),
                            GetWeightedRandom());
                    }
                }
            }
        }

        public static void GenerateRandomScoresForExistingStudents() =>
            FillAllZeroScoresWithRandom();

        // ----------------------------------------------------
        // GET STUDENTS FOR TEACHER (DataTable)
        // ----------------------------------------------------
        public static DataTable GetStudentsForTeacher(string teacherId)
        {
            var dt = new DataTable();

            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                var tcmd = new SQLiteCommand(
                    "SELECT class1, class2, class3 FROM Users WHERE id=@id AND role=2", con);
                tcmd.Parameters.AddWithValue("@id", teacherId);

                int classNo = 0;
                int level = 0;

                using (var dr = tcmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        if (Convert.ToInt32(dr["class1"]) != 0) { classNo = 1; level = Convert.ToInt32(dr["class1"]); }
                        else if (Convert.ToInt32(dr["class2"]) != 0) { classNo = 2; level = Convert.ToInt32(dr["class2"]); }
                        else if (Convert.ToInt32(dr["class3"]) != 0) { classNo = 3; level = Convert.ToInt32(dr["class3"]); }
                    }
                }

                if (classNo == 0 || level == 0)
                {
                    MessageBox.Show(
                        "No valid class or level assigned to this teacher.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return dt;
                }

                string classColumn = $"class{classNo}";

                string sql = $@"
            SELECT
                u.id,
                u.name,
                u.surname,
                IFNULL(MAX(CASE WHEN e.examNo=1 THEN e.score END),0) AS exam1,
                IFNULL(MAX(CASE WHEN e.examNo=2 THEN e.score END),0) AS exam2,
                IFNULL(MAX(CASE WHEN e.examNo=3 THEN e.score END),0) AS exam3,
                IFNULL(MAX(CASE WHEN e.examNo=4 THEN e.score END),0) AS exam4
            FROM Users u
            LEFT JOIN Exams e
                ON u.id = e.studentId AND e.classNo = @classNo
            WHERE u.role = 3 AND u.{classColumn} = @level
            GROUP BY u.id, u.name, u.surname
            ORDER BY u.id";

                var cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@classNo", classNo);
                cmd.Parameters.AddWithValue("@level", level);

                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        // ----------------------------------------------------
        // ADMIN CHECK
        // ----------------------------------------------------
        public static bool AdminExists()
        {
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand(
                    "SELECT COUNT(*) FROM Users WHERE role=1", con);
                return (long)cmd.ExecuteScalar() > 0;
            }
        }

        // ----------------------------------------------------
        // ADD TEACHERS + ADMIN
        // ----------------------------------------------------
        public static void AddTeachersAndAdmin(string hashedPassword)
        {
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                string sql = @"
        INSERT OR IGNORE INTO Users (name,surname,password,role,class1,class2,class3) VALUES
        ('Admin','User',@p,1,0,0,0),
        ('Ahmet','Yılmaz',@p,2,1,0,0),
        ('Ayşe','Demir',@p,2,2,0,0),
        ('Mehmet','Kara',@p,2,3,0,0);";

                var cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@p", hashedPassword);
                cmd.ExecuteNonQuery();
            }
        }

        // ----------------------------------------------------
        // GET STUDENT COUNT BY LEVEL FOR A CLASS
        // ----------------------------------------------------
        public static Dictionary<int, int> GetStudentCountByLevel(int classNo)
        {
            var counts = new Dictionary<int, int>();
            string classColumn = $"class{classNo}";

            string sql = $@"
        SELECT {classColumn} AS Level, COUNT(id) AS StudentCount
        FROM Users
        WHERE role = 3 AND {classColumn} != 0
        GROUP BY {classColumn}
        ORDER BY {classColumn}";

            try
            {
                using (var con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    var cmd = new SQLiteCommand(sql, con);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int level = Convert.ToInt32(dr["Level"]);
                            int count = Convert.ToInt32(dr["StudentCount"]);
                            counts.Add(level, count);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to retrieve student counts ({classColumn}).\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return counts;
        }

        public static int DeleteUser(string userId)
        {
            try
            {
                using (var con = new SQLiteConnection(ConnectionString))
                {
                    con.Open();
                    var cmd = new SQLiteCommand(
                        "DELETE FROM Users WHERE id=@id AND role=3", con);
                    cmd.Parameters.AddWithValue("@id", userId);

                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"A database error occurred while deleting the user:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return 0;
            }
        }
        public static void FixTeacherClasses()
        {
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                string sql = @"
-- ENGLISH (A1–B2)
UPDATE Users SET class1=1, class2=0, class3=0 WHERE id=7  AND role=2;
UPDATE Users SET class1=2, class2=0, class3=0 WHERE id=8  AND role=2;
UPDATE Users SET class1=3, class2=0, class3=0 WHERE id=9  AND role=2;
UPDATE Users SET class1=4, class2=0, class3=0 WHERE id=10 AND role=2;

-- GERMAN (A1–B2)
UPDATE Users SET class1=0, class2=1, class3=0 WHERE id=11 AND role=2;
UPDATE Users SET class1=0, class2=2, class3=0 WHERE id=12 AND role=2;
UPDATE Users SET class1=0, class2=3, class3=0 WHERE id=13 AND role=2;
UPDATE Users SET class1=0, class2=4, class3=0 WHERE id=14 AND role=2;

-- SPANISH (A1–B2)
UPDATE Users SET class1=0, class2=0, class3=1 WHERE id=15 AND role=2;
UPDATE Users SET class1=0, class2=0, class3=2 WHERE id=16 AND role=2;
UPDATE Users SET class1=0, class2=0, class3=3 WHERE id=17 AND role=2;
UPDATE Users SET class1=0, class2=0, class3=4 WHERE id=18 AND role=2;
";

                new SQLiteCommand(sql, con).ExecuteNonQuery();
            }
        }




    }
}