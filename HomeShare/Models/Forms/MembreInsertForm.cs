using HoliDayRental.BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HoliDayRental.Models.Forms
{
    public class MembreInsertForm
    {
        private int _idMembre;
        private string _nom;
        private string _prenom;
        private string _email;
        private int _pays;
        private string _telephone;
        private string _login;
        private string _password;
        private string _rePassword;
        private List<SelectListItem> _listPays;

        [HiddenInput(DisplayValue = false)]
        [ScaffoldColumn(false)]
        public int IdMembre { get => _idMembre; set => _idMembre = value; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string Nom { get => _nom; set => _nom = value; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string Prenom { get => _prenom; set => _prenom = value; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(256)]
        [EmailAddress(ErrorMessage ="L'email n'est pas valide")]
        public string Email { get => _email; set => _email = value; }
        [Required]
        public int Pays { get => _pays; set => _pays = value; }
        [Required]
        [MaxLength(20)]
        public string Telephone { get => _telephone; set => _telephone = value; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Login { get => _login; set => _login = value; }
        [Required]
        [MaxLength(256)]
        [MinLength(10)]
        [RegularExpression("^(?=(?:.*[A-Z]){3})(?=(?:.*[^a-zA-Z]){4})")]
        [Compare(nameof(RePassword), ErrorMessage = "Les mots de passe ne correspondent pas")]
        public string Password { get => _password; set => _password = value; }
        [Required]
        [MaxLength(256)]
        [MinLength(10)]
        [RegularExpression("^(?=(?:.*[A-Z]){3})(?=(?:.*[^a-zA-Z]){4})")]
        [Compare(nameof(RePassword), ErrorMessage = "Les mots de passe ne correspondent pas")]
        public string RePassword { get => _rePassword; set => _rePassword = value; }
        public List<SelectListItem> ListPays { get => _listPays; set => _listPays = value; }
    }
}
