﻿using System.Collections.Generic;
using DogGo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace DogGo.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly IConfiguration _config;
        public WalkRepository(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public List<Walks> GetAllWalks()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT w.Id, w.[Date], w.Duration, w.WalkerId, w.DogId, walker.Name AS WalkerName, d.Name AS DogName
                                        FROM Walks w
                                        LEFT JOIN Walker ON w.WalkerId = Walker.Id
                                        LEFT JOIN Dog d ON w.DogId = d.Id";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Walks> walks = new List<Walks>();
                        while (reader.Read())
                        {
                            Walks walk = new Walks
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                                WalkerId = reader.GetInt32(reader.GetOrdinal("WalkerId")),
                                DogId = reader.GetInt32(reader.GetOrdinal("DogId")),
                                Walker = new Walker()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("WalkerName"))
                                },
                                Dog = new Dog()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("DogName"))
                                }
                            };

                            walks.Add(walk);
                        }

                        return walks;
                    }
                }
            }
        }
        public Walks GetWalkById(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT w.Id, w.[Date], w.Duration, w.WalkerId, w.DogId, walker.Name AS WalkerName, d.Name AS DogName, o.Name AS OwnerName
                                        FROM Walks w
                                        LEFT JOIN Walker ON w.WalkerId = Walker.Id
                                        LEFT JOIN Dog d ON w.DogId = d.Id
                                        LEFT JOIN Owner o ON d.OwnerId = o.Id
                                        WHERE w.Id = @id";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Walks walk = new Walks
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                                WalkerId = reader.GetInt32(reader.GetOrdinal("WalkerId")),
                                DogId = reader.GetInt32(reader.GetOrdinal("DogId")),
                                Walker = new Walker()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("WalkerName"))
                                },
                                Dog = new Dog()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("DogName")),
                                    Owner = new Owner()
                                    {
                                        Name = reader.GetString(reader.GetOrdinal("OwnerName"))
                                    }
                                }
                            };

                            return walk;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }


        public List<Walks> GetWalksByWalkerId(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT w.Id, w.[Date], w.Duration, w.WalkStatusId, d.Name AS DogName, o.Name AS OwnerName, ws.Description 
                                        FROM Walks w
                                        LEFT JOIN Dog d ON w.DogId = d.Id
                                        LEFT JOIN Owner o ON d.OwnerId = o.Id
                                        LEFT JOIN WalkStatus ws ON w.WalkStatusId = ws.Id
                                        WHERE WalkerId = @walkerId";
                    cmd.Parameters.AddWithValue("@walkerId", id);

                    List<Walks> walks = new List<Walks>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    while(reader.Read())
                    {                        
                        Walks walk = new Walks()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                            WalkStatusId = reader.GetInt32(reader.GetOrdinal("WalkStatusId")),

                            Dog = new Dog()
                            {
                                Name = reader.GetString(reader.GetOrdinal("DogName")),
                                Owner = new Owner()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("OwnerName"))
                                }
                            },
                            WalkStatus = new WalkStatus()
                            {
                                Description = reader.GetString(reader.GetOrdinal("Description"))
                            }
                        };
                            walks.Add(walk);

                            if(!reader.IsDBNull(reader.GetOrdinal("DogName")))
                            {
                                walk.Dogs.Add(new Dog()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("DogName")),
                                    Owner = new Owner()
                                    {
                                        Name = reader.GetString(reader.GetOrdinal("OwnerName"))
                                    }
                                });
                            }
                    }
                    return walks;
                }
            }
        }

        public List<Walks> GetWalksByOwnerId(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT w.Id, w.[Date], w.Duration, w.WalkStatusId, d.Name AS DogName, WalkStatus.Description, Walker.Name AS WalkerName
                                            FROM Walks w
                                            LEFT JOIN Dog d ON w.DogId = d.Id
                                            LEFT JOIN Owner o ON d.OwnerId = o.Id
                                            LEFT JOIN Walker ON Walker.Id = w.WalkerId
                                            LEFT JOIN WalkStatus ON w.WalkStatusId = WalkStatus.Id
                                            WHERE OwnerId = @ownerId";
                    cmd.Parameters.AddWithValue("@ownerId", id);

                    List<Walks> walks = new List<Walks>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while(reader.Read())
                        {
                            Walks walk = new Walks()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Duration = reader.GetInt32(reader.GetOrdinal("Duration")),
                                WalkStatusId = reader.GetInt32(reader.GetOrdinal("WalkStatusId")),
                                Dog = new Dog()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("DogName"))
                                },
                                WalkStatus = new WalkStatus()
                                {
                                    Description = reader.GetString(reader.GetOrdinal("Description"))
                                },
                                Walker = new Walker()
                                {
                                    Name = reader.GetString(reader.GetOrdinal("WalkerName"))
                                }
                            };
                            walks.Add(walk);
                        }
                    return walks;
                }
            }
        }

        public void AddWalk(Walks walk)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO Walks ([Date], Duration, WalkerId, DogId, WalkStatusId)
                                        OUTPUT INSERTED.ID
                                        VALUES (@date, @duration, @walkerId, @dogId, @walkStatusId)";

                    cmd.Parameters.AddWithValue("@date", walk.Date);
                    cmd.Parameters.AddWithValue("@duration", walk.Duration);
                    cmd.Parameters.AddWithValue("@walkerId", walk.WalkerId);
                    cmd.Parameters.AddWithValue("@dogId", walk.DogId);
                    cmd.Parameters.AddWithValue("@walkStatusId", walk.WalkStatusId);

                    int id = (int)cmd.ExecuteScalar();

                    walk.Id = id;
                }
            }
        }

        public void UpdateWalk(Walks walk)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE Walks
                                        SET [Date] = @date, 
                                            Duration = @duration, 
                                            WalkerId = @walkerId,
                                            DogId = @dogId,
                                            WalkStatusId = @walkStatusId
                                        WHERE Id = @id";

                    cmd.Parameters.AddWithValue("@date", walk.Date);
                    cmd.Parameters.AddWithValue("@duration", walk.Duration);
                    cmd.Parameters.AddWithValue("@walkerId", walk.WalkerId);
                    cmd.Parameters.AddWithValue("@dogId", walk.DogId);
                    cmd.Parameters.AddWithValue("@walkStatusId", walk.WalkStatusId);
                    cmd.Parameters.AddWithValue("@id", walk.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteWalk(int walkId)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM Walks
                                        WHERE Id = @id";

                    cmd.Parameters.AddWithValue("@id", walkId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
