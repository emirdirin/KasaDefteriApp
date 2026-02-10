using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasaDefteriApp.Models;
using Microsoft.EntityFrameworkCore;

namespace KasaDefteriApp.Data
{
    public class KasaDbContext : DbContext
    {
        // Tables
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<Islem> Islemler { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        // --- 1. Bağlantı Ayarları ---
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQLite bağlantı dizesi
            // 🎉 KRİTİK DÜZELTME: Foreign Keys=True parametresini ekleyerek 
            // veri bütünlüğü kısıtlamalarını (constraint) etkinleştiriyoruz.
            optionsBuilder.UseSqlite("Data Source=KasaDefteri.db;Foreign Keys=True");
        }

        // --- 2. Model İlişkileri ve Kısıtlamaları ---
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 🎉 Basamaklı Silme (Cascade Delete) Ayarı
            // Kasa (Parent) ve Islem (Child) arasındaki ilişkiyi yapılandırıyoruz.
            modelBuilder.Entity<Islem>()
                // İşlemin tek bir Kasası vardır (Many to One)
                .HasOne(i => i.Kasa)
                // Kasanın birden çok İşlemi vardır
                .WithMany(k => k.Islems)
                // Foreign Key sütunu
                .HasForeignKey(i => i.KasaID)
                // KASA SİLİNDİĞİNDE: Bu Kasaya ait tüm İşlemleri de otomatik olarak sil (Basamaklı Silme).
                // Bu, yetim kayıt kalmasını ve hatalı veri oluşumunu engeller.
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
