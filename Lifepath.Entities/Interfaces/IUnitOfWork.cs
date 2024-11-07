using Lifepath.Entities.Model;



namespace Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
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
        int Save(); // Save changes to the database
    }
}
