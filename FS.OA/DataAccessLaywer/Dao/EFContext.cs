
namespace FS.OA.DataAccessLaywer
{
    using FS.OA.Entity;
    using System.Data.Entity;

    public partial class EFContext : DbContext
    {
        public EFContext()
            : base("name=EFContext")
        {
        }

        public virtual DbSet<M_Apply> M_Apply { get; set; }
        public virtual DbSet<M_Approval> M_Approval { get; set; }
        public virtual DbSet<M_Approval_History> M_Approval_History { get; set; }
        public virtual DbSet<M_ApprovalAuthority> M_ApprovalAuthority { get; set; }
        public virtual DbSet<M_ApprovalFlow> M_ApprovalFlow { get; set; }
        public virtual DbSet<M_ApprovalInfo> M_ApprovalInfo { get; set; }
        public virtual DbSet<M_ApprovalType> M_ApprovalType { get; set; }
        public virtual DbSet<M_Authority> M_Authority { get; set; }
        public virtual DbSet<M_Control> M_Control { get; set; }
        public virtual DbSet<M_ControlAuthority> M_ControlAuthority { get; set; }
        public virtual DbSet<M_Page> M_Page { get; set; }
        public virtual DbSet<M_PageAuthority> M_PageAuthority { get; set; }
        public virtual DbSet<M_PositionInfoAuthority> M_PositionInfoAuthority { get; set; }
        public virtual DbSet<M_Role> M_Role { get; set; }
        public virtual DbSet<M_SetOfBooks> M_SetOfBooks { get; set; }
        public virtual DbSet<M_SetOfBooks_Record> M_SetOfBooks_Record { get; set; }
        public virtual DbSet<M_Staff> M_Staff { get; set; }
        public virtual DbSet<M_System> M_System { get; set; }
        public virtual DbSet<M_Task> M_Task { get; set; }
        public virtual DbSet<M_TaskState> M_TaskState { get; set; }
        public virtual DbSet<M_TaskType> M_TaskType { get; set; }
        public virtual DbSet<M_User> M_User { get; set; }
        public virtual DbSet<M_UserAcc> M_UserAcc { get; set; }
        public virtual DbSet<M_UserRole> M_UserRole { get; set; }
        public virtual DbSet<M_WorkFlow> M_WorkFlow { get; set; }
        public virtual DbSet<M_WorkFlow_Step> M_WorkFlow_Step { get; set; }
        public virtual DbSet<M_WorkFlowInfo> M_WorkFlowInfo { get; set; }
        public virtual DbSet<M_WorkInfo_History> M_WorkInfo_History { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<M_ApprovalFlow>()
                .Property(e => e.Page)
                .IsUnicode(false);

            modelBuilder.Entity<M_Control>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<M_Control>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<M_ControlAuthority>()
                .Property(e => e.AuthorityIdList)
                .IsUnicode(false);

            modelBuilder.Entity<M_Page>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<M_Page>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<M_Page>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<M_Page>()
                .Property(e => e.ImageStyle)
                .IsUnicode(false);

            modelBuilder.Entity<M_Page>()
                .Property(e => e.ImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<M_PageAuthority>()
                .Property(e => e.AuthorityIdList)
                .IsUnicode(false);

            modelBuilder.Entity<M_SetOfBooks>()
                .Property(e => e.SetOfBooksCode)
                .IsUnicode(false);

            modelBuilder.Entity<M_SetOfBooks>()
                .Property(e => e.Abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<M_SetOfBooks_Record>()
                .Property(e => e.SetOfBooksCode)
                .IsUnicode(false);

            modelBuilder.Entity<M_SetOfBooks_Record>()
                .Property(e => e.Abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.StaffCode)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.StaffName)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.PayrollCard)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.BeforeName)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.Mailbox)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.IDCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.IDCardNoURL)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.PhotoURL)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.SocialInsuranceNO)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.PaymentStandard)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.InsuredItems_)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.ProvidentFundPaymentStandards_)
                .IsUnicode(false);

            modelBuilder.Entity<M_Staff>()
                .Property(e => e.ProvidentFunNO)
                .IsUnicode(false);

            modelBuilder.Entity<M_System>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<M_Task>()
                .Property(e => e.Charge)
                .IsUnicode(false);

            modelBuilder.Entity<M_Task>()
                .Property(e => e.Executor)
                .IsUnicode(false);

            modelBuilder.Entity<M_Task>()
                .Property(e => e.Complete)
                .IsUnicode(false);

            modelBuilder.Entity<M_Task>()
                .Property(e => e.ApprovalUser)
                .IsUnicode(false);
        }
    }
}
