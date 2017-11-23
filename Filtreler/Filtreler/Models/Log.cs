using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filtreler.Models
{
    [Table("Logs")]
    public class Log
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, DisplayName("İşlem Tarihi")]
        public DateTime Tarih { get; set; }

        [Required, StringLength(25), DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [StringLength(100), DisplayName("Action Name")]
        public string ActionName { get; set; }

        [StringLength(100), DisplayName("ControllerName")]
        public string ControllerName { get; set; }

        [StringLength(250), DisplayName("Bilgi")]
        public string Bilgi { get; set; }

    }
}