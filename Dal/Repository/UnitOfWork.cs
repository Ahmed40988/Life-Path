
using DAL;
using Data;
using Interfaces;
using Lifepath.Entities.Model;

namespace Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly Caredbcontext _context;

    public UnitOfWork(Caredbcontext context)
    {
        _context = context;

        Appointments = new Repository<Appointment>(_context);
        AspNetRoles = new Repository<AspNetRole>(_context);
        AspNetUsers = new Repository<AspNetUser>(_context);
        AspNetUserRoles = new Repository<AspNetUserRole>(_context);
        BlogPosts = new Repository<BlogPost>(_context);
        CallRecordings = new Repository<CallRecording>(_context);
        ChatbotInteractions = new Repository<ChatbotInteraction>(_context);
        ChatMessages = new Repository<ChatMessage>(_context);
        Cities = new Repository<City>(_context);
        Doctors = new Repository<Doctor>(_context);
        Documents = new Repository<Document>(_context);
        LoginLogs = new Repository<LoginLog>(_context);
        Medications = new Repository<Medication>(_context);
        Notifications = new Repository<Notification>(_context);
        Patients = new Repository<Patient>(_context);
        Reviews = new Repository<Review>(_context);
        SignUpLogs = new Repository<SignUpLog>(_context);
        Specializations = new Repository<Specialization>(_context);
        UserFiles = new Repository<UserFile>(_context);
        UserReadHistories = new Repository<UserReadHistory>(_context);
    }

    public IRepository<Appointment> Appointments { get; }
    public IRepository<AspNetRole> AspNetRoles { get; }
    public IRepository<AspNetUser> AspNetUsers { get; }
    public IRepository<AspNetUserRole> AspNetUserRoles { get; }
    public IRepository<BlogPost> BlogPosts { get; }
    public IRepository<CallRecording> CallRecordings { get; }
    public IRepository<ChatbotInteraction> ChatbotInteractions { get; }
    public IRepository<ChatMessage> ChatMessages { get; }
    public IRepository<City> Cities { get; }
    public IRepository<Doctor> Doctors { get; }
    public IRepository<Document> Documents { get; }
    public IRepository<LoginLog> LoginLogs { get; }
    public IRepository<Medication> Medications { get; }
    public IRepository<Notification> Notifications { get; }
    public IRepository<Patient> Patients { get; }
    public IRepository<Review> Reviews { get; }
    public IRepository<SignUpLog> SignUpLogs { get; }
    public IRepository<Specialization> Specializations { get; }
    public IRepository<UserFile> UserFiles { get; }
    public IRepository<UserReadHistory> UserReadHistories { get; }

    public void Dispose()
    {
        _context.Dispose();
    }

    public int Save()
    {
        return _context.SaveChanges();
    }
}
