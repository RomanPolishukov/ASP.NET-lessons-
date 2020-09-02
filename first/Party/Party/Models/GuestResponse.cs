using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Party.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Введите имя!!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите почту!!!")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Почта введена не верно")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Введите ноиер телефона!!!")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Пожалуйста, уточните, будете ли вы присутствовать")]
        public bool? WillAttend { get; set; }
    }
}
