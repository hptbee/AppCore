using System.Collections.Generic;
using System.Transactions;
using Microsoft.EntityFrameworkCore;

namespace AppCore.Entity.Models
{
    public  class AppCoreContext : DbContext
    {
        public virtual DbSet<FlexColumns> FlexColumns { get; set; }
        public virtual DbSet<FlexConfigs> FlexConfigs { get; set; }
        public virtual DbSet<FlexDataTypes> FlexDataTypes { get; set; }
        public virtual DbSet<FlexDepartment> FlexDepartment { get; set; }
        public virtual DbSet<FlexEnums> FlexEnums { get; set; }
        public virtual DbSet<FlexEnumValues> FlexEnumValues { get; set; }
        public virtual DbSet<FlexLanguages> FlexLanguages { get; set; }
        public virtual DbSet<FlexLogs> FlexLogs { get; set; }
        public virtual DbSet<FlexMailTemplates> FlexMailTemplates { get; set; }
        public virtual DbSet<FlexModuleRoles> FlexModuleRoles { get; set; }
        public virtual DbSet<FlexModules> FlexModules { get; set; }
        public virtual DbSet<FlexRelationshipTables> FlexRelationshipTables { get; set; }
        public virtual DbSet<FlexRoles> FlexRoles { get; set; }
        public virtual DbSet<FlexTables> FlexTables { get; set; }
        public virtual DbSet<FlexTempViewColumns> FlexTempViewColumns { get; set; }
        public virtual DbSet<FlexTempViewConditions> FlexTempViewConditions { get; set; }
        public virtual DbSet<FlexTempViews> FlexTempViews { get; set; }
        public virtual DbSet<FlexUserExt> FlexUserExt { get; set; }
        public virtual DbSet<FlexUsers> FlexUsers { get; set; }
        public virtual DbSet<FlexViewColumns> FlexViewColumns { get; set; }
        public virtual DbSet<FlexViewConditions> FlexViewConditions { get; set; }
        public virtual DbSet<FlexViewGroupColumns> FlexViewGroupColumns { get; set; }
        public virtual DbSet<FlexViewRoles> FlexViewRoles { get; set; }
        public virtual DbSet<FlexViews> FlexViews { get; set; }
        public virtual DbSet<FlexViewSortOrders> FlexViewSortOrders { get; set; }
        public virtual DbSet<SaleContactEmails> SaleContactEmails { get; set; }
        public virtual DbSet<SaleCustomerContacts> SaleCustomerContacts { get; set; }
        public virtual DbSet<SaleCustomers> SaleCustomers { get; set; }
        public virtual DbSet<SaleDeliveries> SaleDeliveries { get; set; }
        public virtual DbSet<SaleDistricts> SaleDistricts { get; set; }
        public virtual DbSet<SaleFavouriteProducts> SaleFavouriteProducts { get; set; }
        public virtual DbSet<SaleFiles> SaleFiles { get; set; }
        public virtual DbSet<SaleLocations> SaleLocations { get; set; }
        public virtual DbSet<SaleMenus> SaleMenus { get; set; }
        public virtual DbSet<SaleModules> SaleModules { get; set; }
        public virtual DbSet<SaleModulevsNewsCategory> SaleModulevsNewsCategory { get; set; }
        public virtual DbSet<SaleNavigations> SaleNavigations { get; set; }
        public virtual DbSet<SaleNews> SaleNews { get; set; }
        public virtual DbSet<SaleNewsCategories> SaleNewsCategories { get; set; }
        public virtual DbSet<SaleNewsCategoriesImageList> SaleNewsCategoriesImageList { get; set; }
        public virtual DbSet<SaleNewsImageList> SaleNewsImageList { get; set; }
        public virtual DbSet<SaleNewsVsCategories> SaleNewsVsCategories { get; set; }
        public virtual DbSet<SaleOptions> SaleOptions { get; set; }
        public virtual DbSet<SaleOptionValues> SaleOptionValues { get; set; }
        public virtual DbSet<SaleOrderDelivereds> SaleOrderDelivereds { get; set; }
        public virtual DbSet<SaleOrderDetails> SaleOrderDetails { get; set; }
        public virtual DbSet<SaleOrderRefunds> SaleOrderRefunds { get; set; }
        public virtual DbSet<SaleOrders> SaleOrders { get; set; }
        public virtual DbSet<SalePageLinks> SalePageLinks { get; set; }
        public virtual DbSet<SalePageNavs> SalePageNavs { get; set; }
        public virtual DbSet<SalePartialViews> SalePartialViews { get; set; }
        public virtual DbSet<SalePayments> SalePayments { get; set; }
        public virtual DbSet<SaleProductCategoriesImageList> SaleProductCategoriesImageList { get; set; }
        public virtual DbSet<SaleProductCategorys> SaleProductCategorys { get; set; }
        public virtual DbSet<SaleProductImageList> SaleProductImageList { get; set; }
        public virtual DbSet<SaleProducts> SaleProducts { get; set; }
        public virtual DbSet<SaleProductTabs> SaleProductTabs { get; set; }
        public virtual DbSet<SaleProductVsCategories> SaleProductVsCategories { get; set; }
        public virtual DbSet<SaleProductVsTabs> SaleProductVsTabs { get; set; }
        public virtual DbSet<SaleProvinces> SaleProvinces { get; set; }
        public virtual DbSet<SaleRecuitmentCategories> SaleRecuitmentCategories { get; set; }
        public virtual DbSet<SaleRecuitmentCategoriesImageList> SaleRecuitmentCategoriesImageList { get; set; }
        public virtual DbSet<SaleRecuitmentCategoryVsUser> SaleRecuitmentCategoryVsUser { get; set; }
        public virtual DbSet<SaleRecuitments> SaleRecuitments { get; set; }
        public virtual DbSet<SaleRecuitmentsVsCategories> SaleRecuitmentsVsCategories { get; set; }
        public virtual DbSet<SaleRefMenus> SaleRefMenus { get; set; }
        public virtual DbSet<SaleRefNavigations> SaleRefNavigations { get; set; }
        public virtual DbSet<SaleRefNews> SaleRefNews { get; set; }
        public virtual DbSet<SaleRefNewsCategories> SaleRefNewsCategories { get; set; }
        public virtual DbSet<SaleRefNewsCategoriesImageList> SaleRefNewsCategoriesImageList { get; set; }
        public virtual DbSet<SaleRefNewsImageList> SaleRefNewsImageList { get; set; }
        public virtual DbSet<SaleRefOptions> SaleRefOptions { get; set; }
        public virtual DbSet<SaleRefOptionValues> SaleRefOptionValues { get; set; }
        public virtual DbSet<SaleRefProductCategoriesImageList> SaleRefProductCategoriesImageList { get; set; }
        public virtual DbSet<SaleRefProductImageList> SaleRefProductImageList { get; set; }
        public virtual DbSet<SaleRefProducts> SaleRefProducts { get; set; }
        public virtual DbSet<SaleRefProductsCatetories> SaleRefProductsCatetories { get; set; }
        public virtual DbSet<SaleRefRecuitmentCategories> SaleRefRecuitmentCategories { get; set; }
        public virtual DbSet<SaleRefRecuitmentCategoriesImageList> SaleRefRecuitmentCategoriesImageList { get; set; }
        public virtual DbSet<SaleRefRecuitments> SaleRefRecuitments { get; set; }
        public virtual DbSet<SaleRefVideoLists> SaleRefVideoLists { get; set; }
        public virtual DbSet<SaleRefVideos> SaleRefVideos { get; set; }
        public virtual DbSet<SaleRefWareHouses> SaleRefWareHouses { get; set; }
        public virtual DbSet<SaleResumes> SaleResumes { get; set; }
        public virtual DbSet<SaleTransportFees> SaleTransportFees { get; set; }
        public virtual DbSet<SaleTransports> SaleTransports { get; set; }
        public virtual DbSet<SaleVideos> SaleVideos { get; set; }
        public virtual DbSet<SaleVideosList> SaleVideosList { get; set; }
        public virtual DbSet<SaleVideovsNewsCategory> SaleVideovsNewsCategory { get; set; }
        public virtual DbSet<SaleWards> SaleWards { get; set; }
        public virtual DbSet<SaleWareHouseDetails> SaleWareHouseDetails { get; set; }
        public virtual DbSet<SaleWareHouses> SaleWareHouses { get; set; }
        public virtual DbSet<SaleWebImages> SaleWebImages { get; set; }
        public virtual DbSet<SaleWebPagePositions> SaleWebPagePositions { get; set; }
        public virtual DbSet<SaleWebPages> SaleWebPages { get; set; }
        public virtual DbSet<SystemAuditLogs> SystemAuditLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=210.211.118.132;Initial Catalog=VTHostDbV1;Persist Security Info=True;User ID=vthost_user;Password=1Emqwu7akKe");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlexColumns>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.DataType)
                    .WithMany(p => p.FlexColumns)
                    .HasForeignKey(d => d.DataTypeId)
                    .HasConstraintName("FK_FlexColumns_FlexDataTypes");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.FlexColumns)
                    .HasForeignKey(d => d.TableId)
                    .HasConstraintName("FK_FlexColumns_FlexTables");
            });

            modelBuilder.Entity<FlexConfigs>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<FlexDataTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FlexDepartment>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlexEnums>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.FlexEnums)
                    .HasForeignKey(d => d.TableId)
                    .HasConstraintName("FK_FlexEnums_FlexTables");
            });

            modelBuilder.Entity<FlexEnumValues>(entity =>
            {
                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Enum)
                    .WithMany(p => p.FlexEnumValues)
                    .HasForeignKey(d => d.EnumId)
                    .HasConstraintName("FK_FlexEnumValues_FlexEnums");
            });

            modelBuilder.Entity<FlexLanguages>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Image).HasMaxLength(255);

                entity.Property(e => e.LanguageUl)
                    .HasColumnName("LanguageUL")
                    .HasMaxLength(100);

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(50);
            });

            modelBuilder.Entity<FlexLogs>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception).HasColumnType("ntext");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlexMailTemplates>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Template).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlexModuleRoles>(entity =>
            {
                entity.HasOne(d => d.Module)
                    .WithMany(p => p.FlexModuleRoles)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_FlexModuleRoles_FlexModules");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FlexModuleRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_FlexModuleRoles_FlexRoles");
            });

            modelBuilder.Entity<FlexModules>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Namespace)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FlexRelationshipTables>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayParentColumnName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ParentTableAlias)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlexRoles>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlexTables>(entity =>
            {
                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.FlexTables)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_FlexTables_FlexModules");
            });

            modelBuilder.Entity<FlexTempViewColumns>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Width)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FlexTempViewConditions>(entity =>
            {
                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilterValue1)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FilterValue2)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlexTempViews>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromSql).IsRequired();

                entity.Property(e => e.SelectSql).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlexUserExt>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FlexUserExt)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlexUserExt_FlexUsers");
            });

            modelBuilder.Entity<FlexUsers>(entity =>
            {
                entity.Property(e => e.ActiveCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.FlexUsers)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_FlexUsers_FlexDepartment");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FlexUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_FlexUsers_FlexRoles");
            });

            modelBuilder.Entity<FlexViewColumns>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Width)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.View)
                    .WithMany(p => p.FlexViewColumns)
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("FK_FlexViewColumns_FlexViews");
            });

            modelBuilder.Entity<FlexViewConditions>(entity =>
            {
                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilterValue1)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FilterValue2)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.View)
                    .WithMany(p => p.FlexViewConditions)
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("FK_FlexViewConditions_FlexViews");
            });

            modelBuilder.Entity<FlexViewGroupColumns>(entity =>
            {
                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.View)
                    .WithMany(p => p.FlexViewGroupColumns)
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("FK_FlexViewGroupColumns_FlexViews");
            });

            modelBuilder.Entity<FlexViewRoles>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FlexViewRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_FlexViewRoles_FlexRoles");
            });

            modelBuilder.Entity<FlexViews>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FromSql).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OrderSql).IsRequired();

                entity.Property(e => e.SelectSql).IsRequired();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FlexViewSortOrders>(entity =>
            {
                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.View)
                    .WithMany(p => p.FlexViewSortOrders)
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("FK_FlexViewSortOrders_FlexViews");
            });

            modelBuilder.Entity<SaleContactEmails>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Bussiness).HasMaxLength(100);

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.DateSend).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(100);
            });

            modelBuilder.Entity<SaleCustomerContacts>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.District).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.Province).HasMaxLength(150);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleCustomerContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SaleCustomerContacts_SaleCustomers");
            });

            modelBuilder.Entity<SaleCustomers>(entity =>
            {
                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaleDeliveries>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(20);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LicensePlate).HasMaxLength(20);

                entity.Property(e => e.TimeBegin).HasColumnType("datetime");

                entity.Property(e => e.TimeEnd).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleDistricts>(entity =>
            {
                entity.HasKey(e => e.DisId);

                entity.Property(e => e.DisId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DisName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.SaleDistricts)
                    .HasForeignKey(d => d.ProId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleDistricts_SaleProvinces");
            });

            modelBuilder.Entity<SaleFavouriteProducts>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleFavouriteProducts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SaleFavouriteProducts_SaleCustomers");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleFavouriteProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SaleFavouriteProducts_SaleProducts");
            });

            modelBuilder.Entity<SaleFiles>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FilePath).HasMaxLength(200);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleLocations>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .HasMaxLength(30);

                entity.Property(e => e.Driver).HasMaxLength(200);

                entity.Property(e => e.Latitude).HasMaxLength(30);

                entity.Property(e => e.LicensePlate).HasMaxLength(20);

                entity.Property(e => e.LocaltionId).HasColumnName("LocaltionID");

                entity.Property(e => e.LocationTime).HasColumnType("datetime");

                entity.Property(e => e.Longitude).HasMaxLength(30);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleMenus>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<SaleModules>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnType("nchar(10)");

                entity.HasOne(d => d.NewsCate)
                    .WithMany(p => p.SaleModules)
                    .HasForeignKey(d => d.NewsCateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleModules_SaleNewsCategories1");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.SaleModules)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleModules_SalePageNavs");

                entity.HasOne(d => d.VideosCate)
                    .WithMany(p => p.SaleModules)
                    .HasForeignKey(d => d.VideosCateId)
                    .HasConstraintName("FK_SaleModules_SaleVideos");
            });

            modelBuilder.Entity<SaleModulevsNewsCategory>(entity =>
            {
                entity.HasKey(e => new { e.ModuleId, e.CategoryId });

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleModulevsNewsCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SaleModulevsNewsCategory_SaleNewsCategories");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.SaleModulevsNewsCategory)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleModulevsNewsCategory_SaleModules");
            });

            modelBuilder.Entity<SaleNavigations>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.Url).HasMaxLength(200);

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.SaleNavigationsChild)
                    .HasForeignKey(d => d.ChildId)
                    .HasConstraintName("FK_SaleNavigations_SaleMenus1");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.SaleNavigationsMenu)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_SaleNavigations_SaleMenus");
            });

            modelBuilder.Entity<SaleNews>(entity =>
            {
                entity.Property(e => e.Avatar).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasMaxLength(250);

                entity.Property(e => e.Icon).HasMaxLength(200);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.NameUrl).HasMaxLength(400);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Viewer).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SaleNewsCategories>(entity =>
            {
                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Icon).HasMaxLength(300);

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.NameUrl)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'/')");

                entity.Property(e => e.PositionFrom)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PositionTo).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_SaleNewsCategories_SaleNewsCategories");

                entity.HasOne(d => d.PartialView)
                    .WithMany(p => p.SaleNewsCategories)
                    .HasForeignKey(d => d.PartialViewId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleNewsCategories_SalePartialViews");
            });

            modelBuilder.Entity<SaleNewsCategoriesImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.NewsCategory)
                    .WithMany(p => p.SaleNewsCategoriesImageList)
                    .HasForeignKey(d => d.NewsCategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleNewsCategoriesImageList_SaleNewsCategories");
            });

            modelBuilder.Entity<SaleNewsImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.News)
                    .WithMany(p => p.SaleNewsImageList)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_SaleNewsImageList_SaleNews");
            });

            modelBuilder.Entity<SaleNewsVsCategories>(entity =>
            {
                entity.HasKey(e => new { e.NewsId, e.CategoryId });

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleNewsVsCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SaleNewsVsCategories_SaleNewsCategories");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.SaleNewsVsCategories)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_SaleNewsVsCategories_SaleNews");
            });

            modelBuilder.Entity<SaleOptions>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleOptionValues>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.SaleOptionValues)
                    .HasForeignKey(d => d.OptionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleOptionValues_SaleOptions");
            });

            modelBuilder.Entity<SaleOrderDelivereds>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.SaleOrderDelivereds)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_SaleOrderDelivereds_SaleOrders");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.SaleOrderDelivereds)
                    .HasForeignKey(d => d.VariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleOrderDelivereds_SaleWareHouses");
            });

            modelBuilder.Entity<SaleOrderDetails>(entity =>
            {
                entity.Property(e => e.Name).HasColumnType("nchar(10)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.SaleOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_SaleOrderDetails_SaleOrders");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.SaleOrderDetails)
                    .HasForeignKey(d => d.VariantId)
                    .HasConstraintName("FK_SaleOrderDetails_SaleWareHouses");
            });

            modelBuilder.Entity<SaleOrderRefunds>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.SaleOrderRefunds)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_SaleOrderRefunds_SaleOrders");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.SaleOrderRefunds)
                    .HasForeignKey(d => d.VariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleOrderRefunds_SaleWareHouses");
            });

            modelBuilder.Entity<SaleOrders>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SaleOrders_SaleCustomers");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_SaleOrders_SalePayments");

                entity.HasOne(d => d.TransportFee)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.TransportFeeId)
                    .HasConstraintName("FK_SaleOrders_SaleTransportFees");
            });

            modelBuilder.Entity<SalePageLinks>(entity =>
            {
                entity.Property(e => e.ChildSqlQuery).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<SalePageNavs>(entity =>
            {
                entity.Property(e => e.ChildSqlQuery).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Url).HasMaxLength(200);
            });

            modelBuilder.Entity<SalePartialViews>(entity =>
            {
                entity.Property(e => e.Link).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SalePayments>(entity =>
            {
                entity.Property(e => e.AccessCode).HasMaxLength(100);

                entity.Property(e => e.AccountMerchant).HasMaxLength(100);

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.Guige).HasMaxLength(500);

                entity.Property(e => e.Icon).HasMaxLength(300);

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameMethod).HasMaxLength(200);
            });

            modelBuilder.Entity<SaleProductCategoriesImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.SaleProductCategoriesImageList)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_SaleProductCategoriesImageList_SaleProductCategorys");
            });

            modelBuilder.Entity<SaleProductCategorys>(entity =>
            {
                entity.Property(e => e.Avatar).HasMaxLength(400);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Icon).HasMaxLength(250);

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.MetaTitle).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameUrl).HasMaxLength(1000);

                entity.Property(e => e.ParentUrl).HasMaxLength(1000);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.ViewId).HasDefaultValueSql("((48))");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_SaleProductCategorys_SaleProductCategorys");

                entity.HasOne(d => d.PartialView)
                    .WithMany(p => p.SaleProductCategorys)
                    .HasForeignKey(d => d.PartialViewId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleProductCategorys_SalePartialViews");
            });

            modelBuilder.Entity<SaleProductImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleProductImageList)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SaleProductImageList_SaleProducts");
            });

            modelBuilder.Entity<SaleProducts>(entity =>
            {
                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ImageHover).HasMaxLength(300);

                entity.Property(e => e.MetaDescription).HasMaxLength(255);

                entity.Property(e => e.MetaKeywords).HasMaxLength(500);

                entity.Property(e => e.MetaTitle).HasMaxLength(255);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.NameUrl).HasMaxLength(300);

                entity.Property(e => e.Option1).HasMaxLength(50);

                entity.Property(e => e.Option2).HasMaxLength(50);

                entity.Property(e => e.Option3).HasMaxLength(50);

                entity.Property(e => e.Option4).HasMaxLength(50);

                entity.Property(e => e.Option5).HasMaxLength(50);

                entity.Property(e => e.Price1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Price2).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Price3).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.ViewId).HasDefaultValueSql("((48))");
            });

            modelBuilder.Entity<SaleProductTabs>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<SaleProductVsCategories>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryId });

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleProductVsCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SaleProductVsCategories_SaleProductCategorys");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleProductVsCategories)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SaleProductVsCategories_SaleProducts");
            });

            modelBuilder.Entity<SaleProductVsTabs>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.TabId });

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleProductVsTabs)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SaleProductVsTabs_SaleProducts");

                entity.HasOne(d => d.Tab)
                    .WithMany(p => p.SaleProductVsTabs)
                    .HasForeignKey(d => d.TabId)
                    .HasConstraintName("FK_SaleProductVsTabs_SaleProductTabs");
            });

            modelBuilder.Entity<SaleProvinces>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.Property(e => e.ProId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<SaleRecuitmentCategories>(entity =>
            {
                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameUrl).HasMaxLength(1000);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserRole).HasMaxLength(150);
            });

            modelBuilder.Entity<SaleRecuitmentCategoriesImageList>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TypeFile).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(250);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleRecuitmentCategoriesImageList)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SaleRecuitmentCategoriesImageList_SaleRecuitmentCategories");
            });

            modelBuilder.Entity<SaleRecuitmentCategoryVsUser>(entity =>
            {
                entity.HasOne(d => d.Recuitment)
                    .WithMany(p => p.SaleRecuitmentCategoryVsUser)
                    .HasForeignKey(d => d.RecuitmentId)
                    .HasConstraintName("FK_SaleRecuitmentCategoryVsUser_SaleRecuitmentCategories");
            });

            modelBuilder.Entity<SaleRecuitments>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.Avatar).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.NameUrl)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Phone).HasMaxLength(150);

                entity.Property(e => e.Province).HasMaxLength(150);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SaleRecuitmentsVsCategories>(entity =>
            {
                entity.HasKey(e => new { e.RecuitmentId, e.CategoryId });

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleRecuitmentsVsCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_SaleRecuitmentsVsCategories_SaleRecuitmentCategories");

                entity.HasOne(d => d.Recuitment)
                    .WithMany(p => p.SaleRecuitmentsVsCategories)
                    .HasForeignKey(d => d.RecuitmentId)
                    .HasConstraintName("FK_SaleRecuitmentsVsCategories_SaleRecuitments");
            });

            modelBuilder.Entity<SaleRefMenus>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(200);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefMenus)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefMenus_SaleMenus");
            });

            modelBuilder.Entity<SaleRefNavigations>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.Url).HasMaxLength(200);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefNavigations)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefNavigations_SaleNavigations");
            });

            modelBuilder.Entity<SaleRefNews>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Icon).HasMaxLength(300);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.NameUrl).HasMaxLength(400);

                entity.Property(e => e.Owner).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Year).HasMaxLength(250);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefNews)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefNews_SaleNews");
            });

            modelBuilder.Entity<SaleRefNewsCategories>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Icon).HasMaxLength(300);

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.NameUrl).HasMaxLength(400);

                entity.Property(e => e.SortOrder).HasDefaultValueSql("(N'/')");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefNewsCategories)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_RefNewsCategories_SaleNewsCategories");
            });

            modelBuilder.Entity<SaleRefNewsCategoriesImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.SaleRefNewsCategories)
                    .WithMany(p => p.SaleRefNewsCategoriesImageList)
                    .HasForeignKey(d => new { d.RefNewsCategoryId, d.LanguageId })
                    .HasConstraintName("FK_SaleRefNewsCategoriesImageList_SaleRefNewsCategories");
            });

            modelBuilder.Entity<SaleRefNewsImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.SaleRefNews)
                    .WithMany(p => p.SaleRefNewsImageList)
                    .HasForeignKey(d => new { d.RefNewsId, d.LanguageId })
                    .HasConstraintName("FK_SaleRefNewsImageList_SaleRefNews");
            });

            modelBuilder.Entity<SaleRefOptions>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefOptions)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefOptions_SaleOptions1");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SaleRefOptions)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SaleRefOptions_FlexLanguages");
            });

            modelBuilder.Entity<SaleRefOptionValues>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefOptionValues)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefOptionValues_SaleOptionValues");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SaleRefOptionValues)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SaleRefOptionValues_FlexLanguages");
            });

            modelBuilder.Entity<SaleRefProductCategoriesImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.SaleRefProductsCatetories)
                    .WithMany(p => p.SaleRefProductCategoriesImageList)
                    .HasForeignKey(d => new { d.RefProductCategoryId, d.LanguageId })
                    .HasConstraintName("FK_SaleRefProductCategoriesImageList_SaleRefProductsCatetories");
            });

            modelBuilder.Entity<SaleRefProductImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.SaleRefProducts)
                    .WithMany(p => p.SaleRefProductImageList)
                    .HasForeignKey(d => new { d.RefProductId, d.LanguageId })
                    .HasConstraintName("FK_SaleRefProductImageList_SaleRefProducts");
            });

            modelBuilder.Entity<SaleRefProducts>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImageHover).HasMaxLength(300);

                entity.Property(e => e.MadeIn).HasMaxLength(200);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameUrl).HasMaxLength(300);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefProducts)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefProducts_SaleProducts");
            });

            modelBuilder.Entity<SaleRefProductsCatetories>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Avatar).HasMaxLength(400);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameUrl).HasMaxLength(400);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefProductsCatetories)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefProductCatetories_SaleProductCategorys");
            });

            modelBuilder.Entity<SaleRefRecuitmentCategories>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.NameUrl).HasMaxLength(400);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefRecuitmentCategories)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleRefRecuitmentCategories_SaleRecuitmentCategories");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SaleRefRecuitmentCategories)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleRefRecuitmentCategories_FlexLanguages");
            });

            modelBuilder.Entity<SaleRefRecuitmentCategoriesImageList>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.SaleRefRecuitmentCategories)
                    .WithMany(p => p.SaleRefRecuitmentCategoriesImageList)
                    .HasForeignKey(d => new { d.RefCategoryId, d.LanguageId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleRefRecuitmentCategoriesImageList_SaleRefRecuitmentCategories");
            });

            modelBuilder.Entity<SaleRefRecuitments>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.NameUrl).HasMaxLength(400);

                entity.Property(e => e.Phone).HasMaxLength(150);

                entity.Property(e => e.Province).HasMaxLength(150);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefRecuitments)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefRecuitments_SaleRecuitments");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SaleRefRecuitments)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SaleRefRecuitments_FlexLanguages");
            });

            modelBuilder.Entity<SaleRefVideoLists>(entity =>
            {
                entity.Property(e => e.Icon).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.HasOne(d => d.SaleRefVideos)
                    .WithMany(p => p.SaleRefVideoLists)
                    .HasForeignKey(d => new { d.VideoId, d.LanguageId })
                    .HasConstraintName("FK_SaleRefVideoLists_SaleRefVideos");
            });

            modelBuilder.Entity<SaleRefVideos>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LinkImage).HasMaxLength(300);

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.NameUrl).HasMaxLength(400);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefVideos)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefVideos_SaleVideos1");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SaleRefVideos)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SaleRefVideos_FlexLanguages");
            });

            modelBuilder.Entity<SaleRefWareHouses>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LanguageId });

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SaleRefWareHouses)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_SaleRefWareHouses_SaleWareHouses");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SaleRefWareHouses)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SaleRefWareHouses_FlexLanguages");

                entity.HasOne(d => d.ProductImage)
                    .WithMany(p => p.SaleRefWareHouses)
                    .HasForeignKey(d => d.ProductImageId)
                    .HasConstraintName("FK_SaleRefWareHouses_SaleRefProductImageList");
            });

            modelBuilder.Entity<SaleResumes>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Avatar).HasMaxLength(150);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Cvattact)
                    .HasColumnName("CVAttact")
                    .HasMaxLength(150);

                entity.Property(e => e.DateSend).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Experience).HasMaxLength(100);

                entity.Property(e => e.FileAttact).HasMaxLength(150);

                entity.Property(e => e.Money).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.Qualification).HasMaxLength(100);
            });

            modelBuilder.Entity<SaleTransportFees>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.NameMethod).HasMaxLength(150);

                entity.Property(e => e.PriceTransport).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<SaleTransports>(entity =>
            {
                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.KeyApi)
                    .HasColumnName("KeyAPI")
                    .HasMaxLength(50);

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Readmore).HasMaxLength(100);
            });

            modelBuilder.Entity<SaleVideos>(entity =>
            {
                entity.Property(e => e.Avatar).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.MetaKeywords).HasMaxLength(250);

                entity.Property(e => e.MetaTitle).HasMaxLength(300);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.NameUrl).HasMaxLength(400);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Viewer).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SaleVideosList>(entity =>
            {
                entity.Property(e => e.Icon).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(250);

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.SaleVideosList)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleVideosList_SaleVideos");
            });

            modelBuilder.Entity<SaleVideovsNewsCategory>(entity =>
            {
                entity.HasKey(e => new { e.VideoId, e.NewsCategory });

                entity.HasOne(d => d.NewsCategoryNavigation)
                    .WithMany(p => p.SaleVideovsNewsCategory)
                    .HasForeignKey(d => d.NewsCategory)
                    .HasConstraintName("FK_SaleVideovsNewsCategory_SaleNewsCategories");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.SaleVideovsNewsCategory)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_SaleVideovsNewsCategory_SaleVideos");
            });

            modelBuilder.Entity<SaleWards>(entity =>
            {
                entity.HasKey(e => e.WardId);

                entity.Property(e => e.WardId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DisId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.WardName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SaleWareHouseDetails>(entity =>
            {
                entity.HasOne(d => d.OptionValue)
                    .WithMany(p => p.SaleWareHouseDetails)
                    .HasForeignKey(d => d.OptionValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleWareHouseDetails_SaleOptionValues");

                entity.HasOne(d => d.WareHouse)
                    .WithMany(p => p.SaleWareHouseDetails)
                    .HasForeignKey(d => d.WareHouseId)
                    .HasConstraintName("FK_SaleWareHouseDetails_SaleWareHouses");
            });

            modelBuilder.Entity<SaleWareHouses>(entity =>
            {
                entity.Property(e => e.Barcode).HasMaxLength(255);

                entity.Property(e => e.IsVat).HasColumnName("IsVAT");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PriceSale).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleWareHouses)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_SaleWareHouses_SaleProducts");

                entity.HasOne(d => d.ProductImage)
                    .WithMany(p => p.SaleWareHouses)
                    .HasForeignKey(d => d.ProductImageId)
                    .HasConstraintName("FK_SaleWareHouses_SaleProductImageList");
            });

            modelBuilder.Entity<SaleWebImages>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DescriptionEng).HasMaxLength(500);

                entity.Property(e => e.Link).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.PageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.TitleEnglish).HasMaxLength(200);

                entity.HasOne(d => d.PageCodeNavigation)
                    .WithMany(p => p.SaleWebImages)
                    .HasForeignKey(d => d.PageCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleWebImages_SaleWebPages");

                entity.HasOne(d => d.PositionCodeNavigation)
                    .WithMany(p => p.SaleWebImages)
                    .HasForeignKey(d => d.PositionCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleWebImages_SaleWebPagePositions");
            });

            modelBuilder.Entity<SaleWebPagePositions>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ButtonEng).HasMaxLength(100);

                entity.Property(e => e.ButtonName).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DescriptionEng)
                    .HasColumnName("Description_eng")
                    .HasMaxLength(500);

                entity.Property(e => e.Link).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.TitleEng)
                    .HasColumnName("Title_eng")
                    .HasMaxLength(250);

                entity.HasOne(d => d.PageCodeNavigation)
                    .WithMany(p => p.SaleWebPagePositions)
                    .HasForeignKey(d => d.PageCode)
                    .HasConstraintName("FK_SaleWebPagePositions_SaleWebPages");
            });

            modelBuilder.Entity<SaleWebPages>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.View).HasMaxLength(200);
            });

            modelBuilder.Entity<SystemAuditLogs>(entity =>
            {
                entity.Property(e => e.AfterValue).HasMaxLength(500);

                entity.Property(e => e.BeforeValue).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Operator).HasMaxLength(255);
            });
        }
        
    }
}
