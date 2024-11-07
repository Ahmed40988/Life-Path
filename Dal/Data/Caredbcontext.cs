using Interfaces;
using Lifepath.Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace Data;

public class Caredbcontext : DbContext
{
    public Caredbcontext(DbContextOptions<Caredbcontext> options) : base(options)
    {
    }

    public DbSet<AspNetUser> AspNetUsers { get; set; }
    public DbSet<AspNetRole> AspNetRoles { get; set; }
    public DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Specialization> Specializations { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<CallRecording> CallRecordings { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<LoginLog> LoginLogs { get; set; }
    public DbSet<SignUpLog> SignUpLogs { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<UserReadHistory> UserReadHistories { get; set; }
    public DbSet<UserFile> UserFiles { get; set; }
    public DbSet<ChatbotInteraction> ChatbotInteractions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetUser>()
            .HasKey(u => u.UserID);

        modelBuilder.Entity<AspNetRole>()
            .HasKey(r => r.RoleID);

        modelBuilder.Entity<AspNetUserRole>()
            .HasKey(ur => new { ur.UserID, ur.RoleID });
        modelBuilder.Entity<AspNetUserRole>()
            .HasOne(ur => ur.User)
            .WithMany(u => u.UserRoles)
            .HasForeignKey(ur => ur.UserID);
        modelBuilder.Entity<AspNetUserRole>()
            .HasOne(ur => ur.Role)
            .WithMany(r => r.UserRoles)
            .HasForeignKey(ur => ur.RoleID);

        modelBuilder.Entity<Doctor>()
            .HasOne(d => d.User)
            .WithMany()
            .HasForeignKey(d => d.UserID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Doctor>()
            .HasOne(d => d.Specialization)
            .WithMany()
            .HasForeignKey(d => d.SpecializationID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Patient>()
            .HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Patient)
            .WithMany()
            .HasForeignKey(a => a.PatientID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Doctor)
            .WithMany()
            .HasForeignKey(a => a.DoctorID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.City)
            .WithMany()
            .HasForeignKey(a => a.CityID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CallRecording>()
            .HasOne(cr => cr.Doctor)
            .WithMany()
            .HasForeignKey(cr => cr.DoctorID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<CallRecording>()
            .HasOne(cr => cr.Patient)
            .WithMany()
            .HasForeignKey(cr => cr.PatientID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ChatMessage>()
            .HasOne(cm => cm.Sender)
            .WithMany()
            .HasForeignKey(cm => cm.SenderID)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<ChatMessage>()
            .HasOne(cm => cm.Receiver)
            .WithMany()
            .HasForeignKey(cm => cm.ReceiverID)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.Doctor)
            .WithMany()
            .HasForeignKey(r => r.DoctorID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Review>()
            .HasOne(r => r.Patient)
            .WithMany()
            .HasForeignKey(r => r.PatientID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Notification>()
            .HasOne(n => n.User)
            .WithMany()
            .HasForeignKey(n => n.UserID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<LoginLog>()
            .HasOne(l => l.User)
            .WithMany()
            .HasForeignKey(l => l.UserID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<SignUpLog>()
            .HasOne(s => s.User)
            .WithMany()
            .HasForeignKey(s => s.UserID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Document>()
            .HasOne(d => d.Patient)
            .WithMany()
            .HasForeignKey(d => d.PatientID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Document>()
            .HasOne(d => d.AssociatedDoctor)
            .WithMany()
            .HasForeignKey(d => d.AssociatedDoctorID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Medication>()
            .HasOne(m => m.Patient)
            .WithMany()
            .HasForeignKey(m => m.PatientID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Medication>()
            .HasOne(m => m.Doctor)
            .WithMany()
            .HasForeignKey(m => m.DoctorID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<BlogPost>()
            .HasOne(bp => bp.Doctor)
            .WithMany()
            .HasForeignKey(bp => bp.DoctorID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<UserReadHistory>()
            .HasOne(urh => urh.Patient)
            .WithMany()
            .HasForeignKey(urh => urh.PatientID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<UserReadHistory>()
            .HasOne(urh => urh.Post)
            .WithMany()
            .HasForeignKey(urh => urh.PostID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<UserFile>()
            .HasOne(uf => uf.User)
            .WithMany()
            .HasForeignKey(uf => uf.UserID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<UserFile>()
            .HasOne(uf => uf.AssociatedDoctor)
            .WithMany()
            .HasForeignKey(uf => uf.AssociatedDoctorID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ChatbotInteraction>()
            .HasOne(ci => ci.User)
            .WithMany()
            .HasForeignKey(ci => ci.UserID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}