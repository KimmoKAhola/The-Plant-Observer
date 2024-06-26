﻿using Microsoft.EntityFrameworkCore;
using PlantAPI.Models.Sensor;
using PlantAPI.Models.User;

namespace PlantAPI.Data;

public class PlantContext : DbContext
{
    public PlantContext(DbContextOptions options)
        : base(options) { }

    public DbSet<SensorData> SensorData { get; set; }
    public DbSet<UserBotMessage> UserMessages { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Sensor> Sensors { get; set; }
}
